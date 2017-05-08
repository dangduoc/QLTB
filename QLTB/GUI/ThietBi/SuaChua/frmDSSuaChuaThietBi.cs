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
    public partial class frmDSSuaChuaThietBi : Form
    {
        public frmDSSuaChuaThietBi()
        {
            InitializeComponent();
        }
        private void loadForm()
        {
            List<PhieuSuaTBGridDisplayModel> list = new List<PhieuSuaTBGridDisplayModel>();
            list.Add(new PhieuSuaTBGridDisplayModel
            {
                SoPhieu="PSCTB00001",
                NgayLap="21/11/2010",
                GhiChu=""
            });
            list.Add(new PhieuSuaTBGridDisplayModel
            {
                SoPhieu = "PSCTB00002",
                NgayLap = "21/11/2010",
                GhiChu = ""
            });
            list.Add(new PhieuSuaTBGridDisplayModel
            {
                SoPhieu = "PSCTB00003",
                NgayLap = "21/11/2010",
                GhiChu = ""
            });
            list.Add(new PhieuSuaTBGridDisplayModel
            {
                SoPhieu = "PSCTB00004",
                NgayLap = "21/11/2010",
                GhiChu = ""
            });

            advancedDataGridView.DataSource = list;
            advancedDataGridView.Columns[0].HeaderText = "Số phiếu";
            advancedDataGridView.Columns[0].Width = 100;
            advancedDataGridView.Columns[1].Width = 100;
            advancedDataGridView.Columns[1].HeaderText = "Ngày lập";
            advancedDataGridView.Columns[2].HeaderText = "Ghi chú";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            frmChiTietSuaChuaTB frm = new frmChiTietSuaChuaTB();
            frm.MdiParent = MdiParent;
            frm.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDSSuaChuaThietBi_Load(object sender, EventArgs e)
        {
            loadForm();
        }
    }
}
