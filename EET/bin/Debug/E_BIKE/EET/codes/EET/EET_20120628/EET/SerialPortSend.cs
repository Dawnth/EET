using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace EET
{
    class SerialPortSend
    {
        // ������¼���͵�ָ����
        public static uint myCommandCounter = 1;

        // ָ�
        // ָ��1
        public static string myCommand1 = "";
        // ָ��2
        public static string myCommand2 = "";
        // ָ��3
        public static string myCommand3 = "";
        // ָ��4
        public static string myCommand4 = "";
        // ָ��5
        public static string myCommand5 = "";
        // ָ��6
        public static string myCommand6 = "";
        // ָ��7
        public static string myCommand7 = "";
        // ָ��8
        public static string myCommand8 = "";
        // ָ��9
        public static string myCommand9 = "";
        // ָ��10
        public static string myCommand10 = "";
        // ���ڷ��Ͳ�������Ƶ��
        // ����ASCII�뷽ʽ����
        public static void serialPortSend(Form1 fm)
        {
            try
            {
                // �������͵�ѭ������myCommandCounterֵΪ10ʱ��
                // ��������10��ָ�ֹͣ����ѭ����������ֵΪ1
                switch (myCommandCounter)
                {
                    case 1:
                        myCommandCounter++;
                        fm.EET_myToolStripFocus.Enabled = false;
                        //fm.EET_statusStrip.Enabled = false;
                        fm.groupBox1.Enabled = false;
                        fm.groupBox2.Enabled = false;
                        fm.groupBox3.Enabled = false;
                        break;
                    case 2:
                        myCommandCounter++;
                        break;
                    case 3:
                        myCommandCounter++;
                        break;
                    case 4:
                        myCommandCounter++;
                        break;
                    case 5:
                        myCommandCounter++;
                        break;
                    case 6:
                        myCommandCounter++;
                        break;
                    case 7:
                        myCommandCounter++;
                        break;
                    case 8:
                        myCommandCounter++;
                        break;
                    case 9:
                        myCommandCounter++;
                        break;
                    case 10:
                        fm.timer_Send.Enabled = false;
                        myCommandCounter = 1;
                        fm.EET_myToolStripFocus.Enabled = true;
                        //fm.EET_statusStrip.Enabled = true;
                        fm.groupBox1.Enabled = true;
                        fm.groupBox2.Enabled = true;
                        fm.groupBox3.Enabled = true;
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static string CommandSendPrecess()
        { }
    }
}
