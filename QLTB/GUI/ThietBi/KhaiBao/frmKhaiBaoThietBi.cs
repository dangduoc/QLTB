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
        private DbThietBiHandler handler = new DbThietBiHandler();
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
            cbbPhongBM.DataSource = new DbDanhSachHandler().GetPhongBM().Select(p => new { key = p.PhongHocId, value = p.Ten }).ToList();
            cbbNguonKinhPhi.DisplayMember = "value";
            cbbNguonKinhPhi.ValueMember = "key";
            cbbNguonKinhPhi.DataSource = new DbNguonKinhPhiHandler().GetForCBB().Select(p => new { key = p.NguonKinhPhiId, value = p.Ten }).ToList();
            cbbMucDichSD.DisplayMember = "value";
            cbbMucDichSD.ValueMember = "key";
            cbbMucDichSD.DataSource = new DbDanhSachHandler().GetMucDichSDPhong().Select(p => new { key = p.MucDichSDPhongId, value = p.Ten }).ToList();
            cbbDVT.DisplayMember = "value";
            cbbDVT.ValueMember = "key";
            cbbDVT.DataSource = new DbDanhSachHandler().GetDVT().Select(p => new { key = p.DonViTinhId, value = p.Ten }).ToList();
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
            foreach(var item in layoutControl1.Controls.OfType<DevComponents.DotNetBar.Controls.ComboBoxEx>())
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
            var ThietBiMoi = new ThietBiModel();
            ThietBiMoi.ThietBiId = cbbMaThietBi.SelectedValue.ToString();
            ThietBiMoi.Ten = txtTen.Text;
            ThietBiMoi.SoHieu = txtSoHieu.Text;
            ThietBiMoi.QuyCachSD = txtQuyCach.Text;
            ThietBiMoi.PhongHocId = MyConvert.To<int>(cbbPhongBM.SelectedValue);
            ThietBiMoi.NguonKinhPhiId = (int)cbbNguonKinhPhi.SelectedValue;
            ThietBiMoi.NamDuaVaoSD = MyConvert.To<short>(txtNamSD.Text);
            ThietBiMoi.NamTheoDoi = MyConvert.To<short>(txtNamTheoDoi.Text);
            ThietBiMoi.DonViTinhId = MyConvert.To<int>(cbbDVT.SelectedValue);
            ThietBiMoi.SoLuong = MyConvert.To<short>(txtSoLuong.Text);
            ThietBiMoi.DonGia = MyConvert.To<double>(txtDonGia.Text);
            ThietBiMoi.ThanhTien = MyConvert.To<decimal>(txtThanhTien.Text);
            ThietBiMoi.NuocSanXuat = txtNuocSX.Text;
            ThietBiMoi.MucDichSDId = MyConvert.To<int>(cbbMucDichSD.SelectedValue);
            ThietBiMoi.HanSD = dpickerHanSD.Value;
            ThietBiMoi.NgaySanXuat = dpickNgaySX.Value;
            ThietBiMoi.IsThietBiTuLam = cboxThietBiTuLam.Checked;
            ThietBiMoi.NgayDuaVaoSD = dpickerNgaySD.Value;
            //
            ThietBiMoi.CreateByUserId = GlobalVariable.GetUser().UserName;
            ThietBiMoi.CreatedOnDate = DateTime.Now;
            ThietBiMoi.UpdatedByUserId = ThietBiMoi.CreateByUserId;
            ThietBiMoi.UpdatedOnDate = ThietBiMoi.CreatedOnDate;
            if (ThietBi == null)
            {   
                int result = handler.Create(ThietBiMoi);
                if (result == 1)
                {
                    MessageBox.Show("Thiết bị được khai báo thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
           // loadData();
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
            if(item.SelectedIndex>=0)
            txtSoHieu.Text= new DbThietBiHandler().GenerateCode(item.SelectedValue.ToString().Trim());
            else
            {
                txtSoHieu.Text = "";
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr= MessageBox.Show("Bạn chắc chắn muốn xóa thiết bị này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
    }
}
