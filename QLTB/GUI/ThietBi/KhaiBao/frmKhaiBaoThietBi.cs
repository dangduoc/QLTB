using QLTB.Handler;
using QLTB.Model;
using QLTB.Utils;
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
    public partial class frmKhaiBaoThietBi : DevComponents.DotNetBar.Office2007Form
    {
        private ThietBiModel ThietBi;
        private ThietBiModel ThietBiMoi = new ThietBiModel();
        private DbThietBiHandler handler = new DbThietBiHandler();
        private DbDanhSachHandler dshandler = new DbDanhSachHandler();
        List<object> listValidate;
        public frmKhaiBaoThietBi(string Id)
        {
            InitializeComponent();
            ThietBi = handler.GetById(Id);

        }
        public frmKhaiBaoThietBi()
        {
            InitializeComponent();
            ThietBi = null;
        }
        private bool Validate(out string message)
        {
            foreach (var item in listValidate)
            {
                if (item.GetType() == typeof(DevComponents.DotNetBar.Controls.TextBoxX))
                {
                    var tmp = (DevComponents.DotNetBar.Controls.TextBoxX)item;
                    if (String.IsNullOrEmpty(tmp.Text))
                    {
                        message = tmp.Tag.ToString();
                        return false;
                    }
                }
                else if (item.GetType() == typeof(DevComponents.DotNetBar.Controls.ComboBoxEx))
                {
                    var tmp = (DevComponents.DotNetBar.Controls.ComboBoxEx)item;
                    if (tmp.SelectedIndex < 0)
                    {
                        message = tmp.Tag.ToString();
                        return false;
                    }
                }
            }
            message = "";
            return true;
        }
        private void loadData()
        {
            
            #region Khai báo các control
            //Khai bao truong can nhap
            listValidate = new List<object>()
            {
                cbbMaThietBi,
                txtSoHieu,
                cbbPhongBM,
                txtNamSD,
                
                txtNamTheoDoi,
                cbbNguonKinhPhi,
                cbbDVT,
                txtSoLuong
            };
            txtSoHieu.LostFocus += LostFocusCheck;
            txtNamSD.LostFocus += LostFocusCheck;
            txtNamTheoDoi.LostFocus += LostFocusCheck;
            txtSoLuong.LostFocus += LostFocusCheck;
            //
            //combobox ma thiet bi toi thieu
            //cbbMaThietBi.DisplayMember = "value";
            //cbbMaThietBi.ValueMember = "key";
            cbbMaThietBi.DataSource = new DbThietBiTTHandler().GetMaTB();
            cbbPhongBM.DisplayMember = "value";
            cbbPhongBM.ValueMember = "key";
            cbbPhongBM.DataSource = dshandler.GetPhongBM().Select(p => new { key = p.PhongHocId, value = p.Ten }).ToList();
            cbbNguonKinhPhi.DisplayMember = "value";
            cbbNguonKinhPhi.ValueMember = "key";
            cbbNguonKinhPhi.DataSource = dshandler.GetNguonKP().Select(p => new { key = p.NguonKinhPhiId, value = p.Ten }).ToList();
            cbbMucDichSD.DisplayMember = "value";
            cbbMucDichSD.ValueMember = "key";
            cbbMucDichSD.DataSource = dshandler.DanhSachCoDinh.MucDichSDThietBi.Select(p => new { key = p.Id, value = p.Ten }).ToList();
            cbbDVT.DisplayMember = "value";
            cbbDVT.ValueMember = "key";
            cbbDVT.DataSource = dshandler.GetDVT().Select(p => new { key = p.DonViTinhId, value = p.Ten }).ToList();
            #endregion
            #region Load data khi sửa
            if (ThietBi != null)
            {
                cbbMaThietBi.SelectedItem = ThietBi.ThietBiId;
                cbbPhongBM.SelectedValue = ThietBi.PhongHocId;
                cbbNguonKinhPhi.SelectedValue = ThietBi.NguonKinhPhiId;
                cbbMucDichSD.SelectedValue = ThietBi.MucDichSDId;
                txtTen.Text = ThietBi.Ten;
                txtSoHieu.Text = ThietBi.SoHieu;
                txtQuyCach.Text = ThietBi.QuyCachSD;
                txtNamSD.Text = ThietBi.NamDuaVaoSD.ToString();
                txtNamTheoDoi.Text = ThietBi.NamTheoDoi.ToString();
                cbbDVT.SelectedValue = ThietBi.DonViTinhId;
                txtSoLuong.Text = ThietBi.SoLuong.ToString();
                txtDonGia.Text = ThietBi.DonGia.ToString();
                txtThanhTien.Text = ThietBi.ThanhTien.ToString();
                txtNuocSX.Text = ThietBi.NuocSanXuat;
                cboxThietBiTuLam.Checked = ThietBi.IsThietBiTuLam;
                dpickerNgaySD.Value = ThietBi.NgayDuaVaoSD;
                //
                if (ThietBi.HanSD != null)
                    dpickerHanSD.Value = ThietBi.HanSD.Value;
                if (ThietBi.NgaySanXuat != null)
                {
                    dpickNgaySX.Value = ThietBi.NgaySanXuat.Value;
                }
                cbbMaThietBi.Enabled = false;
                txtSoHieu.Enabled = false;
            }
            #endregion
            DisableHighlightCBB();
        }
        private void DisableHighlightCBB()
        {
            foreach (var item in layoutControl1.Controls.OfType<DevComponents.DotNetBar.Controls.ComboBoxEx>())
            {
                BeginInvoke(new Action(() => { item.Select(0, 0); }));
            }
        }
        private void LostFocusCheck(object sender, EventArgs e)
        {
            var control = sender as Control;
            if (String.IsNullOrEmpty(control.Text))
                errorProvider.SetError((Control)sender, "Trường này là trường bắt buộc!");
            else
                errorProvider.Clear();
        }

        private void saveData()
        {
            ThietBiMoi.ThietBiId = cbbMaThietBi.SelectedValue.ToString();
            ThietBiMoi.Ten = txtTen.Text;
            ThietBiMoi.SoHieu = txtSoHieu.Text;
            ThietBiMoi.QuyCachSD = txtQuyCach.Text;
            ThietBiMoi.PhongHocId = (int)cbbPhongBM.SelectedValue;
            ThietBiMoi.NguonKinhPhiId = (int)cbbNguonKinhPhi.SelectedValue;
            int tmp;
            double tmp1;
            decimal tmp2;
            if (int.TryParse(txtNamSD.Text, out tmp))
                ThietBiMoi.NamDuaVaoSD = tmp;
            if (int.TryParse(txtNamTheoDoi.Text, out tmp))
                ThietBiMoi.NamTheoDoi = tmp;
            ThietBiMoi.DonViTinhId = (int)cbbDVT.SelectedValue;
            if (int.TryParse(txtSoLuong.Text, out tmp))
                ThietBiMoi.SoLuong = tmp;

            if (double.TryParse(txtSoLuong.Text, out tmp1))
                ThietBiMoi.DonGia = tmp1;
            if (decimal.TryParse(txtThanhTien.Text, out tmp2))
                ThietBiMoi.ThanhTien = tmp2;
            ThietBiMoi.NuocSanXuat = txtNuocSX.Text;
            ThietBiMoi.MucDichSDId = (int)cbbMucDichSD.SelectedValue;
            if (dpickerHanSD.Value != new DateTime(1, 1, 1))
            {
                ThietBiMoi.HanSD = dpickerHanSD.Value;
            }
            if(dpickNgaySX.Value!=new DateTime(1, 1, 1))
            {
                ThietBiMoi.NgaySanXuat = dpickNgaySX.Value;
            }
            ThietBiMoi.IsThietBiTuLam = cboxThietBiTuLam.Checked;
            ThietBiMoi.NgayDuaVaoSD = dpickerNgaySD.Value;
            ThietBiMoi.CreateByUserId = GlobalVariable.GetUser().UserId;
            ThietBiMoi.CreatedOnDate = DateTime.Now;
            ThietBiMoi.UpdatedByUserId = ThietBiMoi.CreateByUserId;
            ThietBiMoi.UpdatedOnDate = ThietBiMoi.CreatedOnDate;
            if (ThietBi == null)
            {
                ThietBiMoi.MonHocId = new DbThietBiTTHandler().GetById(ThietBiMoi.ThietBiId).MonHocId;
                ThietBiMoi.TrangThai = 0;
                ThietBiMoi.SoLuongCon = ThietBiMoi.SoLuong;
                int result = handler.Create(ThietBiMoi);
                if (result == 1)
                {
                    MessageBox.Show("Thiết bị được khai báo thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    foreach (var item in layoutControl1.Controls.OfType<DevComponents.DotNetBar.Controls.TextBoxX>())
                    {
                        item.Text = "";
                    }
                    foreach (var item in layoutControl1.Controls.OfType<DevComponents.DotNetBar.Controls.ComboBoxEx>())
                    {
                        item.SelectedIndex = 0;
                    }
                    txtQuyCach.Text = "";
                }
                else if (result == 0)
                {
                    MessageBox.Show("Khai báo thiết bị không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra, xin thử lại khi khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                int result = handler.Update(ThietBiMoi);
                if (result == 1)
                {
                    MessageBox.Show("Thay đổi thông tin thiết bị thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (result == 0)
                {
                    MessageBox.Show("Thay đổi thông tin thiết bị không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra, xin thử lại khi khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frmKhaiBaoThietBi_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string inform = "";
            bool validate = Validate(out inform);
            if (validate)
            {
                saveData();
            }
            else
            {
                MessageBox.Show("Trường " + inform + " là trường bắt buộc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cbbMaThietBi_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = sender as DevComponents.DotNetBar.Controls.ComboBoxEx;
            if (item.SelectedIndex >= 0)
            {
                var tb = new DbThietBiTTHandler().GetById(item.SelectedValue.ToString().Trim());
                txtSoHieu.Text = handler.GenerateCode(item.SelectedValue.ToString().Trim());
                txtTen.Text = tb.Ten;
                ThietBiMoi.MonHocId = tb.MonHocId;


            }
            else
            {
                txtSoHieu.Text = "";
                txtTen.Text = "";
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa thiết bị này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int result = new DbThietBiHandler().Delete(ThietBi.SoHieu);
                if (result == 1) MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("Xóa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
        #region Xử lý sự kiện
        private void txtThanhTien_Enter(object sender, EventArgs e)
        {
            int dongia, soluong, thanhtien;
            if (int.TryParse(txtDonGia.Text, out dongia) && int.TryParse(txtSoLuong.Text, out soluong))
            {
                thanhtien = dongia * soluong;
                txtThanhTien.Text = thanhtien.ToString();
            }
            else
            {
                txtThanhTien.Text = "";
            }
        }

        private void txtDonGia_MouseLeave(object sender, EventArgs e)
        {
            txtThanhTien_Enter(null, null);
        }

        private void dpickerNgaySD_Enter(object sender, EventArgs e)
        {
            int nam;
            if (int.TryParse(txtNamSD.Text, out nam))
            {
                dpickerNgaySD.MinDate = new DateTime(nam, 1, 1);
                dpickerNgaySD.Value = dpickerNgaySD.MinDate;
            }
        }
        private void txtNamSD_MouseLeave(object sender, EventArgs e)
        {
            int nam;
            if (int.TryParse(txtNamSD.Text, out nam))
            {
                dpickerNgaySD.MinDate = new DateTime(nam, 1, 1);
                dpickerNgaySD.Value = dpickerNgaySD.MinDate;
            }
        }
        private void dpickerNgaySD_ValueChanged(object sender, EventArgs e)
        {
            txtNamSD.Text = dpickerNgaySD.Value.Year.ToString();
        }
        private void txtNamTheoDoi_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void btnAddTB_Click(object sender, EventArgs e)
        {
            frmTaoThietBiTT frm = new frmTaoThietBiTT();
            frm.ShowDialog(this);
        }

        private void btnAddPhongBM_Click(object sender, EventArgs e)
        {
            frmTaoPhongBM frm = new frmTaoPhongBM();
            frm.ShowDialog(this);
        }


        #endregion

        private void frmKhaiBaoThietBi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
