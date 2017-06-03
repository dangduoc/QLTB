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
    public partial class frmThongKeBaoCao : DevComponents.DotNetBar.Office2007Form
    {
        public frmThongKeBaoCao()
        {
            InitializeComponent();
        }

        private void frmThongKeBaoCao_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            var parent = MdiParent as Form1;
            parent.pnlLoading.Visible = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
