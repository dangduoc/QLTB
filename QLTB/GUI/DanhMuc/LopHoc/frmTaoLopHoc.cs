using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTB.Handler;
using QLTB.Model;
namespace QLTB.GUI
{
    public partial class frmTaoLopHoc : DevComponents.DotNetBar.Office2007Form
    {
        public frmTaoLopHoc()
        {
            InitializeComponent();
        }
        private void loadForm()
        {
            //
            foreach(var item in pnlBack.Controls.OfType<DevComponents.DotNetBar.Controls.ComboBoxEx>())
            {
                item.DisplayMember = "value";
                item.ValueMember = "key";
            }
            //
            cbbKhoiLop1.DataSource = new DbKhoiLopHandler().GetAllModel().Select(p => new { key = p.KhoiLopId, value = p.Ten }).ToList();
            cbbKhoiLop2.DataSource = cbbKhoiLop1.DataSource;
            cbbKhoiLop3.DataSource = cbbKhoiLop1.DataSource;
            cbbKhoiLop4.DataSource = cbbKhoiLop1.DataSource;
            //
            var list = new List<object>();
            list.Add(new { key = 1, value = "123" });
            list.Add(new { key = 2, value = "ABC" });
            cbbTangTheo1.DataSource = list;
            cbbTangTheo2.DataSource = list;
            cbbTangTheo3.DataSource = list;
            cbbTangTheo4.DataSource = list;
        }
        private void frmTaoLopHoc_Load(object sender, EventArgs e)
        {
            loadForm();
        }
    }
}
