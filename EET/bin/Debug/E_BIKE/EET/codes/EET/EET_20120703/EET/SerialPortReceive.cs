using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace EET
{
    class SerialPortReceive
    {
        // 找到指令标识符
        public static bool gsb_StartByteFoundFlag = false;

        public static int gsi_GetAllCommandCounter_Receive = 0;
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
                        gsi_GetAllCommandCounter_Receive++;

                    }
                    break;
                case 1:
                    if (mySaveIntactCommand.Substring(0, 11) == "11FFF20008")
                    {
                        gsi_GetAllCommandCounter_Receive++;
                    }
                    break;
                case 2:
                    if (mySaveIntactCommand.Substring(0, 11) == "11FFF30008")
                    {
                        gsi_GetAllCommandCounter_Receive++;
                    }
                    break;
                case 3:
                    if (mySaveIntactCommand.Substring(0, 11) == "11FFF40008")
                    {
                        gsi_GetAllCommandCounter_Receive++;
                    }
                    break;
                case 4:
                    if (mySaveIntactCommand.Substring(0, 11) == "11FFF50008")
                    {
                        gsi_GetAllCommandCounter_Receive++;
                    }
                    break;
                case 5:
                    if (mySaveIntactCommand.Substring(0, 11) == "11FFF60008")
                    {
                        gsi_GetAllCommandCounter_Receive++;
                    }
                    break;
                case 6:
                    if (mySaveIntactCommand.Substring(0, 11) == "11FFF70008")
                    {
                        gsi_GetAllCommandCounter_Receive++;
                    }
                    break;
                case 7:
                    if (mySaveIntactCommand.Substring(0, 11) == "11FFF80008")
                    {
                        gsi_GetAllCommandCounter_Receive++;
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
                    if (mySaveIntactCommand == "00FFF100F0")
                    {
                        gsi_GetAllCommandCounter_Send++;
                    }
                    break;
                case 1:
                    if (mySaveIntactCommand == "00FFF200F1")
                    {
                        gsi_GetAllCommandCounter_Send++;
                    }
                    break;
                case 2:
                    if (mySaveIntactCommand == "00FFF300F2")
                    {
                        gsi_GetAllCommandCounter_Send++;
                    }
                    break;
                case 3:
                    if (mySaveIntactCommand == "00FFF400F3")
                    {
                        gsi_GetAllCommandCounter_Send++;
                    }
                    break;
                case 4:
                    if (mySaveIntactCommand == "00FFF500F4")
                    {
                        gsi_GetAllCommandCounter_Send++;
                    }
                    break;
                case 5:
                    if (mySaveIntactCommand == "00FFF600F5")
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
