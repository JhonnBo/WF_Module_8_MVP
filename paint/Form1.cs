using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pen = new Pen(Color.Red, 5);
            bm = new Bitmap(this.Width, this.Height);
            pictureBox1.Image = bm;

        }
        Pen pen;
        Bitmap bm;
        Graphics g;

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {             
                
                g = Graphics.FromImage(pictureBox1.Image = bm);
                g.FillRectangle(new SolidBrush(Color.Black), e.X, e.Y, 5, 5);
                g.Dispose();
                pen.Dispose();

            }

        }
    }
}
