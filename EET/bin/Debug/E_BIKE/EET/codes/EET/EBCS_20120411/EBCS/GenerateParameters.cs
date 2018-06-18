using System;
using System.Collections.Generic;
using System.Text;

namespace EBCS
{
    class GenerateParameters
    {
        // ����ȫ�ֱ���
        // �˷���ͨ����ʽ����ȫ�ֱ���
        public static void UIToConfiguration(Form1 fm)
        {
            ///
            /// �����趨��
            ///
            // �������ֵ
            Form1.gss_MotorSequence = fm.comboBox_MotorSequence.SelectedIndex.ToString();
            // �������
            Form1.gss_HallPhaseValue = fm.comboBox_HallPhaseValue.SelectedIndex.ToString();
            // ���ٷ�Χ����ֵ=�ֱ������ѹ��д��ֵ����λV����ȷ��С����һλ�� �� 255 / 5 
            Form1.gss_SpeedUpperBound = Convert.ToInt32(Convert.ToDouble(fm.myTextBoxNUM_SpeedUpperBound.Text) * 255 / 5).ToString();
            // ���ٷ�Χ����ֵ=�ֱ������ѹ��д��ֵ����λV����ȷ��С����һλ�� �� 255 / 5 
            Form1.gss_SpeedLowerBound = Convert.ToInt32(Convert.ToDouble(fm.myTextBoxNUM_SpeedLowerBound.Text) * 255 / 5).ToString();
            // ���ɳ���������ֵ=�ֱ������ѹ��д��ֵ����λV����ȷ��С����һλ�� �� 255 / 5 
            Form1.gss_ProtectionUpperBound = Convert.ToInt32(Convert.ToDouble(fm.myTextBoxNUM_ProtectionUpperBound.Text) * 255 / 5).ToString();
            // ���ɳ���������ֵ=�ֱ������ѹ��д��ֵ����λV����ȷ��С����һλ�� �� 255 / 5 
            Form1.gss_ProtectionLowerBound = Convert.ToInt32(Convert.ToDouble(fm.myTextBoxNUM_ProtectionLowerBound.Text) * 255 / 5).ToString();
            // �������ֵ
            Form1.gss_BatteryType = fm.comboBox_BatteryType.SelectedIndex.ToString();
            // ��ع�ѹֵ=BusVolt��д��ֵ�� �� 0.0653 �� 255 / 5
            Form1.gss_BatteryMaximumVoltage = Convert.ToInt32(Convert.ToDouble(fm.myTextBoxNUM_BatteryMaximumVoltage.Text) * 0.0653 * 255 / 5).ToString();
            // ���Ƿѹֵ=BusVolt��д��ֵ�� �� 0.0653 �� 255 / 5
            Form1.gss_BatteryMinimumVoltage = Convert.ToInt32(Convert.ToDouble(fm.myTextBoxNUM_BatteryMinimumVoltage.Text) * 0.0653 * 255 / 5).ToString();
            // �����߷�ѹϵ��=д��ֵ �� 10
            Form1.gss_SpeedLimitVoltageDivideCoefficient = Convert.ToInt32(Convert.ToDouble(fm.myTextBoxNUM_SpeedLimitVoltageDivideCoefficient.Text) * 10).ToString();

            ///
            /// ����ѡ����
            ///
            // �������� ������ ����ֵ ����=д��ֵ / 4
            Form1.gss_SNLAccelerationSpeed = Convert.ToInt32(Convert.ToDouble(fm.myTextBoxNUM_SNLAccelerationSpeed.Text) / 4).ToString();
            // �������� ������ ����ֵ ����=д��ֵ / 4
            Form1.gss_SNLHighSpeed = Convert.ToInt32(Convert.ToDouble(fm.myTextBoxNUM_SNLHighSpeed.Text) / 4).ToString();
            // �������� ������ ����ֵ ����=д��ֵ / 4
            Form1.gss_SNLMidSpeed = Convert.ToInt32(Convert.ToDouble(fm.myTextBoxNUM_SNLMidSpeed.Text) / 4).ToString();
            // �������� ������ ����ֵ ����=д��ֵ / 4
            Form1.gss_SNLLowSpeed = Convert.ToInt32(Convert.ToDouble(fm.myTextBoxNUM_SNLLowSpeed.Text) / 4).ToString();
            // �������� ������ ����ֵ ����=д��ֵ / 4
            Form1.gss_SLAccelerationSpeed = Convert.ToInt32(Convert.ToDouble(fm.myTextBoxNUM_SLAccelerationSpeed.Text) / 4).ToString();
            // �������� ������ ����ֵ ����=д��ֵ / 4
            Form1.gss_SLHighSpeed = Convert.ToInt32(Convert.ToDouble(fm.myTextBoxNUM_SLHighSpeed.Text) / 4).ToString();
            // �������� ������ ����ֵ ����=д��ֵ / 4
            Form1.gss_SLMidSpeed = Convert.ToInt32(Convert.ToDouble(fm.myTextBoxNUM_SLMidSpeed.Text) / 4).ToString();
            // �������� ������ ����ֵ ����=д��ֵ / 4
            Form1.gss_SLLowSpeed = Convert.ToInt32(Convert.ToDouble(fm.myTextBoxNUM_SLLowSpeed.Text) / 4).ToString();
            // Ѳ������
            Form1.gss_Cruise = fm.comboBox_Cruise.SelectedIndex.ToString();
            // �綯Ѳ������ת��
            Form1.gss_CruiseSwitch = fm.comboBox_CruiseSwitch.SelectedIndex.ToString();
            // �Զ�Ѳ���ֱ��ȶ�ʱ��=д��ֵ �� 10
            Form1.gss_AutoHoldTime = Convert.ToInt32(Convert.ToDouble(fm.myTextBoxNUM_AutoHoldTime.Text) * 10).ToString();
            // �ֶ�Ѳ����������ʱ��=д��ֵ �� 20
            Form1.gss_ManualHoldTime = Convert.ToInt32(Convert.ToDouble(fm.myTextBoxNUM_ManualHoldTime.Text) * 20).ToString();
            // ��������
            Form1.gss_Boost = fm.comboBox_Boost.SelectedIndex.ToString();
            // ��̬��ʾ
            Form1.gss_ThreeStatusShowSwitch = fm.comboBox_ThreeStatusShowSwitch.SelectedIndex.ToString();
            // ģ���ٶ���ʾ=д��ֵ �� 10
            Form1.gss_SimulationSpeedShow = Convert.ToInt32(Convert.ToDouble(fm.myTextBoxNUM_SimulationSpeedShow.Text) * 10).ToString();
            // ģ�������ʾ=д��ֵ �� 10
            Form1.gss_SimulationCurrentShow = Convert.ToInt32(Convert.ToDouble(fm.myTextBoxNUM_SimulationCurrentShow.Text) * 10).ToString();
            // ɲ������
            Form1.gss_Braking = fm.comboBox_Braking.SelectedIndex.ToString();
            // ����ʵ��
            Form1.gss_MoreSpeed = fm.comboBox_MoreSpeed.SelectedIndex.ToString();

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
            Form1.gss_Pipe = fm.comboBox_Pipe.SelectedIndex.ToString();
            // 6��
            if (fm.comboBox_Pipe.SelectedIndex == 0)
            {
                // �������ֵ=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                Form1.gss_PhaseCurrentPeak = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_PhaseCurrentPeak.Text) * 0.104) * 255 / 5).ToString();
                // ��ת��������ֵ=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                Form1.gss_LockedRotorProtectionCurrentValue = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_LockedRotorProtectionCurrentValue.Text) * 0.104) * 255 / 5).ToString();
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                Form1.gss_SNLAccelerationAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SNLAccelerationAmpere.Text) * 0.104) * 255 / 5).ToString();
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                Form1.gss_SNLHighAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SNLHighAmpere.Text) * 0.104) * 255 / 5).ToString();
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                Form1.gss_SNLMidAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SNLMidAmpere.Text) * 0.104) * 255 / 5).ToString();
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                Form1.gss_SNLLowAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SNLLowAmpere.Text) * 0.104) * 255 / 5).ToString();
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                Form1.gss_SLAccelerationAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SLAccelerationAmpere.Text) * 0.104) * 255 / 5).ToString();
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                Form1.gss_SLHighAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SLHighAmpere.Text) * 0.104) * 255 / 5).ToString();
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                Form1.gss_SLMidAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SLMidAmpere.Text) * 0.104) * 255 / 5).ToString();
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                Form1.gss_SLLowAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SLLowAmpere.Text) * 0.104) * 255 / 5).ToString();
            }
            // 9��
            else if (fm.comboBox_Pipe.SelectedIndex == 1)
            {
                // �������ֵ=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                Form1.gss_PhaseCurrentPeak = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_PhaseCurrentPeak.Text) * 0.104) * 255 / 5).ToString();
                // ��ת��������ֵ=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                Form1.gss_LockedRotorProtectionCurrentValue = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_LockedRotorProtectionCurrentValue.Text) * 0.104) * 255 / 5).ToString();
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                Form1.gss_SNLAccelerationAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SNLAccelerationAmpere.Text) * 0.104) * 255 / 5).ToString();
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                Form1.gss_SNLHighAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SNLHighAmpere.Text) * 0.104) * 255 / 5).ToString();
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                Form1.gss_SNLMidAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SNLMidAmpere.Text) * 0.104) * 255 / 5).ToString();
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                Form1.gss_SNLLowAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SNLLowAmpere.Text) * 0.104) * 255 / 5).ToString();
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                Form1.gss_SLAccelerationAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SLAccelerationAmpere.Text) * 0.104) * 255 / 5).ToString();
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                Form1.gss_SLHighAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SLHighAmpere.Text) * 0.104) * 255 / 5).ToString();
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                Form1.gss_SLMidAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SLMidAmpere.Text) * 0.104) * 255 / 5).ToString();
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                Form1.gss_SLLowAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SLLowAmpere.Text) * 0.104) * 255 / 5).ToString();
            }
            // 12��
            else if (fm.comboBox_Pipe.SelectedIndex == 2)
            {
                // �������ֵ=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                Form1.gss_PhaseCurrentPeak = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_PhaseCurrentPeak.Text) * 0.104) * 255 / 5).ToString();
                // ��ת��������ֵ=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                Form1.gss_LockedRotorProtectionCurrentValue = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_LockedRotorProtectionCurrentValue.Text) * 0.104) * 255 / 5).ToString();
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                Form1.gss_SNLAccelerationAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SNLAccelerationAmpere.Text) * 0.104) * 255 / 5).ToString();
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                Form1.gss_SNLHighAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SNLHighAmpere.Text) * 0.104) * 255 / 5).ToString();
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                Form1.gss_SNLMidAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SNLMidAmpere.Text) * 0.104) * 255 / 5).ToString();
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                Form1.gss_SNLLowAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SNLLowAmpere.Text) * 0.104) * 255 / 5).ToString();
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                Form1.gss_SLAccelerationAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SLAccelerationAmpere.Text) * 0.104) * 255 / 5).ToString();
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                Form1.gss_SLHighAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SLHighAmpere.Text) * 0.104) * 255 / 5).ToString();
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                Form1.gss_SLMidAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SLMidAmpere.Text) * 0.104) * 255 / 5).ToString();
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                Form1.gss_SLLowAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SLLowAmpere.Text) * 0.104) * 255 / 5).ToString();
            }
        }

        // ����д��ֵ
        // �˷���ͨ����ʽ����д��ֵ
        public static void ConfigurationToUI(Form1 fm)
        {
            ///
            /// �����趨��
            ///
            // �������ֵ
            fm.comboBox_MotorSequence.Text = fm.comboBox_MotorSequence.Items[Convert.ToInt32(Form1.gss_MotorSequence)].ToString();
            // �������
            fm.comboBox_HallPhaseValue.Text = fm.comboBox_HallPhaseValue.Items[Convert.ToInt32(Form1.gss_HallPhaseValue)].ToString();
            // ���ٷ�Χ����ֵ=�ֱ������ѹ��д��ֵ����λV����ȷ��С����һλ�� �� 255 / 5 
            fm.myTextBoxNUM_SpeedUpperBound.Text = (Convert.ToDouble(Form1.gss_SpeedUpperBound) * 5 / 255).ToString("0.0");
            // ���ٷ�Χ����ֵ=�ֱ������ѹ��д��ֵ����λV����ȷ��С����һλ�� �� 255 / 5 
            fm.myTextBoxNUM_SpeedLowerBound.Text = (Convert.ToDouble(Form1.gss_SpeedLowerBound) * 5 / 255).ToString("0.0");
            // ���ɳ���������ֵ=�ֱ������ѹ��д��ֵ����λV����ȷ��С����һλ�� �� 255 / 5 
            fm.myTextBoxNUM_ProtectionUpperBound.Text = (Convert.ToDouble(Form1.gss_ProtectionUpperBound) * 5 / 255).ToString("0.0");
            // ���ɳ���������ֵ=�ֱ������ѹ��д��ֵ����λV����ȷ��С����һλ�� �� 255 / 5 
            fm.myTextBoxNUM_ProtectionLowerBound.Text = (Convert.ToDouble(Form1.gss_ProtectionLowerBound) * 5 / 255).ToString("0.0");
            // �������ֵ
            fm.comboBox_BatteryType.Text = fm.comboBox_BatteryType.Items[Convert.ToInt32(Form1.gss_BatteryType)].ToString();
            // ��ع�ѹֵ=BusVolt��д��ֵ�� �� 0.0653 �� 255 / 5
            fm.myTextBoxNUM_BatteryMaximumVoltage.Text = (Convert.ToDouble(Form1.gss_BatteryMaximumVoltage) * 5 / 255 / 0.0653).ToString("0.0");
            // ���Ƿѹֵ=BusVolt��д��ֵ�� �� 0.0653 �� 255 / 5
            fm.myTextBoxNUM_BatteryMinimumVoltage.Text = (Convert.ToDouble(Form1.gss_BatteryMinimumVoltage) * 5 / 255 / 0.0653).ToString("0.0");
            // �����߷�ѹϵ��=д��ֵ �� 10
            fm.myTextBoxNUM_SpeedLimitVoltageDivideCoefficient.Text = (Convert.ToDouble(Form1.gss_SpeedLimitVoltageDivideCoefficient) / 10).ToString("0.0");

            ///
            /// ����ѡ����
            ///
            // �������� ������ ����ֵ ����=д��ֵ / 4
            fm.myTextBoxNUM_SNLAccelerationSpeed.Text = (Convert.ToDouble(Form1.gss_SNLAccelerationSpeed) * 4).ToString("0");
            // �������� ������ ����ֵ ����=д��ֵ / 4
            fm.myTextBoxNUM_SNLHighSpeed.Text = (Convert.ToDouble(Form1.gss_SNLHighSpeed) * 4).ToString("0");
            // �������� ������ ����ֵ ����=д��ֵ / 4
            fm.myTextBoxNUM_SNLMidSpeed.Text = (Convert.ToDouble(Form1.gss_SNLMidSpeed) * 4).ToString("0");
            // �������� ������ ����ֵ ����=д��ֵ / 4
            fm.myTextBoxNUM_SNLLowSpeed.Text = (Convert.ToDouble(Form1.gss_SNLLowSpeed) * 4).ToString("0");
            // �������� ������ ����ֵ ����=д��ֵ / 4
            fm.myTextBoxNUM_SLAccelerationSpeed.Text = (Convert.ToDouble(Form1.gss_SLAccelerationSpeed) * 4).ToString("0");
            // �������� ������ ����ֵ ����=д��ֵ / 4
            fm.myTextBoxNUM_SLHighSpeed.Text = (Convert.ToDouble(Form1.gss_SLHighSpeed) * 4).ToString("0");
            // �������� ������ ����ֵ ����=д��ֵ / 4
            fm.myTextBoxNUM_SLMidSpeed.Text = (Convert.ToDouble(Form1.gss_SLMidSpeed) * 4).ToString("0");
            // �������� ������ ����ֵ ����=д��ֵ / 4
            fm.myTextBoxNUM_SLLowSpeed.Text = (Convert.ToDouble(Form1.gss_SLLowSpeed) * 4).ToString("0");
            // Ѳ������
            fm.comboBox_Cruise.Text = fm.comboBox_Cruise.Items[Convert.ToInt32(Form1.gss_Cruise)].ToString();
            // �綯Ѳ������ת��
            fm.comboBox_CruiseSwitch.Text = fm.comboBox_CruiseSwitch.Items[Convert.ToInt32(Form1.gss_CruiseSwitch)].ToString();
            // �Զ�Ѳ���ֱ��ȶ�ʱ��=д��ֵ �� 10
            fm.myTextBoxNUM_AutoHoldTime.Text = (Convert.ToDouble(Form1.gss_AutoHoldTime) / 10).ToString("0.0");
            // �ֶ�Ѳ����������ʱ��=д��ֵ �� 20
            fm.myTextBoxNUM_ManualHoldTime.Text = (Convert.ToDouble(Form1.gss_ManualHoldTime) / 20).ToString("0.0");
            // ��������
            fm.comboBox_Boost.Text = fm.comboBox_Boost.Items[Convert.ToInt32(Form1.gss_Boost)].ToString();
            // ��̬��ʾ
            fm.comboBox_ThreeStatusShowSwitch.Text = fm.comboBox_ThreeStatusShowSwitch.Items[Convert.ToInt32(Form1.gss_ThreeStatusShowSwitch)].ToString();
            // ģ���ٶ���ʾ=д��ֵ �� 10
            fm.myTextBoxNUM_SimulationSpeedShow.Text = (Convert.ToDouble(Form1.gss_SimulationSpeedShow) / 10).ToString("0.0");
            // ģ�������ʾ=д��ֵ �� 10
            fm.myTextBoxNUM_SimulationCurrentShow.Text = (Convert.ToDouble(Form1.gss_SimulationCurrentShow) / 10).ToString("0.0");
            // ɲ������
            fm.comboBox_Braking.Text = fm.comboBox_Braking.Items[Convert.ToInt32(Form1.gss_Braking)].ToString();
            // ����ʵ��
            fm.comboBox_MoreSpeed.Text = fm.comboBox_MoreSpeed.Items[Convert.ToInt32(Form1.gss_MoreSpeed)].ToString();

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
            fm.comboBox_Pipe.Text = fm.comboBox_Pipe.Items[Convert.ToInt32(Form1.gss_Pipe)].ToString();
            // 6��
            if (Convert.ToInt32(Form1.gss_Pipe) == 0)
            {
                // �������ֵ=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_PhaseCurrentPeak.Text = ((Convert.ToDouble(Form1.gss_PhaseCurrentPeak) * 5 / 255 - 1) / 0.104).ToString("0");
                // ��ת��������ֵ=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_LockedRotorProtectionCurrentValue.Text = ((Convert.ToDouble(Form1.gss_LockedRotorProtectionCurrentValue) * 5 / 255 - 1) / 0.104).ToString("0");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_SNLAccelerationAmpere.Text = ((Convert.ToDouble(Form1.gss_SNLAccelerationAmpere) * 5 / 255 - 1) / 0.104).ToString("0");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_SNLHighAmpere.Text = ((Convert.ToDouble(Form1.gss_SNLHighAmpere) * 5 / 255 - 1) / 0.104).ToString("0");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_SNLMidAmpere.Text = ((Convert.ToDouble(Form1.gss_SNLMidAmpere) * 5 / 255 - 1) / 0.104).ToString("0");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_SNLLowAmpere.Text = ((Convert.ToDouble(Form1.gss_SNLLowAmpere) * 5 / 255 - 1) / 0.104).ToString("0");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_SLAccelerationAmpere.Text = ((Convert.ToDouble(Form1.gss_SLAccelerationAmpere) * 5 / 255 - 1) / 0.104).ToString("0");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_SLHighAmpere.Text = ((Convert.ToDouble(Form1.gss_SLHighAmpere) * 5 / 255 - 1) / 0.104).ToString("0");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_SLMidAmpere.Text = ((Convert.ToDouble(Form1.gss_SLMidAmpere) * 5 / 255 - 1) / 0.104).ToString("0");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_SLLowAmpere.Text = ((Convert.ToDouble(Form1.gss_SLLowAmpere) * 5 / 255 - 1) / 0.104).ToString("0");
            }
            // 9��
            if (Convert.ToInt32(Form1.gss_Pipe) == 1)
            {
                // �������ֵ=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_PhaseCurrentPeak.Text = ((Convert.ToDouble(Form1.gss_PhaseCurrentPeak) * 5 / 255 - 1) / 0.104).ToString("0");
                // ��ת��������ֵ=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_LockedRotorProtectionCurrentValue.Text = ((Convert.ToDouble(Form1.gss_LockedRotorProtectionCurrentValue) * 5 / 255 - 1) / 0.104).ToString("0");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_SNLAccelerationAmpere.Text = ((Convert.ToDouble(Form1.gss_SNLAccelerationAmpere) * 5 / 255 - 1) / 0.104).ToString("0");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_SNLHighAmpere.Text = ((Convert.ToDouble(Form1.gss_SNLHighAmpere) * 5 / 255 - 1) / 0.104).ToString("0");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_SNLMidAmpere.Text = ((Convert.ToDouble(Form1.gss_SNLMidAmpere) * 5 / 255 - 1) / 0.104).ToString("0");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_SNLLowAmpere.Text = ((Convert.ToDouble(Form1.gss_SNLLowAmpere) * 5 / 255 - 1) / 0.104).ToString("0");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_SLAccelerationAmpere.Text = ((Convert.ToDouble(Form1.gss_SLAccelerationAmpere) * 5 / 255 - 1) / 0.104).ToString("0");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_SLHighAmpere.Text = ((Convert.ToDouble(Form1.gss_SLHighAmpere) * 5 / 255 - 1) / 0.104).ToString("0");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_SLMidAmpere.Text = ((Convert.ToDouble(Form1.gss_SLMidAmpere) * 5 / 255 - 1) / 0.104).ToString("0");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_SLLowAmpere.Text = ((Convert.ToDouble(Form1.gss_SLLowAmpere) * 5 / 255 - 1) / 0.104).ToString("0");
            }
            // 12��
            if (Convert.ToInt32(Form1.gss_Pipe) == 2)
            {
                // �������ֵ=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_PhaseCurrentPeak.Text = ((Convert.ToDouble(Form1.gss_PhaseCurrentPeak) * 5 / 255 - 1) / 0.104).ToString("0");
                // ��ת��������ֵ=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_LockedRotorProtectionCurrentValue.Text = ((Convert.ToDouble(Form1.gss_LockedRotorProtectionCurrentValue) * 5 / 255 - 1) / 0.104).ToString("0");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_SNLAccelerationAmpere.Text = ((Convert.ToDouble(Form1.gss_SNLAccelerationAmpere) * 5 / 255 - 1) / 0.104).ToString("0");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_SNLHighAmpere.Text = ((Convert.ToDouble(Form1.gss_SNLHighAmpere) * 5 / 255 - 1) / 0.104).ToString("0");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_SNLMidAmpere.Text = ((Convert.ToDouble(Form1.gss_SNLMidAmpere) * 5 / 255 - 1) / 0.104).ToString("0");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_SNLLowAmpere.Text = ((Convert.ToDouble(Form1.gss_SNLLowAmpere) * 5 / 255 - 1) / 0.104).ToString("0");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_SLAccelerationAmpere.Text = ((Convert.ToDouble(Form1.gss_SLAccelerationAmpere) * 5 / 255 - 1) / 0.104).ToString("0");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_SLHighAmpere.Text = ((Convert.ToDouble(Form1.gss_SLHighAmpere) * 5 / 255 - 1) / 0.104).ToString("0");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_SLMidAmpere.Text = ((Convert.ToDouble(Form1.gss_SLMidAmpere) * 5 / 255 - 1) / 0.104).ToString("0");
                // �������� ������ ����ֵ ����=��1 + BusCurren��д��ֵ�� �� 0.104�� �� 255 / 5
                fm.myTextBoxNUM_SLLowAmpere.Text = ((Convert.ToDouble(Form1.gss_SLLowAmpere) * 5 / 255 - 1) / 0.104).ToString("0");
            }
        }

        // ��ʼ��ȫ�ֱ���
        // �˷�����ʼ��ȫ�ֱ���
        public static void InitParameters(Form1 fm)
        {
            // �������ֵ
            Form1.gss_MotorSequence = "0";
            // ������λ��ֵ
            Form1.gss_HallPhaseValue = "0";
            // ���ٷ�Χ����ֵ
            Form1.gss_SpeedUpperBound = "214";
            // ���ٷ�Χ����ֵ
            Form1.gss_SpeedLowerBound = "56";
            // ���ɳ���������ֵ
            Form1.gss_ProtectionUpperBound = "230";
            // ���ɳ���������ֵ
            Form1.gss_ProtectionLowerBound = "41";
            // �������ֵ
            Form1.gss_PhaseCurrentPeak = "157";
            // �������ֵ
            Form1.gss_BatteryType = "0";
            // ��ع�ѹֵ
            Form1.gss_BatteryMaximumVoltage = "180";
            // ���Ƿѹֵ
            Form1.gss_BatteryMinimumVoltage = "142";
            // ��ת��������ֵ
            Form1.gss_LockedRotorProtectionCurrentValue = "104";
            // �����߷�ѹϵ��
            Form1.gss_SpeedLimitVoltageDivideCoefficient = "17";

            // ��������ѡ��
            Form1.gss_SpeedAndAmpereLimit_Select = "false";
            // �������� ������ ����ֵ ����
            Form1.gss_SNLAccelerationSpeed = "112";
            // �������� ������ ����ֵ ����
            Form1.gss_SNLHighSpeed = "102";
            // �������� ������ ����ֵ ����
            Form1.gss_SNLMidSpeed = "80";
            // �������� ������ ����ֵ ����
            Form1.gss_SNLLowSpeed = "52";
            // �������� ������ ����ֵ ����
            Form1.gss_SNLAccelerationAmpere = "157";
            // �������� ������ ����ֵ ����
            Form1.gss_SNLHighAmpere = "141";
            // �������� ������ ����ֵ ����
            Form1.gss_SNLMidAmpere = "120";
            // �������� ������ ����ֵ ����
            Form1.gss_SNLLowAmpere = "99";
            // �������� ������ ����ֵ ����
            Form1.gss_SLAccelerationSpeed = "68";
            // �������� ������ ����ֵ ����
            Form1.gss_SLHighSpeed = "61";
            // �������� ������ ����ֵ ����
            Form1.gss_SLMidSpeed = "48";
            // �������� ������ ����ֵ ����
            Form1.gss_SLLowSpeed = "32";
            // �������� ������ ����ֵ ����
            Form1.gss_SLAccelerationAmpere = "115";
            // �������� ������ ����ֵ ����
            Form1.gss_SLHighAmpere = "104";
            // �������� ������ ����ֵ ����
            Form1.gss_SLMidAmpere = "93";
            // �������� ������ ����ֵ ����
            Form1.gss_SLLowAmpere = "83";

            // Ѳ������ѡ��
            Form1.gss_Cruise_Select = "false";
            // Ѳ������
            Form1.gss_Cruise = "0";

            // �綯Ѳ������ת��ѡ��
            Form1.gss_CruiseSwitch_Select = "false";
            // �綯Ѳ������ת��
            Form1.gss_CruiseSwitch = "0";

            // �Զ�Ѳ���ֱ��ȶ�ʱ��ѡ��
            Form1.gss_AutoHoldTime_Select = "false";
            // �Զ�Ѳ���ֱ��ȶ�ʱ��
            Form1.gss_AutoHoldTime = "80";

            // �ֶ�Ѳ����������ʱ��ѡ��
            Form1.gss_ManualHoldTime_Select = "false";
            // �ֶ�Ѳ����������ʱ��
            Form1.gss_ManualHoldTime = "40";

            // ��������ѡ��
            Form1.gss_Boost_Select = "false";
            // ��������
            Form1.gss_Boost = "0";

            // ��̬��ʾѡ��
            Form1.gss_ThreeStatusShowSwitch_Select = "false";
            // ��̬��ʾ
            Form1.gss_ThreeStatusShowSwitch = "0";

            // ģ���ٶ���ʾѡ��
            Form1.gss_SimulationSpeedShow_Select = "false";
            // ģ���ٶ���ʾ
            Form1.gss_SimulationSpeedShow = "10";

            // ģ�������ʾѡ��
            Form1.gss_SimulationCurrentShow_Select = "false";
            // ģ�������ʾ
            Form1.gss_SimulationCurrentShow = "50";

            // ɲ������ѡ��
            Form1.gss_Braking_Select = "false";
            // ɲ������
            Form1.gss_Braking = "0";

            // ����ʵ��ѡ��
            Form1.gss_MoreSpeed_Select = "false";
            // ����ʵ��
            Form1.gss_MoreSpeed = "0";

            // ��������1�Ƕ�ֵ
            Form1.gss_HallForwardAngle_1 = "0";
            // ��������2�Ƕ�ֵ
            Form1.gss_HallForwardAngle_2 = "0";
            // ��������3�Ƕ�ֵ
            Form1.gss_HallForwardAngle_3 = "0";
            // ��������4�Ƕ�ֵ
            Form1.gss_HallForwardAngle_4 = "0";
            // ��������5�Ƕ�ֵ
            Form1.gss_HallForwardAngle_5 = "0";
            // ��������6�Ƕ�ֵ
            Form1.gss_HallForwardAngle_6 = "0";
            // �����������1�Ƕ�ֵ
            Form1.gss_HallReverseAngle_1 = "0";
            // �����������2�Ƕ�ֵ
            Form1.gss_HallReverseAngle_2 = "0";
            // �����������3�Ƕ�ֵ
            Form1.gss_HallReverseAngle_3 = "0";
            // �����������4�Ƕ�ֵ
            Form1.gss_HallReverseAngle_4 = "0";
            // �����������5�Ƕ�ֵ
            Form1.gss_HallReverseAngle_5 = "0";
            // �����������6�Ƕ�ֵ
            Form1.gss_HallReverseAngle_6 = "0";
            // ��
            Form1.gss_Pipe = "0";
        }
    }
}