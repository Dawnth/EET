using System;
using System.Collections.Generic;
using System.Text;

namespace EET
{
    class GenerateParameters
    {
        // 初始化全局变量
        // 此方法初始化全局变量
        // I P
        public static void InitParameters(Form1 fm)
        {
            // 电机相序值
            Form1.gss_MotorSequence = "00";
            // 霍尔相位差值
            Form1.gss_HallPhaseValue = "00";
            // 调速范围上限值
            Form1.gss_SpeedUpperBound = "D6";
            // 调速范围下限值
            Form1.gss_SpeedLowerBound = "38";
            // 防飞车保护上限值
            Form1.gss_ProtectionUpperBound = "E6";
            // 防飞车保护下限值
            Form1.gss_ProtectionLowerBound = "29";
            // 相电流峰值
            Form1.gss_PhaseCurrentPeak = "9D";
            // 电池额定电压
            Form1.gss_BatteryType = "00";
            // 电池过压值
            Form1.gss_BatteryMaximumVoltage = "B4";
            // 电池欠压值
            Form1.gss_BatteryMinimumVoltage = "8E";
            // 堵转保护电流值
            Form1.gss_LockedRotorProtectionCurrentValue = "68";
            // 限速线分压系数
            Form1.gss_SpeedLimitVoltageDivideCoefficient = "11";

            // 限速限流选择
            Form1.gss_SpeedAndAmpereLimit_Select = "false";
            // 限速限流 无限速 限速值 提速
            Form1.gss_SNLAccelerationSpeed = "70";
            // 限速限流 无限速 限速值 高速
            Form1.gss_SNLHighSpeed = "66";
            // 限速限流 无限速 限速值 中速
            Form1.gss_SNLMidSpeed = "50";
            // 限速限流 无限速 限速值 低速
            Form1.gss_SNLLowSpeed = "34";
            // 限速限流 无限速 限流值 提速
            Form1.gss_SNLAccelerationAmpere = "9D";
            // 限速限流 无限速 限流值 高速
            Form1.gss_SNLHighAmpere = "8D";
            // 限速限流 无限速 限流值 中速
            Form1.gss_SNLMidAmpere = "78";
            // 限速限流 无限速 限流值 低速
            Form1.gss_SNLLowAmpere = "63";
            // 限速限流 有限速 限速值 提速
            Form1.gss_SLAccelerationSpeed = "44";
            // 限速限流 有限速 限速值 高速
            Form1.gss_SLHighSpeed = "3D";
            // 限速限流 有限速 限速值 中速
            Form1.gss_SLMidSpeed = "30";
            // 限速限流 有限速 限速值 低速
            Form1.gss_SLLowSpeed = "20";
            // 限速限流 有限速 限流值 提速
            Form1.gss_SLAccelerationAmpere = "73";
            // 限速限流 有限速 限流值 高速
            Form1.gss_SLHighAmpere = "68";
            // 限速限流 有限速 限流值 中速
            Form1.gss_SLMidAmpere = "5D";
            // 限速限流 有限速 限流值 低速
            Form1.gss_SLLowAmpere = "53";

            // 巡航功能选择
            Form1.gss_Cruise_Select = "false";
            // 巡航功能
            Form1.gss_Cruise = "00";

            // 电动巡航助力转换选择
            Form1.gss_CruiseSwitch_Select = "false";
            // 电动巡航助力转换
            Form1.gss_CruiseSwitch = "00";

            // 自动巡航手柄稳定时间选择
            Form1.gss_AutoHoldTime_Select = "false";
            // 自动巡航手柄稳定时间
            Form1.gss_AutoHoldTime = "50";

            // 手动巡航按键保持时间选择
            Form1.gss_ManualHoldTime_Select = "false";
            // 手动巡航按键保持时间
            Form1.gss_ManualHoldTime = "28";

            // 助力功能选择
            Form1.gss_Boost_Select = "false";
            // 助力功能
            Form1.gss_Boost = "00";

            // 三态显示选择
            Form1.gss_ThreeStatusShowSwitch_Select = "false";
            // 三态显示
            Form1.gss_ThreeStatusShowSwitch = "00";

            // 模拟速度显示选择
            Form1.gss_SimulationSpeedShow_Select = "false";
            // 模拟速度显示
            Form1.gss_SimulationSpeedShow = "0A";

            // 模拟电流显示选择
            Form1.gss_SimulationCurrentShow_Select = "false";
            // 模拟电流显示
            Form1.gss_SimulationCurrentShow = "32";

            // 刹车功能选择
            Form1.gss_Braking_Select = "false";
            // 刹车功能
            Form1.gss_Braking = "00";

            // 多速实现选择
            Form1.gss_MoreSpeed_Select = "false";
            // 多速实现
            Form1.gss_MoreSpeed = "00";

            // 霍尔边沿1角度值
            Form1.gss_HallForwardAngle_1 = "00";
            // 霍尔边沿2角度值
            Form1.gss_HallForwardAngle_2 = "00";
            // 霍尔边沿3角度值
            Form1.gss_HallForwardAngle_3 = "00";
            // 霍尔边沿4角度值
            Form1.gss_HallForwardAngle_4 = "00";
            // 霍尔边沿5角度值
            Form1.gss_HallForwardAngle_5 = "00";
            // 霍尔边沿6角度值
            Form1.gss_HallForwardAngle_6 = "00";
            // 霍尔反向边沿1角度值
            Form1.gss_HallReverseAngle_1 = "00";
            // 霍尔反向边沿2角度值
            Form1.gss_HallReverseAngle_2 = "00";
            // 霍尔反向边沿3角度值
            Form1.gss_HallReverseAngle_3 = "00";
            // 霍尔反向边沿4角度值
            Form1.gss_HallReverseAngle_4 = "00";
            // 霍尔反向边沿5角度值
            Form1.gss_HallReverseAngle_5 = "00";
            // 霍尔反向边沿6角度值
            Form1.gss_HallReverseAngle_6 = "00";
            // 管
            Form1.gss_Pipe = "00";

            // 最新更新的参数，根据文档增加

            // 电机型号
            Form1.gss_MotorType_Select = "false";
            Form1.gss_MotorType = "00";
            // 启动方式
            Form1.gss_StartStyle = "05";
            // 刹车力度
            Form1.gss_BrakingPotency = "05";
            // 堵转降流
            Form1.gss_LockedRotorCurrentDrop_Select = "false";
            Form1.gss_LockedRotorCurrentDrop = "00";
            // 松手刹防飞车
            Form1.gss_HandBrakeOverrun_Select = "false";
            Form1.gss_HandBrakeOverrun = "00";
            // 滑行反充电
            Form1.gss_SlideCharge_Select = "false";
            Form1.gss_SlideCharge = "00";

            // 36V电池过压值
            Form1.gss_BatteryMaximumVoltage_36V = "89";
            // 36V电池欠压值
            Form1.gss_BatteryMinimumVoltage_36V = "64";

            // 软件版本号
            Form1.gss_SoftwareVersion = "64";
            // 硬件版本好
            Form1.gss_HardwareVersion = "01";
            // 产品型号
            Form1.gss_ProductModel = "01";
            // 电机极数
            Form1.gss_MotorSeries = "08";
            // 共阴共阳
            Form1.gss_SamePolarity = "00";
            // 控制器保护温度
            Form1.gss_ProtectionTemperature = "64";
            // 霍尔有无
            Form1.gss_Hall = "00";
        }

        // 生成全局变量
        // 此方法通过公式计算全局变量
        // U T P
        public static void UIToParameters(Form1 fm)
        {
            ///
            /// 参数设定区
            ///
            // 电机相序值
            Form1.gss_MotorSequence = fm.comboBox_MotorSequence.SelectedIndex.ToString("X2");
            // 霍尔相差
            Form1.gss_HallPhaseValue = fm.comboBox_HallPhaseValue.SelectedIndex.ToString("X2");
            // 调速范围上限值=手柄输入电压（写入值，单位V，精确到小数后一位） × 255 / 5 
            Form1.gss_SpeedUpperBound = Convert.ToInt32(Convert.ToDouble(fm.myTextBoxNUM_SpeedUpperBound.Text) * 255 / 5).ToString("X2");
            // 调速范围下限值=手柄输入电压（写入值，单位V，精确到小数后一位） × 255 / 5 
            Form1.gss_SpeedLowerBound = Convert.ToInt32(Convert.ToDouble(fm.myTextBoxNUM_SpeedLowerBound.Text) * 255 / 5).ToString("X2");
            // 防飞车保护上限值=手柄输入电压（写入值，单位V，精确到小数后一位） × 255 / 5 
            Form1.gss_ProtectionUpperBound = Convert.ToInt32(Convert.ToDouble(fm.myTextBoxNUM_ProtectionUpperBound.Text) * 255 / 5).ToString("X2");
            // 防飞车保护下限值=手柄输入电压（写入值，单位V，精确到小数后一位） × 255 / 5 
            Form1.gss_ProtectionLowerBound = Convert.ToInt32(Convert.ToDouble(fm.myTextBoxNUM_ProtectionLowerBound.Text) * 255 / 5).ToString("X2");
            // 电池额定电压
            Form1.gss_BatteryType = fm.comboBox_BatteryType.SelectedIndex.ToString("X2");
            // 48V电池
            if (fm.comboBox_BatteryType.SelectedIndex == 0)
            {
                // 电池过压值=BusVolt（写入值） × 0.0653 × 255 / 5
                Form1.gss_BatteryMaximumVoltage = Convert.ToInt32(Convert.ToDouble(fm.myTextBoxNUM_BatteryMaximumVoltage.Text) * 0.0653 * 255 / 5).ToString("X2");
                // 电池欠压值=BusVolt（写入值） × 0.0653 × 255 / 5
                Form1.gss_BatteryMinimumVoltage = Convert.ToInt32(Convert.ToDouble(fm.myTextBoxNUM_BatteryMinimumVoltage.Text) * 0.0653 * 255 / 5).ToString("X2");
            }
            // 36V电池
            else
            { 
                // 电池过压值=BusVolt（写入值） × 0.0653 × 255 / 5
                Form1.gss_BatteryMaximumVoltage_36V = Convert.ToInt32(Convert.ToDouble(fm.myTextBoxNUM_BatteryMaximumVoltage.Text) * 0.0653 * 255 / 5).ToString("X2");
                // 电池欠压值=BusVolt（写入值） × 0.0653 × 255 / 5
                Form1.gss_BatteryMinimumVoltage_36V = Convert.ToInt32(Convert.ToDouble(fm.myTextBoxNUM_BatteryMinimumVoltage.Text) * 0.0653 * 255 / 5).ToString("X2");
            }
            // 限速线分压系数=写入值 × 10
            Form1.gss_SpeedLimitVoltageDivideCoefficient = "11";

            ///
            /// 功能选择区
            ///
            // 限速限流 无限速 限速值 提速=写入值 / 4
            Form1.gss_SNLAccelerationSpeed = Convert.ToInt32(Convert.ToDouble(fm.myTextBoxNUM_SNLAccelerationSpeed.Text) / 4).ToString("X2");
            // 限速限流 无限速 限速值 高速=写入值 / 4
            Form1.gss_SNLHighSpeed = Convert.ToInt32(Convert.ToDouble(fm.myTextBoxNUM_SNLHighSpeed.Text) / 4).ToString("X2");
            // 限速限流 无限速 限速值 中速=写入值 / 4
            Form1.gss_SNLMidSpeed = Convert.ToInt32(Convert.ToDouble(fm.myTextBoxNUM_SNLMidSpeed.Text) / 4).ToString("X2");
            // 限速限流 无限速 限速值 低速=写入值 / 4
            Form1.gss_SNLLowSpeed = Convert.ToInt32(Convert.ToDouble(fm.myTextBoxNUM_SNLLowSpeed.Text) / 4).ToString("X2");
            // 限速限流 有限速 限速值 提速=写入值 / 4
            Form1.gss_SLAccelerationSpeed = Convert.ToInt32(Convert.ToDouble(fm.myTextBoxNUM_SLAccelerationSpeed.Text) / 4).ToString("X2");
            // 限速限流 有限速 限速值 高速=写入值 / 4
            Form1.gss_SLHighSpeed = Convert.ToInt32(Convert.ToDouble(fm.myTextBoxNUM_SLHighSpeed.Text) / 4).ToString("X2");
            // 限速限流 有限速 限速值 中速=写入值 / 4
            Form1.gss_SLMidSpeed = Convert.ToInt32(Convert.ToDouble(fm.myTextBoxNUM_SLMidSpeed.Text) / 4).ToString("X2");
            // 限速限流 有限速 限速值 低速=写入值 / 4
            Form1.gss_SLLowSpeed = Convert.ToInt32(Convert.ToDouble(fm.myTextBoxNUM_SLLowSpeed.Text) / 4).ToString("X2");
            // 巡航功能
            Form1.gss_Cruise = fm.comboBox_Cruise.SelectedIndex.ToString("X2");
            // 电动巡航助力转换
            Form1.gss_CruiseSwitch = fm.comboBox_CruiseSwitch.SelectedIndex.ToString("X2");
            // 自动巡航手柄稳定时间=写入值 × 10
            Form1.gss_AutoHoldTime = Convert.ToInt32(Convert.ToDouble(fm.myTextBoxNUM_AutoHoldTime.Text) * 10).ToString("X2");
            // 手动巡航按键保持时间=写入值 × 20
            Form1.gss_ManualHoldTime = Convert.ToInt32(Convert.ToDouble(fm.myTextBoxNUM_ManualHoldTime.Text) * 20).ToString("X2");
            // 助力功能
            Form1.gss_Boost = fm.comboBox_Boost.SelectedIndex.ToString("X2");
            // 三态显示
            Form1.gss_ThreeStatusShowSwitch = fm.comboBox_ThreeStatusShowSwitch.SelectedIndex.ToString("X2");
            // 模拟速度显示=写入值 × 10
            Form1.gss_SimulationSpeedShow = Convert.ToInt32(Convert.ToDouble(fm.myTextBoxNUM_SimulationSpeedShow.Text) * 10).ToString("X2");
            // 模拟电流显示=写入值 × 10
            Form1.gss_SimulationCurrentShow = Convert.ToInt32(Convert.ToDouble(fm.myTextBoxNUM_SimulationCurrentShow.Text) * 10).ToString("X2");
            // 刹车功能
            Form1.gss_Braking = fm.comboBox_Braking.SelectedIndex.ToString("X2");
            // 多速实现
            Form1.gss_MoreSpeed = fm.comboBox_MoreSpeed.SelectedIndex.ToString("X2");

            // CheckBox的选择模式记录
            // 限速限流选择
            Form1.gss_SpeedAndAmpereLimit_Select = fm.checkBox_SpeedAndAmpereLimit_Select.Checked.ToString();
            // 巡航功能选择
            Form1.gss_Cruise_Select = fm.checkBox_Cruise_Select.Checked.ToString();
            // 电动巡航助力转换选择
            Form1.gss_CruiseSwitch_Select = fm.checkBox_CruiseSwitch_Select.Checked.ToString();
            // 自动巡航手柄稳定时间选择
            Form1.gss_AutoHoldTime_Select = fm.checkBox_AutoHoldTime_Select.Checked.ToString();
            // 手动巡航按键保持时间选择
            Form1.gss_ManualHoldTime_Select = fm.checkBox_ManualHoldTime_Select.Checked.ToString();
            // 助力功能选择
            Form1.gss_Boost_Select = fm.checkBox_Boost_Select.Checked.ToString();
            // 三态显示选择
            Form1.gss_ThreeStatusShowSwitch_Select = fm.checkBox_ThreeStatusShowSwitch_Select.Checked.ToString();
            // 模拟速度显示选择
            Form1.gss_SimulationSpeedShow_Select = fm.checkBox_SimulationSpeedShow_Select.Checked.ToString();
            // 模拟电流显示选择
            Form1.gss_SimulationCurrentShow_Select = fm.checkBox_SimulationCurrentShow_Select.Checked.ToString();
            // 刹车功能选择
            Form1.gss_Braking_Select = fm.checkBox_Braking_Select.Checked.ToString();
            // 多速实现选择
            Form1.gss_MoreSpeed_Select = fm.checkBox_MoreSpeed_Select.Checked.ToString();

            // 管
            Form1.gss_Pipe = fm.comboBox_Pipe.SelectedIndex.ToString("X2");
            // 6管
            if (fm.comboBox_Pipe.SelectedIndex == 0)
            {
                // 相电流峰值=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                Form1.gss_PhaseCurrentPeak = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_PhaseCurrentPeak.Text) * 0.104) * 255 / 5).ToString("X2");
                // 堵转保护电流值=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                Form1.gss_LockedRotorProtectionCurrentValue = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_LockedRotorProtectionCurrentValue.Text) * 0.104) * 255 / 5).ToString("X2");
                // 限速限流 无限速 限流值 提速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                Form1.gss_SNLAccelerationAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SNLAccelerationAmpere.Text) * 0.104) * 255 / 5).ToString("X2");
                // 限速限流 无限速 限流值 高速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                Form1.gss_SNLHighAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SNLHighAmpere.Text) * 0.104) * 255 / 5).ToString("X2");
                // 限速限流 无限速 限流值 中速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                Form1.gss_SNLMidAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SNLMidAmpere.Text) * 0.104) * 255 / 5).ToString("X2");
                // 限速限流 无限速 限流值 低速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                Form1.gss_SNLLowAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SNLLowAmpere.Text) * 0.104) * 255 / 5).ToString("X2");
                // 限速限流 有限速 限流值 提速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                Form1.gss_SLAccelerationAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SLAccelerationAmpere.Text) * 0.104) * 255 / 5).ToString("X2");
                // 限速限流 有限速 限流值 高速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                Form1.gss_SLHighAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SLHighAmpere.Text) * 0.104) * 255 / 5).ToString("X2");
                // 限速限流 有限速 限流值 中速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                Form1.gss_SLMidAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SLMidAmpere.Text) * 0.104) * 255 / 5).ToString("X2");
                // 限速限流 有限速 限流值 低速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                Form1.gss_SLLowAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SLLowAmpere.Text) * 0.104) * 255 / 5).ToString("X2");
            }
            // 9管
            else if (fm.comboBox_Pipe.SelectedIndex == 1)
            {
                // 相电流峰值=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                Form1.gss_PhaseCurrentPeak = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_PhaseCurrentPeak.Text) * 0.104) * 255 / 5).ToString("X2");
                // 堵转保护电流值=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                Form1.gss_LockedRotorProtectionCurrentValue = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_LockedRotorProtectionCurrentValue.Text) * 0.104) * 255 / 5).ToString("X2");
                // 限速限流 无限速 限流值 提速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                Form1.gss_SNLAccelerationAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SNLAccelerationAmpere.Text) * 0.104) * 255 / 5).ToString("X2");
                // 限速限流 无限速 限流值 高速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                Form1.gss_SNLHighAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SNLHighAmpere.Text) * 0.104) * 255 / 5).ToString("X2");
                // 限速限流 无限速 限流值 中速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                Form1.gss_SNLMidAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SNLMidAmpere.Text) * 0.104) * 255 / 5).ToString("X2");
                // 限速限流 无限速 限流值 低速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                Form1.gss_SNLLowAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SNLLowAmpere.Text) * 0.104) * 255 / 5).ToString("X2");
                // 限速限流 有限速 限流值 提速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                Form1.gss_SLAccelerationAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SLAccelerationAmpere.Text) * 0.104) * 255 / 5).ToString("X2");
                // 限速限流 有限速 限流值 高速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                Form1.gss_SLHighAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SLHighAmpere.Text) * 0.104) * 255 / 5).ToString("X2");
                // 限速限流 有限速 限流值 中速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                Form1.gss_SLMidAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SLMidAmpere.Text) * 0.104) * 255 / 5).ToString("X2");
                // 限速限流 有限速 限流值 低速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                Form1.gss_SLLowAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SLLowAmpere.Text) * 0.104) * 255 / 5).ToString("X2");
            }
            // 12管
            else if (fm.comboBox_Pipe.SelectedIndex == 2)
            {
                // 相电流峰值=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                Form1.gss_PhaseCurrentPeak = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_PhaseCurrentPeak.Text) * 0.104) * 255 / 5).ToString("X2");
                // 堵转保护电流值=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                Form1.gss_LockedRotorProtectionCurrentValue = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_LockedRotorProtectionCurrentValue.Text) * 0.104) * 255 / 5).ToString("X2");
                // 限速限流 无限速 限流值 提速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                Form1.gss_SNLAccelerationAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SNLAccelerationAmpere.Text) * 0.104) * 255 / 5).ToString("X2");
                // 限速限流 无限速 限流值 高速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                Form1.gss_SNLHighAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SNLHighAmpere.Text) * 0.104) * 255 / 5).ToString("X2");
                // 限速限流 无限速 限流值 中速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                Form1.gss_SNLMidAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SNLMidAmpere.Text) * 0.104) * 255 / 5).ToString("X2");
                // 限速限流 无限速 限流值 低速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                Form1.gss_SNLLowAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SNLLowAmpere.Text) * 0.104) * 255 / 5).ToString("X2");
                // 限速限流 有限速 限流值 提速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                Form1.gss_SLAccelerationAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SLAccelerationAmpere.Text) * 0.104) * 255 / 5).ToString("X2");
                // 限速限流 有限速 限流值 高速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                Form1.gss_SLHighAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SLHighAmpere.Text) * 0.104) * 255 / 5).ToString("X2");
                // 限速限流 有限速 限流值 中速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                Form1.gss_SLMidAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SLMidAmpere.Text) * 0.104) * 255 / 5).ToString("X2");
                // 限速限流 有限速 限流值 低速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                Form1.gss_SLLowAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SLLowAmpere.Text) * 0.104) * 255 / 5).ToString("X2");
            }

            // 最新更新的参数，根据文档增加
            // 电机型号
            Form1.gss_MotorType_Select = fm.checkBox_MotorType_Select.Checked.ToString();
            Form1.gss_MotorType = fm.comboBox_MotorType.SelectedIndex.ToString("X2");
            // 启动方式
            Form1.gss_StartStyle = fm.trackBar_StartStyle.Value.ToString("X2");
            // 刹车力度
            Form1.gss_BrakingPotency = fm.trackBar_BrakingPotency.Value.ToString("X2");
            // 堵转降流
            Form1.gss_LockedRotorCurrentDrop_Select = fm.checkBox_LockedRotorCurrentDrop_Select.Checked.ToString();
            Form1.gss_LockedRotorCurrentDrop = fm.comboBox_LockedRotorCurrentDrop.SelectedIndex.ToString("X2");
            // 松手刹防飞车
            Form1.gss_HandBrakeOverrun_Select = fm.checkBox_HandBrakeOverrun_Select.Checked.ToString();
            Form1.gss_HandBrakeOverrun = fm.comboBox_HandBrakeOverrun.SelectedIndex.ToString("X2");
            // 滑行反充电
            Form1.gss_SlideCharge_Select = fm.checkBox_SlideCharge_Select.Checked.ToString();
            Form1.gss_SlideCharge = fm.comboBox_SlideCharge.SelectedIndex.ToString("X2");

            // 软件版本号
            Form1.gss_SoftwareVersion = Convert.ToInt32(Convert.ToDouble(fm.myTextBoxNUM_SoftwareVersion.Text) * 100).ToString("X2");
            // 硬件版本号
            Form1.gss_HardwareVersion = Convert.ToInt32(fm.myTextBoxNUM_HardwareVersion.Text).ToString("X2");
            // 产品型号
            Form1.gss_ProductModel = Convert.ToInt32(fm.myTextBoxNUM_ProductModel.Text).ToString("X2");
            // 电机极数
            Form1.gss_MotorSeries = Convert.ToInt32(fm.myTextBoxNUM_MotorSeries.Text).ToString("X2");
            // 共阴共阳
            if (fm.myTextBoxNUM_SamePolarity.Text == "共阴")
            {
                Form1.gss_SamePolarity = "00";
            }
            else if (fm.myTextBoxNUM_SamePolarity.Text == "共阳")
            {
                Form1.gss_SamePolarity = "01";
            }
            // 控制器保护温度
            Form1.gss_ProtectionTemperature = Convert.ToInt32(fm.myTextBoxNUM_ProtectionTemperature.Text).ToString("X2");
            // 霍尔有无
            Form1.gss_Hall = fm.comboBox_Hall.SelectedIndex.ToString("X2"); 
        }

        // 生成写入值
        // 此方法通过公式反算写入值
        // P T U
        public static void ParametersToUI(Form1 fm)
        {
            //
            // 参数设定区
            //
            // 电机相序值
            if (Convert.ToInt32(Form1.gss_MotorSequence, 16) < fm.comboBox_MotorSequence.Items.Count)
            {
                fm.comboBox_MotorSequence.Text = fm.comboBox_MotorSequence.Items[Convert.ToInt32(Form1.gss_MotorSequence, 16)].ToString();
            }
            // 霍尔相差
            if (Convert.ToInt32(Form1.gss_HallPhaseValue, 16) < fm.comboBox_HallPhaseValue.Items.Count)
            {
                fm.comboBox_HallPhaseValue.Text = fm.comboBox_HallPhaseValue.Items[Convert.ToInt32(Form1.gss_HallPhaseValue, 16)].ToString();
            }
            // 调速范围上限值=手柄输入电压（写入值，单位V，精确到小数后一位） × 255 / 5 
            fm.myTextBoxNUM_SpeedUpperBound.Text = (Convert.ToDouble(Convert.ToInt32(Form1.gss_SpeedUpperBound, 16)) * 5 / 255).ToString("0.0");
            // 调速范围下限值=手柄输入电压（写入值，单位V，精确到小数后一位） × 255 / 5 
            fm.myTextBoxNUM_SpeedLowerBound.Text = (Convert.ToDouble(Convert.ToInt32(Form1.gss_SpeedLowerBound,16)) * 5 / 255).ToString("0.0");
            // 防飞车保护上限值=手柄输入电压（写入值，单位V，精确到小数后一位） × 255 / 5 
            fm.myTextBoxNUM_ProtectionUpperBound.Text = (Convert.ToDouble(Convert.ToInt32(Form1.gss_ProtectionUpperBound,16)) * 5 / 255).ToString("0.0");
            // 防飞车保护下限值=手柄输入电压（写入值，单位V，精确到小数后一位） × 255 / 5 
            fm.myTextBoxNUM_ProtectionLowerBound.Text = (Convert.ToDouble(Convert.ToInt32(Form1.gss_ProtectionLowerBound,16)) * 5 / 255).ToString("0.0");
            // 电池额定电压
            if (Convert.ToInt32(Form1.gss_BatteryType, 16) < fm.comboBox_BatteryType.Items.Count)
            {
                fm.comboBox_BatteryType.Text = fm.comboBox_BatteryType.Items[Convert.ToInt32(Form1.gss_BatteryType, 16)].ToString();
            }
            // 48v电池
            if (fm.comboBox_BatteryType.SelectedIndex == 0)
            {
                // 电池过压值=BusVolt（写入值） × 0.0653 × 255 / 5
                fm.myTextBoxNUM_BatteryMaximumVoltage.Text = (Convert.ToDouble(Convert.ToInt32(Form1.gss_BatteryMaximumVoltage,16)) * 5 / 255 / 0.0653).ToString("0.0");
                // 电池欠压值=BusVolt（写入值） × 0.0653 × 255 / 5
                fm.myTextBoxNUM_BatteryMinimumVoltage.Text = (Convert.ToDouble(Convert.ToInt32(Form1.gss_BatteryMinimumVoltage,16)) * 5 / 255 / 0.0653).ToString("0.0");
            }
            // 36V电池
            else
            {
                // 电池过压值=BusVolt（写入值） × 0.0653 × 255 / 5
                fm.myTextBoxNUM_BatteryMaximumVoltage.Text = (Convert.ToDouble(Convert.ToInt32(Form1.gss_BatteryMaximumVoltage_36V,16)) * 5 / 255 / 0.0653).ToString("0.0");
                // 电池欠压值=BusVolt（写入值） × 0.0653 × 255 / 5
                fm.myTextBoxNUM_BatteryMinimumVoltage.Text = (Convert.ToDouble(Convert.ToInt32(Form1.gss_BatteryMinimumVoltage_36V,16)) * 5 / 255 / 0.0653).ToString("0.0");
            }
            // 限速线分压系数=写入值 × 10
            // 此处已经取消设置
            //fm.myTextBoxNUM_SpeedLimitVoltageDivideCoefficient.Text = (Convert.ToDouble(Form1.gss_SpeedLimitVoltageDivideCoefficient) / 10).ToString("0.0");

            //
            // 功能选择区
            //
            // 限速限流 无限速 限速值 提速=写入值 / 4
            fm.myTextBoxNUM_SNLAccelerationSpeed.Text = (Convert.ToDouble(Convert.ToInt32(Form1.gss_SNLAccelerationSpeed,16)) * 4).ToString("0");
            // 限速限流 无限速 限速值 高速=写入值 / 4
            fm.myTextBoxNUM_SNLHighSpeed.Text = (Convert.ToDouble(Convert.ToInt32(Form1.gss_SNLHighSpeed,16)) * 4).ToString("0");
            // 限速限流 无限速 限速值 中速=写入值 / 4
            fm.myTextBoxNUM_SNLMidSpeed.Text = (Convert.ToDouble(Convert.ToInt32(Form1.gss_SNLMidSpeed,16)) * 4).ToString("0");
            // 限速限流 无限速 限速值 低速=写入值 / 4
            fm.myTextBoxNUM_SNLLowSpeed.Text = (Convert.ToDouble(Convert.ToInt32(Form1.gss_SNLLowSpeed,16)) * 4).ToString("0");
            // 限速限流 有限速 限速值 提速=写入值 / 4
            fm.myTextBoxNUM_SLAccelerationSpeed.Text = (Convert.ToDouble(Convert.ToInt32(Form1.gss_SLAccelerationSpeed,16)) * 4).ToString("0");
            // 限速限流 有限速 限速值 高速=写入值 / 4
            fm.myTextBoxNUM_SLHighSpeed.Text = (Convert.ToDouble(Convert.ToInt32(Form1.gss_SLHighSpeed,16)) * 4).ToString("0");
            // 限速限流 有限速 限速值 中速=写入值 / 4
            fm.myTextBoxNUM_SLMidSpeed.Text = (Convert.ToDouble(Convert.ToInt32(Form1.gss_SLMidSpeed,16)) * 4).ToString("0");
            // 限速限流 有限速 限速值 低速=写入值 / 4
            fm.myTextBoxNUM_SLLowSpeed.Text = (Convert.ToDouble(Convert.ToInt32(Form1.gss_SLLowSpeed,16)) * 4).ToString("0");
            // 巡航功能
            if (Convert.ToInt32(Form1.gss_Cruise, 16) < fm.comboBox_Cruise.Items.Count)
            {
                fm.comboBox_Cruise.Text = fm.comboBox_Cruise.Items[Convert.ToInt32(Form1.gss_Cruise, 16)].ToString();
            }
            // 电动巡航助力转换
            if (Convert.ToInt32(Form1.gss_CruiseSwitch, 16) < fm.comboBox_CruiseSwitch.Items.Count)
            {
                fm.comboBox_CruiseSwitch.Text = fm.comboBox_CruiseSwitch.Items[Convert.ToInt32(Form1.gss_CruiseSwitch, 16)].ToString();
            }
            // 自动巡航手柄稳定时间=写入值 × 10
            fm.myTextBoxNUM_AutoHoldTime.Text = (Convert.ToDouble(Convert.ToInt32(Form1.gss_AutoHoldTime,16)) / 10).ToString("0");
            // 手动巡航按键保持时间=写入值 × 20
            fm.myTextBoxNUM_ManualHoldTime.Text = (Convert.ToDouble(Convert.ToInt32(Form1.gss_ManualHoldTime,16)) / 20).ToString("0");
            // 助力功能
            if (Convert.ToInt32(Form1.gss_Boost, 16) < fm.comboBox_Boost.Items.Count)
            {
                fm.comboBox_Boost.Text = fm.comboBox_Boost.Items[Convert.ToInt32(Form1.gss_Boost, 16)].ToString();
            }
            // 三态显示
            if (Convert.ToInt32(Form1.gss_ThreeStatusShowSwitch, 16) < fm.comboBox_ThreeStatusShowSwitch.Items.Count)
            {
                fm.comboBox_ThreeStatusShowSwitch.Text = fm.comboBox_ThreeStatusShowSwitch.Items[Convert.ToInt32(Form1.gss_ThreeStatusShowSwitch, 16)].ToString();
            }
            // 模拟速度显示=写入值 × 10
            fm.myTextBoxNUM_SimulationSpeedShow.Text = (Convert.ToDouble(Convert.ToInt32(Form1.gss_SimulationSpeedShow,16)) / 10).ToString("0.0");
            // 模拟电流显示=写入值 × 10
            fm.myTextBoxNUM_SimulationCurrentShow.Text = (Convert.ToDouble(Convert.ToInt32(Form1.gss_SimulationCurrentShow,16)) / 10).ToString("0.0");
            // 刹车功能
            if (Convert.ToInt32(Form1.gss_Braking, 16) < fm.comboBox_Braking.Items.Count)
            {
                fm.comboBox_Braking.Text = fm.comboBox_Braking.Items[Convert.ToInt32(Form1.gss_Braking, 16)].ToString();
            }
            // 多速实现
            if (Convert.ToInt32(Form1.gss_MoreSpeed, 16) < fm.comboBox_MoreSpeed.Items.Count)
            {
                fm.comboBox_MoreSpeed.Text = fm.comboBox_MoreSpeed.Items[Convert.ToInt32(Form1.gss_MoreSpeed, 16)].ToString();
            }

            // CheckBox的选择模式记录
            // 限速限流选择
            fm.checkBox_SpeedAndAmpereLimit_Select.Checked = Convert.ToBoolean(Form1.gss_SpeedAndAmpereLimit_Select);
            // 巡航功能选择
            fm.checkBox_Cruise_Select.Checked = Convert.ToBoolean(Form1.gss_Cruise_Select);
            // 电动巡航助力转换选择
            fm.checkBox_CruiseSwitch_Select.Checked = Convert.ToBoolean(Form1.gss_CruiseSwitch_Select);
            // 自动巡航手柄稳定时间选择
            fm.checkBox_AutoHoldTime_Select.Checked = Convert.ToBoolean(Form1.gss_AutoHoldTime_Select);
            // 手动巡航按键保持时间选择
            fm.checkBox_ManualHoldTime_Select.Checked = Convert.ToBoolean(Form1.gss_ManualHoldTime_Select);
            // 助力功能选择
            fm.checkBox_Boost_Select.Checked = Convert.ToBoolean(Form1.gss_Boost_Select);
            // 三态显示选择
            fm.checkBox_ThreeStatusShowSwitch_Select.Checked = Convert.ToBoolean(Form1.gss_ThreeStatusShowSwitch_Select);
            // 模拟速度显示选择
            fm.checkBox_SimulationSpeedShow_Select.Checked = Convert.ToBoolean(Form1.gss_SimulationSpeedShow_Select);
            // 模拟电流显示选择
            fm.checkBox_SimulationCurrentShow_Select.Checked = Convert.ToBoolean(Form1.gss_SimulationCurrentShow_Select);
            // 刹车功能选择
            fm.checkBox_Braking_Select.Checked = Convert.ToBoolean(Form1.gss_Braking_Select);
            // 多速实现选择
            fm.checkBox_MoreSpeed_Select.Checked = Convert.ToBoolean(Form1.gss_MoreSpeed_Select);

            // 管
            if (Convert.ToInt32(Form1.gss_Pipe, 16) < fm.comboBox_Pipe.Items.Count)
            {
                fm.comboBox_Pipe.Text = fm.comboBox_Pipe.Items[Convert.ToInt32(Form1.gss_Pipe, 16)].ToString();
            }
            // 6管
            if (Convert.ToInt32(Form1.gss_Pipe) == 0)
            {
                // 相电流峰值=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_PhaseCurrentPeak.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_PhaseCurrentPeak,16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // 堵转保护电流值=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_LockedRotorProtectionCurrentValue.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_LockedRotorProtectionCurrentValue,16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // 限速限流 无限速 限流值 提速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_SNLAccelerationAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SNLAccelerationAmpere,16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // 限速限流 无限速 限流值 高速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_SNLHighAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SNLHighAmpere,16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // 限速限流 无限速 限流值 中速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_SNLMidAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SNLMidAmpere,16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // 限速限流 无限速 限流值 低速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_SNLLowAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SNLLowAmpere,16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // 限速限流 有限速 限流值 提速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_SLAccelerationAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SLAccelerationAmpere,16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // 限速限流 有限速 限流值 高速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_SLHighAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SLHighAmpere,16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // 限速限流 有限速 限流值 中速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_SLMidAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SLMidAmpere,16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // 限速限流 有限速 限流值 低速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_SLLowAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SLLowAmpere,16)) * 5 / 255 - 1) / 0.104).ToString("0");
            }
            // 9管
            if (Convert.ToInt32(Form1.gss_Pipe) == 1)
            {
                // 相电流峰值=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_PhaseCurrentPeak.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_PhaseCurrentPeak,16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // 堵转保护电流值=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_LockedRotorProtectionCurrentValue.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_LockedRotorProtectionCurrentValue,16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // 限速限流 无限速 限流值 提速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_SNLAccelerationAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SNLAccelerationAmpere,16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // 限速限流 无限速 限流值 高速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_SNLHighAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SNLHighAmpere,16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // 限速限流 无限速 限流值 中速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_SNLMidAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SNLMidAmpere,16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // 限速限流 无限速 限流值 低速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_SNLLowAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SNLLowAmpere,16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // 限速限流 有限速 限流值 提速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_SLAccelerationAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SLAccelerationAmpere,16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // 限速限流 有限速 限流值 高速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_SLHighAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SLHighAmpere,16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // 限速限流 有限速 限流值 中速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_SLMidAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SLMidAmpere,16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // 限速限流 有限速 限流值 低速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_SLLowAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SLLowAmpere,16)) * 5 / 255 - 1) / 0.104).ToString("0");
            }
            // 12管
            if (Convert.ToInt32(Form1.gss_Pipe) == 2)
            {
                // 相电流峰值=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_PhaseCurrentPeak.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_PhaseCurrentPeak,16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // 堵转保护电流值=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_LockedRotorProtectionCurrentValue.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_LockedRotorProtectionCurrentValue,16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // 限速限流 无限速 限流值 提速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_SNLAccelerationAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SNLAccelerationAmpere,16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // 限速限流 无限速 限流值 高速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_SNLHighAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SNLHighAmpere,16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // 限速限流 无限速 限流值 中速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_SNLMidAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SNLMidAmpere,16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // 限速限流 无限速 限流值 低速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_SNLLowAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SNLLowAmpere,16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // 限速限流 有限速 限流值 提速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_SLAccelerationAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SLAccelerationAmpere,16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // 限速限流 有限速 限流值 高速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_SLHighAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SLHighAmpere,16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // 限速限流 有限速 限流值 中速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_SLMidAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SLMidAmpere,16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // 限速限流 有限速 限流值 低速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_SLLowAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SLLowAmpere, 16)) * 5 / 255 - 1) / 0.104).ToString("0");
            }

            // 最新更新的参数，根据文档增加
            // 电机型号
            fm.checkBox_MotorType_Select.Checked = Convert.ToBoolean(Form1.gss_MotorType_Select);
            if (Convert.ToInt32(Form1.gss_MotorType, 16) < fm.comboBox_MotorType.Items.Count)
            {
                fm.comboBox_MotorType.Text = fm.comboBox_MotorType.Items[Convert.ToInt32(Form1.gss_MotorType, 16)].ToString();
            }
            // 启动方式
            if (Convert.ToInt32(Form1.gss_StartStyle, 16) >= fm.trackBar_StartStyle.Minimum && Convert.ToInt32(Form1.gss_StartStyle, 16) <= fm.trackBar_StartStyle.Maximum)
            {
                fm.trackBar_StartStyle.Value = Convert.ToInt32(Form1.gss_StartStyle, 16);
            }
            // 刹车力度
            if (Convert.ToInt32(Form1.gss_BrakingPotency, 16) >= fm.trackBar_BrakingPotency.Minimum && Convert.ToInt32(Form1.gss_BrakingPotency, 16) <= fm.trackBar_BrakingPotency.Maximum)
            {
                fm.trackBar_BrakingPotency.Value = Convert.ToInt32(Form1.gss_BrakingPotency, 16);
            }
            // 堵转降流
            fm.checkBox_LockedRotorCurrentDrop_Select.Checked = Convert.ToBoolean(Form1.gss_LockedRotorCurrentDrop_Select);
            if (Convert.ToInt32(Form1.gss_LockedRotorCurrentDrop, 16) < fm.comboBox_LockedRotorCurrentDrop.Items.Count)
            {
                fm.comboBox_LockedRotorCurrentDrop.Text = fm.comboBox_LockedRotorCurrentDrop.Items[Convert.ToInt32(Form1.gss_LockedRotorCurrentDrop, 16)].ToString();
            }
            // 松手刹防飞车
            fm.checkBox_HandBrakeOverrun_Select.Checked = Convert.ToBoolean(Form1.gss_HandBrakeOverrun_Select);
            if (Convert.ToInt32(Form1.gss_HandBrakeOverrun, 16) < fm.comboBox_HandBrakeOverrun.Items.Count)
            {
                fm.comboBox_HandBrakeOverrun.Text = fm.comboBox_HandBrakeOverrun.Items[Convert.ToInt32(Form1.gss_HandBrakeOverrun, 16)].ToString();
            }
            // 滑行反充电
            fm.checkBox_SlideCharge_Select.Checked = Convert.ToBoolean(Form1.gss_SlideCharge_Select);
            if (Convert.ToInt32(Form1.gss_SlideCharge, 16) < fm.comboBox_SlideCharge.Items.Count)
            {
                fm.comboBox_SlideCharge.Text = fm.comboBox_SlideCharge.Items[Convert.ToInt32(Form1.gss_SlideCharge, 16)].ToString();
            }

            // 显示区的参数加载
            // 软件版本号
            fm.myTextBoxNUM_SoftwareVersion.Text = (Convert.ToDouble(Convert.ToInt32(Form1.gss_SoftwareVersion, 16)) / 100).ToString("0.00");
            // 硬件版本号
            fm.myTextBoxNUM_HardwareVersion.Text = Convert.ToInt32(Form1.gss_HardwareVersion, 16).ToString();
            // 产品型号
            fm.myTextBoxNUM_ProductModel.Text = Convert.ToInt32(Form1.gss_ProductModel, 16).ToString();
            // 电机极数
            fm.myTextBoxNUM_MotorSeries.Text = Convert.ToInt32(Form1.gss_MotorSeries, 16).ToString();
            // 共阴共阳
            if (Convert.ToInt32(Form1.gss_SamePolarity, 16) == 0)
            {
                fm.myTextBoxNUM_SamePolarity.Text = "共阴";
            }
            else if (Convert.ToInt32(Form1.gss_SamePolarity, 16) == 1)
            {
                fm.myTextBoxNUM_SamePolarity.Text = "共阳";
            }
            // 控制器保护温度
            fm.myTextBoxNUM_ProtectionTemperature.Text = Convert.ToInt32(Form1.gss_ProtectionTemperature, 16).ToString();
            // 霍尔有无
            if (Convert.ToInt32(Form1.gss_Hall, 16) < fm.comboBox_Hall.Items.Count)
            {
                fm.comboBox_Hall.Text = fm.comboBox_Hall.Items[Convert.ToInt32(Form1.gss_Hall, 16)].ToString();
            }
        }

        // 串口专用的读取数据的P T U
        // P T U
        public static void ParametersToUI_SerialPort_Receive(Form1 fm)
        {
            //
            // 参数设定区
            //
            // 电机相序值
            if (Convert.ToInt32(Form1.gss_MotorSequence, 16) < fm.comboBox_MotorSequence.Items.Count)
            {
                fm.comboBox_MotorSequence.Text = fm.comboBox_MotorSequence.Items[Convert.ToInt32(Form1.gss_MotorSequence, 16)].ToString();
            }
            // 霍尔相差
            if (Convert.ToInt32(Form1.gss_HallPhaseValue, 16) < fm.comboBox_HallPhaseValue.Items.Count)
            {
                fm.comboBox_HallPhaseValue.Text = fm.comboBox_HallPhaseValue.Items[Convert.ToInt32(Form1.gss_HallPhaseValue, 16)].ToString();
            }
            // 调速范围上限值=手柄输入电压（写入值，单位V，精确到小数后一位） × 255 / 5 
            fm.myTextBoxNUM_SpeedUpperBound.Text = (Convert.ToDouble(Convert.ToInt32(Form1.gss_SpeedUpperBound, 16)) * 5 / 255).ToString("0.0");
            // 调速范围下限值=手柄输入电压（写入值，单位V，精确到小数后一位） × 255 / 5 
            fm.myTextBoxNUM_SpeedLowerBound.Text = (Convert.ToDouble(Convert.ToInt32(Form1.gss_SpeedLowerBound, 16)) * 5 / 255).ToString("0.0");
            // 防飞车保护上限值=手柄输入电压（写入值，单位V，精确到小数后一位） × 255 / 5 
            fm.myTextBoxNUM_ProtectionUpperBound.Text = (Convert.ToDouble(Convert.ToInt32(Form1.gss_ProtectionUpperBound, 16)) * 5 / 255).ToString("0.0");
            // 防飞车保护下限值=手柄输入电压（写入值，单位V，精确到小数后一位） × 255 / 5 
            fm.myTextBoxNUM_ProtectionLowerBound.Text = (Convert.ToDouble(Convert.ToInt32(Form1.gss_ProtectionLowerBound, 16)) * 5 / 255).ToString("0.0");
            // 电池额定电压
            if (Convert.ToInt32(Form1.gss_BatteryType, 16) < fm.comboBox_BatteryType.Items.Count)
            {
                fm.comboBox_BatteryType.Text = fm.comboBox_BatteryType.Items[Convert.ToInt32(Form1.gss_BatteryType, 16)].ToString();
            }
            // 48v电池
            if (fm.comboBox_BatteryType.SelectedIndex == 0)
            {
                // 电池过压值=BusVolt（写入值） × 0.0653 × 255 / 5
                fm.myTextBoxNUM_BatteryMaximumVoltage.Text = (Convert.ToDouble(Convert.ToInt32(Form1.gss_BatteryMaximumVoltage, 16)) * 5 / 255 / 0.0653).ToString("0.0");
                // 电池欠压值=BusVolt（写入值） × 0.0653 × 255 / 5
                fm.myTextBoxNUM_BatteryMinimumVoltage.Text = (Convert.ToDouble(Convert.ToInt32(Form1.gss_BatteryMinimumVoltage, 16)) * 5 / 255 / 0.0653).ToString("0.0");
            }
            // 36V电池
            else
            {
                // 电池过压值=BusVolt（写入值） × 0.0653 × 255 / 5
                fm.myTextBoxNUM_BatteryMaximumVoltage.Text = (Convert.ToDouble(Convert.ToInt32(Form1.gss_BatteryMaximumVoltage_36V, 16)) * 5 / 255 / 0.0653).ToString("0.0");
                // 电池欠压值=BusVolt（写入值） × 0.0653 × 255 / 5
                fm.myTextBoxNUM_BatteryMinimumVoltage.Text = (Convert.ToDouble(Convert.ToInt32(Form1.gss_BatteryMinimumVoltage_36V, 16)) * 5 / 255 / 0.0653).ToString("0.0");
            }
            // 限速线分压系数=写入值 × 10
            // 此处已经取消设置
            //fm.myTextBoxNUM_SpeedLimitVoltageDivideCoefficient.Text = (Convert.ToDouble(Form1.gss_SpeedLimitVoltageDivideCoefficient) / 10).ToString("0.0");

            //
            // 功能选择区
            //
            // 限速限流 无限速 限速值 提速=写入值 / 4
            fm.myTextBoxNUM_SNLAccelerationSpeed.Text = (Convert.ToDouble(Convert.ToInt32(Form1.gss_SNLAccelerationSpeed, 16)) * 4).ToString("0");
            // 限速限流 无限速 限速值 高速=写入值 / 4
            fm.myTextBoxNUM_SNLHighSpeed.Text = (Convert.ToDouble(Convert.ToInt32(Form1.gss_SNLHighSpeed, 16)) * 4).ToString("0");
            // 限速限流 无限速 限速值 中速=写入值 / 4
            fm.myTextBoxNUM_SNLMidSpeed.Text = (Convert.ToDouble(Convert.ToInt32(Form1.gss_SNLMidSpeed, 16)) * 4).ToString("0");
            // 限速限流 无限速 限速值 低速=写入值 / 4
            fm.myTextBoxNUM_SNLLowSpeed.Text = (Convert.ToDouble(Convert.ToInt32(Form1.gss_SNLLowSpeed, 16)) * 4).ToString("0");
            // 限速限流 有限速 限速值 提速=写入值 / 4
            fm.myTextBoxNUM_SLAccelerationSpeed.Text = (Convert.ToDouble(Convert.ToInt32(Form1.gss_SLAccelerationSpeed, 16)) * 4).ToString("0");
            // 限速限流 有限速 限速值 高速=写入值 / 4
            fm.myTextBoxNUM_SLHighSpeed.Text = (Convert.ToDouble(Convert.ToInt32(Form1.gss_SLHighSpeed, 16)) * 4).ToString("0");
            // 限速限流 有限速 限速值 中速=写入值 / 4
            fm.myTextBoxNUM_SLMidSpeed.Text = (Convert.ToDouble(Convert.ToInt32(Form1.gss_SLMidSpeed, 16)) * 4).ToString("0");
            // 限速限流 有限速 限速值 低速=写入值 / 4
            fm.myTextBoxNUM_SLLowSpeed.Text = (Convert.ToDouble(Convert.ToInt32(Form1.gss_SLLowSpeed, 16)) * 4).ToString("0");
            // 巡航功能
            if (Convert.ToInt32(Form1.gss_Cruise, 16) < fm.comboBox_Cruise.Items.Count)
            {
                fm.comboBox_Cruise.Text = fm.comboBox_Cruise.Items[Convert.ToInt32(Form1.gss_Cruise, 16)].ToString();
            }
            // 电动巡航助力转换
            if (Convert.ToInt32(Form1.gss_CruiseSwitch, 16) < fm.comboBox_CruiseSwitch.Items.Count)
            {
                fm.comboBox_CruiseSwitch.Text = fm.comboBox_CruiseSwitch.Items[Convert.ToInt32(Form1.gss_CruiseSwitch, 16)].ToString();
            }
            // 自动巡航手柄稳定时间=写入值 × 10
            fm.myTextBoxNUM_AutoHoldTime.Text = (Convert.ToDouble(Convert.ToInt32(Form1.gss_AutoHoldTime, 16)) / 10).ToString("0");
            // 手动巡航按键保持时间=写入值 × 20
            fm.myTextBoxNUM_ManualHoldTime.Text = (Convert.ToDouble(Convert.ToInt32(Form1.gss_ManualHoldTime, 16)) / 20).ToString("0");
            // 助力功能
            if (Convert.ToInt32(Form1.gss_Boost, 16) < fm.comboBox_Boost.Items.Count)
            {
                fm.comboBox_Boost.Text = fm.comboBox_Boost.Items[Convert.ToInt32(Form1.gss_Boost, 16)].ToString();
            }
            // 三态显示
            if (Convert.ToInt32(Form1.gss_ThreeStatusShowSwitch, 16) < fm.comboBox_ThreeStatusShowSwitch.Items.Count)
            {
                fm.comboBox_ThreeStatusShowSwitch.Text = fm.comboBox_ThreeStatusShowSwitch.Items[Convert.ToInt32(Form1.gss_ThreeStatusShowSwitch, 16)].ToString();
            }
            // 模拟速度显示=写入值 × 10
            fm.myTextBoxNUM_SimulationSpeedShow.Text = (Convert.ToDouble(Convert.ToInt32(Form1.gss_SimulationSpeedShow, 16)) / 10).ToString("0.0");
            // 模拟电流显示=写入值 × 10
            fm.myTextBoxNUM_SimulationCurrentShow.Text = (Convert.ToDouble(Convert.ToInt32(Form1.gss_SimulationCurrentShow, 16)) / 10).ToString("0.0");
            // 刹车功能
            if (Convert.ToInt32(Form1.gss_Braking, 16) < fm.comboBox_Braking.Items.Count)
            {
                fm.comboBox_Braking.Text = fm.comboBox_Braking.Items[Convert.ToInt32(Form1.gss_Braking, 16)].ToString();
            }
            // 多速实现
            if (Convert.ToInt32(Form1.gss_MoreSpeed, 16) < fm.comboBox_MoreSpeed.Items.Count)
            {
                fm.comboBox_MoreSpeed.Text = fm.comboBox_MoreSpeed.Items[Convert.ToInt32(Form1.gss_MoreSpeed, 16)].ToString();
            }

            // 管
            if (Convert.ToInt32(Form1.gss_Pipe, 16) < fm.comboBox_Pipe.Items.Count)
            {
                fm.comboBox_Pipe.Text = fm.comboBox_Pipe.Items[Convert.ToInt32(Form1.gss_Pipe, 16)].ToString();
            }
            // 6管
            if (Convert.ToInt32(Form1.gss_Pipe) == 0)
            {
                // 相电流峰值=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_PhaseCurrentPeak.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_PhaseCurrentPeak, 16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // 堵转保护电流值=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_LockedRotorProtectionCurrentValue.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_LockedRotorProtectionCurrentValue, 16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // 限速限流 无限速 限流值 提速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_SNLAccelerationAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SNLAccelerationAmpere, 16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // 限速限流 无限速 限流值 高速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_SNLHighAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SNLHighAmpere, 16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // 限速限流 无限速 限流值 中速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_SNLMidAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SNLMidAmpere, 16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // 限速限流 无限速 限流值 低速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_SNLLowAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SNLLowAmpere, 16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // 限速限流 有限速 限流值 提速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_SLAccelerationAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SLAccelerationAmpere, 16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // 限速限流 有限速 限流值 高速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_SLHighAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SLHighAmpere, 16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // 限速限流 有限速 限流值 中速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_SLMidAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SLMidAmpere, 16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // 限速限流 有限速 限流值 低速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_SLLowAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SLLowAmpere, 16)) * 5 / 255 - 1) / 0.104).ToString("0");
            }
            // 9管
            if (Convert.ToInt32(Form1.gss_Pipe) == 1)
            {
                // 相电流峰值=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_PhaseCurrentPeak.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_PhaseCurrentPeak, 16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // 堵转保护电流值=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_LockedRotorProtectionCurrentValue.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_LockedRotorProtectionCurrentValue, 16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // 限速限流 无限速 限流值 提速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_SNLAccelerationAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SNLAccelerationAmpere, 16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // 限速限流 无限速 限流值 高速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_SNLHighAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SNLHighAmpere, 16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // 限速限流 无限速 限流值 中速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_SNLMidAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SNLMidAmpere, 16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // 限速限流 无限速 限流值 低速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_SNLLowAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SNLLowAmpere, 16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // 限速限流 有限速 限流值 提速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_SLAccelerationAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SLAccelerationAmpere, 16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // 限速限流 有限速 限流值 高速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_SLHighAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SLHighAmpere, 16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // 限速限流 有限速 限流值 中速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_SLMidAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SLMidAmpere, 16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // 限速限流 有限速 限流值 低速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_SLLowAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SLLowAmpere, 16)) * 5 / 255 - 1) / 0.104).ToString("0");
            }
            // 12管
            if (Convert.ToInt32(Form1.gss_Pipe) == 2)
            {
                // 相电流峰值=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_PhaseCurrentPeak.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_PhaseCurrentPeak, 16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // 堵转保护电流值=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_LockedRotorProtectionCurrentValue.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_LockedRotorProtectionCurrentValue, 16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // 限速限流 无限速 限流值 提速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_SNLAccelerationAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SNLAccelerationAmpere, 16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // 限速限流 无限速 限流值 高速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_SNLHighAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SNLHighAmpere, 16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // 限速限流 无限速 限流值 中速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_SNLMidAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SNLMidAmpere, 16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // 限速限流 无限速 限流值 低速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_SNLLowAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SNLLowAmpere, 16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // 限速限流 有限速 限流值 提速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_SLAccelerationAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SLAccelerationAmpere, 16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // 限速限流 有限速 限流值 高速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_SLHighAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SLHighAmpere, 16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // 限速限流 有限速 限流值 中速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_SLMidAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SLMidAmpere, 16)) * 5 / 255 - 1) / 0.104).ToString("0");
                // 限速限流 有限速 限流值 低速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_SLLowAmpere.Text = ((Convert.ToDouble(Convert.ToInt32(Form1.gss_SLLowAmpere, 16)) * 5 / 255 - 1) / 0.104).ToString("0");
            }

            // 最新更新的参数，根据文档增加
            // 电机型号
            if (Convert.ToInt32(Form1.gss_MotorType, 16) < fm.comboBox_MotorType.Items.Count)
            {
                fm.comboBox_MotorType.Text = fm.comboBox_MotorType.Items[Convert.ToInt32(Form1.gss_MotorType, 16)].ToString();
            }
            // 启动方式
            if (Convert.ToInt32(Form1.gss_StartStyle, 16) >= fm.trackBar_StartStyle.Minimum && Convert.ToInt32(Form1.gss_StartStyle, 16) <= fm.trackBar_StartStyle.Maximum)
            {
                fm.trackBar_StartStyle.Value = Convert.ToInt32(Form1.gss_StartStyle, 16);
            }
            // 刹车力度
            if (Convert.ToInt32(Form1.gss_BrakingPotency, 16) >= fm.trackBar_BrakingPotency.Minimum && Convert.ToInt32(Form1.gss_BrakingPotency, 16) <= fm.trackBar_BrakingPotency.Maximum)
            {
                fm.trackBar_BrakingPotency.Value = Convert.ToInt32(Form1.gss_BrakingPotency, 16);
            }
            // 堵转降流
            if (Convert.ToInt32(Form1.gss_LockedRotorCurrentDrop, 16) < fm.comboBox_LockedRotorCurrentDrop.Items.Count)
            {
                fm.comboBox_LockedRotorCurrentDrop.Text = fm.comboBox_LockedRotorCurrentDrop.Items[Convert.ToInt32(Form1.gss_LockedRotorCurrentDrop, 16)].ToString();
            }
            // 松手刹防飞车
            if (Convert.ToInt32(Form1.gss_HandBrakeOverrun, 16) < fm.comboBox_HandBrakeOverrun.Items.Count)
            {
                fm.comboBox_HandBrakeOverrun.Text = fm.comboBox_HandBrakeOverrun.Items[Convert.ToInt32(Form1.gss_HandBrakeOverrun, 16)].ToString();
            }
            // 滑行反充电
            if (Convert.ToInt32(Form1.gss_SlideCharge, 16) < fm.comboBox_SlideCharge.Items.Count)
            {
                fm.comboBox_SlideCharge.Text = fm.comboBox_SlideCharge.Items[Convert.ToInt32(Form1.gss_SlideCharge, 16)].ToString();
            }

            // 显示区的参数加载
            // 软件版本号
            fm.myTextBoxNUM_SoftwareVersion.Text = (Convert.ToDouble(Convert.ToInt32(Form1.gss_SoftwareVersion, 16)) / 100).ToString("0.00");
            // 硬件版本号
            fm.myTextBoxNUM_HardwareVersion.Text = Convert.ToInt32(Form1.gss_HardwareVersion, 16).ToString();
            // 产品型号
            fm.myTextBoxNUM_ProductModel.Text = Convert.ToInt32(Form1.gss_ProductModel, 16).ToString();
            // 电机极数
            fm.myTextBoxNUM_MotorSeries.Text = Convert.ToInt32(Form1.gss_MotorSeries, 16).ToString();
            // 共阴共阳
            if (Convert.ToInt32(Form1.gss_SamePolarity, 16) == 0)
            {
                fm.myTextBoxNUM_SamePolarity.Text = "共阴";
            }
            else if (Convert.ToInt32(Form1.gss_SamePolarity, 16) == 1)
            {
                fm.myTextBoxNUM_SamePolarity.Text = "共阳";
            }
            // 控制器保护温度
            fm.myTextBoxNUM_ProtectionTemperature.Text = Convert.ToInt32(Form1.gss_ProtectionTemperature, 16).ToString();
            // 霍尔有无
            if (Convert.ToInt32(Form1.gss_Hall, 16) < fm.comboBox_Hall.Items.Count)
            {
                fm.comboBox_Hall.Text = fm.comboBox_Hall.Items[Convert.ToInt32(Form1.gss_Hall, 16)].ToString();
            }
        }


        // 校验数据是否符合范围要求
        // R B C
        public static void ReadBackCheck(Form1 fm)
        {
            // 调速范围上限值
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

            // 调速范围下限值
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

            // 防飞车保护上限值
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

            // 防飞车保护下限值
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

            // 电池容量 ComboBox
            // 48V电池
            if (fm.comboBox_BatteryType.SelectedIndex == 0)
            {
                // 电池过压保护值
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
                // 电池欠压保护值
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
            // 36V电池
            else if (fm.comboBox_BatteryType.SelectedIndex == 1)
            {
                // 电池过压保护值
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
                // 电池欠压保护值
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

            // 管 ComboBox
            // 此处不做其他数据处理，如果以后管数更改，启用此处
            // 还需更改的地方有如下
            // 1.相电流峰值保护值的范围和系数
            // 2.堵转电流保护值的范围和系数
            // 3.限速限流里的所有限流的范围和系数
            // 6管
            if (fm.comboBox_Pipe.SelectedIndex == 0)
            {
                // 相电流峰值保护值
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
                // 堵转保护电流
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
                // 限速限流 无限速 限流值 提速
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
                // 限速限流 无限速 限流值 高速
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
                // 限速限流 无限速 限流值 中速
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
                // 限速限流 无限速 限流值 低速
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
                // 限速限流 有限速 限流值 提速
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
                // 限速限流 有限速 限流值 高速
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
                // 限速限流 有限速 限流值 中速
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
                // 限速限流 有限速 限流值 低速
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

            // 9管
            else if (fm.comboBox_Pipe.SelectedIndex == 1)
            {
                // 相电流峰值保护值
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
                // 堵转保护电流
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
                // 限速限流 无限速 限流值 提速
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
                // 限速限流 无限速 限流值 高速
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
                // 限速限流 无限速 限流值 中速
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
                // 限速限流 无限速 限流值 低速
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
                // 限速限流 有限速 限流值 提速
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
                // 限速限流 有限速 限流值 高速
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
                // 限速限流 有限速 限流值 中速
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
                // 限速限流 有限速 限流值 低速
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

            // 12管
            else if (fm.comboBox_Pipe.SelectedIndex == 2)
            {
                // 相电流峰值保护值
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
                // 堵转保护电流
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
                // 限速限流 无限速 限流值 提速
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
                // 限速限流 无限速 限流值 高速
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
                // 限速限流 无限速 限流值 中速
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
                // 限速限流 无限速 限流值 低速
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
                // 限速限流 有限速 限流值 提速
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
                // 限速限流 有限速 限流值 高速
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
                // 限速限流 有限速 限流值 中速
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
                // 限速限流 有限速 限流值 低速
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

            // 限速限流 无限速 限速值 提速
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
            // 限速限流 无限速 限速值 高速
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
            // 限速限流 无限速 限速值 中速
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
            // 限速限流 无限速 限速值 低速
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
            // 限速限流 有限速 限速值 提速
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
            // 限速限流 有限速 限速值 高速
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
            // 限速限流 有限速 限速值 中速
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
            // 限速限流 有限速 限速值 低速
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

            // 自动巡航手柄稳定时间
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

            // 手动巡航按键保持时间
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


            // 模拟速度显示
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

            // 模拟电流显示
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
 * C#中ToString格式
 * 
 */

/* 
ToString("0.0")  表示带有一位小数
ToString("0")    表示取整数
ToString("Xy")   X表示转化为十六进制数，y不为空则表示占位数(占位用"0")，y为空则按默认

字符型转换为字符串

// C 货币 

2.5.ToString("C"); // ￥2.50 

// D 10进制数 

25.ToString("D5"); // 25000 

// E 科学型 

25000.ToString("E"); // 2.500000E+005 

// F 固定点 

25.ToString("F2"); // 25.00 

// G 常规 

2.5.ToString("G"); // 2.5 

// N 数字 

2500000.ToString("N"); // 2,500,000.00 

// X 16进制 

255.ToString("X"); // FF 


// C# 日期格式 
DateTime dt = DateTime.Now; 
  
dt.ToString();//2005-11-5 13:21:25 

dt.ToFileTime().ToString();//127756416859912816 

dt.ToFileTimeUtc().ToString();//127756704859912816 

dt.ToLocalTime().ToString();//2005-11-5 21:21:25 

dt.ToLongDateString().ToString();//2005年11月5日 

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

dt.Add(?).ToString();//问号为一个时间段 

dt.Equals("2005-11-6 16:11:04").ToString();//False 

dt.Equals(dt).ToString();//True 

dt.GetHashCode().ToString();//1474088234 

dt.GetType().ToString();//System.DateTime 

dt.GetTypeCode().ToString();//DateTime 

   
dt.GetDateTimeFormats('s')[0].ToString();//2005-11-05T14:06:25 

dt.GetDateTimeFormats('t')[0].ToString();//14:06 

dt.GetDateTimeFormats('y')[0].ToString();//2005年11月 

dt.GetDateTimeFormats('D')[0].ToString();//2005年11月5日 

dt.GetDateTimeFormats('D')[1].ToString();//2005 11 05 

dt.GetDateTimeFormats('D')[2].ToString();//星期六 2005 11 05 

dt.GetDateTimeFormats('D')[3].ToString();//星期六 2005年11月5日 

dt.GetDateTimeFormats('M')[0].ToString();//11月5日 

dt.GetDateTimeFormats('f')[0].ToString();//2005年11月5日 14:06 


dt.GetDateTimeFormats('g')[0].ToString();//2005-11-5 14:06 


dt.GetDateTimeFormats('r')[0].ToString();//Sat, 05 Nov 2005 14:06:25 GMT 

  
string.Format("{0:d}",dt);//2005-11-5 

string.Format("{0:D}",dt);//2005年11月5日 

string.Format("{0:f}",dt);//2005年11月5日 14:23 

string.Format("{0:F}",dt);//2005年11月5日 14:23:23 

string.Format("{0:g}",dt);//2005-11-5 14:23 

string.Format("{0:G}",dt);//2005-11-5 14:23:23 

string.Format("{0:M}",dt);//11月5日 

string.Format("{0:R}",dt);//Sat, 05 Nov 2005 14:23:23 GMT 

string.Format("{0:s}",dt);//2005-11-05T14:23:23 

string.Format("{0:t}",dt);//14:23 

string.Format("{0:T}",dt);//14:23:23 

string.Format("{0:u}",dt);//2005-11-05 14:23:23Z 

string.Format("{0:U}",dt);//2005年11月5日 6:23:23 

string.Format("{0:Y}",dt);//2005年11月 

string.Format("{0}",dt);//2005-11-5 14:23:23 

string.Format("{0:yyyyMMddHHmmssffff}",dt); 
  
  
// 计算2个日期之间的天数差 

DateTime dt1 = Convert.DateTime("2007-8-1");    

DateTime dt2 = Convert.DateTime("2007-8-15");   

TimeSpan span = dt2.Subtract(dt1);             

int dayDiff = span.Days + 1;                    
  
// 计算某年某月的天数 

int days = DateTime.DaysInMonth(2007, 8);       

days = 31;                                      
  
// 给日期增加一天、减少一天 

DateTime dt =DateTime.Now; 

dt.AddDays(1); //增加一天 

dt.AddDays(-1);//减少一天 

日期格式模式 说明
d 月中的某一天。一位数的日期没有前导零。
dd 月中的某一天。一位数的日期有一个前导零。
ddd 周中某天的缩写名称，在 AbbreviatedDayNames 中定义。
dddd 周中某天的完整名称，在 DayNames 中定义。
M 月份数字。一位数的月份没有前导零。
MM 月份数字。一位数的月份有一个前导零。
MMM 月份的缩写名称，在 AbbreviatedMonthNames 中定义。
MMMM 月份的完整名称，在 MonthNames 中定义。
y 不包含纪元的年份。如果不包含纪元的年份小于 10，则显示不具有前导零的年份。
yy 不包含纪元的年份。如果不包含纪元的年份小于 10，则显示具有前导零的年份。
yyyy 包括纪元的四位数的年份。
gg 时期或纪元。如果要设置格式的日期不具有关联的时期或纪元字符串，则忽略该模式。
h 12 小时制的小时。一位数的小时数没有前导零。
hh 12 小时制的小时。一位数的小时数有前导零。
H 24 小时制的小时。一位数的小时数没有前导零。
HH 24 小时制的小时。一位数的小时数有前导零。
m 分钟。一位数的分钟数没有前导零。
mm 分钟。一位数的分钟数有一个前导零。
s 秒。一位数的秒数没有前导零。
ss 秒。一位数的秒数有一个前导零。
f 秒的小数精度为一位。其余数字被截断。
ff 秒的小数精度为两位。其余数字被截断。
fff 秒的小数精度为三位。其余数字被截断。
ffff 秒的小数精度为四位。其余数字被截断。
fffff 秒的小数精度为五位。其余数字被截断。
ffffff 秒的小数精度为六位。其余数字被截断。
fffffff 秒的小数精度为七位。其余数字被截断。
t 在 AMDesignator 或 PMDesignator 中定义的 AM/PM 指示项的第一个字符（如果存在）。
tt 在 AMDesignator 或 PMDesignator 中定义的 AM/PM 指示项（如果存在）。
z 时区偏移量（“+”或“-”后面仅跟小时）。一位数的小时数没有前导零。例如，太平洋标准时间是“-8”。
zz 时区偏移量（“+”或“-”后面仅跟小时）。一位数的小时数有前导零。例如，太平洋标准时间是“-08”。
zzz 完整时区偏移量（“+”或“-”后面跟有小时和分钟）。一位数的小时数和分钟数有前导零。例如，太平洋标准时间是“-08:00”。
: 在 TimeSeparator 中定义的默认时间分隔符。
/ 在 DateSeparator 中定义的默认日期分隔符。
% c 其中 c 是格式模式（如果单独使用）。如果格式模式与原义字符或其他格式模式合并，则可以省略“%”字符。
\ c 其中 c 是任意字符。照原义显示字符。若要显示反斜杠字符，请使用“\\”。

只有上面第二个表中列出的格式模式才能用于创建自定义模式；在第一个表中列出的标准格式字符不能用于创建自定义模式。
自定义模式的长度至少为两个字符；例如，

DateTime.ToString( "d"); // 返回 DateTime 值；“d”是标准短日期模式。 
DateTime.ToString( "%d"); // 返回月中的某天；“%d”是自定义模式。 
DateTime.ToString( "d "); // 返回后面跟有一个空白字符的月中的某天；“d”是自定义模式。 

*/