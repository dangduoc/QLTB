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
    public partial class frmDanhSachMuonTB : DevComponents.DotNetBar.Office2007Form
    {
       
        public frmDanhSachMuonTB()
        {
            InitializeComponent();
        }
        #region ADGV Setup
        private BindingSource source = new BindingSource();
        private string defaultSearchValue = "Value for search";
        private void advancedDataGridView_FilterStringChanged(object sender, EventArgs e)
        {
            var grid = sender as ADGV.AdvancedDataGridView;
            ((BindingSource)grid.DataSource).Filter = grid.FilterString;
        }
        private void advancedDataGridView_SortStringChanged(object sender, EventArgs e)
        {
            var grid = sender as ADGV.AdvancedDataGridView;
            ((BindingSource)grid.DataSource).Sort = grid.SortString;
        }
        private void SetUpSearch(ADGV.SearchToolBar toolBar, DataTable tb, List<string> headers, ADGV.AdvancedDataGridView grid)
        {
            DataTable Table = tb;
            ToolStripTextBox textSearch = toolBar.Items[3] as ToolStripTextBox;
            ToolStripButton searchCaseSensitive = toolBar.Items[6] as ToolStripButton;
            ToolStripButton searchWholeText = toolBar.Items[5] as ToolStripButton;
            ToolStripButton searchBegin = toolBar.Items[4] as ToolStripButton;
            ToolStripComboBox columns = toolBar.Items[2] as ToolStripComboBox;
            ToolStripLabel label = toolBar.Items[1] as ToolStripLabel;
            label.Text = "Tìm kiếm";
            label.ForeColor = Color.Black;
            columns.DropDownStyle = ComboBoxStyle.DropDown;
            columns.FlatStyle = FlatStyle.Flat;
            //
            //
            searchBegin.Checked = false;
            //
            textSearch.TextChanged += (sender, e) => SearchStringChanged(sender, e, toolBar, grid);
            //textSearch.ToolTipText = "Nhập vào giá trị tìm kiếm";
            //
            searchCaseSensitive.CheckedChanged += (sender, e) => SearchOptionChanged(sender, e, toolBar, grid);
            searchWholeText.CheckedChanged += (sender, e) => SearchOptionChanged(sender, e, toolBar, grid);
            searchBegin.CheckedChanged += (sender, e) => SearchOptionChanged(sender, e, toolBar, grid);
            //

            //

            columns.ComboBox.DisplayMember = "value";
            columns.ComboBox.ValueMember = "key";
            List<object> columValues = new List<object>();
            columValues.Add(new { key = "All", value = "Tất cả các cột" });
            for (int i = 0; i < headers.Count; i++)
            {
                columValues.Add(new { key = Table.Columns[i].ColumnName, value = headers[i] });
            }
            columns.ComboBox.DataSource = columValues;
            columns.ComboBox.SelectedValueChanged += (sender, e) => SearchOptionChanged(sender, e, toolBar, grid);
            columns.SelectedIndexChanged += (sender, e) => SearchOptionChanged(sender, e, toolBar, grid);
            BindingSource source = new BindingSource();
            source.DataSource = tb;
            grid.DataSource = source;
        }
        private void SetHeaderForGrid(ADGV.AdvancedDataGridView grid, List<string> headers)
        {
            for (int i = 0; i < headers.Count; i++)
            {
                grid.Columns[i].HeaderText = headers[i];
            }
        }
        private void SearchOptionChanged(object sender, EventArgs e, ADGV.SearchToolBar toolBar, ADGV.AdvancedDataGridView grid)
        {
            searchChanged(toolBar, grid);
        }
        private void SearchStringChanged(object sender, EventArgs e, ADGV.SearchToolBar toolBar, ADGV.AdvancedDataGridView grid)
        {
            ToolStripTextBox textSearch = sender as ToolStripTextBox;
            if (textSearch.Selected)
            {
                searchChanged(toolBar, grid);
            }
            else if (String.IsNullOrEmpty(textSearch.Control.Text))
            {
                ((BindingSource)grid.DataSource).Filter = null;
            }
        }
        public void searchChanged(ADGV.SearchToolBar toolBar, ADGV.AdvancedDataGridView grid)
        {
            ToolStripTextBox textSearch = toolBar.Items[3] as ToolStripTextBox;
            if (!textSearch.Text.Equals(defaultSearchValue))
            {
                ToolStripComboBox columns = toolBar.Items[2] as ToolStripComboBox;
                ToolStripButton searchBegin = toolBar.Items[4] as ToolStripButton;
                ToolStripButton searchWholeText = toolBar.Items[5] as ToolStripButton;
                ToolStripButton searchCaseSensitive = toolBar.Items[6] as ToolStripButton;
                string lastString = "%";
                string firstString = "%";
                if (searchBegin.Checked) firstString = string.Empty;
                if (searchWholeText.Checked) lastString = string.Empty;
                var source = (BindingSource)grid.DataSource;
                ((DataTable)source.DataSource).CaseSensitive = searchCaseSensitive.Checked;
                //
                StringBuilder filter = new StringBuilder();
                if (columns.ComboBox.SelectedValue.ToString().Equals("All"))
                {
                    foreach (DataGridViewColumn column in grid.Columns)
                    {
                        string colName = column.Name;
                        if (column.ValueType != typeof(String))
                        {
                            colName = "Convert(" + colName + ",System.String)";
                        }
                        if (filter.ToString() == "")
                        {
                            filter.Append(colName + " Like '" + firstString + textSearch.Text + lastString + "'");
                        }
                        else
                        {
                            filter.Append(" OR ");
                            filter.Append(colName + " Like '" + firstString + textSearch.Text + lastString + "'");
                        }
                    }
                }
                else
                {
                    string colName = columns.ComboBox.SelectedValue.ToString();
                    colName = "Convert(" + colName + ",System.String)";
                    filter.Append(colName + " Like '" + firstString + textSearch.Text + lastString + "'");
                }
                source.Filter = filter.ToString();
            }
        }
        private void ADGVDanhSach_MouseClick(object sender, MouseEventArgs e)
        {
            if (ADGVDanhSach.SelectedRows[0] != null)
            {
                if (e.Button == MouseButtons.Right)
                {
                    contextMenuStrip.Show(ADGVDanhSach, e.Location);
                }
            }
        }
        #endregion
        private void LoadForm()
        {
            //Clone
            //List<PhieuMuonTBGridDisplayModel> list = new DbPhieuMuonTBHandler().GetAll();
            List<PhieuMuonTBGridDisplayModel> list = new List<PhieuMuonTBGridDisplayModel>();
            list.Add(new PhieuMuonTBGridDisplayModel
            {
                PhieuMuonTBId="PMTB00001",
                BaiDay="Công nghệ tiết 1",
                GiaoVien="Đặng Minh Được",
                LopHoc="Lớp 7A1",
                NgayMuon="21/11/2015",
                NgayTra="22/11/2015",
                TrangThai="Đang sử dụng"
            });
            list.Add(new PhieuMuonTBGridDisplayModel
            {
                PhieuMuonTBId = "PMTB00002",
                BaiDay = "Công nghệ tiết 2",
                GiaoVien = "Đặng Minh Được",
                LopHoc = "Lớp 7A1",
                NgayMuon = "21/11/2015",
                NgayTra = "22/11/2015",
                TrangThai = "Đang sử dụng"
            });
            list.Add(new PhieuMuonTBGridDisplayModel
            {
                PhieuMuonTBId = "PMTB00003",
                BaiDay = "Công nghệ tiết 3",
                GiaoVien = "Đặng Minh Được",
                LopHoc = "Lớp 7A1",
                NgayMuon = "21/11/2015",
                NgayTra = "22/11/2015",
                TrangThai = "Đang sử dụng"
            });
            List<string> headers = new List<string>();
            headers.Add("Số phiếu");
            headers.Add("Ngày mượn");
            headers.Add("Ngày trả");
            headers.Add("Bài dạy");
            headers.Add("Lớp học");
            headers.Add("Giáo viên");
            headers.Add("Trạng thái");
            //
            
        


            //
            DataTable tb = MyConvert.ToDataTable(list);
            SetUpSearch(SearchDSTB, tb, headers, ADGVDanhSach);
            SetHeaderForGrid(ADGVDanhSach, headers);
            ADGVDanhSach.FilterStringChanged += advancedDataGridView_FilterStringChanged;
            ADGVDanhSach.SortStringChanged += advancedDataGridView_SortStringChanged;
            ADGVDanhSach.CellContentDoubleClick += advancedDataGridView_CellContentDoubleClick;
            ADGVDanhSach.KeyPress += advancedDataGridView_KeyPress;
            ADGVDanhSach.MouseClick += ADGVDanhSach_MouseClick;

            //
            btnThem.Click += btnThem_Click;
            btnSua.Click += BtnSua_Click;
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            var row = ADGVDanhSach.SelectedRows[0];
            var id=row.Cells["PhieuMuonTBId"].ToString();
            frmThietBiMuon frm = new frmThietBiMuon(id);
            frm.MdiParent = MdiParent;
            frm.Show();
            Cursor = Cursors.Default;
        }

        private void frmDanhSachMuonTB_Load(object sender, EventArgs e)
        {
            LoadForm();
        }
        private void advancedDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var Id = ADGVDanhSach.Rows[e.RowIndex].Cells["PhieuMuonTBId"].Value.ToString();
            frmThietBiMuon frm = new frmThietBiMuon(Id);
            frm.MdiParent = MdiParent;
            frm.Show();
        }
        private void advancedDataGridView_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                var row = ADGVDanhSach.SelectedRows[0];
                if (row != null)
                {
                    var Id = row.Cells["PhieuMuonTBId"].Value.ToString();
                    frmThietBiMuon frm = new frmThietBiMuon(Id);
                    frm.MdiParent = MdiParent;
                    frm.Show();
                }
            }
        }

        private void btnGhiTra_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            var row = ADGVDanhSach.SelectedRows[0];
            if (row != null)
            {
                var Id = row.Cells["PhieuMuonTBId"].Value.ToString();
                frmGhiNhanTraTB frm = new frmGhiNhanTraTB();
                frm.MdiParent = MdiParent;
                frm.Show();
            }
            Cursor = Cursors.Default;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
             frmThietBiMuon frm = new frmThietBiMuon();
            frm.MdiParent = MdiParent;
            frm.Show();
            Cursor = Cursors.Default;
        }

        private void ADGVDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            List<ThietBiMuonGridDisplayModel> listTB = new List<ThietBiMuonGridDisplayModel>();
            listTB.Add(new ThietBiMuonGridDisplayModel
            {
                ThietBiId = "CSCN00001",
                SoHieu = "CSCN00001.01",
                SoLuongMuon = "2",
                DonViTinh = "Cái",
                Ten = "Đồ dùng môn công nghệ",
                PhongHoc = "Phòng thực hành công nghệ"
            });
            listTB.Add(new ThietBiMuonGridDisplayModel
            {
                ThietBiId = "CSCN00002",
                SoHieu = "CSCN00002.01",
                SoLuongMuon = "1",
                DonViTinh = "Cái",
                Ten = "Đồ dùng môn công nghệ 2",
                PhongHoc = "Phòng thực hành công nghệ"
            });
            List<string> headers = new List<string>();
            headers.Add("Mã thiết bị");
            headers.Add("Tên thiết bị");
            headers.Add("Số hiệu");
            headers.Add("Phòng bộ môn");
            headers.Add("Số lượng");
            headers.Add("Đơn vị tính");
            
            BindingSource source = new BindingSource();
            source.DataSource= MyConvert.ToDataTable<ThietBiMuonGridDisplayModel>(listTB);
            ADGVDSTB.DataSource = source;
            SetHeaderForGrid(ADGVDSTB, headers);
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGhiTra_Click_1(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            frmGhiNhanTraTB frm = new frmGhiNhanTraTB();
            frm.MdiParent = MdiParent;
            frm.Show();
            Cursor = Cursors.Default;
        }

        private void btnBaoHong_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            frmPhieuBaoHong frm = new frmPhieuBaoHong();
            frm.MdiParent = MdiParent;
            frm.Show();
            Cursor = Cursors.Default;
        }
    }
}
