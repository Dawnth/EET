using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace EBCS
{
    class SaveFile
    {
        // 生成配置文档cds
        // cds(configuration dataset)
        public static void SaveConfigurationFile(Form1 fm, string mypath)
        {
            try
            {
                // 配置文档的结构
                XmlDocument cdsxml = new XmlDocument();
                cdsxml.LoadXml(
                    "<Config>" +

                    "<MotorSequence>" +
                    Form1.gss_MotorSequence +
                    "</MotorSequence>" +

                    "<HallPhaseValue>" +
                    Form1.gss_HallPhaseValue +
                    "</HallPhaseValue>" +

                    "<SpeedUpperBound>" +
                    Form1.gss_SpeedUpperBound +
                    "</SpeedUpperBound>" +

                    "<SpeedLowerBound>" +
                    Form1.gss_SpeedLowerBound +
                    "</SpeedLowerBound>" +

                    "<ProtectionUpperBound>" +
                    Form1.gss_ProtectionUpperBound +
                    "</ProtectionUpperBound>" +

                    "<ProtectionLowerBound>" +
                    Form1.gss_ProtectionLowerBound +
                    "</ProtectionLowerBound>" +

                    "<PhaseCurrentPeak>" +
                    Form1.gss_PhaseCurrentPeak +
                    "</PhaseCurrentPeak>" +

                    "<BatteryType>" +
                    Form1.gss_BatteryType +
                    "</BatteryType>" +

                    "<BatteryMaximumVoltage>" +
                    Form1.gss_BatteryMaximumVoltage +
                    "</BatteryMaximumVoltage>" +

                    "<BatteryMinimumVoltage>" +
                    Form1.gss_BatteryMinimumVoltage +
                    "</BatteryMinimumVoltage>" +

                    "<LockedRotorProtectionCurrentValue>" +
                    Form1.gss_LockedRotorProtectionCurrentValue +
                    "</LockedRotorProtectionCurrentValue>" +

                    "<SpeedLimitVoltageDivideCoefficient>" +
                    Form1.gss_SpeedLimitVoltageDivideCoefficient +
                    "</SpeedLimitVoltageDivideCoefficient>" +

                    "<SNLAccelerationSpeed>" +
                    Form1.gss_SNLAccelerationSpeed +
                    "</SNLAccelerationSpeed>" +

                    "<SNLHighSpeed>" +
                    Form1.gss_SNLHighSpeed +
                    "</SNLHighSpeed>" +

                    "<SNLMidSpeed>" +
                    Form1.gss_SNLMidSpeed +
                    "</SNLMidSpeed>" +

                    "<SNLLowSpeed>" +
                    Form1.gss_SNLLowSpeed +
                    "</SNLLowSpeed>" +

                    "<SNLAccelerationAmpere>" +
                    Form1.gss_SNLAccelerationAmpere +
                    "</SNLAccelerationAmpere>" +

                    "<SNLHighAmpere>" +
                    Form1.gss_SNLHighAmpere +
                    "</SNLHighAmpere>" +

                    "<SNLMidAmpere>" +
                    Form1.gss_SNLMidAmpere +
                    "</SNLMidAmpere>" +

                    "<SNLLowAmpere>" +
                    Form1.gss_SNLLowAmpere +
                    "</SNLLowAmpere>" +

                    "<SLAccelerationSpeed>" +
                    Form1.gss_SLAccelerationSpeed +
                    "</SLAccelerationSpeed>" +

                    "<SLHighSpeed>" +
                    Form1.gss_SLHighSpeed +
                    "</SLHighSpeed>" +

                    "<SLMidSpeed>" +
                    Form1.gss_SLMidSpeed +
                    "</SLMidSpeed>" +

                    "<SLLowSpeed>" +
                    Form1.gss_SLLowSpeed +
                    "</SLLowSpeed>" +

                    "<SLAccelerationAmpere>" +
                    Form1.gss_SLAccelerationAmpere +
                    "</SLAccelerationAmpere>" +

                    "<SLHighAmpere>" +
                    Form1.gss_SLHighAmpere +
                    "</SLHighAmpere>" +

                    "<SLMidAmpere>" +
                    Form1.gss_SLMidAmpere +
                    "</SLMidAmpere>" +

                    "<SLLowAmpere>" +
                    Form1.gss_SLLowAmpere +
                    "</SLLowAmpere>" +

                    "<Cruise>" +
                    Form1.gss_Cruise +
                    "</Cruise>" +

                    "<CruiseSwitch>" +
                    Form1.gss_CruiseSwitch +
                    "</CruiseSwitch>" +

                    "<AutoHoldTime>" +
                    Form1.gss_AutoHoldTime +
                    "</AutoHoldTime>" +

                    "<ManualHoldTime>" +
                    Form1.gss_ManualHoldTime +
                    "</ManualHoldTime>" +

                    "<Boost>" +
                    Form1.gss_Boost +
                    "</Boost>" +

                    "<ThreeStatusShowSwitch>" +
                    Form1.gss_ThreeStatusShowSwitch +
                    "</ThreeStatusShowSwitch>" +

                    "<SimulationSpeedShow>" +
                    Form1.gss_SimulationSpeedShow +
                    "</SimulationSpeedShow>" +

                    "<SimulationCurrentShow>" +
                    Form1.gss_SimulationCurrentShow +
                    "</SimulationCurrentShow>" +

                    "<Braking>" +
                    Form1.gss_Braking +
                    "</Braking>" +

                    "<MoreSpeed>" +
                    Form1.gss_MoreSpeed +
                    "</MoreSpeed>" +

                    "<HallForwardAngle_1>" +
                    Form1.gss_HallForwardAngle_1 +
                    "</HallForwardAngle_1>" +

                    "<HallForwardAngle_2>" +
                    Form1.gss_HallForwardAngle_2 +
                    "</HallForwardAngle_2>" +

                    "<HallForwardAngle_3>" +
                    Form1.gss_HallForwardAngle_3 +
                    "</HallForwardAngle_3>" +

                    "<HallForwardAngle_4>" +
                    Form1.gss_HallForwardAngle_4 +
                    "</HallForwardAngle_4>" +

                    "<HallForwardAngle_5>" +
                    Form1.gss_HallForwardAngle_5 +
                    "</HallForwardAngle_5>" +

                    "<HallForwardAngle_6>" +
                    Form1.gss_HallForwardAngle_6 +
                    "</HallForwardAngle_6>" +

                    "<HallReverseAngle_1>" +
                    Form1.gss_HallReverseAngle_1 +
                    "</HallReverseAngle_1>" +

                    "<HallReverseAngle_2>" +
                    Form1.gss_HallReverseAngle_2 +
                    "</HallReverseAngle_2>" +

                    "<HallReverseAngle_3>" +
                    Form1.gss_HallReverseAngle_3 +
                    "</HallReverseAngle_3>" +

                    "<HallReverseAngle_4>" +
                    Form1.gss_HallReverseAngle_4 +
                    "</HallReverseAngle_4>" +

                    "<HallReverseAngle_5>" +
                    Form1.gss_HallReverseAngle_5 +
                    "</HallReverseAngle_5>" +

                    "<HallReverseAngle_6>" +
                    Form1.gss_HallReverseAngle_6 +
                    "</HallReverseAngle_6>" +

                    "<SpeedAndAmpereLimit_Select>" +
                    Form1.gss_SpeedAndAmpereLimit_Select +
                    "</SpeedAndAmpereLimit_Select>" +

                    "<Cruise_Select>" +
                    Form1.gss_Cruise_Select +
                    "</Cruise_Select>" +

                    "<CruiseSwitch_Select>" +
                    Form1.gss_CruiseSwitch_Select +
                    "</CruiseSwitch_Select>" +

                    "<AutoHoldTime_Select>" +
                    Form1.gss_AutoHoldTime_Select +
                    "</AutoHoldTime_Select>" +

                    "<ManualHoldTime_Select>" +
                    Form1.gss_ManualHoldTime_Select +
                    "</ManualHoldTime_Select>" +

                    "<Boost_Select>" +
                    Form1.gss_Boost_Select +
                    "</Boost_Select>" +

                    "<ThreeStatusShowSwitch_Select>" +
                    Form1.gss_ThreeStatusShowSwitch_Select +
                    "</ThreeStatusShowSwitch_Select>" +

                    "<SimulationSpeedShow_Select>" +
                    Form1.gss_SimulationSpeedShow_Select +
                    "</SimulationSpeedShow_Select>" +

                    "<SimulationCurrentShow_Select>" +
                    Form1.gss_SimulationCurrentShow_Select +
                    "</SimulationCurrentShow_Select>" +

                    "<Braking_Select>" +
                    Form1.gss_Braking_Select +
                    "</Braking_Select>" +

                    "<MoreSpeed_Select>" +
                    Form1.gss_MoreSpeed_Select +
                    "</MoreSpeed_Select>" +

                    "<Pipe>" +
                    Form1.gss_Pipe +
                    "</Pipe>" +

                    "</Config>");
                // 保存配置文档
                cdsxml.Save(mypath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
