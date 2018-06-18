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

        // ������ָ��
        public static string myFullCommand = "";

        // ��ʼ��
        public static string myStart = "";

        // Դ��ַ
        public static string mySouceAddr = "FF";

        // Ŀ���ַ
        public static string myTargetAddr = "00";

        // ָ����
        public static string myCommandNumber = "00";

        // ָ���
        public static string myCommandLength = "00";

        // �����ڴ�

        // У���
        public static string myChecksum = "";

        // ������
        public static string myStop = "";

        // ָ�
        // ָ��1
        public static string myCommand1 = "F1";
        // ָ��2
        public static string myCommand2 = "F2";
        // ָ��3
        public static string myCommand3 = "F3";
        // ָ��4
        public static string myCommand4 = "F4";
        // ָ��5
        public static string myCommand5 = "F5";
        // ָ��6
        public static string myCommand6 = "F6";
        // ָ��7
        public static string myCommand7 = "F7";
        // ָ��8
        public static string myCommand8 = "F8";
        // ָ��9
        public static string myCommand9 = "F9";
        // ָ��10
        public static string myCommand10 = "FA";
        // ���ڷ��Ͳ�������Ƶ��
        // ����ASCII�뷽ʽ����
        public static void CommandSendPrecess(Form1 fm)
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
                        // �򿪴���
                        fm.EET_serialPort.Open();
                        // ���͵�һ������
                        serialPortSend(fm, myCommand1,
                            Form1.gss_MotorSequence +
                            Form1.gss_BatteryType +
                            Form1.gss_HallPhaseValue +
                            Form1.gss_LockedRotorProtectionCurrentValue +
                            Form1.gss_SpeedUpperBound +
                            Form1.gss_SpeedLowerBound
                            );
                        break;
                    case 2:
                        myCommandCounter++;
                        // ���͵ڶ�������
                        serialPortSend(fm, myCommand2,
                            Form1.gss_BatteryMaximumVoltage +
                            Form1.gss_BatteryMinimumVoltage +
                            Form1.gss_BatteryMaximumVoltage_36V +
                            Form1.gss_BatteryMinimumVoltage_36V +
                            Form1.gss_ProtectionUpperBound +
                            Form1.gss_ProtectionLowerBound +
                            Form1.gss_PhaseCurrentPeak
                            );
                        break;
                    case 3:
                        myCommandCounter++;
                        // ���͵���������
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
                        break;
                    case 4:
                        myCommandCounter++;
                        // ���͵���������
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
                        break;
                    case 5:
                        myCommandCounter++;
                        // ���͵���������
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
                        break;
                    case 6:
                        // ֹͣ��ʱ��
                        fm.timer_Send.Enabled = false;
                        // ���һ����������
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

                        // ��ɷ��ͣ�����״̬
                        myCommandCounter = 1;
                        fm.EET_myToolStripFocus.Enabled = true;
                        //fm.EET_statusStrip.Enabled = true;
                        fm.groupBox1.Enabled = true;
                        fm.groupBox2.Enabled = true;
                        fm.groupBox3.Enabled = true;
                        // �رմ���
                        fm.EET_serialPort.Close();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // �����������״̬
                fm.timer_Send.Enabled = false;
                myCommandCounter = 1;
                fm.EET_myToolStripFocus.Enabled = true;
                //fm.EET_statusStrip.Enabled = true;
                fm.groupBox1.Enabled = true;
                fm.groupBox2.Enabled = true;
                fm.groupBox3.Enabled = true;
                // �رմ���
                fm.EET_serialPort.Close();
            }
        }

        // �����������ݣ�Ȼ��ASCII����
        public static void serialPortSend(Form1 fm, string myNUM, string myCMD)
        {
            // ��ʱ��У��ͱ���
            int tempChecksum = 0;
            // ���ݵĳ���
            myCommandLength = (myCMD.Length / 2).ToString("X2");
            string tempMiddleCommand = mySouceAddr + myTargetAddr + myNUM + myCommandLength + myCMD;
            for (int i = 0; i < (tempMiddleCommand.Length / 2); i++)
            {
                tempChecksum += Convert.ToInt32(tempMiddleCommand.Substring(i * 2, 2), 16);
            }
            // ����У���
            myChecksum = (tempChecksum % 256).ToString("X2");
            // �ó���������
            myFullCommand = myStart + tempMiddleCommand + myChecksum + myStop;
            // ASCII�뷢��
            fm.EET_serialPort.Write(myFullCommand);
        }
    }
}
