using DevComponents.DotNetBar.SuperGrid;
using DevComponents.DotNetBar.SuperGrid.Style;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QLTB.Model;
using QLTB.Handler;
using QLTB.Utils;
using System.Linq;

namespace QLTB.GUI
{
    public partial class Form2 : DevComponents.DotNetBar.Office2007Form
    {
        #region Private variables
        private int _BaseColumnCount;

        //
        private PhieuKiemKeThietBiModel Phieu;
        private List<BanKiemKeGridDisplayModel> bankiemke = new List<BanKiemKeGridDisplayModel>();
        private List<ThietBiKKGridDisplayModel> dsThietBi = new List<ThietBiKKGridDisplayModel>();
        private DbKiemKeTBHandler handler = new DbKiemKeTBHandler();
        private DanhSachModel dshandler = new DanhSachModel();
        private BindingSource source = new BindingSource();
        #endregion
        public Form2()
        {
            InitializeComponent();
            Phieu = null;
            txtSoPhieu.Text = handler.GenerateCode();
            loadForm();
        }
        public Form2(string SoPhieu)
        {
            InitializeComponent();
            Phieu = handler.GetById(SoPhieu);
            txtSoPhieu.Enabled = false;
            if (Phieu == null)
            {
                MessageBox.Show("Thông tìm thấy phiếu thanh lý", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
            loadForm();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            GridPanel panel = superGridControl1.PrimaryGrid;
            GridColumnCollection columns = panel.Columns;
            panel.ColumnHeader.GroupHeaders.Add(GetClChenhLechHeader(columns));
            panel.ColumnHeader.GroupHeaders.Add(GetClSauHeader(columns));
            panel.ColumnHeader.GroupHeaders.Add(GetClTruocHeader(columns));
            panel.SetGroup(columns["MonHoc"]);
            
        }
        private void loadForm()
        {
            BindingSource src = new BindingSource();
            
            #region Loading data
            cbbPhongBM.DisplayMember = "value";
            cbbPhongBM.ValueMember = "key";
            cbbPhongBM.DataSource = new DbPhongBMHandler().GetNames().Select(p => new { key = p.PhongHocId, value = p.Ten }).ToList();
            //load thong tin phieu 
            if (Phieu != null)
            {
                //Thong tin chung
                txtSoPhieu.Text = Phieu.SoPhieu;
                txtGhiChu.Text = Phieu.GhiChu;
                cbbPhongBM.SelectedValue = Phieu.PhongHocId;
                dpickerNgayKK.Value = Phieu.NgayKiemKe;
                dpickerNgayLap.Value = Phieu.NgayLap;
                //ban kiểm kê
                if (Phieu.BanKiemKe != null)
                {
                    bankiemke.AddRange(Phieu.BanKiemKe);
                    foreach (var item in Phieu.BanKiemKe)
                    {
                        int i = bankiemke.Count + 1;
                        var str = i++.ToString() + ", " + item.HoTen + " - " + item.ChucVu + " - " + item.DaiDien;
                        lboxBanKiemKe.Items.Add(str);
                    }
                }
                else
                {
                    Phieu.BanKiemKe = new List<BanKiemKeGridDisplayModel>();
                }
                //Thiet bi
                if (Phieu.ThietBis == null)
                {
                    Phieu.ThietBis = new List<ThietBiKKGridDisplayModel>();
                }
                else
                {
                    dsThietBi.AddRange(Phieu.ThietBis);

                }
                InitializeGrid(MyConvert.ToDataTable(dsThietBi));
            }
            else
            {
                InitializeGrid(MyConvert.ToDataTable(handler.GetTB()));
            }
        }
        private void saveData()
        {
            var PhieuMoi = new PhieuKiemKeThietBiModel
            {
                SoPhieu = txtSoPhieu.Text,
                GhiChu = txtGhiChu.Text,
                NgayLap = dpickerNgayLap.Value,
                NgayKiemKe = dpickerNgayKK.Value,
                PhongHocId = (int)cbbPhongBM.SelectedValue
            };
            if (Phieu == null)
            {

                PhieuMoi.ThietBis = dsThietBi;
                PhieuMoi.BanKiemKe = bankiemke;
                int result = handler.Create(PhieuMoi);
                if (result == 1)
                {
                    MessageBox.Show("Thông tin kiểm kê được lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (result == 0)
                {
                    MessageBox.Show("Thông tin kiểm kê lưu chưa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra, xin thử lại khi khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                PhieuMoi.BanKiemKe = bankiemke;
                PhieuMoi.ThietBis = dsThietBi;
                int result = handler.Update(PhieuMoi);
                if (result == 1)
                {
                    MessageBox.Show("Cập nhật thông tin kiểm kê thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        #region Super Grid Set up
        #region Group header
        private ColumnGroupHeader GetClTruocHeader(GridColumnCollection columns)
        {
            ColumnGroupHeader cgh = new ColumnGroupHeader();

            cgh.Name = "TruocKiemKe";
            cgh.HeaderText = "Trước kiểm kê";
            cgh.MinRowHeight = 36;
            cgh.StartDisplayIndex = GetDisplayIndex(columns, "MatTruoc");
            cgh.EndDisplayIndex = GetDisplayIndex(columns, "HongTruoc");

            return (cgh);
        }
        private ColumnGroupHeader GetClSauHeader(GridColumnCollection columns)
        {
            ColumnGroupHeader cgh = new ColumnGroupHeader();

            cgh.Name = "SauKiemKe";
            cgh.HeaderText = "Sau kiểm kê";
            cgh.MinRowHeight = 36;
            cgh.StartDisplayIndex = GetDisplayIndex(columns, "MatSau");
            cgh.EndDisplayIndex = GetDisplayIndex(columns, "ConDungDuoc");

            return (cgh);
        }
        private ColumnGroupHeader GetClChenhLechHeader(GridColumnCollection columns)
        {
            ColumnGroupHeader cgh = new ColumnGroupHeader();

            cgh.Name = "ChenhLech";
            cgh.HeaderText = "Chênh lệch";
            cgh.MinRowHeight = 36;
            cgh.StartDisplayIndex = GetDisplayIndex(columns, "ChenhLechMat");
            cgh.EndDisplayIndex = GetDisplayIndex(columns, "ChenhLechHong");

            return (cgh);
        }
        #endregion
        private int GetDisplayIndex(GridColumnCollection columns, string name)
        {
            return (columns.GetDisplayIndex(columns[name]));
        }
        private void ShowColumn(
           GridColumnCollection columns, string name, int dindex, string headerText)
        {
            GridColumn col = columns[name];

            col.Visible = true;
            col.DisplayIndex = dindex;

            if (headerText != null)
                col.HeaderText = headerText;
        }
        private void HideColumn(GridColumnCollection columns, string name)
        {
            columns[name].Visible = false;
        }
        #region InitializeGrid
        private void InitializeGrid(DataTable tb)
        {
            GridPanel panel = superGridControl1.PrimaryGrid;
            panel.Name = "Customers";
            panel.MinRowHeight = 20;
            BindCustomerData(tb);
            superGridControl1.DataBindingComplete += SuperGridControl1DataBindingComplete;
        }
        
        #region BindCustomerData
        private void BindCustomerData(DataTable table)
        {
            BindingSource src = new BindingSource();
            src.DataSource = table;
            _BaseColumnCount = table.Columns.Count;
            // Fill the newly added columns with
            // 'useful' data.
            // Bind our grid to the created dataset.

            superGridControl1.PrimaryGrid.DataSource = src;
            superGridControl1.PrimaryGrid.DataMember = "Customers";
        }
        #endregion
        #endregion
        #region AddNewColumns
        private void AddNewColumns(DataTable table, IEnumerable<string> names)
        {
            Type type = Type.GetType("System.Decimal");

            foreach (string name in names)
                table.Columns.Add(new DataColumn(name, type));
        }
        #endregion
        #region SuperGridControl1DataBindingComplete
        void SuperGridControl1DataBindingComplete(
            object sender, GridDataBindingCompleteEventArgs e)
        {
            GridPanel panel = e.GridPanel;
            GridColumnCollection columns = panel.Columns;

            // Set a few default panel properties

            panel.DefaultRowHeight = 40;
            panel.UseAlternateRowStyle = true;

            // Set initial column defaults

            foreach (GridColumn col in columns)
            {
                col.CellStyles.Default.AllowWrap = Tbool.True;

                col.ColumnSortMode = ColumnSortMode.Multiple;
                col.EnableHeaderMarkup = true;
            }

            SetColumnTw(columns, "Ten", "Tên", 200);
            SetColumnTw(columns, "SoHieu", "Số hiệu", 100);
            SetColumnTw(columns, "PhongHoc", "Kho/ Phòng bộ môn", 120);
            SetColumnTw(columns, "SoLuong", "Số lượng", 100);
            SetColumnTw(columns, "DonViTinh", "Đơn vị tính", 100);
            SetColumnTw(columns, "MatTruoc", "Mất", 100);
            SetColumnTw(columns, "HongTruoc", "Số lượng", 100);
            SetColumnTw(columns, "MatSau", "Số lượng", 100);
            SetColumnTw(columns, "HongSau", "Số lượng", 100);
            SetColumnTw(columns, "ConDungDuoc", "Số lượng", 100);
            SetColumnTw(columns, "ChenhLechMat", "Số lượng", 100);
            SetColumnTw(columns, "ChenhLechHong", "Số lượng", 100);
            SetColumnTw(columns, "GhiChu", "Ghi chú", 200);
            //SetupCurrencyColumns(columns, new string[] { "MTD", "YTD", "LTD", "T1", "T2", "T3" });
            // SetupPctColumns(columns, new string[] { "P1", "P2", "P3", "P4" });

            ResetLayout();
        }
        #endregion
        #region SetColumnTw
        private void SetColumnTw(GridColumnCollection columns,
            string name, string text, int width)
        {
            GridColumn col = columns[name];

            if (col != null)
            {
                col.HeaderText = text;
                col.Width = width;
            }
        }

        #endregion
        #region ResetLayout
        private void ResetLayout()
        {
            GridPanel panel = superGridControl1.PrimaryGrid;
            GridColumnCollection columns = panel.Columns;

            for (int i = 0; i < columns.Count; i++)
            {
                GridColumn col = columns[i];

                col.Visible = (i < _BaseColumnCount);
                col.DisplayIndex = -1;

                col.HeaderStyles.Default.Image = null;
                col.HeaderStyles.Default.Background = null;
                col.HeaderStyles.MouseOver.Background = null;
                col.CellStyles.Default.Background = null;
            }

            // columns["Country"].HeaderText = null;

            panel.ColumnHeader.GroupHeaders.Clear();
            panel.ClearAll();
        }
        #endregion
        #region Ban kiểm kê
        private void addBanKK_Click(object sender, EventArgs e)
        {
            frmDialogThemBanKK frm = new frmDialogThemBanKK();
            frm.ShowDialog(this);
        }
        private void btnRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            RemovePerson();
        }
        public void AddPerson(BanKiemKeGridDisplayModel person)
        {
            bankiemke.Add(person);
            bankiemke = bankiemke.OrderBy(p => p.VaiTro).ToList();
            lboxBanKiemKe.Items.Clear();
            foreach (var item in bankiemke)
            {
                int i = bankiemke.Count + 1;
                var str = i++.ToString() + ", " + item.HoTen + " - " + item.ChucVu + " - " + item.DaiDien;
                lboxBanKiemKe.Items.Add(str);
            }
        }
        public void RemovePerson()
        {
            int index = lboxBanKiemKe.SelectedIndex;
            if (index >= 0)
            {
                lboxBanKiemKe.Items.RemoveAt(index);
                bankiemke.RemoveAt(index);
            }
            else
            {
                MessageBox.Show("Danh sách trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Danh sách thiết bị
        private void btnChonTB_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDialogTBToiThieu frm = new frmDialogTBToiThieu();
        }

        #endregion
        #endregion
        #endregion
        private void comboBoxEx1_DataColumnCreated(object sender, DevComponents.DotNetBar.Controls.DataColumnEventArgs e)
        {
            //DevComponents.AdvTree.ColumnHeader header = e.ColumnHeader;
            //if (header.DataFieldName == "ContactTitle") // Make title column narrow
            //{
            //    header.Width.Relative = 20; // 20% of available width
            //}
            //else // All other columns are at 40% available width
            //{
            //    header.Width.Relative = 40;
            //}
        }
    }
}
