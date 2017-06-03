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
    public partial class frmDMToBoMon : DevComponents.DotNetBar.Office2007Form
    {
        
        public frmDMToBoMon()
        {
            InitializeComponent();
        }

        private void frmDMToBoMon_Load(object sender, EventArgs e)
        {
            var parent = MdiParent as Form1;
            parent.pnlLoading.Visible = false;
        }
    }
}
