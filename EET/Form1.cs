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
using System.Threading;

namespace EET
{
    public partial class Form1 : Form
    {
        #region --变量声明与定义--

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
        // 6.变量到界面     P T U 和 P T U serialport receive
        // 7.回读校验       R B C

        // D P

        #region ----参数设定区----

        // 电机相序值
        public static string gss_MotorSequence = "00";
        // 霍尔相位差值
        public static string gss_HallPhaseValue = "00";
        // 调速范围上限值
        public static string gss_SpeedUpperBound = "D6";
        // 调速范围下限值
        public static string gss_SpeedLowerBound = "38";
        // 防飞车保护上限值
        public static string gss_ProtectionUpperBound = "E6";
        // 防飞车保护下限值
        public static string gss_ProtectionLowerBound = "29";
        // 相电流峰值限制
        public static string gss_PhaseCurrentPeak = "9D";
        // 电池额定电压
        public static string gss_BatteryType = "00";
        // 48V电池过压值
        public static string gss_BatteryMaximumVoltage = "B4";
        // 48V电池欠压值
        public static string gss_BatteryMinimumVoltage = "8E";
        // 36V电池过压值
        public static string gss_BatteryMaximumVoltage_36V = "89";
        // 36V电池欠压值
        public static string gss_BatteryMinimumVoltage_36V = "64";
        // 堵转保护电流值
        public static string gss_LockedRotorProtectionCurrentValue = "68";
        // 限速线分压系数
        public static string gss_SpeedLimitVoltageDivideCoefficient = "11";

        #endregion

        #region ----功能选择区----

        // 限速限流选择
        public static string gss_SpeedAndAmpereLimit_Select = "false";
        // 限速限流 无限速 限速值 提速
        public static string gss_SNLAccelerationSpeed = "70";
        // 限速限流 无限速 限速值 高速
        public static string gss_SNLHighSpeed = "66";
        // 限速限流 无限速 限速值 中速
        public static string gss_SNLMidSpeed = "50";
        // 限速限流 无限速 限速值 低速
        public static string gss_SNLLowSpeed = "34";
        // 限速限流 无限速 限流值 提速
        public static string gss_SNLAccelerationAmpere = "9D";
        // 限速限流 无限速 限流值 高速
        public static string gss_SNLHighAmpere = "8D";
        // 限速限流 无限速 限流值 中速
        public static string gss_SNLMidAmpere = "78";
        // 限速限流 无限速 限流值 低速
        public static string gss_SNLLowAmpere = "63";
        // 限速限流 有限速 限速值 提速
        public static string gss_SLAccelerationSpeed = "44";
        // 限速限流 有限速 限速值 高速
        public static string gss_SLHighSpeed = "3D";
        // 限速限流 有限速 限速值 中速
        public static string gss_SLMidSpeed = "30";
        // 限速限流 有限速 限速值 低速
        public static string gss_SLLowSpeed = "20";
        // 限速限流 有限速 限流值 提速
        public static string gss_SLAccelerationAmpere = "73";
        // 限速限流 有限速 限流值 高速
        public static string gss_SLHighAmpere = "68";
        // 限速限流 有限速 限流值 中速
        public static string gss_SLMidAmpere = "5D";
        // 限速限流 有限速 限流值 低速
        public static string gss_SLLowAmpere = "53";

        // 巡航功能选择
        public static string gss_Cruise_Select = "false";
        // 巡航功能
        public static string gss_Cruise = "00";

        // 电动巡航助力转换选择
        public static string gss_CruiseSwitch_Select = "false";
        // 电动巡航助力转换
        public static string gss_CruiseSwitch = "00";

        // 自动巡航手柄稳定时间选择
        public static string gss_AutoHoldTime_Select = "false";
        // 自动巡航手柄稳定时间
        public static string gss_AutoHoldTime = "50";

        // 手动巡航按键保持时间选择
        public static string gss_ManualHoldTime_Select = "false";
        // 手动巡航按键保持时间
        public static string gss_ManualHoldTime = "28";

        // 助力功能选择
        public static string gss_Boost_Select = "false";
        // 助力功能
        public static string gss_Boost = "00";

        // 三态显示选择
        public static string gss_ThreeStatusShowSwitch_Select = "false";
        // 三态显示
        public static string gss_ThreeStatusShowSwitch = "00";

        // 模拟速度显示选择
        public static string gss_SimulationSpeedShow_Select = "false";
        // 模拟速度显示
        public static string gss_SimulationSpeedShow = "0A";

        // 模拟电流显示选择
        public static string gss_SimulationCurrentShow_Select = "false";
        // 模拟电流显示
        public static string gss_SimulationCurrentShow = "32";

        // 刹车功能选择
        public static string gss_Braking_Select = "false";
        // 刹车功能
        public static string gss_Braking = "00";

        // 多速实现选择
        public static string gss_MoreSpeed_Select = "false";
        // 多速实现
        public static string gss_MoreSpeed = "00";


        //
        // 最新更新的参数，根据文档增加
        //
        // 电机型号
        public static string gss_MotorType_Select = "false";
        public static string gss_MotorType = "00";
        // 启动方式
        public static string gss_StartStyle = "05";
        // 刹车力度
        public static string gss_BrakingPotency = "05";
        // 堵转降流
        public static string gss_LockedRotorCurrentDrop_Select = "false";
        public static string gss_LockedRotorCurrentDrop = "00";
        // 松手刹防飞车
        public static string gss_HandBrakeOverrun_Select = "false";
        public static string gss_HandBrakeOverrun = "00";
        // 滑行反充电
        public static string gss_SlideCharge_Select = "false";
        public static string gss_SlideCharge = "00";


        #endregion

        #region ----只保存与读取的变量----

        // 霍尔边沿1角度值
        public static string gss_HallForwardAngle_1 = "00";
        // 霍尔边沿2角度值
        public static string gss_HallForwardAngle_2 = "00";
        // 霍尔边沿3角度值
        public static string gss_HallForwardAngle_3 = "00";
        // 霍尔边沿4角度值
        public static string gss_HallForwardAngle_4 = "00";
        // 霍尔边沿5角度值
        public static string gss_HallForwardAngle_5 = "00";
        // 霍尔边沿6角度值
        public static string gss_HallForwardAngle_6 = "00";
        // 霍尔反向边沿1角度值
        public static string gss_HallReverseAngle_1 = "00";
        // 霍尔反向边沿2角度值
        public static string gss_HallReverseAngle_2 = "00";
        // 霍尔反向边沿3角度值
        public static string gss_HallReverseAngle_3 = "00";
        // 霍尔反向边沿4角度值
        public static string gss_HallReverseAngle_4 = "00";
        // 霍尔反向边沿5角度值
        public static string gss_HallReverseAngle_5 = "00";
        // 霍尔反向边沿6角度值
        public static string gss_HallReverseAngle_6 = "00";
        // 管
        public static string gss_Pipe = "00";

        #endregion

        #region ----显示区----

        // 软件版本号
        public static string gss_SoftwareVersion = "64";
        // 硬件版本号
        public static string gss_HardwareVersion = "01";
        // 产品型号
        public static string gss_ProductModel = "01";
        // 电机极数
        public static string gss_MotorSeries = "08";
        // 共阴共阳,0共阴，1共阳
        public static string gss_SamePolarity = "00";
        // 控制器保护温度
        public static string gss_ProtectionTemperature = "64";
        // 霍尔有无
        public static string gss_Hall = "00";

        #endregion

        #region --串口参数及计数--

        //// “保存到文档”按钮的使能记录
        //private bool Save_button_SavedFlag = true;
        //// “读取目标配置”按钮的使能记录
        //private bool UpLoad_button_SavedFlag = true;

        // 串口数据记录
        public static string gss_SerialPort_ReceiveData = "";

        // 串口接收标志
        public static bool gsb_SerialPort_IsReceive = false;
        public static bool gsb_SerialPort_IsOpen = false;

        // 串口端口号
        public static string gss_SerialPort_PortName = "COM1";
        // 串口波特率
        public static int gsi_SerialPort_BaudRate = 9600;

        // 等待接收所有指令的计数
        public static int gsi_WaitForAllCommandCounter = 0;
        // 等待接收所有指令的计数最大值
        public static int gsi_WaitForAllCommandCounter_Max = 2;

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
            //comboBox_MotorSeries.Text = comboBox_MotorSeries.Items[0].ToString();
            // 默认共阴共阳
            //comboBox_SamePolarity.Text = comboBox_SamePolarity.Items[0].ToString();

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

            //// 串口端口号加载
            //toolStripComboBox_PortName.Text = toolStripComboBox_PortName.Items[0].ToString();
            // 初始化串口配置
            getPortName();
        }

        // 得到串口端口号
        private void getPortName()
        {
            toolStripComboBox_PortName.Items.Clear();
            foreach (string s in SerialPort.GetPortNames())
            {
                toolStripComboBox_PortName.Items.Add(s);
                toolStripComboBox_PortName.Text = s;
            }
        }

        // Index改变时获取串口端口名
        private void toolStripComboBox_PortName_SelectedIndexChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = toolStripComboBox_PortName.Text;
            gss_SerialPort_PortName = toolStripStatusLabel3.Text;
            m_portDispl.serialPort.PortName = gss_SerialPort_PortName;
        }

        #endregion

        #region --按钮事件--

        // 从文件加载配置按钮事件
        private void toolStripMenuItem_Open_Click(object sender, EventArgs e)
        {
            try
            {
                // 若初始化路径不为空，则打开使用过的路径
                if (EET_openFileDialog.InitialDirectory != "")
                {
                    EET_openFileDialog.InitialDirectory = EET_openFileDialog.FileName.Substring(0, EET_openFileDialog.FileName.LastIndexOf("\\"));
                }
                else
                {
                    EET_openFileDialog.InitialDirectory = Application.StartupPath;
                }
            }
            catch
            {
                EET_openFileDialog.InitialDirectory = Application.StartupPath;
            }
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

                // 使能控件
                EET_myToolStripFocus.Enabled = true;
                groupBox_Parameters.Enabled = true;
                groupBox_Function.Enabled = true;
                groupBox_Display.Enabled = true;

                // 使能按钮
                toolStripMenuItem_Save.Enabled = true;
                toolStripMenuItem_DownLoad.Enabled = true;

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

            // 禁止“读取控制器配置”按钮
            toolStripMenuItem_UpLoad.Enabled = false;

            // 调用计算的方法，生成修改后的的变量
            GenerateParameters.UIToParameters(this);

            // 使能“下载配置到目标”的按钮
            toolStripMenuItem_DownLoad.Enabled = true;
            // 使能“保存配置到文档”按钮
            toolStripMenuItem_Save.Enabled = true;
            // 使能“读取控制器配置”按钮
            toolStripMenuItem_UpLoad.Enabled = true;

            try
            {
                // 若初始化路径不为空，则打开使用过的路径
                if (EET_saveFileDialog.InitialDirectory != "")
                {
                    EET_saveFileDialog.InitialDirectory = EET_saveFileDialog.FileName.Substring(0, EET_saveFileDialog.FileName.LastIndexOf("\\"));
                }
                else
                {
                    EET_saveFileDialog.InitialDirectory = Application.StartupPath;
                }
            }
            catch
            {
                EET_saveFileDialog.InitialDirectory = Application.StartupPath;
            }
            EET_saveFileDialog.FileName = EET_saveFileDialog.InitialDirectory + "\\" + "EET_" + System.DateTime.Now.ToString("yyyyMMdd_HHmmss");
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
            try
            {
                if (EET_saveFileDialog.FileName != "")
                {
                    //System.Diagnostics.Process.Start("explorer.exe", "/select," + EET_saveFileDialog.FileName);
                    System.Diagnostics.Process.Start("explorer.exe", EET_saveFileDialog.FileName.Substring(0, EET_saveFileDialog.FileName.LastIndexOf("\\")));
                }
                else
                {
                    System.Diagnostics.Process.Start("explorer.exe", Application.StartupPath);
                }
            }
            catch
            {
                System.Diagnostics.Process.Start("explorer.exe", Application.StartupPath);
            }
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
            try
            {
                // 禁用控件
                EET_myToolStripFocus.Enabled = false;
                groupBox_Parameters.Enabled = false;
                groupBox_Function.Enabled = false;
                groupBox_Display.Enabled = false;
                // 禁用设置串口端口号
                toolStripComboBox_PortName.Enabled = false;

                // 串口打开状态
                gsb_SerialPort_IsOpen = false;
                // 打开串口
                ChangeSerialPortStatus(Form1.gsb_SerialPort_IsOpen);

                if (m_portDispl.serialPort.IsOpen == true)
                {
                    // 设置显示串口状态的Label颜色及文字
                    toolStripStatusLabel1.Text = "已打开";
                    toolStripStatusLabel1.BackColor = Color.Lime;

                    // 使能定时器
                    timer_Receive.Enabled = true;
                    // 调用发送接收指令的流程
                    SerialPortSend.CommandReceiveProcess(this);
                    // 设置为接收状态
                    SerialPortSend.gss_IsIdleOrReceiveOrSend = SerialPortSend.gss_serialPortStatus[1];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                // 使能控件
                EET_myToolStripFocus.Enabled = true;
                // 使能设置串口端口号
                toolStripComboBox_PortName.Enabled = true;
            }
        }

        // 下载配置到控制器
        private void toolStripMenuItem_DownLoad_Click(object sender, EventArgs e)
        {
            try
            {
                // 禁用控件
                EET_myToolStripFocus.Enabled = false;
                groupBox_Parameters.Enabled = false;
                groupBox_Function.Enabled = false;
                groupBox_Display.Enabled = false;
                // 禁用设置串口端口号
                toolStripComboBox_PortName.Enabled = false;

                // 调用计算的方法，生成修改后的的变量
                GenerateParameters.UIToParameters(this);

                // 串口打开状态
                gsb_SerialPort_IsOpen = false;
                // 打开串口
                ChangeSerialPortStatus(Form1.gsb_SerialPort_IsOpen);

                if (m_portDispl.serialPort.IsOpen == true)
                {
                    // 设置显示串口状态的Label颜色及文字
                    toolStripStatusLabel1.Text = "已打开";
                    toolStripStatusLabel1.BackColor = Color.Lime;

                    // 使能定时器
                    timer_Send.Enabled = true;
                    // 调用发送发送指令的流程
                    SerialPortSend.CommandSendPrecess(this);
                    // 设置为发送状态
                    SerialPortSend.gss_IsIdleOrReceiveOrSend = SerialPortSend.gss_serialPortStatus[2];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                // 使能控件
                EET_myToolStripFocus.Enabled = true;
                groupBox_Parameters.Enabled = true;
                groupBox_Function.Enabled = true;
                groupBox_Display.Enabled = true;
                // 使能设置串口端口号
                toolStripComboBox_PortName.Enabled = true;
            }
        }

        // 置顶
        private void toolStripMenuItem_TopMost_Click(object sender, EventArgs e)
        {
            if (toolStripMenuItem_TopMost.Checked == false)
            {
                toolStripMenuItem_TopMost.Checked = true;
                this.TopMost = true;
            }
            else
            {
                toolStripMenuItem_TopMost.Checked = false;
                this.TopMost = false;
            }
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
                trackBar_BrakingPotency.Enabled = false;
            }
            else
            {
                trackBar_BrakingPotency.Enabled = true;
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

        #region --定时器--

        // 发送指令定时器
        private void timer_Send_Tick(object sender, EventArgs e)
        {
            // 调用发送发送指令的流程
            SerialPortSend.CommandSendPrecess(this);
        }

        // 接收指令定时器
        private void timer_Receive_Tick(object sender, EventArgs e)
        {
            // 调用发送接收指令的流程
            SerialPortSend.CommandReceiveProcess(this);
        }

        // 等待接收所有指令
        private void timer_WaitForAllCommand_Tick(object sender, EventArgs e)
        {
            gsi_WaitForAllCommandCounter++;

            if (gsi_WaitForAllCommandCounter >= gsi_WaitForAllCommandCounter_Max)
            {
                // 清零重置
                gsi_WaitForAllCommandCounter = 0;

                // 停止全部指令接收完成定时器
                timer_WaitForAllCommand.Enabled = false;

                // 读取数据的接收处理
                if (SerialPortSend.gss_IsIdleOrReceiveOrSend == SerialPortSend.gss_serialPortStatus[1])
                {
                    // 使能控件
                    EET_myToolStripFocus.Enabled = true;

                    // 停止定时器
                    timer_Receive.Enabled = false;

                    // 显示指令发送状态
                    toolStripStatusLabel_NowStatus.Text = "通讯出错，请重新读取！";

                    // 发送失败，重置发送指令计数
                    SerialPortSend.gsui_myCommandCounter = 1;

                    // 重发计数清零
                    SerialPortSend.gsi_ReSendCount = 0;

                    // 串口打开状态
                    gsb_SerialPort_IsOpen = true;
                    // 关闭串口
                    ChangeSerialPortStatus(gsb_SerialPort_IsOpen);
                    // 设置为空闲状态
                    SerialPortSend.gss_IsIdleOrReceiveOrSend = SerialPortSend.gss_serialPortStatus[0];

                    // 设置显示串口状态的Label颜色及文字
                    toolStripStatusLabel1.Text = "已关闭";
                    toolStripStatusLabel1.BackColor = Color.Red;

                    // 使能设置串口端口号
                    toolStripComboBox_PortName.Enabled = true;
                }
                // 发送数据的接收处理
                else if (SerialPortSend.gss_IsIdleOrReceiveOrSend == SerialPortSend.gss_serialPortStatus[2])
                {
                    // 停止定时器
                    timer_Send.Enabled = false;

                    // 显示指令发送状态
                    toolStripStatusLabel_NowStatus.Text = "通讯出错，请重新发送！";

                    // 完成发送，发送指令计数复位
                    SerialPortSend.gsui_myCommandCounter = 1;

                    // 重发计数清零
                    SerialPortSend.gsi_ReSendCount = 0;

                    // 使能控件
                    EET_myToolStripFocus.Enabled = true;
                    groupBox_Parameters.Enabled = true;
                    groupBox_Function.Enabled = true;
                    groupBox_Display.Enabled = true;

                    // 串口打开状态
                    Form1.gsb_SerialPort_IsOpen = true;
                    // 关闭串口
                    ChangeSerialPortStatus(gsb_SerialPort_IsOpen);
                    // 设置为空闲状态
                    SerialPortSend.gss_IsIdleOrReceiveOrSend = SerialPortSend.gss_serialPortStatus[0];

                    // 设置显示串口状态的Label颜色及文字
                    toolStripStatusLabel1.Text = "已关闭";
                    toolStripStatusLabel1.BackColor = Color.Red;

                    // 使能设置串口端口号
                    toolStripComboBox_PortName.Enabled = true;
                }
            }
            else
            {
                // 读取数据的接收处理
                if (SerialPortSend.gss_IsIdleOrReceiveOrSend == SerialPortSend.gss_serialPortStatus[1])
                {
                    // 当读取参数接收数据计数值满足要求，认为接收完成
                    if (SerialPortReceive.gsi_GetAllCommandCounter_Receive == 8)
                    {
                        // 读取参数接收数据计数清零
                        SerialPortReceive.gsi_GetAllCommandCounter_Receive = 0;

                        // 清零重置
                        gsi_WaitForAllCommandCounter = 0;

                        // 停止全部指令接收完成定时器
                        timer_WaitForAllCommand.Enabled = false;

                        // 显示指令发送完毕
                        toolStripStatusLabel_NowStatus.Text = "指令发送完毕，应答正确！";

                        // 发送完成，重置发送指令计数
                        SerialPortSend.gsui_myCommandCounter = 1;

                        // 重发计数清零
                        SerialPortSend.gsi_ReSendCount = 0;

                        // 使能控件
                        EET_myToolStripFocus.Enabled = true;
                        groupBox_Parameters.Enabled = true;
                        groupBox_Function.Enabled = true;
                        groupBox_Display.Enabled = true;

                        // 使能按钮
                        toolStripMenuItem_Save.Enabled = true;
                        toolStripMenuItem_DownLoad.Enabled = true;

                        // 串口打开状态
                        gsb_SerialPort_IsOpen = true;
                        // 关闭串口
                        ChangeSerialPortStatus(gsb_SerialPort_IsOpen);
                        // 设置为空闲状态
                        SerialPortSend.gss_IsIdleOrReceiveOrSend = SerialPortSend.gss_serialPortStatus[0];

                        // 设置显示串口状态的Label颜色及文字
                        toolStripStatusLabel1.Text = "已关闭";
                        toolStripStatusLabel1.BackColor = Color.Red;

                        // 使能设置串口端口号
                        toolStripComboBox_PortName.Enabled = true;
                    }
                }
                // 发送数据的接收处理
                else if (SerialPortSend.gss_IsIdleOrReceiveOrSend == SerialPortSend.gss_serialPortStatus[2])
                {
                    // 当发送参数接收数据计数值满足要求，认为接收完成
                    if (SerialPortReceive.gsi_GetAllCommandCounter_Send == 6)
                    {
                        // 发送参数接收数据计数清零
                        SerialPortReceive.gsi_GetAllCommandCounter_Send = 0;

                        // 清零重置
                        gsi_WaitForAllCommandCounter = 0;

                        // 停止全部指令接收完成定时器
                        timer_WaitForAllCommand.Enabled = false;

                        // 显示指令发送完毕
                        toolStripStatusLabel_NowStatus.Text = "指令发送完毕，应答正确！";

                        // 完成发送，发送指令计数复位
                        SerialPortSend.gsui_myCommandCounter = 1;

                        // 重发计数清零
                        SerialPortSend.gsi_ReSendCount = 0;

                        // 使能控件
                        EET_myToolStripFocus.Enabled = true;
                        groupBox_Parameters.Enabled = true;
                        groupBox_Function.Enabled = true;
                        groupBox_Display.Enabled = true;

                        // 串口打开状态
                        Form1.gsb_SerialPort_IsOpen = true;
                        // 关闭串口
                        ChangeSerialPortStatus(gsb_SerialPort_IsOpen);
                        // 设置为空闲状态
                        SerialPortSend.gss_IsIdleOrReceiveOrSend = SerialPortSend.gss_serialPortStatus[0];

                        // 设置显示串口状态的Label颜色及文字
                        toolStripStatusLabel1.Text = "已关闭";
                        toolStripStatusLabel1.BackColor = Color.Red;

                        // 使能设置串口端口号
                        toolStripComboBox_PortName.Enabled = true;
                    }
                }
            }
        }

        #endregion

        #region --新串口的事件及委托--

        /**************************************************************/
        /*************************** 串口类 ***************************/
        /**************************************************************/
        /// <summary>
        /// 定义了一个委托类型
        /// </summary>
        public delegate void WhenGetNew();

        /// <summary>
        /// 串口封装类，Help By Wyz
        /// </summary>
        public class PortDataDisplay
        {
            /// <summary>
            /// 系统串口类
            /// </summary>
            public SerialPort serialPort = new SerialPort(gss_SerialPort_PortName, gsi_SerialPort_BaudRate);
            /// <summary>
            /// 解析得到数据后触发事件
            /// </summary>
            public event WhenGetNew whenGetNew;
            /// <summary>
            /// 处理线程
            /// </summary>
            private SerialDataReceivedEventHandler threadCallHandler;
            /// <summary>
            /// 对外的数据类型定义
            /// </summary>
            public string dataSrc = "";
            /// <summary>
            /// 准备关闭串口=true
            /// </summary>
            private bool m_IsTryToClosePort = false;
            /// <summary>
            /// true表示正在接收数据
            /// </summary>
            private bool m_IsReceiving = false;


            /// <summary>
            /// 初始化
            /// </summary>
            public PortDataDisplay()
            {
            }

            /// <summary>
            /// 有参数的构造函数
            /// </summary>
            /// <param name="PortName">串口号，如"COM1"</param>
            /// <param name="BaudRate">波特率，如9600</param>
            public PortDataDisplay(string PortName, int BaudRate)
            {
                serialPort = new SerialPort(PortName, BaudRate);
            }

            /// <summary>
            /// 开始工作
            /// </summary>
            public void ConnectDeveice()
            {
                //0.注册事件
                serialPort.DataReceived -= OnSerialPortDataCome;
                serialPort.DataReceived += OnSerialPortDataCome;
                //1.再设置一下串口参数
                if (this.serialPort.IsOpen == false)
                {
                    this.serialPort.ReadBufferSize = 1000;
                    this.serialPort.ReceivedBytesThreshold = 1;//数据达到120的时候才就要触发事件，不行！！应该是数据来就触发
                    //2.打开串口开始工作
                    m_IsTryToClosePort = false;
                    this.serialPort.Open();
                }
            }

            /// <summary>
            /// 结束工作
            /// </summary>
            public void DisconnectDeveice() // 关键和核心！！！
            {
                m_IsTryToClosePort = true;
                while (m_IsReceiving)
                {
                    System.Windows.Forms.Application.DoEvents();
                }
                serialPort.Close();
            }

            /// <summary>
            /// 当通知到有数据达到120时处理（读取，与分析）
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void OnSerialPortDataCome(object sender, SerialDataReceivedEventArgs e)
            {
                if (m_IsTryToClosePort) // 关键！！！
                {
                    return;
                }

                m_IsReceiving = true; // 关键!!!

                try
                {
                    if (threadCallHandler == null)
                    {
                        threadCallHandler = new SerialDataReceivedEventHandler(OnSerialPortDataCome);
                    }
                    //定义存储接收数据的数组为1
                    byte[] result = new byte[1];
                    //定义接收字符串存储的数组、启示位置、长度
                    serialPort.Read(result, 0, result.Length);
                    // ASCII码
                    foreach (byte basc in result)
                    {
                        dataSrc = ((char)ulong.Parse(basc.ToString(), System.Globalization.NumberStyles.HexNumber - 10)).ToString();//减10，能得出正确的结果，我也不明白原因，有待研究！！！
                    }
                    if (dataSrc != "" && this.whenGetNew != null)
                    {
                        this.whenGetNew();
                    }
                }
                finally // 放在finally里面比较好。
                {
                    m_IsReceiving = false; // 关键!!!
                }
            }
        }

        /**************************************************************/
        /************************** 串实例化 **************************/
        /**************************************************************/
        public PortDataDisplay m_portDispl = new PortDataDisplay(gss_SerialPort_PortName, gsi_SerialPort_BaudRate);

        // 设置串口开和关
        public void ChangeSerialPortStatus(bool myNowStatus)
        {
            if (myNowStatus == false)
            {
                m_portDispl.whenGetNew -= portDispl_whenGetNew;
                m_portDispl.whenGetNew += new WhenGetNew(portDispl_whenGetNew);
                m_portDispl.ConnectDeveice();
                gsb_SerialPort_IsOpen = true;
            }
            else if (myNowStatus == true)
            {
                m_portDispl.DisconnectDeveice();
                gsb_SerialPort_IsOpen = false;
            }
        }

        // 
        private void portDispl_whenGetNew()
        {
            WhenGetNew ehan = delegate
            {
                // 接收数据的处理
                SerialPortReceive.SerialPortReceiveProcess(this, m_portDispl.dataSrc);
            };

            try
            {
                if (InvokeRequired)
                {
                    this.Invoke(ehan);
                }
            }
            catch
            {
            }
        }
        #endregion
    }
}