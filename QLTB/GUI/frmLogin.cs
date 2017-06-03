using QLTB.DAL;
using QLTB.DAL.Data;
using QLTB.Handler;
using QLTB.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTB.GUI
{
    public partial class frmLogin : DevComponents.DotNetBar.Office2007Form
    {
        public frmLogin()
        {
            InitializeComponent();
            //circularProgress1.IsRunning = true;
        }
        private void CloseForm()
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
        private void InitApp()
        {
            GlobalVariable.SetHeThong();
            GlobalVariable.InitDanhSach();
           

        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                if (ConnectiongStringBuilder.CheckConnection())
                {
                    if (ConnectiongStringBuilder.CheckUserSaved())
                    {
                        InitApp();
                        // Task.Delay(1500).ContinueWith(t => CloseForm());
                        CloseForm();
                    }
                }

                Close();
            }
            catch (Exception ex)
            {
                Close();
            }
        }
    }
}
