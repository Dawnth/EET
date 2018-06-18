using System;
using System.Collections.Generic;
using System.Text;

namespace EET
{
    class GenerateParameters
    {
        // ��ʼ��ȫ�ֱ���
        // �˷�����ʼ��ȫ�ֱ���
        // I P
        public static void InitParameters(Form1 fm)
        {
            // �������ֵ
            Form1.gss_MotorSequence = "00";
            // ������λ��ֵ
            Form1.gss_HallPhaseValue = "00";
            // ���ٷ�Χ����ֵ
            Form1.gss_SpeedUpperBound = "D6";
            // ���ٷ�Χ����ֵ
            Form1.gss_SpeedLowerBound = "38";
            // ���ɳ���������ֵ
            Form1.gss_ProtectionUpperBound = "E6";
            // ���ɳ���������ֵ
            Form1.gss_ProtectionLowerBound = "29";
            // �������ֵ
            Form1.gss_PhaseCurrentPeak = "9D";
            // ��ض��ѹ
            Form1.gss_BatteryType = "00";
            // ��ع�ѹֵ
            Form1.gss_BatteryMaximumVoltage = "B4";
            // ���Ƿѹֵ
            Form1.gss_BatteryMinimumVoltage = "8E";
            // ��ת��������ֵ
            Form1.gss_LockedRotorProtectionCurrentValue = "68";
            // �����߷�ѹϵ��
            Form1.gss_SpeedLimitVoltageDivideCoefficient = "11";

            // ��������ѡ��
            Form1.gss_SpeedAndAmpereLimit_Select = "false";
            // �������� ������ ����ֵ ����
            Form1.gss_SNLAccelerationSpeed = "70";
            // �������� ������ ����ֵ ����
            Form1.gss_SNLHighSpeed = "66";
            // �������� ������ ����ֵ ����
            Form1.gss_SNLMidSpeed = "50";
            // �������� ������ ����ֵ ����
            Form1.gss_SNLLowSpeed = "34";
            // �������� ������ ����ֵ ����
            Form1.gss_SNLAccelerationAmpere = "9D";
            // �������� ������ ����ֵ ����
            Form1.gss_SNLHighAmpere = "8D";
            // �������� ������ ����ֵ ����
            Form1.gss_SNLMidAmpere = "78";
            // �������� ������ ����ֵ ����
            Form1.gss_SNLLowAmpere = "63";
            // �������� ������ ����ֵ ����
            Form1.gss_SLAccelerationSpeed = "44";
            // �������� ������ ����ֵ ����
            Form1.gss_SLHighSpeed = "3D";
            // �������� ������ ����ֵ ����
            Form1.gss_SLMidSpeed = "30";
            // �������� ������ ����ֵ ����
            Form1.gss_SLLowSpeed = "20";
            // �������� ������ ����ֵ ����
            Form1.gss_SLAccelerationAmpere = "73";
            // �������� ������ ����ֵ ����
            Form1.gss_SLHighAmpere = "68";
            // �������� ������ ����ֵ ����
            Form1.gss_SLMidAmpere = "5D";
            // �������� ������ ����ֵ ����
            Form1.gss_SLLowAmpere = "53";

            // Ѳ������ѡ��
            Form1.gss_Cruise_Select = "false";
            // Ѳ������
            Form1.gss_Cruise = "00";

            // �綯Ѳ������ת��ѡ��
            Form1.gss_CruiseSwitch_Select = "false";
            // �綯Ѳ������ת��
            Form1.gss_CruiseSwitch = "00";

            // �Զ�Ѳ���ֱ��ȶ�ʱ��ѡ��
            Form1.gss_AutoHoldTime_Select = "false";
            // �Զ�Ѳ���ֱ��ȶ�ʱ��
            Form1.gss_AutoHoldTime = "50";

            // �ֶ�Ѳ����������ʱ��ѡ��
            Form1.gss_ManualHoldTime_Select = "false";
            // �ֶ�Ѳ����������ʱ��
            Form1.gss_ManualHoldTime = "28";

            // ��������ѡ��
            Form1.gss_Boost_Select = "false";
            // ��������
            Form1.gss_Boost = "00";

            // ��̬��ʾѡ��
            Form1.gss_ThreeStatusShowSwitch_Select = "false";
            // ��̬��ʾ
            Form1.gss_ThreeStatusShowSwitch = "00";

            // ģ���ٶ���ʾѡ��
            Form1.gss_SimulationSpeedShow_Select = "false";
            // ģ���ٶ���ʾ
            Form1.gss_SimulationSpeedShow = "0A";

            // ģ�������ʾѡ��
            Form1.gss_SimulationCurrentShow_Select = "false";
            // ģ�������ʾ
            Form1.gss_SimulationCurrentShow = "32";

            // ɲ������ѡ��
            Form1.gss_Braking_Select = "false";
            // ɲ������
            Form1.gss_Braking = "00";

            // ����ʵ��ѡ��
            Form1.gss_MoreSpeed_Select = "false";
            // ����ʵ��
            Form1.gss_MoreSpeed = "00";

            // ��������1�Ƕ�ֵ
            Form1.gss_HallForwardAngle_1 = "00";
            // ��������2�Ƕ�ֵ
            Form1.gss_HallForwardAngle_2 = "00";
            // ��������3�Ƕ�ֵ
            Form1.gss_HallForwardAngle_3 = "00";
            // ��������4�Ƕ�ֵ
            Form1.gss_HallForwardAngle_4 = "00";
            // ��������5�Ƕ�ֵ
            Form1.gss_HallForwardAngle_5 = "00";
            // ��������6�Ƕ�ֵ
            Form1.gss_HallForwardAngle_6 = "00";
            // �����������1�Ƕ�ֵ
            Form1.gss_HallReverseAngle_1 = "00";
            // �����������2�Ƕ�ֵ
            Form1.gss_HallReverseAngle_2 = "00";
            // �����������3�Ƕ�ֵ
            Form1.gss_HallReverseAngle_3 = "00";
            // �����������4�Ƕ�ֵ
            Form1.gss_HallReverseAngle_4 = "00";
            // �����������5�Ƕ�ֵ
            Form1.gss_HallReverseAngle_5 = "00";
            // �����������6�Ƕ�ֵ
            Form1.gss_HallReverseAngle_6 = "00";
            // ��
            Form1.gss_Pipe = "00";

            // ���¸��µĲ����������ĵ�����

            // ����ͺ�
            Form1.gss_MotorType_Select = "false";
            Form1.gss_MotorType = "00";
            // ������ʽ
            Form1.gss_StartStyle = "05";
            // ɲ������
            Form1.gss_BrakingPotency = "05";
            // ��ת����
            Form1.gss_LockedRotorCurrentDrop_Select = "false";
            Form1.gss_LockedRotorCurrentDrop = "00";
            // ����ɲ���ɳ�
            Form1.gss_HandBrakeOverrun_Select = "false";
            Form1.gss_HandBrakeOverrun = "00";
            // ���з����
            Form1.gss_SlideCharge_Select = "false";
            Form1.gss_SlideCharge = "00";

            // 36V��ع�ѹֵ
            Form1.gss_BatteryMaximumVoltage_36V = "89";
            // 36V���Ƿѹֵ
            Form1.gss_BatteryMinimumVoltage_36V = "64";

            // ����汾��
            Form1.gss_SoftwareVersion = "64";
            // Ӳ���汾��
            Form1.gss_HardwareVersion = "01";
            // ��Ʒ�ͺ�
            Form1.gss_ProductModel = "01";
            // �������
            Form1.gss_MotorSeries = "08";
            // ��������
            Form1.gss_SamePolarity = "00";
            // �����������¶�
            Form1.gss_ProtectionTemperature = "64";
            // ��������
            Form1.gss_Hall = "00";
        }

        // ����ȫ�ֱ���
        // �˷���ͨ����ʽ����ȫ�ֱ���
        // U T P
        public static void UIToParameters(Form1 fm)
        {
            ///
            /// �����趨��
            ///
            // �������ֵ
            Form1.gss_MotorSequence = fm.comboBox_MotorSequence.SelectedIndex.ToString("X2");
            // �������
            Form1.gss_HallPhaseValue = fm.comboBox_HallPhaseValue.SelectedIndex.ToString("X2");
            // ���ٷ�Χ����ֵ=�ֱ������ѹ��д��ֵ����λV����ȷ��С����һλ�� �� 255 / 5 
            Form1.gss_SpeedUpperBound = Convert.ToInt32(Convert.ToDouble(fm.myTextBoxNUM_SpeedUpperBound.Text) * 255 / 5).ToString("X2");
            // ���ٷ�Χ����ֵ=�ֱ������ѹ��д��ֵ����λV����ȷ��С����һλ�� �� 255 / 5 
            Form1.gss_SpeedLowerBound = Convert.ToInt32(Convert.ToDouble(fm.myTextBoxNUM_SpeedLowerBound.Text) * 255 / 5).ToString("X2");
            // ���ɳ���������ֵ=�ֱ������ѹ��д��ֵ����λV����ȷ��С����һλ�� �� 255 / 5 
            Form1.gss_ProtectionUpperBound = Convert.ToInt32(Convert.ToDouble(fm.myTextBoxNUM_ProtectionUpperBound.Text) * 255 / 5).ToString("X2");
            // ���ɳ���������ֵ=�ֱ������ѹ��д��ֵ����λV����ȷ��С����һλ�� �� 255 / 5 
            Form1.gss_ProtectionLowerBound = Convert.ToInt32(Convert.ToDouble(fm.myTextBoxNUM_ProtectionLowerBound.Text) * 255 / 5).ToString("X2");
            // ��ض��ѹ
            Form1.gss_BatteryType = fm.comboBox_BatteryType.SelectedIndex.ToString("X2");
            // 48V���
            if (fm.comboBox_BatteryType.SelectedIndex == 0)
            {
                // ��ع�ѹֵ=BusVolt��д��ֵ�� �� 0.0653 �� 255 / 5
                Form1.gss_BatteryMaximumVoltage = Convert.ToInt32(Convert.ToDouble(fm.myTextBoxNUM_BatteryMaximumVoltage.Text) * 0.0653 * 255 / 5).ToString("X2");
                // ���Ƿѹֵ=BusVolt��д��ֵ�� �� 0.0653 �� 255 / 5
                Form1.gss_BatteryMinimumVoltage = Convert.ToInt32(Convert.ToDouble(fm.myTextBoxNUM_BatteryMinimumVoltage.Text) * 0.0653 * 255 / 5).ToString("X2");
            }
            // 36V���
            else
            { 
                // ��ع�ѹֵ=BusVolt��д��ֵ�� �� 0.0653 �� 255 / 5
                Form1.gss_BatteryMaximumVoltage_36V = Convert.ToInt32(Convert.ToDouble(fm.myTextBoxNUM_BatteryMaximumVoltage.Text) * 0.0653 * 255 / 5).ToString("X2");
                // ���Ƿѹֵ=BusVolt��д��ֵ�� �� 0.0653 �� 255 / 5
                Form1.gss_BatteryMinimumVoltage_36V = Convert.ToInt32(Convert.ToDouble(fm.myTextBoxNUM_BatteryMinimumVoltage.Text) * 0.0653 * 255 / 5).ToString("X2");
            }
            // �����߷�ѹϵ��=д��ֵ �� 10
            Form1.gss_SpeedLimitVoltageDivideCoefficient = "11";

            ///
            /// ����ѡ����
            ///
            // �������� ������ ����ֵ ����=д��ֵ / 4
            Form1.gss_SNLAccelerationSpeed = Convert.ToInt32(Convert.ToDouble(fm.myTextBoxNUM_SNLAccelerationSpeed.Text) / 4).ToString("X2");
            // �������� ������ ����ֵ ����=д��ֵ / 4
            Form1.gss_SNLHighSpeed = Convert.ToInt32(Convert.ToDouble(fm.myTextBoxNUM_SNLHighSpeed.Text) / 4).ToString("X2");
            // �������� ������ ����ֵ ����=д��ֵ / 4
            Form1.gss_SNLMidSpeed = Convert.ToInt32(Convert.ToDouble(fm.myTextBoxNUM_SNLMidSpeed.Text) / 4).ToString("X2");
            // �������� ������ ����ֵ ����=д��ֵ / 4
            Form1.gss_SNLLowSpeed = Convert.ToInt32(Convert.ToDouble(fm.myTextBoxNUM_SNLLowSpeed.Text) / 4).ToString("X2");
            // �������� ������ ����ֵ ����=д��ֵ / 4
            Form1.gss_SLAccelerationSpeed = Convert.ToInt32(Convert.ToDouble(fm.myTextBoxNUM_SLAccelerationSpeed.Text) / 4).ToString("X2");
            // �������� ������ ����ֵ ����=д��ֵ / 4
            Form1.gss_SLHighSpeed = Convert.ToInt32(Convert.ToDouble(fm.myTextBoxNUM_SLHighSpeed.Text) / 4).ToString("X2");
            // �������� ������ ����ֵ ����=д��ֵ / 4
            Form1.gss_SLMidSpeed = Convert.ToInt32(Convert.ToDouble(fm.myTextBoxNUM_SLMidSpeed.Text) / 4).ToString("X2");
            // �������� ������ ����ֵ ����=д��ֵ / 4
            Form1.gss_SLLowSpeed = Convert.ToInt32(Convert.ToDouble(fm.myTextBoxNUM_SLLowSpeed.Text) / 4).ToString("X2");
            // Ѳ������
            Form1.gss_Cruise = fm.comboBox_Cruise.SelectedIndex.ToString("X2");
            // �綯Ѳ������ת��
            Form1.gss_CruiseSwitch = fm.comboBox_CruiseSwitch.SelectedIndex.ToString("X2");
            // �Զ�Ѳ���ֱ��ȶ�ʱ��=д��ֵ �� 10
            Form1.gss_AutoHoldTime = Convert.ToInt32(Convert.ToDouble(fm.myTextBoxNUM_AutoHoldTime.Text) * 10).ToString("X2");
            // �ֶ�Ѳ����������ʱ��=д��ֵ �� 20
            Form1.gss_ManualHoldTime = Convert.ToInt32(Convert.ToDouble(fm.myTextBoxNUM_ManualHoldTime.Text) * 20).ToString("X2");
            // ��������
            Form1.gss_Boost = fm.comboBox_Boost.SelectedIndex.ToString("X2");
            // ��̬��ʾ
            Form1.gss_ThreeStatusShowSwitch = fm.comboBox_ThreeStatusShowSwitch.SelectedIndex.ToString("X2");
            // ģ���ٶ���ʾ=д��ֵ �� 10
            Form1.gss_SimulationSpeedShow = Convert.ToInt32(Convert.ToDouble(fm.myTextBoxNUM_SimulationSpeedShow.Text) * 10).ToString("X2");
            // ģ�������ʾ=д��ֵ �� 10
            Form1.gss_SimulationCurrentShow = Convert.ToInt32(Convert.ToDouble(fm.myTextBoxNUM_SimulationCurrentShow.Text) * 10).ToString("X2");
            // ɲ������
            Form1.gss_Braking = fm.comboBox_Braking.SelectedIndex.ToString("X2");
            // ����ʵ��
            Form1.gss_MoreSpeed = fm.comboBox_MoreSpeed.SelectedIndex.ToString("X2");

            // CheckBox��ѡ��ģʽ��¼
            // ��������ѡ��
            Form1.gss_SpeedAndAmpereLimit_Select = fm.checkBox_SpeedAndAmpereLimit_Select.Checked.ToString();
            // Ѳ������ѡ��
            Form1.gss_Cruise_Select = fm.checkBox_Cruise_Select.Checked.ToString();
            // �綯Ѳ������ת��ѡ��
            Form1.gss_CruiseSwitch_Select = fm.checkBox_CruiseSwitch_Select.Checked.ToString();
            // �Զ�Ѳ���ֱ��ȶ�ʱ��ѡ��
            Form1.gss_AutoHoldTime_Select = fm.checkBox_AutoHoldTime_Select.Checked.ToString();
            // �ֶ�Ѳ����������ʱ��ѡ��
            Form1.gss_ManualHoldTime_Select = fm.checkBox_ManualHoldTime_Select.Checked.ToString();
            // ��������ѡ��
            Form1.gss_Boost_Select = fm.checkBox_Boost_Select.Checked.ToString();
            // ��̬��ʾѡ��
            Form1.gss_ThreeStatusShowSwitch_Select = fm.checkBox_ThreeStatusShowSwitch_Select.Checked.ToString();
            // ģ���ٶ���ʾѡ��
            Form1.gss_SimulationSpeedShow_Select = fm.checkBox_SimulationSpeedShow_Select.Checked.ToString();
            // ģ�������ʾѡ��
            Form1.gss_SimulationCurrentShow_Select = fm.checkBox_SimulationCurrentShow_Select.Checked.ToString();
            // ɲ������ѡ��
            Form1.gss_Braking_Select = fm.checkBox_Braking_Select.Checked.ToString();
            // ����ʵ��ѡ��
            Form1.gss_MoreSpeed_Select = fm.checkBox_MoreSpeed_Select.Checked.ToString();

            // ��
            Form1.gss_Pipe = fm.comboBox_Pipe.SelectedIndex.ToString("X2");
            // 6��
            if (fm.comboBox_Pipe.SelectedIndex == 0)
            {
                // �������ֵ=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                Form1.gss_PhaseCurrentPeak = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_PhaseCurrentPeak.Text) * 0.104) * 255 / 5).ToString("X2");
                // ��ת��������ֵ=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                Form1.gss_LockedRotorProtectionCurrentValue = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_LockedRotorProtectionCurrentValue.Text) * 0.104) * 255 / 5).ToString("X2");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                Form1.gss_SNLAccelerationAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SNLAccelerationAmpere.Text) * 0.104) * 255 / 5).ToString("X2");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                Form1.gss_SNLHighAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SNLHighAmpere.Text) * 0.104) * 255 / 5).ToString("X2");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                Form1.gss_SNLMidAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SNLMidAmpere.Text) * 0.104) * 255 / 5).ToString("X2");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                Form1.gss_SNLLowAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SNLLowAmpere.Text) * 0.104) * 255 / 5).ToString("X2");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                Form1.gss_SLAccelerationAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SLAccelerationAmpere.Text) * 0.104) * 255 / 5).ToString("X2");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                Form1.gss_SLHighAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SLHighAmpere.Text) * 0.104) * 255 / 5).ToString("X2");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                Form1.gss_SLMidAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SLMidAmpere.Text) * 0.104) * 255 / 5).ToString("X2");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                Form1.gss_SLLowAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SLLowAmpere.Text) * 0.104) * 255 / 5).ToString("X2");
            }
            // 9��
            else if (fm.comboBox_Pipe.SelectedIndex == 1)
            {
                // �������ֵ=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                Form1.gss_PhaseCurrentPeak = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_PhaseCurrentPeak.Text) * 0.104) * 255 / 5).ToString("X2");
                // ��ת��������ֵ=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                Form1.gss_LockedRotorProtectionCurrentValue = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_LockedRotorProtectionCurrentValue.Text) * 0.104) * 255 / 5).ToString("X2");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                Form1.gss_SNLAccelerationAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SNLAccelerationAmpere.Text) * 0.104) * 255 / 5).ToString("X2");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                Form1.gss_SNLHighAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SNLHighAmpere.Text) * 0.104) * 255 / 5).ToString("X2");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                Form1.gss_SNLMidAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SNLMidAmpere.Text) * 0.104) * 255 / 5).ToString("X2");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                Form1.gss_SNLLowAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SNLLowAmpere.Text) * 0.104) * 255 / 5).ToString("X2");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                Form1.gss_SLAccelerationAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SLAccelerationAmpere.Text) * 0.104) * 255 / 5).ToString("X2");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                Form1.gss_SLHighAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SLHighAmpere.Text) * 0.104) * 255 / 5).ToString("X2");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                Form1.gss_SLMidAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SLMidAmpere.Text) * 0.104) * 255 / 5).ToString("X2");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                Form1.gss_SLLowAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SLLowAmpere.Text) * 0.104) * 255 / 5).ToString("X2");
            }
            // 12��
            else if (fm.comboBox_Pipe.SelectedIndex == 2)
            {
                // �������ֵ=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                Form1.gss_PhaseCurrentPeak = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_PhaseCurrentPeak.Text) * 0.104) * 255 / 5).ToString("X2");
                // ��ת��������ֵ=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                Form1.gss_LockedRotorProtectionCurrentValue = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_LockedRotorProtectionCurrentValue.Text) * 0.104) * 255 / 5).ToString("X2");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                Form1.gss_SNLAccelerationAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SNLAccelerationAmpere.Text) * 0.104) * 255 / 5).ToString("X2");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                Form1.gss_SNLHighAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SNLHighAmpere.Text) * 0.104) * 255 / 5).ToString("X2");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                Form1.gss_SNLMidAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SNLMidAmpere.Text) * 0.104) * 255 / 5).ToString("X2");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                Form1.gss_SNLLowAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SNLLowAmpere.Text) * 0.104) * 255 / 5).ToString("X2");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                Form1.gss_SLAccelerationAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SLAccelerationAmpere.Text) * 0.104) * 255 / 5).ToString("X2");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                Form1.gss_SLHighAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SLHighAmpere.Text) * 0.104) * 255 / 5).ToString("X2");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                Form1.gss_SLMidAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SLMidAmpere.Text) * 0.104) * 255 / 5).ToString("X2");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                Form1.gss_SLLowAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SLLowAmpere.Text) * 0.104) * 255 / 5).ToString("X2");
            }

            // ���¸��µĲ����������ĵ�����
            // ����ͺ�
            Form1.gss_MotorType_Select = fm.checkBox_MotorType_Select.Checked.ToString();
            Form1.gss_MotorType = fm.comboBox_MotorType.SelectedIndex.ToString("X2");
            // ������ʽ
            Form1.gss_StartStyle = fm.trackBar_StartStyle.Value.ToString("X2");
            // ɲ������
            Form1.gss_BrakingPotency = fm.trackBar_BrakingPotency.Value.ToString("X2");
            // ��ת����
            Form1.gss_LockedRotorCurrentDrop_Select = fm.checkBox_LockedRotorCurrentDrop_Select.Checked.ToString();
            Form1.gss_LockedRotorCurrentDrop = fm.comboBox_LockedRotorCurrentDrop.SelectedIndex.ToString("X2");
            // ����ɲ���ɳ�
            Form1.gss_HandBrakeOverrun_Select = fm.checkBox_HandBrakeOverrun_Select.Checked.ToString();
            Form1.gss_HandBrakeOverrun = fm.comboBox_HandBrakeOverrun.SelectedIndex.ToString("X2");
            // ���з����
            Form1.gss_SlideCharge_Select = fm.checkBox_SlideCharge_Select.Checked.ToString();
            Form1.gss_SlideCharge = fm.comboBox_SlideCharge.SelectedIndex.ToString("X2");

            // ����汾��
            Form1.gss_SoftwareVersion = Convert.ToInt32(Convert.ToDouble(fm.myTextBoxNUM_SoftwareVersion.Text) * 100).ToString("X2");
            // Ӳ���汾��
            Form1.gss_HardwareVersion = Convert.ToInt32(fm.myTextBoxNUM_HardwareVersion.Text).ToString("X2");
            // ��Ʒ�ͺ�
            Form1.gss_ProductModel = Convert.ToInt32(fm.myTextBoxNUM_ProductModel.Text).ToString("X2");
            // �������
            Form1.gss_MotorSeries = Convert.ToInt32(fm.myTextBoxNUM_MotorSeries.Text).ToString("X2");
            // ��������
            if (fm.myTextBoxNUM_SamePolarity.Text == "����")
            {
                Form1.gss_SamePolarity = "00";
            }
            else if (fm.myTextBoxNUM_SamePolarity.Text == "����")
            {
                Form1.gss_SamePolarity = "01";
            }
            // �����������¶�
            Form1.gss_ProtectionTemperature = Convert.ToInt32(fm.myTextBoxNUM_ProtectionTemperature.Text).ToString("X2");
            // ��������
            Form1.gss_Hall = fm.comboBox_Hall.SelectedIndex.ToString("X2"); 
        }

        // ����д��ֵ
        // �˷���ͨ����ʽ����д��ֵ
        // P T U
        public static void ParametersToUI(Form1 fm)
        {
            //
            // �����趨��
            //
            // �������ֵ
            if (Convert.ToInt32(Form1.gss_MotorSequence, 16) < fm.comboBox_MotorSequence.Items.Count)
            {
                fm.comboBox_MotorSequence.Text = fm.comboBox_MotorSequence.Items[Convert.ToInt32(Form1.gss_MotorSequence, 16)].ToString();
            }
            // �������
            if (Convert.ToInt32(Form1.gss_HallPhaseValue, 16) < fm.comboBox_HallPhaseValue.Items.Count)
            {
                fm.comboBox_HallPhaseValue.Text = fm.comboBox_HallPhaseValue.Items[Convert.ToInt32(Form1.gss_HallPhaseValue, 16)].ToString();
            }
            // ���ٷ�Χ����ֵ=�ֱ������ѹ��д��ֵ����λV����ȷ��С����һλ�� �� 255 / 5 
            fm.myTextBoxNUM_SpeedUpperBound.Text = (Convert.ToDouble(Convert.ToInt32(Form1.gss_SpeedUpperBound, 16)) * 5 / 255).ToString("0.0");
            // ���ٷ�Χ����ֵ=�ֱ������ѹ��д��ֵ����λV����ȷ��С����һλ�� �� 255 / 5 
            fm.myTextBoxNUM_SpeedLowerBound.Text = (Convert.ToDouble(Convert.ToInt32(Form1.gss_SpeedLowerBound,16)) * 5 / 255).ToString("0.0");
            // ���ɳ���������ֵ=�ֱ������ѹ��д��ֵ����λV����ȷ��С����һλ�� �� 255 / 5 
            fm.myTextBoxNUM_ProtectionUpperBound.Text = (Convert.ToDouble(Convert.ToInt32(Form1.gss_ProtectionUpperBound,16)) * 5 / 255).ToString("0.0");
            // ���ɳ���������ֵ=�ֱ������ѹ��д��ֵ����λV����ȷ��С����һλ�� �� 255 / 5 
            fm.myTextBoxNUM_ProtectionLowerBound.Text = (Convert.ToDouble(Convert.ToInt32(Form1.gss_ProtectionLowerBound,16)) * 5 / 255).ToString("0.0");
            // ��ض��ѹ
            if (Convert.ToInt32(Form1.gss_BatteryType, 16) < fm.comboBox_BatteryType.Items.Count)
            {
                fm.comboBox_BatteryType.Text = fm.comboBox_BatteryType.Items[Convert.ToInt32(Form1.gss_BatteryType, 16)].ToString();
            }
            // 48v���
            if (fm.comboBox_BatteryType.SelectedIndex == 0)
            {
                // ��ع�ѹֵ=BusVolt��д��ֵ�� �� 0.0653 �� 255 / 5
                fm.myTextBoxNUM_BatteryMaximumVoltage.Text = (Convert.ToDouble(Convert.ToInt32(Form1.gss_BatteryMaximumVoltage,16)) * 5 / 255 / 0.0653).ToString("0.0");
                // ���Ƿѹֵ=BusVolt��д��ֵ�� �� 0.0653 �� 255 / 5
                fm.myTextBoxNUM_BatteryMinimumVoltage.Text = (Convert.ToDouble(Convert.ToInt32(Form1.gss_BatteryMinimumVoltage,16)) * 5 / 255 / 0.0653).ToString("0.0");
            }
            // 36V���
            else
            {
                // ��ع�ѹֵ=BusVolt��д��ֵ�� �� 0.0653 �� 255 / 5
                fm.myTextBoxNUM_BatteryMaximumVoltage.Text = (Convert.ToDouble(Convert.ToInt32(Form1.gss_BatteryMaximumVoltage_36V,16)) * 5 / 255 / 0.0653).ToString("0.0");
                // ���Ƿѹֵ=BusVolt��д��ֵ�� �� 0.0653 �� 255 / 5
                fm.myTextBoxNUM_BatteryMinimumVoltage.Text = (Convert.ToDouble(Convert.ToInt32(Form1.gss_BatteryMinimumVoltage_36V,16)) * 5 / 255 / 0.0653).ToString("0.0");
            }
            // �����߷�ѹϵ��=д��ֵ �� 10
            // �˴��Ѿ�ȡ������
            //fm.myTextBoxNUM_SpeedLimitVoltageDivideCoefficient.Text = (Convert.ToDouble(Form1.gss_SpeedLimitVoltageDivideCoefficient) / 10).ToString("0.0");

            //
            // ����ѡ����
            //
            // �������� ������ ����ֵ ����=д��ֵ / 4
            fm.myTextBoxNUM_SNLAccelerationSpeed.Text = (Convert.ToDouble(Convert.ToInt32(Form1.gss_SNLAccelerationSpeed,16)) * 4).ToString("0");
            // �������� ������ ����ֵ ����=д��ֵ / 4
            fm.myTextBoxNUM_SNLHighSpeed.Text = (Convert.ToDouble(Convert.ToInt32(Form1.gss_SNLHighSpeed,16)) * 4).ToString("0");
            // �������� ������ ����ֵ ����=д��ֵ / 4
            fm.myTextBoxNUM_SNLMidSpeed.Text = (Convert.ToDouble(Convert.ToInt32(Form1.gss_SNLMidSpeed,16)) * 4).ToString("0");
            // �������� ������ ����ֵ ����=д��ֵ / 4
            fm.myTextBoxNUM_SNLLowSpeed.Text = (Convert.ToDouble(Convert.ToInt32(Form1.gss_SNLLowSpeed,16)) * 4).ToString("0");
            // �������� ������ ����ֵ ����=д��ֵ / 4
            fm.myTextBoxNUM_SLAccelerationSpeed.Text = (Convert.ToDouble(Convert.ToInt32(Form1.gss_SLAccelerationSpeed,16)) * 4).ToString("0");
            // �������� ������ ����ֵ ����=д��ֵ / 4
            fm.myTextBoxNUM_SLHighSpeed.Text = (Convert.ToDouble(Convert.ToInt32(Form1.gss_SLHighSpeed,16)) * 4).ToString("0");
            // �������� ������ ����ֵ ����=д��ֵ / 4
            fm.myTextBoxNUM_SLMidSpeed.Text = (Convert.ToDouble(Convert.ToInt32(Form1.gss_SLMidSpeed,16)) * 4).ToString("0");
            // �������� ������ ����ֵ ����=д��ֵ / 4
            fm.myTextBoxNUM_SLLowSpeed.Text = (Convert.ToDouble(Convert.ToInt32(Form1.gss_SLLowSpeed,16)) * 4).ToString("0");
            // Ѳ������
            if (Convert.ToInt32(Form1.gss_Cruise, 16) < fm.comboBox_Cruise.Items.Count)
            {
                fm.comboBox_Cruise.Text = fm.comboBox_Cruise.Items[Convert.ToInt32(Form1.gss_Cruise, 16)].ToString();
            }
            // �綯Ѳ������ת��
            if (Convert.ToInt32(Form1.gss_CruiseSwitch, 16) < fm.comboBox_CruiseSwitch.Items.Count)
            {
                fm.comboBox_CruiseSwitch.Text = fm.comboBox_CruiseSwitch.Items[Convert.ToInt32(Form1.gss_CruiseSwitch, 16)].ToString();
            }
            // �Զ�Ѳ���ֱ��ȶ�ʱ��=д��ֵ �� 10
            fm.myTextBoxNUM_AutoHoldTime.Text = (Convert.ToDouble(Convert.ToInt32(Form1.gss_AutoHoldTime,16)) / 10).ToString("0");
            // �ֶ�Ѳ����������ʱ��=д��ֵ �� 20
            fm.myTextBoxNUM_ManualHoldTime.Text = (Convert.ToDouble(Convert.ToInt32(Form1.gss_ManualHoldTime,16)) / 20).ToString("0");
            // ��������
            if (Convert.ToInt32(Form1.gss_Boost, 16) < fm.comboBox_Boost.Items.Count)
            {
                fm.comboBox_Boost.Text = fm.comboBox_Boost.Items[Convert.ToInt32(Form1.gss_Boost, 16)].ToString();
            }
            // ��̬��ʾ
            if (Convert.ToInt32(Form1.gss_ThreeStatusShowSwitch, 16) < fm.comboBox_ThreeStatusShowSwitch.Items.Count)
            {
                fm.comboBox_ThreeStatusShowSwitch.Text = fm.comboBox_ThreeStatusShowSwitch.Items[Convert.ToInt32(Form1.gss_ThreeStatusShowSwitch, 16)].ToString();
            }
            // ģ���ٶ���ʾ=д��ֵ �� 10
            fm.myTextBoxNUM_SimulationSpeedShow.Text = (Convert.ToDouble(Convert.ToInt32(Form1.gss_SimulationSpeedShow,16)) / 10).ToString("0.0");
            // ģ�������ʾ=д��ֵ �� 10
            fm.myTextBoxNUM_SimulationCurrentShow.Text = (Convert.ToDouble(Convert.ToInt32(Form1.gss_SimulationCurrentShow,16)) / 10).ToString("0.0");
            // ɲ������
            if (Convert.ToInt32(Form1.gss_Braking, 16) < fm.comboBox_Braking.Items.Count)
            {
                fm.comboBox_Braking.Text = fm.comboBox_Braking.Items[Convert.ToInt32(Form1.gss_Braking, 16)].ToString();
            }
            // ����ʵ��
            if (Convert.ToInt32(Form1.gss_MoreSpeed, 16) < fm.comboBox_MoreSpeed.Items.Count)
            {
                fm.comboBox_MoreSpeed.Text = fm.comboBox_MoreSpeed.Items[Convert.ToInt32(Form1.gss_MoreSpeed, 16)].ToString();
            }

            // CheckBox��ѡ��ģʽ��¼
            // ��������ѡ��
            fm.checkBox_SpeedAndAmpereLimit_Select.Checked = Convert.ToBoolean(Form1.gss_SpeedAndAmpereLimit_Select);
            // Ѳ������ѡ��
            fm.checkBox_Cruise_Select.Checked = Convert.ToBoolean(Form1.gss_Cruise_Select);
            // �綯Ѳ������ת��ѡ��
            fm.checkBox_CruiseSwitch_Select.Checked = Convert.ToBoolean(Form1.gss_CruiseSwitch_Select);
            // �Զ�Ѳ���ֱ��ȶ�ʱ��ѡ��
            fm.checkBox_AutoHoldTime_Select.Checked = Convert.ToBoolean(Form1.gss_AutoHoldTime_Select);
            // �ֶ�Ѳ����������ʱ��ѡ��
            fm.checkBox_ManualHoldTime_Select.Checked = Convert.ToBoolean(Form1.gss_ManualHoldTime_Select);
            // ��������ѡ��
            fm.checkBox_Boost_Select.Checked = Convert.ToBoolean(Form1.gss_Boost_Select);
            // ��̬��ʾѡ��
            fm.checkBox_ThreeStatusShowSwitch_Select.Checked = Convert.ToBoolean(Form1.gss_ThreeStatusShowSwitch_Select);
            // ģ���ٶ���ʾѡ��
            fm.checkBox_SimulationSpeedShow_Select.Checked = Convert.ToBoolean(Form1.gss_SimulationSpeedShow_Select);
            // ģ�������ʾѡ��
            fm.checkBox_SimulationCurrentShow_Select.Checked = Convert.ToBoolean(Form1.gss_SimulationCurrentShow_Select);
            // ɲ������ѡ��
            fm.checkBox_Braking_Select.Checked = Convert.ToBoolean(Form1.gss_Braking_Select);
            // ����ʵ��ѡ��
            fm.checkBox_MoreSpeed_Select.Checked = Convert.ToBoolean(Form1.gss_MoreSpeed_Select);

            // ��
            if (Convert.ToInt32(Form1.gss_Pipe, 16) < fm.comboBox_Pipe.Items.Count)
            {
                fm.comboBox_Pipe.Text = fm.comboBox_Pipe.Items[Convert.ToInt32(Form1.gss_Pipe, 16)].ToString();
            }
            // 6��
            if (Convert.ToInt32(Form1.gss_Pipe) == 0)
            {
                // �������ֵ=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_PhaseCurrentPeak.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_PhaseCurrentPeak,16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // ��ת��������ֵ=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_LockedRotorProtectionCurrentValue.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_LockedRotorProtectionCurrentValue,16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_SNLAccelerationAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SNLAccelerationAmpere,16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_SNLHighAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SNLHighAmpere,16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_SNLMidAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SNLMidAmpere,16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_SNLLowAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SNLLowAmpere,16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_SLAccelerationAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SLAccelerationAmpere,16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_SLHighAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SLHighAmpere,16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_SLMidAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SLMidAmpere,16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_SLLowAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SLLowAmpere,16)) * 5 / 255 - 1) / 0.104).ToString("0");
            }
            // 9��
            if (Convert.ToInt32(Form1.gss_Pipe) == 1)
            {
                // �������ֵ=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_PhaseCurrentPeak.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_PhaseCurrentPeak,16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // ��ת��������ֵ=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_LockedRotorProtectionCurrentValue.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_LockedRotorProtectionCurrentValue,16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_SNLAccelerationAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SNLAccelerationAmpere,16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_SNLHighAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SNLHighAmpere,16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_SNLMidAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SNLMidAmpere,16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_SNLLowAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SNLLowAmpere,16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_SLAccelerationAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SLAccelerationAmpere,16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_SLHighAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SLHighAmpere,16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_SLMidAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SLMidAmpere,16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_SLLowAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SLLowAmpere,16)) * 5 / 255 - 1) / 0.104).ToString("0");
            }
            // 12��
            if (Convert.ToInt32(Form1.gss_Pipe) == 2)
            {
                // �������ֵ=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_PhaseCurrentPeak.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_PhaseCurrentPeak,16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // ��ת��������ֵ=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_LockedRotorProtectionCurrentValue.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_LockedRotorProtectionCurrentValue,16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_SNLAccelerationAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SNLAccelerationAmpere,16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_SNLHighAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SNLHighAmpere,16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_SNLMidAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SNLMidAmpere,16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_SNLLowAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SNLLowAmpere,16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_SLAccelerationAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SLAccelerationAmpere,16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_SLHighAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SLHighAmpere,16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_SLMidAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SLMidAmpere,16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_SLLowAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SLLowAmpere, 16)) * 5 / 255 - 1) / 0.104).ToString("0");
            }

            // ���¸��µĲ����������ĵ�����
            // ����ͺ�
            fm.checkBox_MotorType_Select.Checked = Convert.ToBoolean(Form1.gss_MotorType_Select);
            if (Convert.ToInt32(Form1.gss_MotorType, 16) < fm.comboBox_MotorType.Items.Count)
            {
                fm.comboBox_MotorType.Text = fm.comboBox_MotorType.Items[Convert.ToInt32(Form1.gss_MotorType, 16)].ToString();
            }
            // ������ʽ
            if (Convert.ToInt32(Form1.gss_StartStyle, 16) >= fm.trackBar_StartStyle.Minimum && Convert.ToInt32(Form1.gss_StartStyle, 16) <= fm.trackBar_StartStyle.Maximum)
            {
                fm.trackBar_StartStyle.Value = Convert.ToInt32(Form1.gss_StartStyle, 16);
            }
            // ɲ������
            if (Convert.ToInt32(Form1.gss_BrakingPotency, 16) >= fm.trackBar_BrakingPotency.Minimum && Convert.ToInt32(Form1.gss_BrakingPotency, 16) <= fm.trackBar_BrakingPotency.Maximum)
            {
                fm.trackBar_BrakingPotency.Value = Convert.ToInt32(Form1.gss_BrakingPotency, 16);
            }
            // ��ת����
            fm.checkBox_LockedRotorCurrentDrop_Select.Checked = Convert.ToBoolean(Form1.gss_LockedRotorCurrentDrop_Select);
            if (Convert.ToInt32(Form1.gss_LockedRotorCurrentDrop, 16) < fm.comboBox_LockedRotorCurrentDrop.Items.Count)
            {
                fm.comboBox_LockedRotorCurrentDrop.Text = fm.comboBox_LockedRotorCurrentDrop.Items[Convert.ToInt32(Form1.gss_LockedRotorCurrentDrop, 16)].ToString();
            }
            // ����ɲ���ɳ�
            fm.checkBox_HandBrakeOverrun_Select.Checked = Convert.ToBoolean(Form1.gss_HandBrakeOverrun_Select);
            if (Convert.ToInt32(Form1.gss_HandBrakeOverrun, 16) < fm.comboBox_HandBrakeOverrun.Items.Count)
            {
                fm.comboBox_HandBrakeOverrun.Text = fm.comboBox_HandBrakeOverrun.Items[Convert.ToInt32(Form1.gss_HandBrakeOverrun, 16)].ToString();
            }
            // ���з����
            fm.checkBox_SlideCharge_Select.Checked = Convert.ToBoolean(Form1.gss_SlideCharge_Select);
            if (Convert.ToInt32(Form1.gss_SlideCharge, 16) < fm.comboBox_SlideCharge.Items.Count)
            {
                fm.comboBox_SlideCharge.Text = fm.comboBox_SlideCharge.Items[Convert.ToInt32(Form1.gss_SlideCharge, 16)].ToString();
            }

            // ��ʾ���Ĳ�������
            // ����汾��
            fm.myTextBoxNUM_SoftwareVersion.Text = (Convert.ToDouble(Convert.ToInt32(Form1.gss_SoftwareVersion, 16)) / 100).ToString("0.00");
            // Ӳ���汾��
            fm.myTextBoxNUM_HardwareVersion.Text = Convert.ToInt32(Form1.gss_HardwareVersion, 16).ToString();
            // ��Ʒ�ͺ�
            fm.myTextBoxNUM_ProductModel.Text = Convert.ToInt32(Form1.gss_ProductModel, 16).ToString();
            // �������
            fm.myTextBoxNUM_MotorSeries.Text = Convert.ToInt32(Form1.gss_MotorSeries, 16).ToString();
            // ��������
            if (Convert.ToInt32(Form1.gss_SamePolarity, 16) == 0)
            {
                fm.myTextBoxNUM_SamePolarity.Text = "����";
            }
            else if (Convert.ToInt32(Form1.gss_SamePolarity, 16) == 1)
            {
                fm.myTextBoxNUM_SamePolarity.Text = "����";
            }
            // �����������¶�
            fm.myTextBoxNUM_ProtectionTemperature.Text = Convert.ToInt32(Form1.gss_ProtectionTemperature, 16).ToString();
            // ��������
            if (Convert.ToInt32(Form1.gss_Hall, 16) < fm.comboBox_Hall.Items.Count)
            {
                fm.comboBox_Hall.Text = fm.comboBox_Hall.Items[Convert.ToInt32(Form1.gss_Hall, 16)].ToString();
            }
        }

        // ����ר�õĶ�ȡ���ݵ�P T U
        // P T U
        public static void ParametersToUI_SerialPort_Receive(Form1 fm)
        {
            //
            // �����趨��
            //
            // �������ֵ
            if (Convert.ToInt32(Form1.gss_MotorSequence, 16) < fm.comboBox_MotorSequence.Items.Count)
            {
                fm.comboBox_MotorSequence.Text = fm.comboBox_MotorSequence.Items[Convert.ToInt32(Form1.gss_MotorSequence, 16)].ToString();
            }
            // �������
            if (Convert.ToInt32(Form1.gss_HallPhaseValue, 16) < fm.comboBox_HallPhaseValue.Items.Count)
            {
                fm.comboBox_HallPhaseValue.Text = fm.comboBox_HallPhaseValue.Items[Convert.ToInt32(Form1.gss_HallPhaseValue, 16)].ToString();
            }
            // ���ٷ�Χ����ֵ=�ֱ������ѹ��д��ֵ����λV����ȷ��С����һλ�� �� 255 / 5 
            fm.myTextBoxNUM_SpeedUpperBound.Text = (Convert.ToDouble(Convert.ToInt32(Form1.gss_SpeedUpperBound, 16)) * 5 / 255).ToString("0.0");
            // ���ٷ�Χ����ֵ=�ֱ������ѹ��д��ֵ����λV����ȷ��С����һλ�� �� 255 / 5 
            fm.myTextBoxNUM_SpeedLowerBound.Text = (Convert.ToDouble(Convert.ToInt32(Form1.gss_SpeedLowerBound, 16)) * 5 / 255).ToString("0.0");
            // ���ɳ���������ֵ=�ֱ������ѹ��д��ֵ����λV����ȷ��С����һλ�� �� 255 / 5 
            fm.myTextBoxNUM_ProtectionUpperBound.Text = (Convert.ToDouble(Convert.ToInt32(Form1.gss_ProtectionUpperBound, 16)) * 5 / 255).ToString("0.0");
            // ���ɳ���������ֵ=�ֱ������ѹ��д��ֵ����λV����ȷ��С����һλ�� �� 255 / 5 
            fm.myTextBoxNUM_ProtectionLowerBound.Text = (Convert.ToDouble(Convert.ToInt32(Form1.gss_ProtectionLowerBound, 16)) * 5 / 255).ToString("0.0");
            // ��ض��ѹ
            if (Convert.ToInt32(Form1.gss_BatteryType, 16) < fm.comboBox_BatteryType.Items.Count)
            {
                fm.comboBox_BatteryType.Text = fm.comboBox_BatteryType.Items[Convert.ToInt32(Form1.gss_BatteryType, 16)].ToString();
            }
            // 48v���
            if (fm.comboBox_BatteryType.SelectedIndex == 0)
            {
                // ��ع�ѹֵ=BusVolt��д��ֵ�� �� 0.0653 �� 255 / 5
                fm.myTextBoxNUM_BatteryMaximumVoltage.Text = (Convert.ToDouble(Convert.ToInt32(Form1.gss_BatteryMaximumVoltage, 16)) * 5 / 255 / 0.0653).ToString("0.0");
                // ���Ƿѹֵ=BusVolt��д��ֵ�� �� 0.0653 �� 255 / 5
                fm.myTextBoxNUM_BatteryMinimumVoltage.Text = (Convert.ToDouble(Convert.ToInt32(Form1.gss_BatteryMinimumVoltage, 16)) * 5 / 255 / 0.0653).ToString("0.0");
            }
            // 36V���
            else
            {
                // ��ع�ѹֵ=BusVolt��д��ֵ�� �� 0.0653 �� 255 / 5
                fm.myTextBoxNUM_BatteryMaximumVoltage.Text = (Convert.ToDouble(Convert.ToInt32(Form1.gss_BatteryMaximumVoltage_36V, 16)) * 5 / 255 / 0.0653).ToString("0.0");
                // ���Ƿѹֵ=BusVolt��д��ֵ�� �� 0.0653 �� 255 / 5
                fm.myTextBoxNUM_BatteryMinimumVoltage.Text = (Convert.ToDouble(Convert.ToInt32(Form1.gss_BatteryMinimumVoltage_36V, 16)) * 5 / 255 / 0.0653).ToString("0.0");
            }
            // �����߷�ѹϵ��=д��ֵ �� 10
            // �˴��Ѿ�ȡ������
            //fm.myTextBoxNUM_SpeedLimitVoltageDivideCoefficient.Text = (Convert.ToDouble(Form1.gss_SpeedLimitVoltageDivideCoefficient) / 10).ToString("0.0");

            //
            // ����ѡ����
            //
            // �������� ������ ����ֵ ����=д��ֵ / 4
            fm.myTextBoxNUM_SNLAccelerationSpeed.Text = (Convert.ToDouble(Convert.ToInt32(Form1.gss_SNLAccelerationSpeed, 16)) * 4).ToString("0");
            // �������� ������ ����ֵ ����=д��ֵ / 4
            fm.myTextBoxNUM_SNLHighSpeed.Text = (Convert.ToDouble(Convert.ToInt32(Form1.gss_SNLHighSpeed, 16)) * 4).ToString("0");
            // �������� ������ ����ֵ ����=д��ֵ / 4
            fm.myTextBoxNUM_SNLMidSpeed.Text = (Convert.ToDouble(Convert.ToInt32(Form1.gss_SNLMidSpeed, 16)) * 4).ToString("0");
            // �������� ������ ����ֵ ����=д��ֵ / 4
            fm.myTextBoxNUM_SNLLowSpeed.Text = (Convert.ToDouble(Convert.ToInt32(Form1.gss_SNLLowSpeed, 16)) * 4).ToString("0");
            // �������� ������ ����ֵ ����=д��ֵ / 4
            fm.myTextBoxNUM_SLAccelerationSpeed.Text = (Convert.ToDouble(Convert.ToInt32(Form1.gss_SLAccelerationSpeed, 16)) * 4).ToString("0");
            // �������� ������ ����ֵ ����=д��ֵ / 4
            fm.myTextBoxNUM_SLHighSpeed.Text = (Convert.ToDouble(Convert.ToInt32(Form1.gss_SLHighSpeed, 16)) * 4).ToString("0");
            // �������� ������ ����ֵ ����=д��ֵ / 4
            fm.myTextBoxNUM_SLMidSpeed.Text = (Convert.ToDouble(Convert.ToInt32(Form1.gss_SLMidSpeed, 16)) * 4).ToString("0");
            // �������� ������ ����ֵ ����=д��ֵ / 4
            fm.myTextBoxNUM_SLLowSpeed.Text = (Convert.ToDouble(Convert.ToInt32(Form1.gss_SLLowSpeed, 16)) * 4).ToString("0");
            // Ѳ������
            if (Convert.ToInt32(Form1.gss_Cruise, 16) < fm.comboBox_Cruise.Items.Count)
            {
                fm.comboBox_Cruise.Text = fm.comboBox_Cruise.Items[Convert.ToInt32(Form1.gss_Cruise, 16)].ToString();
            }
            // �綯Ѳ������ת��
            if (Convert.ToInt32(Form1.gss_CruiseSwitch, 16) < fm.comboBox_CruiseSwitch.Items.Count)
            {
                fm.comboBox_CruiseSwitch.Text = fm.comboBox_CruiseSwitch.Items[Convert.ToInt32(Form1.gss_CruiseSwitch, 16)].ToString();
            }
            // �Զ�Ѳ���ֱ��ȶ�ʱ��=д��ֵ �� 10
            fm.myTextBoxNUM_AutoHoldTime.Text = (Convert.ToDouble(Convert.ToInt32(Form1.gss_AutoHoldTime, 16)) / 10).ToString("0");
            // �ֶ�Ѳ����������ʱ��=д��ֵ �� 20
            fm.myTextBoxNUM_ManualHoldTime.Text = (Convert.ToDouble(Convert.ToInt32(Form1.gss_ManualHoldTime, 16)) / 20).ToString("0");
            // ��������
            if (Convert.ToInt32(Form1.gss_Boost, 16) < fm.comboBox_Boost.Items.Count)
            {
                fm.comboBox_Boost.Text = fm.comboBox_Boost.Items[Convert.ToInt32(Form1.gss_Boost, 16)].ToString();
            }
            // ��̬��ʾ
            if (Convert.ToInt32(Form1.gss_ThreeStatusShowSwitch, 16) < fm.comboBox_ThreeStatusShowSwitch.Items.Count)
            {
                fm.comboBox_ThreeStatusShowSwitch.Text = fm.comboBox_ThreeStatusShowSwitch.Items[Convert.ToInt32(Form1.gss_ThreeStatusShowSwitch, 16)].ToString();
            }
            // ģ���ٶ���ʾ=д��ֵ �� 10
            fm.myTextBoxNUM_SimulationSpeedShow.Text = (Convert.ToDouble(Convert.ToInt32(Form1.gss_SimulationSpeedShow, 16)) / 10).ToString("0.0");
            // ģ�������ʾ=д��ֵ �� 10
            fm.myTextBoxNUM_SimulationCurrentShow.Text = (Convert.ToDouble(Convert.ToInt32(Form1.gss_SimulationCurrentShow, 16)) / 10).ToString("0.0");
            // ɲ������
            if (Convert.ToInt32(Form1.gss_Braking, 16) < fm.comboBox_Braking.Items.Count)
            {
                fm.comboBox_Braking.Text = fm.comboBox_Braking.Items[Convert.ToInt32(Form1.gss_Braking, 16)].ToString();
            }
            // ����ʵ��
            if (Convert.ToInt32(Form1.gss_MoreSpeed, 16) < fm.comboBox_MoreSpeed.Items.Count)
            {
                fm.comboBox_MoreSpeed.Text = fm.comboBox_MoreSpeed.Items[Convert.ToInt32(Form1.gss_MoreSpeed, 16)].ToString();
            }

            // ��
            if (Convert.ToInt32(Form1.gss_Pipe, 16) < fm.comboBox_Pipe.Items.Count)
            {
                fm.comboBox_Pipe.Text = fm.comboBox_Pipe.Items[Convert.ToInt32(Form1.gss_Pipe, 16)].ToString();
            }
            // 6��
            if (Convert.ToInt32(Form1.gss_Pipe) == 0)
            {
                // �������ֵ=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_PhaseCurrentPeak.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_PhaseCurrentPeak, 16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // ��ת��������ֵ=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_LockedRotorProtectionCurrentValue.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_LockedRotorProtectionCurrentValue, 16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_SNLAccelerationAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SNLAccelerationAmpere, 16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_SNLHighAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SNLHighAmpere, 16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_SNLMidAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SNLMidAmpere, 16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_SNLLowAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SNLLowAmpere, 16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_SLAccelerationAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SLAccelerationAmpere, 16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_SLHighAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SLHighAmpere, 16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_SLMidAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SLMidAmpere, 16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_SLLowAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SLLowAmpere, 16)) * 5 / 255 - 1) / 0.104).ToString("0");
            }
            // 9��
            if (Convert.ToInt32(Form1.gss_Pipe) == 1)
            {
                // �������ֵ=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_PhaseCurrentPeak.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_PhaseCurrentPeak, 16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // ��ת��������ֵ=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_LockedRotorProtectionCurrentValue.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_LockedRotorProtectionCurrentValue, 16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_SNLAccelerationAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SNLAccelerationAmpere, 16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_SNLHighAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SNLHighAmpere, 16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_SNLMidAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SNLMidAmpere, 16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_SNLLowAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SNLLowAmpere, 16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_SLAccelerationAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SLAccelerationAmpere, 16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_SLHighAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SLHighAmpere, 16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_SLMidAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SLMidAmpere, 16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_SLLowAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SLLowAmpere, 16)) * 5 / 255 - 1) / 0.104).ToString("0");
            }
            // 12��
            if (Convert.ToInt32(Form1.gss_Pipe) == 2)
            {
                // �������ֵ=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_PhaseCurrentPeak.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_PhaseCurrentPeak, 16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // ��ת��������ֵ=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_LockedRotorProtectionCurrentValue.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_LockedRotorProtectionCurrentValue, 16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_SNLAccelerationAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SNLAccelerationAmpere, 16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_SNLHighAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SNLHighAmpere, 16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_SNLMidAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SNLMidAmpere, 16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_SNLLowAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SNLLowAmpere, 16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_SLAccelerationAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SLAccelerationAmpere, 16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_SLHighAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SLHighAmpere, 16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_SLMidAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SLMidAmpere, 16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_SLLowAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SLLowAmpere, 16)) * 5 / 255 - 1) / 0.104).ToString("0");
            }

            // ���¸��µĲ����������ĵ�����
            // ����ͺ�
            if (Convert.ToInt32(Form1.gss_MotorType, 16) < fm.comboBox_MotorType.Items.Count)
            {
                fm.comboBox_MotorType.Text = fm.comboBox_MotorType.Items[Convert.ToInt32(Form1.gss_MotorType, 16)].ToString();
            }
            // ������ʽ
            if (Convert.ToInt32(Form1.gss_StartStyle, 16) >= fm.trackBar_StartStyle.Minimum && Convert.ToInt32(Form1.gss_StartStyle, 16) <= fm.trackBar_StartStyle.Maximum)
            {
                fm.trackBar_StartStyle.Value = Convert.ToInt32(Form1.gss_StartStyle, 16);
            }
            // ɲ������
            if (Convert.ToInt32(Form1.gss_BrakingPotency, 16) >= fm.trackBar_BrakingPotency.Minimum && Convert.ToInt32(Form1.gss_BrakingPotency, 16) <= fm.trackBar_BrakingPotency.Maximum)
            {
                fm.trackBar_BrakingPotency.Value = Convert.ToInt32(Form1.gss_BrakingPotency, 16);
            }
            // ��ת����
            if (Convert.ToInt32(Form1.gss_LockedRotorCurrentDrop, 16) < fm.comboBox_LockedRotorCurrentDrop.Items.Count)
            {
                fm.comboBox_LockedRotorCurrentDrop.Text = fm.comboBox_LockedRotorCurrentDrop.Items[Convert.ToInt32(Form1.gss_LockedRotorCurrentDrop, 16)].ToString();
            }
            // ����ɲ���ɳ�
            if (Convert.ToInt32(Form1.gss_HandBrakeOverrun, 16) < fm.comboBox_HandBrakeOverrun.Items.Count)
            {
                fm.comboBox_HandBrakeOverrun.Text = fm.comboBox_HandBrakeOverrun.Items[Convert.ToInt32(Form1.gss_HandBrakeOverrun, 16)].ToString();
            }
            // ���з����
            if (Convert.ToInt32(Form1.gss_SlideCharge, 16) < fm.comboBox_SlideCharge.Items.Count)
            {
                fm.comboBox_SlideCharge.Text = fm.comboBox_SlideCharge.Items[Convert.ToInt32(Form1.gss_SlideCharge, 16)].ToString();
            }

            // ��ʾ���Ĳ�������
            // ����汾��
            fm.myTextBoxNUM_SoftwareVersion.Text = (Convert.ToDouble(Convert.ToInt32(Form1.gss_SoftwareVersion, 16)) / 100).ToString("0.00");
            // Ӳ���汾��
            fm.myTextBoxNUM_HardwareVersion.Text = Convert.ToInt32(Form1.gss_HardwareVersion, 16).ToString();
            // ��Ʒ�ͺ�
            fm.myTextBoxNUM_ProductModel.Text = Convert.ToInt32(Form1.gss_ProductModel, 16).ToString();
            // �������
            fm.myTextBoxNUM_MotorSeries.Text = Convert.ToInt32(Form1.gss_MotorSeries, 16).ToString();
            // ��������
            if (Convert.ToInt32(Form1.gss_SamePolarity, 16) == 0)
            {
                fm.myTextBoxNUM_SamePolarity.Text = "����";
            }
            else if (Convert.ToInt32(Form1.gss_SamePolarity, 16) == 1)
            {
                fm.myTextBoxNUM_SamePolarity.Text = "����";
            }
            // �����������¶�
            fm.myTextBoxNUM_ProtectionTemperature.Text = Convert.ToInt32(Form1.gss_ProtectionTemperature, 16).ToString();
            // ��������
            if (Convert.ToInt32(Form1.gss_Hall, 16) < fm.comboBox_Hall.Items.Count)
            {
                fm.comboBox_Hall.Text = fm.comboBox_Hall.Items[Convert.ToInt32(Form1.gss_Hall, 16)].ToString();
            }
        }


        // У�������Ƿ���Ϸ�ΧҪ��
        // R B C
        public static void ReadBackCheck(Form1 fm)
        {
            // ���ٷ�Χ����ֵ
            try
            {
                if (Convert.ToDouble(fm.myTextBoxNUM_SpeedUpperBound.Text) < (2.1))
                {
                    fm.myTextBoxNUM_SpeedUpperBound.Text = "2.1";
                }
                else if (Convert.ToDouble(fm.myTextBoxNUM_SpeedUpperBound.Text) > (4.9))
                {
                    fm.myTextBoxNUM_SpeedUpperBound.Text = "4.9";
                }
            }
            catch (Exception)
            {
                fm.myTextBoxNUM_SpeedUpperBound.Text = "4.2";
            }

            // ���ٷ�Χ����ֵ
            try
            {
                if (Convert.ToDouble(fm.myTextBoxNUM_SpeedLowerBound.Text) < (0.1))
                {
                    fm.myTextBoxNUM_SpeedLowerBound.Text = "0.1";
                }
                else if (Convert.ToDouble(fm.myTextBoxNUM_SpeedLowerBound.Text) > (1.9))
                {
                    fm.myTextBoxNUM_SpeedLowerBound.Text = "1.9";
                }
            }
            catch (Exception)
            {
                fm.myTextBoxNUM_SpeedLowerBound.Text = "1.1";
            }

            // ���ɳ���������ֵ
            try
            {
                if (Convert.ToDouble(fm.myTextBoxNUM_ProtectionUpperBound.Text) < (2.1))
                {
                    fm.myTextBoxNUM_ProtectionUpperBound.Text = "2.1";
                }
                else if (Convert.ToDouble(fm.myTextBoxNUM_ProtectionUpperBound.Text) > (4.9))
                {
                    fm.myTextBoxNUM_ProtectionUpperBound.Text = "4.9";
                }
            }
            catch (Exception)
            {
                fm.myTextBoxNUM_ProtectionUpperBound.Text = "4.5";
            }

            // ���ɳ���������ֵ
            try
            {
                if (Convert.ToDouble(fm.myTextBoxNUM_ProtectionLowerBound.Text) < (0.1))
                {
                    fm.myTextBoxNUM_ProtectionLowerBound.Text = "0.1";
                }
                else if (Convert.ToDouble(fm.myTextBoxNUM_ProtectionLowerBound.Text) > (1.9))
                {
                    fm.myTextBoxNUM_ProtectionLowerBound.Text = "1.9";
                }
            }
            catch (Exception)
            {
                fm.myTextBoxNUM_ProtectionLowerBound.Text = "0.8";
            }

            // ������� ComboBox
            // 48V���
            if (fm.comboBox_BatteryType.SelectedIndex == 0)
            {
                // ��ع�ѹ����ֵ
                try
                {
                    if (Convert.ToDouble(fm.myTextBoxNUM_BatteryMaximumVoltage.Text) < (48))
                    {
                        fm.myTextBoxNUM_BatteryMaximumVoltage.Text = "48.0";
                    }
                    else if (Convert.ToDouble(fm.myTextBoxNUM_BatteryMaximumVoltage.Text) > (56))
                    {
                        fm.myTextBoxNUM_BatteryMaximumVoltage.Text = "56.0";
                    }
                }
                catch (Exception)
                {
                    fm.myTextBoxNUM_BatteryMaximumVoltage.Text = "54.0";
                }
                // ���Ƿѹ����ֵ
                try
                {
                    if (Convert.ToDouble(fm.myTextBoxNUM_BatteryMinimumVoltage.Text) < (42))
                    {
                        fm.myTextBoxNUM_BatteryMinimumVoltage.Text = "42.0";
                    }
                    else if (Convert.ToDouble(fm.myTextBoxNUM_BatteryMinimumVoltage.Text) > (48))
                    {
                        fm.myTextBoxNUM_BatteryMinimumVoltage.Text = "48.0";
                    }
                }
                catch (Exception)
                {
                    fm.myTextBoxNUM_BatteryMinimumVoltage.Text = "42.5";
                }
            }
            // 36V���
            else if (fm.comboBox_BatteryType.SelectedIndex == 1)
            {
                // ��ع�ѹ����ֵ
                try
                {
                    if (Convert.ToDouble(fm.myTextBoxNUM_BatteryMaximumVoltage.Text) < (36))
                    {
                        fm.myTextBoxNUM_BatteryMaximumVoltage.Text = "36.0";
                    }
                    else if (Convert.ToDouble(fm.myTextBoxNUM_BatteryMaximumVoltage.Text) > (42))
                    {
                        fm.myTextBoxNUM_BatteryMaximumVoltage.Text = "42.0";
                    }
                }
                catch (Exception)
                {
                    fm.myTextBoxNUM_BatteryMaximumVoltage.Text = "41.0";
                }
                // ���Ƿѹ����ֵ
                try
                {
                    if (Convert.ToDouble(fm.myTextBoxNUM_BatteryMinimumVoltage.Text) < (28))
                    {
                        fm.myTextBoxNUM_BatteryMinimumVoltage.Text = "28.0";
                    }
                    else if (Convert.ToDouble(fm.myTextBoxNUM_BatteryMinimumVoltage.Text) > (36))
                    {
                        fm.myTextBoxNUM_BatteryMinimumVoltage.Text = "36.0";
                    }
                }
                catch (Exception)
                {
                    fm.myTextBoxNUM_BatteryMinimumVoltage.Text = "30.0";
                }
            }

            // �� ComboBox
            // �˴������������ݴ�������Ժ�������ģ����ô˴�
            // ������ĵĵط�������
            // 1.�������ֵ����ֵ�ķ�Χ��ϵ��
            // 2.��ת��������ֵ�ķ�Χ��ϵ��
            // 3.��������������������ķ�Χ��ϵ��
            // 6��
            if (fm.comboBox_Pipe.SelectedIndex == 0)
            {
                // �������ֵ����ֵ
                try
                {
                    if (Convert.ToDouble(fm.myTextBoxNUM_PhaseCurrentPeak.Text) < (6))
                    {
                        fm.myTextBoxNUM_PhaseCurrentPeak.Text = "6";
                    }
                    else if (Convert.ToDouble(fm.myTextBoxNUM_PhaseCurrentPeak.Text) > (35))
                    {
                        fm.myTextBoxNUM_PhaseCurrentPeak.Text = "35";
                    }
                }
                catch (Exception)
                {
                    fm.myTextBoxNUM_PhaseCurrentPeak.Text = "20";
                }
                // ��ת��������
                try
                {
                    if (Convert.ToDouble(fm.myTextBoxNUM_LockedRotorProtectionCurrentValue.Text) < (6))
                    {
                        fm.myTextBoxNUM_LockedRotorProtectionCurrentValue.Text = "6";
                    }
                    else if (Convert.ToDouble(fm.myTextBoxNUM_LockedRotorProtectionCurrentValue.Text) > (35))
                    {
                        fm.myTextBoxNUM_LockedRotorProtectionCurrentValue.Text = "35";
                    }
                }
                catch (Exception)
                {
                    fm.myTextBoxNUM_LockedRotorProtectionCurrentValue.Text = "10";
                }
                // �������� ������ ����ֵ ����
                try
                {
                    if (Convert.ToDouble(fm.myTextBoxNUM_SNLAccelerationAmpere.Text) < (1))
                    {
                        fm.myTextBoxNUM_SNLAccelerationAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(fm.myTextBoxNUM_SNLAccelerationAmpere.Text) > (35))
                    {
                        fm.myTextBoxNUM_SNLAccelerationAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    fm.myTextBoxNUM_SNLAccelerationAmpere.Text = "20";
                }
                // �������� ������ ����ֵ ����
                try
                {
                    if (Convert.ToDouble(fm.myTextBoxNUM_SNLHighAmpere.Text) < (1))
                    {
                        fm.myTextBoxNUM_SNLHighAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(fm.myTextBoxNUM_SNLHighAmpere.Text) > (35))
                    {
                        fm.myTextBoxNUM_SNLHighAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    fm.myTextBoxNUM_SNLHighAmpere.Text = "17";
                }
                // �������� ������ ����ֵ ����
                try
                {
                    if (Convert.ToDouble(fm.myTextBoxNUM_SNLMidAmpere.Text) < (1))
                    {
                        fm.myTextBoxNUM_SNLMidAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(fm.myTextBoxNUM_SNLMidAmpere.Text) > (35))
                    {
                        fm.myTextBoxNUM_SNLMidAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    fm.myTextBoxNUM_SNLMidAmpere.Text = "13";
                }
                // �������� ������ ����ֵ ����
                try
                {
                    if (Convert.ToDouble(fm.myTextBoxNUM_SNLLowAmpere.Text) < (1))
                    {
                        fm.myTextBoxNUM_SNLLowAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(fm.myTextBoxNUM_SNLLowAmpere.Text) > (35))
                    {
                        fm.myTextBoxNUM_SNLLowAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    fm.myTextBoxNUM_SNLLowAmpere.Text = "9";
                }
                // �������� ������ ����ֵ ����
                try
                {
                    if (Convert.ToDouble(fm.myTextBoxNUM_SLAccelerationAmpere.Text) < (1))
                    {
                        fm.myTextBoxNUM_SLAccelerationAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(fm.myTextBoxNUM_SLAccelerationAmpere.Text) > (35))
                    {
                        fm.myTextBoxNUM_SLAccelerationAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    fm.myTextBoxNUM_SLAccelerationAmpere.Text = "12";
                }
                // �������� ������ ����ֵ ����
                try
                {
                    if (Convert.ToDouble(fm.myTextBoxNUM_SLHighAmpere.Text) < (1))
                    {
                        fm.myTextBoxNUM_SLHighAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(fm.myTextBoxNUM_SLHighAmpere.Text) > (35))
                    {
                        fm.myTextBoxNUM_SLHighAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    fm.myTextBoxNUM_SLHighAmpere.Text = "10";
                }
                // �������� ������ ����ֵ ����
                try
                {
                    if (Convert.ToDouble(fm.myTextBoxNUM_SLMidAmpere.Text) < (1))
                    {
                        fm.myTextBoxNUM_SLMidAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(fm.myTextBoxNUM_SLMidAmpere.Text) > (35))
                    {
                        fm.myTextBoxNUM_SLMidAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    fm.myTextBoxNUM_SLMidAmpere.Text = "8";
                }
                // �������� ������ ����ֵ ����
                try
                {
                    if (Convert.ToDouble(fm.myTextBoxNUM_SLLowAmpere.Text) < (1))
                    {
                        fm.myTextBoxNUM_SLLowAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(fm.myTextBoxNUM_SLLowAmpere.Text) > (35))
                    {
                        fm.myTextBoxNUM_SLLowAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    fm.myTextBoxNUM_SLLowAmpere.Text = "6";
                }
            }

            // 9��
            else if (fm.comboBox_Pipe.SelectedIndex == 1)
            {
                // �������ֵ����ֵ
                try
                {
                    if (Convert.ToDouble(fm.myTextBoxNUM_PhaseCurrentPeak.Text) < (6))
                    {
                        fm.myTextBoxNUM_PhaseCurrentPeak.Text = "6";
                    }
                    else if (Convert.ToDouble(fm.myTextBoxNUM_PhaseCurrentPeak.Text) > (35))
                    {
                        fm.myTextBoxNUM_PhaseCurrentPeak.Text = "35";
                    }
                }
                catch (Exception)
                {
                    fm.myTextBoxNUM_PhaseCurrentPeak.Text = "20";
                }
                // ��ת��������
                try
                {
                    if (Convert.ToDouble(fm.myTextBoxNUM_LockedRotorProtectionCurrentValue.Text) < (6))
                    {
                        fm.myTextBoxNUM_LockedRotorProtectionCurrentValue.Text = "6";
                    }
                    else if (Convert.ToDouble(fm.myTextBoxNUM_LockedRotorProtectionCurrentValue.Text) > (35))
                    {
                        fm.myTextBoxNUM_LockedRotorProtectionCurrentValue.Text = "35";
                    }
                }
                catch (Exception)
                {
                    fm.myTextBoxNUM_LockedRotorProtectionCurrentValue.Text = "10";
                }
                // �������� ������ ����ֵ ����
                try
                {
                    if (Convert.ToDouble(fm.myTextBoxNUM_SNLAccelerationAmpere.Text) < (1))
                    {
                        fm.myTextBoxNUM_SNLAccelerationAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(fm.myTextBoxNUM_SNLAccelerationAmpere.Text) > (35))
                    {
                        fm.myTextBoxNUM_SNLAccelerationAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    fm.myTextBoxNUM_SNLAccelerationAmpere.Text = "20";
                }
                // �������� ������ ����ֵ ����
                try
                {
                    if (Convert.ToDouble(fm.myTextBoxNUM_SNLHighAmpere.Text) < (1))
                    {
                        fm.myTextBoxNUM_SNLHighAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(fm.myTextBoxNUM_SNLHighAmpere.Text) > (35))
                    {
                        fm.myTextBoxNUM_SNLHighAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    fm.myTextBoxNUM_SNLHighAmpere.Text = "17";
                }
                // �������� ������ ����ֵ ����
                try
                {
                    if (Convert.ToDouble(fm.myTextBoxNUM_SNLMidAmpere.Text) < (1))
                    {
                        fm.myTextBoxNUM_SNLMidAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(fm.myTextBoxNUM_SNLMidAmpere.Text) > (35))
                    {
                        fm.myTextBoxNUM_SNLMidAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    fm.myTextBoxNUM_SNLMidAmpere.Text = "13";
                }
                // �������� ������ ����ֵ ����
                try
                {
                    if (Convert.ToDouble(fm.myTextBoxNUM_SNLLowAmpere.Text) < (1))
                    {
                        fm.myTextBoxNUM_SNLLowAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(fm.myTextBoxNUM_SNLLowAmpere.Text) > (35))
                    {
                        fm.myTextBoxNUM_SNLLowAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    fm.myTextBoxNUM_SNLLowAmpere.Text = "9";
                }
                // �������� ������ ����ֵ ����
                try
                {
                    if (Convert.ToDouble(fm.myTextBoxNUM_SLAccelerationAmpere.Text) < (1))
                    {
                        fm.myTextBoxNUM_SLAccelerationAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(fm.myTextBoxNUM_SLAccelerationAmpere.Text) > (35))
                    {
                        fm.myTextBoxNUM_SLAccelerationAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    fm.myTextBoxNUM_SLAccelerationAmpere.Text = "12";
                }
                // �������� ������ ����ֵ ����
                try
                {
                    if (Convert.ToDouble(fm.myTextBoxNUM_SLHighAmpere.Text) < (1))
                    {
                        fm.myTextBoxNUM_SLHighAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(fm.myTextBoxNUM_SLHighAmpere.Text) > (35))
                    {
                        fm.myTextBoxNUM_SLHighAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    fm.myTextBoxNUM_SLHighAmpere.Text = "10";
                }
                // �������� ������ ����ֵ ����
                try
                {
                    if (Convert.ToDouble(fm.myTextBoxNUM_SLMidAmpere.Text) < (1))
                    {
                        fm.myTextBoxNUM_SLMidAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(fm.myTextBoxNUM_SLMidAmpere.Text) > (35))
                    {
                        fm.myTextBoxNUM_SLMidAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    fm.myTextBoxNUM_SLMidAmpere.Text = "8";
                }
                // �������� ������ ����ֵ ����
                try
                {
                    if (Convert.ToDouble(fm.myTextBoxNUM_SLLowAmpere.Text) < (1))
                    {
                        fm.myTextBoxNUM_SLLowAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(fm.myTextBoxNUM_SLLowAmpere.Text) > (35))
                    {
                        fm.myTextBoxNUM_SLLowAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    fm.myTextBoxNUM_SLLowAmpere.Text = "6";
                }
            }

            // 12��
            else if (fm.comboBox_Pipe.SelectedIndex == 2)
            {
                // �������ֵ����ֵ
                try
                {
                    if (Convert.ToDouble(fm.myTextBoxNUM_PhaseCurrentPeak.Text) < (6))
                    {
                        fm.myTextBoxNUM_PhaseCurrentPeak.Text = "6";
                    }
                    else if (Convert.ToDouble(fm.myTextBoxNUM_PhaseCurrentPeak.Text) > (35))
                    {
                        fm.myTextBoxNUM_PhaseCurrentPeak.Text = "35";
                    }
                }
                catch (Exception)
                {
                    fm.myTextBoxNUM_PhaseCurrentPeak.Text = "20";
                }
                // ��ת��������
                try
                {
                    if (Convert.ToDouble(fm.myTextBoxNUM_LockedRotorProtectionCurrentValue.Text) < (6))
                    {
                        fm.myTextBoxNUM_LockedRotorProtectionCurrentValue.Text = "6";
                    }
                    else if (Convert.ToDouble(fm.myTextBoxNUM_LockedRotorProtectionCurrentValue.Text) > (35))
                    {
                        fm.myTextBoxNUM_LockedRotorProtectionCurrentValue.Text = "35";
                    }
                }
                catch (Exception)
                {
                    fm.myTextBoxNUM_LockedRotorProtectionCurrentValue.Text = "10";
                }
                // �������� ������ ����ֵ ����
                try
                {
                    if (Convert.ToDouble(fm.myTextBoxNUM_SNLAccelerationAmpere.Text) < (1))
                    {
                        fm.myTextBoxNUM_SNLAccelerationAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(fm.myTextBoxNUM_SNLAccelerationAmpere.Text) > (35))
                    {
                        fm.myTextBoxNUM_SNLAccelerationAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    fm.myTextBoxNUM_SNLAccelerationAmpere.Text = "20";
                }
                // �������� ������ ����ֵ ����
                try
                {
                    if (Convert.ToDouble(fm.myTextBoxNUM_SNLHighAmpere.Text) < (1))
                    {
                        fm.myTextBoxNUM_SNLHighAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(fm.myTextBoxNUM_SNLHighAmpere.Text) > (35))
                    {
                        fm.myTextBoxNUM_SNLHighAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    fm.myTextBoxNUM_SNLHighAmpere.Text = "17";
                }
                // �������� ������ ����ֵ ����
                try
                {
                    if (Convert.ToDouble(fm.myTextBoxNUM_SNLMidAmpere.Text) < (1))
                    {
                        fm.myTextBoxNUM_SNLMidAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(fm.myTextBoxNUM_SNLMidAmpere.Text) > (35))
                    {
                        fm.myTextBoxNUM_SNLMidAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    fm.myTextBoxNUM_SNLMidAmpere.Text = "13";
                }
                // �������� ������ ����ֵ ����
                try
                {
                    if (Convert.ToDouble(fm.myTextBoxNUM_SNLLowAmpere.Text) < (1))
                    {
                        fm.myTextBoxNUM_SNLLowAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(fm.myTextBoxNUM_SNLLowAmpere.Text) > (35))
                    {
                        fm.myTextBoxNUM_SNLLowAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    fm.myTextBoxNUM_SNLLowAmpere.Text = "9";
                }
                // �������� ������ ����ֵ ����
                try
                {
                    if (Convert.ToDouble(fm.myTextBoxNUM_SLAccelerationAmpere.Text) < (1))
                    {
                        fm.myTextBoxNUM_SLAccelerationAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(fm.myTextBoxNUM_SLAccelerationAmpere.Text) > (35))
                    {
                        fm.myTextBoxNUM_SLAccelerationAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    fm.myTextBoxNUM_SLAccelerationAmpere.Text = "12";
                }
                // �������� ������ ����ֵ ����
                try
                {
                    if (Convert.ToDouble(fm.myTextBoxNUM_SLHighAmpere.Text) < (1))
                    {
                        fm.myTextBoxNUM_SLHighAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(fm.myTextBoxNUM_SLHighAmpere.Text) > (35))
                    {
                        fm.myTextBoxNUM_SLHighAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    fm.myTextBoxNUM_SLHighAmpere.Text = "10";
                }
                // �������� ������ ����ֵ ����
                try
                {
                    if (Convert.ToDouble(fm.myTextBoxNUM_SLMidAmpere.Text) < (1))
                    {
                        fm.myTextBoxNUM_SLMidAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(fm.myTextBoxNUM_SLMidAmpere.Text) > (35))
                    {
                        fm.myTextBoxNUM_SLMidAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    fm.myTextBoxNUM_SLMidAmpere.Text = "8";
                }
                // �������� ������ ����ֵ ����
                try
                {
                    if (Convert.ToDouble(fm.myTextBoxNUM_SLLowAmpere.Text) < (1))
                    {
                        fm.myTextBoxNUM_SLLowAmpere.Text = "1";
                    }
                    else if (Convert.ToDouble(fm.myTextBoxNUM_SLLowAmpere.Text) > (35))
                    {
                        fm.myTextBoxNUM_SLLowAmpere.Text = "35";
                    }
                }
                catch (Exception)
                {
                    fm.myTextBoxNUM_SLLowAmpere.Text = "6";
                }
            }

            // �������� ������ ����ֵ ����
            try
            {
                if (Convert.ToDouble(fm.myTextBoxNUM_SNLAccelerationSpeed.Text) < (1))
                {
                    fm.myTextBoxNUM_SNLAccelerationSpeed.Text = "1";
                }
                else if (Convert.ToDouble(fm.myTextBoxNUM_SNLAccelerationSpeed.Text) > (600))
                {
                    fm.myTextBoxNUM_SNLAccelerationSpeed.Text = "600";
                }
            }
            catch (Exception)
            {
                fm.myTextBoxNUM_SNLAccelerationSpeed.Text = "450";
            }
            // �������� ������ ����ֵ ����
            try
            {
                if (Convert.ToDouble(fm.myTextBoxNUM_SNLHighSpeed.Text) < (1))
                {
                    fm.myTextBoxNUM_SNLHighSpeed.Text = "1";
                }
                else if (Convert.ToDouble(fm.myTextBoxNUM_SNLHighSpeed.Text) > (600))
                {
                    fm.myTextBoxNUM_SNLHighSpeed.Text = "600";
                }
            }
            catch (Exception)
            {
                fm.myTextBoxNUM_SNLHighSpeed.Text = "410";
            }
            // �������� ������ ����ֵ ����
            try
            {
                if (Convert.ToDouble(fm.myTextBoxNUM_SNLMidSpeed.Text) < (1))
                {
                    fm.myTextBoxNUM_SNLMidSpeed.Text = "1";
                }
                else if (Convert.ToDouble(fm.myTextBoxNUM_SNLMidSpeed.Text) > (600))
                {
                    fm.myTextBoxNUM_SNLMidSpeed.Text = "600";
                }
            }
            catch (Exception)
            {
                fm.myTextBoxNUM_SNLMidSpeed.Text = "320";
            }
            // �������� ������ ����ֵ ����
            try
            {
                if (Convert.ToDouble(fm.myTextBoxNUM_SNLLowSpeed.Text) < (1))
                {
                    fm.myTextBoxNUM_SNLLowSpeed.Text = "1";
                }
                else if (Convert.ToDouble(fm.myTextBoxNUM_SNLLowSpeed.Text) > (600))
                {
                    fm.myTextBoxNUM_SNLLowSpeed.Text = "600";
                }
            }
            catch (Exception)
            {
                fm.myTextBoxNUM_SNLLowSpeed.Text = "210";
            }
            // �������� ������ ����ֵ ����
            try
            {
                if (Convert.ToDouble(fm.myTextBoxNUM_SLAccelerationSpeed.Text) < (1))
                {
                    fm.myTextBoxNUM_SLAccelerationSpeed.Text = "1";
                }
                else if (Convert.ToDouble(fm.myTextBoxNUM_SLAccelerationSpeed.Text) > (600))
                {
                    fm.myTextBoxNUM_SLAccelerationSpeed.Text = "600";
                }
            }
            catch (Exception)
            {
                fm.myTextBoxNUM_SLAccelerationSpeed.Text = "270";
            }
            // �������� ������ ����ֵ ����
            try
            {
                if (Convert.ToDouble(fm.myTextBoxNUM_SLHighSpeed.Text) < (1))
                {
                    fm.myTextBoxNUM_SLHighSpeed.Text = "1";
                }
                else if (Convert.ToDouble(fm.myTextBoxNUM_SLHighSpeed.Text) > (600))
                {
                    fm.myTextBoxNUM_SLHighSpeed.Text = "600";
                }
            }
            catch (Exception)
            {
                fm.myTextBoxNUM_SLHighSpeed.Text = "244";
            }
            // �������� ������ ����ֵ ����
            try
            {
                if (Convert.ToDouble(fm.myTextBoxNUM_SLMidSpeed.Text) < (1))
                {
                    fm.myTextBoxNUM_SLMidSpeed.Text = "1";
                }
                else if (Convert.ToDouble(fm.myTextBoxNUM_SLMidSpeed.Text) > (600))
                {
                    fm.myTextBoxNUM_SLMidSpeed.Text = "600";
                }
            }
            catch (Exception)
            {
                fm.myTextBoxNUM_SLMidSpeed.Text = "190";
            }
            // �������� ������ ����ֵ ����
            try
            {
                if (Convert.ToDouble(fm.myTextBoxNUM_SLLowSpeed.Text) < (1))
                {
                    fm.myTextBoxNUM_SLLowSpeed.Text = "1";
                }
                else if (Convert.ToDouble(fm.myTextBoxNUM_SLLowSpeed.Text) > (600))
                {
                    fm.myTextBoxNUM_SLLowSpeed.Text = "600";
                }
            }
            catch (Exception)
            {
                fm.myTextBoxNUM_SLLowSpeed.Text = "126";
            }

            // �Զ�Ѳ���ֱ��ȶ�ʱ��
            try
            {
                if (Convert.ToDouble(fm.myTextBoxNUM_AutoHoldTime.Text) < (2))
                {
                    fm.myTextBoxNUM_AutoHoldTime.Text = "2";
                }
                else if (Convert.ToDouble(fm.myTextBoxNUM_AutoHoldTime.Text) > (12))
                {
                    fm.myTextBoxNUM_AutoHoldTime.Text = "12";
                }
            }
            catch (Exception)
            {
                fm.myTextBoxNUM_AutoHoldTime.Text = "8";
            }

            // �ֶ�Ѳ����������ʱ��
            try
            {
                if (Convert.ToDouble(fm.myTextBoxNUM_ManualHoldTime.Text) < (1))
                {
                    fm.myTextBoxNUM_ManualHoldTime.Text = "1";
                }
                else if (Convert.ToDouble(fm.myTextBoxNUM_ManualHoldTime.Text) > (4))
                {
                    fm.myTextBoxNUM_ManualHoldTime.Text = "4";
                }
            }
            catch (Exception)
            {
                fm.myTextBoxNUM_ManualHoldTime.Text = "2";
            }


            // ģ���ٶ���ʾ
            try
            {
                if (Convert.ToDouble(fm.myTextBoxNUM_SimulationSpeedShow.Text) < (0.2))
                {
                    fm.myTextBoxNUM_SimulationSpeedShow.Text = "0.2";
                }
                else if (Convert.ToDouble(fm.myTextBoxNUM_SimulationSpeedShow.Text) > (1))
                {
                    fm.myTextBoxNUM_SimulationSpeedShow.Text = "1.0";
                }
            }
            catch (Exception)
            {
                fm.myTextBoxNUM_SimulationSpeedShow.Text = "1.0";
            }

            // ģ�������ʾ
            try
            {
                if (Convert.ToDouble(fm.myTextBoxNUM_SimulationCurrentShow.Text) < (2))
                {
                    fm.myTextBoxNUM_SimulationCurrentShow.Text = "2.0";
                }
                else if (Convert.ToDouble(fm.myTextBoxNUM_SimulationCurrentShow.Text) > (10))
                {
                    fm.myTextBoxNUM_SimulationCurrentShow.Text = "10.0";
                }
            }
            catch (Exception)
            {
                fm.myTextBoxNUM_SimulationCurrentShow.Text = "5.0";
            }
        }
    }
}

/*
 * 
 * C#��ToString��ʽ
 * 
 */

/* 
ToString("0.0")  ��ʾ����һλС��
ToString("0")    ��ʾȡ����
ToString("Xy")   X��ʾת��Ϊʮ����������y��Ϊ�����ʾռλ��(ռλ��"0")��yΪ����Ĭ��

�ַ���ת��Ϊ�ַ���

// C ���� 

2.5.ToString("C"); // ��2.50 

// D 10������ 

25.ToString("D5"); // 25000 

// E ��ѧ�� 

25000.ToString("E"); // 2.500000E+005 

// F �̶��� 

25.ToString("F2"); // 25.00 

// G ���� 

2.5.ToString("G"); // 2.5 

// N ���� 

2500000.ToString("N"); // 2,500,000.00 

// X 16���� 

255.ToString("X"); // FF 


// C# ���ڸ�ʽ 
DateTime dt = DateTime.Now; 
  
dt.ToString();//2005-11-5 13:21:25 

dt.ToFileTime().ToString();//127756416859912816 

dt.ToFileTimeUtc().ToString();//127756704859912816 

dt.ToLocalTime().ToString();//2005-11-5 21:21:25 

dt.ToLongDateString().ToString();//2005��11��5�� 

dt.ToLongTimeString().ToString();//13:21:25 

dt.ToOADate().ToString();//38661.5565508218 

dt.ToShortDateString().ToString();//2005-11-5 

dt.ToShortTimeString().ToString();//13:21 

dt.ToUniversalTime().ToString();//2005-11-5 5:21:25 

dt.Year.ToString();//2005 

dt.Date.ToString();//2005-11-5 0:00:00 

dt.DayOfWeek.ToString();//Saturday 

dt.DayOfYear.ToString();//309 

dt.Hour.ToString();//13 

dt.Millisecond.ToString();//441 

dt.Minute.ToString();//30 

dt.Month.ToString();//11 

dt.Second.ToString();//28 

dt.Ticks.ToString();//632667942284412864 

dt.TimeOfDay.ToString();//13:30:28.4412864 

dt.ToString();//2005-11-5 13:47:04 

dt.AddYears(1).ToString();//2006-11-5 13:47:04 

dt.AddDays(1.1).ToString();//2005-11-6 16:11:04 

dt.AddHours(1.1).ToString();//2005-11-5 14:53:04 

dt.AddMilliseconds(1.1).ToString();//2005-11-5 13:47:04 

dt.AddMonths(1).ToString();//2005-12-5 13:47:04 

dt.AddSeconds(1.1).ToString();//2005-11-5 13:47:05 

dt.AddMinutes(1.1).ToString();//2005-11-5 13:48:10 

dt.AddTicks(1000).ToString();//2005-11-5 13:47:04 

dt.CompareTo(dt).ToString();//0 

dt.Add(?).ToString();//�ʺ�Ϊһ��ʱ��� 

dt.Equals("2005-11-6 16:11:04").ToString();//False 

dt.Equals(dt).ToString();//True 

dt.GetHashCode().ToString();//1474088234 

dt.GetType().ToString();//System.DateTime 

dt.GetTypeCode().ToString();//DateTime 

   
dt.GetDateTimeFormats('s')[0].ToString();//2005-11-05T14:06:25 

dt.GetDateTimeFormats('t')[0].ToString();//14:06 

dt.GetDateTimeFormats('y')[0].ToString();//2005��11�� 

dt.GetDateTimeFormats('D')[0].ToString();//2005��11��5�� 

dt.GetDateTimeFormats('D')[1].ToString();//2005 11 05 

dt.GetDateTimeFormats('D')[2].ToString();//������ 2005 11 05 

dt.GetDateTimeFormats('D')[3].ToString();//������ 2005��11��5�� 

dt.GetDateTimeFormats('M')[0].ToString();//11��5�� 

dt.GetDateTimeFormats('f')[0].ToString();//2005��11��5�� 14:06 


dt.GetDateTimeFormats('g')[0].ToString();//2005-11-5 14:06 


dt.GetDateTimeFormats('r')[0].ToString();//Sat, 05 Nov 2005 14:06:25 GMT 

  
string.Format("{0:d}",dt);//2005-11-5 

string.Format("{0:D}",dt);//2005��11��5�� 

string.Format("{0:f}",dt);//2005��11��5�� 14:23 

string.Format("{0:F}",dt);//2005��11��5�� 14:23:23 

string.Format("{0:g}",dt);//2005-11-5 14:23 

string.Format("{0:G}",dt);//2005-11-5 14:23:23 

string.Format("{0:M}",dt);//11��5�� 

string.Format("{0:R}",dt);//Sat, 05 Nov 2005 14:23:23 GMT 

string.Format("{0:s}",dt);//2005-11-05T14:23:23 

string.Format("{0:t}",dt);//14:23 

string.Format("{0:T}",dt);//14:23:23 

string.Format("{0:u}",dt);//2005-11-05 14:23:23Z 

string.Format("{0:U}",dt);//2005��11��5�� 6:23:23 

string.Format("{0:Y}",dt);//2005��11�� 

string.Format("{0}",dt);//2005-11-5 14:23:23 

string.Format("{0:yyyyMMddHHmmssffff}",dt); 
  
  
// ����2������֮��������� 

DateTime dt1 = Convert.DateTime("2007-8-1");    

DateTime dt2 = Convert.DateTime("2007-8-15");   

TimeSpan span = dt2.Subtract(dt1);             

int dayDiff = span.Days + 1;                    
  
// ����ĳ��ĳ�µ����� 

int days = DateTime.DaysInMonth(2007, 8);       

days = 31;                                      
  
// ����������һ�졢����һ�� 

DateTime dt =DateTime.Now; 

dt.AddDays(1); //����һ�� 

dt.AddDays(-1);//����һ�� 

���ڸ�ʽģʽ ˵��
d ���е�ĳһ�졣һλ��������û��ǰ���㡣
dd ���е�ĳһ�졣һλ����������һ��ǰ���㡣
ddd ����ĳ�����д���ƣ��� AbbreviatedDayNames �ж��塣
dddd ����ĳ����������ƣ��� DayNames �ж��塣
M �·����֡�һλ�����·�û��ǰ���㡣
MM �·����֡�һλ�����·���һ��ǰ���㡣
MMM �·ݵ���д���ƣ��� AbbreviatedMonthNames �ж��塣
MMMM �·ݵ��������ƣ��� MonthNames �ж��塣
y ��������Ԫ����ݡ������������Ԫ�����С�� 10������ʾ������ǰ�������ݡ�
yy ��������Ԫ����ݡ������������Ԫ�����С�� 10������ʾ����ǰ�������ݡ�
yyyy ������Ԫ����λ������ݡ�
gg ʱ�ڻ��Ԫ�����Ҫ���ø�ʽ�����ڲ����й�����ʱ�ڻ��Ԫ�ַ���������Ը�ģʽ��
h 12 Сʱ�Ƶ�Сʱ��һλ����Сʱ��û��ǰ���㡣
hh 12 Сʱ�Ƶ�Сʱ��һλ����Сʱ����ǰ���㡣
H 24 Сʱ�Ƶ�Сʱ��һλ����Сʱ��û��ǰ���㡣
HH 24 Сʱ�Ƶ�Сʱ��һλ����Сʱ����ǰ���㡣
m ���ӡ�һλ���ķ�����û��ǰ���㡣
mm ���ӡ�һλ���ķ�������һ��ǰ���㡣
s �롣һλ��������û��ǰ���㡣
ss �롣һλ����������һ��ǰ���㡣
f ���С������Ϊһλ���������ֱ��ضϡ�
ff ���С������Ϊ��λ���������ֱ��ضϡ�
fff ���С������Ϊ��λ���������ֱ��ضϡ�
ffff ���С������Ϊ��λ���������ֱ��ضϡ�
fffff ���С������Ϊ��λ���������ֱ��ضϡ�
ffffff ���С������Ϊ��λ���������ֱ��ضϡ�
fffffff ���С������Ϊ��λ���������ֱ��ضϡ�
t �� AMDesignator �� PMDesignator �ж���� AM/PM ָʾ��ĵ�һ���ַ���������ڣ���
tt �� AMDesignator �� PMDesignator �ж���� AM/PM ָʾ�������ڣ���
z ʱ��ƫ��������+����-���������Сʱ����һλ����Сʱ��û��ǰ���㡣���磬̫ƽ���׼ʱ���ǡ�-8����
zz ʱ��ƫ��������+����-���������Сʱ����һλ����Сʱ����ǰ���㡣���磬̫ƽ���׼ʱ���ǡ�-08����
zzz ����ʱ��ƫ��������+����-���������Сʱ�ͷ��ӣ���һλ����Сʱ���ͷ�������ǰ���㡣���磬̫ƽ���׼ʱ���ǡ�-08:00����
: �� TimeSeparator �ж����Ĭ��ʱ��ָ�����
/ �� DateSeparator �ж����Ĭ�����ڷָ�����
% c ���� c �Ǹ�ʽģʽ���������ʹ�ã��������ʽģʽ��ԭ���ַ���������ʽģʽ�ϲ��������ʡ�ԡ�%���ַ���
\ c ���� c �������ַ�����ԭ����ʾ�ַ�����Ҫ��ʾ��б���ַ�����ʹ�á�\\����

ֻ������ڶ��������г��ĸ�ʽģʽ�������ڴ����Զ���ģʽ���ڵ�һ�������г��ı�׼��ʽ�ַ��������ڴ����Զ���ģʽ��
�Զ���ģʽ�ĳ�������Ϊ�����ַ������磬

DateTime.ToString( "d"); // ���� DateTime ֵ����d���Ǳ�׼������ģʽ�� 
DateTime.ToString( "%d"); // �������е�ĳ�죻��%d�����Զ���ģʽ�� 
DateTime.ToString( "d "); // ���غ������һ���հ��ַ������е�ĳ�죻��d�����Զ���ģʽ�� 

*/