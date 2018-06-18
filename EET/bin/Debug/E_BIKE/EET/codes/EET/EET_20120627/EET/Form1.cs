using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;
using System.Xml;
using System.IO;
using System.IO.Ports;
using System.Collections;

namespace EET
{
    public partial class Form1 : Form
    {
        #region --变量定义--

        // g  代表全局变量  global
        // s  代表静态变量  static
        // s  代表字符串    string

        // 变量新增的流程如下
        // 1.变量定义       D P
        // 2.变量初始化     I P
        // 保存变量
        // 3.界面到变量     U T P
        // 4.变量到配置     P T C
        // 读取变量
        // 5.配置到变量     C T P
        // 6.变量到界面     P T U
        // 7.回读校验       R B C

        // D P
        #region ----参数设定区----

        // 电机相序值
        public static string gss_MotorSequence = "0";
        // 霍尔相位差值
        public static string gss_HallPhaseValue = "0";
        // 调速范围上限值
        public static string gss_SpeedUpperBound = "214";
        // 调速范围下限值
        public static string gss_SpeedLowerBound = "56";
        // 防飞车保护上限值
        public static string gss_ProtectionUpperBound = "230";
        // 防飞车保护下限值
        public static string gss_ProtectionLowerBound = "41";
        // 相电流峰值
        public static string gss_PhaseCurrentPeak = "157";
        // 电池容量值
        public static string gss_BatteryType = "0";
        // 电池过压值
        public static string gss_BatteryMaximumVoltage = "180";
        // 电池欠压值
        public static string gss_BatteryMinimumVoltage = "142";
        // 36V电池过压值
        public static string gss_BatteryMaximumVoltage_36V = "137";
        // 36V电池欠压值
        public static string gss_BatteryMinimumVoltage_36V = "100";
        // 堵转保护电流值
        public static string gss_LockedRotorProtectionCurrentValue = "104";
        // 限速线分压系数
        public static string gss_SpeedLimitVoltageDivideCoefficient = "17";

        #endregion

        #region ----功能选择区----

        // 限速限流选择
        public static string gss_SpeedAndAmpereLimit_Select = "false";
        // 限速限流 无限速 限速值 提速
        public static string gss_SNLAccelerationSpeed = "112";
        // 限速限流 无限速 限速值 高速
        public static string gss_SNLHighSpeed = "102";
        // 限速限流 无限速 限速值 中速
        public static string gss_SNLMidSpeed = "80";
        // 限速限流 无限速 限速值 低速
        public static string gss_SNLLowSpeed = "52";
        // 限速限流 无限速 限流值 提速
        public static string gss_SNLAccelerationAmpere = "157";
        // 限速限流 无限速 限流值 高速
        public static string gss_SNLHighAmpere = "141";
        // 限速限流 无限速 限流值 中速
        public static string gss_SNLMidAmpere = "120";
        // 限速限流 无限速 限流值 低速
        public static string gss_SNLLowAmpere = "99";
        // 限速限流 有限速 限速值 提速
        public static string gss_SLAccelerationSpeed = "68";
        // 限速限流 有限速 限速值 高速
        public static string gss_SLHighSpeed = "61";
        // 限速限流 有限速 限速值 中速
        public static string gss_SLMidSpeed = "48";
        // 限速限流 有限速 限速值 低速
        public static string gss_SLLowSpeed = "32";
        // 限速限流 有限速 限流值 提速
        public static string gss_SLAccelerationAmpere = "115";
        // 限速限流 有限速 限流值 高速
        public static string gss_SLHighAmpere = "104";
        // 限速限流 有限速 限流值 中速
        public static string gss_SLMidAmpere = "93";
        // 限速限流 有限速 限流值 低速
        public static string gss_SLLowAmpere = "83";

        // 巡航功能选择
        public static string gss_Cruise_Select = "false";
        // 巡航功能
        public static string gss_Cruise = "0";

        // 电动巡航助力转换选择
        public static string gss_CruiseSwitch_Select = "false";
        // 电动巡航助力转换
        public static string gss_CruiseSwitch = "0";

        // 自动巡航手柄稳定时间选择
        public static string gss_AutoHoldTime_Select = "false";
        // 自动巡航手柄稳定时间
        public static string gss_AutoHoldTime = "80";

        // 手动巡航按键保持时间选择
        public static string gss_ManualHoldTime_Select = "false";
        // 手动巡航按键保持时间
        public static string gss_ManualHoldTime = "40";

        // 助力功能选择
        public static string gss_Boost_Select = "false";
        // 助力功能
        public static string gss_Boost = "0";

        // 三态显示选择
        public static string gss_ThreeStatusShowSwitch_Select = "false";
        // 三态显示
        public static string gss_ThreeStatusShowSwitch = "0";

        // 模拟速度显示选择
        public static string gss_SimulationSpeedShow_Select = "false";
        // 模拟速度显示
        public static string gss_SimulationSpeedShow = "10";

        // 模拟电流显示选择
        public static string gss_SimulationCurrentShow_Select = "false";
        // 模拟电流显示
        public static string gss_SimulationCurrentShow = "50";

        // 刹车功能选择
        public static string gss_Braking_Select = "false";
        // 刹车功能
        public static string gss_Braking = "0";

        // 多速实现选择
        public static string gss_MoreSpeed_Select = "false";
        // 多速实现
        public static string gss_MoreSpeed = "0";


        //
        // 最新更新的参数，根据文档增加
        //
        // 电机型号
        public static string gss_MotorType_Select = "false";
        public static string gss_MotorType = "0";
        // 启动方式
        public static string gss_StartStyle = "0";
        // 刹车力度
        public static string gss_BrakingPotency = "0";
        // 堵转降流
        public static string gss_LockedRotorCurrentDrop_Select = "false";
        public static string gss_LockedRotorCurrentDrop = "0";
        // 松手刹防飞车
        public static string gss_HandBrakeOverrun_Select = "false";
        public static string gss_HandBrakeOverrun = "0";
        // 滑行反充电
        public static string gss_SlideCharge_Select = "false";
        public static string gss_SlideCharge = "0";


        #endregion

        #region ----隐藏的变量----

        // 霍尔边沿1角度值
        public static string gss_HallForwardAngle_1 = "0";
        // 霍尔边沿2角度值
        public static string gss_HallForwardAngle_2 = "0";
        // 霍尔边沿3角度值
        public static string gss_HallForwardAngle_3 = "0";
        // 霍尔边沿4角度值
        public static string gss_HallForwardAngle_4 = "0";
        // 霍尔边沿5角度值
        public static string gss_HallForwardAngle_5 = "0";
        // 霍尔边沿6角度值
        public static string gss_HallForwardAngle_6 = "0";
        // 霍尔反向边沿1角度值
        public static string gss_HallReverseAngle_1 = "0";
        // 霍尔反向边沿2角度值
        public static string gss_HallReverseAngle_2 = "0";
        // 霍尔反向边沿3角度值
        public static string gss_HallReverseAngle_3 = "0";
        // 霍尔反向边沿4角度值
        public static string gss_HallReverseAngle_4 = "0";
        // 霍尔反向边沿5角度值
        public static string gss_HallReverseAngle_5 = "0";
        // 霍尔反向边沿6角度值
        public static string gss_HallReverseAngle_6 = "0";
        // 管
        public static string gss_Pipe = "0";

        #endregion

        #region --按钮的使能--
        // “保存到文档”按钮的使能记录
        private bool Save_button_SavedFlag = true;
        // “读取目标配置”按钮的使能记录
        private bool UpLoad_button_SavedFlag = true;
        // “生成配置”按钮的使能记录
        //private bool Generation_button_SavedFlag = true;
        // “下载配置到目标”按钮的使能记录
        //private bool DownLoad_button_SavedFlag = true;
        #endregion

        #endregion

        #region --窗体加载--

        // 初始化窗体内容
        public Form1()
        {
            InitializeComponent();
        }

        // 窗体加载
        private void Form1_Load(object sender, EventArgs e)
        {
            // 取消最大化
            //this.ControlBox = false;
            this.MaximizeBox = false;
            // 第一个变量控件获取焦点
            comboBox_MotorSequence.Focus();

            /**************************************************************/
            /******************** 设置comboBox的默认值 ********************/
            /**************************************************************/

            // 默认电机相序
            comboBox_MotorSequence.Text = comboBox_MotorSequence.Items[0].ToString();
            // 默认霍尔角度
            comboBox_HallPhaseValue.Text = comboBox_HallPhaseValue.Items[0].ToString();
            // 默认电池额定电压
            comboBox_BatteryType.Text = comboBox_BatteryType.Items[0].ToString();
            // 默认巡航功能
            comboBox_Cruise.Text = comboBox_Cruise.Items[0].ToString();
            // 默认巡航助力转换
            comboBox_CruiseSwitch.Text = comboBox_CruiseSwitch.Items[0].ToString();
            // 默认助力功能
            comboBox_Boost.Text = comboBox_Boost.Items[0].ToString();
            // 默认三态显示
            comboBox_ThreeStatusShowSwitch.Text = comboBox_ThreeStatusShowSwitch.Items[0].ToString();
            // 默认电子刹车功能
            comboBox_Braking.Text = comboBox_Braking.Items[0].ToString();
            // 默认多速
            comboBox_MoreSpeed.Text = comboBox_MoreSpeed.Items[0].ToString();
            // 默认管数
            comboBox_Pipe.Text = comboBox_Pipe.Items[0].ToString();

            // 增加但未加入保存为变量及添加入配置中
            // 霍尔有无 （默认有）
            comboBox_Hall.Text = comboBox_Hall.Items[1].ToString();
            // 默认电机极数
            comboBox_MotorSeries.Text = comboBox_MotorSeries.Items[0].ToString();
            // 默认共阴共阳
            comboBox_SamePolarity.Text = comboBox_SamePolarity.Items[0].ToString();

            // 新增第一波 comboBox
            // 默认电机型号
            comboBox_MotorType.Text = comboBox_MotorType.Items[0].ToString();
            // 默认堵转降流
            comboBox_LockedRotorCurrentDrop.Text = comboBox_LockedRotorCurrentDrop.Items[0].ToString();
            // 默认松手刹防飞车
            comboBox_HandBrakeOverrun.Text = comboBox_HandBrakeOverrun.Items[0].ToString();
            // 默认滑行反充电
            comboBox_SlideCharge.Text = comboBox_SlideCharge.Items[0].ToString();


            /**************************************************************/
            /******************** 设置checkBox的默认值 ********************/
            /**************************************************************/

            // 设置checkBox为非选定
            // 默认限速限流选择
            checkBox_SpeedAndAmpereLimit_Select.Checked = false;
            // 默认巡航功能选择
            checkBox_Cruise_Select.Checked = false;
            // 默认巡航助力转换选择
            checkBox_CruiseSwitch_Select.Checked = false;
            // 默认自动巡航手柄稳定时间选择
            checkBox_AutoHoldTime_Select.Checked = false;
            // 默认手动巡航按键保持时间选择
            checkBox_ManualHoldTime_Select.Checked = false;
            // 默认助力选择
            checkBox_Boost_Select.Checked = false;
            // 默认三态显示选择
            checkBox_ThreeStatusShowSwitch_Select.Checked = false;
            // 默认模拟速度选择
            checkBox_SimulationSpeedShow_Select.Checked = false;
            // 默认模拟电流选择
            checkBox_SimulationCurrentShow_Select.Checked = false;
            // 默认电子刹车选择
            checkBox_Braking_Select.Checked = false;
            // 默认多速选择
            checkBox_MoreSpeed_Select.Checked = false;

            // 新增第一波 checkBox
            // 默认电机型号选择
            checkBox_MotorType_Select.Checked = false;
            // 默认堵转降流选择
            checkBox_LockedRotorCurrentDrop_Select.Checked = false;
            // 默认松手刹防飞车选择
            checkBox_HandBrakeOverrun_Select.Checked = false;
            // 默认滑行反充电
            checkBox_SlideCharge_Select.Checked = false;
        }

        #endregion

        #region --按钮事件--

        // 从文件加载配置按钮事件
        private void toolStripMenuItem_Open_Click(object sender, EventArgs e)
        {
            // 获得应用程序的路径
            EET_openFileDialog.InitialDirectory = Application.StartupPath;
            EET_openFileDialog.ShowDialog();
        }

        // openFileDialog的OK按钮事件
        private void EET_openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            //打开配置文件
            try
            {
                // 禁止界面
                this.Enabled = false;

                OpenFile.OpenConfigurationFile(this, EET_openFileDialog.FileName);

                // 使能界面
                this.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // 使能界面
                this.Enabled = true;
            }
        }

        // 保存配置到文件按钮事件
        private void toolStripMenuItem_Save_Click(object sender, EventArgs e)
        {

            // 禁止读取目标配置按钮
            toolStripMenuItem_UpLoad.Enabled = false;

            // 调用计算的方法，生成修改后的的变量
            GenerateParameters.UIToParameters(this);

            // 使能“下载配置到目标”的按钮
            toolStripMenuItem_DownLoad.Enabled = true;
            // 使能“保存配置到文档”按钮
            toolStripMenuItem_Save.Enabled = true;
            // 使能“读取控制器配置”按钮
            toolStripMenuItem_DownLoad.Enabled = true;


            // 获得应用程序的路径
            EET_saveFileDialog.InitialDirectory = Application.StartupPath;
            EET_saveFileDialog.FileName = "EET_" + System.DateTime.Now.ToString("yyyyMMdd_HHmmss");
            EET_saveFileDialog.ShowDialog();
        }

        // saveFileDialog的OK按钮事件
        private void EET_saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            //打开配置文件
            try
            {
                SaveFile.ParametersToConfiguration(this, EET_saveFileDialog.FileName);
                // 保存后，禁止保存按钮
                //toolStripMenuItem_Save.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // 打开程序的文件夹
        private void toolStripMenuItem_SaveFloder_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", Application.StartupPath);
        }

        // 退出按钮的事件
        private void toolStripMenuItem_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.ExitThread();
        }
        
        // 从控制器读取配置
        private void toolStripMenuItem_UpLoad_Click(object sender, EventArgs e)
        {
        }

        // 下载配置到控制器
        private void toolStripMenuItem_DownLoad_Click(object sender, EventArgs e)
        {

            // 禁止读取目标配置按钮
            toolStripMenuItem_UpLoad.Enabled = false;

            // 调用计算的方法，生成修改后的的变量
            GenerateParameters.UIToParameters(this);

            // 使能“下载配置到目标”的按钮
            toolStripMenuItem_DownLoad.Enabled = true;
            // 使能“保存到文档”按钮
            toolStripMenuItem_Save.Enabled = true;
            // 使能“读取目标配置”按钮
            toolStripMenuItem_UpLoad.Enabled = true;


            // 需要再次生成后才能下载配置到目标
            //toolStripMenuItem_DownLoad.Enabled = false;

            // “保存到文档”按钮的使能记录
            Save_button_SavedFlag = toolStripMenuItem_Save.Enabled;
            // “读取目标配置”按钮的使能记录
            UpLoad_button_SavedFlag = toolStripMenuItem_UpLoad.Enabled;

            // 电机下载配置到目标按钮后，禁止所有其他操作
            this.ControlBox = false;
            EET_myToolStripFocus.Enabled = false;
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            toolStripMenuItem_Save.Enabled = false;
            toolStripMenuItem_UpLoad.Enabled = false;

            // 显示进度条
            toolStripProgressBar1.Visible = true;
            // 测试ProgressBar
            for (; toolStripProgressBar1.Value < 100; )//循环
            {
                // 暂停1秒
                System.Threading.Thread.Sleep(20);
                // 让进度条增加一次
                toolStripProgressBar1.Value += toolStripProgressBar1.Step;
                // 如果进度条满后，退出循环，清空进度条，并隐藏进度条
                if (toolStripProgressBar1.Value >= 100)
                {
                    System.Threading.Thread.Sleep(1000);
                    toolStripProgressBar1.Visible = false;
                    toolStripProgressBar1.Value = 0;
                    break;
                }
            }

            // 点击事件完成后，使能所有其他操作
            this.ControlBox = true;
            this.MaximizeBox = false;
            EET_myToolStripFocus.Enabled = true;
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            toolStripMenuItem_Save.Enabled = Save_button_SavedFlag;
            toolStripMenuItem_UpLoad.Enabled = UpLoad_button_SavedFlag;
        }

        // 帮助文档
        private void toolStripMenuItem_HelpFile_Click(object sender, EventArgs e)
        {
            HelpFile EET_HelpFile = new HelpFile();
            EET_HelpFile.Show();
        }

        // 关于
        private void toolStripMenuItem_About_Click(object sender, EventArgs e)
        {
            About EET_About = new About();
            EET_About.ShowDialog();
        }

        // 隐藏的框体“限速线分压系数”的双击文字全选事件 
        private void myTextBoxNUM_SpeedLimitVoltageDivideCoefficient_Lable_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // 双击显示的文字：限速线分压系数
            //myTextBoxNUM_SpeedLimitVoltageDivideCoefficient_Lable.Text = "限速线分压系数";
            // 选择所有文字
            //myTextBoxNUM_SpeedLimitVoltageDivideCoefficient_Lable.SelectAll();
            // 使能隐藏的输入框体
            //myTextBoxNUM_SpeedLimitVoltageDivideCoefficient.Enabled = true;
            //myTextBoxNUM_SpeedLimitVoltageDivideCoefficient.Visible = true;
        }

        //// 生成配置按钮
        //private void Generation_button_Click(object sender, EventArgs e)
        //{
        //    // 禁止读取目标配置按钮
        //    toolStripMenuItem_UpLoad.Enabled = false;
        //
        //    // 调用计算的方法，生成修改后的的变量
        //    GenerateParameters.UIToConfiguration(this);
        //
        //    // 使能“下载配置到目标”的按钮
        //    toolStripMenuItem_DownLoad.Enabled = true;
        //    // 使能“保存到文档”按钮
        //    toolStripMenuItem_Save.Enabled = true;
        //    // 使能“读取目标配置”按钮
        //    toolStripMenuItem_DownLoad.Enabled = true;
        //}

        // 下载配置到目标
        private void DownLoad_button_Click(object sender, EventArgs e)
        {
            // 需要再次生成后才能下载配置到目标
            toolStripMenuItem_DownLoad.Enabled = false;

            // “保存到文档”按钮的使能记录
            Save_button_SavedFlag = toolStripMenuItem_Save.Enabled;
            // “读取目标配置”按钮的使能记录
            UpLoad_button_SavedFlag = toolStripMenuItem_UpLoad.Enabled;

            // 电机下载配置到目标按钮后，禁止所有其他操作
            this.ControlBox = false;
            EET_myToolStripFocus.Enabled = false;
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            toolStripMenuItem_Save.Enabled = false;
            toolStripMenuItem_UpLoad.Enabled = false;

            // 显示进度条
            toolStripProgressBar1.Visible = true;
            // 测试ProgressBar
            for (; toolStripProgressBar1.Value < 100; )//循环
            {
                // 暂停1秒
                System.Threading.Thread.Sleep(20);
                // 让进度条增加一次
                toolStripProgressBar1.Value += toolStripProgressBar1.Step;
                // 如果进度条满后，退出循环，清空进度条，并隐藏进度条
                if (toolStripProgressBar1.Value >= 100)
                {
                    System.Threading.Thread.Sleep(1000);
                    toolStripProgressBar1.Visible = false;
                    toolStripProgressBar1.Value = 0;
                    break;
                }
            }

            // 点击事件完成后，使能所有其他操作
            this.ControlBox = true;
            this.MaximizeBox = false;
            EET_myToolStripFocus.Enabled = true;
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            toolStripMenuItem_Save.Enabled = Save_button_SavedFlag;
            toolStripMenuItem_UpLoad.Enabled = UpLoad_button_SavedFlag;
        }

        #endregion

        #region --选框事件--

        // 限速限流 CheckBox
        private void checkBox_SpeedAndAmpereLimit_Select_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_SpeedAndAmpereLimit_Select.Checked == true)
            {
                myTextBoxNUM_SNLAccelerationSpeed.Enabled = true;
                myTextBoxNUM_SNLHighSpeed.Enabled = true;
                myTextBoxNUM_SNLMidSpeed.Enabled = true;
                myTextBoxNUM_SNLLowSpeed.Enabled = true;
                myTextBoxNUM_SNLAccelerationAmpere.Enabled = true;
                myTextBoxNUM_SNLHighAmpere.Enabled = true;
                myTextBoxNUM_SNLMidAmpere.Enabled = true;
                myTextBoxNUM_SNLLowAmpere.Enabled = true;
                myTextBoxNUM_SLAccelerationSpeed.Enabled = true;
                myTextBoxNUM_SLHighSpeed.Enabled = true;
                myTextBoxNUM_SLMidSpeed.Enabled = true;
                myTextBoxNUM_SLLowSpeed.Enabled = true;
                myTextBoxNUM_SLAccelerationAmpere.Enabled = true;
                myTextBoxNUM_SLHighAmpere.Enabled = true;
                myTextBoxNUM_SLMidAmpere.Enabled = true;
                myTextBoxNUM_SLLowAmpere.Enabled = true;
            }
            else
            {
                myTextBoxNUM_SNLAccelerationSpeed.Enabled = false;
                myTextBoxNUM_SNLHighSpeed.Enabled = false;
                myTextBoxNUM_SNLMidSpeed.Enabled = false;
                myTextBoxNUM_SNLLowSpeed.Enabled = false;
                myTextBoxNUM_SNLAccelerationAmpere.Enabled = false;
                myTextBoxNUM_SNLHighAmpere.Enabled = false;
                myTextBoxNUM_SNLMidAmpere.Enabled = false;
                myTextBoxNUM_SNLLowAmpere.Enabled = false;
                myTextBoxNUM_SLAccelerationSpeed.Enabled = false;
                myTextBoxNUM_SLHighSpeed.Enabled = false;
                myTextBoxNUM_SLMidSpeed.Enabled = false;
                myTextBoxNUM_SLLowSpeed.Enabled = false;
                myTextBoxNUM_SLAccelerationAmpere.Enabled = false;
                myTextBoxNUM_SLHighAmpere.Enabled = false;
                myTextBoxNUM_SLMidAmpere.Enabled = false;
                myTextBoxNUM_SLLowAmpere.Enabled = false;
            }
        }

        // 巡航功能 CheckBox
        private void checkBox_Cruise_Select_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Cruise_Select.Checked == true)
            {
                comboBox_Cruise.Enabled = true;
            }
            else
            {
                comboBox_Cruise.Enabled = false;
            }
        }

        // 电动巡航助力转换 CheckBox
        private void checkBox_CruiseSwitch_Select_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_CruiseSwitch_Select.Checked == true)
            {
                comboBox_CruiseSwitch.Enabled = true;
            }
            else
            {
                comboBox_CruiseSwitch.Enabled = false;
            }
        }

        // 自动巡航手柄稳定时间 CheckBox
        private void checkBox_AutoHoldTime_Select_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_AutoHoldTime_Select.Checked == true)
            {
                myTextBoxNUM_AutoHoldTime.Enabled = true;
            }
            else
            {
                myTextBoxNUM_AutoHoldTime.Enabled = false;
            }
        }

        // 手动巡航按键保持时间 CheckBox
        private void checkBox_ManualHoldTime_Select_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ManualHoldTime_Select.Checked == true)
            {
                myTextBoxNUM_ManualHoldTime.Enabled = true;
            }
            else
            {
                myTextBoxNUM_ManualHoldTime.Enabled = false;
            }
        }

        // 助力功能 CheckBox
        private void checkBox_Boost_Select_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Boost_Select.Checked == true)
            {
                comboBox_Boost.Enabled = true;
            }
            else
            {
                comboBox_Boost.Enabled = false;
            }
        }

        // 三态显示 CheckBox
        private void checkBox_ThreeStatusShowSwitch_Select_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ThreeStatusShowSwitch_Select.Checked == true)
            {
                comboBox_ThreeStatusShowSwitch.Enabled = true;
            }
            else
            {
                comboBox_ThreeStatusShowSwitch.Enabled = false;
            }
        }

        // 模拟速度显示 CheckBox
        private void checkBox_SimulationSpeedShow_Select_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_SimulationSpeedShow_Select.Checked == true)
            {
                myTextBoxNUM_SimulationSpeedShow.Enabled = true;
            }
            else
            {
                myTextBoxNUM_SimulationSpeedShow.Enabled = false;
            }
        }

        // 模拟电流显示 CheckBox
        private void checkBox_SimulationCurrentShow_Select_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_SimulationCurrentShow_Select.Checked == true)
            {
                myTextBoxNUM_SimulationCurrentShow.Enabled = true;
            }
            else
            {
                myTextBoxNUM_SimulationCurrentShow.Enabled = false;
            }
        }

        // 刹车功能 CheckBox
        private void checkBox_Braking_Select_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Braking_Select.Checked == true)
            {
                comboBox_Braking.Enabled = true;
            }
            else
            {
                comboBox_Braking.Enabled = false;
            }
        }

        // 多速实现 CheckBox
        private void checkBox_MoreSpeed_Select_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_MoreSpeed_Select.Checked == true)
            {
                comboBox_MoreSpeed.Enabled = true;
            }
            else
            {
                comboBox_MoreSpeed.Enabled = false;
            }
        }

        #endregion

        #region --参数变量--

        // 电机相序变更 ComboBox
        private void comboBox_MotorSequence_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // 霍尔相差 ComboBox
        private void comboBox_HallPhaseValue_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // 调速范围上限值
        private void myTextBoxNUM_SpeedUpperBound_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(myTextBoxNUM_SpeedUpperBound.Text) < (2.1))
                {
                    myTextBoxNUM_SpeedUpperBound.Text = "2.1";
                }
                else if (Convert.ToDouble(myTextBoxNUM_SpeedUpperBound.Text) > (4.9))
                {
                    myTextBoxNUM_SpeedUpperBound.Text = "4.9";
                }
            }
            catch (Exception)
            {
                myTextBoxNUM_SpeedUpperBound.Text = "4.2";
            }
        }

        // 调速范围下限值
        private void myTextBoxNUM_SpeedLowerBound_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(myTextBoxNUM_SpeedLowerBound.Text) < (0.1))
                {
                    myTextBoxNUM_SpeedLowerBound.Text = "0.1";
                }
                else if (Convert.ToDouble(myTextBoxNUM_SpeedLowerBound.Text) > (1.9))
                {
                    myTextBoxNUM_SpeedLowerBound.Text = "1.9";
                }
            }
            catch (Exception)
            {
                myTextBoxNUM_SpeedLowerBound.Text = "1.1";
            }
        }

        // 防飞车保护上限值
        private void myTextBoxNUM_ProtectionUpperBound_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(myTextBoxNUM_ProtectionUpperBound.Text) < (2.1))
                {
                    myTextBoxNUM_ProtectionUpperBound.Text = "2.1";
                }
                else if (Convert.ToDouble(myTextBoxNUM_ProtectionUpperBound.Text) > (4.9))
                {
                    myTextBoxNUM_ProtectionUpperBound.Text = "4.9";
                }
            }
            catch (Exception)
            {
                myTextBoxNUM_ProtectionUpperBound.Text = "4.5";
            }
        }

        // 防飞车保护下限值
        private void myTextBoxNUM_ProtectionLowerBound_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(myTextBoxNUM_ProtectionLowerBound.Text) < (0.1))
                {
                    myTextBoxNUM_ProtectionLowerBound.Text = "0.1";
                }
                else if (Convert.ToDouble(myTextBoxNUM_ProtectionLowerBound.Text) > (1.9))
                {
                    myTextBoxNUM_ProtectionLowerBound.Text = "1.9";
                }
            }
            catch (Exception)
            {
                myTextBoxNUM_ProtectionLowerBound.Text = "0.8";
            }
        }

        // 相电流峰值保护值
        private void myTextBoxNUM_PhaseCurrentPeak_Leave(object sender, EventArgs e)
        {
            // 6管
            if (comboBox_Pipe.SelectedIndex == 0)
            {
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_PhaseCurrentPeak.Text) < (6))
                    {
                        myTextBoxNUM_PhaseCurrentPeak.Text = "6";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_PhaseCurrentPeak.Text) > (35))
                    {
                        myTextBoxNUM_PhaseCurrentPeak.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_PhaseCurrentPeak.Text = "20";
                }
            }
            // 9管
            else if (comboBox_Pipe.SelectedIndex == 1)
            {
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_PhaseCurrentPeak.Text) < (6))
                    {
                        myTextBoxNUM_PhaseCurrentPeak.Text = "6";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_PhaseCurrentPeak.Text) > (35))
                    {
                        myTextBoxNUM_PhaseCurrentPeak.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_PhaseCurrentPeak.Text = "20";
                }
            }
            // 12管
            else if (comboBox_Pipe.SelectedIndex == 2)
            {
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_PhaseCurrentPeak.Text) < (6))
                    {
                        myTextBoxNUM_PhaseCurrentPeak.Text = "6";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_PhaseCurrentPeak.Text) > (35))
                    {
                        myTextBoxNUM_PhaseCurrentPeak.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_PhaseCurrentPeak.Text = "20";
                }
            }
        }

        // 电池容量 ComboBox
        private void comboBox_BatteryType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 48V电池
            if (comboBox_BatteryType.SelectedIndex == 0)
            {
                // 电池过压保护值
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_BatteryMaximumVoltage.Text) < (48))
                    {
                        myTextBoxNUM_BatteryMaximumVoltage.Text = "48.0";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_BatteryMaximumVoltage.Text) > (56))
                    {
                        myTextBoxNUM_BatteryMaximumVoltage.Text = "56.0";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_BatteryMaximumVoltage.Text = "54.0";
                }
                // 电池欠压保护值
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_BatteryMinimumVoltage.Text) < (42))
                    {
                        myTextBoxNUM_BatteryMinimumVoltage.Text = "42.0";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_BatteryMinimumVoltage.Text) > (48))
                    {
                        myTextBoxNUM_BatteryMinimumVoltage.Text = "48.0";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_BatteryMinimumVoltage.Text = "42.5";
                }
            }
            // 36V电池
            else if (comboBox_BatteryType.SelectedIndex == 1)
            {
                // 电池过压保护值
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_BatteryMaximumVoltage.Text) < (36))
                    {
                        myTextBoxNUM_BatteryMaximumVoltage.Text = "36.0";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_BatteryMaximumVoltage.Text) > (42))
                    {
                        myTextBoxNUM_BatteryMaximumVoltage.Text = "42.0";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_BatteryMaximumVoltage.Text = "41.0";
                }
                // 电池欠压保护值
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_BatteryMinimumVoltage.Text) < (28))
                    {
                        myTextBoxNUM_BatteryMinimumVoltage.Text = "28.0";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_BatteryMinimumVoltage.Text) > (36))
                    {
                        myTextBoxNUM_BatteryMinimumVoltage.Text = "36.0";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_BatteryMinimumVoltage.Text = "30.0";
                }
            }
        }

        // 电池过压保护值注释
        private void myTextBoxNUM_BatteryMaximumVoltage_Leave(object sender, EventArgs e)
        {
            // 48V电池
            if (comboBox_BatteryType.SelectedIndex == 0)
            {
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_BatteryMaximumVoltage.Text) < (48))
                    {
                        myTextBoxNUM_BatteryMaximumVoltage.Text = "48.0";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_BatteryMaximumVoltage.Text) > (56))
                    {
                        myTextBoxNUM_BatteryMaximumVoltage.Text = "56.0";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_BatteryMaximumVoltage.Text = "54.0";
                }
            }
            // 36V电池
            else if (comboBox_BatteryType.SelectedIndex == 1)
            {
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_BatteryMaximumVoltage.Text) < (36))
                    {
                        myTextBoxNUM_BatteryMaximumVoltage.Text = "36.0";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_BatteryMaximumVoltage.Text) > (42))
                    {
                        myTextBoxNUM_BatteryMaximumVoltage.Text = "42.0";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_BatteryMaximumVoltage.Text = "41.0";
                }
            }
        }

        // 电池欠压保护值
        private void myTextBoxNUM_BatteryMinimumVoltage_Leave(object sender, EventArgs e)
        {
            // 48V电池
            if (comboBox_BatteryType.SelectedIndex == 0)
            {
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_BatteryMinimumVoltage.Text) < (42))
                    {
                        myTextBoxNUM_BatteryMinimumVoltage.Text = "42.0";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_BatteryMinimumVoltage.Text) > (48))
                    {
                        myTextBoxNUM_BatteryMinimumVoltage.Text = "48.0";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_BatteryMinimumVoltage.Text = "42.5";
                }
            }
            // 36V电池
            else if (comboBox_BatteryType.SelectedIndex == 1)
            {
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_BatteryMinimumVoltage.Text) < (28))
                    {
                        myTextBoxNUM_BatteryMinimumVoltage.Text = "28.0";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_BatteryMinimumVoltage.Text) > (36))
                    {
                        myTextBoxNUM_BatteryMinimumVoltage.Text = "36.0";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_BatteryMinimumVoltage.Text = "30.0";
                }
            }
        }

        // 堵转保护电流
        private void myTextBoxNUM_LockedRotorProtectionCurrentValue_Leave(object sender, EventArgs e)
        {
            // 6管
            if (comboBox_Pipe.SelectedIndex == 0)
            {
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_LockedRotorProtectionCurrentValue.Text) < (6))
                    {
                        myTextBoxNUM_LockedRotorProtectionCurrentValue.Text = "6";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_LockedRotorProtectionCurrentValue.Text) > (35))
                    {
                        myTextBoxNUM_LockedRotorProtectionCurrentValue.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_LockedRotorProtectionCurrentValue.Text = "10";
                }
            }
            // 9管
            else if (comboBox_Pipe.SelectedIndex == 1)
            {
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_LockedRotorProtectionCurrentValue.Text) < (6))
                    {
                        myTextBoxNUM_LockedRotorProtectionCurrentValue.Text = "6";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_LockedRotorProtectionCurrentValue.Text) > (35))
                    {
                        myTextBoxNUM_LockedRotorProtectionCurrentValue.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_LockedRotorProtectionCurrentValue.Text = "10";
                }
            }
            // 12管
            else if (comboBox_Pipe.SelectedIndex == 2)
            {
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_LockedRotorProtectionCurrentValue.Text) < (6))
                    {
                        myTextBoxNUM_LockedRotorProtectionCurrentValue.Text = "6";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_LockedRotorProtectionCurrentValue.Text) > (35))
                    {
                        myTextBoxNUM_LockedRotorProtectionCurrentValue.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_LockedRotorProtectionCurrentValue.Text = "10";
                }
            }
        }

        // 限速分压系数
        private void myTextBoxNUM_SpeedLimitVoltageDivideCoefficient_Leave(object sender, EventArgs e)
        {
            //try
            //{
            //    if (Convert.ToDouble(myTextBoxNUM_SpeedLimitVoltageDivideCoefficient.Text) < (1))
            //    {
            //        myTextBoxNUM_SpeedLimitVoltageDivideCoefficient.Text = "1.0";
            //    }
            //    else if (Convert.ToDouble(myTextBoxNUM_SpeedLimitVoltageDivideCoefficient.Text) > (2))
            //    {
            //        myTextBoxNUM_SpeedLimitVoltageDivideCoefficient.Text = "2.0";
            //    }
            //}
            //catch (Exception)
            //{
            //    myTextBoxNUM_SpeedLimitVoltageDivideCoefficient.Text = "1.7";
            //}
        }

        // 管 ComboBox
        private void comboBox_Pipe_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 此处不做其他数据处理，如果以后管数更改，启用此处
            // 还需更改的地方有如下
            // 1.相电流峰值保护值的范围和系数
            // 2.堵转电流保护值的范围和系数
            // 3.限速限流里的所有限流的范围和系数
            // 6管
            if (comboBox_Pipe.SelectedIndex == 0)
            {
                // 相电流峰值保护值
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_PhaseCurrentPeak.Text) < (6))
                    {
                        myTextBoxNUM_PhaseCurrentPeak.Text = "6";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_PhaseCurrentPeak.Text) > (35))
                    {
                        myTextBoxNUM_PhaseCurrentPeak.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_PhaseCurrentPeak.Text = "20";
                }
                // 堵转保护电流
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_LockedRotorProtectionCurrentValue.Text) < (6))
                    {
                        myTextBoxNUM_LockedRotorProtectionCurrentValue.Text = "6";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_LockedRotorProtectionCurrentValue.Text) > (35))
                    {
                        myTextBoxNUM_LockedRotorProtectionCurrentValue.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_LockedRotorProtectionCurrentValue.Text = "10";
                }
                // 限速限流 无限速 限流值 提速
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SNLAccelerationAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SNLAccelerationAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SNLAccelerationAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SNLAccelerationAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SNLAccelerationAmpere.Text = "20";
                }
                // 限速限流 无限速 限流值 高速
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SNLHighAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SNLHighAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SNLHighAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SNLHighAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SNLHighAmpere.Text = "17";
                }
                // 限速限流 无限速 限流值 中速
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SNLMidAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SNLMidAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SNLMidAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SNLMidAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SNLMidAmpere.Text = "13";
                }
                // 限速限流 无限速 限流值 低速
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SNLLowAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SNLLowAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SNLLowAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SNLLowAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SNLLowAmpere.Text = "9";
                }
                // 限速限流 有限速 限流值 提速
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SLAccelerationAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SLAccelerationAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SLAccelerationAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SLAccelerationAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SLAccelerationAmpere.Text = "12";
                }
                // 限速限流 有限速 限流值 高速
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SLHighAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SLHighAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SLHighAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SLHighAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SLHighAmpere.Text = "10";
                }
                // 限速限流 有限速 限流值 中速
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SLMidAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SLMidAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SLMidAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SLMidAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SLMidAmpere.Text = "8";
                }
                // 限速限流 有限速 限流值 低速
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SLLowAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SLLowAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SLLowAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SLLowAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SLLowAmpere.Text = "6";
                }
            }

            // 9管
            else if (comboBox_Pipe.SelectedIndex == 1)
            {
                // 相电流峰值保护值
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_PhaseCurrentPeak.Text) < (6))
                    {
                        myTextBoxNUM_PhaseCurrentPeak.Text = "6";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_PhaseCurrentPeak.Text) > (35))
                    {
                        myTextBoxNUM_PhaseCurrentPeak.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_PhaseCurrentPeak.Text = "20";
                }
                // 堵转保护电流
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_LockedRotorProtectionCurrentValue.Text) < (6))
                    {
                        myTextBoxNUM_LockedRotorProtectionCurrentValue.Text = "6";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_LockedRotorProtectionCurrentValue.Text) > (35))
                    {
                        myTextBoxNUM_LockedRotorProtectionCurrentValue.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_LockedRotorProtectionCurrentValue.Text = "10";
                }
                // 限速限流 无限速 限流值 提速
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SNLAccelerationAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SNLAccelerationAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SNLAccelerationAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SNLAccelerationAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SNLAccelerationAmpere.Text = "20";
                }
                // 限速限流 无限速 限流值 高速
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SNLHighAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SNLHighAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SNLHighAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SNLHighAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SNLHighAmpere.Text = "17";
                }
                // 限速限流 无限速 限流值 中速
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SNLMidAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SNLMidAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SNLMidAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SNLMidAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SNLMidAmpere.Text = "13";
                }
                // 限速限流 无限速 限流值 低速
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SNLLowAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SNLLowAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SNLLowAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SNLLowAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SNLLowAmpere.Text = "9";
                }
                // 限速限流 有限速 限流值 提速
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SLAccelerationAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SLAccelerationAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SLAccelerationAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SLAccelerationAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SLAccelerationAmpere.Text = "12";
                }
                // 限速限流 有限速 限流值 高速
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SLHighAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SLHighAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SLHighAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SLHighAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SLHighAmpere.Text = "10";
                }
                // 限速限流 有限速 限流值 中速
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SLMidAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SLMidAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SLMidAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SLMidAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SLMidAmpere.Text = "8";
                }
                // 限速限流 有限速 限流值 低速
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SLLowAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SLLowAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SLLowAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SLLowAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SLLowAmpere.Text = "6";
                }
            }

            // 12管
            else if (comboBox_Pipe.SelectedIndex == 2)
            {
                // 相电流峰值保护值
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_PhaseCurrentPeak.Text) < (6))
                    {
                        myTextBoxNUM_PhaseCurrentPeak.Text = "6";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_PhaseCurrentPeak.Text) > (35))
                    {
                        myTextBoxNUM_PhaseCurrentPeak.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_PhaseCurrentPeak.Text = "20";
                }
                // 堵转保护电流
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_LockedRotorProtectionCurrentValue.Text) < (6))
                    {
                        myTextBoxNUM_LockedRotorProtectionCurrentValue.Text = "6";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_LockedRotorProtectionCurrentValue.Text) > (35))
                    {
                        myTextBoxNUM_LockedRotorProtectionCurrentValue.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_LockedRotorProtectionCurrentValue.Text = "10";
                }
                // 限速限流 无限速 限流值 提速
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SNLAccelerationAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SNLAccelerationAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SNLAccelerationAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SNLAccelerationAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SNLAccelerationAmpere.Text = "20";
                }
                // 限速限流 无限速 限流值 高速
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SNLHighAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SNLHighAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SNLHighAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SNLHighAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SNLHighAmpere.Text = "17";
                }
                // 注释
                // 限速限流 无限速 限流值 中速
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SNLMidAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SNLMidAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SNLMidAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SNLMidAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SNLMidAmpere.Text = "13";
                }
                // 限速限流 无限速 限流值 低速
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SNLLowAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SNLLowAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SNLLowAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SNLLowAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SNLLowAmpere.Text = "9";
                }
                // 限速限流 有限速 限流值 提速
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SLAccelerationAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SLAccelerationAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SLAccelerationAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SLAccelerationAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SLAccelerationAmpere.Text = "12";
                }
                // 限速限流 有限速 限流值 高速
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SLHighAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SLHighAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SLHighAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SLHighAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SLHighAmpere.Text = "10";
                }
                // 限速限流 有限速 限流值 中速
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SLMidAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SLMidAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SLMidAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SLMidAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SLMidAmpere.Text = "8";
                }
                // 限速限流 有限速 限流值 低速
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SLLowAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SLLowAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SLLowAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SLLowAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SLLowAmpere.Text = "6";
                }
            }
        }

        // 霍尔有无
        private void comboBox_Hall_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Hall.SelectedIndex == 0)
            {
                comboBox_HallPhaseValue.Enabled = false;
            }
            else if (comboBox_Hall.SelectedIndex == 1)
            {
                comboBox_HallPhaseValue.Enabled = true;
            }
        }

        #endregion

        #region --功能变量--

        // 限速限流 无限速 限速值 提速
        private void myTextBoxNUM_SNLAccelerationSpeed_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(myTextBoxNUM_SNLAccelerationSpeed.Text) < (1))
                {
                    myTextBoxNUM_SNLAccelerationSpeed.Text = "1";
                }
                else if (Convert.ToDouble(myTextBoxNUM_SNLAccelerationSpeed.Text) > (600))
                {
                    myTextBoxNUM_SNLAccelerationSpeed.Text = "600";
                }
            }
            catch (Exception)
            {
                myTextBoxNUM_SNLAccelerationSpeed.Text = "450";
            }
        }
        // 限速限流 无限速 限速值 高速
        private void myTextBoxNUM_SNLHighSpeed_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(myTextBoxNUM_SNLHighSpeed.Text) < (1))
                {
                    myTextBoxNUM_SNLHighSpeed.Text = "1";
                }
                else if (Convert.ToDouble(myTextBoxNUM_SNLHighSpeed.Text) > (600))
                {
                    myTextBoxNUM_SNLHighSpeed.Text = "600";
                }
            }
            catch (Exception)
            {
                myTextBoxNUM_SNLHighSpeed.Text = "410";
            }
        }
        // 限速限流 无限速 限速值 中速
        private void myTextBoxNUM_SNLMidSpeed_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(myTextBoxNUM_SNLMidSpeed.Text) < (1))
                {
                    myTextBoxNUM_SNLMidSpeed.Text = "1";
                }
                else if (Convert.ToDouble(myTextBoxNUM_SNLMidSpeed.Text) > (600))
                {
                    myTextBoxNUM_SNLMidSpeed.Text = "600";
                }
            }
            catch (Exception)
            {
                myTextBoxNUM_SNLMidSpeed.Text = "320";
            }
        }
        // 限速限流 无限速 限速值 低速
        private void myTextBoxNUM_SNLLowSpeed_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(myTextBoxNUM_SNLLowSpeed.Text) < (1))
                {
                    myTextBoxNUM_SNLLowSpeed.Text = "1";
                }
                else if (Convert.ToDouble(myTextBoxNUM_SNLLowSpeed.Text) > (600))
                {
                    myTextBoxNUM_SNLLowSpeed.Text = "600";
                }
            }
            catch (Exception)
            {
                myTextBoxNUM_SNLLowSpeed.Text = "210";
            }
        }
        // 限速限流 无限速 限流值 提速
        private void myTextBoxNUM_SNLAccelerationAmpere_Leave(object sender, EventArgs e)
        {
            // 6管
            if (comboBox_Pipe.SelectedIndex == 0)
            {
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SNLAccelerationAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SNLAccelerationAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SNLAccelerationAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SNLAccelerationAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SNLAccelerationAmpere.Text = "20";
                }
            }
            // 9管
            else if (comboBox_Pipe.SelectedIndex == 1)
            {
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SNLAccelerationAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SNLAccelerationAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SNLAccelerationAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SNLAccelerationAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SNLAccelerationAmpere.Text = "20";
                }
            }
            // 12管
            else if (comboBox_Pipe.SelectedIndex == 2)
            {
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SNLAccelerationAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SNLAccelerationAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SNLAccelerationAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SNLAccelerationAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SNLAccelerationAmpere.Text = "20";
                }
            }
        }
        // 限速限流 无限速 限流值 高速
        private void myTextBoxNUM_SNLHighAmpere_Leave(object sender, EventArgs e)
        {
            // 6管
            if (comboBox_Pipe.SelectedIndex == 0)
            {
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SNLHighAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SNLHighAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SNLHighAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SNLHighAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SNLHighAmpere.Text = "17";
                }
            }
            // 9管
            else if (comboBox_Pipe.SelectedIndex == 1)
            {
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SNLHighAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SNLHighAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SNLHighAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SNLHighAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SNLHighAmpere.Text = "17";
                }
            }
            // 12管
            else if (comboBox_Pipe.SelectedIndex == 2)
            {
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SNLHighAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SNLHighAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SNLHighAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SNLHighAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SNLHighAmpere.Text = "17";
                }
            }
        }
        // 限速限流 无限速 限流值 中速
        private void myTextBoxNUM_SNLMidAmpere_Leave(object sender, EventArgs e)
        {
            // 6管
            if (comboBox_Pipe.SelectedIndex == 0)
            {
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SNLMidAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SNLMidAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SNLMidAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SNLMidAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SNLMidAmpere.Text = "13";
                }
            }
            // 9管
            else if (comboBox_Pipe.SelectedIndex == 1)
            {
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SNLMidAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SNLMidAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SNLMidAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SNLMidAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SNLMidAmpere.Text = "13";
                }
            }
            // 12管
            else if (comboBox_Pipe.SelectedIndex == 2)
            {
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SNLMidAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SNLMidAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SNLMidAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SNLMidAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SNLMidAmpere.Text = "13";
                }
            }
        }
        // 限速限流 无限速 限流值 低速
        private void myTextBoxNUM_SNLLowAmpere_Leave(object sender, EventArgs e)
        {
            // 6管
            if (comboBox_Pipe.SelectedIndex == 0)
            {
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SNLLowAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SNLLowAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SNLLowAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SNLLowAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SNLLowAmpere.Text = "9";
                }
            }
            // 9管
            else if (comboBox_Pipe.SelectedIndex == 1)
            {
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SNLLowAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SNLLowAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SNLLowAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SNLLowAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SNLLowAmpere.Text = "9";
                }
            }
            // 12管
            else if (comboBox_Pipe.SelectedIndex == 2)
            {
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SNLLowAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SNLLowAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SNLLowAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SNLLowAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SNLLowAmpere.Text = "9";
                }
            }
        }
        // 限速限流 有限速 限速值 提速
        private void myTextBoxNUM_SLAccelerationSpeed_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(myTextBoxNUM_SLAccelerationSpeed.Text) < (1))
                {
                    myTextBoxNUM_SLAccelerationSpeed.Text = "1";
                }
                else if (Convert.ToDouble(myTextBoxNUM_SLAccelerationSpeed.Text) > (600))
                {
                    myTextBoxNUM_SLAccelerationSpeed.Text = "600";
                }
            }
            catch (Exception)
            {
                myTextBoxNUM_SLAccelerationSpeed.Text = "270";
            }
        }
        // 限速限流 有限速 限速值 高速
        private void myTextBoxNUM_SLHighSpeed_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(myTextBoxNUM_SLHighSpeed.Text) < (1))
                {
                    myTextBoxNUM_SLHighSpeed.Text = "1";
                }
                else if (Convert.ToDouble(myTextBoxNUM_SLHighSpeed.Text) > (600))
                {
                    myTextBoxNUM_SLHighSpeed.Text = "600";
                }
            }
            catch (Exception)
            {
                myTextBoxNUM_SLHighSpeed.Text = "244";
            }
        }
        // 限速限流 有限速 限速值 中速
        private void myTextBoxNUM_SLMidSpeed_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(myTextBoxNUM_SLMidSpeed.Text) < (1))
                {
                    myTextBoxNUM_SLMidSpeed.Text = "1";
                }
                else if (Convert.ToDouble(myTextBoxNUM_SLMidSpeed.Text) > (600))
                {
                    myTextBoxNUM_SLMidSpeed.Text = "600";
                }
            }
            catch (Exception)
            {
                myTextBoxNUM_SLMidSpeed.Text = "190";
            }
        }
        // 限速限流 有限速 限速值 低速
        private void myTextBoxNUM_SLLowSpeed_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(myTextBoxNUM_SLLowSpeed.Text) < (1))
                {
                    myTextBoxNUM_SLLowSpeed.Text = "1";
                }
                else if (Convert.ToDouble(myTextBoxNUM_SLLowSpeed.Text) > (600))
                {
                    myTextBoxNUM_SLLowSpeed.Text = "600";
                }
            }
            catch (Exception)
            {
                myTextBoxNUM_SLLowSpeed.Text = "126";
            }
        }
        // 限速限流 有限速 限流值 提速
        private void myTextBoxNUM_SLAccelerationAmpere_Leave(object sender, EventArgs e)
        {
            // 6管
            if (comboBox_Pipe.SelectedIndex == 0)
            {
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SLAccelerationAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SLAccelerationAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SLAccelerationAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SLAccelerationAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SLAccelerationAmpere.Text = "12";
                }
            }
            // 9管
            else if (comboBox_Pipe.SelectedIndex == 1)
            {
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SLAccelerationAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SLAccelerationAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SLAccelerationAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SLAccelerationAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SLAccelerationAmpere.Text = "12";
                }
            }
            // 12管
            else if (comboBox_Pipe.SelectedIndex == 2)
            {
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SLAccelerationAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SLAccelerationAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SLAccelerationAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SLAccelerationAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SLAccelerationAmpere.Text = "12";
                }
            }
        }
        // 限速限流 有限速 限流值 高速
        private void myTextBoxNUM_SLHighAmpere_Leave(object sender, EventArgs e)
        {
            // 6管
            if (comboBox_Pipe.SelectedIndex == 0)
            {
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SLHighAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SLHighAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SLHighAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SLHighAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SLHighAmpere.Text = "10";
                }
            }
            // 9管
            else if (comboBox_Pipe.SelectedIndex == 1)
            {
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SLHighAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SLHighAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SLHighAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SLHighAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SLHighAmpere.Text = "10";
                }
            }
            // 12管
            else if (comboBox_Pipe.SelectedIndex == 2)
            {
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SLHighAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SLHighAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SLHighAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SLHighAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SLHighAmpere.Text = "10";
                }
            }
        }
        // 限速限流 有限速 限流值 中速
        private void myTextBoxNUM_SLMidAmpere_Leave(object sender, EventArgs e)
        {
            // 6管
            if (comboBox_Pipe.SelectedIndex == 0)
            {
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SLMidAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SLMidAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SLMidAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SLMidAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SLMidAmpere.Text = "8";
                }
            }
            // 9管
            else if (comboBox_Pipe.SelectedIndex == 1)
            {
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SLMidAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SLMidAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SLMidAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SLMidAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SLMidAmpere.Text = "8";
                }
            }   
            // 12管
            else if (comboBox_Pipe.SelectedIndex == 2)
            {
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SLMidAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SLMidAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SLMidAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SLMidAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SLMidAmpere.Text = "8";
                }
            }
        }
        // 限速限流 有限速 限流值 低速
        private void myTextBoxNUM_SLLowAmpere_Leave(object sender, EventArgs e)
        {
            // 6管
            if (comboBox_Pipe.SelectedIndex == 0)
            {
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SLLowAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SLLowAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SLLowAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SLLowAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SLLowAmpere.Text = "6";
                }
            }
            // 9管
            else if (comboBox_Pipe.SelectedIndex == 1)
            {
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SLLowAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SLLowAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SLLowAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SLLowAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SLLowAmpere.Text = "6";
                }
            }
            // 12管
            else if (comboBox_Pipe.SelectedIndex == 2)
            {
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SLLowAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SLLowAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SLLowAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SLLowAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SLLowAmpere.Text = "6";
                }
            }
        }

        // 巡航功能
        private void comboBox_Cruise_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 测试颜色
            //if (comboBox_Cruise.SelectedIndex == 0)
            //{ comboBox_Cruise.BackColor = Color.Red; }
            //else
            //{ comboBox_Cruise.BackColor = Color.Green;}
        }

        // 电动巡航助力转换
        private void comboBox_CruiseSwitch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // 自动巡航手柄稳定时间
        private void myTextBoxNUM_AutoHoldTime_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(myTextBoxNUM_AutoHoldTime.Text) < (2))
                {
                    myTextBoxNUM_AutoHoldTime.Text = "2";
                }
                else if (Convert.ToDouble(myTextBoxNUM_AutoHoldTime.Text) > (12))
                {
                    myTextBoxNUM_AutoHoldTime.Text = "12";
                }
            }
            catch (Exception)
            {
                myTextBoxNUM_AutoHoldTime.Text = "8";
            }
        }

        // 手动巡航按键保持时间
        private void myTextBoxNUM_ManualHoldTime_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(myTextBoxNUM_ManualHoldTime.Text) < (1))
                {
                    myTextBoxNUM_ManualHoldTime.Text = "1";
                }
                else if (Convert.ToDouble(myTextBoxNUM_ManualHoldTime.Text) > (4))
                {
                    myTextBoxNUM_ManualHoldTime.Text = "4";
                }
            }
            catch (Exception)
            {
                myTextBoxNUM_ManualHoldTime.Text = "2";
            }
        }

        // 助力功能
        private void comboBox_Boost_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // 三态显示
        private void comboBox_ThreeStatusShowSwitch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // 模拟速度显示
        private void myTextBoxNUM_SimulationSpeedShow_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(myTextBoxNUM_SimulationSpeedShow.Text) < (0.2))
                {
                    myTextBoxNUM_SimulationSpeedShow.Text = "0.2";
                }
                else if (Convert.ToDouble(myTextBoxNUM_SimulationSpeedShow.Text) > (1))
                {
                    myTextBoxNUM_SimulationSpeedShow.Text = "1.0";
                }
            }
            catch (Exception)
            {
                myTextBoxNUM_SimulationSpeedShow.Text = "1.0";
            }
        }

        // 模拟电流显示
        private void myTextBoxNUM_SimulationCurrentShow_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(myTextBoxNUM_SimulationCurrentShow.Text) < (2))
                {
                    myTextBoxNUM_SimulationCurrentShow.Text = "2.0";
                }
                else if (Convert.ToDouble(myTextBoxNUM_SimulationCurrentShow.Text) > (10))
                {
                    myTextBoxNUM_SimulationCurrentShow.Text = "10.0";
                }
            }
            catch (Exception)
            {
                myTextBoxNUM_SimulationCurrentShow.Text = "5.0";
            }
        }

        // 刹车功能
        private void comboBox_Braking_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Braking.SelectedIndex == 0)
            {
                //myTextBoxNUM_BrakingPotency.Enabled = false;
            }
            else if (comboBox_Braking.SelectedIndex == 1)
            {
                //myTextBoxNUM_BrakingPotency.Enabled = true;
            }
        }

        // 多速实现
        private void comboBox_MoreSpeed_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        #endregion

        #region --新增功能--

        // 电机型号选择
        private void checkBox_MotorType_Select_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_MotorType_Select.Checked == true)
            {
                comboBox_MotorType.Enabled = true;
            }
            else
            {
                comboBox_MotorType.Enabled = false;
            }
        }

        // 电机型号
        private void comboBox_MotorType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // 启动方式
        private void trackBar_StartStyle_Scroll(object sender, EventArgs e)
        {
            //label_StartStyle.Text = trackBar_StartStyle.Value.ToString();
        }

        // 启动方式的值改变
        private void trackBar_StartStyle_ValueChanged(object sender, EventArgs e)
        {
            //label_StartStyle.Text = trackBar_StartStyle.Value.ToString();
        }

        // 刹车力度
        private void trackBar_BrakingPotency_Scroll(object sender, EventArgs e)
        {
            label_BrakingPotency.Text = trackBar_BrakingPotency.Value.ToString();
        }

        // 刹车力度的值改变
        private void trackBar_BrakingPotency_ValueChanged(object sender, EventArgs e)
        {
            label_BrakingPotency.Text = trackBar_BrakingPotency.Value.ToString();
        }

        // 堵转降流选择
        private void checkBox_LockedRotorCurrentDrop_Select_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_LockedRotorCurrentDrop_Select.Checked == true)
            {
                comboBox_LockedRotorCurrentDrop.Enabled = true;
            }
            else
            {
                comboBox_LockedRotorCurrentDrop.Enabled = false;
            }
        }

        // 堵转降流
        private void comboBox_LockedRotorCurrentDrop_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        // 松手刹防飞车选择
        private void checkBox_HandBrakeOverrun_Select_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_HandBrakeOverrun_Select.Checked == true)
            {
                comboBox_HandBrakeOverrun.Enabled = true;
            }
            else
            {
                comboBox_HandBrakeOverrun.Enabled = false;
            }
        }

        // 松手刹防飞车
        private void comboBox_HandBrakeOverrun_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        // 滑行反充电选择
        private void checkBox_SlideCharge_Select_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_SlideCharge_Select.Checked == true)
            {
                comboBox_SlideCharge.Enabled = true;
            }
            else
            {
                comboBox_SlideCharge.Enabled = false;
            }
        }

        // 滑行反充电
        private void comboBox_ReverseCharge_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        #endregion

    }
}