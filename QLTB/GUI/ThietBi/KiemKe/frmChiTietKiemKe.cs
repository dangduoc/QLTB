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
    public partial class frmChiTietKiemKe : DevComponents.DotNetBar.Office2007Form
    {
        public frmChiTietKiemKe()
        {
            InitializeComponent();
        }
        private void loadForm()
        {
           
            List<BanKiemKeGridDisplayModel> list = new List<BanKiemKeGridDisplayModel>();
            list.Add(new BanKiemKeGridDisplayModel
            {
                HoTen="Đặng Minh Được",
                ChucVu="Trưởng ban kiểm kê",
                DaiDien="Ban giám hiệu",
                VaiTro=""
            });
            DataGridViewLinkColumn col = new DataGridViewLinkColumn();
            DataGridViewLinkColumn col2 = new DataGridViewLinkColumn();
            col2.HeaderText = "STT";
            col2.Width = 30;
            col2.Text = "1";
            col2.LinkColor = Color.White;
            col2.UseColumnTextForLinkValue = true;
            col.Width = 50;
            col.HeaderText = "";
            gridBanKiemKe.Columns.Add(col2);
            gridBanKiemKe.Columns.Add(col);
            gridBanKiemKe.DataSource = list;
            gridBanKiemKe.Columns[2].HeaderText = "Họ tên";
            gridBanKiemKe.Columns[3].HeaderText = "Chức vụ";
            gridBanKiemKe.Columns[4].HeaderText = "Đại diện";
            gridBanKiemKe.Columns[5].HeaderText = "Vai trò";
            gridBanKiemKe.Columns[1].DisplayIndex = 5;
            gridBanKiemKe.Refresh();
            gridBanKiemKe.Update();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmChiTietKiemKe_Load(object sender, EventArgs e)
        {
            loadForm();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
