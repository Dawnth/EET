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
    public partial class Form1 : Form
    {
        #region --���������붨��--

        // g  ����ȫ�ֱ���  global
        // s  ����̬����  static
        // s  �����ַ���    string

        // ������������������
        // 1.��������       D P
        // 2.������ʼ��     I P
        // �������
        // 3.���浽����     U T P
        // 4.����������     P T C
        // ��ȡ����
        // 5.���õ�����     C T P
        // 6.����������     P T U �� P T U serialport receive
        // 7.�ض�У��       R B C

        // D P

        #region ----�����趨��----

        // �������ֵ
        public static string gss_MotorSequence = "00";
        // ������λ��ֵ
        public static string gss_HallPhaseValue = "00";
        // ���ٷ�Χ����ֵ
        public static string gss_SpeedUpperBound = "D6";
        // ���ٷ�Χ����ֵ
        public static string gss_SpeedLowerBound = "38";
        // ���ɳ���������ֵ
        public static string gss_ProtectionUpperBound = "E6";
        // ���ɳ���������ֵ
        public static string gss_ProtectionLowerBound = "29";
        // �������ֵ����
        public static string gss_PhaseCurrentPeak = "9D";
        // ��ض��ѹ
        public static string gss_BatteryType = "00";
        // 48V��ع�ѹֵ
        public static string gss_BatteryMaximumVoltage = "B4";
        // 48V���Ƿѹֵ
        public static string gss_BatteryMinimumVoltage = "8E";
        // 36V��ع�ѹֵ
        public static string gss_BatteryMaximumVoltage_36V = "89";
        // 36V���Ƿѹֵ
        public static string gss_BatteryMinimumVoltage_36V = "64";
        // ��ת��������ֵ
        public static string gss_LockedRotorProtectionCurrentValue = "68";
        // �����߷�ѹϵ��
        public static string gss_SpeedLimitVoltageDivideCoefficient = "11";

        #endregion

        #region ----����ѡ����----

        // ��������ѡ��
        public static string gss_SpeedAndAmpereLimit_Select = "false";
        // �������� ������ ����ֵ ����
        public static string gss_SNLAccelerationSpeed = "70";
        // �������� ������ ����ֵ ����
        public static string gss_SNLHighSpeed = "66";
        // �������� ������ ����ֵ ����
        public static string gss_SNLMidSpeed = "50";
        // �������� ������ ����ֵ ����
        public static string gss_SNLLowSpeed = "34";
        // �������� ������ ����ֵ ����
        public static string gss_SNLAccelerationAmpere = "9D";
        // �������� ������ ����ֵ ����
        public static string gss_SNLHighAmpere = "8D";
        // �������� ������ ����ֵ ����
        public static string gss_SNLMidAmpere = "78";
        // �������� ������ ����ֵ ����
        public static string gss_SNLLowAmpere = "63";
        // �������� ������ ����ֵ ����
        public static string gss_SLAccelerationSpeed = "44";
        // �������� ������ ����ֵ ����
        public static string gss_SLHighSpeed = "3D";
        // �������� ������ ����ֵ ����
        public static string gss_SLMidSpeed = "30";
        // �������� ������ ����ֵ ����
        public static string gss_SLLowSpeed = "20";
        // �������� ������ ����ֵ ����
        public static string gss_SLAccelerationAmpere = "73";
        // �������� ������ ����ֵ ����
        public static string gss_SLHighAmpere = "68";
        // �������� ������ ����ֵ ����
        public static string gss_SLMidAmpere = "5D";
        // �������� ������ ����ֵ ����
        public static string gss_SLLowAmpere = "53";

        // Ѳ������ѡ��
        public static string gss_Cruise_Select = "false";
        // Ѳ������
        public static string gss_Cruise = "00";

        // �綯Ѳ������ת��ѡ��
        public static string gss_CruiseSwitch_Select = "false";
        // �綯Ѳ������ת��
        public static string gss_CruiseSwitch = "00";

        // �Զ�Ѳ���ֱ��ȶ�ʱ��ѡ��
        public static string gss_AutoHoldTime_Select = "false";
        // �Զ�Ѳ���ֱ��ȶ�ʱ��
        public static string gss_AutoHoldTime = "50";

        // �ֶ�Ѳ����������ʱ��ѡ��
        public static string gss_ManualHoldTime_Select = "false";
        // �ֶ�Ѳ����������ʱ��
        public static string gss_ManualHoldTime = "28";

        // ��������ѡ��
        public static string gss_Boost_Select = "false";
        // ��������
        public static string gss_Boost = "00";

        // ��̬��ʾѡ��
        public static string gss_ThreeStatusShowSwitch_Select = "false";
        // ��̬��ʾ
        public static string gss_ThreeStatusShowSwitch = "00";

        // ģ���ٶ���ʾѡ��
        public static string gss_SimulationSpeedShow_Select = "false";
        // ģ���ٶ���ʾ
        public static string gss_SimulationSpeedShow = "0A";

        // ģ�������ʾѡ��
        public static string gss_SimulationCurrentShow_Select = "false";
        // ģ�������ʾ
        public static string gss_SimulationCurrentShow = "32";

        // ɲ������ѡ��
        public static string gss_Braking_Select = "false";
        // ɲ������
        public static string gss_Braking = "00";

        // ����ʵ��ѡ��
        public static string gss_MoreSpeed_Select = "false";
        // ����ʵ��
        public static string gss_MoreSpeed = "00";


        //
        // ���¸��µĲ����������ĵ�����
        //
        // ����ͺ�
        public static string gss_MotorType_Select = "false";
        public static string gss_MotorType = "00";
        // ������ʽ
        public static string gss_StartStyle = "05";
        // ɲ������
        public static string gss_BrakingPotency = "05";
        // ��ת����
        public static string gss_LockedRotorCurrentDrop_Select = "false";
        public static string gss_LockedRotorCurrentDrop = "00";
        // ����ɲ���ɳ�
        public static string gss_HandBrakeOverrun_Select = "false";
        public static string gss_HandBrakeOverrun = "00";
        // ���з����
        public static string gss_SlideCharge_Select = "false";
        public static string gss_SlideCharge = "00";


        #endregion

        #region ----ֻ�������ȡ�ı���----

        // ��������1�Ƕ�ֵ
        public static string gss_HallForwardAngle_1 = "00";
        // ��������2�Ƕ�ֵ
        public static string gss_HallForwardAngle_2 = "00";
        // ��������3�Ƕ�ֵ
        public static string gss_HallForwardAngle_3 = "00";
        // ��������4�Ƕ�ֵ
        public static string gss_HallForwardAngle_4 = "00";
        // ��������5�Ƕ�ֵ
        public static string gss_HallForwardAngle_5 = "00";
        // ��������6�Ƕ�ֵ
        public static string gss_HallForwardAngle_6 = "00";
        // �����������1�Ƕ�ֵ
        public static string gss_HallReverseAngle_1 = "00";
        // �����������2�Ƕ�ֵ
        public static string gss_HallReverseAngle_2 = "00";
        // �����������3�Ƕ�ֵ
        public static string gss_HallReverseAngle_3 = "00";
        // �����������4�Ƕ�ֵ
        public static string gss_HallReverseAngle_4 = "00";
        // �����������5�Ƕ�ֵ
        public static string gss_HallReverseAngle_5 = "00";
        // �����������6�Ƕ�ֵ
        public static string gss_HallReverseAngle_6 = "00";
        // ��
        public static string gss_Pipe = "00";

        #endregion

        #region ----��ʾ��----

        // ����汾��
        public static string gss_SoftwareVersion = "64";
        // Ӳ���汾��
        public static string gss_HardwareVersion = "01";
        // ��Ʒ�ͺ�
        public static string gss_ProductModel = "01";
        // �������
        public static string gss_MotorSeries = "08";
        // ��������,0������1����
        public static string gss_SamePolarity = "00";
        // �����������¶�
        public static string gss_ProtectionTemperature = "64";
        // ��������
        public static string gss_Hall = "00";

        #endregion

        #region --���ڲ���������--

        //// �����浽�ĵ�����ť��ʹ�ܼ�¼
        //private bool Save_button_SavedFlag = true;
        //// ����ȡĿ�����á���ť��ʹ�ܼ�¼
        //private bool UpLoad_button_SavedFlag = true;

        // �������ݼ�¼
        public static string gss_SerialPort_ReceiveData = "";

        // ���ڽ��ձ�־
        public static bool gsb_SerialPort_IsReceive = false;
        public static bool gsb_SerialPort_IsOpen = false;

        // ���ڶ˿ں�
        public static string gss_SerialPort_PortName = "COM1";
        // ���ڲ�����
        public static int gsi_SerialPort_BaudRate = 9600;

        // �ȴ���������ָ��ļ���
        public static int gsi_WaitForAllCommandCounter = 0;
        // �ȴ���������ָ��ļ������ֵ
        public static int gsi_WaitForAllCommandCounter_Max = 2;

        #endregion

        #endregion

        #region --�������--

        // ��ʼ����������
        public Form1()
        {
            InitializeComponent();
        }

        // �������
        private void Form1_Load(object sender, EventArgs e)
        {
            // ȡ�����
            //this.ControlBox = false;
            this.MaximizeBox = false;
            // ��һ�������ؼ���ȡ����
            comboBox_MotorSequence.Focus();

            /**************************************************************/
            /******************** ����comboBox��Ĭ��ֵ ********************/
            /**************************************************************/

            // Ĭ�ϵ������
            comboBox_MotorSequence.Text = comboBox_MotorSequence.Items[0].ToString();
            // Ĭ�ϻ����Ƕ�
            comboBox_HallPhaseValue.Text = comboBox_HallPhaseValue.Items[0].ToString();
            // Ĭ�ϵ�ض��ѹ
            comboBox_BatteryType.Text = comboBox_BatteryType.Items[0].ToString();
            // Ĭ��Ѳ������
            comboBox_Cruise.Text = comboBox_Cruise.Items[0].ToString();
            // Ĭ��Ѳ������ת��
            comboBox_CruiseSwitch.Text = comboBox_CruiseSwitch.Items[0].ToString();
            // Ĭ����������
            comboBox_Boost.Text = comboBox_Boost.Items[0].ToString();
            // Ĭ����̬��ʾ
            comboBox_ThreeStatusShowSwitch.Text = comboBox_ThreeStatusShowSwitch.Items[0].ToString();
            // Ĭ�ϵ���ɲ������
            comboBox_Braking.Text = comboBox_Braking.Items[0].ToString();
            // Ĭ�϶���
            comboBox_MoreSpeed.Text = comboBox_MoreSpeed.Items[0].ToString();
            // Ĭ�Ϲ���
            comboBox_Pipe.Text = comboBox_Pipe.Items[0].ToString();

            // ���ӵ�δ���뱣��Ϊ�����������������
            // �������� ��Ĭ���У�
            comboBox_Hall.Text = comboBox_Hall.Items[1].ToString();
            // Ĭ�ϵ������
            //comboBox_MotorSeries.Text = comboBox_MotorSeries.Items[0].ToString();
            // Ĭ�Ϲ�������
            //comboBox_SamePolarity.Text = comboBox_SamePolarity.Items[0].ToString();

            // ������һ�� comboBox
            // Ĭ�ϵ���ͺ�
            comboBox_MotorType.Text = comboBox_MotorType.Items[0].ToString();
            // Ĭ�϶�ת����
            comboBox_LockedRotorCurrentDrop.Text = comboBox_LockedRotorCurrentDrop.Items[0].ToString();
            // Ĭ������ɲ���ɳ�
            comboBox_HandBrakeOverrun.Text = comboBox_HandBrakeOverrun.Items[0].ToString();
            // Ĭ�ϻ��з����
            comboBox_SlideCharge.Text = comboBox_SlideCharge.Items[0].ToString();


            /**************************************************************/
            /******************** ����checkBox��Ĭ��ֵ ********************/
            /**************************************************************/

            // ����checkBoxΪ��ѡ��
            // Ĭ����������ѡ��
            checkBox_SpeedAndAmpereLimit_Select.Checked = false;
            // Ĭ��Ѳ������ѡ��
            checkBox_Cruise_Select.Checked = false;
            // Ĭ��Ѳ������ת��ѡ��
            checkBox_CruiseSwitch_Select.Checked = false;
            // Ĭ���Զ�Ѳ���ֱ��ȶ�ʱ��ѡ��
            checkBox_AutoHoldTime_Select.Checked = false;
            // Ĭ���ֶ�Ѳ����������ʱ��ѡ��
            checkBox_ManualHoldTime_Select.Checked = false;
            // Ĭ������ѡ��
            checkBox_Boost_Select.Checked = false;
            // Ĭ����̬��ʾѡ��
            checkBox_ThreeStatusShowSwitch_Select.Checked = false;
            // Ĭ��ģ���ٶ�ѡ��
            checkBox_SimulationSpeedShow_Select.Checked = false;
            // Ĭ��ģ�����ѡ��
            checkBox_SimulationCurrentShow_Select.Checked = false;
            // Ĭ�ϵ���ɲ��ѡ��
            checkBox_Braking_Select.Checked = false;
            // Ĭ�϶���ѡ��
            checkBox_MoreSpeed_Select.Checked = false;

            // ������һ�� checkBox
            // Ĭ�ϵ���ͺ�ѡ��
            checkBox_MotorType_Select.Checked = false;
            // Ĭ�϶�ת����ѡ��
            checkBox_LockedRotorCurrentDrop_Select.Checked = false;
            // Ĭ������ɲ���ɳ�ѡ��
            checkBox_HandBrakeOverrun_Select.Checked = false;
            // Ĭ�ϻ��з����
            checkBox_SlideCharge_Select.Checked = false;

            //// ���ڶ˿ںż���
            //toolStripComboBox_PortName.Text = toolStripComboBox_PortName.Items[0].ToString();
            // ��ʼ����������
            getPortName();
        }

        // �õ����ڶ˿ں�
        private void getPortName()
        {
            toolStripComboBox_PortName.Items.Clear();
            foreach (string s in SerialPort.GetPortNames())
            {
                toolStripComboBox_PortName.Items.Add(s);
                toolStripComboBox_PortName.Text = s;
            }
        }

        // Index�ı�ʱ��ȡ���ڶ˿���
        private void toolStripComboBox_PortName_SelectedIndexChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = toolStripComboBox_PortName.Text;
            gss_SerialPort_PortName = toolStripStatusLabel3.Text;
            m_portDispl.serialPort.PortName = gss_SerialPort_PortName;
        }

        #endregion

        #region --��ť�¼�--

        // ���ļ��������ð�ť�¼�
        private void toolStripMenuItem_Open_Click(object sender, EventArgs e)
        {
            try
            {
                // ����ʼ��·����Ϊ�գ����ʹ�ù���·��
                if (EET_openFileDialog.InitialDirectory != "")
                {
                    EET_openFileDialog.InitialDirectory = EET_openFileDialog.FileName.Substring(0, EET_openFileDialog.FileName.LastIndexOf("\\"));
                }
                else
                {
                    EET_openFileDialog.InitialDirectory = Application.StartupPath;
                }
            }
            catch
            {
                EET_openFileDialog.InitialDirectory = Application.StartupPath;
            }
            EET_openFileDialog.ShowDialog();
        }

        // openFileDialog��OK��ť�¼�
        private void EET_openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            //�������ļ�
            try
            {
                // ��ֹ����
                this.Enabled = false;

                OpenFile.OpenConfigurationFile(this, EET_openFileDialog.FileName);

                // ʹ�ܿؼ�
                EET_myToolStripFocus.Enabled = true;
                groupBox_Parameters.Enabled = true;
                groupBox_Function.Enabled = true;
                groupBox_Display.Enabled = true;

                // ʹ�ܰ�ť
                toolStripMenuItem_Save.Enabled = true;
                toolStripMenuItem_DownLoad.Enabled = true;

                // ʹ�ܽ���
                this.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // ʹ�ܽ���
                this.Enabled = true;
            }
        }

        // �������õ��ļ���ť�¼�
        private void toolStripMenuItem_Save_Click(object sender, EventArgs e)
        {

            // ��ֹ����ȡ���������á���ť
            toolStripMenuItem_UpLoad.Enabled = false;

            // ���ü���ķ����������޸ĺ�ĵı���
            GenerateParameters.UIToParameters(this);

            // ʹ�ܡ��������õ�Ŀ�ꡱ�İ�ť
            toolStripMenuItem_DownLoad.Enabled = true;
            // ʹ�ܡ��������õ��ĵ�����ť
            toolStripMenuItem_Save.Enabled = true;
            // ʹ�ܡ���ȡ���������á���ť
            toolStripMenuItem_UpLoad.Enabled = true;

            try
            {
                // ����ʼ��·����Ϊ�գ����ʹ�ù���·��
                if (EET_saveFileDialog.InitialDirectory != "")
                {
                    EET_saveFileDialog.InitialDirectory = EET_saveFileDialog.FileName.Substring(0, EET_saveFileDialog.FileName.LastIndexOf("\\"));
                }
                else
                {
                    EET_saveFileDialog.InitialDirectory = Application.StartupPath;
                }
            }
            catch
            {
                EET_saveFileDialog.InitialDirectory = Application.StartupPath;
            }
            EET_saveFileDialog.FileName = EET_saveFileDialog.InitialDirectory + "\\" + "EET_" + System.DateTime.Now.ToString("yyyyMMdd_HHmmss");
            EET_saveFileDialog.ShowDialog();
        }

        // saveFileDialog��OK��ť�¼�
        private void EET_saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            //�������ļ�
            try
            {
                SaveFile.ParametersToConfiguration(this, EET_saveFileDialog.FileName);
                // ����󣬽�ֹ���水ť
                //toolStripMenuItem_Save.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // �򿪳�����ļ���
        private void toolStripMenuItem_SaveFloder_Click(object sender, EventArgs e)
        {
            try
            {
                if (EET_saveFileDialog.FileName != "")
                {
                    //System.Diagnostics.Process.Start("explorer.exe", "/select," + EET_saveFileDialog.FileName);
                    System.Diagnostics.Process.Start("explorer.exe", EET_saveFileDialog.FileName.Substring(0, EET_saveFileDialog.FileName.LastIndexOf("\\")));
                }
                else
                {
                    System.Diagnostics.Process.Start("explorer.exe", Application.StartupPath);
                }
            }
            catch
            {
                System.Diagnostics.Process.Start("explorer.exe", Application.StartupPath);
            }
        }

        // �˳���ť���¼�
        private void toolStripMenuItem_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.ExitThread();
        }

        // �ӿ�������ȡ����
        private void toolStripMenuItem_UpLoad_Click(object sender, EventArgs e)
        {
            try
            {
                // ���ÿؼ�
                EET_myToolStripFocus.Enabled = false;
                groupBox_Parameters.Enabled = false;
                groupBox_Function.Enabled = false;
                groupBox_Display.Enabled = false;
                // �������ô��ڶ˿ں�
                toolStripComboBox_PortName.Enabled = false;

                // ���ڴ�״̬
                gsb_SerialPort_IsOpen = false;
                // �򿪴���
                ChangeSerialPortStatus(Form1.gsb_SerialPort_IsOpen);

                if (m_portDispl.serialPort.IsOpen == true)
                {
                    // ������ʾ����״̬��Label��ɫ������
                    toolStripStatusLabel1.Text = "�Ѵ�";
                    toolStripStatusLabel1.BackColor = Color.Lime;

                    // ʹ�ܶ�ʱ��
                    timer_Receive.Enabled = true;
                    // ���÷��ͽ���ָ�������
                    SerialPortSend.CommandReceiveProcess(this);
                    // ����Ϊ����״̬
                    SerialPortSend.gss_IsIdleOrReceiveOrSend = SerialPortSend.gss_serialPortStatus[1];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                // ʹ�ܿؼ�
                EET_myToolStripFocus.Enabled = true;
                // ʹ�����ô��ڶ˿ں�
                toolStripComboBox_PortName.Enabled = true;
            }
        }

        // �������õ�������
        private void toolStripMenuItem_DownLoad_Click(object sender, EventArgs e)
        {
            try
            {
                // ���ÿؼ�
                EET_myToolStripFocus.Enabled = false;
                groupBox_Parameters.Enabled = false;
                groupBox_Function.Enabled = false;
                groupBox_Display.Enabled = false;
                // �������ô��ڶ˿ں�
                toolStripComboBox_PortName.Enabled = false;

                // ���ü���ķ����������޸ĺ�ĵı���
                GenerateParameters.UIToParameters(this);

                // ���ڴ�״̬
                gsb_SerialPort_IsOpen = false;
                // �򿪴���
                ChangeSerialPortStatus(Form1.gsb_SerialPort_IsOpen);

                if (m_portDispl.serialPort.IsOpen == true)
                {
                    // ������ʾ����״̬��Label��ɫ������
                    toolStripStatusLabel1.Text = "�Ѵ�";
                    toolStripStatusLabel1.BackColor = Color.Lime;

                    // ʹ�ܶ�ʱ��
                    timer_Send.Enabled = true;
                    // ���÷��ͷ���ָ�������
                    SerialPortSend.CommandSendPrecess(this);
                    // ����Ϊ����״̬
                    SerialPortSend.gss_IsIdleOrReceiveOrSend = SerialPortSend.gss_serialPortStatus[2];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                // ʹ�ܿؼ�
                EET_myToolStripFocus.Enabled = true;
                groupBox_Parameters.Enabled = true;
                groupBox_Function.Enabled = true;
                groupBox_Display.Enabled = true;
                // ʹ�����ô��ڶ˿ں�
                toolStripComboBox_PortName.Enabled = true;
            }
        }

        // �ö�
        private void toolStripMenuItem_TopMost_Click(object sender, EventArgs e)
        {
            if (toolStripMenuItem_TopMost.Checked == false)
            {
                toolStripMenuItem_TopMost.Checked = true;
                this.TopMost = true;
            }
            else
            {
                toolStripMenuItem_TopMost.Checked = false;
                this.TopMost = false;
            }
        }

        // �����ĵ�
        private void toolStripMenuItem_HelpFile_Click(object sender, EventArgs e)
        {
            HelpFile EET_HelpFile = new HelpFile();
            EET_HelpFile.Show();
        }

        // ����
        private void toolStripMenuItem_About_Click(object sender, EventArgs e)
        {
            About EET_About = new About();
            EET_About.ShowDialog();
        }

        #endregion

        #region --ѡ���¼�--

        // �������� CheckBox
        private void checkBox_SpeedAndAmpereLimit_Select_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_SpeedAndAmpereLimit_Select.Checked == true)
            {
                myTextBoxNUM_SNLAccelerationSpeed.Enabled = true;
                myTextBoxNUM_SNLHighSpeed.Enabled = true;
                myTextBoxNUM_SNLMidSpeed.Enabled = true;
                myTextBoxNUM_SNLLowSpeed.Enabled = true;
                myTextBoxNUM_SNLAccelerationAmpere.Enabled = true;
                myTextBoxNUM_SNLHighAmpere.Enabled = true;
                myTextBoxNUM_SNLMidAmpere.Enabled = true;
                myTextBoxNUM_SNLLowAmpere.Enabled = true;
                myTextBoxNUM_SLAccelerationSpeed.Enabled = true;
                myTextBoxNUM_SLHighSpeed.Enabled = true;
                myTextBoxNUM_SLMidSpeed.Enabled = true;
                myTextBoxNUM_SLLowSpeed.Enabled = true;
                myTextBoxNUM_SLAccelerationAmpere.Enabled = true;
                myTextBoxNUM_SLHighAmpere.Enabled = true;
                myTextBoxNUM_SLMidAmpere.Enabled = true;
                myTextBoxNUM_SLLowAmpere.Enabled = true;
            }
            else
            {
                myTextBoxNUM_SNLAccelerationSpeed.Enabled = false;
                myTextBoxNUM_SNLHighSpeed.Enabled = false;
                myTextBoxNUM_SNLMidSpeed.Enabled = false;
                myTextBoxNUM_SNLLowSpeed.Enabled = false;
                myTextBoxNUM_SNLAccelerationAmpere.Enabled = false;
                myTextBoxNUM_SNLHighAmpere.Enabled = false;
                myTextBoxNUM_SNLMidAmpere.Enabled = false;
                myTextBoxNUM_SNLLowAmpere.Enabled = false;
                myTextBoxNUM_SLAccelerationSpeed.Enabled = false;
                myTextBoxNUM_SLHighSpeed.Enabled = false;
                myTextBoxNUM_SLMidSpeed.Enabled = false;
                myTextBoxNUM_SLLowSpeed.Enabled = false;
                myTextBoxNUM_SLAccelerationAmpere.Enabled = false;
                myTextBoxNUM_SLHighAmpere.Enabled = false;
                myTextBoxNUM_SLMidAmpere.Enabled = false;
                myTextBoxNUM_SLLowAmpere.Enabled = false;
            }
        }

        // Ѳ������ CheckBox
        private void checkBox_Cruise_Select_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Cruise_Select.Checked == true)
            {
                comboBox_Cruise.Enabled = true;
            }
            else
            {
                comboBox_Cruise.Enabled = false;
            }
        }

        // �綯Ѳ������ת�� CheckBox
        private void checkBox_CruiseSwitch_Select_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_CruiseSwitch_Select.Checked == true)
            {
                comboBox_CruiseSwitch.Enabled = true;
            }
            else
            {
                comboBox_CruiseSwitch.Enabled = false;
            }
        }

        // �Զ�Ѳ���ֱ��ȶ�ʱ�� CheckBox
        private void checkBox_AutoHoldTime_Select_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_AutoHoldTime_Select.Checked == true)
            {
                myTextBoxNUM_AutoHoldTime.Enabled = true;
            }
            else
            {
                myTextBoxNUM_AutoHoldTime.Enabled = false;
            }
        }

        // �ֶ�Ѳ����������ʱ�� CheckBox
        private void checkBox_ManualHoldTime_Select_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ManualHoldTime_Select.Checked == true)
            {
                myTextBoxNUM_ManualHoldTime.Enabled = true;
            }
            else
            {
                myTextBoxNUM_ManualHoldTime.Enabled = false;
            }
        }

        // �������� CheckBox
        private void checkBox_Boost_Select_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Boost_Select.Checked == true)
            {
                comboBox_Boost.Enabled = true;
            }
            else
            {
                comboBox_Boost.Enabled = false;
            }
        }

        // ��̬��ʾ CheckBox
        private void checkBox_ThreeStatusShowSwitch_Select_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ThreeStatusShowSwitch_Select.Checked == true)
            {
                comboBox_ThreeStatusShowSwitch.Enabled = true;
            }
            else
            {
                comboBox_ThreeStatusShowSwitch.Enabled = false;
            }
        }

        // ģ���ٶ���ʾ CheckBox
        private void checkBox_SimulationSpeedShow_Select_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_SimulationSpeedShow_Select.Checked == true)
            {
                myTextBoxNUM_SimulationSpeedShow.Enabled = true;
            }
            else
            {
                myTextBoxNUM_SimulationSpeedShow.Enabled = false;
            }
        }

        // ģ�������ʾ CheckBox
        private void checkBox_SimulationCurrentShow_Select_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_SimulationCurrentShow_Select.Checked == true)
            {
                myTextBoxNUM_SimulationCurrentShow.Enabled = true;
            }
            else
            {
                myTextBoxNUM_SimulationCurrentShow.Enabled = false;
            }
        }

        // ɲ������ CheckBox
        private void checkBox_Braking_Select_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Braking_Select.Checked == true)
            {
                comboBox_Braking.Enabled = true;
            }
            else
            {
                comboBox_Braking.Enabled = false;
            }
        }

        // ����ʵ�� CheckBox
        private void checkBox_MoreSpeed_Select_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_MoreSpeed_Select.Checked == true)
            {
                comboBox_MoreSpeed.Enabled = true;
            }
            else
            {
                comboBox_MoreSpeed.Enabled = false;
            }
        }

        #endregion

        #region --��������--

        // ��������� ComboBox
        private void comboBox_MotorSequence_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // ������� ComboBox
        private void comboBox_HallPhaseValue_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // ���ٷ�Χ����ֵ
        private void myTextBoxNUM_SpeedUpperBound_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(myTextBoxNUM_SpeedUpperBound.Text) < (2.1))
                {
                    myTextBoxNUM_SpeedUpperBound.Text = "2.1";
                }
                else if (Convert.ToDouble(myTextBoxNUM_SpeedUpperBound.Text) > (4.9))
                {
                    myTextBoxNUM_SpeedUpperBound.Text = "4.9";
                }
            }
            catch (Exception)
            {
                myTextBoxNUM_SpeedUpperBound.Text = "4.2";
            }
        }

        // ���ٷ�Χ����ֵ
        private void myTextBoxNUM_SpeedLowerBound_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(myTextBoxNUM_SpeedLowerBound.Text) < (0.1))
                {
                    myTextBoxNUM_SpeedLowerBound.Text = "0.1";
                }
                else if (Convert.ToDouble(myTextBoxNUM_SpeedLowerBound.Text) > (1.9))
                {
                    myTextBoxNUM_SpeedLowerBound.Text = "1.9";
                }
            }
            catch (Exception)
            {
                myTextBoxNUM_SpeedLowerBound.Text = "1.1";
            }
        }

        // ���ɳ���������ֵ
        private void myTextBoxNUM_ProtectionUpperBound_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(myTextBoxNUM_ProtectionUpperBound.Text) < (2.1))
                {
                    myTextBoxNUM_ProtectionUpperBound.Text = "2.1";
                }
                else if (Convert.ToDouble(myTextBoxNUM_ProtectionUpperBound.Text) > (4.9))
                {
                    myTextBoxNUM_ProtectionUpperBound.Text = "4.9";
                }
            }
            catch (Exception)
            {
                myTextBoxNUM_ProtectionUpperBound.Text = "4.5";
            }
        }

        // ���ɳ���������ֵ
        private void myTextBoxNUM_ProtectionLowerBound_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(myTextBoxNUM_ProtectionLowerBound.Text) < (0.1))
                {
                    myTextBoxNUM_ProtectionLowerBound.Text = "0.1";
                }
                else if (Convert.ToDouble(myTextBoxNUM_ProtectionLowerBound.Text) > (1.9))
                {
                    myTextBoxNUM_ProtectionLowerBound.Text = "1.9";
                }
            }
            catch (Exception)
            {
                myTextBoxNUM_ProtectionLowerBound.Text = "0.8";
            }
        }

        // �������ֵ����ֵ
        private void myTextBoxNUM_PhaseCurrentPeak_Leave(object sender, EventArgs e)
        {
            // 6��
            if (comboBox_Pipe.SelectedIndex == 0)
            {
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_PhaseCurrentPeak.Text) < (6))
                    {
                        myTextBoxNUM_PhaseCurrentPeak.Text = "6";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_PhaseCurrentPeak.Text) > (35))
                    {
                        myTextBoxNUM_PhaseCurrentPeak.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_PhaseCurrentPeak.Text = "20";
                }
            }
            // 9��
            else if (comboBox_Pipe.SelectedIndex == 1)
            {
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_PhaseCurrentPeak.Text) < (6))
                    {
                        myTextBoxNUM_PhaseCurrentPeak.Text = "6";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_PhaseCurrentPeak.Text) > (35))
                    {
                        myTextBoxNUM_PhaseCurrentPeak.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_PhaseCurrentPeak.Text = "20";
                }
            }
            // 12��
            else if (comboBox_Pipe.SelectedIndex == 2)
            {
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_PhaseCurrentPeak.Text) < (6))
                    {
                        myTextBoxNUM_PhaseCurrentPeak.Text = "6";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_PhaseCurrentPeak.Text) > (35))
                    {
                        myTextBoxNUM_PhaseCurrentPeak.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_PhaseCurrentPeak.Text = "20";
                }
            }
        }

        // ������� ComboBox
        private void comboBox_BatteryType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 48V���
            if (comboBox_BatteryType.SelectedIndex == 0)
            {
                // ��ع�ѹ����ֵ
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_BatteryMaximumVoltage.Text) < (48))
                    {
                        myTextBoxNUM_BatteryMaximumVoltage.Text = "48.0";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_BatteryMaximumVoltage.Text) > (56))
                    {
                        myTextBoxNUM_BatteryMaximumVoltage.Text = "56.0";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_BatteryMaximumVoltage.Text = "54.0";
                }
                // ���Ƿѹ����ֵ
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_BatteryMinimumVoltage.Text) < (42))
                    {
                        myTextBoxNUM_BatteryMinimumVoltage.Text = "42.0";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_BatteryMinimumVoltage.Text) > (48))
                    {
                        myTextBoxNUM_BatteryMinimumVoltage.Text = "48.0";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_BatteryMinimumVoltage.Text = "42.5";
                }
            }
            // 36V���
            else if (comboBox_BatteryType.SelectedIndex == 1)
            {
                // ��ع�ѹ����ֵ
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_BatteryMaximumVoltage.Text) < (36))
                    {
                        myTextBoxNUM_BatteryMaximumVoltage.Text = "36.0";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_BatteryMaximumVoltage.Text) > (42))
                    {
                        myTextBoxNUM_BatteryMaximumVoltage.Text = "42.0";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_BatteryMaximumVoltage.Text = "41.0";
                }
                // ���Ƿѹ����ֵ
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_BatteryMinimumVoltage.Text) < (28))
                    {
                        myTextBoxNUM_BatteryMinimumVoltage.Text = "28.0";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_BatteryMinimumVoltage.Text) > (36))
                    {
                        myTextBoxNUM_BatteryMinimumVoltage.Text = "36.0";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_BatteryMinimumVoltage.Text = "30.0";
                }
            }
        }

        // ��ع�ѹ����ֵע��
        private void myTextBoxNUM_BatteryMaximumVoltage_Leave(object sender, EventArgs e)
        {
            // 48V���
            if (comboBox_BatteryType.SelectedIndex == 0)
            {
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_BatteryMaximumVoltage.Text) < (48))
                    {
                        myTextBoxNUM_BatteryMaximumVoltage.Text = "48.0";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_BatteryMaximumVoltage.Text) > (56))
                    {
                        myTextBoxNUM_BatteryMaximumVoltage.Text = "56.0";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_BatteryMaximumVoltage.Text = "54.0";
                }
            }
            // 36V���
            else if (comboBox_BatteryType.SelectedIndex == 1)
            {
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_BatteryMaximumVoltage.Text) < (36))
                    {
                        myTextBoxNUM_BatteryMaximumVoltage.Text = "36.0";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_BatteryMaximumVoltage.Text) > (42))
                    {
                        myTextBoxNUM_BatteryMaximumVoltage.Text = "42.0";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_BatteryMaximumVoltage.Text = "41.0";
                }
            }
        }

        // ���Ƿѹ����ֵ
        private void myTextBoxNUM_BatteryMinimumVoltage_Leave(object sender, EventArgs e)
        {
            // 48V���
            if (comboBox_BatteryType.SelectedIndex == 0)
            {
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_BatteryMinimumVoltage.Text) < (42))
                    {
                        myTextBoxNUM_BatteryMinimumVoltage.Text = "42.0";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_BatteryMinimumVoltage.Text) > (48))
                    {
                        myTextBoxNUM_BatteryMinimumVoltage.Text = "48.0";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_BatteryMinimumVoltage.Text = "42.5";
                }
            }
            // 36V���
            else if (comboBox_BatteryType.SelectedIndex == 1)
            {
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_BatteryMinimumVoltage.Text) < (28))
                    {
                        myTextBoxNUM_BatteryMinimumVoltage.Text = "28.0";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_BatteryMinimumVoltage.Text) > (36))
                    {
                        myTextBoxNUM_BatteryMinimumVoltage.Text = "36.0";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_BatteryMinimumVoltage.Text = "30.0";
                }
            }
        }

        // ��ת��������
        private void myTextBoxNUM_LockedRotorProtectionCurrentValue_Leave(object sender, EventArgs e)
        {
            // 6��
            if (comboBox_Pipe.SelectedIndex == 0)
            {
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_LockedRotorProtectionCurrentValue.Text) < (6))
                    {
                        myTextBoxNUM_LockedRotorProtectionCurrentValue.Text = "6";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_LockedRotorProtectionCurrentValue.Text) > (35))
                    {
                        myTextBoxNUM_LockedRotorProtectionCurrentValue.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_LockedRotorProtectionCurrentValue.Text = "10";
                }
            }
            // 9��
            else if (comboBox_Pipe.SelectedIndex == 1)
            {
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_LockedRotorProtectionCurrentValue.Text) < (6))
                    {
                        myTextBoxNUM_LockedRotorProtectionCurrentValue.Text = "6";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_LockedRotorProtectionCurrentValue.Text) > (35))
                    {
                        myTextBoxNUM_LockedRotorProtectionCurrentValue.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_LockedRotorProtectionCurrentValue.Text = "10";
                }
            }
            // 12��
            else if (comboBox_Pipe.SelectedIndex == 2)
            {
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_LockedRotorProtectionCurrentValue.Text) < (6))
                    {
                        myTextBoxNUM_LockedRotorProtectionCurrentValue.Text = "6";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_LockedRotorProtectionCurrentValue.Text) > (35))
                    {
                        myTextBoxNUM_LockedRotorProtectionCurrentValue.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_LockedRotorProtectionCurrentValue.Text = "10";
                }
            }
        }

        // �� ComboBox
        private void comboBox_Pipe_SelectedIndexChanged(object sender, EventArgs e)
        {
            // �˴������������ݴ�������Ժ�������ģ����ô˴�
            // ������ĵĵط�������
            // 1.�������ֵ����ֵ�ķ�Χ��ϵ��
            // 2.��ת��������ֵ�ķ�Χ��ϵ��
            // 3.��������������������ķ�Χ��ϵ��
            // 6��
            if (comboBox_Pipe.SelectedIndex == 0)
            {
                // �������ֵ����ֵ
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_PhaseCurrentPeak.Text) < (6))
                    {
                        myTextBoxNUM_PhaseCurrentPeak.Text = "6";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_PhaseCurrentPeak.Text) > (35))
                    {
                        myTextBoxNUM_PhaseCurrentPeak.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_PhaseCurrentPeak.Text = "20";
                }
                // ��ת��������
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_LockedRotorProtectionCurrentValue.Text) < (6))
                    {
                        myTextBoxNUM_LockedRotorProtectionCurrentValue.Text = "6";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_LockedRotorProtectionCurrentValue.Text) > (35))
                    {
                        myTextBoxNUM_LockedRotorProtectionCurrentValue.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_LockedRotorProtectionCurrentValue.Text = "10";
                }
                // �������� ������ ����ֵ ����
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SNLAccelerationAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SNLAccelerationAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SNLAccelerationAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SNLAccelerationAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SNLAccelerationAmpere.Text = "20";
                }
                // �������� ������ ����ֵ ����
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SNLHighAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SNLHighAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SNLHighAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SNLHighAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SNLHighAmpere.Text = "17";
                }
                // �������� ������ ����ֵ ����
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SNLMidAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SNLMidAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SNLMidAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SNLMidAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SNLMidAmpere.Text = "13";
                }
                // �������� ������ ����ֵ ����
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SNLLowAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SNLLowAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SNLLowAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SNLLowAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SNLLowAmpere.Text = "9";
                }
                // �������� ������ ����ֵ ����
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SLAccelerationAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SLAccelerationAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SLAccelerationAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SLAccelerationAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SLAccelerationAmpere.Text = "12";
                }
                // �������� ������ ����ֵ ����
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SLHighAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SLHighAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SLHighAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SLHighAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SLHighAmpere.Text = "10";
                }
                // �������� ������ ����ֵ ����
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SLMidAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SLMidAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SLMidAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SLMidAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SLMidAmpere.Text = "8";
                }
                // �������� ������ ����ֵ ����
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SLLowAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SLLowAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SLLowAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SLLowAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SLLowAmpere.Text = "6";
                }
            }

            // 9��
            else if (comboBox_Pipe.SelectedIndex == 1)
            {
                // �������ֵ����ֵ
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_PhaseCurrentPeak.Text) < (6))
                    {
                        myTextBoxNUM_PhaseCurrentPeak.Text = "6";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_PhaseCurrentPeak.Text) > (35))
                    {
                        myTextBoxNUM_PhaseCurrentPeak.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_PhaseCurrentPeak.Text = "20";
                }
                // ��ת��������
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_LockedRotorProtectionCurrentValue.Text) < (6))
                    {
                        myTextBoxNUM_LockedRotorProtectionCurrentValue.Text = "6";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_LockedRotorProtectionCurrentValue.Text) > (35))
                    {
                        myTextBoxNUM_LockedRotorProtectionCurrentValue.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_LockedRotorProtectionCurrentValue.Text = "10";
                }
                // �������� ������ ����ֵ ����
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SNLAccelerationAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SNLAccelerationAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SNLAccelerationAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SNLAccelerationAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SNLAccelerationAmpere.Text = "20";
                }
                // �������� ������ ����ֵ ����
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SNLHighAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SNLHighAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SNLHighAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SNLHighAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SNLHighAmpere.Text = "17";
                }
                // �������� ������ ����ֵ ����
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SNLMidAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SNLMidAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SNLMidAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SNLMidAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SNLMidAmpere.Text = "13";
                }
                // �������� ������ ����ֵ ����
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SNLLowAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SNLLowAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SNLLowAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SNLLowAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SNLLowAmpere.Text = "9";
                }
                // �������� ������ ����ֵ ����
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SLAccelerationAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SLAccelerationAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SLAccelerationAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SLAccelerationAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SLAccelerationAmpere.Text = "12";
                }
                // �������� ������ ����ֵ ����
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SLHighAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SLHighAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SLHighAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SLHighAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SLHighAmpere.Text = "10";
                }
                // �������� ������ ����ֵ ����
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SLMidAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SLMidAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SLMidAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SLMidAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SLMidAmpere.Text = "8";
                }
                // �������� ������ ����ֵ ����
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SLLowAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SLLowAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SLLowAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SLLowAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SLLowAmpere.Text = "6";
                }
            }

            // 12��
            else if (comboBox_Pipe.SelectedIndex == 2)
            {
                // �������ֵ����ֵ
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_PhaseCurrentPeak.Text) < (6))
                    {
                        myTextBoxNUM_PhaseCurrentPeak.Text = "6";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_PhaseCurrentPeak.Text) > (35))
                    {
                        myTextBoxNUM_PhaseCurrentPeak.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_PhaseCurrentPeak.Text = "20";
                }
                // ��ת��������
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_LockedRotorProtectionCurrentValue.Text) < (6))
                    {
                        myTextBoxNUM_LockedRotorProtectionCurrentValue.Text = "6";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_LockedRotorProtectionCurrentValue.Text) > (35))
                    {
                        myTextBoxNUM_LockedRotorProtectionCurrentValue.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_LockedRotorProtectionCurrentValue.Text = "10";
                }
                // �������� ������ ����ֵ ����
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SNLAccelerationAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SNLAccelerationAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SNLAccelerationAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SNLAccelerationAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SNLAccelerationAmpere.Text = "20";
                }
                // �������� ������ ����ֵ ����
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SNLHighAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SNLHighAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SNLHighAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SNLHighAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SNLHighAmpere.Text = "17";
                }
                // ע��
                // �������� ������ ����ֵ ����
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SNLMidAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SNLMidAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SNLMidAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SNLMidAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SNLMidAmpere.Text = "13";
                }
                // �������� ������ ����ֵ ����
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SNLLowAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SNLLowAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SNLLowAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SNLLowAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SNLLowAmpere.Text = "9";
                }
                // �������� ������ ����ֵ ����
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SLAccelerationAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SLAccelerationAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SLAccelerationAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SLAccelerationAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SLAccelerationAmpere.Text = "12";
                }
                // �������� ������ ����ֵ ����
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SLHighAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SLHighAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SLHighAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SLHighAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SLHighAmpere.Text = "10";
                }
                // �������� ������ ����ֵ ����
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SLMidAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SLMidAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SLMidAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SLMidAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SLMidAmpere.Text = "8";
                }
                // �������� ������ ����ֵ ����
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SLLowAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SLLowAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SLLowAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SLLowAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SLLowAmpere.Text = "6";
                }
            }
        }

        // ��������
        private void comboBox_Hall_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Hall.SelectedIndex == 0)
            {
                comboBox_HallPhaseValue.Enabled = false;
            }
            else if (comboBox_Hall.SelectedIndex == 1)
            {
                comboBox_HallPhaseValue.Enabled = true;
            }
        }

        #endregion

        #region --���ܱ���--

        // �������� ������ ����ֵ ����
        private void myTextBoxNUM_SNLAccelerationSpeed_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(myTextBoxNUM_SNLAccelerationSpeed.Text) < (1))
                {
                    myTextBoxNUM_SNLAccelerationSpeed.Text = "1";
                }
                else if (Convert.ToDouble(myTextBoxNUM_SNLAccelerationSpeed.Text) > (600))
                {
                    myTextBoxNUM_SNLAccelerationSpeed.Text = "600";
                }
            }
            catch (Exception)
            {
                myTextBoxNUM_SNLAccelerationSpeed.Text = "450";
            }
        }
        // �������� ������ ����ֵ ����
        private void myTextBoxNUM_SNLHighSpeed_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(myTextBoxNUM_SNLHighSpeed.Text) < (1))
                {
                    myTextBoxNUM_SNLHighSpeed.Text = "1";
                }
                else if (Convert.ToDouble(myTextBoxNUM_SNLHighSpeed.Text) > (600))
                {
                    myTextBoxNUM_SNLHighSpeed.Text = "600";
                }
            }
            catch (Exception)
            {
                myTextBoxNUM_SNLHighSpeed.Text = "410";
            }
        }
        // �������� ������ ����ֵ ����
        private void myTextBoxNUM_SNLMidSpeed_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(myTextBoxNUM_SNLMidSpeed.Text) < (1))
                {
                    myTextBoxNUM_SNLMidSpeed.Text = "1";
                }
                else if (Convert.ToDouble(myTextBoxNUM_SNLMidSpeed.Text) > (600))
                {
                    myTextBoxNUM_SNLMidSpeed.Text = "600";
                }
            }
            catch (Exception)
            {
                myTextBoxNUM_SNLMidSpeed.Text = "320";
            }
        }
        // �������� ������ ����ֵ ����
        private void myTextBoxNUM_SNLLowSpeed_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(myTextBoxNUM_SNLLowSpeed.Text) < (1))
                {
                    myTextBoxNUM_SNLLowSpeed.Text = "1";
                }
                else if (Convert.ToDouble(myTextBoxNUM_SNLLowSpeed.Text) > (600))
                {
                    myTextBoxNUM_SNLLowSpeed.Text = "600";
                }
            }
            catch (Exception)
            {
                myTextBoxNUM_SNLLowSpeed.Text = "210";
            }
        }
        // �������� ������ ����ֵ ����
        private void myTextBoxNUM_SNLAccelerationAmpere_Leave(object sender, EventArgs e)
        {
            // 6��
            if (comboBox_Pipe.SelectedIndex == 0)
            {
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SNLAccelerationAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SNLAccelerationAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SNLAccelerationAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SNLAccelerationAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SNLAccelerationAmpere.Text = "20";
                }
            }
            // 9��
            else if (comboBox_Pipe.SelectedIndex == 1)
            {
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SNLAccelerationAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SNLAccelerationAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SNLAccelerationAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SNLAccelerationAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SNLAccelerationAmpere.Text = "20";
                }
            }
            // 12��
            else if (comboBox_Pipe.SelectedIndex == 2)
            {
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SNLAccelerationAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SNLAccelerationAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SNLAccelerationAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SNLAccelerationAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SNLAccelerationAmpere.Text = "20";
                }
            }
        }
        // �������� ������ ����ֵ ����
        private void myTextBoxNUM_SNLHighAmpere_Leave(object sender, EventArgs e)
        {
            // 6��
            if (comboBox_Pipe.SelectedIndex == 0)
            {
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SNLHighAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SNLHighAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SNLHighAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SNLHighAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SNLHighAmpere.Text = "17";
                }
            }
            // 9��
            else if (comboBox_Pipe.SelectedIndex == 1)
            {
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SNLHighAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SNLHighAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SNLHighAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SNLHighAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SNLHighAmpere.Text = "17";
                }
            }
            // 12��
            else if (comboBox_Pipe.SelectedIndex == 2)
            {
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SNLHighAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SNLHighAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SNLHighAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SNLHighAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SNLHighAmpere.Text = "17";
                }
            }
        }
        // �������� ������ ����ֵ ����
        private void myTextBoxNUM_SNLMidAmpere_Leave(object sender, EventArgs e)
        {
            // 6��
            if (comboBox_Pipe.SelectedIndex == 0)
            {
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SNLMidAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SNLMidAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SNLMidAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SNLMidAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SNLMidAmpere.Text = "13";
                }
            }
            // 9��
            else if (comboBox_Pipe.SelectedIndex == 1)
            {
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SNLMidAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SNLMidAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SNLMidAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SNLMidAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SNLMidAmpere.Text = "13";
                }
            }
            // 12��
            else if (comboBox_Pipe.SelectedIndex == 2)
            {
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SNLMidAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SNLMidAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SNLMidAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SNLMidAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SNLMidAmpere.Text = "13";
                }
            }
        }
        // �������� ������ ����ֵ ����
        private void myTextBoxNUM_SNLLowAmpere_Leave(object sender, EventArgs e)
        {
            // 6��
            if (comboBox_Pipe.SelectedIndex == 0)
            {
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SNLLowAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SNLLowAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SNLLowAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SNLLowAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SNLLowAmpere.Text = "9";
                }
            }
            // 9��
            else if (comboBox_Pipe.SelectedIndex == 1)
            {
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SNLLowAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SNLLowAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SNLLowAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SNLLowAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SNLLowAmpere.Text = "9";
                }
            }
            // 12��
            else if (comboBox_Pipe.SelectedIndex == 2)
            {
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SNLLowAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SNLLowAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SNLLowAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SNLLowAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SNLLowAmpere.Text = "9";
                }
            }
        }
        // �������� ������ ����ֵ ����
        private void myTextBoxNUM_SLAccelerationSpeed_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(myTextBoxNUM_SLAccelerationSpeed.Text) < (1))
                {
                    myTextBoxNUM_SLAccelerationSpeed.Text = "1";
                }
                else if (Convert.ToDouble(myTextBoxNUM_SLAccelerationSpeed.Text) > (600))
                {
                    myTextBoxNUM_SLAccelerationSpeed.Text = "600";
                }
            }
            catch (Exception)
            {
                myTextBoxNUM_SLAccelerationSpeed.Text = "270";
            }
        }
        // �������� ������ ����ֵ ����
        private void myTextBoxNUM_SLHighSpeed_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(myTextBoxNUM_SLHighSpeed.Text) < (1))
                {
                    myTextBoxNUM_SLHighSpeed.Text = "1";
                }
                else if (Convert.ToDouble(myTextBoxNUM_SLHighSpeed.Text) > (600))
                {
                    myTextBoxNUM_SLHighSpeed.Text = "600";
                }
            }
            catch (Exception)
            {
                myTextBoxNUM_SLHighSpeed.Text = "244";
            }
        }
        // �������� ������ ����ֵ ����
        private void myTextBoxNUM_SLMidSpeed_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(myTextBoxNUM_SLMidSpeed.Text) < (1))
                {
                    myTextBoxNUM_SLMidSpeed.Text = "1";
                }
                else if (Convert.ToDouble(myTextBoxNUM_SLMidSpeed.Text) > (600))
                {
                    myTextBoxNUM_SLMidSpeed.Text = "600";
                }
            }
            catch (Exception)
            {
                myTextBoxNUM_SLMidSpeed.Text = "190";
            }
        }
        // �������� ������ ����ֵ ����
        private void myTextBoxNUM_SLLowSpeed_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(myTextBoxNUM_SLLowSpeed.Text) < (1))
                {
                    myTextBoxNUM_SLLowSpeed.Text = "1";
                }
                else if (Convert.ToDouble(myTextBoxNUM_SLLowSpeed.Text) > (600))
                {
                    myTextBoxNUM_SLLowSpeed.Text = "600";
                }
            }
            catch (Exception)
            {
                myTextBoxNUM_SLLowSpeed.Text = "126";
            }
        }
        // �������� ������ ����ֵ ����
        private void myTextBoxNUM_SLAccelerationAmpere_Leave(object sender, EventArgs e)
        {
            // 6��
            if (comboBox_Pipe.SelectedIndex == 0)
            {
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SLAccelerationAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SLAccelerationAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SLAccelerationAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SLAccelerationAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SLAccelerationAmpere.Text = "12";
                }
            }
            // 9��
            else if (comboBox_Pipe.SelectedIndex == 1)
            {
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SLAccelerationAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SLAccelerationAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SLAccelerationAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SLAccelerationAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SLAccelerationAmpere.Text = "12";
                }
            }
            // 12��
            else if (comboBox_Pipe.SelectedIndex == 2)
            {
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SLAccelerationAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SLAccelerationAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SLAccelerationAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SLAccelerationAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SLAccelerationAmpere.Text = "12";
                }
            }
        }
        // �������� ������ ����ֵ ����
        private void myTextBoxNUM_SLHighAmpere_Leave(object sender, EventArgs e)
        {
            // 6��
            if (comboBox_Pipe.SelectedIndex == 0)
            {
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SLHighAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SLHighAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SLHighAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SLHighAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SLHighAmpere.Text = "10";
                }
            }
            // 9��
            else if (comboBox_Pipe.SelectedIndex == 1)
            {
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SLHighAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SLHighAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SLHighAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SLHighAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SLHighAmpere.Text = "10";
                }
            }
            // 12��
            else if (comboBox_Pipe.SelectedIndex == 2)
            {
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SLHighAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SLHighAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SLHighAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SLHighAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SLHighAmpere.Text = "10";
                }
            }
        }
        // �������� ������ ����ֵ ����
        private void myTextBoxNUM_SLMidAmpere_Leave(object sender, EventArgs e)
        {
            // 6��
            if (comboBox_Pipe.SelectedIndex == 0)
            {
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SLMidAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SLMidAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SLMidAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SLMidAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SLMidAmpere.Text = "8";
                }
            }
            // 9��
            else if (comboBox_Pipe.SelectedIndex == 1)
            {
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SLMidAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SLMidAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SLMidAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SLMidAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SLMidAmpere.Text = "8";
                }
            }
            // 12��
            else if (comboBox_Pipe.SelectedIndex == 2)
            {
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SLMidAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SLMidAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SLMidAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SLMidAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SLMidAmpere.Text = "8";
                }
            }
        }
        // �������� ������ ����ֵ ����
        private void myTextBoxNUM_SLLowAmpere_Leave(object sender, EventArgs e)
        {
            // 6��
            if (comboBox_Pipe.SelectedIndex == 0)
            {
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SLLowAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SLLowAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SLLowAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SLLowAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SLLowAmpere.Text = "6";
                }
            }
            // 9��
            else if (comboBox_Pipe.SelectedIndex == 1)
            {
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SLLowAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SLLowAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SLLowAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SLLowAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SLLowAmpere.Text = "6";
                }
            }
            // 12��
            else if (comboBox_Pipe.SelectedIndex == 2)
            {
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_SLLowAmpere.Text) < (1))
                    {
                        myTextBoxNUM_SLLowAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_SLLowAmpere.Text) > (35))
                    {
                        myTextBoxNUM_SLLowAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_SLLowAmpere.Text = "6";
                }
            }
        }

        // Ѳ������
        private void comboBox_Cruise_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ������ɫ
            //if (comboBox_Cruise.SelectedIndex == 0)
            //{ comboBox_Cruise.BackColor = Color.Red; }
            //else
            //{ comboBox_Cruise.BackColor = Color.Green;}
        }

        // �綯Ѳ������ת��
        private void comboBox_CruiseSwitch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // �Զ�Ѳ���ֱ��ȶ�ʱ��
        private void myTextBoxNUM_AutoHoldTime_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(myTextBoxNUM_AutoHoldTime.Text) < (2))
                {
                    myTextBoxNUM_AutoHoldTime.Text = "2";
                }
                else if (Convert.ToDouble(myTextBoxNUM_AutoHoldTime.Text) > (12))
                {
                    myTextBoxNUM_AutoHoldTime.Text = "12";
                }
            }
            catch (Exception)
            {
                myTextBoxNUM_AutoHoldTime.Text = "8";
            }
        }

        // �ֶ�Ѳ����������ʱ��
        private void myTextBoxNUM_ManualHoldTime_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(myTextBoxNUM_ManualHoldTime.Text) < (1))
                {
                    myTextBoxNUM_ManualHoldTime.Text = "1";
                }
                else if (Convert.ToDouble(myTextBoxNUM_ManualHoldTime.Text) > (4))
                {
                    myTextBoxNUM_ManualHoldTime.Text = "4";
                }
            }
            catch (Exception)
            {
                myTextBoxNUM_ManualHoldTime.Text = "2";
            }
        }

        // ��������
        private void comboBox_Boost_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // ��̬��ʾ
        private void comboBox_ThreeStatusShowSwitch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // ģ���ٶ���ʾ
        private void myTextBoxNUM_SimulationSpeedShow_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(myTextBoxNUM_SimulationSpeedShow.Text) < (0.2))
                {
                    myTextBoxNUM_SimulationSpeedShow.Text = "0.2";
                }
                else if (Convert.ToDouble(myTextBoxNUM_SimulationSpeedShow.Text) > (1))
                {
                    myTextBoxNUM_SimulationSpeedShow.Text = "1.0";
                }
            }
            catch (Exception)
            {
                myTextBoxNUM_SimulationSpeedShow.Text = "1.0";
            }
        }

        // ģ�������ʾ
        private void myTextBoxNUM_SimulationCurrentShow_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(myTextBoxNUM_SimulationCurrentShow.Text) < (2))
                {
                    myTextBoxNUM_SimulationCurrentShow.Text = "2.0";
                }
                else if (Convert.ToDouble(myTextBoxNUM_SimulationCurrentShow.Text) > (10))
                {
                    myTextBoxNUM_SimulationCurrentShow.Text = "10.0";
                }
            }
            catch (Exception)
            {
                myTextBoxNUM_SimulationCurrentShow.Text = "5.0";
            }
        }

        // ɲ������
        private void comboBox_Braking_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Braking.SelectedIndex == 0)
            {
                trackBar_BrakingPotency.Enabled = false;
            }
            else
            {
                trackBar_BrakingPotency.Enabled = true;
            }
        }

        // ����ʵ��
        private void comboBox_MoreSpeed_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        #endregion

        #region --��������--

        // ����ͺ�ѡ��
        private void checkBox_MotorType_Select_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_MotorType_Select.Checked == true)
            {
                comboBox_MotorType.Enabled = true;
            }
            else
            {
                comboBox_MotorType.Enabled = false;
            }
        }

        // ����ͺ�
        private void comboBox_MotorType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // ������ʽ
        private void trackBar_StartStyle_Scroll(object sender, EventArgs e)
        {
            //label_StartStyle.Text = trackBar_StartStyle.Value.ToString();
        }

        // ������ʽ��ֵ�ı�
        private void trackBar_StartStyle_ValueChanged(object sender, EventArgs e)
        {
            //label_StartStyle.Text = trackBar_StartStyle.Value.ToString();
        }

        // ɲ������
        private void trackBar_BrakingPotency_Scroll(object sender, EventArgs e)
        {
            label_BrakingPotency.Text = trackBar_BrakingPotency.Value.ToString();
        }

        // ɲ�����ȵ�ֵ�ı�
        private void trackBar_BrakingPotency_ValueChanged(object sender, EventArgs e)
        {
            label_BrakingPotency.Text = trackBar_BrakingPotency.Value.ToString();
        }

        // ��ת����ѡ��
        private void checkBox_LockedRotorCurrentDrop_Select_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_LockedRotorCurrentDrop_Select.Checked == true)
            {
                comboBox_LockedRotorCurrentDrop.Enabled = true;
            }
            else
            {
                comboBox_LockedRotorCurrentDrop.Enabled = false;
            }
        }

        // ��ת����
        private void comboBox_LockedRotorCurrentDrop_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        // ����ɲ���ɳ�ѡ��
        private void checkBox_HandBrakeOverrun_Select_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_HandBrakeOverrun_Select.Checked == true)
            {
                comboBox_HandBrakeOverrun.Enabled = true;
            }
            else
            {
                comboBox_HandBrakeOverrun.Enabled = false;
            }
        }

        // ����ɲ���ɳ�
        private void comboBox_HandBrakeOverrun_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        // ���з����ѡ��
        private void checkBox_SlideCharge_Select_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_SlideCharge_Select.Checked == true)
            {
                comboBox_SlideCharge.Enabled = true;
            }
            else
            {
                comboBox_SlideCharge.Enabled = false;
            }
        }

        // ���з����
        private void comboBox_ReverseCharge_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        #endregion

        #region --��ʱ��--

        // ����ָ�ʱ��
        private void timer_Send_Tick(object sender, EventArgs e)
        {
            // ���÷��ͷ���ָ�������
            SerialPortSend.CommandSendPrecess(this);
        }

        // ����ָ�ʱ��
        private void timer_Receive_Tick(object sender, EventArgs e)
        {
            // ���÷��ͽ���ָ�������
            SerialPortSend.CommandReceiveProcess(this);
        }

        // �ȴ���������ָ��
        private void timer_WaitForAllCommand_Tick(object sender, EventArgs e)
        {
            gsi_WaitForAllCommandCounter++;

            if (gsi_WaitForAllCommandCounter >= gsi_WaitForAllCommandCounter_Max)
            {
                // ��������
                gsi_WaitForAllCommandCounter = 0;

                // ֹͣȫ��ָ�������ɶ�ʱ��
                timer_WaitForAllCommand.Enabled = false;

                // ��ȡ���ݵĽ��մ���
                if (SerialPortSend.gss_IsIdleOrReceiveOrSend == SerialPortSend.gss_serialPortStatus[1])
                {
                    // ʹ�ܿؼ�
                    EET_myToolStripFocus.Enabled = true;

                    // ֹͣ��ʱ��
                    timer_Receive.Enabled = false;

                    // ��ʾָ���״̬
                    toolStripStatusLabel_NowStatus.Text = "ͨѶ���������¶�ȡ��";

                    // ����ʧ�ܣ����÷���ָ�����
                    SerialPortSend.gsui_myCommandCounter = 1;

                    // �ط���������
                    SerialPortSend.gsi_ReSendCount = 0;

                    // ���ڴ�״̬
                    gsb_SerialPort_IsOpen = true;
                    // �رմ���
                    ChangeSerialPortStatus(gsb_SerialPort_IsOpen);
                    // ����Ϊ����״̬
                    SerialPortSend.gss_IsIdleOrReceiveOrSend = SerialPortSend.gss_serialPortStatus[0];

                    // ������ʾ����״̬��Label��ɫ������
                    toolStripStatusLabel1.Text = "�ѹر�";
                    toolStripStatusLabel1.BackColor = Color.Red;

                    // ʹ�����ô��ڶ˿ں�
                    toolStripComboBox_PortName.Enabled = true;
                }
                // �������ݵĽ��մ���
                else if (SerialPortSend.gss_IsIdleOrReceiveOrSend == SerialPortSend.gss_serialPortStatus[2])
                {
                    // ֹͣ��ʱ��
                    timer_Send.Enabled = false;

                    // ��ʾָ���״̬
                    toolStripStatusLabel_NowStatus.Text = "ͨѶ���������·��ͣ�";

                    // ��ɷ��ͣ�����ָ�������λ
                    SerialPortSend.gsui_myCommandCounter = 1;

                    // �ط���������
                    SerialPortSend.gsi_ReSendCount = 0;

                    // ʹ�ܿؼ�
                    EET_myToolStripFocus.Enabled = true;
                    groupBox_Parameters.Enabled = true;
                    groupBox_Function.Enabled = true;
                    groupBox_Display.Enabled = true;

                    // ���ڴ�״̬
                    Form1.gsb_SerialPort_IsOpen = true;
                    // �رմ���
                    ChangeSerialPortStatus(gsb_SerialPort_IsOpen);
                    // ����Ϊ����״̬
                    SerialPortSend.gss_IsIdleOrReceiveOrSend = SerialPortSend.gss_serialPortStatus[0];

                    // ������ʾ����״̬��Label��ɫ������
                    toolStripStatusLabel1.Text = "�ѹر�";
                    toolStripStatusLabel1.BackColor = Color.Red;

                    // ʹ�����ô��ڶ˿ں�
                    toolStripComboBox_PortName.Enabled = true;
                }
            }
            else
            {
                // ��ȡ���ݵĽ��մ���
                if (SerialPortSend.gss_IsIdleOrReceiveOrSend == SerialPortSend.gss_serialPortStatus[1])
                {
                    // ����ȡ�����������ݼ���ֵ����Ҫ����Ϊ�������
                    if (SerialPortReceive.gsi_GetAllCommandCounter_Receive == 8)
                    {
                        // ��ȡ�����������ݼ�������
                        SerialPortReceive.gsi_GetAllCommandCounter_Receive = 0;

                        // ��������
                        gsi_WaitForAllCommandCounter = 0;

                        // ֹͣȫ��ָ�������ɶ�ʱ��
                        timer_WaitForAllCommand.Enabled = false;

                        // ��ʾָ������
                        toolStripStatusLabel_NowStatus.Text = "ָ�����ϣ�Ӧ����ȷ��";

                        // ������ɣ����÷���ָ�����
                        SerialPortSend.gsui_myCommandCounter = 1;

                        // �ط���������
                        SerialPortSend.gsi_ReSendCount = 0;

                        // ʹ�ܿؼ�
                        EET_myToolStripFocus.Enabled = true;
                        groupBox_Parameters.Enabled = true;
                        groupBox_Function.Enabled = true;
                        groupBox_Display.Enabled = true;

                        // ʹ�ܰ�ť
                        toolStripMenuItem_Save.Enabled = true;
                        toolStripMenuItem_DownLoad.Enabled = true;

                        // ���ڴ�״̬
                        gsb_SerialPort_IsOpen = true;
                        // �رմ���
                        ChangeSerialPortStatus(gsb_SerialPort_IsOpen);
                        // ����Ϊ����״̬
                        SerialPortSend.gss_IsIdleOrReceiveOrSend = SerialPortSend.gss_serialPortStatus[0];

                        // ������ʾ����״̬��Label��ɫ������
                        toolStripStatusLabel1.Text = "�ѹر�";
                        toolStripStatusLabel1.BackColor = Color.Red;

                        // ʹ�����ô��ڶ˿ں�
                        toolStripComboBox_PortName.Enabled = true;
                    }
                }
                // �������ݵĽ��մ���
                else if (SerialPortSend.gss_IsIdleOrReceiveOrSend == SerialPortSend.gss_serialPortStatus[2])
                {
                    // �����Ͳ����������ݼ���ֵ����Ҫ����Ϊ�������
                    if (SerialPortReceive.gsi_GetAllCommandCounter_Send == 6)
                    {
                        // ���Ͳ����������ݼ�������
                        SerialPortReceive.gsi_GetAllCommandCounter_Send = 0;

                        // ��������
                        gsi_WaitForAllCommandCounter = 0;

                        // ֹͣȫ��ָ�������ɶ�ʱ��
                        timer_WaitForAllCommand.Enabled = false;

                        // ��ʾָ������
                        toolStripStatusLabel_NowStatus.Text = "ָ�����ϣ�Ӧ����ȷ��";

                        // ��ɷ��ͣ�����ָ�������λ
                        SerialPortSend.gsui_myCommandCounter = 1;

                        // �ط���������
                        SerialPortSend.gsi_ReSendCount = 0;

                        // ʹ�ܿؼ�
                        EET_myToolStripFocus.Enabled = true;
                        groupBox_Parameters.Enabled = true;
                        groupBox_Function.Enabled = true;
                        groupBox_Display.Enabled = true;

                        // ���ڴ�״̬
                        Form1.gsb_SerialPort_IsOpen = true;
                        // �رմ���
                        ChangeSerialPortStatus(gsb_SerialPort_IsOpen);
                        // ����Ϊ����״̬
                        SerialPortSend.gss_IsIdleOrReceiveOrSend = SerialPortSend.gss_serialPortStatus[0];

                        // ������ʾ����״̬��Label��ɫ������
                        toolStripStatusLabel1.Text = "�ѹر�";
                        toolStripStatusLabel1.BackColor = Color.Red;

                        // ʹ�����ô��ڶ˿ں�
                        toolStripComboBox_PortName.Enabled = true;
                    }
                }
            }
        }

        #endregion

        #region --�´��ڵ��¼���ί��--

        /**************************************************************/
        /*************************** ������ ***************************/
        /**************************************************************/
        /// <summary>
        /// ������һ��ί������
        /// </summary>
        public delegate void WhenGetNew();

        /// <summary>
        /// ���ڷ�װ�࣬Help By Wyz
        /// </summary>
        public class PortDataDisplay
        {
            /// <summary>
            /// ϵͳ������
            /// </summary>
            public SerialPort serialPort = new SerialPort(gss_SerialPort_PortName, gsi_SerialPort_BaudRate);
            /// <summary>
            /// �����õ����ݺ󴥷��¼�
            /// </summary>
            public event WhenGetNew whenGetNew;
            /// <summary>
            /// �����߳�
            /// </summary>
            private SerialDataReceivedEventHandler threadCallHandler;
            /// <summary>
            /// ������������Ͷ���
            /// </summary>
            public string dataSrc = "";
            /// <summary>
            /// ׼���رմ���=true
            /// </summary>
            private bool m_IsTryToClosePort = false;
            /// <summary>
            /// true��ʾ���ڽ�������
            /// </summary>
            private bool m_IsReceiving = false;


            /// <summary>
            /// ��ʼ��
            /// </summary>
            public PortDataDisplay()
            {
            }

            /// <summary>
            /// �в����Ĺ��캯��
            /// </summary>
            /// <param name="PortName">���ںţ���"COM1"</param>
            /// <param name="BaudRate">�����ʣ���9600</param>
            public PortDataDisplay(string PortName, int BaudRate)
            {
                serialPort = new SerialPort(PortName, BaudRate);
            }

            /// <summary>
            /// ��ʼ����
            /// </summary>
            public void ConnectDeveice()
            {
                //0.ע���¼�
                serialPort.DataReceived -= OnSerialPortDataCome;
                serialPort.DataReceived += OnSerialPortDataCome;
                //1.������һ�´��ڲ���
                if (this.serialPort.IsOpen == false)
                {
                    this.serialPort.ReadBufferSize = 1000;
                    this.serialPort.ReceivedBytesThreshold = 1;//���ݴﵽ120��ʱ��ž�Ҫ�����¼������У���Ӧ�����������ʹ���
                    //2.�򿪴��ڿ�ʼ����
                    m_IsTryToClosePort = false;
                    this.serialPort.Open();
                }
            }

            /// <summary>
            /// ��������
            /// </summary>
            public void DisconnectDeveice() // �ؼ��ͺ��ģ�����
            {
                m_IsTryToClosePort = true;
                while (m_IsReceiving)
                {
                    System.Windows.Forms.Application.DoEvents();
                }
                serialPort.Close();
            }

            /// <summary>
            /// ��֪ͨ�������ݴﵽ120ʱ������ȡ���������
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void OnSerialPortDataCome(object sender, SerialDataReceivedEventArgs e)
            {
                if (m_IsTryToClosePort) // �ؼ�������
                {
                    return;
                }

                m_IsReceiving = true; // �ؼ�!!!

                try
                {
                    if (threadCallHandler == null)
                    {
                        threadCallHandler = new SerialDataReceivedEventHandler(OnSerialPortDataCome);
                    }
                    //����洢�������ݵ�����Ϊ1
                    byte[] result = new byte[1];
                    //��������ַ����洢�����顢��ʾλ�á�����
                    serialPort.Read(result, 0, result.Length);
                    // ASCII��
                    foreach (byte basc in result)
                    {
                        dataSrc = ((char)ulong.Parse(basc.ToString(), System.Globalization.NumberStyles.HexNumber - 10)).ToString();//��10���ܵó���ȷ�Ľ������Ҳ������ԭ���д��о�������
                    }
                    if (dataSrc != "" && this.whenGetNew != null)
                    {
                        this.whenGetNew();
                    }
                }
                finally // ����finally����ȽϺá�
                {
                    m_IsReceiving = false; // �ؼ�!!!
                }
            }
        }

        /**************************************************************/
        /************************** ��ʵ���� **************************/
        /**************************************************************/
        public PortDataDisplay m_portDispl = new PortDataDisplay(gss_SerialPort_PortName, gsi_SerialPort_BaudRate);

        // ���ô��ڿ��͹�
        public void ChangeSerialPortStatus(bool myNowStatus)
        {
            if (myNowStatus == false)
            {
                m_portDispl.whenGetNew -= portDispl_whenGetNew;
                m_portDispl.whenGetNew += new WhenGetNew(portDispl_whenGetNew);
                m_portDispl.ConnectDeveice();
                gsb_SerialPort_IsOpen = true;
            }
            else if (myNowStatus == true)
            {
                m_portDispl.DisconnectDeveice();
                gsb_SerialPort_IsOpen = false;
            }
        }

        // 
        private void portDispl_whenGetNew()
        {
            WhenGetNew ehan = delegate
            {
                // �������ݵĴ���
                SerialPortReceive.SerialPortReceiveProcess(this, m_portDispl.dataSrc);
            };

            try
            {
                if (InvokeRequired)
                {
                    this.Invoke(ehan);
                }
            }
            catch
            {
            }
        }
        #endregion
    }
}