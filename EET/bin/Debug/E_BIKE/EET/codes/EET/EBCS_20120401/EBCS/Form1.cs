using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EBCS
{
    public partial class Form1 : Form
    {
        #region --变量定义--

        // g  代表全局变量  global
        // s  代表静态变量  static
        // s  代表字符串    string

        /* 参数设定区 */
        // 电机相序值
        public static string gss_MotorSequence = "";
        // 霍尔相位差值
        public static string gss_HallPhaseValue = "";
        // 调速范围上限值
        public static string gss_SpeedUpperBound = "";
        // 调速范围下限值
        public static string gss_SpeedLowerBound = "";
        // 防飞车保护上限值
        public static string gss_ProtectionUpperBound = "";
        // 防飞车保护下限值
        public static string gss_ProtectionLowerBound = "";
        // 相电流峰值
        public static string gss_PhaseCurrentPeak = "";
        // 电池容量值
        public static string gss_BatteryType = "";
        // 电池欠压值
        public static string gss_BatteryMinimumVoltage = "";
        // 电池过压值
        public static string gss_BatteryMaximumVoltage = "";
        // 堵转保护电流值
        public static string gss_LockedRotorProtectionCurrentValue = "";

        /* 功能选择区 */

        // 限速限流选择
        public static string gss_SpeedAndAmpereLimit_Select = "";
        // 限速限流 无限速 限速值 提速
        public static string gss_SNLAccelerationSpeed = "";
        // 限速限流 无限速 限速值 高速
        public static string gss_SNLHighSpeed = "";
        // 限速限流 无限速 限速值 中速
        public static string gss_SNLMidSpeed = "";
        // 限速限流 无限速 限速值 低速
        public static string gss_SNLLowSpeed = "";
        // 限速限流 无限速 限流值 提速
        public static string gss_SNLAccelerationAmpere = "";
        // 限速限流 无限速 限流值 高速
        public static string gss_SNLHighAmpere = "";
        // 限速限流 无限速 限流值 中速
        public static string gss_SNLMidAmpere = "";
        // 限速限流 无限速 限流值 低速
        public static string gss_SNLLowAmpere = "";
        // 限速限流 有限速 限速值 提速
        public static string gss_SLAccelerationSpeed = "";
        // 限速限流 有限速 限速值 高速
        public static string gss_SLHighSpeed = "";
        // 限速限流 有限速 限速值 中速
        public static string gss_SLMidSpeed = "";
        // 限速限流 有限速 限速值 低速
        public static string gss_SLLowSpeed = "";
        // 限速限流 有限速 限流值 提速
        public static string gss_SLAccelerationAmpere = "";
        // 限速限流 有限速 限流值 高速
        public static string gss_SLHighAmpere = "";
        // 限速限流 有限速 限流值 中速
        public static string gss_SLMidAmpere = "";
        // 限速限流 有限速 限流值 低速
        public static string gss_SLLowAmpere = "";

        // 巡航功能选择
        public static string gss_Cruise_Select = "";
        // 巡航功能
        public static string gss_Cruise = "";

        // 电动巡航助力转换选择
        public static string gss_CruiseSwitch_Select = "";
        // 电动巡航助力转换
        public static string gss_CruiseSwitch = "";

        // 自动巡航手柄稳定时间选择
        public static string gss_AutoHoldTime_Select = "";
        // 自动巡航手柄稳定时间
        public static string gss_AutoHoldTime = "";

        // 手动巡航按键保持时间选择
        public static string gss_ManualHoldTime_Select = "";
        // 手动巡航按键保持时间
        public static string gss_ManualHoldTime = "";

        // 助力功能选择
        public static string gss_Boost_Select = "";
        // 助力功能
        public static string gss_Boost = "";

        // 三态显示选择
        public static string gss_ThreeStatusShowSwitch_Select = "";
        // 三态显示
        public static string gss_ThreeStatusShowSwitch = "";

        // 刹车功能选择
        public static string gss_Braking_Select = "";
        // 刹车功能
        public static string gss_Braking = "";

        // 多速实现选择
        public static string gss_MoreSpeed_Select = "";
        // 多速实现
        public static string gss_MoreSpeed = "";

        // 模拟速度显示选择
        public static string gss_SimulationSpeedShow_Select = "";
        // 模拟速度显示
        public static string gss_SimulationSpeedShow = "";

        // 模拟电流显示选择
        public static string gss_SimulationCurrentShow_Select = "";
        // 模拟电流显示
        public static string gss_SimulationCurrentShow = "";

        /* 隐藏的需保存变量 */
        // 霍尔边沿1角度值
        public static string gss_HallForwardAngle_1 = "";
        // 霍尔边沿2角度值
        public static string gss_HallForwardAngle_2 = "";
        // 霍尔边沿3角度值
        public static string gss_HallForwardAngle_3 = "";
        // 霍尔边沿4角度值
        public static string gss_HallForwardAngle_4 = "";
        // 霍尔边沿5角度值
        public static string gss_HallForwardAngle_5 = "";
        // 霍尔边沿6角度值
        public static string gss_HallForwardAngle_6 = "";
        // 霍尔反向边沿1角度值
        public static string gss_HallReverseAngle_1 = "";
        // 霍尔反向边沿2角度值
        public static string gss_HallReverseAngle_2 = "";
        // 霍尔反向边沿3角度值
        public static string gss_HallReverseAngle_3 = "";
        // 霍尔反向边沿4角度值
        public static string gss_HallReverseAngle_4 = "";
        // 霍尔反向边沿5角度值
        public static string gss_HallReverseAngle_5 = "";
        // 霍尔反向边沿6角度值
        public static string gss_HallReverseAngle_6 = "";
        // 限速线分压系数
        public static string gss_SpeedLimitVoltageDivideCoefficient = "";

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
            this.MaximizeBox = false;
            // 第一个变量控件获取焦点
            comboBox_MotorSequence.Focus();
            // 添加comboBox的默认值
            comboBox_MotorSequence.Text = comboBox_MotorSequence.Items[0].ToString();
            comboBox_HallPhaseValue.Text = comboBox_HallPhaseValue.Items[0].ToString();
            comboBox_BatteryType.Text = comboBox_BatteryType.Items[0].ToString();
            comboBox_Cruise.Text = comboBox_Cruise.Items[0].ToString();
            comboBox_CruiseSwitch.Text = comboBox_CruiseSwitch.Items[0].ToString();
            comboBox_ThreeStatusShowSwitch.Text = comboBox_ThreeStatusShowSwitch.Items[0].ToString();
            comboBox_Braking.Text = comboBox_Braking.Items[0].ToString();
            comboBox_Boost.Text = comboBox_Boost.Items[0].ToString();
        }

        #endregion


        // 下载配置到目标
        private void DownLoad_button_Click(object sender, EventArgs e)
        {
            toolStripProgressBar1.Visible = true;
            // 测试ProgressBar
            for (; toolStripProgressBar1.Value < 100; )//循环
            {
                // 暂停1秒
                System.Threading.Thread.Sleep(20);
                // 让进度条增加一次
                toolStripProgressBar1.Value += toolStripProgressBar1.Step;
                // 如果进度条满后，退出循环，清空进度条
                if (toolStripProgressBar1.Value >= 100)
                {
                    System.Threading.Thread.Sleep(1000);
                    toolStripProgressBar1.Visible = false;
                    toolStripProgressBar1.Value = 0;
                    break;
                }
            }
        }

        // 隐藏的框体“限速线分压系数”的双击文字全选事件 
        private void myTextBoxNUM_SpeedLimitVoltageDivideCoefficient_Lable_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // 双击显示的文字：限速线分压系数
            myTextBoxNUM_SpeedLimitVoltageDivideCoefficient_Lable.Text = "限速线分压系数";
            // 选择所有文字
            myTextBoxNUM_SpeedLimitVoltageDivideCoefficient_Lable.SelectAll();
            // 使能隐藏的输入框体
            myTextBoxNUM_SpeedLimitVoltageDivideCoefficient.Enabled = true;
        }

        // 生成所有参数
        private void button1_Click(object sender, EventArgs e)
        {
        }

        // 关于
        private void toolStripButton_About_Click(object sender, EventArgs e)
        {
            About EBCS_About = new About();
            EBCS_About.ShowDialog();
        }

        //#region --变量赋值--

        // 
        private void myTextBoxNUM_SpeedLowerBound_TextChanged(object sender, EventArgs e)
        {
            gss_SpeedLowerBound = myTextBoxNUM_SpeedLowerBound.Text;
        }

        //#endregion

        //#region --变量范围--

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
            gss_SpeedUpperBound = Convert.ToInt32(Convert.ToDouble(myTextBoxNUM_SpeedUpperBound.Text) * 255 / 5).ToString();
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
            try
            {
                if (Convert.ToDouble(myTextBoxNUM_PhaseCurrentPeak.Text) < (6))
                {
                    myTextBoxNUM_PhaseCurrentPeak.Text = "6";
                }
                else if (Convert.ToDouble(myTextBoxNUM_PhaseCurrentPeak.Text) > (80))
                {
                    myTextBoxNUM_PhaseCurrentPeak.Text = "80";
                }
            }
            catch (Exception)
            {
                myTextBoxNUM_PhaseCurrentPeak.Text = "20";
            }
        }

        // 电池过压保护值
        private void myTextBoxNUM_BatteryMaximumVoltage_Leave(object sender, EventArgs e)
        {
            // 48V电池
            if (comboBox_BatteryType.SelectedIndex == 0)
            {
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_BatteryMaximumVoltage.Text) < (48))
                    {
                        myTextBoxNUM_BatteryMaximumVoltage.Text = "48";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_BatteryMaximumVoltage.Text) > (56))
                    {
                        myTextBoxNUM_BatteryMaximumVoltage.Text = "56";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_BatteryMaximumVoltage.Text = "54";
                }
            }
            // 36V电池
            else if (comboBox_BatteryType.SelectedIndex == 1)
            {
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_BatteryMaximumVoltage.Text) < (36))
                    {
                        myTextBoxNUM_BatteryMaximumVoltage.Text = "36";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_BatteryMaximumVoltage.Text) > (42))
                    {
                        myTextBoxNUM_BatteryMaximumVoltage.Text = "42";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_BatteryMaximumVoltage.Text = "41";
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
                        myTextBoxNUM_BatteryMinimumVoltage.Text = "42";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_BatteryMinimumVoltage.Text) > (48))
                    {
                        myTextBoxNUM_BatteryMinimumVoltage.Text = "48";
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
                        myTextBoxNUM_BatteryMinimumVoltage.Text = "28";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_BatteryMinimumVoltage.Text) > (36))
                    {
                        myTextBoxNUM_BatteryMinimumVoltage.Text = "36";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_BatteryMinimumVoltage.Text = "30";
                }
            }
        }

        // 电机相序变更
        private void comboBox_MotorSequence_SelectedIndexChanged(object sender, EventArgs e)
        {
            gss_MotorSequence = comboBox_MotorSequence.SelectedIndex.ToString();
        }

        // 霍尔相差 Select
        private void comboBox_HallPhaseValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            gss_HallPhaseValue = comboBox_HallPhaseValue.SelectedIndex.ToString();
        }

        // 电池容量 Select
        private void comboBox_BatteryType_SelectedIndexChanged(object sender, EventArgs e)
        {
            gss_BatteryType = comboBox_BatteryType.SelectedIndex.ToString();
        }

        // 堵转保护电流
        private void myTextBoxNUM_LockedRotorProtectionCurrentValue_Leave(object sender, EventArgs e)
        {

        }


        
        //#endregion
    }
}