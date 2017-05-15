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
    public partial class Form1 : DevComponents.DotNetBar.Office2007Form
    {
        public Form1()
        {
            InitializeComponent();
            bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
     
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frmThietBi frm = new frmThietBi();
            frm.MdiParent = this;
            
            frm.Show();
        }

        private void buttonItem7_Click(object sender, EventArgs e)
        {

        }
    }
}
