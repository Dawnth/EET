using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace EET
{
    class SerialPortSend
    {
        // 用来记录发送的指令数
        // 从1开始，非从0开始，方便代码查看
        public static uint myCommandCounter = 1;

        // 完整的指令
        public static string myFullCommand = "";

        // 起始符
        public static string myStart = "";

        // 源地址
        public static string mySouceAddr = "FF";

        // 目标地址
        public static string myTargetAddr = "00";

        // 指令编号
        public static string myCommandNumber = "00";

        // 指令长度
        public static string myCommandLength = "00";

        // 数据在此

        // 校验和
        public static string myChecksum = "";

        // 结束符
        public static string myStop = "";

        // 指令集
        // 指令1
        public static string myCommand1 = "F1";
        // 指令2
        public static string myCommand2 = "F2";
        // 指令3
        public static string myCommand3 = "F3";
        // 指令4
        public static string myCommand4 = "F4";
        // 指令5
        public static string myCommand5 = "F5";
        // 指令6
        public static string myCommand6 = "F6";
        // 指令7
        public static string myCommand7 = "F7";
        // 指令8
        public static string myCommand8 = "F8";
        // 指令9
        public static string myCommand9 = "F9";
        // 指令10
        public static string myCommand10 = "FA";

        // 进度条的增长值
        public static int ProgressBar_IncreaseValue = 16;

        // 串口发送参数到变频板
        // 采用ASCII码方式发送
        public static void CommandSendPrecess(Form1 fm)
        {
            try
            {
                // 按条发送的循环，当myCommandCounter值为10时，
                // 即发送了10条指令，停止发送循环，设置其值为1
                switch (myCommandCounter)
                {
                    case 1:
                        myCommandCounter++;
                        fm.EET_myToolStripFocus.Enabled = false;
                        //fm.EET_statusStrip.Enabled = false;
                        fm.groupBox1.Enabled = false;
                        fm.groupBox2.Enabled = false;
                        fm.groupBox3.Enabled = false;
                        // 打开串口
                        Form1.gsb_SerialPort_OpenFlag = false;
                        fm.setSerialPortStatus(Form1.gsb_SerialPort_OpenFlag);
                        Form1.gsb_SerialPort_ReceiveFlag = true;
                        // 发送第一组数据
                        serialPortSend(fm, myCommand1,
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
                        fm.toolStripProgressBar_Status.Value += ProgressBar_IncreaseValue;
                        break;
                    case 2:
                        myCommandCounter++;
                        // 发送第二组数据
                        serialPortSend(fm, myCommand2,
                            Form1.gss_BatteryMaximumVoltage +
                            Form1.gss_BatteryMinimumVoltage +
                            Form1.gss_BatteryMaximumVoltage_36V +
                            Form1.gss_BatteryMinimumVoltage_36V +
                            Form1.gss_ProtectionUpperBound +
                            Form1.gss_ProtectionLowerBound +
                            Form1.gss_PhaseCurrentPeak
                            );
                        // 让进度条增加一次
                        fm.toolStripProgressBar_Status.Value += ProgressBar_IncreaseValue;
                        break;
                    case 3:
                        myCommandCounter++;
                        // 发送第三组数据
                        serialPortSend(fm, myCommand3,
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
                        fm.toolStripProgressBar_Status.Value += ProgressBar_IncreaseValue;
                        break;
                    case 4:
                        myCommandCounter++;
                        // 发送第四组数据
                        serialPortSend(fm, myCommand4,
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
                        fm.toolStripProgressBar_Status.Value += ProgressBar_IncreaseValue;
                        break;
                    case 5:
                        myCommandCounter++;
                        // 发送第五组数据
                        serialPortSend(fm, myCommand5,
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
                        fm.toolStripProgressBar_Status.Value += ProgressBar_IncreaseValue;
                        break;
                    case 6:
                        // 停止定时器
                        fm.timer_Send.Enabled = false;
                        // 最后一组数据数据
                        serialPortSend(fm, myCommand6,
                            Form1.gss_Braking +
                            Form1.gss_MoreSpeed +
                            Form1.gss_MotorType +
                            Form1.gss_StartStyle +
                            Form1.gss_BrakingPotency +
                            Form1.gss_LockedRotorCurrentDrop +
                            Form1.gss_HandBrakeOverrun +
                            Form1.gss_SlideCharge
                            );

                        // 放在接收应答处
                        // 显示指令发送完毕
                        fm.toolStripStatusLabel_NowStatus.Text = "指令发送完毕，应答正确";

                        // 进度条加满
                        fm.toolStripProgressBar_Status.Value = 100;
                        System.Threading.Thread.Sleep(500);
                        fm.toolStripProgressBar_Status.Visible = false;
                        fm.toolStripProgressBar_Status.Value = 0;

                        // 完成发送，重置状态
                        myCommandCounter = 1;
                        fm.EET_myToolStripFocus.Enabled = true;
                        //fm.EET_statusStrip.Enabled = true;
                        fm.groupBox1.Enabled = true;
                        fm.groupBox2.Enabled = true;
                        fm.groupBox3.Enabled = true;
                        //串口接收状态
                        Form1.gsb_SerialPort_ReceiveFlag = false;
                        // 关闭串口
                        Form1.gsb_SerialPort_OpenFlag = true;
                        fm.setSerialPortStatus(Form1.gsb_SerialPort_OpenFlag);
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // 如果出错，重置状态
                fm.timer_Send.Enabled = false;
                myCommandCounter = 1;
                fm.EET_myToolStripFocus.Enabled = true;
                //fm.EET_statusStrip.Enabled = true;
                fm.groupBox1.Enabled = true;
                fm.groupBox2.Enabled = true;
                fm.groupBox3.Enabled = true;
                //串口接收状态
                Form1.gsb_SerialPort_ReceiveFlag = false;
                // 关闭串口
                Form1.gsb_SerialPort_OpenFlag = true;
                fm.setSerialPortStatus(Form1.gsb_SerialPort_OpenFlag);
            }
        }

        // 计算整个数据，然后ASCII发送
        public static void serialPortSend(Form1 fm, string myNUM, string myCMD)
        {
            // 临时的校验和变量
            int tempChecksum = 0;
            // 数据的长度
            myCommandLength = (myCMD.Length / 2).ToString("X2");
            string tempMiddleCommand = mySouceAddr + myTargetAddr + myNUM + myCommandLength + myCMD;
            for (int i = 0; i < (tempMiddleCommand.Length / 2); i++)
            {
                tempChecksum += Convert.ToInt32(tempMiddleCommand.Substring(i * 2, 2), 16);
            }
            // 计算校验和
            myChecksum = (tempChecksum % 256).ToString("X2");
            // 得出完整数据
            myFullCommand = myStart + tempMiddleCommand + myChecksum + myStop;
            // ASCII码发送
            fm.m_portDispl.serialPort.Write(myFullCommand);
        }
    }
}
