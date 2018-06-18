using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EBCS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 下载配置到目标
        private void DownLoad_button_Click(object sender, EventArgs e)
        {
            // 测试ProgressBar
            for (int i = 0; i < 10; i++)//循环
            {
                // 暂停1秒
                System.Threading.Thread.Sleep(500);
                // 让进度条增加一次
                toolStripProgressBar1.Value += toolStripProgressBar1.Step;
                // 如果进度条满后，退出循环，清空进度条
                if ( toolStripProgressBar1.Value >= 100 )
                {
                    System.Threading.Thread.Sleep(1000);
                    toolStripProgressBar1.Value = 0;
                    break;
                }
            }
        }
    }
}