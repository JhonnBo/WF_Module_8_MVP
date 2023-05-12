using MVP_Sample.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVP_Sample
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            Form1 form = new Form1();
            RectanglePresenter presenter = new RectanglePresenter(form);
            Application.Run(form);
        }
    }
}











//Form1 form2 = new Form1();
//RectanglePresenter presenter2 = new RectanglePresenter(form2);
//form2.Show();
