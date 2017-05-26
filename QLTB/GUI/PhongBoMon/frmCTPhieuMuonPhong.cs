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

            ADGVDSTB.Columns.Add(linkColEdit);
            ADGVDSTB.Columns.Add(linkColDelete);
            //load danh sach thiet bi muon
            ADGVDSTB.DataSource = listTB;
            ADGVDSTB.Columns[2].HeaderText = "Mã thiết bị";
            ADGVDSTB.Columns[3].HeaderText = "Tên thiết bị";
            ADGVDSTB.Columns[4].HeaderText = "Số hiệu";
            ADGVDSTB.Columns[5].HeaderText = "Phòng bộ môn";
            ADGVDSTB.Columns[6].HeaderText = "Số lượng mượn";
            ADGVDSTB.Columns[7].HeaderText = "Đơn vị tính";
            ADGVDSTB.Columns[2].DisplayIndex = 0;
            ADGVDSTB.Columns[3].DisplayIndex = 1;
            ADGVDSTB.Columns[4].DisplayIndex = 2;
            ADGVDSTB.Columns[5].DisplayIndex = 3;
            ADGVDSTB.Columns[6].DisplayIndex = 4;
            ADGVDSTB.Columns[7].DisplayIndex = 5;
            ADGVDSTB.Columns[0].DisplayIndex = 6;
            ADGVDSTB.Columns[1].DisplayIndex = 7;
        }

        private void frmCTPhieuMuonPhong_Load(object sender, EventArgs e)
        {
            loadForm();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLayTB_Click(object sender, EventArgs e)
        {
            //frmDialogDSThietBi frm = new frmDialogDSThietBi();
            //frm.ShowDialog(this);
        }

        private void btnBaoHong_Click(object sender, EventArgs e)
        {
            frmPhieuBaoHong frm = new frmPhieuBaoHong();
            frm.MdiParent = MdiParent;
            frm.Show();
        }
    }
}
