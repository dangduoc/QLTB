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
    public partial class frmKiemKeTB : Form
    {
        public frmKiemKeTB()
        {
            InitializeComponent();
        }
        private void loadForm()
        {
            List<KiemKeTBGridDisplayModel> list = new List<KiemKeTBGridDisplayModel>();
            list.Add(new KiemKeTBGridDisplayModel
            {
                SoHieu="PKTTB00001",
                NgayKiemKe="21/11/2010",
                NgayLap="19/10/2010",
                GhiChu=""
            });
            list.Add(new KiemKeTBGridDisplayModel
            {
                SoHieu = "PKTTB00002",
                NgayKiemKe = "21/11/2010",
                NgayLap = "19/10/2010",
                GhiChu = ""
            });
            list.Add(new KiemKeTBGridDisplayModel
            {
                SoHieu = "PKTTB00003",
                NgayKiemKe = "21/11/2010",
                NgayLap = "19/10/2010",
                GhiChu = ""
            });
            list.Add(new KiemKeTBGridDisplayModel
            {
                SoHieu = "PKTTB00004",
                NgayKiemKe = "21/11/2010",
                NgayLap = "19/10/2010",
                GhiChu = ""
            });
            advancedDataGridView.DataSource = list;
            advancedDataGridView.Columns[0].HeaderText = "Số phiếu";
            advancedDataGridView.Columns[0].Width = 100;
            advancedDataGridView.Columns[1].Width = 100;
            advancedDataGridView.Columns[2].Width = 100;
            advancedDataGridView.Columns[1].HeaderText = "Ngày lập";
            advancedDataGridView.Columns[2].HeaderText = "Ngày kiếm kê";
            advancedDataGridView.Columns[3].HeaderText = "Ghi chú";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmChiTietKiemKe frm = new frmChiTietKiemKe();
            frm.MdiParent = MdiParent;
            frm.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmKiemKeTB_Load(object sender, EventArgs e)
        {
            loadForm();
        }
    }
}
