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
    public partial class frmPhieuBaoHong : Form
    {
        public frmPhieuBaoHong()
        {
            InitializeComponent();
        }
        private void loadForm()
        {
            List<ThietBiHongGridDisplayModel> list = new List<ThietBiHongGridDisplayModel>();
            gridDSThietBiMuon.DataSource = list;


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

            gridDSThietBiMuon.Columns[0].HeaderText = "Số hiệu";
            gridDSThietBiMuon.Columns[1].HeaderText = "Mã thiết bị";
            gridDSThietBiMuon.Columns[2].HeaderText = "Tên thiết bị";
            gridDSThietBiMuon.Columns[3].HeaderText = "Kho/Phòng bộ môn";
            gridDSThietBiMuon.Columns[4].HeaderText = "Số lượng mượn";
            gridDSThietBiMuon.Columns[5].HeaderText = "Đơn vị tính";
            gridDSThietBiMuon.Columns[6].HeaderText = "Tình trạng";
            gridDSThietBiMuon.Columns[7].HeaderText = "Lý do hỏng/mất";
            gridDSThietBiMuon.Columns[8].HeaderText = "Tình trạng hỏng hóc";
        }

        private void frmPhieuBaoHong_Load(object sender, EventArgs e)
        {
            loadForm();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
