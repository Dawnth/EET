using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EBCS
{
    public partial class Form1 : Form
    {
        #region --��������--

        // g  ����ȫ�ֱ���  global
        // s  ����̬����  static
        // s  �����ַ���    string

        /* �����趨�� */
        // �������ֵ
        public static string gss_MotorSequence = "";
        // ������λ��ֵ
        public static string gss_HallPhaseValue = "";
        // ���ٷ�Χ����ֵ
        public static string gss_SpeedUpperBound = "";
        // ���ٷ�Χ����ֵ
        public static string gss_SpeedLowerBound = "";
        // ���ɳ���������ֵ
        public static string gss_ProtectionUpperBound = "";
        // ���ɳ���������ֵ
        public static string gss_ProtectionLowerBound = "";
        // �������ֵ
        public static string gss_PhaseCurrentPeak = "";
        // �������ֵ
        public static string gss_BatteryType = "";
        // ���Ƿѹֵ
        public static string gss_BatteryMinimumVoltage = "";
        // ��ع�ѹֵ
        public static string gss_BatteryMaximumVoltage = "";
        // ��ת��������ֵ
        public static string gss_LockedRotorProtectionCurrentValue = "";

        /* ����ѡ���� */

        // ��������ѡ��
        public static string gss_SpeedAndAmpereLimit_Select = "";
        // �������� ������ ����ֵ ����
        public static string gss_SNLAccelerationSpeed = "";
        // �������� ������ ����ֵ ����
        public static string gss_SNLHighSpeed = "";
        // �������� ������ ����ֵ ����
        public static string gss_SNLMidSpeed = "";
        // �������� ������ ����ֵ ����
        public static string gss_SNLLowSpeed = "";
        // �������� ������ ����ֵ ����
        public static string gss_SNLAccelerationAmpere = "";
        // �������� ������ ����ֵ ����
        public static string gss_SNLHighAmpere = "";
        // �������� ������ ����ֵ ����
        public static string gss_SNLMidAmpere = "";
        // �������� ������ ����ֵ ����
        public static string gss_SNLLowAmpere = "";
        // �������� ������ ����ֵ ����
        public static string gss_SLAccelerationSpeed = "";
        // �������� ������ ����ֵ ����
        public static string gss_SLHighSpeed = "";
        // �������� ������ ����ֵ ����
        public static string gss_SLMidSpeed = "";
        // �������� ������ ����ֵ ����
        public static string gss_SLLowSpeed = "";
        // �������� ������ ����ֵ ����
        public static string gss_SLAccelerationAmpere = "";
        // �������� ������ ����ֵ ����
        public static string gss_SLHighAmpere = "";
        // �������� ������ ����ֵ ����
        public static string gss_SLMidAmpere = "";
        // �������� ������ ����ֵ ����
        public static string gss_SLLowAmpere = "";

        // Ѳ������ѡ��
        public static string gss_Cruise_Select = "";
        // Ѳ������
        public static string gss_Cruise = "";

        // �綯Ѳ������ת��ѡ��
        public static string gss_CruiseSwitch_Select = "";
        // �綯Ѳ������ת��
        public static string gss_CruiseSwitch = "";

        // �Զ�Ѳ���ֱ��ȶ�ʱ��ѡ��
        public static string gss_AutoHoldTime_Select = "";
        // �Զ�Ѳ���ֱ��ȶ�ʱ��
        public static string gss_AutoHoldTime = "";

        // �ֶ�Ѳ����������ʱ��ѡ��
        public static string gss_ManualHoldTime_Select = "";
        // �ֶ�Ѳ����������ʱ��
        public static string gss_ManualHoldTime = "";

        // ��������ѡ��
        public static string gss_Boost_Select = "";
        // ��������
        public static string gss_Boost = "";

        // ��̬��ʾѡ��
        public static string gss_ThreeStatusShowSwitch_Select = "";
        // ��̬��ʾ
        public static string gss_ThreeStatusShowSwitch = "";

        // ɲ������ѡ��
        public static string gss_Braking_Select = "";
        // ɲ������
        public static string gss_Braking = "";

        // ����ʵ��ѡ��
        public static string gss_MoreSpeed_Select = "";
        // ����ʵ��
        public static string gss_MoreSpeed = "";

        // ģ���ٶ���ʾѡ��
        public static string gss_SimulationSpeedShow_Select = "";
        // ģ���ٶ���ʾ
        public static string gss_SimulationSpeedShow = "";

        // ģ�������ʾѡ��
        public static string gss_SimulationCurrentShow_Select = "";
        // ģ�������ʾ
        public static string gss_SimulationCurrentShow = "";

        /* ���ص��豣����� */
        // ��������1�Ƕ�ֵ
        public static string gss_HallForwardAngle_1 = "";
        // ��������2�Ƕ�ֵ
        public static string gss_HallForwardAngle_2 = "";
        // ��������3�Ƕ�ֵ
        public static string gss_HallForwardAngle_3 = "";
        // ��������4�Ƕ�ֵ
        public static string gss_HallForwardAngle_4 = "";
        // ��������5�Ƕ�ֵ
        public static string gss_HallForwardAngle_5 = "";
        // ��������6�Ƕ�ֵ
        public static string gss_HallForwardAngle_6 = "";
        // �����������1�Ƕ�ֵ
        public static string gss_HallReverseAngle_1 = "";
        // �����������2�Ƕ�ֵ
        public static string gss_HallReverseAngle_2 = "";
        // �����������3�Ƕ�ֵ
        public static string gss_HallReverseAngle_3 = "";
        // �����������4�Ƕ�ֵ
        public static string gss_HallReverseAngle_4 = "";
        // �����������5�Ƕ�ֵ
        public static string gss_HallReverseAngle_5 = "";
        // �����������6�Ƕ�ֵ
        public static string gss_HallReverseAngle_6 = "";
        // �����߷�ѹϵ��
        public static string gss_SpeedLimitVoltageDivideCoefficient = "";

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
            this.MaximizeBox = false;
            // ��һ�������ؼ���ȡ����
            comboBox_MotorSequence.Focus();
            // ���comboBox��Ĭ��ֵ
            comboBox_MotorSequence.Text = comboBox_MotorSequence.Items[0].ToString();
            comboBox_HallPhaseValue.Text = comboBox_HallPhaseValue.Items[0].ToString();
            comboBox_BatteryType.Text = comboBox_BatteryType.Items[0].ToString();
            comboBox_Cruise.Text = comboBox_Cruise.Items[0].ToString();
            comboBox_CruiseSwitch.Text = comboBox_CruiseSwitch.Items[0].ToString();
            comboBox_ThreeStatusShowSwitch.Text = comboBox_ThreeStatusShowSwitch.Items[0].ToString();
            comboBox_Braking.Text = comboBox_Braking.Items[0].ToString();
            comboBox_Boost.Text = comboBox_Boost.Items[0].ToString();
        }

        #endregion


        // �������õ�Ŀ��
        private void DownLoad_button_Click(object sender, EventArgs e)
        {
            toolStripProgressBar1.Visible = true;
            // ����ProgressBar
            for (; toolStripProgressBar1.Value < 100; )//ѭ��
            {
                // ��ͣ1��
                System.Threading.Thread.Sleep(20);
                // �ý���������һ��
                toolStripProgressBar1.Value += toolStripProgressBar1.Step;
                // ��������������˳�ѭ������ս�����
                if (toolStripProgressBar1.Value >= 100)
                {
                    System.Threading.Thread.Sleep(1000);
                    toolStripProgressBar1.Visible = false;
                    toolStripProgressBar1.Value = 0;
                    break;
                }
            }
        }

        // ���صĿ��塰�����߷�ѹϵ������˫������ȫѡ�¼� 
        private void myTextBoxNUM_SpeedLimitVoltageDivideCoefficient_Lable_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // ˫����ʾ�����֣������߷�ѹϵ��
            myTextBoxNUM_SpeedLimitVoltageDivideCoefficient_Lable.Text = "�����߷�ѹϵ��";
            // ѡ����������
            myTextBoxNUM_SpeedLimitVoltageDivideCoefficient_Lable.SelectAll();
            // ʹ�����ص��������
            myTextBoxNUM_SpeedLimitVoltageDivideCoefficient.Enabled = true;
        }

        // �������в���
        private void button1_Click(object sender, EventArgs e)
        {
        }

        // ����
        private void toolStripButton_About_Click(object sender, EventArgs e)
        {
            About EBCS_About = new About();
            EBCS_About.ShowDialog();
        }

        //#region --������ֵ--

        // 
        private void myTextBoxNUM_SpeedLowerBound_TextChanged(object sender, EventArgs e)
        {
            gss_SpeedLowerBound = myTextBoxNUM_SpeedLowerBound.Text;
        }

        //#endregion

        //#region --������Χ--

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
            gss_SpeedUpperBound = Convert.ToInt32(Convert.ToDouble(myTextBoxNUM_SpeedUpperBound.Text) * 255 / 5).ToString();
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
            try
            {
                if (Convert.ToDouble(myTextBoxNUM_PhaseCurrentPeak.Text) < (6))
                {
                    myTextBoxNUM_PhaseCurrentPeak.Text = "6";
                }
                else if (Convert.ToDouble(myTextBoxNUM_PhaseCurrentPeak.Text) > (80))
                {
                    myTextBoxNUM_PhaseCurrentPeak.Text = "80";
                }
            }
            catch (Exception)
            {
                myTextBoxNUM_PhaseCurrentPeak.Text = "20";
            }
        }

        // ��ع�ѹ����ֵ
        private void myTextBoxNUM_BatteryMaximumVoltage_Leave(object sender, EventArgs e)
        {
            // 48V���
            if (comboBox_BatteryType.SelectedIndex == 0)
            {
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_BatteryMaximumVoltage.Text) < (48))
                    {
                        myTextBoxNUM_BatteryMaximumVoltage.Text = "48";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_BatteryMaximumVoltage.Text) > (56))
                    {
                        myTextBoxNUM_BatteryMaximumVoltage.Text = "56";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_BatteryMaximumVoltage.Text = "54";
                }
            }
            // 36V���
            else if (comboBox_BatteryType.SelectedIndex == 1)
            {
                try
                {
                    if (Convert.ToDouble(myTextBoxNUM_BatteryMaximumVoltage.Text) < (36))
                    {
                        myTextBoxNUM_BatteryMaximumVoltage.Text = "36";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_BatteryMaximumVoltage.Text) > (42))
                    {
                        myTextBoxNUM_BatteryMaximumVoltage.Text = "42";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_BatteryMaximumVoltage.Text = "41";
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
                        myTextBoxNUM_BatteryMinimumVoltage.Text = "42";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_BatteryMinimumVoltage.Text) > (48))
                    {
                        myTextBoxNUM_BatteryMinimumVoltage.Text = "48";
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
                        myTextBoxNUM_BatteryMinimumVoltage.Text = "28";
                    }
                    else if (Convert.ToDouble(myTextBoxNUM_BatteryMinimumVoltage.Text) > (36))
                    {
                        myTextBoxNUM_BatteryMinimumVoltage.Text = "36";
                    }
                }
                catch (Exception)
                {
                    myTextBoxNUM_BatteryMinimumVoltage.Text = "30";
                }
            }
        }

        // ���������
        private void comboBox_MotorSequence_SelectedIndexChanged(object sender, EventArgs e)
        {
            gss_MotorSequence = comboBox_MotorSequence.SelectedIndex.ToString();
        }

        // ������� Select
        private void comboBox_HallPhaseValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            gss_HallPhaseValue = comboBox_HallPhaseValue.SelectedIndex.ToString();
        }

        // ������� Select
        private void comboBox_BatteryType_SelectedIndexChanged(object sender, EventArgs e)
        {
            gss_BatteryType = comboBox_BatteryType.SelectedIndex.ToString();
        }

        // ��ת��������
        private void myTextBoxNUM_LockedRotorProtectionCurrentValue_Leave(object sender, EventArgs e)
        {

        }


        
        //#endregion
    }
}