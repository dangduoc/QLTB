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
    public partial class frmThongTinDonVi : DevComponents.DotNetBar.Office2007Form
    {
        private ThongTinDonViModel DonVi;
        private DbThongTinDVHandler handler= new DbThongTinDVHandler();
        private DbDanhSachHandler dshandler = new DbDanhSachHandler();
        public frmThongTinDonVi()
        {
            InitializeComponent();
            DonVi = handler.Get();
        }
        private void DisableHighlightCBB()
        {
            foreach (var item in layoutControl1.Controls.OfType<DevComponents.DotNetBar.Controls.ComboBoxEx>())
            {
                BeginInvoke(new Action(() => { item.Select(0, 0); }));
            }
            foreach (var item in layoutControl2.Controls.OfType<DevComponents.DotNetBar.Controls.ComboBoxEx>())
            {
                BeginInvoke(new Action(() => { item.Select(0, 0); }));
            }
        }
        private void loadForm()
        {
            #region combobox set up
            foreach (var item in layoutControl1.Controls.OfType<DevComponents.DotNetBar.Controls.ComboBoxEx>())
            {
                item.DisplayMember = "value";
                item.ValueMember = "key";
            }
            foreach (var item in layoutControl2.Controls.OfType<DevComponents.DotNetBar.Controls.ComboBoxEx>())
            {
                item.DisplayMember = "value";
                item.ValueMember = "key";
            }
            //
            cbbKhoiTruong.DataSource = GlobalVariable.GetDS().KhoiTruong.Select(p => new { key = p.KhoiTruongId, value = p.Ten }).ToList();
            cbbLoaiTruong.DataSource = GlobalVariable.GetDS().LoaiHinhTruong.Select(p => new { key = p.Id, value = p.Ten }).ToList();
            cbbLoaiTruongCB.DataSource = GlobalVariable.GetDS().LoaiTruongChuyenBiet.Select(p => new { key = p.Id, value = p.Ten }).ToList();
            cbbCapTruong.DataSource = GlobalVariable.GetDS().CapTruong.Select(p => new { key = p.CapTruongId, value = p.Ten }).ToList();
            cbbDacBietVM.DataSource = GlobalVariable.GetDS().VungMien.Select(p => new { key = p.Id, value = p.Ten }).ToList();
            cbbHangTruong.DataSource = GlobalVariable.GetDS().HangTruong.Select(p => new { key = p.Id, value = p.Ten }).ToList();
            cbbHinhThucDT.DataSource = GlobalVariable.GetDS().HinhThucDaoTao.Select(p => new { key = p.Id, value = p.Ten }).ToList();
            cbbTinhThanh.DataSource = dshandler.GetTinhThanh().Select(p => new { key = p.TinhThanhId, value = p.Ten }).ToList();
            cbbQuanHuyen.DataSource = dshandler.GetQuanHuyen().Select(p => new { key = p.QuanHuyenId, value = p.Ten }).ToList();
            cbbPhuongXa.DataSource = dshandler.GetPhuongXa().Select(p => new { key = p.PhuongXaId, value = p.Ten }).ToList();
            cbbTinhThanh.SelectedValueChanged += CbbTinhThanh_SelectedValueChanged;
            cbbQuanHuyen.SelectedValueChanged += CbbQuanHuyen_SelectedValueChanged;
            #endregion
                
            if (DonVi != null)
            {
                txtMaDV.Text = DonVi.MaDonVi;
                txtTenTruong.Text = DonVi.Ten;
                txtDonViChuQuan.Text = DonVi.DonViChuQuan;
                cbbKhoiTruong.SelectedValue = DonVi.KhoiTruongId;
                cbbCapTruong.SelectedValue = DonVi.CapTruongId;
                cbbHinhThucDT.SelectedValue = DonVi.HinhThucDaoTaoId;
                cbbLoaiTruong.SelectedValue = DonVi.LoaiHinhTruongId;
                cbbLoaiTruongCB.SelectedValue = DonVi.LoaiTruongChuyenBietId;
                cbbHangTruong.SelectedValue = DonVi.HangTruongId;
                cbbDacBietVM.SelectedValue = DonVi.VungMienId;
                cboxChuanQG.Checked = DonVi.IsDatChuanQG;
                cbbTinhThanh.SelectedValue = DonVi.TinhThanhId;
                cbbQuanHuyen.SelectedValue = DonVi.QuanHuyenId;
                cbbPhuongXa.SelectedValue = DonVi.PhuongXaId;
                txtDiaChi.Text = DonVi.DuongPhoSoNha;
                txtEmail.Text = DonVi.Email;
                txtSDT.Text = DonVi.SDT;
                txtFax.Text = DonVi.Fax;
                txtWebsite.Text = DonVi.Website;
                txtHieuTruong.Text = DonVi.HieuTruong;
                txtCBTB.Text = DonVi.CanBoTb;
                txtKeToan.Text = DonVi.KeToan;
                txtNguoiLapBieu.Text = DonVi.NguoiLapBieu;
            }
            DisableHighlightCBB();
        }
        private void saveData()
        {
            var DonViMoi = new ThongTinDonViModel
            {
                MaDonVi = txtMaDV.Text,
                Ten = txtTenTruong.Text,
                SDT = txtSDT.Text,
                DuongPhoSoNha = txtDiaChi.Text,
                CanBoTb = txtCBTB.Text,
                CapTruongId = MyConvert.To<int>(cbbCapTruong.SelectedValue),
                DonViChuQuan = txtDonViChuQuan.Text,
                Email = txtEmail.Text,
                Fax = txtFax.Text,
                HangTruongId = MyConvert.To<int>(cbbHangTruong.SelectedValue),
                HieuTruong = txtHieuTruong.Text,
                HinhThucDaoTaoId = MyConvert.To<int>(cbbHinhThucDT.SelectedValue),
                IsDatChuanQG = cboxChuanQG.Checked,
                KeToan = txtKeToan.Text,
                KhoiTruongId = MyConvert.To<int>(cbbKhoiTruong.SelectedValue),
                LoaiHinhTruongId = MyConvert.To<int>(cbbLoaiTruong.SelectedValue),
                LoaiTruongChuyenBietId = MyConvert.To<int>(cbbLoaiTruongCB.SelectedValue),
                NguoiLapBieu = txtNguoiLapBieu.Text,
                PhuongXaId = MyConvert.To<int>(cbbPhuongXa.SelectedValue),
                QuanHuyenId = MyConvert.To<int>(cbbQuanHuyen.SelectedValue),
                TinhThanhId = MyConvert.To<int>(cbbTinhThanh.SelectedValue),
                VungMienId = MyConvert.To<int>(cbbDacBietVM.SelectedValue),
                Website = txtWebsite.Text,
                DiaChiHienThi = cbbTinhThanh.Text + ", " + cbbQuanHuyen.Text + ", " + cbbPhuongXa.Text
            };
            
            if (DonVi == null)
            {
                int result=handler.Create(DonViMoi);
                if (result == 1)
                {
                    MessageBox.Show("Thông tin đơn vị được lưu lại thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (result == 0)
                {
                    MessageBox.Show("Việc lưu lại bị gián đoạn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra, xin thử lại khi khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                int result=handler.Update(DonViMoi);
                if (result == 1)
                {
                    MessageBox.Show("Thông tin đơn vị được lưu lại thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (result == 0)
                {
                    MessageBox.Show("Việc lưu lại bị gián đoạn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra, xin thử lại khi khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void CbbTinhThanh_SelectedValueChanged(object sender, EventArgs e)
        {
            var id = (int)cbbTinhThanh.SelectedValue;
            cbbQuanHuyen.DataSource= dshandler.GetQuanHuyen(id).Select(p => new { key = p.QuanHuyenId, value = p.Ten }).ToList();
            cbbQuanHuyen.SelectedIndex = 0;
        }

        private void CbbQuanHuyen_SelectedValueChanged(object sender, EventArgs e)
        {
            var id = (int)cbbQuanHuyen.SelectedValue;
            cbbPhuongXa.DataSource= dshandler.GetPhuongXa(id).Select(p => new { key = p.PhuongXaId, value = p.Ten }).ToList();
            cbbPhuongXa.SelectedIndex = 0;
        }
        private void frmThongTinDonVi_Load(object sender, EventArgs e)
        {
            loadForm();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            saveData();
        }
    }
}
