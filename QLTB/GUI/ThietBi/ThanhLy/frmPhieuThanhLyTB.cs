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
    public partial class frmPhieuThanhLyTB : DevComponents.DotNetBar.Office2007Form, IFrmPhieuTBHong
    {
        private PhieuThanhLyModel Phieu;
        private List<ThietBiTLGridDisplayModel> dsThietBi = new List<ThietBiTLGridDisplayModel>();
        private DbPhieuThanhLyHandler handler = new DbPhieuThanhLyHandler();
        private DanhSachModel dshandler = new DanhSachModel();
        private BindingSource source = new BindingSource();
        public frmPhieuThanhLyTB()
        {
            InitializeComponent();
            Phieu = null;
        }
        public frmPhieuThanhLyTB(string SoPhieu)
        {
            InitializeComponent();
            Phieu = handler.GetById(SoPhieu);
            txtSoPhieu.Enabled = false;
            if (Phieu == null)
            {
                MessageBox.Show("Thông tìm thấy phiếu thanh lý", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }
        private void loadForm()
        {
            #region Loading data
            //load thong tin phieu 
            if (Phieu != null)
            {
                txtSoPhieu.Text = Phieu.PhieuThanhLyTBId;
                txtDiaDiem.Text = Phieu.DiaDiem;
                txtHoiDongThanhLy.Text = Phieu.HoiDongThanhLy;
                dpickerNgayLap.Value = (DateTime)Phieu.NgapLap;
                txtNoiDung.Text = Phieu.NoiDung;
                if (Phieu.ThietBis == null)
                {
                    Phieu.ThietBis = new List<ThietBiTLGridDisplayModel>();
                }
                else
                {
                    dsThietBi = Phieu.ThietBis;
                }
                source.DataSource = MyConvert.ToDataTable<ThietBiTLGridDisplayModel>(dsThietBi);
            }
            else
            {
                //txtSoPhieu.Text = handler.GenerateCode();
                source.DataSource = MyConvert.ToDataTable<ThietBiTLGridDisplayModel>(dsThietBi);
            }


            //load danh sach thiet bi muon
            ADGVDSTB.DataSource = source;
            #endregion
            #region Base Grid Display

            ADGVDSTB.Columns[0].HeaderText = "Mã thiết bị";
            ADGVDSTB.Columns[1].HeaderText = "Số hiệu";
            ADGVDSTB.Columns[2].HeaderText = "Tên thiết bị";
            ADGVDSTB.Columns[3].HeaderText = "Phòng bộ môn";
            ADGVDSTB.Columns[5].HeaderText = "Đơn vị tính";
            ADGVDSTB.Columns[0].ReadOnly = true;
            ADGVDSTB.Columns[1].ReadOnly = true;
            ADGVDSTB.Columns[2].ReadOnly = true;
            ADGVDSTB.Columns[3].ReadOnly = true;
            ADGVDSTB.Columns[5].ReadOnly = true;
            #endregion

            ADGVDSTB.Columns[4].HeaderText = "Số lượng";
            ADGVDSTB.Columns[6].HeaderText = "Số phiếu báo hỏng";
            ADGVDSTB.Columns[7].HeaderText = "Lý do";



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
            var PhieuMoi = new PhieuThanhLyModel
            {
                PhieuThanhLyTBId = txtSoPhieu.Text,
                NgapLap = dpickerNgayLap.Value,
                DiaDiem = txtDiaDiem.Text,
                NoiDung = txtNoiDung.Text,
                HoiDongThanhLy = txtHoiDongThanhLy.Text,
                IsDelete = false
            };
            if (Phieu == null)
            {
                PhieuMoi.CreatedByUserId = GlobalVariable.GetUser().UserId;
                PhieuMoi.CreatedOnDate = DateTime.Now;
                PhieuMoi.UpdatedByUserId = PhieuMoi.CreatedByUserId;
                PhieuMoi.UpdatedOnDate = PhieuMoi.CreatedOnDate;
                PhieuMoi.ThietBis = dsThietBi;
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
                PhieuMoi.ThietBis = Phieu.ThietBis;
                PhieuMoi.UpdatedByUserId = GlobalVariable.GetUser().UserId;
                PhieuMoi.UpdatedOnDate = DateTime.Now;
                int result = handler.Update(PhieuMoi,dsThietBi);
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
        public void AddToGrid(List<BaseThietBiHongGridDisplayModel> list)
        {

            var listSoHieu = dsThietBi.Select(p => p.SoHieu).ToList();
            var repeatList = list.Where(p => listSoHieu.Contains(p.SoHieu)).ToList();
            list.RemoveAll(p => listSoHieu.Contains(p.SoHieu));

            foreach(var item in list)
            {
                dsThietBi.Add(new ThietBiTLGridDisplayModel
                {
                    ThietBiId=item.ThietBiId,
                    SoHieu=item.SoHieu,
                    SoLuongTL="1",
                    DonViTinh=item.DonViTinh,
                    LyDo="",
                    Ten=item.Ten,
                    PhongHoc=item.PhongHoc,
                    SoPhieuBaoHong=item.SoPhieuBaoHong
                });
            }
            //

            source = new BindingSource();
            source.DataSource = MyConvert.ToDataTable<ThietBiTLGridDisplayModel>(dsThietBi);
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
        private void frmPhieuThanhLyTB_Load(object sender, EventArgs e)
        {
            loadForm();
        }
        private void ADGVDSTB_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var sohieu = ADGVDSTB.Rows[e.RowIndex].Cells["SoHieu"].Value.ToString();
                var tb = dsThietBi.Where(p => p.SoHieu.Equals(sohieu)).FirstOrDefault();
                //so luong
                var soluong = Convert.ToInt32(ADGVDSTB.Rows[e.RowIndex].Cells["SoLuongTL"].Value);
                tb.SoLuongTL = soluong.ToString();
                //Ly do
                tb.LyDo = ADGVDSTB.Rows[e.RowIndex].Cells["LyDo"].Value.ToString();
            }
            catch (Exception ex)
            {

            }
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

        private void frmPhieuThanhLyTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            saveData();
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
