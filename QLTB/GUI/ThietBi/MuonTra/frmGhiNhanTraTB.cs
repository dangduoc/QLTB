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
    public partial class frmGhiNhanTraTB : Form
    {
        public frmGhiNhanTraTB()
        {
            InitializeComponent();
        }
        private void loadForm()
        {
            List<ThietBiTraGridDisplayModel> list = new List<ThietBiTraGridDisplayModel>();
            ADGVDSTB.DataSource = list;
            ADGVDSTB.Columns[0].HeaderText = "Mã thiết bị";
            ADGVDSTB.Columns[1].HeaderText = "Tên thiết bị";
            ADGVDSTB.Columns[2].HeaderText = "Số hiệu";
            ADGVDSTB.Columns[3].HeaderText = "Kho/ phòng";
            ADGVDSTB.Columns[4].HeaderText = "Số lượng mượn";
            ADGVDSTB.Columns[5].HeaderText = "Đơn vị tính";
            ADGVDSTB.Columns[6].HeaderText = "Tình trạng khi trả";
            ADGVDSTB.Columns[7].HeaderText = "Tiêu hao";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
