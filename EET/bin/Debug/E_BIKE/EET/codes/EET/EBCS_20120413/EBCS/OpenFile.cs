using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace EBCS
{
    class OpenFile
    {
        Form1 fm = new Form1();
        // 读取配置文档
        // cds(configuration dataset)
        public static void OpenConfigurationFile(Form1 fm, string mypath)
        {
            try
            {
                // 判断配置文档如果存在则加载配置文档
                if (File.Exists(mypath))
                {
                    // 加载到参数
                    ConfigurationToParameters(mypath);
                    // 加载到界面
                    GenerateParameters.ConfigurationToUI(fm);
                    // 总校验
                    GenerateParameters.ReadBackCheck(fm);
                }
                // 如果配置文档不存在
                else
                {
                    // 删除已存在的文档
                    GenerateParameters.InitParameters(fm);
                    File.Delete(fm.EBCS_openFileDialog.FileName);
                    SaveFile.SaveConfigurationFile(fm, fm.EBCS_openFileDialog.FileName);
                }
            }
            catch (Exception ex)
            {
                // 删除已存在的文档
                GenerateParameters.InitParameters(fm);
                File.Delete(fm.EBCS_openFileDialog.FileName);
                SaveFile.SaveConfigurationFile(fm, fm.EBCS_openFileDialog.FileName);
                MessageBox.Show(ex.Message);
            }
        }



        // 读取值到全局变量
        public static void ConfigurationToParameters(string mypath)
        {
            // 读取XML文档
            XmlDocument cdsxml = new XmlDocument();
            cdsxml.Load(mypath);
            XmlNode configNode = cdsxml.SelectSingleNode("Config");
            // 判断是否含指定结点，如果有结点则读取子节点的值
            if (configNode != null)
            {
                // 全局变量的值
                Form1.gss_MotorSequence = configNode.ChildNodes.Item(0).InnerText.ToString();
                Form1.gss_HallPhaseValue = configNode.ChildNodes.Item(1).InnerText.ToString();
                Form1.gss_SpeedUpperBound = configNode.ChildNodes.Item(2).InnerText.ToString();
                Form1.gss_SpeedLowerBound = configNode.ChildNodes.Item(3).InnerText.ToString();
                Form1.gss_ProtectionUpperBound = configNode.ChildNodes.Item(4).InnerText.ToString();
                Form1.gss_ProtectionLowerBound = configNode.ChildNodes.Item(5).InnerText.ToString();
                Form1.gss_PhaseCurrentPeak = configNode.ChildNodes.Item(6).InnerText.ToString();
                Form1.gss_BatteryType = configNode.ChildNodes.Item(7).InnerText.ToString();
                Form1.gss_BatteryMaximumVoltage = configNode.ChildNodes.Item(8).InnerText.ToString();
                Form1.gss_BatteryMinimumVoltage = configNode.ChildNodes.Item(9).InnerText.ToString();
                Form1.gss_LockedRotorProtectionCurrentValue = configNode.ChildNodes.Item(10).InnerText.ToString();
                Form1.gss_SpeedLimitVoltageDivideCoefficient = configNode.ChildNodes.Item(11).InnerText.ToString();
                Form1.gss_SNLAccelerationSpeed = configNode.ChildNodes.Item(12).InnerText.ToString();
                Form1.gss_SNLHighSpeed = configNode.ChildNodes.Item(13).InnerText.ToString();
                Form1.gss_SNLMidSpeed = configNode.ChildNodes.Item(14).InnerText.ToString();
                Form1.gss_SNLLowSpeed = configNode.ChildNodes.Item(15).InnerText.ToString();
                Form1.gss_SNLAccelerationAmpere = configNode.ChildNodes.Item(16).InnerText.ToString();
                Form1.gss_SNLHighAmpere = configNode.ChildNodes.Item(17).InnerText.ToString();
                Form1.gss_SNLMidAmpere = configNode.ChildNodes.Item(18).InnerText.ToString();
                Form1.gss_SNLLowAmpere = configNode.ChildNodes.Item(19).InnerText.ToString();
                Form1.gss_SLAccelerationSpeed = configNode.ChildNodes.Item(20).InnerText.ToString();
                Form1.gss_SLHighSpeed = configNode.ChildNodes.Item(21).InnerText.ToString();
                Form1.gss_SLMidSpeed = configNode.ChildNodes.Item(22).InnerText.ToString();
                Form1.gss_SLLowSpeed = configNode.ChildNodes.Item(23).InnerText.ToString();
                Form1.gss_SLAccelerationAmpere = configNode.ChildNodes.Item(24).InnerText.ToString();
                Form1.gss_SLHighAmpere = configNode.ChildNodes.Item(25).InnerText.ToString();
                Form1.gss_SLMidAmpere = configNode.ChildNodes.Item(26).InnerText.ToString();
                Form1.gss_SLLowAmpere = configNode.ChildNodes.Item(27).InnerText.ToString();
                Form1.gss_Cruise = configNode.ChildNodes.Item(28).InnerText.ToString();
                Form1.gss_CruiseSwitch = configNode.ChildNodes.Item(29).InnerText.ToString();
                Form1.gss_AutoHoldTime = configNode.ChildNodes.Item(30).InnerText.ToString();
                Form1.gss_ManualHoldTime = configNode.ChildNodes.Item(31).InnerText.ToString();
                Form1.gss_Boost = configNode.ChildNodes.Item(32).InnerText.ToString();
                Form1.gss_ThreeStatusShowSwitch = configNode.ChildNodes.Item(33).InnerText.ToString();
                Form1.gss_SimulationSpeedShow = configNode.ChildNodes.Item(34).InnerText.ToString();
                Form1.gss_SimulationCurrentShow = configNode.ChildNodes.Item(35).InnerText.ToString();
                Form1.gss_Braking = configNode.ChildNodes.Item(36).InnerText.ToString();
                Form1.gss_MoreSpeed = configNode.ChildNodes.Item(37).InnerText.ToString();
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
                // checkBox的checked值
                Form1.gss_SpeedAndAmpereLimit_Select = configNode.ChildNodes.Item(50).InnerText.ToString();
                Form1.gss_Cruise_Select = configNode.ChildNodes.Item(51).InnerText.ToString();
                Form1.gss_CruiseSwitch_Select = configNode.ChildNodes.Item(52).InnerText.ToString();
                Form1.gss_AutoHoldTime_Select = configNode.ChildNodes.Item(53).InnerText.ToString();
                Form1.gss_ManualHoldTime_Select = configNode.ChildNodes.Item(54).InnerText.ToString();
                Form1.gss_Boost_Select = configNode.ChildNodes.Item(55).InnerText.ToString();
                Form1.gss_ThreeStatusShowSwitch_Select = configNode.ChildNodes.Item(56).InnerText.ToString();
                Form1.gss_SimulationSpeedShow_Select = configNode.ChildNodes.Item(57).InnerText.ToString();
                Form1.gss_SimulationCurrentShow_Select = configNode.ChildNodes.Item(58).InnerText.ToString();
                Form1.gss_Braking_Select = configNode.ChildNodes.Item(59).InnerText.ToString();
                Form1.gss_MoreSpeed_Select = configNode.ChildNodes.Item(60).InnerText.ToString();
                // 管
                Form1.gss_Pipe = configNode.ChildNodes.Item(61).InnerText.ToString();
            }
        }
    }
}
