using QLTB.Model;
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
    public partial class frmChiTietSuaChuaTB : Form
    {
        public frmChiTietSuaChuaTB()
        {
            InitializeComponent();
        }
        private void loadForm()
        {
            List<ThietBiSuaGridDisplayModel> list = new List<ThietBiSuaGridDisplayModel>();
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

            gridDSThietBiMuon.Columns[0].HeaderText = "Mã thiết bị";
            gridDSThietBiMuon.Columns[1].HeaderText = "Tên thiết bị";
            gridDSThietBiMuon.Columns[2].HeaderText = "Loại thiết bị";
            gridDSThietBiMuon.Columns[3].HeaderText = "Số hiệu";
            gridDSThietBiMuon.Columns[4].HeaderText = "Kho/Phòng bộ môn";
            gridDSThietBiMuon.Columns[5].HeaderText = "Số lượng cần sửa";
            gridDSThietBiMuon.Columns[6].HeaderText = "Đơn vị tính";
            gridDSThietBiMuon.Columns[7].HeaderText = "Giá trị";
            gridDSThietBiMuon.Columns[8].HeaderText = "Đơn giá";
            gridDSThietBiMuon.Columns[9].HeaderText = "Thành tiền";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmChiTietSuaChuaTB_Load(object sender, EventArgs e)
        {
            loadForm();
        }
    }
}
