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
    public partial class frmCTPhieuMuonPhong : DevComponents.DotNetBar.Office2007Form
    {
        public frmCTPhieuMuonPhong()
        {
            InitializeComponent();
        }
        private void loadForm()
        {
            List<ThietBiMuonGridDisplayModel> listTB = new List<ThietBiMuonGridDisplayModel>();
            DataGridViewLinkColumn linkColEdit = new DataGridViewLinkColumn();
            linkColEdit.Text = "Thay đổi";
            linkColEdit.Name = "Edit";
            linkColEdit.LinkColor = Color.Blue;
            linkColEdit.LinkBehavior = LinkBehavior.NeverUnderline;
            linkColEdit.UseColumnTextForLinkValue = true;
            linkColEdit.HeaderText = "";
            DataGridViewLinkColumn linkColDelete = new DataGridViewLinkColumn();
            linkColDelete.Text = "Xóa bỏ";
            linkColDelete.Name = "Delete";
            linkColDelete.LinkColor = Color.Red;
            linkColDelete.LinkBehavior = LinkBehavior.NeverUnderline;
            linkColDelete.UseColumnTextForLinkValue = true;
            linkColDelete.HeaderText = "";

            gridDSThietBiMuon.Columns.Add(linkColEdit);
            gridDSThietBiMuon.Columns.Add(linkColDelete);
            //load danh sach thiet bi muon
            gridDSThietBiMuon.DataSource = listTB;
            gridDSThietBiMuon.Columns[2].HeaderText = "Mã thiết bị";
            gridDSThietBiMuon.Columns[3].HeaderText = "Tên thiết bị";
            gridDSThietBiMuon.Columns[4].HeaderText = "Số hiệu";
            gridDSThietBiMuon.Columns[5].HeaderText = "Phòng bộ môn";
            gridDSThietBiMuon.Columns[6].HeaderText = "Số lượng mượn";
            gridDSThietBiMuon.Columns[7].HeaderText = "Đơn vị tính";
            gridDSThietBiMuon.Columns[2].DisplayIndex = 0;
            gridDSThietBiMuon.Columns[3].DisplayIndex = 1;
            gridDSThietBiMuon.Columns[4].DisplayIndex = 2;
            gridDSThietBiMuon.Columns[5].DisplayIndex = 3;
            gridDSThietBiMuon.Columns[6].DisplayIndex = 4;
            gridDSThietBiMuon.Columns[7].DisplayIndex = 5;
            gridDSThietBiMuon.Columns[0].DisplayIndex = 6;
            gridDSThietBiMuon.Columns[1].DisplayIndex = 7;
        }

        private void frmCTPhieuMuonPhong_Load(object sender, EventArgs e)
        {
            loadForm();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
