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
        // ��ʼ����������
        public About()
        {
            InitializeComponent();
        }

        // ��������¼�
        private void About_Load(object sender, EventArgs e)
        {
            // ȡ����󻯺���С����ť
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        // ���ڰ�ť��ȷ���رմ����¼�
        private void button_AboutClose_Click(object sender, EventArgs e)
        {
            // �رչ��ڴ���
            this.Close();
        }
    }
}