using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace EET
{
    class SaveFile
    {
        // ���������ĵ�cds
        // cds(configuration dataset)
        // P T C
        public static void ParametersToConfiguration(Form1 fm, string mypath)
        {
            try
            {
                // �����ĵ��Ľṹ
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


                    // ���¸��µĲ����������ĵ�����
                    "<MotorType_Select>" +
                    Form1.gss_MotorType_Select +
                    "</MotorType_Select>" +

                    "<MotorType>" +
                    Form1.gss_MotorType +
                    "</MotorType>" +

                    "<StartStyle>" +
                    Form1.gss_StartStyle +
                    "</StartStyle>" +

                    "<BrakingPotency>" +
                    Form1.gss_BrakingPotency +
                    "</BrakingPotency>" +

                    "<LockedRotorCurrentDrop_Select>" +
                    Form1.gss_LockedRotorCurrentDrop_Select +
                    "</LockedRotorCurrentDrop_Select>" +

                    "<LockedRotorCurrentDrop>" +
                    Form1.gss_LockedRotorCurrentDrop +
                    "</LockedRotorCurrentDrop>" +

                    "<HandBrakeOverrun_Select>" +
                    Form1.gss_HandBrakeOverrun_Select +
                    "</HandBrakeOverrun_Select>" +

                    "<HandBrakeOverrun>" +
                    Form1.gss_HandBrakeOverrun +
                    "</HandBrakeOverrun>" +

                    "<SlideCharge_Select>" +
                    Form1.gss_SlideCharge_Select +
                    "</SlideCharge_Select>" +

                    "<SlideCharge>" +
                    Form1.gss_SlideCharge +
                    "</SlideCharge>" +





                    "</Config>");
                // ���������ĵ�
                cdsxml.Save(mypath);

                // ���������ĵ�Ϊֻ������
                File.SetAttributes(mypath, FileAttributes.ReadOnly);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

/*
 * ���ڱ����ļ��������ļ����Ե�һЩ���ô���
 * ���Ϊ�˱����ļ��У��������أ�Ҳ����αװ�ļ��� 
private void button3_Click(object sender, EventArgs e) 
{  
    FileAttributes MyAttributes = File.GetAttributes(textBox1.Text); 
    File.SetAttributes(textBox1.Text, FileAttributes.Normal);//�����ļ�������Ϊ���� 
    Directory.SetCreationTime(textBox1.Text, dateTimePicker1.Value);//�����ļ��д���ʱ�� 
    Directory.SetLastWriteTime(textBox1.Text, dateTimePicker2.Value);//�����ļ���������޸�ʱ�� 
    Directory.SetLastAccessTime(textBox1.Text, dateTimePicker3.Value);//�����ļ������������ʱ�� 
    if (checkBox1.Checked == true) 
        File.SetAttributes(textBox1.Text, FileAttributes.ReadOnly);//���ó�ֻ���ļ��� 
    FileAttributes MyAttributes = File.GetAttributes(textBox1.Text); 
    if (this.checkBox2.Checked == true) 
        File.SetAttributes(textBox1.Text, MyAttributes | FileAttributes.System);//�������ϵͳ�ļ��� 
    MyAttributes = File.GetAttributes(textBox1.Text); 
    if (this.checkBox3.Checked == true) 
        File.SetAttributes(textBox1.Text, MyAttributes | FileAttributes.Hidden);//������������ļ��� 
    MyAttributes = File.GetAttributes(textBox1.Text); 
    if (this.checkBox4.Checked == true) 
        File.SetAttributes(textBox1.Text, MyAttributes | FileAttributes.Archive);//������ӹ鵵�ļ���
    MessageBox.Show("�����ļ������Բ����ɹ���", "��Ϣ��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information); 
} 
*/
