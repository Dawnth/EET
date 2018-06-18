using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace EET
{
    class SerialPortReceive
    {
        // �ҵ�ָ���ʶ��
        public static bool gsb_StartByteFoundFlag = false;

        public static int gsi_GetAllCommandCounter_Receive = 0;
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

        // �������ݵĽ��մ���
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
