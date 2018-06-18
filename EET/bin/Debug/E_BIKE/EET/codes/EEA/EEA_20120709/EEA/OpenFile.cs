using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace EEA
{
    class OpenFile
    {
        // 读取配置文档
        // cds(configuration dataset)
        public static void OpenConfigurationFile(Form1 fm, string mypath)
        {
            try
            {
                // 判断配置文档如果存在则加载配置文档
                if (File.Exists(mypath))
                {
                    // 加载到参数及数组
                    ConfigurationToParameters(mypath);

                    // 显示软件版本号，硬件版本号，产品型号和文档日期到界面
                    ParametersToUI(fm);

                    // 参数加载到数组
                    ParametersToArray(fm);

                    // 显示文件路径
                    fm.textBox_FileName.Text = mypath;
                }
                // 如果配置文档不存在
                // Do Nothing
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // 读取值到全局变量
        // C T P
        public static void ConfigurationToParameters(string mypath)
        {
            // 读取XML文档
            XmlDocument cdsxml = new XmlDocument();
            cdsxml.Load(mypath);
            XmlNode configNode = cdsxml.SelectSingleNode("Config");
            // 判断是否含指定结点，如果有结点则读取子节点的值
            if (configNode != null && configNode.ChildNodes.Count >= 81)
            {
                // 全局变量的值
                Form1.gss_MotorSequence = configNode.ChildNodes.Item(0).InnerText.ToString();
                Form1.gss_BatteryType = configNode.ChildNodes.Item(7).InnerText.ToString();
                Form1.gss_HallPhaseValue = configNode.ChildNodes.Item(1).InnerText.ToString();
                Form1.gss_HallForwardAngle_1 = configNode.ChildNodes.Item(38).InnerText.ToString();
                Form1.gss_HallForwardAngle_2 = configNode.ChildNodes.Item(39).InnerText.ToString();
                Form1.gss_HallForwardAngle_3 = configNode.ChildNodes.Item(40).InnerText.ToString();
                Form1.gss_HallForwardAngle_4 = configNode.ChildNodes.Item(41).InnerText.ToString();
                Form1.gss_HallForwardAngle_5 = configNode.ChildNodes.Item(42).InnerText.ToString();
                Form1.gss_HallForwardAngle_6 = configNode.ChildNodes.Item(43).InnerText.ToString();
                Form1.gss_HallReverseAngle_1 = configNode.ChildNodes.Item(44).InnerText.ToString();
                Form1.gss_HallReverseAngle_2 = configNode.ChildNodes.Item(45).InnerText.ToString();
                Form1.gss_HallReverseAngle_3 = configNode.ChildNodes.Item(46).InnerText.ToString();
                Form1.gss_HallReverseAngle_4 = configNode.ChildNodes.Item(47).InnerText.ToString();
                Form1.gss_HallReverseAngle_5 = configNode.ChildNodes.Item(48).InnerText.ToString();
                Form1.gss_HallReverseAngle_6 = configNode.ChildNodes.Item(49).InnerText.ToString();


                Form1.gss_SpeedUpperBound = configNode.ChildNodes.Item(2).InnerText.ToString();
                Form1.gss_SpeedLowerBound = configNode.ChildNodes.Item(3).InnerText.ToString();
                Form1.gss_ProtectionUpperBound = configNode.ChildNodes.Item(4).InnerText.ToString();
                Form1.gss_ProtectionLowerBound = configNode.ChildNodes.Item(5).InnerText.ToString();
                Form1.gss_SpeedLimitVoltageDivideCoefficient = configNode.ChildNodes.Item(11).InnerText.ToString();
                Form1.gss_BatteryMaximumVoltage_36V = configNode.ChildNodes.Item(72).InnerText.ToString();
                Form1.gss_BatteryMinimumVoltage_36V = configNode.ChildNodes.Item(73).InnerText.ToString();
                Form1.gss_BatteryMaximumVoltage = configNode.ChildNodes.Item(8).InnerText.ToString();
                Form1.gss_BatteryMinimumVoltage = configNode.ChildNodes.Item(9).InnerText.ToString();
                Form1.gss_PhaseCurrentPeak = configNode.ChildNodes.Item(6).InnerText.ToString();
                Form1.gss_LockedRotorProtectionCurrentValue = configNode.ChildNodes.Item(10).InnerText.ToString();


                Form1.gss_SNLAccelerationSpeed = configNode.ChildNodes.Item(12).InnerText.ToString();
                Form1.gss_SNLHighSpeed = configNode.ChildNodes.Item(13).InnerText.ToString();
                Form1.gss_SNLMidSpeed = configNode.ChildNodes.Item(14).InnerText.ToString();
                Form1.gss_SNLLowSpeed = configNode.ChildNodes.Item(15).InnerText.ToString();
                Form1.gss_SLAccelerationSpeed = configNode.ChildNodes.Item(20).InnerText.ToString();
                Form1.gss_SLHighSpeed = configNode.ChildNodes.Item(21).InnerText.ToString();
                Form1.gss_SLMidSpeed = configNode.ChildNodes.Item(22).InnerText.ToString();
                Form1.gss_SLLowSpeed = configNode.ChildNodes.Item(23).InnerText.ToString();


                Form1.gss_SNLAccelerationAmpere = configNode.ChildNodes.Item(16).InnerText.ToString();
                Form1.gss_SNLHighAmpere = configNode.ChildNodes.Item(17).InnerText.ToString();
                Form1.gss_SNLMidAmpere = configNode.ChildNodes.Item(18).InnerText.ToString();
                Form1.gss_SNLLowAmpere = configNode.ChildNodes.Item(19).InnerText.ToString();
                Form1.gss_SLAccelerationAmpere = configNode.ChildNodes.Item(24).InnerText.ToString();
                Form1.gss_SLHighAmpere = configNode.ChildNodes.Item(25).InnerText.ToString();
                Form1.gss_SLMidAmpere = configNode.ChildNodes.Item(26).InnerText.ToString();
                Form1.gss_SLLowAmpere = configNode.ChildNodes.Item(27).InnerText.ToString();


                Form1.gss_Cruise = configNode.ChildNodes.Item(28).InnerText.ToString();
                Form1.gss_Boost = configNode.ChildNodes.Item(32).InnerText.ToString();
                Form1.gss_CruiseSwitch = configNode.ChildNodes.Item(29).InnerText.ToString();
                Form1.gss_ThreeStatusShowSwitch = configNode.ChildNodes.Item(33).InnerText.ToString();
                Form1.gss_AutoHoldTime = configNode.ChildNodes.Item(30).InnerText.ToString();
                Form1.gss_ManualHoldTime = configNode.ChildNodes.Item(31).InnerText.ToString();
                Form1.gss_Braking = configNode.ChildNodes.Item(36).InnerText.ToString();
                Form1.gss_SimulationSpeedShow = configNode.ChildNodes.Item(34).InnerText.ToString();
                Form1.gss_MoreSpeed = configNode.ChildNodes.Item(37).InnerText.ToString();
                Form1.gss_SimulationCurrentShow = configNode.ChildNodes.Item(35).InnerText.ToString();


                Form1.gss_BrakingPotency = configNode.ChildNodes.Item(65).InnerText.ToString();
                Form1.gss_SlideCharge = configNode.ChildNodes.Item(71).InnerText.ToString();
                Form1.gss_StartStyle = configNode.ChildNodes.Item(64).InnerText.ToString();
                Form1.gss_MotorType = configNode.ChildNodes.Item(63).InnerText.ToString();
                Form1.gss_LockedRotorCurrentDrop = configNode.ChildNodes.Item(67).InnerText.ToString();
                Form1.gss_HandBrakeOverrun = configNode.ChildNodes.Item(69).InnerText.ToString();


                Form1.gss_SoftwareVersion = configNode.ChildNodes.Item(74).InnerText.ToString();
                Form1.gss_HardwareVersion = configNode.ChildNodes.Item(75).InnerText.ToString();
                Form1.gss_ProductModel = configNode.ChildNodes.Item(76).InnerText.ToString();
                if (configNode.ChildNodes.Item(81) != null)
                {
                    Form1.gss_Date = configNode.ChildNodes.Item(81).InnerText.ToString();
                }
            }
            else
            {
                MessageBox.Show("加载文档不完整，请重新选择");
            }
        }

        // 显示软件版本号，硬件版本号，产品型号
        public static void ParametersToUI(Form1 fm)
        {
            // 软件版本号
            fm.textBox_SoftwareVersion.Text = (Convert.ToDouble(Convert.ToInt32(Form1.gss_SoftwareVersion, 16)) / 100).ToString("0.00");
            // 硬件版本号
            fm.textBox_HardwareVersion.Text = Convert.ToInt32(Form1.gss_HardwareVersion, 16).ToString();
            // 产品型号
            fm.textBox_ProductModel.Text = Convert.ToInt32(Form1.gss_ProductModel, 16).ToString();
            // 产品型号
            fm.textBox_Date.Text = Form1.gss_Date;
        }


        // 参数加载到数组
        public static void ParametersToArray(Form1 fm)
        {
            // 参数加载到非加密数组
            Form1.myArray_NotEncryption[0] = Convert.ToByte(Convert.ToInt32(Form1.gss_MotorSequence, 16));
            Form1.myArray_NotEncryption[1] = Convert.ToByte(Convert.ToInt32(Form1.gss_BatteryType, 16));
            Form1.myArray_NotEncryption[2] = Convert.ToByte(Convert.ToInt32(Form1.gss_HallPhaseValue, 16));
            Form1.myArray_NotEncryption[3] = Convert.ToByte(Convert.ToInt32(Form1.gss_HallForwardAngle_1, 16));
            Form1.myArray_NotEncryption[4] = Convert.ToByte(Convert.ToInt32(Form1.gss_HallForwardAngle_2, 16));
            Form1.myArray_NotEncryption[5] = Convert.ToByte(Convert.ToInt32(Form1.gss_HallForwardAngle_3, 16));
            Form1.myArray_NotEncryption[6] = Convert.ToByte(Convert.ToInt32(Form1.gss_HallForwardAngle_4, 16));
            Form1.myArray_NotEncryption[7] = Convert.ToByte(Convert.ToInt32(Form1.gss_HallForwardAngle_5, 16));
            Form1.myArray_NotEncryption[8] = Convert.ToByte(Convert.ToInt32(Form1.gss_HallForwardAngle_6, 16));
            Form1.myArray_NotEncryption[9] = Convert.ToByte(Convert.ToInt32(Form1.gss_HallReverseAngle_1, 16));
            Form1.myArray_NotEncryption[10] = Convert.ToByte(Convert.ToInt32(Form1.gss_HallReverseAngle_2, 16));
            Form1.myArray_NotEncryption[11] = Convert.ToByte(Convert.ToInt32(Form1.gss_HallReverseAngle_3, 16));
            Form1.myArray_NotEncryption[12] = Convert.ToByte(Convert.ToInt32(Form1.gss_HallReverseAngle_4, 16));
            Form1.myArray_NotEncryption[13] = Convert.ToByte(Convert.ToInt32(Form1.gss_HallReverseAngle_5, 16));
            Form1.myArray_NotEncryption[14] = Convert.ToByte(Convert.ToInt32(Form1.gss_HallReverseAngle_6, 16));
            // 填充空白，使用ECOVI中可用的十六进制数 EC
            Form1.myArray_NotEncryption[15] = Convert.ToByte(Convert.ToInt32("EC", 16));
            Form1.myArray_NotEncryption[16] = Convert.ToByte(Convert.ToInt32("EC", 16));


            // 参数加载到加密数组
            Form1.myArray_Encryption[0] = Convert.ToByte(Convert.ToInt32(Form1.gss_SpeedUpperBound, 16));
            Form1.myArray_Encryption[1] = Convert.ToByte(Convert.ToInt32(Form1.gss_SpeedLowerBound, 16));
            Form1.myArray_Encryption[2] = Convert.ToByte(Convert.ToInt32(Form1.gss_ProtectionUpperBound, 16));
            Form1.myArray_Encryption[3] = Convert.ToByte(Convert.ToInt32(Form1.gss_ProtectionLowerBound, 16));
            Form1.myArray_Encryption[4] = Convert.ToByte(Convert.ToInt32(Form1.gss_SpeedLimitVoltageDivideCoefficient, 16));
            Form1.myArray_Encryption[5] = Convert.ToByte(Convert.ToInt32(Form1.gss_BatteryMaximumVoltage_36V, 16));
            Form1.myArray_Encryption[6] = Convert.ToByte(Convert.ToInt32(Form1.gss_BatteryMinimumVoltage_36V, 16));
            Form1.myArray_Encryption[7] = Convert.ToByte(Convert.ToInt32(Form1.gss_BatteryMaximumVoltage, 16));
            Form1.myArray_Encryption[8] = Convert.ToByte(Convert.ToInt32(Form1.gss_BatteryMinimumVoltage, 16));
            Form1.myArray_Encryption[9] = Convert.ToByte(Convert.ToInt32(Form1.gss_PhaseCurrentPeak, 16));
            Form1.myArray_Encryption[10] = Convert.ToByte(Convert.ToInt32(Form1.gss_LockedRotorProtectionCurrentValue, 16));
            Form1.myArray_Encryption[11] = Convert.ToByte(Convert.ToInt32(Form1.gss_SNLAccelerationSpeed, 16));
            Form1.myArray_Encryption[12] = Convert.ToByte(Convert.ToInt32(Form1.gss_SNLHighSpeed, 16));
            Form1.myArray_Encryption[13] = Convert.ToByte(Convert.ToInt32(Form1.gss_SNLMidSpeed, 16));
            Form1.myArray_Encryption[14] = Convert.ToByte(Convert.ToInt32(Form1.gss_SNLLowSpeed, 16));
            Form1.myArray_Encryption[15] = Convert.ToByte(Convert.ToInt32(Form1.gss_SLAccelerationSpeed, 16));
            Form1.myArray_Encryption[16] = Convert.ToByte(Convert.ToInt32(Form1.gss_SLHighSpeed, 16));
            Form1.myArray_Encryption[17] = Convert.ToByte(Convert.ToInt32(Form1.gss_SLMidSpeed, 16));
            Form1.myArray_Encryption[18] = Convert.ToByte(Convert.ToInt32(Form1.gss_SLLowSpeed, 16));
            Form1.myArray_Encryption[19] = Convert.ToByte(Convert.ToInt32(Form1.gss_SNLAccelerationAmpere, 16));
            Form1.myArray_Encryption[20] = Convert.ToByte(Convert.ToInt32(Form1.gss_SNLHighAmpere, 16));
            Form1.myArray_Encryption[21] = Convert.ToByte(Convert.ToInt32(Form1.gss_SNLMidAmpere, 16));
            Form1.myArray_Encryption[22] = Convert.ToByte(Convert.ToInt32(Form1.gss_SNLLowAmpere, 16));
            Form1.myArray_Encryption[23] = Convert.ToByte(Convert.ToInt32(Form1.gss_SLAccelerationAmpere, 16));
            Form1.myArray_Encryption[24] = Convert.ToByte(Convert.ToInt32(Form1.gss_SLHighAmpere, 16));
            Form1.myArray_Encryption[25] = Convert.ToByte(Convert.ToInt32(Form1.gss_SLMidAmpere, 16));
            Form1.myArray_Encryption[26] = Convert.ToByte(Convert.ToInt32(Form1.gss_SLLowAmpere, 16));
            Form1.myArray_Encryption[27] = Convert.ToByte(Convert.ToInt32(Form1.gss_Cruise, 16));
            Form1.myArray_Encryption[28] = Convert.ToByte(Convert.ToInt32(Form1.gss_Boost, 16));
            Form1.myArray_Encryption[29] = Convert.ToByte(Convert.ToInt32(Form1.gss_CruiseSwitch, 16));
            Form1.myArray_Encryption[30] = Convert.ToByte(Convert.ToInt32(Form1.gss_ThreeStatusShowSwitch, 16));
            Form1.myArray_Encryption[31] = Convert.ToByte(Convert.ToInt32(Form1.gss_AutoHoldTime, 16));
            Form1.myArray_Encryption[32] = Convert.ToByte(Convert.ToInt32(Form1.gss_ManualHoldTime, 16));
            Form1.myArray_Encryption[33] = Convert.ToByte(Convert.ToInt32(Form1.gss_Braking, 16));
            Form1.myArray_Encryption[34] = Convert.ToByte(Convert.ToInt32(Form1.gss_SimulationSpeedShow, 16));
            Form1.myArray_Encryption[35] = Convert.ToByte(Convert.ToInt32(Form1.gss_MoreSpeed, 16));
            Form1.myArray_Encryption[36] = Convert.ToByte(Convert.ToInt32(Form1.gss_SimulationCurrentShow, 16));
            Form1.myArray_Encryption[37] = Convert.ToByte(Convert.ToInt32(Form1.gss_BrakingPotency, 16));
            Form1.myArray_Encryption[38] = Convert.ToByte(Convert.ToInt32(Form1.gss_SlideCharge, 16));
            Form1.myArray_Encryption[39] = Convert.ToByte(Convert.ToInt32(Form1.gss_StartStyle, 16));
            Form1.myArray_Encryption[40] = Convert.ToByte(Convert.ToInt32(Form1.gss_MotorType, 16));
            Form1.myArray_Encryption[41] = Convert.ToByte(Convert.ToInt32(Form1.gss_LockedRotorCurrentDrop, 16));
            Form1.myArray_Encryption[42] = Convert.ToByte(Convert.ToInt32(Form1.gss_HandBrakeOverrun, 16));
            // 填充空白，使用ECOVI中可用的十六进制数 EC
            Form1.myArray_Encryption[43] = Convert.ToByte(Convert.ToInt32("EC", 16));
            Form1.myArray_Encryption[44] = Convert.ToByte(Convert.ToInt32("EC", 16));
        }
    }
}
