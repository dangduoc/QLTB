using QLTB.Handler;
using QLTB.Model;
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
    public partial class frmThietBiMuon : DevComponents.DotNetBar.Office2007Form
    {
        private PhieuMuonThietBiModel Phieu;
        private DbPhieuMuonTBHandler handler= new DbPhieuMuonTBHandler();
        private DbDanhSachHandler dshandler = new DbDanhSachHandler();
        public frmThietBiMuon()
        {
            InitializeComponent();
            Phieu = null;
        }
        public frmThietBiMuon(string Id)
        {
            InitializeComponent();
            Phieu = handler.GetById(Id);
        }
        private void loadForm()
        {
            //
            foreach(var item in layoutControl1.Controls.OfType<DevComponents.DotNetBar.Controls.ComboBoxEx>())
            {
                item.DisplayMember = "value";
                item.ValueMember = "key";
            }
            //
            CbbGiaoVien.DataSource = dshandler.GetGiaoVien().Select(p => new { key = p.GiaoVienId, value = p.TenDayDu + " - " + p.GiaoVienId }).ToList();
            CbbKhoiLop.DataSource = dshandler.GetKhoiLop().Select(p => new { key = p.KhoiLopId, value = p.Ten }).ToList();
            CbbDayLop.DataSource = dshandler.GetLopHoc().Select(p => new { key = p.LopHocId, value = p.Ten }).ToList();
            CbbMonHoc.DataSource = dshandler.GetMonHoc().Select(p => new { key = p.MonHocId, value = p.Ten }).ToList();
            CbbMucDichSD.DataSource = dshandler.GetMucDichSDPhong().Select(p => new { key = p.MucDichSDPhongId, value = p.Ten }).ToList();
            CbbBuoiTrongNgay.DataSource = dshandler.GetTGTrongNgay().Select(p => new { key = p.BuoiId, value = p.Ten }).ToList();
            //
            //load thong tin phieu muon
            if (Phieu != null)
            {
                txtSoPhieu.Text = Phieu.PhieuMuonTBId;
                txtSoTiet.Text = Phieu.SoTiet.ToString();
                txtGhiChu.Text = Phieu.GhiChu;
                cbbTenBaiDay.SelectedValue = Phieu.BaiDayId;
                CbbMucDichSD.SelectedValue = Phieu.MucDichSuDungId;
                CbbMonHoc.SelectedValue = Phieu.MonHocId;
                CbbKhoiLop.SelectedValue = Phieu.KhoiLopId;
                CbbGiaoVien.SelectedValue = Phieu.GiaoVienId;
                CbbDayLop.SelectedValue = Phieu.LopHocId;
                CbbBuoiTrongNgay.SelectedValue = Phieu.ThoiGianTrongNgay;
                cboxNgoaiQuyDinh.Checked = Phieu.IsNgoaiQuyDinh;
            }
            //load danh sach thiet bi muon
            gridDSThietBiMuon.DataSource = Phieu.ThietBis;
            gridDSThietBiMuon.Columns[0].HeaderText = "Mã thiết bị";
            gridDSThietBiMuon.Columns[1].HeaderText = "Tên thiết bị";
            gridDSThietBiMuon.Columns[2].HeaderText = "Số hiệu";
            gridDSThietBiMuon.Columns[3].HeaderText = "Phòng bộ môn";
            gridDSThietBiMuon.Columns[4].HeaderText = "Số lượng mượn";
            gridDSThietBiMuon.Columns[5].HeaderText = "Đơn vị tính";
            //
            DisableHighlightCBB();
        }
        private void saveData()
        {

        }
        private void DisableHighlightCBB()
        {
            foreach (var item in layoutControl1.Controls.OfType<DevComponents.DotNetBar.Controls.ComboBoxEx>())
            {
                BeginInvoke(new Action(() => { item.Select(0, 0); }));
            }
        }
        private void frmThietBiMuon_Load(object sender, EventArgs e)
        {
            loadForm();
        }
    }
}
