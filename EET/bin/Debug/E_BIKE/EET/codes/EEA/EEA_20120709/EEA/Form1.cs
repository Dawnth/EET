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

namespace EEA
{
    public partial class Form1 : Form
    {
        #region --������ز���--

        // α���������
        Random rd = new Random();

        // �м���̱���
        byte Temp1 = 0;
        byte Temp2 = 0;
        byte Temp3 = 0;
        byte Temp4 = 0;

        // �ܳ�
        byte Key1 = 0;
        byte Key2 = 0;
        byte Key3 = 0;
        byte Key4 = 0;

        // �������ֶ�У���
        byte CheckSum_NotEncryption = 0;

        // �����ֶ�У���
        byte CheckSum_Encryption = 0;

        // �����ܵ����� ��������15��
        public static byte[] myArray_NotEncryption = new byte[18];

        // ���ܵ������� ��������43��
        public static byte[] myArray_Encryption = new byte[50];

        // �����õ��±�ֵ
        //public static int i = 0;

        #endregion

        #region --��ȡ�ĵ���ز���--

        // g  ����ȫ�ֱ���  global
        // s  ����̬����  static
        // s  �����ַ���    string

        #region --������������--

        // �������ֵ
        public static string gss_MotorSequence = "00";
        // ��ض��ѹ
        public static string gss_BatteryType = "00";
        // ������λ��ֵ
        public static string gss_HallPhaseValue = "00";
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

        #endregion

        #region --����������--

        // ���ٷ�Χ����ֵ
        public static string gss_SpeedUpperBound = "D6";
        // ���ٷ�Χ����ֵ
        public static string gss_SpeedLowerBound = "38";
        // ���ɳ���������ֵ
        public static string gss_ProtectionUpperBound = "E6";
        // ���ɳ���������ֵ
        public static string gss_ProtectionLowerBound = "29";
        // �����߷�ѹϵ��
        public static string gss_SpeedLimitVoltageDivideCoefficient = "11";
        // 36V��ع�ѹֵ
        public static string gss_BatteryMaximumVoltage_36V = "89";
        // 36V���Ƿѹֵ
        public static string gss_BatteryMinimumVoltage_36V = "64";
        // 48V��ع�ѹֵ
        public static string gss_BatteryMaximumVoltage = "B4";
        // 48V���Ƿѹֵ
        public static string gss_BatteryMinimumVoltage = "8E";
        // �������ֵ����
        public static string gss_PhaseCurrentPeak = "9D";
        // ��ת��������ֵ
        public static string gss_LockedRotorProtectionCurrentValue = "68";

        // �������� ������ ����ֵ ����
        public static string gss_SNLAccelerationSpeed = "70";
        // �������� ������ ����ֵ ����
        public static string gss_SNLHighSpeed = "66";
        // �������� ������ ����ֵ ����
        public static string gss_SNLMidSpeed = "50";
        // �������� ������ ����ֵ ����
        public static string gss_SNLLowSpeed = "34";
        // �������� ������ ����ֵ ����
        public static string gss_SLAccelerationSpeed = "44";
        // �������� ������ ����ֵ ����
        public static string gss_SLHighSpeed = "3D";
        // �������� ������ ����ֵ ����
        public static string gss_SLMidSpeed = "30";
        // �������� ������ ����ֵ ����
        public static string gss_SLLowSpeed = "20";

        // �������� ������ ����ֵ ����
        public static string gss_SNLAccelerationAmpere = "9D";
        // �������� ������ ����ֵ ����
        public static string gss_SNLHighAmpere = "8D";
        // �������� ������ ����ֵ ����
        public static string gss_SNLMidAmpere = "78";
        // �������� ������ ����ֵ ����
        public static string gss_SNLLowAmpere = "63";
        // �������� ������ ����ֵ ����
        public static string gss_SLAccelerationAmpere = "73";
        // �������� ������ ����ֵ ����
        public static string gss_SLHighAmpere = "68";
        // �������� ������ ����ֵ ����
        public static string gss_SLMidAmpere = "5D";
        // �������� ������ ����ֵ ����
        public static string gss_SLLowAmpere = "53";

        // Ѳ������
        public static string gss_Cruise = "00";
        // ��������
        public static string gss_Boost = "00";
        // �綯Ѳ������ת��
        public static string gss_CruiseSwitch = "00";
        // ��̬��ʾ
        public static string gss_ThreeStatusShowSwitch = "00";
        // �Զ�Ѳ���ֱ��ȶ�ʱ��
        public static string gss_AutoHoldTime = "50";
        // �ֶ�Ѳ����������ʱ��
        public static string gss_ManualHoldTime = "28";
        // ɲ������
        public static string gss_Braking = "00";
        // ģ���ٶ���ʾ
        public static string gss_SimulationSpeedShow = "0A";
        // ����ʵ��
        public static string gss_MoreSpeed = "00";
        // ģ�������ʾ
        public static string gss_SimulationCurrentShow = "32";

        // ɲ������
        public static string gss_BrakingPotency = "05";
        // ���з����
        public static string gss_SlideCharge = "00";
        // ������ʽ
        public static string gss_StartStyle = "05";
        // ����ͺ�
        public static string gss_MotorType = "00";
        // ��ת����
        public static string gss_LockedRotorCurrentDrop = "00";
        // ����ɲ���ɳ�
        public static string gss_HandBrakeOverrun = "00";

        #endregion

        #region --��ʾʹ��--

        // ����汾��
        public static string gss_SoftwareVersion = "64";
        // Ӳ���汾��
        public static string gss_HardwareVersion = "01";
        // ��Ʒ�ͺ�
        public static string gss_ProductModel = "01";
        // �ĵ�����
        //public static string gss_Date = System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        public static string gss_Date = "";

        #endregion

        #endregion

        #region --��ʼ������--

        public Form1()
        {
            InitializeComponent();
        }

        // �������
        private void Form1_Load(object sender, EventArgs e)
        {
            // �����ܳ�
            EEA_GenerateKeys();

            // ��ֹ���ɰ�ť
            button_Generate.Enabled = false;
        }

        #endregion

        #region --������ع���--

        // �����ܳ�
        private void button_Reset_Click(object sender, EventArgs e)
        {
            // �����ܳ�
            EEA_GenerateKeys();
        }

        internal void EEA_GenerateKeys()
        {
            // �����1��254
            textBox_Key_First.Text = rd.Next(1, 254).ToString("X2");
            // ѭ����ȡ��ֱֵ��������Key_Frist
            while (true)
            {
                textBox_Key_Second.Text = rd.Next(1, 254).ToString("X2");
                if (textBox_Key_Second.Text != textBox_Key_First.Text)
                { break; }
            }
            // ѭ����ȡ��ֱֵ��������Key_Second��Key_Frist
            while (true)
            {
                textBox_Key_Third.Text = rd.Next(1, 254).ToString("X2");
                if (textBox_Key_Third.Text != textBox_Key_Second.Text && textBox_Key_Third.Text != textBox_Key_First.Text)
                { break; }
            }
            // ѭ����ȡ��ֱֵ��������Key_Third��Key_Second��Key_Frist
            while (true)
            {
                textBox_Key_Fourth.Text = rd.Next(1, 254).ToString("X2");
                if (textBox_Key_Fourth.Text != textBox_Key_Third.Text && textBox_Key_Fourth.Text != textBox_Key_Second.Text && textBox_Key_Fourth.Text != textBox_Key_First.Text)
                { break; }
            }
        }

        // �ܳ׼��ص�����������
        internal void EEA_GetKeys()
        {
            // ���ص�����
            Key1 = Convert.ToByte(Convert.ToInt32(textBox_Key_First.Text, 16));
            Key2 = Convert.ToByte(Convert.ToInt32(textBox_Key_Second.Text, 16));
            Key3 = Convert.ToByte(Convert.ToInt32(textBox_Key_Third.Text, 16));
            Key4 = Convert.ToByte(Convert.ToInt32(textBox_Key_Fourth.Text, 16));

            // ���ص�����
            myArray_Encryption[45] = Convert.ToByte(Key4);
            myArray_Encryption[46] = Convert.ToByte(Key3);
            myArray_Encryption[47] = Convert.ToByte(Key2);
            myArray_Encryption[48] = Convert.ToByte(Key1);
        }

        // ͨ���ܳ��������в���
        private void button_Generate_Click(object sender, EventArgs e)
        {
            try
            {
                // ��ֹ����
                this.Enabled = false;

                // �ܳ׼���
                EEA_GetKeys();

                // ���������ص�����
                OpenFile.ParametersToArray(this);

                // �������߷�ѹϵ�����ص�������
                Set_SpeedLimitVoltageDivideCoefficient();

                // �����㷨
                for (int i = 0; i < (myArray_Encryption.Length - 7); i++)
                {
                    EEA_EncryptionAlgorithm(myArray_Encryption[i], i);
                }

                // ����ϴ�ʹ�õ�У���
                CheckSum_NotEncryption = 0;
                CheckSum_Encryption = 0;
                // ����У���
                EEA_CheckSum();

                // ʹ�ܱ��水ť
                button_Save.Enabled = true;

                // �������ɰ�ť
                button_Generate.Enabled = false;

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

        // �����㷨
        private void EEA_EncryptionAlgorithm(byte rawData_String, int myArrayIndex)
        {
            // ����int�ͣ���ֹ���
            int temp_Int32 = 0;

            // �����㷨����
            //�����ļ��е�Դ�룺ԭ����
            //���ܺ�����ģ����ܺ����
            //���ܹ������ݣ�Temp1��Temp2��Temp3��Temp4

            // �������㲽��һ��Temp1 = ԭ���� + Key1
            Temp1 = Convert.ToByte((rawData_String + Key1) % 256);

            // �������㲽�����Temp2 = Temp2ѭ������ ��Key2/8����������
            //Temp2 = Convert.ToByte(((byte)Temp1 << (Key2 % 8)) % 256);
            Temp2 = Convert.ToByte(((Temp1 << (Key2 % 8)) | (Temp1 >> (8 - (Key2 % 8)))) % 256);

            // �������㲽������Temp3 = Temp2 ��� Key3
            Temp3 = Convert.ToByte((Temp2 ^ Key3) % 256);

            // �������㲽���ģ�Temp4 = Temp3�ߵ���λ����
            Temp4 = Convert.ToByte(((Temp3 / 16) + ((Temp3 % 16) * 16)) % 256);

            // �������㲽���壺���ܺ���� = Temp4 �C Key4
            if (Temp4 < Key4)
            {
                temp_Int32 = Temp4 + 256;
                myArray_Encryption[myArrayIndex] = Convert.ToByte((temp_Int32 - Key4) % 256);
            }
            else
            {
                myArray_Encryption[myArrayIndex] = Convert.ToByte((Temp4 - Key4) % 256);
            }
        }

        // У��ͼ���
        private void EEA_CheckSum()
        {
            // ��ʱ����
            int temp_CheckSum_NotEncryption = 0;
            int temp_CheckSum_Encryption = 0;

            // �Ǽ�������У��ͼ���
            // �Ǽ�������У���Ϊ�ۼӺ�
            for (int i = 0; i < (myArray_NotEncryption.Length - 1); i++)
            {
                temp_CheckSum_NotEncryption += myArray_NotEncryption[i];
            }
            // �ۼӺ�
            CheckSum_NotEncryption = Convert.ToByte(temp_CheckSum_NotEncryption % 256);
            myArray_NotEncryption[17] = CheckSum_NotEncryption;

            // ��������У��ͼ���
            // ��������У���Ϊ�ۼӺ�ȡ�����1
            for (int i = 0; i < (myArray_Encryption.Length - 1); i++)
            {
                temp_CheckSum_Encryption += myArray_Encryption[i];
            }
            // ���룬ȡ����һ��byte���൱��256-ԭ����
            CheckSum_Encryption = Convert.ToByte((256 - temp_CheckSum_Encryption % 256) % 256);
            myArray_Encryption[49] = Convert.ToByte(CheckSum_Encryption % 256);
        }

        #endregion

        #region --��ť�¼�--

        // �򿪰�ť�¼�
        private void button_Open_Click(object sender, EventArgs e)
        {
            try
            {
                // ����ʼ��·����Ϊ�գ����ʹ�ù���·��
                if (EEA_openFileDialog.InitialDirectory != "")
                {
                    EEA_openFileDialog.InitialDirectory = EEA_openFileDialog.FileName.Substring(0, EEA_openFileDialog.FileName.LastIndexOf("\\"));
                }
                else
                {
                    EEA_openFileDialog.InitialDirectory = Application.StartupPath;
                }
            }
            catch
            {
                EEA_openFileDialog.InitialDirectory = Application.StartupPath;
            }
            EEA_openFileDialog.ShowDialog();
        }

        // openFileDialog��OK��ť�¼�
        private void EEA_openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            //�������ļ�
            try
            {
                // ��ֹ����
                this.Enabled = false;

                OpenFile.OpenConfigurationFile(this, EEA_openFileDialog.FileName);

                // ʹ�������߷�ѹϵ��
                textBox_SpeedLimitVoltageDivideCoefficient.Enabled = true;
                // ʹ�����ɰ�ť
                button_Generate.Enabled = true;

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

        // ���水ť�¼�
        private void button_Save_Click(object sender, EventArgs e)
        {
            try
            {
                // ����ʼ��·����Ϊ�գ����ʹ�ù���·��
                if (EEA_saveFileDialog.InitialDirectory != "")
                {
                    EEA_saveFileDialog.InitialDirectory = EEA_saveFileDialog.FileName.Substring(0, EEA_saveFileDialog.FileName.LastIndexOf("\\"));
                }
                else
                {
                    EEA_saveFileDialog.InitialDirectory = Application.StartupPath;
                }
            }
            catch
            {
                EEA_saveFileDialog.InitialDirectory = Application.StartupPath;
            }
            EEA_saveFileDialog.FileName = EEA_saveFileDialog.InitialDirectory + "\\" + "EEA_" + System.DateTime.Now.ToString("yyyyMMdd_HHmmss");
            EEA_saveFileDialog.ShowDialog();
        }

        // saveFileDialog��OK��ť�¼�
        private void EEA_saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                // ���浽�ĵ�
                FileStream fs = new FileStream(EEA_saveFileDialog.FileName, FileMode.Create);
                fs.Write(myArray_NotEncryption, 0, myArray_NotEncryption.Length);
                fs.Write(myArray_NotEncryption, 0, myArray_NotEncryption.Length);
                fs.Write(myArray_NotEncryption, 0, myArray_NotEncryption.Length);
                fs.Write(myArray_Encryption, 0, myArray_Encryption.Length);
                fs.Write(myArray_Encryption, 0, myArray_Encryption.Length);
                fs.Write(myArray_Encryption, 0, myArray_Encryption.Length);
                fs.Close(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //
        private void button_SaveFloder_Click(object sender, EventArgs e)
        {
            try
            {
                if (EEA_saveFileDialog.FileName != "")
                {
                    System.Diagnostics.Process.Start("explorer.exe", EEA_saveFileDialog.FileName.Substring(0, EEA_saveFileDialog.FileName.LastIndexOf("\\")));
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

        #endregion


        private void textBox_Key_Fourth_TextChanged(object sender, EventArgs e)
        {
            button_Save.Enabled = false;
            button_Generate.Enabled = true;
        }

        private void textBox_Key_Third_TextChanged(object sender, EventArgs e)
        {
            button_Save.Enabled = false;
            button_Generate.Enabled = true;
        }

        private void textBox_Key_Second_TextChanged(object sender, EventArgs e)
        {
            button_Save.Enabled = false;
            button_Generate.Enabled = true;
        }

        private void textBox_Key_First_TextChanged(object sender, EventArgs e)
        {
            button_Save.Enabled = false;
            button_Generate.Enabled = true;
        }

        private void textBox_SpeedLimitVoltageDivideCoefficient_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(textBox_SpeedLimitVoltageDivideCoefficient.Text) < (1.0))
                {
                    textBox_SpeedLimitVoltageDivideCoefficient.Text = "1.0";
                }
                else if (Convert.ToDouble(textBox_SpeedLimitVoltageDivideCoefficient.Text) > (2.0))
                {
                    textBox_SpeedLimitVoltageDivideCoefficient.Text = "2.0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                textBox_SpeedLimitVoltageDivideCoefficient.Focus();
            }
        }

        // �������߷�ѹϵ�����ص�����
        private void Set_SpeedLimitVoltageDivideCoefficient()
        {
            myArray_Encryption[4] = Convert.ToByte(Convert.ToDouble(textBox_SpeedLimitVoltageDivideCoefficient.Text) * 10);
        }
    }
}