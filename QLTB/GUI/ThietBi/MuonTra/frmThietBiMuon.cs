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
    public partial class frmThietBiMuon : DevComponents.DotNetBar.Office2007Form
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
            //
            foreach (var item in layoutControl1.Controls.OfType<DevComponents.DotNetBar.Controls.ComboBoxEx>())
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
            CbbMonHoc.SelectedValueChanged += CbbMonHoc_SelectedValueChanged;
            CbbMonHoc.SelectedIndexChanged += CbbMonHoc_SelectedValueChanged;

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
                if (Phieu.ThietBis == null)
                {
                    Phieu.ThietBis = new List<ThietBiMuonGridDisplayModel>();
                }
                source.DataSource = Phieu.ThietBis;
            }
            else
            {
                txtSoPhieu.Text = handler.GenerateCode();
                CbbMonHoc.SelectedIndex = 0;
                source.DataSource = dsThietBi;
            }
        
            DataGridViewLinkColumn linkColEdit = new DataGridViewLinkColumn();
            linkColEdit.Text = "Thay đổi";
            linkColEdit.Name = "Edit";
            linkColEdit.LinkColor = Color.Blue;
            linkColEdit.LinkBehavior = LinkBehavior.NeverUnderline;
            linkColEdit.UseColumnTextForLinkValue = true;
            linkColEdit.HeaderText = "";
            DataGridViewLinkColumn linkColDelete = new DataGridViewLinkColumn();
            linkColDelete.Text = "Xóa bỏ";
            linkColDelete.Name = "Delete";
            linkColDelete.LinkColor = Color.Red;
            linkColDelete.LinkBehavior = LinkBehavior.NeverUnderline;
            linkColDelete.UseColumnTextForLinkValue = true;
            linkColDelete.HeaderText = "";

            gridDSThietBiMuon.Columns.Add(linkColEdit);
            gridDSThietBiMuon.Columns.Add(linkColDelete);
            //load danh sach thiet bi muon
            gridDSThietBiMuon.DataSource = source;
            gridDSThietBiMuon.Columns[2].HeaderText = "Mã thiết bị";
            gridDSThietBiMuon.Columns[3].HeaderText = "Tên thiết bị";
            gridDSThietBiMuon.Columns[4].HeaderText = "Số hiệu";
            gridDSThietBiMuon.Columns[5].HeaderText = "Phòng bộ môn";
            gridDSThietBiMuon.Columns[6].HeaderText = "Số lượng mượn";
            gridDSThietBiMuon.Columns[7].HeaderText = "Đơn vị tính";
            gridDSThietBiMuon.Columns[2].DisplayIndex = 1;
            gridDSThietBiMuon.Columns[3].DisplayIndex = 2;
            gridDSThietBiMuon.Columns[4].DisplayIndex = 3;
            gridDSThietBiMuon.Columns[5].DisplayIndex = 4;
            gridDSThietBiMuon.Columns[6].DisplayIndex = 5;
            gridDSThietBiMuon.Columns[7].DisplayIndex = 6;
            gridDSThietBiMuon.Columns[0].DisplayIndex = 7;
            gridDSThietBiMuon.Columns[1].DisplayIndex = 8;
         
         
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
                SoTiet = MyConvert.To<int>(txtSoTiet.Text),
                MucDichSuDungId = MyConvert.To<int>(CbbMucDichSD.SelectedValue),
                GhiChu = txtGhiChu.Text,
                BaiDayId = MyConvert.To<int?>(cbbTenBaiDay.SelectedValue),
                IsNgoaiQuyDinh = cboxNgoaiQuyDinh.Checked,
                KhoiLopId = MyConvert.To<int>(CbbKhoiLop.SelectedValue),
                LopHocId = MyConvert.To<int>(CbbDayLop.SelectedValue),
                MonHocId = MyConvert.To<int>(CbbMonHoc.SelectedValue),
                ThoiGianTrongNgay = MyConvert.To<int>(CbbBuoiTrongNgay.SelectedValue),
                GiaoVienId = CbbGiaoVien.SelectedValue.ToString(),
                NgayMuon = MyConvert.To<DateTime>(dPickerNgayMuon.Value),
                NgayTra = MyConvert.To<DateTime>(dPickerNgayTra.Value),
            };
            if (Phieu == null)
            {
                PhieuMoi.CreatedByUserId = GlobalVariable.GetUser().UserName;
                PhieuMoi.CreatedOnDate = DateTime.Now;
                PhieuMoi.UpdatedByUserId = PhieuMoi.CreatedByUserId;
                PhieuMoi.UpdatedOnDate = PhieuMoi.CreatedOnDate;
                PhieuMoi.ThietBis = dsThietBi;
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
                PhieuMoi.UpdatedByUserId = GlobalVariable.GetUser().UserName;
                PhieuMoi.UpdatedOnDate = DateTime.Now;
                int result = handler.Update(PhieuMoi);
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
            foreach (var item in layoutControl1.Controls.OfType<DevComponents.DotNetBar.Controls.ComboBoxEx>())
            {
                BeginInvoke(new Action(() => { item.Select(0, 0); }));
            }
        }
        private void frmThietBiMuon_Load(object sender, EventArgs e)
        {
            loadForm();
        }

        public void AddToGrid(List<ThietBiMuonGridDisplayModel> list)
        {
            #region Truing hop tao phieu moi
            if (Phieu == null)
            {
                var listSoHieu = dsThietBi.Select(p1 => p1.SoHieu).ToList();
                var repeatList = list.Where(p => listSoHieu.Contains(p.SoHieu)).ToList();
                list.RemoveAll(p => listSoHieu.Contains(p.SoHieu));
                dsThietBi.AddRange(list);
                //
                
                source = new BindingSource();
                source.DataSource = dsThietBi;
                gridDSThietBiMuon.DataSource = source;
                gridDSThietBiMuon.Refresh();
                gridDSThietBiMuon.Update();
                //
                //DataGridViewLinkColumn linkColEdit = new DataGridViewLinkColumn();
                //linkColEdit.Text = "Thay đổi";
                //linkColEdit.Name = "Edit";
                //linkColEdit.LinkColor = Color.Blue;
                //linkColEdit.LinkBehavior = LinkBehavior.NeverUnderline;
                //linkColEdit.UseColumnTextForLinkValue = true;
                //linkColEdit.HeaderText = "";
                //DataGridViewLinkColumn linkColDelete = new DataGridViewLinkColumn();
                //linkColDelete.Text = "Xóa bỏ";
                //linkColDelete.Name = "Delete";
                //linkColDelete.LinkColor = Color.Red;
                //linkColDelete.LinkBehavior = LinkBehavior.NeverUnderline;
                //linkColDelete.UseColumnTextForLinkValue = true;
                //linkColDelete.HeaderText = "";

                //gridDSThietBiMuon.Columns.Add(linkColEdit);
                //gridDSThietBiMuon.Columns.Add(linkColDelete);
                ////
                //gridDSThietBiMuon.Columns[0].HeaderText = "Mã thiết bị";
                //gridDSThietBiMuon.Columns[1].HeaderText = "Tên thiết bị";
                //gridDSThietBiMuon.Columns[2].HeaderText = "Số hiệu";
                //gridDSThietBiMuon.Columns[3].HeaderText = "Phòng bộ môn";
                //gridDSThietBiMuon.Columns[4].HeaderText = "Số lượng mượn";
                //gridDSThietBiMuon.Columns[5].HeaderText = "Đơn vị tính";
                //gridDSThietBiMuon.Columns[6].Width = 50;
                //gridDSThietBiMuon.Columns[7].Width = 50;
                //
                if (repeatList.Count > 0)
                {
                    string str = "";
                    foreach (var item in repeatList)
                    {
                        str = str + item.SoHieu + ", ";
                    }
                    MessageBox.Show("Các số hiệu đã có trong danh sách: " + str, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            #endregion
            #region Truong hop chinh sua phieu muon
            else
            {
                var listSoHieu = Phieu.ThietBis.Select(p1 => p1.SoHieu).ToList();
                var repeatList = list.Where(p => listSoHieu.Contains(p.SoHieu)).ToList();
                list.RemoveAll(p => listSoHieu.Contains(p.SoHieu));
                Phieu.ThietBis.AddRange(list);
                DataGridViewRow row = new DataGridViewRow();
                source = new BindingSource();
                source.DataSource = Phieu.ThietBis;
                gridDSThietBiMuon.DataSource = source;
                if (repeatList.Count > 0)
                {
                    string str = "";
                    foreach (var item in repeatList)
                    {
                        str = str + item.SoHieu + ", ";
                    }
                    MessageBox.Show("Các số hiệu đã có trong danh sách: " + str, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            #endregion        
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            frmDialogDSThietBi frm = new frmDialogDSThietBi();
            frm.ShowDialog(this);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            saveData();
        }

        private void gridDSThietBiMuon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = gridDSThietBiMuon.Rows[e.RowIndex].Cells[4].Value.ToString();
            if ((e.RowIndex >= 0) && (e.ColumnIndex == gridDSThietBiMuon.Columns["Delete"].Index))
            {
                DialogResult dr = MessageBox.Show("Xóa thiết bị có số hiệu: " + id + " khỏi danh sách", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.OK)
                {
                    if (Phieu != null)
                    {
                        if (handler.RemoveFromList(id, Phieu.PhieuMuonTBId) == 1)
                        {
                            gridDSThietBiMuon.Rows.Remove(gridDSThietBiMuon.Rows[e.RowIndex]);
                        }
                        else
                        {
                            MessageBox.Show("Xóa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        if (dsThietBi.Remove(dsThietBi.Where(p => p.SoHieu.Equals(id)).FirstOrDefault()))
                            gridDSThietBiMuon.Rows.Remove(gridDSThietBiMuon.Rows[e.RowIndex]);
                    }
                }

            }
            else if ((e.RowIndex >= 0) && (e.ColumnIndex == gridDSThietBiMuon.Columns["Edit"].Index))
            {

            }
        }
    }
}
