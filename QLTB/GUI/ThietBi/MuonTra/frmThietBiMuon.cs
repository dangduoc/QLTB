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
    public partial class frmThietBiMuon : DevComponents.DotNetBar.Office2007Form, IFrmPhieu
    {
        private PhieuMuonThietBiModel Phieu;
        private List<ThietBiMuonGridDisplayModel> dsThietBi = new List<ThietBiMuonGridDisplayModel>();
        private DbPhieuMuonTBHandler handler = new DbPhieuMuonTBHandler();
        private DbDanhSachHandler dshandler = new DbDanhSachHandler();
        private BindingSource source = new BindingSource();
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
            if (Phieu != null)
            {
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
                if (Phieu.ThietBis == null)
                {
                    Phieu.ThietBis = new List<ThietBiMuonGridDisplayModel>();

                }
                else
                {
                    dsThietBi = Phieu.ThietBis;
                }
                source.DataSource = MyConvert.ToDataTable<ThietBiMuonGridDisplayModel>(dsThietBi);
            }
            else
            {
                txtSoPhieu.Text = handler.GenerateCode();
                CbbMonHoc.SelectedIndex = 0;
                source.DataSource = MyConvert.ToDataTable<ThietBiMuonGridDisplayModel>(dsThietBi);
            }


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
            ADGVDSTB.Columns[5].ReadOnly = false;

            ADGVDSTB.Columns[0].Width = 70;
            ADGVDSTB.Columns[1].Width = 100;
            ADGVDSTB.Columns[5].Width = 100;
            ADGVDSTB.Columns[4].Width = 100;

            //
            /*Cột xóa button*/
            DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn col1 = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            col1.Name = "Remove";
            col1.Image = imageList1.Images[0];
            col1.Text = "";
            col1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Left;
            col1.FlatStyle = FlatStyle.Flat;
            DevComponents.DotNetBar.ColorScheme color = new DevComponents.DotNetBar.ColorScheme();
            color.ItemBackground = Color.White;
            color.ItemBackground2 = Color.White;
            color.PanelBorder = Color.White;
            color.PanelBackground = Color.White;
            color.PanelBackground2 = Color.White;
            col1.Width = 30;
            col1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            col1.ColorScheme = color;
            col1.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            col1.ToolTipText = "Xóa";
            ADGVDSTB.Columns.Add(col1);
            ADGVDSTB.Columns["Remove"].HeaderText = "";
            //
            ADGVDSTB.CellValueChanged -= ADGVDSTB_CellValueChanged;
            ADGVDSTB.CellValueChanged += ADGVDSTB_CellValueChanged;
            //
            cbbTenBaiDay.DataSource = dshandler.GetBaiGiang((int)CbbMonHoc.SelectedValue).Select(p => new { key = p.BaiGiangId, value = p.Ten }).ToList();
            DisableHighlightCBB();
        }

        private void CbbMonHoc_SelectedValueChanged(object sender, EventArgs e)
        {
            cbbTenBaiDay.DataSource = dshandler.GetBaiGiang((int)CbbMonHoc.SelectedValue).Select(p => new { key = p.BaiGiangId, value = p.Ten }).ToList();
        }

        private void saveData()
        {
            var PhieuMoi = new PhieuMuonThietBiModel
            {
                
                PhieuMuonTBId = txtSoPhieu.Text,
                SoTiet = Convert.ToInt32(txtSoTiet.Text),
                MucDichSuDungId = (int)CbbMucDichSD.SelectedValue,
                GhiChu = txtGhiChu.Text,
                BaiDayId = (int)cbbTenBaiDay.SelectedValue,
                IsNgoaiQuyDinh = cboxNgoaiQuyDinh.Checked,
                KhoiLopId = (int)CbbKhoiLop.SelectedValue,
                LopHocId = (int)CbbDayLop.SelectedValue,
                MonHocId = (int)CbbMonHoc.SelectedValue,
                ThoiGianTrongNgay = (int)CbbBuoiTrongNgay.SelectedValue,
                GiaoVienId = CbbGiaoVien.SelectedValue.ToString(),
                NgayMuon = (DateTime)dPickerNgayMuon.Value,
                NgayTra = (DateTime)dPickerNgayTra.Value,
                MuonTuTiet = Convert.ToInt32(txtMuonTuTiet.Text),
                ThietBis = dsThietBi
            };
            if (Phieu == null)
            {
                PhieuMoi.CreatedByUserId = GlobalVariable.GetUser().UserId;
                PhieuMoi.CreatedOnDate = DateTime.Now;
                PhieuMoi.UpdatedByUserId = PhieuMoi.CreatedByUserId;
                PhieuMoi.UpdatedOnDate = PhieuMoi.CreatedOnDate;
                int result = handler.Create(PhieuMoi);
                if (result == 1)
                {
                    MessageBox.Show("Đăng ký phiếu mượn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (result == 0)
                {
                    MessageBox.Show("Đăng ký phiếu mượn không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra, xin thử lại khi khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {

                PhieuMoi.UpdatedByUserId = GlobalVariable.GetUser().UserId;
                PhieuMoi.UpdatedOnDate = DateTime.Now;
                int result = handler.Update(PhieuMoi, dsThietBi);
                if (result == 1)
                {
                    MessageBox.Show("Cập nhật thông tin phiếu mượn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (result == 0)
                {
                    MessageBox.Show("Cập nhật thông tin phiếu mượn không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra, xin thử lại khi khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void DisableHighlightCBB()
        {
            foreach (var item in layoutTTC.Controls.OfType<DevComponents.DotNetBar.Controls.ComboBoxEx>())
            {
                BeginInvoke(new Action(() => { item.Select(0, 0); }));
            }
        }
        private void frmThietBiMuon_Load(object sender, EventArgs e)
        {
            btnLuu.Click += BtnLuu_Click;
            loadForm();

        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            saveData();
        }

        public void AddToGrid(List<BaseThietBiGridDisplayModel> list)
        {

            var listSoHieu = dsThietBi.Select(p => p.SoHieu).ToList();
            var repeatList = list.Where(p => listSoHieu.Contains(p.SoHieu)).ToList();
            list.RemoveAll(p => listSoHieu.Contains(p.SoHieu));
            //
            foreach (var item in list)
            {
                dsThietBi.Add(new ThietBiMuonGridDisplayModel
                {
                    ThietBiId = item.ThietBiId,
                    SoHieu = item.SoHieu,
                    DonViTinh = item.DonViTinh,
                    PhongHoc = item.PhongHoc,
                    Ten = item.Ten,
                    SoLuongMuon = "1"
                });
            }
            //

            source = new BindingSource();
            source.DataSource = MyConvert.ToDataTable<ThietBiMuonGridDisplayModel>(dsThietBi);
            ADGVDSTB.DataSource = source;
            if (repeatList.Count > 0)
            {
                string str = "";
                foreach (var item in repeatList)
                {
                    str = str + item.SoHieu + ", ";
                }
                MessageBox.Show("Các số hiệu đã có trong danh sách: " + str, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            ADGVDSTB.CellValueChanged -= ADGVDSTB_CellValueChanged;
            ADGVDSTB.CellValueChanged += ADGVDSTB_CellValueChanged;
        }
        private void gridDSThietBiMuon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var id = ADGVDSTB.Rows[e.RowIndex].Cells["SoHieu"].Value.ToString();
                if (e.ColumnIndex == ADGVDSTB.Columns["Remove"].Index)
                {
                    DialogResult dr = MessageBox.Show("Xóa thiết bị có số hiệu: " + id + " khỏi danh sách", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        if (Phieu != null)
                        {
                            if (handler.RemoveFromList(id, Phieu.PhieuMuonTBId) == 1)
                            {
                                ADGVDSTB.Rows.Remove(ADGVDSTB.Rows[e.RowIndex]);
                            }
                            else
                            {
                                MessageBox.Show("Xóa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            if (dsThietBi.Remove(dsThietBi.Where(p => p.SoHieu.Equals(id)).FirstOrDefault()))
                                ADGVDSTB.Rows.Remove(ADGVDSTB.Rows[e.RowIndex]);
                        }
                    }

                }

            }
        }
        private void btnBaoHong_Click(object sender, EventArgs e)
        {
            List<BaseThietBiGridDisplayModel> lst = new List<BaseThietBiGridDisplayModel>();
            foreach (var item in dsThietBi)
            {
                lst.Add(new BaseThietBiGridDisplayModel
                {
                    ThietBiId = item.ThietBiId,
                    Ten = item.Ten,
                    SoHieu = item.SoHieu,
                    DonViTinh = item.DonViTinh,
                    PhongHoc = item.PhongHoc
                });
            }
            frmDialogTBBaoHong frm = new frmDialogTBBaoHong(lst);
            frm.ShowDialog(this);
        }

        private void btnLayTB_Click(object sender, EventArgs e)
        {
            if (CbbMonHoc.SelectedValue != null)
            {
                int id = (int)CbbMonHoc.SelectedValue;
                frmDialogDSThietBi frm = new frmDialogDSThietBi(p => p.TrangThai == 1 && p.MonHocId == id);
                frm.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Mời chọn môn học trước", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {

        }

        private void ADGVDSTB_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var sohieu = ADGVDSTB.Rows[e.RowIndex].Cells["SoHieu"].Value.ToString();
            var soluong = Convert.ToInt32(ADGVDSTB.Rows[e.RowIndex].Cells["SoLuongMuon"].Value);
            dsThietBi.Where(p => p.SoHieu.Equals(sohieu)).FirstOrDefault().SoLuongMuon = soluong.ToString();
        }

        private void CbbKhoiLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            CbbDayLop.DataSource = dshandler.GetLopHoc((int)CbbKhoiLop.SelectedValue).Select(p => new { key = p.LopHocId, value = p.Ten }).ToList();
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

        private void CbbGiaoVien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
