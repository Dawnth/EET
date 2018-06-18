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

namespace EET
{
    public partial class Form1 : Form
    {
        #region --��������--

        // g  ����ȫ�ֱ���  global
        // s  ������̬����  static
        // s  �����ַ���    string

        // ������������������
        // 1.��������       D P
        // 2.������ʼ��     I P
        // �������
        // 3.���浽����     U T P
        // 4.����������     P T C
        // ��ȡ����
        // 5.���õ�����     C T P
        // 6.����������     P T U
        // 7.�ض�У��       R B C

        // D P
        #region ----�����趨��----

        // �������ֵ
        public static string gss_MotorSequence = "0";
        // ������λ��ֵ
        public static string gss_HallPhaseValue = "0";
        // ���ٷ�Χ����ֵ
        public static string gss_SpeedUpperBound = "214";
        // ���ٷ�Χ����ֵ
        public static string gss_SpeedLowerBound = "56";
        // ���ɳ���������ֵ
        public static string gss_ProtectionUpperBound = "230";
        // ���ɳ���������ֵ
        public static string gss_ProtectionLowerBound = "41";
        // �������ֵ
        public static string gss_PhaseCurrentPeak = "157";
        // �������ֵ
        public static string gss_BatteryType = "0";
        // ��ع�ѹֵ
        public static string gss_BatteryMaximumVoltage = "180";
        // ���Ƿѹֵ
        public static string gss_BatteryMinimumVoltage = "142";
        // 36V��ع�ѹֵ
        public static string gss_BatteryMaximumVoltage_36V = "137";
        // 36V���Ƿѹֵ
        public static string gss_BatteryMinimumVoltage_36V = "100";
        // ��ת��������ֵ
        public static string gss_LockedRotorProtectionCurrentValue = "104";
        // �����߷�ѹϵ��
        public static string gss_SpeedLimitVoltageDivideCoefficient = "17";

        #endregion

        #region ----����ѡ����----

        // ��������ѡ��
        public static string gss_SpeedAndAmpereLimit_Select = "false";
        // �������� ������ ����ֵ ����
        public static string gss_SNLAccelerationSpeed = "112";
        // �������� ������ ����ֵ ����
        public static string gss_SNLHighSpeed = "102";
        // �������� ������ ����ֵ ����
        public static string gss_SNLMidSpeed = "80";
        // �������� ������ ����ֵ ����
        public static string gss_SNLLowSpeed = "52";
        // �������� ������ ����ֵ ����
        public static string gss_SNLAccelerationAmpere = "157";
        // �������� ������ ����ֵ ����
        public static string gss_SNLHighAmpere = "141";
        // �������� ������ ����ֵ ����
        public static string gss_SNLMidAmpere = "120";
        // �������� ������ ����ֵ ����
        public static string gss_SNLLowAmpere = "99";
        // �������� ������ ����ֵ ����
        public static string gss_SLAccelerationSpeed = "68";
        // �������� ������ ����ֵ ����
        public static string gss_SLHighSpeed = "61";
        // �������� ������ ����ֵ ����
        public static string gss_SLMidSpeed = "48";
        // �������� ������ ����ֵ ����
        public static string gss_SLLowSpeed = "32";
        // �������� ������ ����ֵ ����
        public static string gss_SLAccelerationAmpere = "115";
        // �������� ������ ����ֵ ����
        public static string gss_SLHighAmpere = "104";
        // �������� ������ ����ֵ ����
        public static string gss_SLMidAmpere = "93";
        // �������� ������ ����ֵ ����
        public static string gss_SLLowAmpere = "83";

        // Ѳ������ѡ��
        public static string gss_Cruise_Select = "false";
        // Ѳ������
        public static string gss_Cruise = "0";

        // �綯Ѳ������ת��ѡ��
        public static string gss_CruiseSwitch_Select = "false";
        // �綯Ѳ������ת��
        public static string gss_CruiseSwitch = "0";

        // �Զ�Ѳ���ֱ��ȶ�ʱ��ѡ��
        public static string gss_AutoHoldTime_Select = "false";
        // �Զ�Ѳ���ֱ��ȶ�ʱ��
        public static string gss_AutoHoldTime = "80";

        // �ֶ�Ѳ����������ʱ��ѡ��
        public static string gss_ManualHoldTime_Select = "false";
        // �ֶ�Ѳ����������ʱ��
        public static string gss_ManualHoldTime = "40";

        // ��������ѡ��
        public static string gss_Boost_Select = "false";
        // ��������
        public static string gss_Boost = "0";

        // ��̬��ʾѡ��
        public static string gss_ThreeStatusShowSwitch_Select = "false";
        // ��̬��ʾ
        public static string gss_ThreeStatusShowSwitch = "0";

        // ģ���ٶ���ʾѡ��
        public static string gss_SimulationSpeedShow_Select = "false";
        // ģ���ٶ���ʾ
        public static string gss_SimulationSpeedShow = "10";

        // ģ�������ʾѡ��
        public static string gss_SimulationCurrentShow_Select = "false";
        // ģ�������ʾ
        public static string gss_SimulationCurrentShow = "50";

        // ɲ������ѡ��
        public static string gss_Braking_Select = "false";
        // ɲ������
        public static string gss_Braking = "0";

        // ����ʵ��ѡ��
        public static string gss_MoreSpeed_Select = "false";
        // ����ʵ��
        public static string gss_MoreSpeed = "0";


        //
        // ���¸��µĲ����������ĵ�����
        //
        // ����ͺ�
        public static string gss_MotorType_Select = "false";
        public static string gss_MotorType = "0";
        // ������ʽ
        public static string gss_StartStyle = "0";
        // ɲ������
        public static string gss_BrakingPotency = "0";
        // ��ת����
        public static string gss_LockedRotorCurrentDrop_Select = "false";
        public static string gss_LockedRotorCurrentDrop = "0";
        // ����ɲ���ɳ�
        public static string gss_HandBrakeOverrun_Select = "false";
        public static string gss_HandBrakeOverrun = "0";
        // ���з����
        public static string gss_SlideCharge_Select = "false";
        public static string gss_SlideCharge = "0";


        #endregion

        #region ----���صı���----

        // ��������1�Ƕ�ֵ
        public static string gss_HallForwardAngle_1 = "0";
        // ��������2�Ƕ�ֵ
        public static string gss_HallForwardAngle_2 = "0";
        // ��������3�Ƕ�ֵ
        public static string gss_HallForwardAngle_3 = "0";
        // ��������4�Ƕ�ֵ
        public static string gss_HallForwardAngle_4 = "0";
        // ��������5�Ƕ�ֵ
        public static string gss_HallForwardAngle_5 = "0";
        // ��������6�Ƕ�ֵ
        public static string gss_HallForwardAngle_6 = "0";
        // �����������1�Ƕ�ֵ
        public static string gss_HallReverseAngle_1 = "0";
        // �����������2�Ƕ�ֵ
        public static string gss_HallReverseAngle_2 = "0";
        // �����������3�Ƕ�ֵ
        public static string gss_HallReverseAngle_3 = "0";
        // �����������4�Ƕ�ֵ
        public static string gss_HallReverseAngle_4 = "0";
        // �����������5�Ƕ�ֵ
        public static string gss_HallReverseAngle_5 = "0";
        // �����������6�Ƕ�ֵ
        public static string gss_HallReverseAngle_6 = "0";
        // ��
        public static string gss_Pipe = "0";

        #endregion

        #region --��ť��ʹ��--
        // �����浽�ĵ�����ť��ʹ�ܼ�¼
        private bool Save_button_SavedFlag = true;
        // ����ȡĿ�����á���ť��ʹ�ܼ�¼
        private bool UpLoad_button_SavedFlag = true;
        // ���������á���ť��ʹ�ܼ�¼
        //private bool Generation_button_SavedFlag = true;
        // ���������õ�Ŀ�ꡱ��ť��ʹ�ܼ�¼
        //private bool DownLoad_button_SavedFlag = true;
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

            // ���ӵ�δ���뱣��Ϊ������������������
            // �������� ��Ĭ���У�
            comboBox_Hall.Text = comboBox_Hall.Items[1].ToString();
            // Ĭ�ϵ������
            comboBox_MotorSeries.Text = comboBox_MotorSeries.Items[0].ToString();
            // Ĭ�Ϲ�������
            comboBox_SamePolarity.Text = comboBox_SamePolarity.Items[0].ToString();

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
        }

        #endregion

        #region --��ť�¼�--

        // ���ļ��������ð�ť�¼�
        private void toolStripMenuItem_Open_Click(object sender, EventArgs e)
        {
            // ���Ӧ�ó����·��
            EET_openFileDialog.InitialDirectory = Application.StartupPath;
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

            // ��ֹ��ȡĿ�����ð�ť
            toolStripMenuItem_UpLoad.Enabled = false;

            // ���ü���ķ����������޸ĺ�ĵı���
            GenerateParameters.UIToParameters(this);

            // ʹ�ܡ��������õ�Ŀ�ꡱ�İ�ť
            toolStripMenuItem_DownLoad.Enabled = true;
            // ʹ�ܡ��������õ��ĵ�����ť
            toolStripMenuItem_Save.Enabled = true;
            // ʹ�ܡ���ȡ���������á���ť
            toolStripMenuItem_DownLoad.Enabled = true;


            // ���Ӧ�ó����·��
            EET_saveFileDialog.InitialDirectory = Application.StartupPath;
            EET_saveFileDialog.FileName = "EET_" + System.DateTime.Now.ToString("yyyyMMdd_HHmmss");
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
            System.Diagnostics.Process.Start("explorer.exe", Application.StartupPath);
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
        }

        // �������õ�������
        private void toolStripMenuItem_DownLoad_Click(object sender, EventArgs e)
        {

            // ��ֹ��ȡĿ�����ð�ť
            toolStripMenuItem_UpLoad.Enabled = false;

            // ���ü���ķ����������޸ĺ�ĵı���
            GenerateParameters.UIToParameters(this);

            // ʹ�ܡ��������õ�Ŀ�ꡱ�İ�ť
            toolStripMenuItem_DownLoad.Enabled = true;
            // ʹ�ܡ����浽�ĵ�����ť
            toolStripMenuItem_Save.Enabled = true;
            // ʹ�ܡ���ȡĿ�����á���ť
            toolStripMenuItem_UpLoad.Enabled = true;


            // ��Ҫ�ٴ����ɺ�����������õ�Ŀ��
            //toolStripMenuItem_DownLoad.Enabled = false;

            // �����浽�ĵ�����ť��ʹ�ܼ�¼
            Save_button_SavedFlag = toolStripMenuItem_Save.Enabled;
            // ����ȡĿ�����á���ť��ʹ�ܼ�¼
            UpLoad_button_SavedFlag = toolStripMenuItem_UpLoad.Enabled;

            // ����������õ�Ŀ�갴ť�󣬽�ֹ������������
            this.ControlBox = false;
            EET_myToolStripFocus.Enabled = false;
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            toolStripMenuItem_Save.Enabled = false;
            toolStripMenuItem_UpLoad.Enabled = false;

            // ��ʾ������
            toolStripProgressBar1.Visible = true;
            // ����ProgressBar
            for (; toolStripProgressBar1.Value < 100; )//ѭ��
            {
                // ��ͣ1��
                System.Threading.Thread.Sleep(20);
                // �ý���������һ��
                toolStripProgressBar1.Value += toolStripProgressBar1.Step;
                // ��������������˳�ѭ������ս������������ؽ�����
                if (toolStripProgressBar1.Value >= 100)
                {
                    System.Threading.Thread.Sleep(1000);
                    toolStripProgressBar1.Visible = false;
                    toolStripProgressBar1.Value = 0;
                    break;
                }
            }

            // ����¼���ɺ�ʹ��������������
            this.ControlBox = true;
            this.MaximizeBox = false;
            EET_myToolStripFocus.Enabled = true;
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            toolStripMenuItem_Save.Enabled = Save_button_SavedFlag;
            toolStripMenuItem_UpLoad.Enabled = UpLoad_button_SavedFlag;
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

        // ���صĿ��塰�����߷�ѹϵ������˫������ȫѡ�¼� 
        private void myTextBoxNUM_SpeedLimitVoltageDivideCoefficient_Lable_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // ˫����ʾ�����֣������߷�ѹϵ��
            //myTextBoxNUM_SpeedLimitVoltageDivideCoefficient_Lable.Text = "�����߷�ѹϵ��";
            // ѡ����������
            //myTextBoxNUM_SpeedLimitVoltageDivideCoefficient_Lable.SelectAll();
            // ʹ�����ص��������
            //myTextBoxNUM_SpeedLimitVoltageDivideCoefficient.Enabled = true;
            //myTextBoxNUM_SpeedLimitVoltageDivideCoefficient.Visible = true;
        }

        //// �������ð�ť
        //private void Generation_button_Click(object sender, EventArgs e)
        //{
        //    // ��ֹ��ȡĿ�����ð�ť
        //    toolStripMenuItem_UpLoad.Enabled = false;
        //
        //    // ���ü���ķ����������޸ĺ�ĵı���
        //    GenerateParameters.UIToConfiguration(this);
        //
        //    // ʹ�ܡ��������õ�Ŀ�ꡱ�İ�ť
        //    toolStripMenuItem_DownLoad.Enabled = true;
        //    // ʹ�ܡ����浽�ĵ�����ť
        //    toolStripMenuItem_Save.Enabled = true;
        //    // ʹ�ܡ���ȡĿ�����á���ť
        //    toolStripMenuItem_DownLoad.Enabled = true;
        //}

        // �������õ�Ŀ��
        private void DownLoad_button_Click(object sender, EventArgs e)
        {
            // ��Ҫ�ٴ����ɺ�����������õ�Ŀ��
            toolStripMenuItem_DownLoad.Enabled = false;

            // �����浽�ĵ�����ť��ʹ�ܼ�¼
            Save_button_SavedFlag = toolStripMenuItem_Save.Enabled;
            // ����ȡĿ�����á���ť��ʹ�ܼ�¼
            UpLoad_button_SavedFlag = toolStripMenuItem_UpLoad.Enabled;

            // ����������õ�Ŀ�갴ť�󣬽�ֹ������������
            this.ControlBox = false;
            EET_myToolStripFocus.Enabled = false;
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            toolStripMenuItem_Save.Enabled = false;
            toolStripMenuItem_UpLoad.Enabled = false;

            // ��ʾ������
            toolStripProgressBar1.Visible = true;
            // ����ProgressBar
            for (; toolStripProgressBar1.Value < 100; )//ѭ��
            {
                // ��ͣ1��
                System.Threading.Thread.Sleep(20);
                // �ý���������һ��
                toolStripProgressBar1.Value += toolStripProgressBar1.Step;
                // ��������������˳�ѭ������ս������������ؽ�����
                if (toolStripProgressBar1.Value >= 100)
                {
                    System.Threading.Thread.Sleep(1000);
                    toolStripProgressBar1.Visible = false;
                    toolStripProgressBar1.Value = 0;
                    break;
                }
            }

            // ����¼���ɺ�ʹ��������������
            this.ControlBox = true;
            this.MaximizeBox = false;
            EET_myToolStripFocus.Enabled = true;
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            toolStripMenuItem_Save.Enabled = Save_button_SavedFlag;
            toolStripMenuItem_UpLoad.Enabled = UpLoad_button_SavedFlag;
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

        // ���ٷ�ѹϵ��
        private void myTextBoxNUM_SpeedLimitVoltageDivideCoefficient_Leave(object sender, EventArgs e)
        {
            //try
            //{
            //    if (Convert.ToDouble(myTextBoxNUM_SpeedLimitVoltageDivideCoefficient.Text) < (1))
            //    {
            //        myTextBoxNUM_SpeedLimitVoltageDivideCoefficient.Text = "1.0";
            //    }
            //    else if (Convert.ToDouble(myTextBoxNUM_SpeedLimitVoltageDivideCoefficient.Text) > (2))
            //    {
            //        myTextBoxNUM_SpeedLimitVoltageDivideCoefficient.Text = "2.0";
            //    }
            //}
            //catch (Exception)
            //{
            //    myTextBoxNUM_SpeedLimitVoltageDivideCoefficient.Text = "1.7";
            //}
        }

        // �� ComboBox
        private void comboBox_Pipe_SelectedIndexChanged(object sender, EventArgs e)
        {
            // �˴������������ݴ���������Ժ�������ģ����ô˴�
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
                //myTextBoxNUM_BrakingPotency.Enabled = false;
            }
            else if (comboBox_Braking.SelectedIndex == 1)
            {
                //myTextBoxNUM_BrakingPotency.Enabled = true;
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

    }
}