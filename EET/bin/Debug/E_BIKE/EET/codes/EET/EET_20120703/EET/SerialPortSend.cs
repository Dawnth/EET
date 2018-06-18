using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace EET
{
    class SerialPortSend
    {
        // 状态数组
        public static string[] gss_serialPortStatus = new String[] { "Idle", "Receive", "Send" };

        // 标记当前处于空闲(Idle)还是接收(Receive)或者发送(Send)状态
        public static string gss_IsIdleOrReceiveOrSend = gss_serialPortStatus[0];

        // 重新发送次数
        public static int gsi_ReSendCount = 0;
        public static int gsi_MaxReSendCount = 2;
        
        // 用来记录发送的指令数
        // 从1开始，非从0开始，方便代码查看
        public static uint gsui_myCommandCounter = 1;

        // 完整的指令
        public static string gss_myFullCommand = "";

        // 起始符
        public static string gss_myStart = "";

        // 源地址
        public static string gss_mySouceAddr = "FF";

        // 发送参数指令的目标地址
        public static string gss_myTargetAddr_Send = "00";

        // 读取参数指令的目标地址
        public static string gss_myTargetAddr_Receive = "11";

        // 指令编号
        public static string gss_myCommandNumber = "00";

        // 指令长度
        public static string gss_myCommandLength = "00";

        // 数据在此

        // 校验和
        public static string gss_myChecksum = "";

        // 结束符
        public static string gss_myStop = "";

        // 进度条的增长值
        public static int gsi_ProgressBar_IncreaseValue_Send = 16;
        public static int gsi_ProgressBar_IncreaseValue_Receive = 12;

        #region --接收数据发送指令集--

        // 指令1
        public static string gss_mySendCommand_R1 = "FF11F10001";
        // 指令2
        public static string gss_mySendCommand_R2 = "FF11F20002";
        // 指令3
        public static string gss_mySendCommand_R3 = "FF11F30003";
        // 指令4
        public static string gss_mySendCommand_R4 = "FF11F40004";
        // 指令5
        public static string gss_mySendCommand_R5 = "FF11F50005";
        // 指令6
        public static string gss_mySendCommand_R6 = "FF11F60006";
        // 指令7
        public static string gss_mySendCommand_R7 = "FF11F70007";
        // 指令8
        public static string gss_mySendCommand_R8 = "FF11F80008";
        // 指令9
        public static string gss_mySendCommand_R9 = "FF11F90009";
        // 指令10
        public static string gss_mySendCommand_R10 = "FF11FA000A";

        #endregion

        #region --发送数据发送指令集--

        // 指令1
        public static string gss_mySendCommand_S1 = "F1";
        // 指令2
        public static string gss_mySendCommand_S2 = "F2";
        // 指令3
        public static string gss_mySendCommand_S3 = "F3";
        // 指令4
        public static string gss_mySendCommand_S4 = "F4";
        // 指令5
        public static string gss_mySendCommand_S5 = "F5";
        // 指令6
        public static string gss_mySendCommand_S6 = "F6";
        // 指令7
        public static string gss_mySendCommand_S7 = "F7";
        // 指令8
        public static string gss_mySendCommand_S8 = "F8";
        // 指令9
        public static string gss_mySendCommand_S9 = "F9";
        // 指令10
        public static string gss_mySendCommand_S10 = "FA";

        #endregion

        // 串口从变频板读取参数的发送指令处理过程
        public static void CommandReceiveProcess(Form1 fm)
        {
            try
            {
                // 按条发送的循环
                // 例如：当myCommandCounter值为10时，即发送了10条指令，
                // 停止发送循环，设置其值为1
                switch (gsui_myCommandCounter)
                {
                    case 1:
                        gsui_myCommandCounter++;
                        // 发送第一组数据
                        mySentCommand_R(fm, gss_mySendCommand_R1);
                        // 清空进度条
                        fm.toolStripProgressBar_Status.Value = 0;
                        // 显示进度条
                        fm.toolStripProgressBar_Status.Visible = true;
                        // 让进度条增加一次
                        fm.toolStripProgressBar_Status.Value += gsi_ProgressBar_IncreaseValue_Receive;
                        break;
                    case 2:
                        gsui_myCommandCounter++;
                        // 发送第二组数据
                        mySentCommand_R(fm, gss_mySendCommand_R2);
                        // 让进度条增加一次
                        fm.toolStripProgressBar_Status.Value += gsi_ProgressBar_IncreaseValue_Receive;
                        break;
                    case 3:
                        gsui_myCommandCounter++;
                        // 发送第三组数据
                        mySentCommand_R(fm, gss_mySendCommand_R3);
                        // 让进度条增加一次
                        fm.toolStripProgressBar_Status.Value += gsi_ProgressBar_IncreaseValue_Receive;
                        break;
                    case 4:
                        gsui_myCommandCounter++;
                        // 发送第四组数据
                        mySentCommand_R(fm, gss_mySendCommand_R4);
                        // 让进度条增加一次
                        fm.toolStripProgressBar_Status.Value += gsi_ProgressBar_IncreaseValue_Receive;
                        break;
                    case 5:
                        gsui_myCommandCounter++;
                        // 发送第五组数据
                        mySentCommand_R(fm, gss_mySendCommand_R5);
                        // 让进度条增加一次
                        fm.toolStripProgressBar_Status.Value += gsi_ProgressBar_IncreaseValue_Receive;
                        break;
                    case 6:
                        gsui_myCommandCounter++;
                        // 发送第五组数据
                        mySentCommand_R(fm, gss_mySendCommand_R6);
                        // 让进度条增加一次
                        fm.toolStripProgressBar_Status.Value += gsi_ProgressBar_IncreaseValue_Receive;
                        break;
                    case 7:
                        gsui_myCommandCounter++;
                        // 发送第五组数据
                        mySentCommand_R(fm, gss_mySendCommand_R7);
                        // 让进度条增加一次
                        fm.toolStripProgressBar_Status.Value += gsi_ProgressBar_IncreaseValue_Receive;
                        break;
                    case 8:
                        // 停止定时器
                        fm.timer_Receive.Enabled = false;
                        // 最后一组数据数据
                        mySentCommand_R(fm, gss_mySendCommand_R8);

                        // 放在接收应答处
                        // 显示指令发送完毕
                        fm.toolStripStatusLabel_NowStatus.Text = "指令发送完毕，应答正确";

                        // 进度条加满
                        fm.toolStripProgressBar_Status.Value = 100;
                        System.Threading.Thread.Sleep(500);
                        fm.toolStripProgressBar_Status.Visible = false;
                        fm.toolStripProgressBar_Status.Value = 0;

                        // 完成发送，重置状态
                        gsui_myCommandCounter = 1;

                        // 使能控件
                        fm.EET_myToolStripFocus.Enabled = true;
                        fm.groupBox1.Enabled = true;
                        fm.groupBox2.Enabled = true;
                        fm.groupBox3.Enabled = true;

                        // 使能按钮
                        fm.toolStripMenuItem_Save.Enabled = true;
                        fm.toolStripMenuItem_DownLoad.Enabled = true;

                        // 串口打开状态
                        Form1.gsb_SerialPort_IsOpen = true;
                        // 关闭串口
                        fm.ChangeSerialPortStatus(Form1.gsb_SerialPort_IsOpen);
                        // 设置为空闲状态
                        SerialPortSend.gss_IsIdleOrReceiveOrSend = SerialPortSend.gss_serialPortStatus[0];

                        // 使能设置串口端口号
                        fm.toolStripComboBox_PortName.Enabled = true;
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // 显示指令发送状态
                fm.toolStripStatusLabel_NowStatus.Text = "通讯出错，请重新读取！";
                // 如果出错，重置状态
                fm.timer_Receive.Enabled = false;

                // 完成发送，重置状态
                gsui_myCommandCounter = 1;

                // 使能控件
                fm.EET_myToolStripFocus.Enabled = true;

                // 串口打开状态
                Form1.gsb_SerialPort_IsOpen = true;
                // 关闭串口
                fm.ChangeSerialPortStatus(Form1.gsb_SerialPort_IsOpen);
                // 设置为空闲状态
                SerialPortSend.gss_IsIdleOrReceiveOrSend = SerialPortSend.gss_serialPortStatus[0];

                // 使能设置串口端口号
                fm.toolStripComboBox_PortName.Enabled = true;
            }
        }

        // 串口发送参数到变频板的发送指令处理过程
        // 采用ASCII码方式发送
        public static void CommandSendPrecess(Form1 fm)
        {
            try
            {
                // 按条发送的循环
                // 例如：当myCommandCounter值为10时，即发送了10条指令，
                // 停止发送循环，设置其值为1
                switch (gsui_myCommandCounter)
                {
                    case 1:
                        gsui_myCommandCounter++;
                        // 发送第一组数据
                        mySentCommand_S(fm, gss_mySendCommand_S1,
                            Form1.gss_MotorSequence +
                            Form1.gss_BatteryType +
                            Form1.gss_HallPhaseValue +
                            Form1.gss_LockedRotorProtectionCurrentValue +
                            Form1.gss_SpeedUpperBound +
                            Form1.gss_SpeedLowerBound
                            );
                        // 清空进度条
                        fm.toolStripProgressBar_Status.Value = 0;
                        // 显示进度条
                        fm.toolStripProgressBar_Status.Visible = true;
                        // 让进度条增加一次
                        fm.toolStripProgressBar_Status.Value += gsi_ProgressBar_IncreaseValue_Send;
                        break;
                    case 2:
                        gsui_myCommandCounter++;
                        // 发送第二组数据
                        mySentCommand_S(fm, gss_mySendCommand_S2,
                            Form1.gss_BatteryMaximumVoltage +
                            Form1.gss_BatteryMinimumVoltage +
                            Form1.gss_BatteryMaximumVoltage_36V +
                            Form1.gss_BatteryMinimumVoltage_36V +
                            Form1.gss_ProtectionUpperBound +
                            Form1.gss_ProtectionLowerBound +
                            Form1.gss_PhaseCurrentPeak
                            );
                        // 让进度条增加一次
                        fm.toolStripProgressBar_Status.Value += gsi_ProgressBar_IncreaseValue_Send;
                        break;
                    case 3:
                        gsui_myCommandCounter++;
                        // 发送第三组数据
                        mySentCommand_S(fm, gss_mySendCommand_S3,
                            Form1.gss_SNLAccelerationSpeed +
                            Form1.gss_SNLHighSpeed +
                            Form1.gss_SNLMidSpeed +
                            Form1.gss_SNLLowSpeed +
                            Form1.gss_SNLAccelerationAmpere +
                            Form1.gss_SNLHighAmpere +
                            Form1.gss_SNLMidAmpere +
                            Form1.gss_SNLLowAmpere
                            );
                        // 让进度条增加一次
                        fm.toolStripProgressBar_Status.Value += gsi_ProgressBar_IncreaseValue_Send;
                        break;
                    case 4:
                        gsui_myCommandCounter++;
                        // 发送第四组数据
                        mySentCommand_S(fm, gss_mySendCommand_S4,
                            Form1.gss_SLAccelerationSpeed +
                            Form1.gss_SLHighSpeed +
                            Form1.gss_SLMidSpeed +
                            Form1.gss_SLLowSpeed +
                            Form1.gss_SLAccelerationAmpere +
                            Form1.gss_SLHighAmpere +
                            Form1.gss_SLMidAmpere +
                            Form1.gss_SLLowAmpere
                            );
                        // 让进度条增加一次
                        fm.toolStripProgressBar_Status.Value += gsi_ProgressBar_IncreaseValue_Send;
                        break;
                    case 5:
                        gsui_myCommandCounter++;
                        // 发送第五组数据
                        mySentCommand_S(fm, gss_mySendCommand_S5,
                            Form1.gss_Cruise +
                            Form1.gss_CruiseSwitch +
                            Form1.gss_AutoHoldTime +
                            Form1.gss_ManualHoldTime +
                            Form1.gss_Boost +
                            Form1.gss_ThreeStatusShowSwitch +
                            Form1.gss_SimulationSpeedShow +
                            Form1.gss_SimulationCurrentShow
                            );
                        // 让进度条增加一次
                        fm.toolStripProgressBar_Status.Value += gsi_ProgressBar_IncreaseValue_Send;
                        break;
                    case 6:
                        // 最后一组数据数据
                        mySentCommand_S(fm, gss_mySendCommand_S6,
                            Form1.gss_Braking +
                            Form1.gss_MoreSpeed +
                            Form1.gss_MotorType +
                            Form1.gss_StartStyle +
                            Form1.gss_BrakingPotency +
                            Form1.gss_LockedRotorCurrentDrop +
                            Form1.gss_HandBrakeOverrun +
                            Form1.gss_SlideCharge
                            );

                        // 进度条加满
                        fm.toolStripProgressBar_Status.Value = 100;
                        System.Threading.Thread.Sleep(1000);
                        fm.toolStripProgressBar_Status.Visible = false;
                        fm.toolStripProgressBar_Status.Value = 0;

                        if (SerialPortReceive.gsi_GetAllCommandCounter_Send == 6)
                        {
                            // 停止定时器
                            fm.timer_Send.Enabled = false;

                            // 计数清零
                            SerialPortReceive.gsi_GetAllCommandCounter_Send = 0;
                            // 显示指令发送完毕
                            fm.toolStripStatusLabel_NowStatus.Text = "指令发送完毕，应答正确";

                            // 完成发送，重置状态
                            gsui_myCommandCounter = 1;
                            // 重发次数清零
                            gsi_ReSendCount = 0;

                            // 使能控件
                            fm.EET_myToolStripFocus.Enabled = true;
                            fm.groupBox1.Enabled = true;
                            fm.groupBox2.Enabled = true;
                            fm.groupBox3.Enabled = true;

                            // 串口打开状态
                            Form1.gsb_SerialPort_IsOpen = true;
                            // 关闭串口
                            fm.ChangeSerialPortStatus(Form1.gsb_SerialPort_IsOpen);
                            // 设置为空闲状态
                            SerialPortSend.gss_IsIdleOrReceiveOrSend = SerialPortSend.gss_serialPortStatus[0];

                            // 使能设置串口端口号
                            fm.toolStripComboBox_PortName.Enabled = true;
                        }
                        else
                        {
                            // 完成发送，重置状态
                            gsui_myCommandCounter = 1;
                            gsi_ReSendCount++;
                            if (gsi_ReSendCount >= gsi_MaxReSendCount)
                            { 
                                // 显示指令发送状态
                                fm.toolStripStatusLabel_NowStatus.Text = "通讯出错，请重新发送！";
                                // 如果出错，重置状态
                                fm.timer_Send.Enabled = false;
                                gsui_myCommandCounter = 1;
                                // 使能控件
                                fm.EET_myToolStripFocus.Enabled = true;
                                fm.groupBox1.Enabled = true;
                                fm.groupBox2.Enabled = true;
                                fm.groupBox3.Enabled = true;

                                // 串口打开状态
                                Form1.gsb_SerialPort_IsOpen = true;
                                // 关闭串口
                                fm.ChangeSerialPortStatus(Form1.gsb_SerialPort_IsOpen);
                                // 设置为空闲状态
                                SerialPortSend.gss_IsIdleOrReceiveOrSend = SerialPortSend.gss_serialPortStatus[0];

                                // 使能设置串口端口号
                                fm.toolStripComboBox_PortName.Enabled = true;
                            }
                        }
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // 显示指令发送状态
                fm.toolStripStatusLabel_NowStatus.Text = "通讯出错，请重新发送！";
                // 如果出错，重置状态
                fm.timer_Send.Enabled = false;
                gsui_myCommandCounter = 1;
                // 使能控件
                fm.EET_myToolStripFocus.Enabled = true;
                fm.groupBox1.Enabled = true;
                fm.groupBox2.Enabled = true;
                fm.groupBox3.Enabled = true;

                // 串口打开状态
                Form1.gsb_SerialPort_IsOpen = true;
                // 关闭串口
                fm.ChangeSerialPortStatus(Form1.gsb_SerialPort_IsOpen);
                // 设置为空闲状态
                SerialPortSend.gss_IsIdleOrReceiveOrSend = SerialPortSend.gss_serialPortStatus[0];

                // 使能设置串口端口号
                fm.toolStripComboBox_PortName.Enabled = true;
            }
        }

        // 发送参数的发送过程，然后ASCII发送
        public static void mySentCommand_S(Form1 fm, string myNUM, string myCMD)
        {
            // 临时的校验和变量
            int tempChecksum = 0;
            // 数据的长度
            gss_myCommandLength = (myCMD.Length / 2).ToString("X2");
            string tempMiddleCommand = gss_mySouceAddr + gss_myTargetAddr_Send + myNUM + gss_myCommandLength + myCMD;
            for (int i = 0; i < (tempMiddleCommand.Length / 2); i++)
            {
                tempChecksum += Convert.ToInt32(tempMiddleCommand.Substring(i * 2, 2), 16);
            }
            // 计算校验和
            gss_myChecksum = (tempChecksum % 256).ToString("X2");
            // 得出完整数据
            gss_myFullCommand = gss_myStart + tempMiddleCommand + gss_myChecksum + gss_myStop;
            // ASCII码发送
            fm.m_portDispl.serialPort.Write(gss_myFullCommand);
        }

        // 接收参数的发送过程，然后ASCII发送
        public static void mySentCommand_R(Form1 fm, string myCMD)
        {
            // ASCII码发送
            fm.m_portDispl.serialPort.Write(myCMD);
        }
    }
}
