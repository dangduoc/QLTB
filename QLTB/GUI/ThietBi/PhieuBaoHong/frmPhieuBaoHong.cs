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
    public partial class frmPhieuBaoHong : DevComponents.DotNetBar.Office2007Form, IFrmPhieuBaseTB
    {
        private PhieuBaoHongModel Phieu;
        private List<ThietBiHongGridDisplayModel> dsThietBi = new List<ThietBiHongGridDisplayModel>();
        private DbPhieuBaoHongHandler handler = new DbPhieuBaoHongHandler();
        private DbDanhSachHandler dshandler = new DbDanhSachHandler();
        private BindingSource source = new BindingSource();
        private List<BaseThietBiGridDisplayModel> dsBase=null;
        public frmPhieuBaoHong()
        {
            InitializeComponent();
            Phieu = null;
        }
        public frmPhieuBaoHong(List<BaseThietBiGridDisplayModel> ds)
        {
            InitializeComponent();
            dsBase = ds;
            Phieu = null;
        }
        public frmPhieuBaoHong(string Id)
        {
            InitializeComponent();
            Phieu = handler.GetById(Id);
            txtSoPhieu.Enabled = false;
            if (Phieu == null)
            {
                MessageBox.Show("Thông tìm thấy phiếu báo hỏng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }
        private void loadForm()
        {

            #region Loading data
            if (Phieu != null)
            {
                txtSoPhieu.Text = Phieu.PhieuBaoHongId;
                txtNguoiLamHong.Text = Phieu.NguoiLamHong;
                txtGhiChu.Text = Phieu.GhiChu;
                dpickerNgayLap.Value = Phieu.NgayLap;
                if (Phieu.ThietBis == null)
                {
                    Phieu.ThietBis = new List<ThietBiHongGridDisplayModel>();

                }
                else
                {
                    dsThietBi = Phieu.ThietBis;
                }
                source.DataSource = MyConvert.ToDataTable<ThietBiHongGridDisplayModel>(dsThietBi);
            }
            else
            {
                txtSoPhieu.Text = handler.GenerateCode();
                source.DataSource = MyConvert.ToDataTable<ThietBiHongGridDisplayModel>(dsThietBi);
            }
            ADGVDSTB.DataSource = source;
            #endregion
            #region Base GridDisplay Model
            //ADGVDSTB.AutoGenerateColumns = false;
            //foreach (var item in typeof(ThietBiHongGridDisplayModel).GetProperties())
            //{
            //    DataGridViewColumn column = new DataGridViewColumn();
            //    column.CellTemplate = new DataGridViewTextBoxCell();
            //    column.Name = item.Name;
            //    column.ValueType = typeof(string);
            //    column.Visible = true;

            //    ADGVDSTB.Columns.Add(column);
            //}
            ADGVDSTB.Columns["ThietBiId"].HeaderText = "Mã thiết bị";
            ADGVDSTB.Columns["ThietBiId"].DisplayIndex = 0;
            ADGVDSTB.Columns["ThietBiId"].ReadOnly = true;
            ADGVDSTB.Columns["SoHieu"].HeaderText = "Số hiệu";
            ADGVDSTB.Columns["SoHieu"].DisplayIndex = 1;
            ADGVDSTB.Columns["SoHieu"].ReadOnly = true;
            ADGVDSTB.Columns["Ten"].HeaderText = "Tên thiết bị";
            ADGVDSTB.Columns["Ten"].DisplayIndex = 2;
            ADGVDSTB.Columns["Ten"].ReadOnly = true;
            ADGVDSTB.Columns["PhongHoc"].HeaderText = "Kho/Phòng bộ môn";
            ADGVDSTB.Columns["PhongHoc"].DisplayIndex = 3;
            ADGVDSTB.Columns["PhongHoc"].ReadOnly = true;
            ADGVDSTB.Columns["DonViTinh"].HeaderText = "Đơn vị tính";
            ADGVDSTB.Columns["DonViTinh"].DisplayIndex = 4;
            ADGVDSTB.Columns["DonViTinh"].ReadOnly = true;
            #endregion
            /**/
            ADGVDSTB.Columns["SoLuongMuon"].HeaderText = "Số lượng hỏng/mất";

            ADGVDSTB.Columns["SoLuongMuon"].ReadOnly = true;
            //
            ADGVDSTB.Columns["TinhTrang"].HeaderText = "Tình trạng";
            ADGVDSTB.Columns["TinhTrang"].Visible = false;
            ADGVDSTB.Columns["LyDo"].HeaderText = "Lý do hỏng/mất";
            ADGVDSTB.Columns["LyDo"].ReadOnly = false;

            ADGVDSTB.Columns["TinhTrangHong"].HeaderText = "Tình trạng hỏng hóc";
            ADGVDSTB.Columns["TinhTrangHong"].ReadOnly = false;

            /*Cột tình trạng combobox*/
            DataGridViewComboBoxColumn col = new DataGridViewComboBoxColumn();
            //col.DrawMode = DrawMode.Normal;
            //col.FlatStyle = FlatStyle.Flat;
            col.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            //col.DropDownStyle = ComboBoxStyle.DropDownList;
            col.HeaderText = "Tinh trạng";
            col.Name = "Combo";
            col.ValueType = typeof(int);
            col.DisplayMember = "Ten";
            col.ValueMember = "Id";
            col.DataSource = GlobalVariable.GetDS().TinhTrangPhieuBH;
            col.DefaultCellStyle.NullValue = "Hỏng";
            // col.Items.AddRange(GlobalVariable.GetDS().TinhTrangPhieuBH.Select(p => p.Ten).ToArray());
            ADGVDSTB.Columns.Add(col);
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

            /*Vị trí hiển thị cho cột xóa và tình trạng*/
            ADGVDSTB.Columns["SoLuongMuon"].DisplayIndex = 5;
            ADGVDSTB.Columns["Combo"].DisplayIndex = 6;
            ADGVDSTB.Columns["LyDo"].DisplayIndex = 7;
            ADGVDSTB.Columns["TinhTrangHong"].DisplayIndex = 8;
            ADGVDSTB.Columns["TinhTrang"].DisplayIndex = 9;
            ADGVDSTB.Columns.Add(col1);
            ADGVDSTB.Columns["Remove"].DisplayIndex = 10;
            ADGVDSTB.Columns["Remove"].HeaderText = "";


            /*Set lại event cellvaluechanged*/
            ADGVDSTB.CellValueChanged -= ADGVDSTB_CellValueChanged;
            ADGVDSTB.CellValueChanged += ADGVDSTB_CellValueChanged;
        }
        private void saveData()
        {
            var PhieuMoi = new PhieuBaoHongModel
            {
                PhieuBaoHongId = txtSoPhieu.Text,
                NgayLap = dpickerNgayLap.Value,
                GhiChu = txtGhiChu.Text,
                IsDelete = false,
                NguoiLamHong = txtNguoiLamHong.Text,
                
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
                    MessageBox.Show("Khai báo phiếu báo hỏng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (result == 0)
                {
                    MessageBox.Show("Khai báo phiếu bao hỏng không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                int result = handler.Update(PhieuMoi, dsThietBi);
                if (result == 1)
                {
                    MessageBox.Show("Cập nhật thành công thông tin phiếu báo hỏng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (result == 0)
                {
                    MessageBox.Show("Cập nhật thông tin phiếu báo hỏng không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra, xin thử lại khi khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        public void AddToGrid(List<BaseThietBiGridDisplayModel> list)
        {

            var listSoHieu = dsThietBi.Select(p => p.SoHieu).ToList();
            var repeatList = list.Where(p => listSoHieu.Contains(p.SoHieu)).ToList();
            list.RemoveAll(p => listSoHieu.Contains(p.SoHieu));
            foreach (var item in list)
            {
                dsThietBi.Add(new ThietBiHongGridDisplayModel
                {
                    ThietBiId = item.ThietBiId,
                    SoHieu = item.SoHieu,
                    DonViTinh = item.DonViTinh,
                    PhongHoc = item.PhongHoc,
                    Ten = item.Ten,
                    SoLuongMuon = "1",
                    LyDo = "",
                    TinhTrang = "1",
                    TinhTrangHong = "",
                });
            }
            //

            source = new BindingSource();
            source.DataSource = MyConvert.ToDataTable<ThietBiHongGridDisplayModel>(dsThietBi);
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
                            if (handler.RemoveFromList(id, Phieu.PhieuBaoHongId) == 1)
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
        private void ADGVDSTB_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var SoHieu = ADGVDSTB.Rows[e.RowIndex].Cells["SoHieu"].Value.ToString();
            var selectedDevice = dsThietBi.Where(p => p.SoHieu.Equals(SoHieu)).FirstOrDefault();
            if (ADGVDSTB.Columns["Combo"].Index == e.ColumnIndex)
            {
                var value = ADGVDSTB.Rows[e.RowIndex].Cells["Combo"] as DataGridViewComboBoxCell;

                selectedDevice.TinhTrang = value.Value.ToString();
            }
            else if (ADGVDSTB.Columns["LyDo"].Index == e.ColumnIndex)
            {
                var value = ADGVDSTB.Rows[e.RowIndex].Cells["LyDo"].Value.ToString();
                selectedDevice.LyDo = value;
            }
            else if (ADGVDSTB.Columns["TinhTrangHong"].Index == e.ColumnIndex)
            {
                var value = ADGVDSTB.Rows[e.RowIndex].Cells["TinhTrangHong"].Value.ToString();
                selectedDevice.TinhTrangHong = value;
            }
        }
        private void frmPhieuBaoHong_Load(object sender, EventArgs e)
        {
            loadForm();
            if (dsBase != null)
            {
                AddToGrid(dsBase);
            }
            foreach (DataGridViewRow item in ADGVDSTB.Rows)
            {

                if (item.Cells["TinhTrang"].Value != null)
                {

                }
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLayTB_Click(object sender, EventArgs e)
        {
            //List<BaseThietBiGridDisplayModel> ds = new List<BaseThietBiGridDisplayModel>();
            //foreach (var item in dsThietBi)
            //{
            //    ds.Add(new BaseThietBiGridDisplayModel
            //    {
            //        ThietBiId = item.ThietBiId,
            //        SoHieu = item.SoHieu,
            //        DonViTinh = item.DonViTinh,
            //        PhongHoc = item.PhongHoc,
            //        Ten = item.Ten
            //    });
            //}
            //frmDialogTBBaoHong frm = new frmDialogTBBaoHong();
            //frm.Text = "Danh sách thiết bị trong phiếu mượn";
            //frm.ShowDialog(this);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            saveData();
        }

        private void frmPhieuBaoHong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
