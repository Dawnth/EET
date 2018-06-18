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
    class SerialPortReceive
    {
        // 找到指令标识符
        public static bool gsb_StartByteFoundFlag = false;

        // 读取参数接收数据计数
        public static int gsi_GetAllCommandCounter_Receive = 0;
        // 发送参数接收数据计数
        public static int gsi_GetAllCommandCounter_Send = 0;

        // 存放一条完整指令的变量
        public static string gss_SaveIntactCommand = "";

        // 串口从变频板接收参数的接收指令处理过程
        public static void SerialPortReceiveProcess(Form1 fm, string mySingle)
        {
            try
            {
                // 找到头码
                if (mySingle == SerialPortSend.gss_myStart)
                {
                    gsb_StartByteFoundFlag = true;

                    // 保存数据
                    gss_SaveIntactCommand = mySingle;
                }
                // 找到尾码
                else if (mySingle == SerialPortSend.gss_myStop)
                {
                    // 找到了完整的指令，找到指令标识符清零
                    gsb_StartByteFoundFlag = false;

                    // 保存数据
                    gss_SaveIntactCommand += mySingle;


                    // 读取数据的接收处理
                    if (SerialPortSend.gss_IsIdleOrReceiveOrSend == SerialPortSend.gss_serialPortStatus[1])
                    {
                        SerialPortReceive_CommandReceive(fm, gss_SaveIntactCommand);
                    }
                    // 发送数据的接收处理
                    else if (SerialPortSend.gss_IsIdleOrReceiveOrSend == SerialPortSend.gss_serialPortStatus[2])
                    {
                        SerialPortReceive_CommandSend(fm, gss_SaveIntactCommand);
                    }
                    // 在用完清空保存完整指令的变量
                    gss_SaveIntactCommand = "";
                }
                // 保存中间值
                else if (gsb_StartByteFoundFlag == true)
                {
                    gss_SaveIntactCommand += mySingle;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // 读取数据的接收处理
        public static void SerialPortReceive_CommandReceive(Form1 fm, string mySaveIntactCommand)
        {
            switch (gsi_GetAllCommandCounter_Receive)
            {
                case 0:
                    if (mySaveIntactCommand.Substring(0, 11) == "11FFF10008")
                    {
                        try
                        {
                            Form1.gss_SoftwareVersion = mySaveIntactCommand.Substring(11, 2);
                            Form1.gss_HardwareVersion = mySaveIntactCommand.Substring(13, 2);
                            Form1.gss_ProductModel = mySaveIntactCommand.Substring(15, 2);
                            Form1.gss_MotorSequence = mySaveIntactCommand.Substring(17, 2);
                            Form1.gss_MotorSeries = mySaveIntactCommand.Substring(19, 2);
                            Form1.gss_BatteryType = mySaveIntactCommand.Substring(21, 2);
                            Form1.gss_Hall = mySaveIntactCommand.Substring(23, 2);
                            Form1.gss_HallPhaseValue = mySaveIntactCommand.Substring(25, 2);

                            gsi_GetAllCommandCounter_Receive++;
                        }
                        catch
                        {
                            break;
                        }
                    }
                    break;
                case 1:
                    if (mySaveIntactCommand.Substring(0, 11) == "11FFF20008")
                    {
                        try
                        {
                            Form1.gss_HallForwardAngle_1 = mySaveIntactCommand.Substring(11, 2);
                            Form1.gss_HallForwardAngle_2 = mySaveIntactCommand.Substring(13, 2);
                            Form1.gss_HallForwardAngle_3 = mySaveIntactCommand.Substring(15, 2);
                            Form1.gss_HallForwardAngle_4 = mySaveIntactCommand.Substring(17, 2);
                            Form1.gss_HallForwardAngle_5 = mySaveIntactCommand.Substring(19, 2);
                            Form1.gss_HallForwardAngle_6 = mySaveIntactCommand.Substring(21, 2);
                            Form1.gss_SamePolarity = mySaveIntactCommand.Substring(23, 2);
                            Form1.gss_ProtectionTemperature = mySaveIntactCommand.Substring(25, 2);

                            gsi_GetAllCommandCounter_Receive++;
                        }
                        catch
                        {
                            break;
                        }
                    }
                    break;
                case 2:
                    if (mySaveIntactCommand.Substring(0, 11) == "11FFF30008")
                    {
                        try
                        {
                            Form1.gss_HallReverseAngle_1 = mySaveIntactCommand.Substring(11, 2);
                            Form1.gss_HallReverseAngle_2 = mySaveIntactCommand.Substring(13, 2);
                            Form1.gss_HallReverseAngle_3 = mySaveIntactCommand.Substring(15, 2);
                            Form1.gss_HallReverseAngle_4 = mySaveIntactCommand.Substring(17, 2);
                            Form1.gss_HallReverseAngle_5 = mySaveIntactCommand.Substring(19, 2);
                            Form1.gss_HallReverseAngle_6 = mySaveIntactCommand.Substring(21, 2);
                            Form1.gss_LockedRotorProtectionCurrentValue = mySaveIntactCommand.Substring(23, 2);
                            Form1.gss_PhaseCurrentPeak = mySaveIntactCommand.Substring(25, 2);

                            gsi_GetAllCommandCounter_Receive++;
                        }
                        catch
                        {
                            break;
                        }
                    }
                    break;
                case 3:
                    if (mySaveIntactCommand.Substring(0, 11) == "11FFF40008")
                    {
                        try
                        {
                            Form1.gss_SpeedUpperBound = mySaveIntactCommand.Substring(11, 2);
                            Form1.gss_SpeedLowerBound = mySaveIntactCommand.Substring(13, 2);
                            Form1.gss_BatteryMaximumVoltage = mySaveIntactCommand.Substring(15, 2);
                            Form1.gss_BatteryMinimumVoltage = mySaveIntactCommand.Substring(17, 2);
                            Form1.gss_BatteryMaximumVoltage_36V = mySaveIntactCommand.Substring(19, 2);
                            Form1.gss_BatteryMinimumVoltage_36V = mySaveIntactCommand.Substring(21, 2);
                            Form1.gss_ProtectionUpperBound = mySaveIntactCommand.Substring(23, 2);
                            Form1.gss_ProtectionLowerBound = mySaveIntactCommand.Substring(25, 2);

                            gsi_GetAllCommandCounter_Receive++;
                        }
                        catch
                        {
                            break;
                        }
                    }
                    break;
                case 4:
                    if (mySaveIntactCommand.Substring(0, 11) == "11FFF50008")
                    {
                        try
                        {
                            Form1.gss_SNLAccelerationSpeed = mySaveIntactCommand.Substring(11, 2);
                            Form1.gss_SNLHighSpeed = mySaveIntactCommand.Substring(13, 2);
                            Form1.gss_SNLMidSpeed = mySaveIntactCommand.Substring(15, 2);
                            Form1.gss_SNLLowSpeed = mySaveIntactCommand.Substring(17, 2);
                            Form1.gss_SNLAccelerationAmpere = mySaveIntactCommand.Substring(19, 2);
                            Form1.gss_SNLHighAmpere = mySaveIntactCommand.Substring(21, 2);
                            Form1.gss_SNLMidAmpere = mySaveIntactCommand.Substring(23, 2);
                            Form1.gss_SNLLowAmpere = mySaveIntactCommand.Substring(25, 2);

                            gsi_GetAllCommandCounter_Receive++;
                        }
                        catch
                        {
                            break;
                        }
                    }
                    break;
                case 5:
                    if (mySaveIntactCommand.Substring(0, 11) == "11FFF60008")
                    {
                        try
                        {
                            Form1.gss_SLAccelerationSpeed = mySaveIntactCommand.Substring(11, 2);
                            Form1.gss_SLHighSpeed = mySaveIntactCommand.Substring(13, 2);
                            Form1.gss_SLMidSpeed = mySaveIntactCommand.Substring(15, 2);
                            Form1.gss_SLLowSpeed = mySaveIntactCommand.Substring(17, 2);
                            Form1.gss_SLAccelerationAmpere = mySaveIntactCommand.Substring(19, 2);
                            Form1.gss_SLHighAmpere = mySaveIntactCommand.Substring(21, 2);
                            Form1.gss_SLMidAmpere = mySaveIntactCommand.Substring(23, 2);
                            Form1.gss_SLLowAmpere = mySaveIntactCommand.Substring(25, 2);

                            gsi_GetAllCommandCounter_Receive++;
                        }
                        catch
                        {
                            break;
                        }
                    }
                    break;
                case 6:
                    if (mySaveIntactCommand.Substring(0, 11) == "11FFF70008")
                    {
                        try
                        {
                            Form1.gss_Cruise = mySaveIntactCommand.Substring(11, 2);
                            Form1.gss_CruiseSwitch = mySaveIntactCommand.Substring(13, 2);
                            Form1.gss_AutoHoldTime = mySaveIntactCommand.Substring(15, 2);
                            Form1.gss_ManualHoldTime = mySaveIntactCommand.Substring(17, 2);
                            Form1.gss_Boost = mySaveIntactCommand.Substring(19, 2);
                            Form1.gss_ThreeStatusShowSwitch = mySaveIntactCommand.Substring(21, 2);
                            Form1.gss_SimulationSpeedShow = mySaveIntactCommand.Substring(23, 2);
                            Form1.gss_SimulationCurrentShow = mySaveIntactCommand.Substring(25, 2);

                            gsi_GetAllCommandCounter_Receive++;
                        }
                        catch
                        {
                            break;
                        }
                    }
                    break;
                case 7:
                    if (mySaveIntactCommand.Substring(0, 11) == "11FFF80008")
                    {
                        try
                        {
                            Form1.gss_Braking = mySaveIntactCommand.Substring(11, 2);
                            Form1.gss_MoreSpeed = mySaveIntactCommand.Substring(13, 2);
                            Form1.gss_MotorType = mySaveIntactCommand.Substring(15, 2);
                            Form1.gss_StartStyle = mySaveIntactCommand.Substring(17, 2);
                            Form1.gss_BrakingPotency = mySaveIntactCommand.Substring(19, 2);
                            Form1.gss_LockedRotorCurrentDrop = mySaveIntactCommand.Substring(21, 2);
                            Form1.gss_HandBrakeOverrun = mySaveIntactCommand.Substring(23, 2);
                            Form1.gss_SlideCharge = mySaveIntactCommand.Substring(25, 2);

                            gsi_GetAllCommandCounter_Receive++;

                            // 加载参数到界面
                            GenerateParameters.ParametersToUI_SerialPort_Receive(fm);
                            // 总校验
                            GenerateParameters.ReadBackCheck(fm);
                        }
                        catch
                        {
                            break;
                        }
                    }
                    break;
                default:
                    break;
            }
        }

        // 发送数据的接收处理
        public static void SerialPortReceive_CommandSend(Form1 fm, string mySaveIntactCommand)
        {
            switch (gsi_GetAllCommandCounter_Send)
            {
                case 0:
                    if (mySaveIntactCommand == "00FFF10000F0")
                    {
                        gsi_GetAllCommandCounter_Send++;
                    }
                    break;
                case 1:
                    if (mySaveIntactCommand == "00FFF20000F1")
                    {
                        gsi_GetAllCommandCounter_Send++;
                    }
                    break;
                case 2:
                    if (mySaveIntactCommand == "00FFF30000F2")
                    {
                        gsi_GetAllCommandCounter_Send++;
                    }
                    break;
                case 3:
                    if (mySaveIntactCommand == "00FFF40000F3")
                    {
                        gsi_GetAllCommandCounter_Send++;
                    }
                    break;
                case 4:
                    if (mySaveIntactCommand == "00FFF50000F4")
                    {
                        gsi_GetAllCommandCounter_Send++;
                    }
                    break;
                case 5:
                    if (mySaveIntactCommand == "00FFF60000F5")
                    {
                        gsi_GetAllCommandCounter_Send++;
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
