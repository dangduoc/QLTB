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
using QLTB.Utils;
using System.IO;

namespace QLTB.GUI
{
    public partial class frmTaoGiaoVien : DevComponents.DotNetBar.Office2007Form
    {

        private DbGiaoVienHandler handler = new DbGiaoVienHandler();
        private DanhSachModel dshandler = new DanhSachModel();
        private GiaoVienModel GiaoVienMoi = new GiaoVienModel();
        private GiaoVienModel GiaoVien;
        public frmTaoGiaoVien()
        {
            InitializeComponent();
            GiaoVien = null;
            txtSoHieu.Text = handler.GenerateCode();
            txtSoHieu.Enabled = false;
        }
        public frmTaoGiaoVien(string Id)
        {
            InitializeComponent();
            GiaoVien = handler.GetById(Id);
            txtSoHieu.Enabled = false;
            if (GiaoVien == null)
            {
                MessageBox.Show("Không tìm thấy giáo viên nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }
        /// <summary>
        /// loading data
        /// </summary>
        private void loadForm()
        {
            //Comboboxes
            foreach (var item in layoutTTC.Controls.OfType<DevComponents.DotNetBar.Controls.ComboBoxEx>())
            {
                item.DisplayMember = "value";
                item.ValueMember = "key";
            }
            foreach (var item in layoutTTCV.Controls.OfType<DevComponents.DotNetBar.Controls.ComboBoxEx>())
            {
                item.DisplayMember = "value";
                item.ValueMember = "key";
            }
            foreach (var item in layoutTDCM.Controls.OfType<DevComponents.DotNetBar.Controls.ComboBoxEx>())
            {
                item.DisplayMember = "value";
                item.ValueMember = "key";
            }
            #region fill comboboxes
            cbbGioiTinh.DataSource = dshandler.GioiTinh.Select(p => new { key = p.GioiTinhId, value = p.Ten }).ToList();
            cbbChucVu.DataSource = dshandler.ChucVuGiaoVien.Select(p => new { key = p.Id, value = p.Ten }).ToList();
            cbbLoaiHD.DataSource = dshandler.LoaiHopDong.Select(p => new { key = p.Id, value = p.Ten }).ToList();
            cbbViTri.DataSource = dshandler.ViTriGiaoVien.Select(p => new { key = p.Id, value = p.Ten }).ToList();
            cbbTrinhDoCM.DataSource = dshandler.TrinhDoChuyenMon.Select(p => new { key = p.Id, value = p.Ten }).ToList();
            cbbTrinhDoChuan.DataSource = dshandler.TrinhDoChuan.Select(p => new { key = p.Id, value = p.Ten }).ToList();
            cbbDanToc.DataSource = new DbDanhSachHandler().GetDanToc().Select(p => new { key = p.DanTocId, value = p.Ten }).ToList();
            cbbMonHoc.DataSource = new DbMonHocHandler().GetAll().Select(p => new { key = p.MonHocId, value = p.Ten }).ToList();
            cbbToBM.DataSource = new DbToBoMonHandler().GetAll().Select(p => new { key = p.ToBoMonId, value = p.Ten }).ToList();
            //
            //cbbQLNhaNuoc
            //cbbQLGiaoDuc
            //cbbLyLuanCT
            cbbBienChe.Text = "Viên chức";
            //
            #endregion
            #region Loading data
            if (GiaoVien != null)
            {
                //Thong tin chung
                txtSoHieu.Text = GiaoVien.GiaoVienId;
                txtHoDem.Text = GiaoVien.HoVaDem;
                txtTen.Text = GiaoVien.Ten;
                txtHoTen.Text = GiaoVien.TenDayDu;
                if (GiaoVien.NgaySinh != null)
                    dpickerNgaySinh.Value = (DateTime)GiaoVien.NgaySinh;
                txtNoiSinh.Text = GiaoVien.NoiSinh;
                cbbGioiTinh.SelectedValue = GiaoVien.GioiTinhId;
                if (GiaoVien.DanTocId != null)
                {
                    cbbDanToc.SelectedValue = GiaoVien.DanTocId;
                }
                //Thong tin lien he
                txtDTCQ.Text = GiaoVien.DienThoaiCQ;
                txtDTDD.Text = GiaoVien.DienThoaiDD;
                txtEmailCN.Text = GiaoVien.EmailCN;
                txtEmailCQ.Text = GiaoVien.EmailCQ;
                //Thong tin cong viec
                if (GiaoVien.ViTriId != null)
                    cbbViTri.SelectedValue = GiaoVien.ViTriId;
                if (GiaoVien.ChucVuId != null)
                    cbbChucVu.SelectedValue = GiaoVien.ChucVuId;

                cbbToBM.SelectedValue = GiaoVien.PhongBanId;
                cbbLoaiHD.SelectedValue = GiaoVien.LoaiHopDongId;
                txtChucVuKiemNhiem.Text = GiaoVien.ChucVuKiemNhiem;
                if (GiaoVien.MonHocId != null)
                    cbbMonHoc.SelectedValue = GiaoVien.MonHocId;
                dpickerNgayVao.Value = GiaoVien.NgayVaoNganh;
                //Trinh do chuyen mon
                if (GiaoVien.TrinhDoId != null)
                    cbbTrinhDoCM.SelectedValue = GiaoVien.TrinhDoId;
                if (GiaoVien.TrinhDoChuanId != null)
                    cbbTrinhDoChuan.SelectedValue = GiaoVien.TrinhDoChuanId;
                // cbbLyLuanCT.SelectedValue
                cboxThamGiaBD.Checked = (bool)GiaoVien.IsThamGiaBoiDuong;
                //cbbQLNhaNuoc.SelectedValue
                //cbbQLGiaoDuc.SelectedValue  
                cboxDangVien.Checked = (bool)GiaoVien.IsLaDangVien;
                if (GiaoVien.NgayVaoDang != null)
                    dpickerNgayVaoDang.Value = (DateTime)GiaoVien.NgayVaoDang;
                //Ảnh đại diện
                string folder = Path.Combine(GlobalVariable.ImagePath(), GiaoVien.GiaoVienId);
                if (!string.IsNullOrEmpty(GiaoVien.AnhDaiDien))
                {
                    picBoxAnhDaiDien.ImageLocation = Path.Combine(folder, GiaoVien.AnhDaiDien);
                }

            }
            #endregion
            DisableHighlightCBB();

        }
        /// <summary>
        /// saveing data
        /// </summary>
        private void saveData()
        {

            GiaoVienMoi.GiaoVienId = txtSoHieu.Text;
            GiaoVienMoi.HoVaDem = txtHoDem.Text;
            if (dpickerNgaySinh.Value != new DateTime(1, 1, 1))
                GiaoVienMoi.NgaySinh = (DateTime)dpickerNgaySinh.Value;
            GiaoVienMoi.NoiSinh = txtNoiSinh.Text;
            GiaoVienMoi.ChucVuId = (int?)MyConvert.ChangeType(cbbChucVu.SelectedValue, typeof(int?));
            GiaoVienMoi.DanTocId = (int?)MyConvert.ChangeType(cbbDanToc.SelectedValue, typeof(int?));
            GiaoVienMoi.ChucVuKiemNhiem = txtChucVuKiemNhiem.Text;
            GiaoVienMoi.DienThoaiCQ = txtDTCQ.Text;
            GiaoVienMoi.DienThoaiDD = txtDTDD.Text;
            GiaoVienMoi.EmailCN = txtEmailCN.Text;
            GiaoVienMoi.EmailCQ = txtEmailCQ.Text;
            GiaoVienMoi.GioiTinhId = (int)cbbGioiTinh.SelectedValue;
            GiaoVienMoi.IsLaDangVien = cboxDangVien.Checked;
            GiaoVienMoi.IsThamGiaBoiDuong = cboxThamGiaBD.Checked;
            GiaoVienMoi.LoaiHopDongId = (int)cbbLoaiHD.SelectedValue;
            GiaoVienMoi.LyLuanChinhTriId = (int?)MyConvert.ChangeType(cbbLyLuanCT.SelectedValue, typeof(int?));
            GiaoVienMoi.MonHocId = (int?)MyConvert.ChangeType(cbbMonHoc.SelectedValue, typeof(int?));
            if (dpickerNgayVaoDang.Value != new DateTime(1, 1, 1))
                GiaoVienMoi.NgayVaoDang = (DateTime)dpickerNgayVaoDang.Value;
            GiaoVienMoi.NgayVaoNganh = (DateTime)dpickerNgayVao.Value;
            GiaoVienMoi.PhongBanId = (int)cbbToBM.SelectedValue;
            GiaoVienMoi.QuanLyGiaoDucId = (int?)MyConvert.ChangeType(cbbQLGiaoDuc.SelectedValue, typeof(int?));
            GiaoVienMoi.QuanLyNhaNuocId = (int?)MyConvert.ChangeType(cbbQLNhaNuoc.SelectedValue, typeof(int?));
            GiaoVienMoi.Ten = txtTen.Text;
            GiaoVienMoi.TenDayDu = txtHoTen.Text;
            GiaoVienMoi.TrinhDoChuanId = (int?)MyConvert.ChangeType(cbbTrinhDoChuan.SelectedValue, typeof(int?));
            GiaoVienMoi.TrinhDoId = (int?)MyConvert.ChangeType(cbbTrinhDoCM.SelectedValue, typeof(int?));
            GiaoVienMoi.ViTriId = (int?)MyConvert.ChangeType(cbbViTri.SelectedValue, typeof(int?));
            //Anh
            if (picBoxAnhDaiDien.Tag != null)
            {
                GiaoVienMoi.AnhDaiDien = picBoxAnhDaiDien.Tag.ToString() + ".png";
            }
            else if (GiaoVien != null)
            {
                GiaoVienMoi.AnhDaiDien = GiaoVien.AnhDaiDien;
            }
            if (GiaoVien != null)
            {
                GiaoVienMoi.TrangThai = GiaoVien.TrangThai;

                int result = handler.Update(GiaoVienMoi);
                if (result == 1)
                {
                    if (!string.IsNullOrEmpty(GiaoVienMoi.AnhDaiDien))
                    {
                        string folder = Path.Combine(GlobalVariable.ImagePath(), GiaoVienMoi.GiaoVienId);
                        //saving image
                        if (Directory.Exists(folder) == false)
                        {
                            Directory.CreateDirectory(folder);
                        }
                        else
                        {
                            DirectoryInfo di = new DirectoryInfo(folder);
                            di.Delete(true);
                            Directory.CreateDirectory(folder);
                        }
                        Methods.resizeImage(picBoxAnhDaiDien.ImageLocation, Path.Combine(folder, GiaoVienMoi.AnhDaiDien), 300, 400);
                    }
                    MessageBox.Show("Cập nhật thông tin đối tượng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin đối tượng không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                GiaoVienMoi.TrangThai = 1;
                int result = handler.Create(GiaoVienMoi);
                if (result == 1)
                {
                    if (!string.IsNullOrEmpty(GiaoVienMoi.AnhDaiDien))
                    {
                        string folder = Path.Combine(GlobalVariable.ImagePath(), GiaoVienMoi.GiaoVienId);
                        //saving image
                        if (Directory.Exists(folder) == false)
                        {
                            Directory.CreateDirectory(folder);
                        }
                        else
                        {
                            DirectoryInfo di = new DirectoryInfo(folder);
                            di.Delete(true);
                            Directory.CreateDirectory(folder);
                        }
                        Methods.resizeImage(picBoxAnhDaiDien.ImageLocation, Path.Combine(folder, GiaoVienMoi.AnhDaiDien), 300, 400);

                    }
                    MessageBox.Show("Thêm mới giáo viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm giáo viên không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void DisableHighlightCBB()
        {
            foreach (var item in layoutTTC.Controls.OfType<DevComponents.DotNetBar.Controls.ComboBoxEx>())
            {
                BeginInvoke(new Action(() => { item.Select(0, 0); }));
            }
            foreach (var item in layoutTTCV.Controls.OfType<DevComponents.DotNetBar.Controls.ComboBoxEx>())
            {
                BeginInvoke(new Action(() => { item.Select(0, 0); }));
            }
            foreach (var item in layoutTDCM.Controls.OfType<DevComponents.DotNetBar.Controls.ComboBoxEx>())
            {
                BeginInvoke(new Action(() => { item.Select(0, 0); }));
            }
        }
        private void frmTaoGiaoVien_Load(object sender, EventArgs e)
        {
            loadForm();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnChangePicture_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                picBoxAnhDaiDien.Image = null;
                picBoxAnhDaiDien.ImageLocation = open.FileName;
                picBoxAnhDaiDien.Tag = Path.GetFileNameWithoutExtension(open.FileName);


            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            saveData();
        }

        private void frmTaoGiaoVien_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnBack_Click(null, null);
            }
        }
    }
}
