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
        // �ҵ�ָ���ʶ��
        public static bool gsb_StartByteFoundFlag = false;

        // ��ȡ�����������ݼ���
        public static int gsi_GetAllCommandCounter_Receive = 0;
        // ���Ͳ����������ݼ���
        public static int gsi_GetAllCommandCounter_Send = 0;

        // ���һ������ָ��ı���
        public static string gss_SaveIntactCommand = "";

        // ���ڴӱ�Ƶ����ղ����Ľ���ָ������
        public static void SerialPortReceiveProcess(Form1 fm, string mySingle)
        {
            try
            {
                // �ҵ�ͷ��
                if (mySingle == SerialPortSend.gss_myStart)
                {
                    gsb_StartByteFoundFlag = true;

                    // ��������
                    gss_SaveIntactCommand = mySingle;
                }
                // �ҵ�β��
                else if (mySingle == SerialPortSend.gss_myStop)
                {
                    // �ҵ���������ָ��ҵ�ָ���ʶ������
                    gsb_StartByteFoundFlag = false;

                    // ��������
                    gss_SaveIntactCommand += mySingle;


                    // ��ȡ���ݵĽ��մ���
                    if (SerialPortSend.gss_IsIdleOrReceiveOrSend == SerialPortSend.gss_serialPortStatus[1])
                    {
                        SerialPortReceive_CommandReceive(fm, gss_SaveIntactCommand);
                    }
                    // �������ݵĽ��մ���
                    else if (SerialPortSend.gss_IsIdleOrReceiveOrSend == SerialPortSend.gss_serialPortStatus[2])
                    {
                        SerialPortReceive_CommandSend(fm, gss_SaveIntactCommand);
                    }
                    // ��������ձ�������ָ��ı���
                    gss_SaveIntactCommand = "";
                }
                // �����м�ֵ
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

        // ��ȡ���ݵĽ��մ���
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

                            // ���ز���������
                            GenerateParameters.ParametersToUI_SerialPort_Receive(fm);
                            // ��У��
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

        // �������ݵĽ��մ���
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
