using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTB.Model;
namespace QLTB.GUI
{
    public partial class frmDSGiamThietBi : Form
    {
        public frmDSGiamThietBi()
        {
            InitializeComponent();
        }
        private void loadForm()
        {
            List<PhieuGiamTBGridDisplayModel> list = new List<PhieuGiamTBGridDisplayModel>();
            list.Add(new PhieuGiamTBGridDisplayModel
            {
                SoPhieu="PGTB000001",
                NgayLap="21/11/2010",
                GhiChu=""
            });
            list.Add(new PhieuGiamTBGridDisplayModel
            {
                SoPhieu = "PGTB000002",
                NgayLap = "21/11/2010",
                GhiChu = ""
            });
            list.Add(new PhieuGiamTBGridDisplayModel
            {
                SoPhieu = "PGTB000003",
                NgayLap = "21/11/2010",
                GhiChu = ""

            });
            list.Add(new PhieuGiamTBGridDisplayModel
            {
                SoPhieu = "PGTB000004",
                NgayLap = "21/11/2010",
                GhiChu = ""
            });
            advancedDataGridView.DataSource = list;
            advancedDataGridView.Columns[0].HeaderText = "Số phiếu";
            advancedDataGridView.Columns[0].Width = 100;
            advancedDataGridView.Columns[1].HeaderText = "Ngày lập";
            advancedDataGridView.Columns[1].Width = 100;
            advancedDataGridView.Columns[2].HeaderText = "Ghi chú";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            frmPhieGiamThietBi frm = new frmPhieGiamThietBi();
            frm.MdiParent = MdiParent;
            frm.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDSGiamThietBi_Load(object sender, EventArgs e)
        {
            loadForm();
        }
    }
}
