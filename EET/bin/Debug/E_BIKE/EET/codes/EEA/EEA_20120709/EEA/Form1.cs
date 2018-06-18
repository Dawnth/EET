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
        #region --加密相关参数--

        // 伪随机数变量
        Random rd = new Random();

        // 中间过程变量
        byte Temp1 = 0;
        byte Temp2 = 0;
        byte Temp3 = 0;
        byte Temp4 = 0;

        // 密匙
        byte Key1 = 0;
        byte Key2 = 0;
        byte Key3 = 0;
        byte Key4 = 0;

        // 不加密字段校验和
        byte CheckSum_NotEncryption = 0;

        // 加密字段校验和
        byte CheckSum_Encryption = 0;

        // 不加密的数组 其中数据15个
        public static byte[] myArray_NotEncryption = new byte[18];

        // 加密的是数组 其中数据43个
        public static byte[] myArray_Encryption = new byte[50];

        // 数组用的下标值
        //public static int i = 0;

        #endregion

        #region --读取文档相关参数--

        // g  代表全局变量  global
        // s  代表静态变量  static
        // s  代表字符串    string

        #region --不加密数据区--

        // 电机相序值
        public static string gss_MotorSequence = "00";
        // 电池额定电压
        public static string gss_BatteryType = "00";
        // 霍尔相位差值
        public static string gss_HallPhaseValue = "00";
        // 霍尔边沿1角度值
        public static string gss_HallForwardAngle_1 = "00";
        // 霍尔边沿2角度值
        public static string gss_HallForwardAngle_2 = "00";
        // 霍尔边沿3角度值
        public static string gss_HallForwardAngle_3 = "00";
        // 霍尔边沿4角度值
        public static string gss_HallForwardAngle_4 = "00";
        // 霍尔边沿5角度值
        public static string gss_HallForwardAngle_5 = "00";
        // 霍尔边沿6角度值
        public static string gss_HallForwardAngle_6 = "00";
        // 霍尔反向边沿1角度值
        public static string gss_HallReverseAngle_1 = "00";
        // 霍尔反向边沿2角度值
        public static string gss_HallReverseAngle_2 = "00";
        // 霍尔反向边沿3角度值
        public static string gss_HallReverseAngle_3 = "00";
        // 霍尔反向边沿4角度值
        public static string gss_HallReverseAngle_4 = "00";
        // 霍尔反向边沿5角度值
        public static string gss_HallReverseAngle_5 = "00";
        // 霍尔反向边沿6角度值
        public static string gss_HallReverseAngle_6 = "00";

        #endregion

        #region --加密数据区--

        // 调速范围上限值
        public static string gss_SpeedUpperBound = "D6";
        // 调速范围下限值
        public static string gss_SpeedLowerBound = "38";
        // 防飞车保护上限值
        public static string gss_ProtectionUpperBound = "E6";
        // 防飞车保护下限值
        public static string gss_ProtectionLowerBound = "29";
        // 限速线分压系数
        public static string gss_SpeedLimitVoltageDivideCoefficient = "11";
        // 36V电池过压值
        public static string gss_BatteryMaximumVoltage_36V = "89";
        // 36V电池欠压值
        public static string gss_BatteryMinimumVoltage_36V = "64";
        // 48V电池过压值
        public static string gss_BatteryMaximumVoltage = "B4";
        // 48V电池欠压值
        public static string gss_BatteryMinimumVoltage = "8E";
        // 相电流峰值限制
        public static string gss_PhaseCurrentPeak = "9D";
        // 堵转保护电流值
        public static string gss_LockedRotorProtectionCurrentValue = "68";

        // 限速限流 无限速 限速值 提速
        public static string gss_SNLAccelerationSpeed = "70";
        // 限速限流 无限速 限速值 高速
        public static string gss_SNLHighSpeed = "66";
        // 限速限流 无限速 限速值 中速
        public static string gss_SNLMidSpeed = "50";
        // 限速限流 无限速 限速值 低速
        public static string gss_SNLLowSpeed = "34";
        // 限速限流 有限速 限速值 提速
        public static string gss_SLAccelerationSpeed = "44";
        // 限速限流 有限速 限速值 高速
        public static string gss_SLHighSpeed = "3D";
        // 限速限流 有限速 限速值 中速
        public static string gss_SLMidSpeed = "30";
        // 限速限流 有限速 限速值 低速
        public static string gss_SLLowSpeed = "20";

        // 限速限流 无限速 限流值 提速
        public static string gss_SNLAccelerationAmpere = "9D";
        // 限速限流 无限速 限流值 高速
        public static string gss_SNLHighAmpere = "8D";
        // 限速限流 无限速 限流值 中速
        public static string gss_SNLMidAmpere = "78";
        // 限速限流 无限速 限流值 低速
        public static string gss_SNLLowAmpere = "63";
        // 限速限流 有限速 限流值 提速
        public static string gss_SLAccelerationAmpere = "73";
        // 限速限流 有限速 限流值 高速
        public static string gss_SLHighAmpere = "68";
        // 限速限流 有限速 限流值 中速
        public static string gss_SLMidAmpere = "5D";
        // 限速限流 有限速 限流值 低速
        public static string gss_SLLowAmpere = "53";

        // 巡航功能
        public static string gss_Cruise = "00";
        // 助力功能
        public static string gss_Boost = "00";
        // 电动巡航助力转换
        public static string gss_CruiseSwitch = "00";
        // 三态显示
        public static string gss_ThreeStatusShowSwitch = "00";
        // 自动巡航手柄稳定时间
        public static string gss_AutoHoldTime = "50";
        // 手动巡航按键保持时间
        public static string gss_ManualHoldTime = "28";
        // 刹车功能
        public static string gss_Braking = "00";
        // 模拟速度显示
        public static string gss_SimulationSpeedShow = "0A";
        // 多速实现
        public static string gss_MoreSpeed = "00";
        // 模拟电流显示
        public static string gss_SimulationCurrentShow = "32";

        // 刹车力度
        public static string gss_BrakingPotency = "05";
        // 滑行反充电
        public static string gss_SlideCharge = "00";
        // 启动方式
        public static string gss_StartStyle = "05";
        // 电机型号
        public static string gss_MotorType = "00";
        // 堵转降流
        public static string gss_LockedRotorCurrentDrop = "00";
        // 松手刹防飞车
        public static string gss_HandBrakeOverrun = "00";

        #endregion

        #region --显示使用--

        // 软件版本号
        public static string gss_SoftwareVersion = "64";
        // 硬件版本号
        public static string gss_HardwareVersion = "01";
        // 产品型号
        public static string gss_ProductModel = "01";
        // 文档日期
        //public static string gss_Date = System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        public static string gss_Date = "";

        #endregion

        #endregion

        #region --初始化加载--

        public Form1()
        {
            InitializeComponent();
        }

        // 窗体加载
        private void Form1_Load(object sender, EventArgs e)
        {
            // 生成密匙
            EEA_GenerateKeys();

            // 禁止生成按钮
            button_Generate.Enabled = false;
        }

        #endregion

        #region --加密相关过程--

        // 重置密匙
        private void button_Reset_Click(object sender, EventArgs e)
        {
            // 生成密匙
            EEA_GenerateKeys();
        }

        internal void EEA_GenerateKeys()
        {
            // 随机数1到254
            textBox_Key_First.Text = rd.Next(1, 254).ToString("X2");
            // 循环获取数值直到不等于Key_Frist
            while (true)
            {
                textBox_Key_Second.Text = rd.Next(1, 254).ToString("X2");
                if (textBox_Key_Second.Text != textBox_Key_First.Text)
                { break; }
            }
            // 循环获取数值直到不等于Key_Second与Key_Frist
            while (true)
            {
                textBox_Key_Third.Text = rd.Next(1, 254).ToString("X2");
                if (textBox_Key_Third.Text != textBox_Key_Second.Text && textBox_Key_Third.Text != textBox_Key_First.Text)
                { break; }
            }
            // 循环获取数值直到不等于Key_Third、Key_Second和Key_Frist
            while (true)
            {
                textBox_Key_Fourth.Text = rd.Next(1, 254).ToString("X2");
                if (textBox_Key_Fourth.Text != textBox_Key_Third.Text && textBox_Key_Fourth.Text != textBox_Key_Second.Text && textBox_Key_Fourth.Text != textBox_Key_First.Text)
                { break; }
            }
        }

        // 密匙加载到变量及数组
        internal void EEA_GetKeys()
        {
            // 加载到变量
            Key1 = Convert.ToByte(Convert.ToInt32(textBox_Key_First.Text, 16));
            Key2 = Convert.ToByte(Convert.ToInt32(textBox_Key_Second.Text, 16));
            Key3 = Convert.ToByte(Convert.ToInt32(textBox_Key_Third.Text, 16));
            Key4 = Convert.ToByte(Convert.ToInt32(textBox_Key_Fourth.Text, 16));

            // 加载到数组
            myArray_Encryption[45] = Convert.ToByte(Key4);
            myArray_Encryption[46] = Convert.ToByte(Key3);
            myArray_Encryption[47] = Convert.ToByte(Key2);
            myArray_Encryption[48] = Convert.ToByte(Key1);
        }

        // 通过密匙生成所有参数
        private void button_Generate_Click(object sender, EventArgs e)
        {
            try
            {
                // 禁止界面
                this.Enabled = false;

                // 密匙加载
                EEA_GetKeys();

                // 将参数加载到数组
                OpenFile.ParametersToArray(this);

                // 将限速线分压系数加载到数组中
                Set_SpeedLimitVoltageDivideCoefficient();

                // 加密算法
                for (int i = 0; i < (myArray_Encryption.Length - 7); i++)
                {
                    EEA_EncryptionAlgorithm(myArray_Encryption[i], i);
                }

                // 清除上次使用的校验和
                CheckSum_NotEncryption = 0;
                CheckSum_Encryption = 0;
                // 生成校验和
                EEA_CheckSum();

                // 使能保存按钮
                button_Save.Enabled = true;

                // 禁用生成按钮
                button_Generate.Enabled = false;

                // 使能界面
                this.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // 使能界面
                this.Enabled = true;
            }
        }

        // 加密算法
        private void EEA_EncryptionAlgorithm(byte rawData_String, int myArrayIndex)
        {
            // 定义int型，防止溢出
            int temp_Int32 = 0;

            // 加密算法流程
            //配置文件中的源码：原参数
            //加密后的密文：加密后参数
            //加密过程数据：Temp1、Temp2、Temp3、Temp4

            // 加密运算步骤一：Temp1 = 原参数 + Key1
            Temp1 = Convert.ToByte((rawData_String + Key1) % 256);

            // 加密运算步骤二：Temp2 = Temp2循环左移 （Key2/8的余数）次
            //Temp2 = Convert.ToByte(((byte)Temp1 << (Key2 % 8)) % 256);
            Temp2 = Convert.ToByte(((Temp1 << (Key2 % 8)) | (Temp1 >> (8 - (Key2 % 8)))) % 256);

            // 加密运算步骤三：Temp3 = Temp2 异或 Key3
            Temp3 = Convert.ToByte((Temp2 ^ Key3) % 256);

            // 加密运算步骤四：Temp4 = Temp3高低四位互换
            Temp4 = Convert.ToByte(((Temp3 / 16) + ((Temp3 % 16) * 16)) % 256);

            // 加密运算步骤五：加密后参数 = Temp4 – Key4
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

        // 校验和计算
        private void EEA_CheckSum()
        {
            // 临时变量
            int temp_CheckSum_NotEncryption = 0;
            int temp_CheckSum_Encryption = 0;

            // 非加密数组校验和计算
            // 非加密数组校验和为累加和
            for (int i = 0; i < (myArray_NotEncryption.Length - 1); i++)
            {
                temp_CheckSum_NotEncryption += myArray_NotEncryption[i];
            }
            // 累加和
            CheckSum_NotEncryption = Convert.ToByte(temp_CheckSum_NotEncryption % 256);
            myArray_NotEncryption[17] = CheckSum_NotEncryption;

            // 加密数组校验和计算
            // 加密数组校验和为累加和取反后加1
            for (int i = 0; i < (myArray_Encryption.Length - 1); i++)
            {
                temp_CheckSum_Encryption += myArray_Encryption[i];
            }
            // 求补码，取反加一，byte的相当于256-原数据
            CheckSum_Encryption = Convert.ToByte((256 - temp_CheckSum_Encryption % 256) % 256);
            myArray_Encryption[49] = Convert.ToByte(CheckSum_Encryption % 256);
        }

        #endregion

        #region --按钮事件--

        // 打开按钮事件
        private void button_Open_Click(object sender, EventArgs e)
        {
            try
            {
                // 若初始化路径不为空，则打开使用过的路径
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

        // openFileDialog的OK按钮事件
        private void EEA_openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            //打开配置文件
            try
            {
                // 禁止界面
                this.Enabled = false;

                OpenFile.OpenConfigurationFile(this, EEA_openFileDialog.FileName);

                // 使能限速线分压系数
                textBox_SpeedLimitVoltageDivideCoefficient.Enabled = true;
                // 使能生成按钮
                button_Generate.Enabled = true;

                // 使能界面
                this.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // 使能界面
                this.Enabled = true;
            }
        }

        // 保存按钮事件
        private void button_Save_Click(object sender, EventArgs e)
        {
            try
            {
                // 若初始化路径不为空，则打开使用过的路径
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

        // saveFileDialog的OK按钮事件
        private void EEA_saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                // 保存到文档
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

        // 将限速线分压系数加载到数组
        private void Set_SpeedLimitVoltageDivideCoefficient()
        {
            myArray_Encryption[4] = Convert.ToByte(Convert.ToDouble(textBox_SpeedLimitVoltageDivideCoefficient.Text) * 10);
        }
    }
}