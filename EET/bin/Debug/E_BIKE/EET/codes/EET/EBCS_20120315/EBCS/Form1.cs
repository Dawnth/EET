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

        // �������õ�Ŀ��
        private void DownLoad_button_Click(object sender, EventArgs e)
        {
            // ����ProgressBar
            for (int i = 0; i < 10; i++)//ѭ��
            {
                // ��ͣ1��
                System.Threading.Thread.Sleep(500);
                // �ý���������һ��
                toolStripProgressBar1.Value += toolStripProgressBar1.Step;
                // ��������������˳�ѭ������ս�����
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