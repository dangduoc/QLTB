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
            ADGVDSTB.DataSource = list;
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

            ADGVDSTB.Columns[0].HeaderText = "Mã thiết bị";
            ADGVDSTB.Columns[1].HeaderText = "Tên thiết bị";
            ADGVDSTB.Columns[2].HeaderText = "Loại thiết bị";
            ADGVDSTB.Columns[3].HeaderText = "Số hiệu";
            ADGVDSTB.Columns[4].HeaderText = "Kho/Phòng bộ môn";
            ADGVDSTB.Columns[5].HeaderText = "Số lượng cần sửa";
            ADGVDSTB.Columns[6].HeaderText = "Đơn vị tính";
            ADGVDSTB.Columns[7].HeaderText = "Giá trị";
            ADGVDSTB.Columns[8].HeaderText = "Đơn giá";
            ADGVDSTB.Columns[9].HeaderText = "Thành tiền";
        }


        private void frmChiTietSuaChuaTB_Load(object sender, EventArgs e)
        {
            loadForm();
        }

        private void btnLayTB_Click(object sender, EventArgs e)
        {
            frmDialogTBSuaChua frm = new frmDialogTBSuaChua();
            frm.ShowDialog(this);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
