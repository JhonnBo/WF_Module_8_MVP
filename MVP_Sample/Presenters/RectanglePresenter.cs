using MVP_Sample.Models;
using MVP_Sample.Views;
using System;
using System.Windows.Forms;

namespace MVP_Sample.Presenters
{
    internal class RectanglePresenter
    {
        Irectangle rectangleView;

        public RectanglePresenter(Irectangle view)
        {
            rectangleView = view;
            rectangleView.CalculateArea += new EventHandler(RectangleView_CalculateArea);
        }

        private void RectangleView_CalculateArea(object sender, EventArgs e)
        {
            Rectangle rectangle = new Rectangle();

            // From View To Model <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
            rectangle.Length = double.Parse(rectangleView.LengthText);
            rectangle.Width = double.Parse(rectangleView.WidthText);

            // From Model To View >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
            rectangleView.AreaText = rectangle.CalculateArea().ToString();
        }
    }
}















//Form1 frm = new Form1();
//frm.ShowDialog();