using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace EET
{
    class SerialPortSend
    {
        // 用来记录发送的指令数
        public static uint myCommandCounter = 1;

        // 指令集
        // 指令1
        public static string myCommand1 = "";
        // 指令2
        public static string myCommand2 = "";
        // 指令3
        public static string myCommand3 = "";
        // 指令4
        public static string myCommand4 = "";
        // 指令5
        public static string myCommand5 = "";
        // 指令6
        public static string myCommand6 = "";
        // 指令7
        public static string myCommand7 = "";
        // 指令8
        public static string myCommand8 = "";
        // 指令9
        public static string myCommand9 = "";
        // 指令10
        public static string myCommand10 = "";
        // 串口发送参数到变频板
        // 采用ASCII码方式发送
        public static void serialPortSend(Form1 fm)
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
