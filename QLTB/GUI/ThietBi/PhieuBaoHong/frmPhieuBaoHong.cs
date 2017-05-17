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
    public partial class frmPhieuBaoHong : DevComponents.DotNetBar.Office2007Form
    {
        public frmPhieuBaoHong()
        {
            InitializeComponent();
        }
        private void loadForm()
        {
            List<ThietBiHongGridDisplayModel> list = new List<ThietBiHongGridDisplayModel>();
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

            ADGVDSTB.Columns[0].HeaderText = "Số hiệu";
            ADGVDSTB.Columns[1].HeaderText = "Mã thiết bị";
            ADGVDSTB.Columns[2].HeaderText = "Tên thiết bị";
            ADGVDSTB.Columns[3].HeaderText = "Kho/Phòng bộ môn";
            ADGVDSTB.Columns[4].HeaderText = "Số lượng mượn";
            ADGVDSTB.Columns[5].HeaderText = "Đơn vị tính";
            ADGVDSTB.Columns[6].HeaderText = "Tình trạng";
            ADGVDSTB.Columns[7].HeaderText = "Lý do hỏng/mất";
            ADGVDSTB.Columns[8].HeaderText = "Tình trạng hỏng hóc";
        }

        private void frmPhieuBaoHong_Load(object sender, EventArgs e)
        {
            loadForm();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
