using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EBCS
{
    public partial class About : Form
    {
        // 初始化窗体内容
        public About()
        {
            InitializeComponent();
        }

        // 窗体加载事件
        private void About_Load(object sender, EventArgs e)
        {
            // 取消最大化和最小化按钮
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        // 关于按钮的确定关闭窗体事件
        private void button_AboutClose_Click(object sender, EventArgs e)
        {
            // 关闭关于窗体
            this.Close();
        }
    }
}