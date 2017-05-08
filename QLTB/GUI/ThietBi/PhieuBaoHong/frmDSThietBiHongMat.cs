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
    public partial class frmDSThietBiHongMat : Form
    {
        public frmDSThietBiHongMat()
        {
            InitializeComponent();
        }
        private void loadForm()
        {
            List<PhieuBaoHongGridDisplayModel> list = new List<PhieuBaoHongGridDisplayModel>();
            list.Add(new PhieuBaoHongGridDisplayModel
            {
                PhieuBaoHongId="PBHTB00001",
                NguoiLamHong="Đặng Minh Được",
                NgayLap="21/11/2010",
                GhiChu="Hỏng rất nặng"
            });
            list.Add(new PhieuBaoHongGridDisplayModel
            {
                PhieuBaoHongId = "PBHTB00002",
                NguoiLamHong = "Đặng Ngọc Bích",
                NgayLap = "21/11/2010",
                GhiChu = ""
            });
            list.Add(new PhieuBaoHongGridDisplayModel
            {
                PhieuBaoHongId = "PBHTB00003",
                NguoiLamHong = "Nguyễn Văn Phú",
                NgayLap = "21/11/2010",
                GhiChu = "Hỏng rất nặng"
            });
            list.Add(new PhieuBaoHongGridDisplayModel
            {
                PhieuBaoHongId = "PBHTB00004",
                NguoiLamHong = "Phạm Ngọc Phi",
                NgayLap = "21/11/2010",
                GhiChu = ""
            });
            advancedDataGridView.DataSource = list;
            advancedDataGridView.Columns[0].HeaderText = "Số phiếu";
            advancedDataGridView.Columns[0].Width = 100;
            advancedDataGridView.Columns[1].Width = 100;
            advancedDataGridView.Columns[0].Width = 150;
            advancedDataGridView.Columns[1].HeaderText = "Ngày lập";
            advancedDataGridView.Columns[2].HeaderText = "Người làm hỏng/mất";
            advancedDataGridView.Columns[3].HeaderText = "Ghi chú";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmPhieuBaoHong frm = new frmPhieuBaoHong();
            frm.MdiParent = MdiParent;
            frm.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDSThietBiHongMat_Load(object sender, EventArgs e)
        {
            loadForm();
        }
    }
}
