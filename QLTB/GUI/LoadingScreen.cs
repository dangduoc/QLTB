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
        private void button1_Click(object sender, EventArgs e)
        {
            progressBarX1.Visible = true;
            Task.Delay(4000).ContinueWith(t => CloseForm());
        }
    }
}
