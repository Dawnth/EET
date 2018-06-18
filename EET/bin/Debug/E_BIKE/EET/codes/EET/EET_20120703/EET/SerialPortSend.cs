using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace EET
{
    class SerialPortSend
    {
        // ״̬����
        public static string[] gss_serialPortStatus = new String[] { "Idle", "Receive", "Send" };

        // ��ǵ�ǰ���ڿ���(Idle)���ǽ���(Receive)���߷���(Send)״̬
        public static string gss_IsIdleOrReceiveOrSend = gss_serialPortStatus[0];

        // ���·��ʹ���
        public static int gsi_ReSendCount = 0;
        public static int gsi_MaxReSendCount = 2;
        
        // ������¼���͵�ָ����
        // ��1��ʼ���Ǵ�0��ʼ���������鿴
        public static uint gsui_myCommandCounter = 1;

        // ������ָ��
        public static string gss_myFullCommand = "";

        // ��ʼ��
        public static string gss_myStart = "";

        // Դ��ַ
        public static string gss_mySouceAddr = "FF";

        // ���Ͳ���ָ���Ŀ���ַ
        public static string gss_myTargetAddr_Send = "00";

        // ��ȡ����ָ���Ŀ���ַ
        public static string gss_myTargetAddr_Receive = "11";

        // ָ����
        public static string gss_myCommandNumber = "00";

        // ָ���
        public static string gss_myCommandLength = "00";

        // �����ڴ�

        // У���
        public static string gss_myChecksum = "";

        // ������
        public static string gss_myStop = "";

        // ������������ֵ
        public static int gsi_ProgressBar_IncreaseValue_Send = 16;
        public static int gsi_ProgressBar_IncreaseValue_Receive = 12;

        #region --�������ݷ���ָ�--

        // ָ��1
        public static string gss_mySendCommand_R1 = "FF11F10001";
        // ָ��2
        public static string gss_mySendCommand_R2 = "FF11F20002";
        // ָ��3
        public static string gss_mySendCommand_R3 = "FF11F30003";
        // ָ��4
        public static string gss_mySendCommand_R4 = "FF11F40004";
        // ָ��5
        public static string gss_mySendCommand_R5 = "FF11F50005";
        // ָ��6
        public static string gss_mySendCommand_R6 = "FF11F60006";
        // ָ��7
        public static string gss_mySendCommand_R7 = "FF11F70007";
        // ָ��8
        public static string gss_mySendCommand_R8 = "FF11F80008";
        // ָ��9
        public static string gss_mySendCommand_R9 = "FF11F90009";
        // ָ��10
        public static string gss_mySendCommand_R10 = "FF11FA000A";

        #endregion

        #region --�������ݷ���ָ�--

        // ָ��1
        public static string gss_mySendCommand_S1 = "F1";
        // ָ��2
        public static string gss_mySendCommand_S2 = "F2";
        // ָ��3
        public static string gss_mySendCommand_S3 = "F3";
        // ָ��4
        public static string gss_mySendCommand_S4 = "F4";
        // ָ��5
        public static string gss_mySendCommand_S5 = "F5";
        // ָ��6
        public static string gss_mySendCommand_S6 = "F6";
        // ָ��7
        public static string gss_mySendCommand_S7 = "F7";
        // ָ��8
        public static string gss_mySendCommand_S8 = "F8";
        // ָ��9
        public static string gss_mySendCommand_S9 = "F9";
        // ָ��10
        public static string gss_mySendCommand_S10 = "FA";

        #endregion

        // ���ڴӱ�Ƶ���ȡ�����ķ���ָ������
        public static void CommandReceiveProcess(Form1 fm)
        {
            try
            {
                // �������͵�ѭ��
                // ���磺��myCommandCounterֵΪ10ʱ����������10��ָ�
                // ֹͣ����ѭ����������ֵΪ1
                switch (gsui_myCommandCounter)
                {
                    case 1:
                        gsui_myCommandCounter++;
                        // ���͵�һ������
                        mySentCommand_R(fm, gss_mySendCommand_R1);
                        // ��ս�����
                        fm.toolStripProgressBar_Status.Value = 0;
                        // ��ʾ������
                        fm.toolStripProgressBar_Status.Visible = true;
                        // �ý���������һ��
                        fm.toolStripProgressBar_Status.Value += gsi_ProgressBar_IncreaseValue_Receive;
                        break;
                    case 2:
                        gsui_myCommandCounter++;
                        // ���͵ڶ�������
                        mySentCommand_R(fm, gss_mySendCommand_R2);
                        // �ý���������һ��
                        fm.toolStripProgressBar_Status.Value += gsi_ProgressBar_IncreaseValue_Receive;
                        break;
                    case 3:
                        gsui_myCommandCounter++;
                        // ���͵���������
                        mySentCommand_R(fm, gss_mySendCommand_R3);
                        // �ý���������һ��
                        fm.toolStripProgressBar_Status.Value += gsi_ProgressBar_IncreaseValue_Receive;
                        break;
                    case 4:
                        gsui_myCommandCounter++;
                        // ���͵���������
                        mySentCommand_R(fm, gss_mySendCommand_R4);
                        // �ý���������һ��
                        fm.toolStripProgressBar_Status.Value += gsi_ProgressBar_IncreaseValue_Receive;
                        break;
                    case 5:
                        gsui_myCommandCounter++;
                        // ���͵���������
                        mySentCommand_R(fm, gss_mySendCommand_R5);
                        // �ý���������һ��
                        fm.toolStripProgressBar_Status.Value += gsi_ProgressBar_IncreaseValue_Receive;
                        break;
                    case 6:
                        gsui_myCommandCounter++;
                        // ���͵���������
                        mySentCommand_R(fm, gss_mySendCommand_R6);
                        // �ý���������һ��
                        fm.toolStripProgressBar_Status.Value += gsi_ProgressBar_IncreaseValue_Receive;
                        break;
                    case 7:
                        gsui_myCommandCounter++;
                        // ���͵���������
                        mySentCommand_R(fm, gss_mySendCommand_R7);
                        // �ý���������һ��
                        fm.toolStripProgressBar_Status.Value += gsi_ProgressBar_IncreaseValue_Receive;
                        break;
                    case 8:
                        // ֹͣ��ʱ��
                        fm.timer_Receive.Enabled = false;
                        // ���һ����������
                        mySentCommand_R(fm, gss_mySendCommand_R8);

                        // ���ڽ���Ӧ��
                        // ��ʾָ������
                        fm.toolStripStatusLabel_NowStatus.Text = "ָ�����ϣ�Ӧ����ȷ";

                        // ����������
                        fm.toolStripProgressBar_Status.Value = 100;
                        System.Threading.Thread.Sleep(500);
                        fm.toolStripProgressBar_Status.Visible = false;
                        fm.toolStripProgressBar_Status.Value = 0;

                        // ��ɷ��ͣ�����״̬
                        gsui_myCommandCounter = 1;

                        // ʹ�ܿؼ�
                        fm.EET_myToolStripFocus.Enabled = true;
                        fm.groupBox1.Enabled = true;
                        fm.groupBox2.Enabled = true;
                        fm.groupBox3.Enabled = true;

                        // ʹ�ܰ�ť
                        fm.toolStripMenuItem_Save.Enabled = true;
                        fm.toolStripMenuItem_DownLoad.Enabled = true;

                        // ���ڴ�״̬
                        Form1.gsb_SerialPort_IsOpen = true;
                        // �رմ���
                        fm.ChangeSerialPortStatus(Form1.gsb_SerialPort_IsOpen);
                        // ����Ϊ����״̬
                        SerialPortSend.gss_IsIdleOrReceiveOrSend = SerialPortSend.gss_serialPortStatus[0];

                        // ʹ�����ô��ڶ˿ں�
                        fm.toolStripComboBox_PortName.Enabled = true;
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // ��ʾָ���״̬
                fm.toolStripStatusLabel_NowStatus.Text = "ͨѶ���������¶�ȡ��";
                // �����������״̬
                fm.timer_Receive.Enabled = false;

                // ��ɷ��ͣ�����״̬
                gsui_myCommandCounter = 1;

                // ʹ�ܿؼ�
                fm.EET_myToolStripFocus.Enabled = true;

                // ���ڴ�״̬
                Form1.gsb_SerialPort_IsOpen = true;
                // �رմ���
                fm.ChangeSerialPortStatus(Form1.gsb_SerialPort_IsOpen);
                // ����Ϊ����״̬
                SerialPortSend.gss_IsIdleOrReceiveOrSend = SerialPortSend.gss_serialPortStatus[0];

                // ʹ�����ô��ڶ˿ں�
                fm.toolStripComboBox_PortName.Enabled = true;
            }
        }

        // ���ڷ��Ͳ�������Ƶ��ķ���ָ������
        // ����ASCII�뷽ʽ����
        public static void CommandSendPrecess(Form1 fm)
        {
            try
            {
                // �������͵�ѭ��
                // ���磺��myCommandCounterֵΪ10ʱ����������10��ָ�
                // ֹͣ����ѭ����������ֵΪ1
                switch (gsui_myCommandCounter)
                {
                    case 1:
                        gsui_myCommandCounter++;
                        // ���͵�һ������
                        mySentCommand_S(fm, gss_mySendCommand_S1,
                            Form1.gss_MotorSequence +
                            Form1.gss_BatteryType +
                            Form1.gss_HallPhaseValue +
                            Form1.gss_LockedRotorProtectionCurrentValue +
                            Form1.gss_SpeedUpperBound +
                            Form1.gss_SpeedLowerBound
                            );
                        // ��ս�����
                        fm.toolStripProgressBar_Status.Value = 0;
                        // ��ʾ������
                        fm.toolStripProgressBar_Status.Visible = true;
                        // �ý���������һ��
                        fm.toolStripProgressBar_Status.Value += gsi_ProgressBar_IncreaseValue_Send;
                        break;
                    case 2:
                        gsui_myCommandCounter++;
                        // ���͵ڶ�������
                        mySentCommand_S(fm, gss_mySendCommand_S2,
                            Form1.gss_BatteryMaximumVoltage +
                            Form1.gss_BatteryMinimumVoltage +
                            Form1.gss_BatteryMaximumVoltage_36V +
                            Form1.gss_BatteryMinimumVoltage_36V +
                            Form1.gss_ProtectionUpperBound +
                            Form1.gss_ProtectionLowerBound +
                            Form1.gss_PhaseCurrentPeak
                            );
                        // �ý���������һ��
                        fm.toolStripProgressBar_Status.Value += gsi_ProgressBar_IncreaseValue_Send;
                        break;
                    case 3:
                        gsui_myCommandCounter++;
                        // ���͵���������
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
                        // �ý���������һ��
                        fm.toolStripProgressBar_Status.Value += gsi_ProgressBar_IncreaseValue_Send;
                        break;
                    case 4:
                        gsui_myCommandCounter++;
                        // ���͵���������
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
                        // �ý���������һ��
                        fm.toolStripProgressBar_Status.Value += gsi_ProgressBar_IncreaseValue_Send;
                        break;
                    case 5:
                        gsui_myCommandCounter++;
                        // ���͵���������
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
                        // �ý���������һ��
                        fm.toolStripProgressBar_Status.Value += gsi_ProgressBar_IncreaseValue_Send;
                        break;
                    case 6:
                        // ���һ����������
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

                        // ����������
                        fm.toolStripProgressBar_Status.Value = 100;
                        System.Threading.Thread.Sleep(1000);
                        fm.toolStripProgressBar_Status.Visible = false;
                        fm.toolStripProgressBar_Status.Value = 0;

                        if (SerialPortReceive.gsi_GetAllCommandCounter_Send == 6)
                        {
                            // ֹͣ��ʱ��
                            fm.timer_Send.Enabled = false;

                            // ��������
                            SerialPortReceive.gsi_GetAllCommandCounter_Send = 0;
                            // ��ʾָ������
                            fm.toolStripStatusLabel_NowStatus.Text = "ָ�����ϣ�Ӧ����ȷ";

                            // ��ɷ��ͣ�����״̬
                            gsui_myCommandCounter = 1;
                            // �ط���������
                            gsi_ReSendCount = 0;

                            // ʹ�ܿؼ�
                            fm.EET_myToolStripFocus.Enabled = true;
                            fm.groupBox1.Enabled = true;
                            fm.groupBox2.Enabled = true;
                            fm.groupBox3.Enabled = true;

                            // ���ڴ�״̬
                            Form1.gsb_SerialPort_IsOpen = true;
                            // �رմ���
                            fm.ChangeSerialPortStatus(Form1.gsb_SerialPort_IsOpen);
                            // ����Ϊ����״̬
                            SerialPortSend.gss_IsIdleOrReceiveOrSend = SerialPortSend.gss_serialPortStatus[0];

                            // ʹ�����ô��ڶ˿ں�
                            fm.toolStripComboBox_PortName.Enabled = true;
                        }
                        else
                        {
                            // ��ɷ��ͣ�����״̬
                            gsui_myCommandCounter = 1;
                            gsi_ReSendCount++;
                            if (gsi_ReSendCount >= gsi_MaxReSendCount)
                            { 
                                // ��ʾָ���״̬
                                fm.toolStripStatusLabel_NowStatus.Text = "ͨѶ���������·��ͣ�";
                                // �����������״̬
                                fm.timer_Send.Enabled = false;
                                gsui_myCommandCounter = 1;
                                // ʹ�ܿؼ�
                                fm.EET_myToolStripFocus.Enabled = true;
                                fm.groupBox1.Enabled = true;
                                fm.groupBox2.Enabled = true;
                                fm.groupBox3.Enabled = true;

                                // ���ڴ�״̬
                                Form1.gsb_SerialPort_IsOpen = true;
                                // �رմ���
                                fm.ChangeSerialPortStatus(Form1.gsb_SerialPort_IsOpen);
                                // ����Ϊ����״̬
                                SerialPortSend.gss_IsIdleOrReceiveOrSend = SerialPortSend.gss_serialPortStatus[0];

                                // ʹ�����ô��ڶ˿ں�
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
                // ��ʾָ���״̬
                fm.toolStripStatusLabel_NowStatus.Text = "ͨѶ���������·��ͣ�";
                // �����������״̬
                fm.timer_Send.Enabled = false;
                gsui_myCommandCounter = 1;
                // ʹ�ܿؼ�
                fm.EET_myToolStripFocus.Enabled = true;
                fm.groupBox1.Enabled = true;
                fm.groupBox2.Enabled = true;
                fm.groupBox3.Enabled = true;

                // ���ڴ�״̬
                Form1.gsb_SerialPort_IsOpen = true;
                // �رմ���
                fm.ChangeSerialPortStatus(Form1.gsb_SerialPort_IsOpen);
                // ����Ϊ����״̬
                SerialPortSend.gss_IsIdleOrReceiveOrSend = SerialPortSend.gss_serialPortStatus[0];

                // ʹ�����ô��ڶ˿ں�
                fm.toolStripComboBox_PortName.Enabled = true;
            }
        }

        // ���Ͳ����ķ��͹��̣�Ȼ��ASCII����
        public static void mySentCommand_S(Form1 fm, string myNUM, string myCMD)
        {
            // ��ʱ��У��ͱ���
            int tempChecksum = 0;
            // ���ݵĳ���
            gss_myCommandLength = (myCMD.Length / 2).ToString("X2");
            string tempMiddleCommand = gss_mySouceAddr + gss_myTargetAddr_Send + myNUM + gss_myCommandLength + myCMD;
            for (int i = 0; i < (tempMiddleCommand.Length / 2); i++)
            {
                tempChecksum += Convert.ToInt32(tempMiddleCommand.Substring(i * 2, 2), 16);
            }
            // ����У���
            gss_myChecksum = (tempChecksum % 256).ToString("X2");
            // �ó���������
            gss_myFullCommand = gss_myStart + tempMiddleCommand + gss_myChecksum + gss_myStop;
            // ASCII�뷢��
            fm.m_portDispl.serialPort.Write(gss_myFullCommand);
        }

        // ���ղ����ķ��͹��̣�Ȼ��ASCII����
        public static void mySentCommand_R(Form1 fm, string myCMD)
        {
            // ASCII�뷢��
            fm.m_portDispl.serialPort.Write(myCMD);
        }
    }
}
