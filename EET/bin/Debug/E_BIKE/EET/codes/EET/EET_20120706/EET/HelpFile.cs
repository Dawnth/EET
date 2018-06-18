using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EET
{
    public partial class HelpFile : Form
    {
        public HelpFile()
        {
            InitializeComponent();
            // 取消最大化和最小化按钮
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        //获得选中节点的等级
        public int NodeLevel(TreeNode n)
        {
            int i = 0;
            while (!(n.Parent == null))
            {
                n = n.Parent;
                i += 1;
            }
            return i;
        }

        // 电机节点查看帮助文档
        private void treeView_List_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            richTextBox_SelectedNode.Text = e.Node.Text;
            // "\r\n" 回车换行
            switch (e.Node.Text)
            {
                case "主界面":
                    richTextBox_Information.Text = "主界面包括“菜单栏”、“数据区” 及“状态栏”。\r\n可以进行配置的加载、保存、读取及下载等操作。\r\n软件操作需串口支持，需要先连接串口后再打开软件！";
                    break;
                case "菜单栏":
                    richTextBox_Information.Text = "菜单栏即界面最上方，包括“文件”、“操作”、“端口” 及“帮助”。";
                    break;
                case "文件":
                    richTextBox_Information.Text = "文件包括“从文件加载配置”、“保存配置到文件”、“打开文件夹”及“退出”";
                    break;
                case "从文件加载配置":
                    richTextBox_Information.Text = "将已经保存的配置文件加载到软件中，用于调试过的配置快速的恢复。";
                    break;
                case "保存配置到文件":
                    richTextBox_Information.Text = "将已经调试过的配置保存到配置文件中，留作存档，该配置文件也可以被再次加载到软件中。";
                    break;
                case "打开文件夹":
                    richTextBox_Information.Text = "打开存放配置文档的文件夹。";
                    break;
                case "退出":
                    richTextBox_Information.Text = "关闭软件。";
                    break;
                case "操作":
                    richTextBox_Information.Text = "操作包括“从控制器读取配置”、“下载配置到控制器”及“置顶”。";
                    break;
                case "从控制器读取配置":
                    richTextBox_Information.Text = "从控制器读取控制器内部的当前配置，读取的参数用来做调试的基础值，或者读取后保存到配置文档，留作存档。";
                    break;
                case "下载配置到控制器":
                    richTextBox_Information.Text = "将软件当前的配置下载到控制器内进行调试。";
                    break;
                case "置顶":
                    richTextBox_Information.Text = "将软件至于所有串口的最前端，单击设定或者取消。";
                    break;
                case "端口":
                    richTextBox_Information.Text = "若要使用本软件，需先连接串口后再打开本软件，可用的端口号会自动加载到列表中，选择对应的端口后可以进行通讯。";
                    break;
                case "帮助":
                    richTextBox_Information.Text = "包括“帮助文档”及“关于”";
                    break;
                case "帮助文档":
                    richTextBox_Information.Text = "即本文档。";
                    break;
                case "关于":
                    richTextBox_Information.Text = "软件版本及所有权说明。";
                    break;
                case "状态栏":
                    richTextBox_Information.Text = "状态栏即界面最下方，状态栏显示区包括被选择的串口端口号，串口当前状态，通讯连接状态，进度条。";
                    break;
                case "显示区":
                    richTextBox_Information.Text = "即显示从控制器内部读取的相关信息，此区域内的数据无法更改。";
                    break;
                case "软件版本号":
                    richTextBox_Information.Text = "读取的软件版本号。";
                    break;
                case "硬件版本号":
                    richTextBox_Information.Text = "读取的硬件版本号。";
                    break;
                case "产品型号":
                    richTextBox_Information.Text = "读取的产品型号";
                    break;
                case "电机极数":
                    richTextBox_Information.Text = "读取的控制器对应电机的极数";
                    break;
                case "共阴共阳":
                    richTextBox_Information.Text = "读取的共阴共阳。";
                    break;
                case "控制器保护温度":
                    richTextBox_Information.Text = "读取的控制区保护温度";
                    break;
                case "参数设定区":
                    richTextBox_Information.Text = "设置参数值。";
                    break;
                case "电机相序":
                    richTextBox_Information.Text = "设置电机相序\r\n“正向运行”\r\n“反向运行”。";
                    break;
                case "电池额定电压":
                    richTextBox_Information.Text = "设置当前使用的电池额定电压。";
                    break;
                case "电池保护电压 过压":
                    richTextBox_Information.Text = "根据选择的电池额定电压值，设置电池保护电压 过压值\r\n48V电池的设置范围为“48～56V”\r\n36V电池的设置范围为“36～42V”。";
                    break;
                case "电池保护电压 欠压":
                    richTextBox_Information.Text = "根据选择的电池额定电压值，设置电池保护电压 欠压值\r\n48V电池的设置范围为“42～48V”\r\n36V电池的设置范围为“28～36V”。";
                    break;
                case "霍尔":
                    richTextBox_Information.Text = "显示霍尔\r\n“有”\r\n“无”。";
                    break;
                case "防飞车保护电压 上限":
                    richTextBox_Information.Text = "设置防飞车保护电压 上限值\r\n设置范围为“2.1～4.9V”。";
                    break;
                case "防飞车保护电压 下限":
                    richTextBox_Information.Text = "设置防飞车保护电压 下限值\r\n设置范围为“0.1～1.9V”。";
                    break;
                case "霍尔相差":
                    richTextBox_Information.Text = "设置霍尔相差\r\n“60”\r\n“120”。";
                    break;
                case "相电流峰值限制":
                    richTextBox_Information.Text = "设置相电流峰值限制值\r\n设置范围为“6～35A”。";
                    break;
                case "手柄调速电压 上限":
                    richTextBox_Information.Text = "设置手柄调速电压 上限值\r\n设置范围为“2.1～4.9V”。";
                    break;
                case "手柄调速电压 下限":
                    richTextBox_Information.Text = "设置手柄调速电压 下限值\r\n设置范围为“0.1～1.9V”。";
                    break;
                case "堵转保护电流":
                    richTextBox_Information.Text = "设置堵转保护电流值\r\n设置范围为“6～40A”。";
                    break;
                case "功能选择区":
                    richTextBox_Information.Text = "设置功能值，每项前的复选框若不选择，则使用软件显示的标定值，若需更改，请先勾选复选框，然后再更改相关参数。";
                    break;
                case "限速限流":
                    richTextBox_Information.Text = "限速限流设置。";
                    break;
                case "断开限速线":
                    richTextBox_Information.Text = "当断开限速线时\r\n设置限速值范围为“1～600RPM”\r\n设置限流值范围为“1～35A”。";
                    break;
                case "连接限速线":
                    richTextBox_Information.Text = "当连接限速线时\r\n设置限速值范围为“1～600RPM”\r\n设置限流值范围为“1～35A”。";
                    break;
                case "启动方式":
                    richTextBox_Information.Text = "启动方式的选择，软启动（1）到硬启动（10）有10个档位，请根据调试需求进行设置。";
                    break;
                case "巡航功能":
                    richTextBox_Information.Text = "设置巡航功能\r\n“无”\r\n“手动”\r\n“自动”\r\n“自动带选择”。";
                    break;
                case "自动巡航手柄稳定时间":
                    richTextBox_Information.Text = "设置自动巡航手柄稳定时间值\r\n设置范围为“2～12S”。";
                    break;
                case "手动巡航按键保持时间":
                    richTextBox_Information.Text = "设置手动巡航按键保持时间值\r\n设置范围为“0.1～4S”。";
                    break;
                case "助力功能":
                    richTextBox_Information.Text = "设置助力功能\r\n“无”\r\n“手动”\r\n“自动”。";
                    break;
                case "电动巡航助力转换":
                    richTextBox_Information.Text = "设置电动巡航助力转换\r\n“无”\r\n“电动－巡航－助力”\r\n“电动－助力－巡航”。";
                    break;
                case "堵转降流处理":
                    richTextBox_Information.Text = "设置堵转降流处理\r\n“3秒后完全降电流”\r\n“3秒内分阶段降电流”。";
                    break;
                case "松手刹防飞车":
                    richTextBox_Information.Text = "设置松手刹防飞车\r\n“无”\r\n“有”。";
                    break;
                case "刹车功能":
                    richTextBox_Information.Text = "设置刹车功能\r\n“无”\r\n“负力矩”\r\n“零矢量”\r\n“直流分量”。";
                    break;
                case "刹车力度":
                    richTextBox_Information.Text = "刹车力度的选择，有10个档位，请根据调试需求进行设置。";
                    break;
                case "电机型号":
                    richTextBox_Information.Text = "设置不同电机型号\r\n设置范围为“0～255”.";
                    break;
                case "模拟速度显示输出值":
                    richTextBox_Information.Text = "设定模拟速度显示输出值，模拟速度显示速度电压对应关系\r\n设置范围为“0.2～1”。";
                    break;
                case "模拟电流显示输出值":
                    richTextBox_Information.Text = "设定模拟电流显示输出值，模拟电流显示电流电压对应关系\r\n设置范围为“2～10”。";
                    break;
                case "三态显示":
                    richTextBox_Information.Text = "设置三态显示\r\n“无”\r\n“电动－巡航－助力(高电平－高阻－低电平)”\r\n“电动－巡航－助力(高电平－低电平－高阻)”\r\n“电动－巡航－助力(高阻－高电平－低电平)”\r\n“电动－巡航－助力(高阻－低电平－高电平)”\r\n“电动－巡航－助力(低电平－高阻－高电平)”\r\n“电动－巡航－助力(低电平－高电平－高阻)”。";
                    break;
                case "滑行反充电":
                    richTextBox_Information.Text = "设置滑行反充电，“无”或者“有”。";
                    break;
                case "多速实现":
                    richTextBox_Information.Text = "设置多速实现\r\n“无”\r\n“按键切换方式(提高中低四速)”\r\n“按键切换方式(高中低三速)”\r\n“按键切换方式(高低两速)”\r\n“2根线束(高低两速可选)”\r\n“3根线束(高中低三速可选)”\r\n“4根线束(提速、高、中、低四速可选)”。";
                    break;
                default:
                    break;
            }
        }
    }
}