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
    public partial class frmPhieuMuaThietBi : DevComponents.DotNetBar.Office2007Form
    {
        public frmPhieuMuaThietBi()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmPhieuMuaThietBi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
