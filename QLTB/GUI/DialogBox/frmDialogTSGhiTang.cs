using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTB.Handler;
namespace QLTB.GUI
{
    public partial class frmDialogTSGhiTang : DevComponents.DotNetBar.Office2007Form
    {
        public frmDialogTSGhiTang()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (ridoNamHoc.Checked)
            {
                frmReportGhiTang frm = new frmReportGhiTang(Convert.ToInt32(cbbNamHoc.SelectedValue));
                frm.ShowDialog(Owner);
                Close();
            }
        }

        private void frmDialogTSGhiTang_Load(object sender, EventArgs e)
        {
            cbbNamHoc.DisplayMember = "value";
            cbbNamHoc.ValueMember = "key";
            cbbNamHoc.DataSource = new DbThongTinNHHandler().GetAll().Select(p => new { key = p.NamHocId, value = p.ThoiGian }).ToList();
        }
    }
}
