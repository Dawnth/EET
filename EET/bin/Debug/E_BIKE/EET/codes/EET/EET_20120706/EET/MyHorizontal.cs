using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace EET
{
    public partial class MyHorizontal : UserControl
    {
        public MyHorizontal()
        {
            InitializeComponent();
        }
        private void MyHorizontal_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

            Graphics g = e.Graphics;

            Rectangle r = this.ClientRectangle;



            Pen darkPen = new Pen(SystemColors.ControlDark, 1);

            Pen LightPen = new Pen(Color.White);



            //�ð�ɫ�������ϱ�Ե

            g.DrawLine(darkPen, r.Left, r.Top, r.Right, r.Top);



            //����ɫ�������±�Ե

            g.DrawLine(LightPen, r.Left, r.Top + 1, r.Right, r.Top + 1);

        }
    }
}