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
    public partial class frmChiTietSuaChuaTB : DevComponents.DotNetBar.Office2007Form, IFrmPhieuTBHong
    {
        private PhieuSuaTBModel Phieu;
        private List<ThietBiSuaGridDisplayModel> dsThietBi = new List<ThietBiSuaGridDisplayModel>();
        private DbPhieuSuaTBHandler handler = new DbPhieuSuaTBHandler();
        private DanhSachModel dshandler = new DanhSachModel();
        private BindingSource source = new BindingSource();
        public frmChiTietSuaChuaTB()
        {
            InitializeComponent();
            Phieu = null;
            txtSoPhieu.Text = handler.GenerateCode();
            txtSoPhieu.Enabled = false;
        }
        public frmChiTietSuaChuaTB(string SoPhieu)
        {
            InitializeComponent();
            Phieu = handler.GetById(SoPhieu);
            txtSoPhieu.Enabled = false;
            if (Phieu == null)
            {
                MessageBox.Show("Thông tìm thấy phiếu sửa ch", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }
        private void loadForm()
        {
            #region Loading data
            //load thong tin phieu 
            if (Phieu != null)
            {
                txtSoPhieu.Text = Phieu.PhieuSuaTBId;
                txtGhiChu.Text = Phieu.GhiChu;
                dpickerNgayLap.Value = (DateTime)Phieu.NgayLap;
                if (Phieu.ThietBis == null)
                {
                    Phieu.ThietBis = new List<ThietBiSuaGridDisplayModel>();

                }
                else
                {
                    dsThietBi = Phieu.ThietBis;
                }
                source.DataSource = MyConvert.ToDataTable<ThietBiSuaGridDisplayModel>(dsThietBi);
            }
            else
            {
                //txtSoPhieu.Text = handler.GenerateCode();
                source.DataSource = MyConvert.ToDataTable<ThietBiSuaGridDisplayModel>(dsThietBi);
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
            ADGVDSTB.Columns[5].HeaderText = "Loại thiết bị";
            ADGVDSTB.Columns[5].ReadOnly = true;
            ADGVDSTB.Columns[6].HeaderText = "Số lượng cần sửa";
            ADGVDSTB.Columns[7].HeaderText = "Giá trị";
            ADGVDSTB.Columns[8].HeaderText = "Đơn giá sửa";
            ADGVDSTB.Columns[9].HeaderText = "Thành tiền";
            ADGVDSTB.Columns[9].ReadOnly = true;
            ADGVDSTB.Columns[10].HeaderText = "Tinh Trang Hong";
            ADGVDSTB.Columns[10].Visible = false;
            ADGVDSTB.Columns[11].Visible = false;

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
        }
        private void saveData()
        {
            var PhieuMoi = new PhieuSuaTBModel
            {
                PhieuSuaTBId = txtSoPhieu.Text,
                NgayLap = dpickerNgayLap.Value,
                GhiChu = txtGhiChu.Text,
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
                    MessageBox.Show("Thêm đề xuất sửa chữa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (result == 0)
                {
                    MessageBox.Show("Thêm đề xuất sửa chữa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra, xin thử lại khi khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                PhieuMoi.ThietBis = Phieu.ThietBis;
                PhieuMoi.UpdatedByUserId = GlobalVariable.GetUser().UserId;
                PhieuMoi.UpdatedOnDate = DateTime.Now;
                int result = handler.Update(PhieuMoi);
                if (result == 1)
                {
                    MessageBox.Show("Cập nhật thông tin phiếu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (result == 0)
                {
                    MessageBox.Show("Cập nhật thông tin không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra, xin thử lại khi khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void ADGVDSTB_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var sohieu = ADGVDSTB.Rows[e.RowIndex].Cells["SoHieu"].Value.ToString();
                var maphieubh = ADGVDSTB.Rows[e.RowIndex].Cells["MaPhieuHongMat"].Value.ToString();
                var tb = dsThietBi.Where(p => p.SoHieu.Equals(sohieu) && p.MaPhieuHongMat.Equals(maphieubh)).FirstOrDefault();
                if (tb != null)
                {
                    //so luong
                    var soluong = Convert.ToDecimal(ADGVDSTB.Rows[e.RowIndex].Cells["SoLuongCanSua"].Value);
                    tb.SoLuongCanSua = soluong.ToString();
                    //Ly do
                    var dongia = Convert.ToDecimal(ADGVDSTB.Rows[e.RowIndex].Cells["DonGiaSua"].Value);
                    tb.DonGiaSua = dongia.ToString();
                    tb.GiaTri = ADGVDSTB.Rows[e.RowIndex].Cells["GiaTri"].Value.ToString();
                    tb.ThanhTien = (soluong * dongia).ToString();
                    ADGVDSTB.Rows[e.RowIndex].Cells["ThanhTien"].Value = tb.ThanhTien.ToString();
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void frmChiTietSuaChuaTB_Load(object sender, EventArgs e)
        {
            loadForm();
        }

        private void btnLayTB_Click(object sender, EventArgs e)
        {
            frmDialogDSTBHong frm = new frmDialogDSTBHong();
            frm.ShowDialog(this);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void AddToGrid(List<BaseThietBiHongGridDisplayModel> list)
        {

            var listSoHieu = dsThietBi.Select(p => p.SoHieu).ToList();
            var repeatList = list.Where(p => listSoHieu.Contains(p.SoHieu)).ToList();
            list.RemoveAll(p => listSoHieu.Contains(p.SoHieu));

            foreach (var item in list)
            {
                dsThietBi.Add(new ThietBiSuaGridDisplayModel
                {
                    ThietBiId = item.ThietBiId,
                    SoHieu = item.SoHieu,
                    SoLuongCanSua = "1",
                    DonViTinh = item.DonViTinh,
                    DonGiaSua = "",
                    Ten = item.Ten,
                    PhongHoc = item.PhongHoc,
                    MaPhieuHongMat = item.SoPhieuBaoHong,
                    GiaTri = "0.00",
                    LoaiTB = item.Loai,
                    ThanhTien = "",
                });
            }
            //

            source = new BindingSource();
            source.DataSource = MyConvert.ToDataTable<ThietBiSuaGridDisplayModel>(dsThietBi);
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            saveData();
        }

        private void frmChiTietSuaChuaTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void ADGVDSTB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                var id = ADGVDSTB.Rows[e.RowIndex].Cells["SoHieu"].Value.ToString();
                if (e.ColumnIndex == ADGVDSTB.Columns["Remove"].Index)
                {
                    DialogResult dr = MessageBox.Show("Xóa thiết bị có số hiệu: " + id + " khỏi danh sách", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        if (dsThietBi.Remove(dsThietBi.Where(p => p.SoHieu.Equals(id)).FirstOrDefault()))
                            ADGVDSTB.Rows.Remove(ADGVDSTB.Rows[e.RowIndex]);
                    }

                }

            }
        }
    }
}
