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
        public frmGhiNhanTraTB(string Id)
        {
            InitializeComponent();
        }
        private void loadForm()
        {
            List<ThietBiTraGridDisplayModel> list = new List<ThietBiTraGridDisplayModel>();
            gridDSThietBiMuon.DataSource = list;
            gridDSThietBiMuon.Columns[0].HeaderText = "Mã thiết bị";
            gridDSThietBiMuon.Columns[1].HeaderText = "Tên thiết bị";
            gridDSThietBiMuon.Columns[2].HeaderText = "Số hiệu";
            gridDSThietBiMuon.Columns[3].HeaderText = "Kho/ phòng";
            gridDSThietBiMuon.Columns[4].HeaderText = "Số lượng mượn";
            gridDSThietBiMuon.Columns[5].HeaderText = "Đơn vị tính";
            gridDSThietBiMuon.Columns[6].HeaderText = "Tình trạng khi trả";
            gridDSThietBiMuon.Columns[7].HeaderText = "Tiêu hao";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
