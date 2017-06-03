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
using QLTB.Utils;

namespace QLTB.GUI
{
    public partial class frmGhiNhanTraTB : DevComponents.DotNetBar.Office2007Form
    {
        private PhieuMuonThietBiModel Phieu;
        private DbPhieuMuonTBHandler handler = new DbPhieuMuonTBHandler();
        private DbDanhSachHandler dshandler = new DbDanhSachHandler();
        private List<ThietBiTraGridDisplayModel> dsThietBi = new List<ThietBiTraGridDisplayModel>();
        private BindingSource source = new BindingSource();
        public frmGhiNhanTraTB(string PhieuId)
        {
            InitializeComponent();
            Phieu = handler.GetById(PhieuId);
        }

        private void loadForm()
        {
            #region Loading data
            foreach (var item in layoutTTC.Controls.OfType<DevComponents.DotNetBar.Controls.ComboBoxEx>())
            {
                item.DisplayMember = "value";
                item.ValueMember = "key";
            }
            //
            CbbGiaoVien.DataSource = dshandler.GetGiaoVien().Select(p => new { key = p.GiaoVienId, value = p.TenDayDu + " - " + p.GiaoVienId }).ToList();
            CbbKhoiLop.DataSource = dshandler.GetKhoiLop().Select(p => new { key = p.KhoiLopId, value = p.Ten }).ToList();
            CbbKhoiLop.SelectedIndex = 0;
            CbbMonHoc.DataSource = dshandler.GetMonHoc().Select(p => new { key = p.MonHocId, value = p.Ten }).ToList();
            CbbMucDichSD.DataSource = GlobalVariable.GetDS().MucDichSDPhong.Select(p => new { key = p.Id, value = p.Ten }).ToList();
            CbbBuoiTrongNgay.DataSource = GlobalVariable.GetDS().ThoiGianTrongNgay.Select(p => new { key = p.Id, value = p.Ten }).ToList();
            CbbMonHoc.SelectedValueChanged += CbbMonHoc_SelectedValueChanged;
            CbbMonHoc.SelectedIndexChanged += CbbMonHoc_SelectedValueChanged;
            CbbMonHoc.SelectedIndex = 0;

            //
            //load thong tin phieu muon
            txtMuonTuTiet.Text = Phieu.MuonTuTiet.ToString();
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
            dPickerNgayMuon.Value = Phieu.NgayMuon;
            dPickerNgayTra.Value = Phieu.NgayTra;

            //Chuyển về thiết bị trả
            foreach (var item in Phieu.ThietBis)
            {
                dsThietBi.Add(new ThietBiTraGridDisplayModel
                {
                    SoHieu = item.SoHieu,
                    ThietBiId = item.ThietBiId,
                    Ten = item.Ten,
                    SoLuongMuon = item.SoLuongMuon,
                    DonViTinh = item.DonViTinh,
                    PhongHoc = item.PhongHoc,
                    TieuHao = "",
                    TinhTrangKhiTra = ""
                });
            }

            //
            source.DataSource = MyConvert.ToDataTable<ThietBiTraGridDisplayModel>(dsThietBi);
            //load danh sach thiet bi muon
            ADGVDSTB.DataSource = source;
            #endregion
            #region Base Grid Display

            ADGVDSTB.Columns[0].HeaderText = "Mã thiết bị";
            ADGVDSTB.Columns[1].HeaderText = "Số hiệu";
            ADGVDSTB.Columns[2].HeaderText = "Tên thiết bị";
            ADGVDSTB.Columns[3].HeaderText = "Phòng bộ môn";
            ADGVDSTB.Columns[4].HeaderText = "Đơn vị tính";
            ADGVDSTB.Columns[0].ReadOnly = true;
            ADGVDSTB.Columns[1].ReadOnly = true;
            ADGVDSTB.Columns[2].ReadOnly = true;
            ADGVDSTB.Columns[3].ReadOnly = true;
            ADGVDSTB.Columns[4].ReadOnly = true;
            #endregion

            ADGVDSTB.Columns[5].HeaderText = "Số lượng mượn";
            ADGVDSTB.Columns[5].ReadOnly = true;
            ADGVDSTB.Columns[6].HeaderText = "Tình trang khi trả";
            ADGVDSTB.Columns[6].ReadOnly = false;
            ADGVDSTB.Columns[7].HeaderText = "Tiêu hao";
            ADGVDSTB.Columns[7].ReadOnly = false;



            ADGVDSTB.Columns[0].Width = 70;
            ADGVDSTB.Columns[1].Width = 100;
            ADGVDSTB.Columns[5].Width = 100;
            ADGVDSTB.Columns[4].Width = 100;

            //Thêm lại event change value
            ADGVDSTB.CellValueChanged -= ADGVDSTB_CellValueChanged;
            ADGVDSTB.CellValueChanged += ADGVDSTB_CellValueChanged;
            //
            cbbTenBaiDay.DataSource = dshandler.GetBaiGiang((int)CbbMonHoc.SelectedValue).Select(p => new { key = p.BaiGiangId, value = p.Ten }).ToList();
            DisableHighlightCBB();
        }
        private void saveData()
        {
            PhieuTraTBModel model = new PhieuTraTBModel
            {
                PhieuMuonId = Phieu.PhieuMuonTBId
            };
            model.ThietBis = new List<ThietBiTraModel>();
            foreach (var item in dsThietBi)
            {
                ThietBiTraModel tb = new ThietBiTraModel();
                tb.SoHieu = item.SoHieu;
                tb.TinhTrangKhiTra = item.TinhTrangKhiTra;
                double tmp;
                if (double.TryParse(item.TieuHao, out tmp))
                {
                    tb.TieuHao = tmp;
                }
                model.ThietBis.Add(tb);
            }
            int result = new DbPhieuTraTBHandler().Create(model);
            if (result == 1)
            {
                MessageBox.Show("Ghi nhận trả thiết bị thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ghi nhận trả thiết bị không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void ADGVDSTB_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var sohieu = ADGVDSTB.Rows[e.RowIndex].Cells["SoHieu"].Value.ToString();
            string TinhTrangKhiTra = ADGVDSTB.Rows[e.RowIndex].Cells["TinhTrangKhiTra"].Value.ToString();
            string TieuHao = ADGVDSTB.Rows[e.RowIndex].Cells["TieuHao"].Value.ToString();
            var tb = dsThietBi.Where(p => p.SoHieu.Equals(sohieu)).FirstOrDefault();
            tb.TinhTrangKhiTra = TinhTrangKhiTra;
            tb.TieuHao = TieuHao;
        }
        private void CbbMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            var lst = dshandler.GetBaiGiang((int)CbbMonHoc.SelectedValue).Select(p => new { key = p.BaiGiangId, value = p.Ten }).ToList();
            if (lst.Count > 0)
                cbbTenBaiDay.DataSource = dshandler.GetBaiGiang((int)CbbMonHoc.SelectedValue).Select(p => new { key = p.BaiGiangId, value = p.Ten }).ToList();
            else
            {
                cbbTenBaiDay.Text = "";
            }
        }
        private void CbbMonHoc_SelectedValueChanged(object sender, EventArgs e)
        {
            cbbTenBaiDay.DataSource = dshandler.GetBaiGiang((int)CbbMonHoc.SelectedValue).Select(p => new { key = p.BaiGiangId, value = p.Ten }).ToList();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void DisableHighlightCBB()
        {
            foreach (var item in layoutTTC.Controls.OfType<DevComponents.DotNetBar.Controls.ComboBoxEx>())
            {
                BeginInvoke(new Action(() => { item.Select(0, 0); }));
            }
        }
        private void CbbKhoiLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            CbbDayLop.DataSource = dshandler.GetLopHoc((int)CbbKhoiLop.SelectedValue).Select(p => new { key = p.LopHocId, value = p.Ten }).ToList();
        }
        private void frmGhiNhanTraTB_Load(object sender, EventArgs e)
        {
            loadForm();
        }
    }
}
