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
    public partial class frmTaoMonHoc : DevComponents.DotNetBar.Office2007Form
    {
        private DbMonHocHandler handler = new DbMonHocHandler();
        private DanhSachModel dshandler = new DanhSachModel();
        private MonHocModel MonHoc;
        public frmTaoMonHoc()
        {
            InitializeComponent();
            MonHoc = null;
        }
        public frmTaoMonHoc(int Id)
        {
            InitializeComponent();
            MonHoc = handler.GetById(Id);
            if (MonHoc == null)
            {
                MessageBox.Show("Không tìm thấy môn học nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }
        private void loadForm()
        {
            foreach (var item in layoutControl.Controls.OfType<DevComponents.DotNetBar.Controls.ComboBoxEx>())
            {
                item.ValueMember = "key";
                item.DisplayMember = "value";
            }
            //
            cbbKieuMon.DataSource = dshandler.LoaiMonHoc.Select(p => new { key = p.Id, value = p.Ten }).ToList();
            cbbLoaiDanhGia.DataSource = dshandler.DanhGiaMonHoc.Select(p => new { key = p.Id, value = p.Ten }).ToList();
            //
            if (MonHoc != null)
            {
                txtTen.Text = MonHoc.Ten;
                cbbKieuMon.SelectedValue = MonHoc.LoaiMonHocId;
                cbbLoaiDanhGia.SelectedValue = MonHoc.LoaiDanhGiaId;
                txtMaMonHoc.Text = MonHoc.MaMonHoc;
            }
            DisableHighlightCBB();
        }
        private void DisableHighlightCBB()
        {
            foreach (var item in layoutControl.Controls.OfType<DevComponents.DotNetBar.Controls.ComboBoxEx>())
            {
                BeginInvoke(new Action(() => { item.Select(0, 0); }));
            }
        }
        private void saveData()
        {
            MonHocModel MonHocMoi = new MonHocModel
            {
                MaMonHoc = txtMaMonHoc.Text,
                LoaiDanhGiaId = (int)cbbLoaiDanhGia.SelectedValue,
                LoaiMonHocId = (int)cbbKieuMon.SelectedValue,
                Ten = txtTen.Text
            };
            if (MonHoc != null)
            {
                MonHocMoi.MonHocId = MonHoc.MonHocId;

                int result = handler.Update(MonHocMoi);
                if (result == 1)
                {
                    MessageBox.Show("Cập nhật thông tin môn học thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin môn học không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                int result = handler.Create(MonHocMoi);
                if (result == 1)
                {
                    MessageBox.Show("Thêm mới môn học thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm mới môn học không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void frmTaoMonHoc_Load(object sender, EventArgs e)
        {
            try
            {
                loadForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Xảy ra lỗi", MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                saveData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Xảy ra lỗi", MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
            }
        }

        private void frmTaoMonHoc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave_Click(null, null);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
