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
    public partial class frmDSThanhLyTB : Form
    {
        public frmDSThanhLyTB()
        {
            InitializeComponent();
        }
        private void loadForm()
        {
            List<PhieuTLGridDisplayModel> list = new List<PhieuTLGridDisplayModel>();
            list.Add(new PhieuTLGridDisplayModel
            {
                SoPhieu="PTL0000001",
                NgayLap="21/11/2010",
                GhiChu=""
            });
            list.Add(new PhieuTLGridDisplayModel
            {
                SoPhieu = "PTL0000002",
                NgayLap = "21/11/2011",
                GhiChu = ""
            });
            list.Add(new PhieuTLGridDisplayModel
            {
                SoPhieu = "PTL0000003",
                NgayLap = "21/11/2012",
                GhiChu = ""
            });
            list.Add(new PhieuTLGridDisplayModel
            {
                SoPhieu = "PTL0000004",
                NgayLap = "21/11/2013",
                GhiChu = ""
            });
            advancedDataGridView.DataSource = list;
            advancedDataGridView.Columns[0].HeaderText = "Số phiếu";
            advancedDataGridView.Columns[0].Width = 100;
            advancedDataGridView.Columns[1].Width = 100;
            advancedDataGridView.Columns[1].HeaderText = "Ngày lập";
            advancedDataGridView.Columns[2].HeaderText = "Ghi chú";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            frmPhieuThanhLyTB frm = new frmPhieuThanhLyTB();
            frm.MdiParent = MdiParent;
            frm.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDSThanhLyTB_Load(object sender, EventArgs e)
        {
            loadForm();
        }
    }
}
