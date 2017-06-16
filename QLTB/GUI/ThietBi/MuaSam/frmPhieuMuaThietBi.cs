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
    public partial class frmPhieuMuaThietBi : DevComponents.DotNetBar.Office2007Form
    {
        private PhieuMuaSamTBModel Phieu;
        private List<ThietBiMuaGridDisplayModel> dsThietBi = new List<ThietBiMuaGridDisplayModel>();
        private DbMuaSamTBHandler handler = new DbMuaSamTBHandler();
        private DanhSachModel dshandler = new DanhSachModel();
        private BindingSource source = new BindingSource();
        private bool isTuMua = false;
        public frmPhieuMuaThietBi()
        {
            InitializeComponent();
            Phieu = null;
        }
        public frmPhieuMuaThietBi(string id)
        {
            InitializeComponent();
            Phieu = handler.GetById(id);
            
            if (Phieu == null)
            {
                MessageBox.Show("Thông tìm thấy đề nghị nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }
        private void loadForm()
        {
            #region Loading data
            //load thong tin phieu 
            if (Phieu != null)
            {
                txtTenDeNghi.Text = Phieu.Ten;
                var nh = new DbThongTinNHHandler().GetById((int)Phieu.NamHocId);
                txtNamHoc.Text = nh.NamBatDau.ToString() + " - " + nh.NamKetThuc.ToString();

                if (Phieu.ThietBis == null)
                {
                    Phieu.ThietBis = new List<ThietBiMuaGridDisplayModel>();
                }
                else
                {
                    dsThietBi = Phieu.ThietBis;
                }
                source.DataSource = MyConvert.ToDataTable<ThietBiMuaGridDisplayModel>(dsThietBi);
            }
            else
            {
                var nh = GlobalVariable.GetHeThong().NamHoc;
                txtNamHoc.Text = nh.NamBatDau.ToString() + " - " + nh.NamKetThuc.ToString();
                source.DataSource = MyConvert.ToDataTable<ThietBiMuaGridDisplayModel>(dsThietBi);
            }


            //load danh sach thiet bi muon
            ADGVDSTB.DataSource = source;
            #endregion
            #region Base Grid Display

            ADGVDSTB.Columns[0].HeaderText = "Mã thiết bị";
            ADGVDSTB.Columns[1].HeaderText = "Tên thiết bị";
            ADGVDSTB.Columns[2].HeaderText = "Loại thiết bị";
            ADGVDSTB.Columns[3].HeaderText = "Số lượng đang có";
            ADGVDSTB.Columns[0].ReadOnly = true;
            ADGVDSTB.Columns[1].ReadOnly = true;
            ADGVDSTB.Columns[2].ReadOnly = true;
            ADGVDSTB.Columns[3].ReadOnly = true;
            #endregion
            ADGVDSTB.Columns[4].HeaderText = "Số lượng đề nghị";
            ADGVDSTB.Columns[5].HeaderText = "Đơn giá";
            ADGVDSTB.Columns[6].HeaderText = "Thành tiền";
            ADGVDSTB.Columns[7].HeaderText = "Tự mua";
            ADGVDSTB.Columns[7].Visible = false;


            ADGVDSTB.Columns[0].Width = 70;
            ADGVDSTB.Columns[2].Width = 100;
            ADGVDSTB.Columns[3].Width = 100;
            ADGVDSTB.Columns[4].Width = 100;
            ADGVDSTB.Columns[5].Width = 70;
            ADGVDSTB.Columns[6].Width = 70;
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
            var PhieuMoi = new PhieuMuaSamTBModel
            {
                NamHocId = GlobalVariable.GetHeThong().NamHoc.NamHocId,
                NgayLap = DateTime.Now,
                PhieuDeNghiId = handler.GenerateCode(),
                Ten = txtTenDeNghi.Text,
                TrangThaiId = 0,
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
                    MessageBox.Show("Thông tin thanh lý thiết bị lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (result == 0)
                {
                    MessageBox.Show("Thông tin thanh lý thiết bị lưu không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    MessageBox.Show("Cập nhật thông tin phiếu thanh lý thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                var matb = ADGVDSTB.Rows[e.RowIndex].Cells["MaThietBi"].Value.ToString();

                var tb = dsThietBi.Where(p => p.MaThietBi.Equals(matb) && p.isTuMua == isTuMua).FirstOrDefault();
                //so luong
                var soluongdangco = Convert.ToInt32(ADGVDSTB.Rows[e.RowIndex].Cells["SoLuongDangCo"].Value);
                tb.SoLuongDangCo = soluongdangco.ToString();
                var soluongdenghi = Convert.ToInt32(ADGVDSTB.Rows[e.RowIndex].Cells["SoLuongDeNghi"].Value);
                tb.SoLuongDeNghi = soluongdenghi.ToString();
                var dongia = Convert.ToDouble(ADGVDSTB.Rows[e.RowIndex].Cells["DonGia"].Value);
                tb.DonGia = dongia.ToString();
                var thanhtien = soluongdenghi * dongia;
                tb.ThanhTien = thanhtien.ToString();
                ADGVDSTB.Rows[e.RowIndex].Cells["ThanhTien"].Value = tb.ThanhTien;
            }
            catch (Exception ex)
            {

            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmPhieuMuaThietBi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void frmPhieuMuaThietBi_Load(object sender, EventArgs e)
        {
            loadForm();
        }
        public void AddToGrid(ThietBiTTDialogModel tb)
        {

            var listSoHieu = dsThietBi.Select(p => p.MaThietBi).ToList();
            if (dsThietBi.Any(p => p.MaThietBi.Equals(tb.ThietBiId)))
            {
                MessageBox.Show("Thiết bị này đã có trong danh sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dsThietBi.Add(new ThietBiMuaGridDisplayModel
                {
                    MaThietBi = tb.ThietBiId,
                    Ten = tb.Ten,
                    SoLuongDangCo = tb.SoLuongCon.ToString(),
                    SoLuongDeNghi = "",
                    DonGia = "",
                    isTuMua = isTuMua,
                    LoaiTB = tb.LoaiThietBi,
                    ThanhTien = ""
                });
                //

                source = new BindingSource();
                source.DataSource = MyConvert.ToDataTable<ThietBiMuaGridDisplayModel>(dsThietBi);
                ADGVDSTB.DataSource = source;

                ADGVDSTB.CellValueChanged -= ADGVDSTB_CellValueChanged;
                ADGVDSTB.CellValueChanged += ADGVDSTB_CellValueChanged;
            }
        }
        private void ADGVDSTB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var id = ADGVDSTB.Rows[e.RowIndex].Cells["MaThietBi"].Value.ToString();
                if (e.ColumnIndex == ADGVDSTB.Columns["Remove"].Index)
                {
                    DialogResult dr = MessageBox.Show("Xóa thiết bị có mã: " + id + " khỏi danh sách", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        if (dsThietBi.Remove(dsThietBi.Where(p => p.MaThietBi.Equals(id)).FirstOrDefault()))
                            ADGVDSTB.Rows.Remove(ADGVDSTB.Rows[e.RowIndex]);
                    }

                }

            }
        }

        private void tabCapTren_Click(object sender, EventArgs e)
        {
            isTuMua = false;
        }

        private void tabTuMua_Click(object sender, EventArgs e)
        {
            isTuMua = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            saveData();
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            frmDialogTBToiThieu frm = new frmDialogTBToiThieu();
            frm.ShowDialog(this);
        }
    }
}
