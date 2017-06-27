using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTB.GUI;
namespace QLTB
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
       
        static void Main()
        {

            SqlServerTypes.Utilities.LoadNativeAssemblies(AppDomain.CurrentDomain.BaseDirectory);
            System.Globalization.CultureInfo cultureInfo = new System.Globalization.CultureInfo("vi-VN");
            System.Threading.Thread.CurrentThread.CurrentCulture = cultureInfo;
            System.Threading.Thread.CurrentThread.CurrentUICulture = cultureInfo;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoadingScreen fLogin = new LoadingScreen();
            if (fLogin.ShowDialog() == DialogResult.OK)
            {
                Form1 frm = new Form1();
                frm.Visible = false;
                Application.Run(frm);
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
