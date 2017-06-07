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
    public partial class frmTaoGiaoVien : DevComponents.DotNetBar.Office2007Form
    {
        private DbGiaoVienHandler handler = new DbGiaoVienHandler();
        private DanhSachModel dshandler = new DanhSachModel();
        private GiaoVienModel GiaoVien;
        public frmTaoGiaoVien()
        {
            InitializeComponent();
            GiaoVien = null;
        }
        public frmTaoGiaoVien(string Id)
        {
            InitializeComponent();
            GiaoVien=handler.GetById(Id);
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
            cbbChucVu.DataSource= dshandler.ChucVuGiaoVien.Select(p => new { key = p.Id, value = p.Ten }).ToList();
            cbbLoaiHD.DataSource = dshandler.LoaiHopDong.Select(p => new { key = p.Id, value = p.Ten }).ToList();
            cbbViTri.DataSource = dshandler.ViTriGiaoVien.Select(p => new { key = p.Id, value = p.Ten }).ToList();
            cbbTrinhDoCM.DataSource = dshandler.TrinhDoChuyenMon.Select(p => new { key = p.Id, value = p.Ten }).ToList();
            cbbTrinhDoChuan.DataSource = dshandler.TrinhDoChuan.Select(p => new { key = p.Id, value = p.Ten }).ToList();
            cbbDanToc.DataSource = new DbDanhSachHandler().GetDanToc().Select(p => new { key = p.DanTocId, value = p.Ten }).ToList();
            cbbMonHoc.DataSource=new DbMonHocHandler().GetAll().Select(p => new { key = p.MonHocId, value = p.Ten }).ToList();
            cbbToBM.DataSource=new DbToBoMonHandler().GetAll().Select(p => new { key = p.ToBoMonId, value = p.Ten }).ToList();
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
                if(GiaoVien.NgaySinh!=null)
                dpickerNgaySinh.Value = (DateTime)GiaoVien.NgaySinh;
                txtNoiSinh.Text = GiaoVien.NoiSinh;
                cbbGioiTinh.SelectedValue = GiaoVien.GioiTinhId;
                cbbDanToc.SelectedValue = GiaoVien.DanTocId;
                //Thong tin lien he
                txtDTCQ.Text = GiaoVien.DienThoaiCQ;
                txtDTDD.Text = GiaoVien.DienThoaiDD;
                txtEmailCN.Text = GiaoVien.EmailCN;
                txtEmailCQ.Text = GiaoVien.EmailCQ;
                //Thong tin cong viec
                cbbViTri.SelectedValue = GiaoVien.ViTriId;
                cbbChucVu.SelectedValue = GiaoVien.ChucVuId;
                cbbToBM.SelectedValue = GiaoVien.PhongBanId;
                cbbLoaiHD.SelectedValue = GiaoVien.LoaiHopDongId;
                txtChucVuKiemNhiem.Text = GiaoVien.ChucVuKiemNhiem;
                cbbMonHoc.SelectedValue = GiaoVien.MonHocId;
                dpickerNgayVao.Value = GiaoVien.NgayVaoNganh;
                //Trinh do chuyen mon
                cbbTrinhDoCM.SelectedValue = GiaoVien.TrinhDoId;
                cbbTrinhDoChuan.SelectedValue = GiaoVien.TrinhDoChuanId;
                // cbbLyLuanCT.SelectedValue
                cboxThamGiaBD.Checked = (bool)GiaoVien.IsThamGiaBoiDuong;
                //cbbQLNhaNuoc.SelectedValue
                //cbbQLGiaoDuc.SelectedValue  
                cboxDangVien.Checked = (bool)GiaoVien.IsLaDangVien;
                if(GiaoVien.NgayVaoDang!=null)
                dpickerNgayVaoDang.Value = (DateTime)GiaoVien.NgayVaoDang;

            }
            #endregion
            DisableHighlightCBB();

        }
        /// <summary>
        /// saveing data
        /// </summary>
        private void saveData()
        {

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
    }
}
