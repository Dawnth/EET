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
            Form1.gss_MotorSequence = "0";
            // 霍尔相位差值
            Form1.gss_HallPhaseValue = "0";
            // 调速范围上限值
            Form1.gss_SpeedUpperBound = "214";
            // 调速范围下限值
            Form1.gss_SpeedLowerBound = "56";
            // 防飞车保护上限值
            Form1.gss_ProtectionUpperBound = "230";
            // 防飞车保护下限值
            Form1.gss_ProtectionLowerBound = "41";
            // 相电流峰值
            Form1.gss_PhaseCurrentPeak = "157";
            // 电池容量值
            Form1.gss_BatteryType = "0";
            // 电池过压值
            Form1.gss_BatteryMaximumVoltage = "180";
            // 电池欠压值
            Form1.gss_BatteryMinimumVoltage = "142";
            // 堵转保护电流值
            Form1.gss_LockedRotorProtectionCurrentValue = "104";
            // 限速线分压系数
            Form1.gss_SpeedLimitVoltageDivideCoefficient = "17";

            // 限速限流选择
            Form1.gss_SpeedAndAmpereLimit_Select = "false";
            // 限速限流 无限速 限速值 提速
            Form1.gss_SNLAccelerationSpeed = "112";
            // 限速限流 无限速 限速值 高速
            Form1.gss_SNLHighSpeed = "102";
            // 限速限流 无限速 限速值 中速
            Form1.gss_SNLMidSpeed = "80";
            // 限速限流 无限速 限速值 低速
            Form1.gss_SNLLowSpeed = "52";
            // 限速限流 无限速 限流值 提速
            Form1.gss_SNLAccelerationAmpere = "157";
            // 限速限流 无限速 限流值 高速
            Form1.gss_SNLHighAmpere = "141";
            // 限速限流 无限速 限流值 中速
            Form1.gss_SNLMidAmpere = "120";
            // 限速限流 无限速 限流值 低速
            Form1.gss_SNLLowAmpere = "99";
            // 限速限流 有限速 限速值 提速
            Form1.gss_SLAccelerationSpeed = "68";
            // 限速限流 有限速 限速值 高速
            Form1.gss_SLHighSpeed = "61";
            // 限速限流 有限速 限速值 中速
            Form1.gss_SLMidSpeed = "48";
            // 限速限流 有限速 限速值 低速
            Form1.gss_SLLowSpeed = "32";
            // 限速限流 有限速 限流值 提速
            Form1.gss_SLAccelerationAmpere = "115";
            // 限速限流 有限速 限流值 高速
            Form1.gss_SLHighAmpere = "104";
            // 限速限流 有限速 限流值 中速
            Form1.gss_SLMidAmpere = "93";
            // 限速限流 有限速 限流值 低速
            Form1.gss_SLLowAmpere = "83";

            // 巡航功能选择
            Form1.gss_Cruise_Select = "false";
            // 巡航功能
            Form1.gss_Cruise = "0";

            // 电动巡航助力转换选择
            Form1.gss_CruiseSwitch_Select = "false";
            // 电动巡航助力转换
            Form1.gss_CruiseSwitch = "0";

            // 自动巡航手柄稳定时间选择
            Form1.gss_AutoHoldTime_Select = "false";
            // 自动巡航手柄稳定时间
            Form1.gss_AutoHoldTime = "80";

            // 手动巡航按键保持时间选择
            Form1.gss_ManualHoldTime_Select = "false";
            // 手动巡航按键保持时间
            Form1.gss_ManualHoldTime = "40";

            // 助力功能选择
            Form1.gss_Boost_Select = "false";
            // 助力功能
            Form1.gss_Boost = "0";

            // 三态显示选择
            Form1.gss_ThreeStatusShowSwitch_Select = "false";
            // 三态显示
            Form1.gss_ThreeStatusShowSwitch = "0";

            // 模拟速度显示选择
            Form1.gss_SimulationSpeedShow_Select = "false";
            // 模拟速度显示
            Form1.gss_SimulationSpeedShow = "10";

            // 模拟电流显示选择
            Form1.gss_SimulationCurrentShow_Select = "false";
            // 模拟电流显示
            Form1.gss_SimulationCurrentShow = "50";

            // 刹车功能选择
            Form1.gss_Braking_Select = "false";
            // 刹车功能
            Form1.gss_Braking = "0";

            // 多速实现选择
            Form1.gss_MoreSpeed_Select = "false";
            // 多速实现
            Form1.gss_MoreSpeed = "0";

            // 霍尔边沿1角度值
            Form1.gss_HallForwardAngle_1 = "0";
            // 霍尔边沿2角度值
            Form1.gss_HallForwardAngle_2 = "0";
            // 霍尔边沿3角度值
            Form1.gss_HallForwardAngle_3 = "0";
            // 霍尔边沿4角度值
            Form1.gss_HallForwardAngle_4 = "0";
            // 霍尔边沿5角度值
            Form1.gss_HallForwardAngle_5 = "0";
            // 霍尔边沿6角度值
            Form1.gss_HallForwardAngle_6 = "0";
            // 霍尔反向边沿1角度值
            Form1.gss_HallReverseAngle_1 = "0";
            // 霍尔反向边沿2角度值
            Form1.gss_HallReverseAngle_2 = "0";
            // 霍尔反向边沿3角度值
            Form1.gss_HallReverseAngle_3 = "0";
            // 霍尔反向边沿4角度值
            Form1.gss_HallReverseAngle_4 = "0";
            // 霍尔反向边沿5角度值
            Form1.gss_HallReverseAngle_5 = "0";
            // 霍尔反向边沿6角度值
            Form1.gss_HallReverseAngle_6 = "0";
            // 管
            Form1.gss_Pipe = "0";

            // 最新更新的参数，根据文档增加

            // 电机型号
            Form1.gss_MotorType_Select = "false";
            Form1.gss_MotorType = "0";
            // 启动方式
            Form1.gss_StartStyle = "0";
            // 刹车力度
            Form1.gss_BrakingPotency = "0";
            // 堵转降流
            Form1.gss_LockedRotorCurrentDrop_Select = "false";
            Form1.gss_LockedRotorCurrentDrop = "0";
            // 松手刹防飞车
            Form1.gss_HandBrakeOverrun_Select = "false";
            Form1.gss_HandBrakeOverrun = "0";
            // 滑行反充电
            Form1.gss_SlideCharge_Select = "false";
            Form1.gss_SlideCharge = "0";
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
            Form1.gss_MotorSequence = fm.comboBox_MotorSequence.SelectedIndex.ToString();
            // 霍尔相差
            Form1.gss_HallPhaseValue = fm.comboBox_HallPhaseValue.SelectedIndex.ToString();
            // 调速范围上限值=手柄输入电压（写入值，单位V，精确到小数后一位） × 255 / 5 
            Form1.gss_SpeedUpperBound = Convert.ToInt32(Convert.ToDouble(fm.myTextBoxNUM_SpeedUpperBound.Text) * 255 / 5).ToString();
            // 调速范围下限值=手柄输入电压（写入值，单位V，精确到小数后一位） × 255 / 5 
            Form1.gss_SpeedLowerBound = Convert.ToInt32(Convert.ToDouble(fm.myTextBoxNUM_SpeedLowerBound.Text) * 255 / 5).ToString();
            // 防飞车保护上限值=手柄输入电压（写入值，单位V，精确到小数后一位） × 255 / 5 
            Form1.gss_ProtectionUpperBound = Convert.ToInt32(Convert.ToDouble(fm.myTextBoxNUM_ProtectionUpperBound.Text) * 255 / 5).ToString();
            // 防飞车保护下限值=手柄输入电压（写入值，单位V，精确到小数后一位） × 255 / 5 
            Form1.gss_ProtectionLowerBound = Convert.ToInt32(Convert.ToDouble(fm.myTextBoxNUM_ProtectionLowerBound.Text) * 255 / 5).ToString();
            // 电池容量值
            Form1.gss_BatteryType = fm.comboBox_BatteryType.SelectedIndex.ToString();
            // 电池过压值=BusVolt（写入值） × 0.0653 × 255 / 5
            Form1.gss_BatteryMaximumVoltage = Convert.ToInt32(Convert.ToDouble(fm.myTextBoxNUM_BatteryMaximumVoltage.Text) * 0.0653 * 255 / 5).ToString();
            // 电池欠压值=BusVolt（写入值） × 0.0653 × 255 / 5
            Form1.gss_BatteryMinimumVoltage = Convert.ToInt32(Convert.ToDouble(fm.myTextBoxNUM_BatteryMinimumVoltage.Text) * 0.0653 * 255 / 5).ToString();
            // 限速线分压系数=写入值 × 10
            Form1.gss_SpeedLimitVoltageDivideCoefficient = "17";

            ///
            /// 功能选择区
            ///
            // 限速限流 无限速 限速值 提速=写入值 / 4
            Form1.gss_SNLAccelerationSpeed = Convert.ToInt32(Convert.ToDouble(fm.myTextBoxNUM_SNLAccelerationSpeed.Text) / 4).ToString();
            // 限速限流 无限速 限速值 高速=写入值 / 4
            Form1.gss_SNLHighSpeed = Convert.ToInt32(Convert.ToDouble(fm.myTextBoxNUM_SNLHighSpeed.Text) / 4).ToString();
            // 限速限流 无限速 限速值 中速=写入值 / 4
            Form1.gss_SNLMidSpeed = Convert.ToInt32(Convert.ToDouble(fm.myTextBoxNUM_SNLMidSpeed.Text) / 4).ToString();
            // 限速限流 无限速 限速值 低速=写入值 / 4
            Form1.gss_SNLLowSpeed = Convert.ToInt32(Convert.ToDouble(fm.myTextBoxNUM_SNLLowSpeed.Text) / 4).ToString();
            // 限速限流 有限速 限速值 提速=写入值 / 4
            Form1.gss_SLAccelerationSpeed = Convert.ToInt32(Convert.ToDouble(fm.myTextBoxNUM_SLAccelerationSpeed.Text) / 4).ToString();
            // 限速限流 有限速 限速值 高速=写入值 / 4
            Form1.gss_SLHighSpeed = Convert.ToInt32(Convert.ToDouble(fm.myTextBoxNUM_SLHighSpeed.Text) / 4).ToString();
            // 限速限流 有限速 限速值 中速=写入值 / 4
            Form1.gss_SLMidSpeed = Convert.ToInt32(Convert.ToDouble(fm.myTextBoxNUM_SLMidSpeed.Text) / 4).ToString();
            // 限速限流 有限速 限速值 低速=写入值 / 4
            Form1.gss_SLLowSpeed = Convert.ToInt32(Convert.ToDouble(fm.myTextBoxNUM_SLLowSpeed.Text) / 4).ToString();
            // 巡航功能
            Form1.gss_Cruise = fm.comboBox_Cruise.SelectedIndex.ToString();
            // 电动巡航助力转换
            Form1.gss_CruiseSwitch = fm.comboBox_CruiseSwitch.SelectedIndex.ToString();
            // 自动巡航手柄稳定时间=写入值 × 10
            Form1.gss_AutoHoldTime = Convert.ToInt32(Convert.ToDouble(fm.myTextBoxNUM_AutoHoldTime.Text) * 10).ToString();
            // 手动巡航按键保持时间=写入值 × 20
            Form1.gss_ManualHoldTime = Convert.ToInt32(Convert.ToDouble(fm.myTextBoxNUM_ManualHoldTime.Text) * 20).ToString();
            // 助力功能
            Form1.gss_Boost = fm.comboBox_Boost.SelectedIndex.ToString();
            // 三态显示
            Form1.gss_ThreeStatusShowSwitch = fm.comboBox_ThreeStatusShowSwitch.SelectedIndex.ToString();
            // 模拟速度显示=写入值 × 10
            Form1.gss_SimulationSpeedShow = Convert.ToInt32(Convert.ToDouble(fm.myTextBoxNUM_SimulationSpeedShow.Text) * 10).ToString();
            // 模拟电流显示=写入值 × 10
            Form1.gss_SimulationCurrentShow = Convert.ToInt32(Convert.ToDouble(fm.myTextBoxNUM_SimulationCurrentShow.Text) * 10).ToString();
            // 刹车功能
            Form1.gss_Braking = fm.comboBox_Braking.SelectedIndex.ToString();
            // 多速实现
            Form1.gss_MoreSpeed = fm.comboBox_MoreSpeed.SelectedIndex.ToString();

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
            Form1.gss_Pipe = fm.comboBox_Pipe.SelectedIndex.ToString();
            // 6管
            if (fm.comboBox_Pipe.SelectedIndex == 0)
            {
                // 相电流峰值=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                Form1.gss_PhaseCurrentPeak = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_PhaseCurrentPeak.Text) * 0.104) * 255 / 5).ToString();
                // 堵转保护电流值=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                Form1.gss_LockedRotorProtectionCurrentValue = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_LockedRotorProtectionCurrentValue.Text) * 0.104) * 255 / 5).ToString();
                // 限速限流 无限速 限流值 提速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                Form1.gss_SNLAccelerationAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SNLAccelerationAmpere.Text) * 0.104) * 255 / 5).ToString();
                // 限速限流 无限速 限流值 高速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                Form1.gss_SNLHighAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SNLHighAmpere.Text) * 0.104) * 255 / 5).ToString();
                // 限速限流 无限速 限流值 中速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                Form1.gss_SNLMidAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SNLMidAmpere.Text) * 0.104) * 255 / 5).ToString();
                // 限速限流 无限速 限流值 低速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                Form1.gss_SNLLowAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SNLLowAmpere.Text) * 0.104) * 255 / 5).ToString();
                // 限速限流 有限速 限流值 提速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                Form1.gss_SLAccelerationAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SLAccelerationAmpere.Text) * 0.104) * 255 / 5).ToString();
                // 限速限流 有限速 限流值 高速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                Form1.gss_SLHighAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SLHighAmpere.Text) * 0.104) * 255 / 5).ToString();
                // 限速限流 有限速 限流值 中速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                Form1.gss_SLMidAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SLMidAmpere.Text) * 0.104) * 255 / 5).ToString();
                // 限速限流 有限速 限流值 低速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                Form1.gss_SLLowAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SLLowAmpere.Text) * 0.104) * 255 / 5).ToString();
            }
            // 9管
            else if (fm.comboBox_Pipe.SelectedIndex == 1)
            {
                // 相电流峰值=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                Form1.gss_PhaseCurrentPeak = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_PhaseCurrentPeak.Text) * 0.104) * 255 / 5).ToString();
                // 堵转保护电流值=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                Form1.gss_LockedRotorProtectionCurrentValue = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_LockedRotorProtectionCurrentValue.Text) * 0.104) * 255 / 5).ToString();
                // 限速限流 无限速 限流值 提速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                Form1.gss_SNLAccelerationAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SNLAccelerationAmpere.Text) * 0.104) * 255 / 5).ToString();
                // 限速限流 无限速 限流值 高速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                Form1.gss_SNLHighAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SNLHighAmpere.Text) * 0.104) * 255 / 5).ToString();
                // 限速限流 无限速 限流值 中速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                Form1.gss_SNLMidAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SNLMidAmpere.Text) * 0.104) * 255 / 5).ToString();
                // 限速限流 无限速 限流值 低速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                Form1.gss_SNLLowAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SNLLowAmpere.Text) * 0.104) * 255 / 5).ToString();
                // 限速限流 有限速 限流值 提速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                Form1.gss_SLAccelerationAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SLAccelerationAmpere.Text) * 0.104) * 255 / 5).ToString();
                // 限速限流 有限速 限流值 高速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                Form1.gss_SLHighAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SLHighAmpere.Text) * 0.104) * 255 / 5).ToString();
                // 限速限流 有限速 限流值 中速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                Form1.gss_SLMidAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SLMidAmpere.Text) * 0.104) * 255 / 5).ToString();
                // 限速限流 有限速 限流值 低速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                Form1.gss_SLLowAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SLLowAmpere.Text) * 0.104) * 255 / 5).ToString();
            }
            // 12管
            else if (fm.comboBox_Pipe.SelectedIndex == 2)
            {
                // 相电流峰值=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                Form1.gss_PhaseCurrentPeak = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_PhaseCurrentPeak.Text) * 0.104) * 255 / 5).ToString();
                // 堵转保护电流值=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                Form1.gss_LockedRotorProtectionCurrentValue = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_LockedRotorProtectionCurrentValue.Text) * 0.104) * 255 / 5).ToString();
                // 限速限流 无限速 限流值 提速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                Form1.gss_SNLAccelerationAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SNLAccelerationAmpere.Text) * 0.104) * 255 / 5).ToString();
                // 限速限流 无限速 限流值 高速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                Form1.gss_SNLHighAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SNLHighAmpere.Text) * 0.104) * 255 / 5).ToString();
                // 限速限流 无限速 限流值 中速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                Form1.gss_SNLMidAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SNLMidAmpere.Text) * 0.104) * 255 / 5).ToString();
                // 限速限流 无限速 限流值 低速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                Form1.gss_SNLLowAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SNLLowAmpere.Text) * 0.104) * 255 / 5).ToString();
                // 限速限流 有限速 限流值 提速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                Form1.gss_SLAccelerationAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SLAccelerationAmpere.Text) * 0.104) * 255 / 5).ToString();
                // 限速限流 有限速 限流值 高速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                Form1.gss_SLHighAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SLHighAmpere.Text) * 0.104) * 255 / 5).ToString();
                // 限速限流 有限速 限流值 中速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                Form1.gss_SLMidAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SLMidAmpere.Text) * 0.104) * 255 / 5).ToString();
                // 限速限流 有限速 限流值 低速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                Form1.gss_SLLowAmpere = Convert.ToInt32((1 + Convert.ToDouble(fm.myTextBoxNUM_SLLowAmpere.Text) * 0.104) * 255 / 5).ToString();
            }

            // 最新更新的参数，根据文档增加
            // 电机型号
            Form1.gss_MotorType_Select = fm.checkBox_MotorType_Select.Checked.ToString();
            Form1.gss_MotorType = fm.comboBox_MotorType.SelectedIndex.ToString();
            // 启动方式
            Form1.gss_StartStyle = fm.trackBar_StartStyle.Value.ToString();
            // 刹车力度
            Form1.gss_BrakingPotency = fm.trackBar_BrakingPotency.Value.ToString();
            // 堵转降流
            Form1.gss_LockedRotorCurrentDrop_Select = fm.checkBox_LockedRotorCurrentDrop_Select.Checked.ToString();
            Form1.gss_LockedRotorCurrentDrop = fm.comboBox_LockedRotorCurrentDrop.SelectedIndex.ToString();
            // 松手刹防飞车
            Form1.gss_HandBrakeOverrun_Select = fm.checkBox_HandBrakeOverrun_Select.Checked.ToString();
            Form1.gss_HandBrakeOverrun = fm.comboBox_HandBrakeOverrun.SelectedIndex.ToString();
            // 滑行反充电
            Form1.gss_SlideCharge_Select = fm.checkBox_SlideCharge_Select.Checked.ToString();
            Form1.gss_SlideCharge = fm.comboBox_SlideCharge.SelectedIndex.ToString();
        }

        // 生成写入值
        // 此方法通过公式反算写入值
        // P T U
        public static void ParametersToUI(Form1 fm)
        {
            ///
            /// 参数设定区
            ///
            // 电机相序值
            fm.comboBox_MotorSequence.Text = fm.comboBox_MotorSequence.Items[Convert.ToInt32(Form1.gss_MotorSequence)].ToString();
            // 霍尔相差
            fm.comboBox_HallPhaseValue.Text = fm.comboBox_HallPhaseValue.Items[Convert.ToInt32(Form1.gss_HallPhaseValue)].ToString();
            // 调速范围上限值=手柄输入电压（写入值，单位V，精确到小数后一位） × 255 / 5 
            fm.myTextBoxNUM_SpeedUpperBound.Text = (Convert.ToDouble(Form1.gss_SpeedUpperBound) * 5 / 255).ToString("0.0");
            // 调速范围下限值=手柄输入电压（写入值，单位V，精确到小数后一位） × 255 / 5 
            fm.myTextBoxNUM_SpeedLowerBound.Text = (Convert.ToDouble(Form1.gss_SpeedLowerBound) * 5 / 255).ToString("0.0");
            // 防飞车保护上限值=手柄输入电压（写入值，单位V，精确到小数后一位） × 255 / 5 
            fm.myTextBoxNUM_ProtectionUpperBound.Text = (Convert.ToDouble(Form1.gss_ProtectionUpperBound) * 5 / 255).ToString("0.0");
            // 防飞车保护下限值=手柄输入电压（写入值，单位V，精确到小数后一位） × 255 / 5 
            fm.myTextBoxNUM_ProtectionLowerBound.Text = (Convert.ToDouble(Form1.gss_ProtectionLowerBound) * 5 / 255).ToString("0.0");
            // 电池容量值
            fm.comboBox_BatteryType.Text = fm.comboBox_BatteryType.Items[Convert.ToInt32(Form1.gss_BatteryType)].ToString();
            // 电池过压值=BusVolt（写入值） × 0.0653 × 255 / 5
            fm.myTextBoxNUM_BatteryMaximumVoltage.Text = (Convert.ToDouble(Form1.gss_BatteryMaximumVoltage) * 5 / 255 / 0.0653).ToString("0.0");
            // 电池欠压值=BusVolt（写入值） × 0.0653 × 255 / 5
            fm.myTextBoxNUM_BatteryMinimumVoltage.Text = (Convert.ToDouble(Form1.gss_BatteryMinimumVoltage) * 5 / 255 / 0.0653).ToString("0.0");
            // 限速线分压系数=写入值 × 10
            //fm.myTextBoxNUM_SpeedLimitVoltageDivideCoefficient.Text = (Convert.ToDouble(Form1.gss_SpeedLimitVoltageDivideCoefficient) / 10).ToString("0.0");

            ///
            /// 功能选择区
            ///
            // 限速限流 无限速 限速值 提速=写入值 / 4
            fm.myTextBoxNUM_SNLAccelerationSpeed.Text = (Convert.ToDouble(Form1.gss_SNLAccelerationSpeed) * 4).ToString("0");
            // 限速限流 无限速 限速值 高速=写入值 / 4
            fm.myTextBoxNUM_SNLHighSpeed.Text = (Convert.ToDouble(Form1.gss_SNLHighSpeed) * 4).ToString("0");
            // 限速限流 无限速 限速值 中速=写入值 / 4
            fm.myTextBoxNUM_SNLMidSpeed.Text = (Convert.ToDouble(Form1.gss_SNLMidSpeed) * 4).ToString("0");
            // 限速限流 无限速 限速值 低速=写入值 / 4
            fm.myTextBoxNUM_SNLLowSpeed.Text = (Convert.ToDouble(Form1.gss_SNLLowSpeed) * 4).ToString("0");
            // 限速限流 有限速 限速值 提速=写入值 / 4
            fm.myTextBoxNUM_SLAccelerationSpeed.Text = (Convert.ToDouble(Form1.gss_SLAccelerationSpeed) * 4).ToString("0");
            // 限速限流 有限速 限速值 高速=写入值 / 4
            fm.myTextBoxNUM_SLHighSpeed.Text = (Convert.ToDouble(Form1.gss_SLHighSpeed) * 4).ToString("0");
            // 限速限流 有限速 限速值 中速=写入值 / 4
            fm.myTextBoxNUM_SLMidSpeed.Text = (Convert.ToDouble(Form1.gss_SLMidSpeed) * 4).ToString("0");
            // 限速限流 有限速 限速值 低速=写入值 / 4
            fm.myTextBoxNUM_SLLowSpeed.Text = (Convert.ToDouble(Form1.gss_SLLowSpeed) * 4).ToString("0");
            // 巡航功能
            fm.comboBox_Cruise.Text = fm.comboBox_Cruise.Items[Convert.ToInt32(Form1.gss_Cruise)].ToString();
            // 电动巡航助力转换
            fm.comboBox_CruiseSwitch.Text = fm.comboBox_CruiseSwitch.Items[Convert.ToInt32(Form1.gss_CruiseSwitch)].ToString();
            // 自动巡航手柄稳定时间=写入值 × 10
            fm.myTextBoxNUM_AutoHoldTime.Text = (Convert.ToDouble(Form1.gss_AutoHoldTime) / 10).ToString("0");
            // 手动巡航按键保持时间=写入值 × 20
            fm.myTextBoxNUM_ManualHoldTime.Text = (Convert.ToDouble(Form1.gss_ManualHoldTime) / 20).ToString("0");
            // 助力功能
            fm.comboBox_Boost.Text = fm.comboBox_Boost.Items[Convert.ToInt32(Form1.gss_Boost)].ToString();
            // 三态显示
            fm.comboBox_ThreeStatusShowSwitch.Text = fm.comboBox_ThreeStatusShowSwitch.Items[Convert.ToInt32(Form1.gss_ThreeStatusShowSwitch)].ToString();
            // 模拟速度显示=写入值 × 10
            fm.myTextBoxNUM_SimulationSpeedShow.Text = (Convert.ToDouble(Form1.gss_SimulationSpeedShow) / 10).ToString("0.0");
            // 模拟电流显示=写入值 × 10
            fm.myTextBoxNUM_SimulationCurrentShow.Text = (Convert.ToDouble(Form1.gss_SimulationCurrentShow) / 10).ToString("0.0");
            // 刹车功能
            fm.comboBox_Braking.Text = fm.comboBox_Braking.Items[Convert.ToInt32(Form1.gss_Braking)].ToString();
            // 多速实现
            fm.comboBox_MoreSpeed.Text = fm.comboBox_MoreSpeed.Items[Convert.ToInt32(Form1.gss_MoreSpeed)].ToString();

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
            fm.comboBox_Pipe.Text = fm.comboBox_Pipe.Items[Convert.ToInt32(Form1.gss_Pipe)].ToString();
            // 6管
            if (Convert.ToInt32(Form1.gss_Pipe) == 0)
            {
                // 相电流峰值=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_PhaseCurrentPeak.Text = ((Convert.ToDouble(Form1.gss_PhaseCurrentPeak) * 5 / 255 - 1) / 0.104).ToString("0");
                // 堵转保护电流值=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_LockedRotorProtectionCurrentValue.Text = ((Convert.ToDouble(Form1.gss_LockedRotorProtectionCurrentValue) * 5 / 255 - 1) / 0.104).ToString("0");
                // 限速限流 无限速 限流值 提速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_SNLAccelerationAmpere.Text = ((Convert.ToDouble(Form1.gss_SNLAccelerationAmpere) * 5 / 255 - 1) / 0.104).ToString("0");
                // 限速限流 无限速 限流值 高速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_SNLHighAmpere.Text = ((Convert.ToDouble(Form1.gss_SNLHighAmpere) * 5 / 255 - 1) / 0.104).ToString("0");
                // 限速限流 无限速 限流值 中速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_SNLMidAmpere.Text = ((Convert.ToDouble(Form1.gss_SNLMidAmpere) * 5 / 255 - 1) / 0.104).ToString("0");
                // 限速限流 无限速 限流值 低速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_SNLLowAmpere.Text = ((Convert.ToDouble(Form1.gss_SNLLowAmpere) * 5 / 255 - 1) / 0.104).ToString("0");
                // 限速限流 有限速 限流值 提速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_SLAccelerationAmpere.Text = ((Convert.ToDouble(Form1.gss_SLAccelerationAmpere) * 5 / 255 - 1) / 0.104).ToString("0");
                // 限速限流 有限速 限流值 高速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_SLHighAmpere.Text = ((Convert.ToDouble(Form1.gss_SLHighAmpere) * 5 / 255 - 1) / 0.104).ToString("0");
                // 限速限流 有限速 限流值 中速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_SLMidAmpere.Text = ((Convert.ToDouble(Form1.gss_SLMidAmpere) * 5 / 255 - 1) / 0.104).ToString("0");
                // 限速限流 有限速 限流值 低速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_SLLowAmpere.Text = ((Convert.ToDouble(Form1.gss_SLLowAmpere) * 5 / 255 - 1) / 0.104).ToString("0");
            }
            // 9管
            if (Convert.ToInt32(Form1.gss_Pipe) == 1)
            {
                // 相电流峰值=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_PhaseCurrentPeak.Text = ((Convert.ToDouble(Form1.gss_PhaseCurrentPeak) * 5 / 255 - 1) / 0.104).ToString("0");
                // 堵转保护电流值=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_LockedRotorProtectionCurrentValue.Text = ((Convert.ToDouble(Form1.gss_LockedRotorProtectionCurrentValue) * 5 / 255 - 1) / 0.104).ToString("0");
                // 限速限流 无限速 限流值 提速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_SNLAccelerationAmpere.Text = ((Convert.ToDouble(Form1.gss_SNLAccelerationAmpere) * 5 / 255 - 1) / 0.104).ToString("0");
                // 限速限流 无限速 限流值 高速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_SNLHighAmpere.Text = ((Convert.ToDouble(Form1.gss_SNLHighAmpere) * 5 / 255 - 1) / 0.104).ToString("0");
                // 限速限流 无限速 限流值 中速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_SNLMidAmpere.Text = ((Convert.ToDouble(Form1.gss_SNLMidAmpere) * 5 / 255 - 1) / 0.104).ToString("0");
                // 限速限流 无限速 限流值 低速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_SNLLowAmpere.Text = ((Convert.ToDouble(Form1.gss_SNLLowAmpere) * 5 / 255 - 1) / 0.104).ToString("0");
                // 限速限流 有限速 限流值 提速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_SLAccelerationAmpere.Text = ((Convert.ToDouble(Form1.gss_SLAccelerationAmpere) * 5 / 255 - 1) / 0.104).ToString("0");
                // 限速限流 有限速 限流值 高速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_SLHighAmpere.Text = ((Convert.ToDouble(Form1.gss_SLHighAmpere) * 5 / 255 - 1) / 0.104).ToString("0");
                // 限速限流 有限速 限流值 中速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_SLMidAmpere.Text = ((Convert.ToDouble(Form1.gss_SLMidAmpere) * 5 / 255 - 1) / 0.104).ToString("0");
                // 限速限流 有限速 限流值 低速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_SLLowAmpere.Text = ((Convert.ToDouble(Form1.gss_SLLowAmpere) * 5 / 255 - 1) / 0.104).ToString("0");
            }
            // 12管
            if (Convert.ToInt32(Form1.gss_Pipe) == 2)
            {
                // 相电流峰值=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_PhaseCurrentPeak.Text = ((Convert.ToDouble(Form1.gss_PhaseCurrentPeak) * 5 / 255 - 1) / 0.104).ToString("0");
                // 堵转保护电流值=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_LockedRotorProtectionCurrentValue.Text = ((Convert.ToDouble(Form1.gss_LockedRotorProtectionCurrentValue) * 5 / 255 - 1) / 0.104).ToString("0");
                // 限速限流 无限速 限流值 提速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_SNLAccelerationAmpere.Text = ((Convert.ToDouble(Form1.gss_SNLAccelerationAmpere) * 5 / 255 - 1) / 0.104).ToString("0");
                // 限速限流 无限速 限流值 高速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_SNLHighAmpere.Text = ((Convert.ToDouble(Form1.gss_SNLHighAmpere) * 5 / 255 - 1) / 0.104).ToString("0");
                // 限速限流 无限速 限流值 中速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_SNLMidAmpere.Text = ((Convert.ToDouble(Form1.gss_SNLMidAmpere) * 5 / 255 - 1) / 0.104).ToString("0");
                // 限速限流 无限速 限流值 低速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_SNLLowAmpere.Text = ((Convert.ToDouble(Form1.gss_SNLLowAmpere) * 5 / 255 - 1) / 0.104).ToString("0");
                // 限速限流 有限速 限流值 提速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_SLAccelerationAmpere.Text = ((Convert.ToDouble(Form1.gss_SLAccelerationAmpere) * 5 / 255 - 1) / 0.104).ToString("0");
                // 限速限流 有限速 限流值 高速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_SLHighAmpere.Text = ((Convert.ToDouble(Form1.gss_SLHighAmpere) * 5 / 255 - 1) / 0.104).ToString("0");
                // 限速限流 有限速 限流值 中速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_SLMidAmpere.Text = ((Convert.ToDouble(Form1.gss_SLMidAmpere) * 5 / 255 - 1) / 0.104).ToString("0");
                // 限速限流 有限速 限流值 低速=（1 + BusCurren（写入值） × 0.104） × 255 / 5
                fm.myTextBoxNUM_SLLowAmpere.Text = ((Convert.ToDouble(Form1.gss_SLLowAmpere) * 5 / 255 - 1) / 0.104).ToString("0");
            }

            // 最新更新的参数，根据文档增加
            // 电机型号
            fm.checkBox_MotorType_Select.Checked = Convert.ToBoolean(Form1.gss_MotorType_Select);
            fm.comboBox_MotorType.Text = fm.comboBox_MotorType.Items[Convert.ToInt32(Form1.gss_MotorType)].ToString();
            // 启动方式
            fm.trackBar_StartStyle.Value = Convert.ToInt32(Form1.gss_StartStyle);
            // 刹车力度
            fm.trackBar_BrakingPotency.Value = Convert.ToInt32(Form1.gss_BrakingPotency);
            // 堵转降流
            fm.checkBox_LockedRotorCurrentDrop_Select.Checked = Convert.ToBoolean(Form1.gss_LockedRotorCurrentDrop_Select);
            fm.comboBox_LockedRotorCurrentDrop.Text = fm.comboBox_LockedRotorCurrentDrop.Items[Convert.ToInt32(Form1.gss_LockedRotorCurrentDrop)].ToString();
            // 松手刹防飞车
            fm.checkBox_HandBrakeOverrun_Select.Checked = Convert.ToBoolean(Form1.gss_HandBrakeOverrun_Select);
            fm.comboBox_HandBrakeOverrun.Text = fm.comboBox_HandBrakeOverrun.Items[Convert.ToInt32(Form1.gss_HandBrakeOverrun)].ToString();
            // 滑行反充电
            fm.checkBox_SlideCharge_Select.Checked = Convert.ToBoolean(Form1.gss_SlideCharge_Select);
            fm.comboBox_SlideCharge.Text = fm.comboBox_SlideCharge.Items[Convert.ToInt32(Form1.gss_SlideCharge)].ToString();
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

            // 限速分压系数
            //try
            //{
            //    if (Convert.ToDouble(fm.myTextBoxNUM_SpeedLimitVoltageDivideCoefficient.Text) < (1))
            //    {
            //        fm.myTextBoxNUM_SpeedLimitVoltageDivideCoefficient.Text = "1.0";
            //    }
            //    else if (Convert.ToDouble(fm.myTextBoxNUM_SpeedLimitVoltageDivideCoefficient.Text) > (2))
            //    {
            //        fm.myTextBoxNUM_SpeedLimitVoltageDivideCoefficient.Text = "2.0";
            //    }
            //}
            //catch (Exception)
            //{
            //    fm.myTextBoxNUM_SpeedLimitVoltageDivideCoefficient.Text = "1.7";
            //}

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
