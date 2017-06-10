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
using QLTB.Handler;

namespace QLTB.GUI
{
    public partial class frmThemLopHoc : DevComponents.DotNetBar.Office2007Form
    {
        DbLopHocHandler handler = new DbLopHocHandler();
        private LopHocModel LopHoc;
        public frmThemLopHoc()
        {
            InitializeComponent();
            LopHoc = null;
        }
        public frmThemLopHoc(int id)
        {
            InitializeComponent();
            LopHoc= handler.GetById(id);
            if (LopHoc == null)
            {
                MessageBox.Show("Không tìm thấy lớp học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }
        private void loadForm()
        {
            cbbKhoiLop.ValueMember = "key";
            cbbKhoiLop.DisplayMember = "value";
            cbbKhoiLop.DataSource = new DbKhoiLopHandler().GetAllModel().Select(p => new { key = p.KhoiLopId, value = p.Ten }).ToList();
        }
        private void saveData()
        {
            LopHocModel LopHocMoi = new LopHocModel
            {
                KhoiLopId=(int)cbbKhoiLop.SelectedValue,
                Ten=txtTenLop.Text
            };
            if (LopHoc != null)
            {
                int result=handler.Create(LopHocMoi);
                if (result == 1)
                {
                    MessageBox.Show("Thêm lớp học thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm lớp học không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                int result=handler.Update(LopHocMoi);
                if (result == 1)
                {
                    MessageBox.Show("Cập nhật thông tin lớp học thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin lớp học không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void frmThemLopHoc_Load(object sender, EventArgs e)
        {
            loadForm();
        }
    }
}
