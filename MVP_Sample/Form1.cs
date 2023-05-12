using MVP_Sample.Views;
using System;
using System.Windows.Forms;

// https://www.youtube.com/embed/N6RNy3rPZpg
// https://www.youtube.com/watch?v=UgnbIJYUTQY

namespace MVP_Sample
{
    public partial class Form1 : Form, Irectangle
    {
        public Form1()
        {
            InitializeComponent();
            btnCalculate.Click += new EventHandler(this.btnCalculate_Click);           
        }

        #region Irectangle
        public string LengthText
        {
            get => txtLength.Text;
            set => txtLength.Text = value;
        }
        public string WidthText
        {
            get => txtWidth.Text;
            set => txtWidth.Text = value;
        }
        public string AreaText
        {
            get => lblResult.Text;
            set => lblResult.Text = value;
        }

        public event EventHandler CalculateArea;
        #endregion

        #region Проброс события
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (CalculateArea != null)
            {
                CalculateArea(this, EventArgs.Empty);
            }         
        }
        #endregion
    }
}
