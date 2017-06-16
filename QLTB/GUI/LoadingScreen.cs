using QLTB.Handler;
using QLTB.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTB.GUI
{
    public partial class LoadingScreen : DevComponents.DotNetBar.Metro.MetroForm
    {
        public LoadingScreen()
        {
            InitializeComponent();
            labelX1.ForeColor = Color.Green;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

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
        private void button1_Click(object sender, EventArgs e)
        {
            if (ConnectiongStringBuilder.CheckConnection())
            {
                if (!ConnectiongStringBuilder.CheckUserSaved())
                {
                    progressBarX1.Visible = true;
                    string username = txtUserName.Text.Trim();
                    string password = txtPassWord.Text.Trim();
                    string message = "";
                    var handler = new LoginHandler();
                    var WorkingUser = handler.CheckLogin(username, password, out message);
                    if (WorkingUser != null)
                    {
                        InitApp();
                        //Set global
                        GlobalVariable.SetUser(WorkingUser);
                        //
                        Task.Delay(1000).ContinueWith(t => CloseForm());
                    }
                    else
                    {
                        MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Close();
                    }
                }
            }     
        }

        private void textBoxX1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                button1.PerformClick();
            }
        }
    }
}
