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
    public partial class frmThietBi : DevComponents.DotNetBar.Office2007Form
    {
        private string defaultSearchValue = "Value for search";
        public frmThietBi()
        {
            InitializeComponent();
            btnDSThietBi.Click += btnDSThietBi_Click;
            btnKiemKe.Click += btnKiemKe_Click;
        }
        #region Danh sách thiết bị

        #endregion
        #region Tăng thiết bị
        #endregion
        #region Loading forms
        private void LoadFormThietBi()
        {
            List<ThietBiGridDisplayModel> list = new DbThietBiHandler().GetAll();
            List<string> headers = new List<string>();
            headers.Add("Số hiệu");
            headers.Add("Mã thiết bị");
            headers.Add("Tên thiết bị");
            headers.Add("Kho/Phòng bộ môn");
            headers.Add("Bộ môn");
            headers.Add("Số lượng");
            headers.Add("Đơn vị tính");
            headers.Add("Mất");
            headers.Add("Hỏng");
            //
            DataTable tb = MyConvert.ToDataTable(list);
            SetUpSearch(SearchDSTB, tb, headers, ADGVDanhSachTB);
            SetHeaderForGrid(ADGVDanhSachTB, headers);
            ADGVDanhSachTB.Columns[2].Width = 170;
            ADGVDanhSachTB.Columns["KhoPhong"].Width = 170;
            ADGVDanhSachTB.Columns["SoLuong"].Width = 80;
            ADGVDanhSachTB.Columns["SoLuongHong"].Width = 50;
            ADGVDanhSachTB.Columns["SoLuongMat"].Width = 50;
            ADGVDanhSachTB.FilterStringChanged += advancedDataGridView_FilterStringChanged;
            ADGVDanhSachTB.SortStringChanged += advancedDataGridView_SortStringChanged;
            ADGVDanhSachTB.CellContentDoubleClick += ADGVDanhSachTB_CellContentDoubleClick;
            ADGVDanhSachTB.KeyPress += ADGVDanhSachTB_KeyPress;
            ADGVDanhSachTB.MouseClick += ADGVDanhSachTB_MouseClick;
            //
            btnSuaDSTB.Click += btnXemDSTB_Click;
            btnXoaDSTB.Click += btnXoaDSTB_Click;
            //

        }
        private void loadFormGhiTang()
        {
            
        }

        private void loadFormKiemKe()
        {
            List<KiemKeTBGridDisplayModel> list = new List<KiemKeTBGridDisplayModel>();
            list.Add(new KiemKeTBGridDisplayModel
            {
                SoHieu = "PKTTB00001",
                NgayKiemKe = "21/11/2010",
                NgayLap = "19/10/2010",
                GhiChu = ""
            });
            list.Add(new KiemKeTBGridDisplayModel
            {
                SoHieu = "PKTTB00002",
                NgayKiemKe = "21/11/2010",
                NgayLap = "19/10/2010",
                GhiChu = ""
            });
            list.Add(new KiemKeTBGridDisplayModel
            {
                SoHieu = "PKTTB00003",
                NgayKiemKe = "21/11/2010",
                NgayLap = "19/10/2010",
                GhiChu = ""
            });
            list.Add(new KiemKeTBGridDisplayModel
            {
                SoHieu = "PKTTB00004",
                NgayKiemKe = "21/11/2010",
                NgayLap = "19/10/2010",
                GhiChu = ""
            });
            List<string> headers = new List<string>();
            headers.Add("Số phiếu");
            headers.Add("Ngày lập");
            headers.Add("Ngày kiếm kê");
            headers.Add("Ghi chú");
            //
            DataTable tb = MyConvert.ToDataTable(list);
            SetUpSearch(SearchKiemKe, tb, headers, ADGVDSKiemKe);
            SetHeaderForGrid(ADGVDSKiemKe, headers);
            ADGVDSKiemKe.FilterStringChanged += advancedDataGridView_FilterStringChanged;
            ADGVDSKiemKe.SortStringChanged += advancedDataGridView_SortStringChanged;
            //ADGVDSKiemKe.CellContentDoubleClick += ADGVDanhSachTB_CellContentDoubleClick;
            //ADGVDSKiemKe.KeyPress += ADGVDanhSachTB_KeyPress;
            //ADGVDSKiemKe.MouseClick += ADGVDanhSachTB_MouseClick;
            //
            //btnSuaDSTB.Click += btnXemDSTB_Click;
            //btnXoaDSTB.Click += btnXoaDSTB_Click;
        }
        #endregion
        #region Event Function
        #region Share Function
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
        #endregion
        #region Danh sách thiết bị
        private void btnDSThietBi_Click(object sender, EventArgs e)
        {
            if (!this.DoubleBuffered) this.DoubleBuffered = true;
            tabControlPanel1.SuspendLayout();
            pnlBackDSThietBi.SuspendLayout();
            pnlContentDSTB.SuspendLayout();
            LoadFormThietBi();
            tabControlPanel1.ResumeLayout();
            pnlBackDSThietBi.ResumeLayout();
            pnlContentDSTB.ResumeLayout();
        }
        private void ADGVDanhSachTB_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = ADGVDanhSachTB.Rows[e.RowIndex].Cells["SoHieu"].Value.ToString();
            frmKhaiBaoThietBi frm = new frmKhaiBaoThietBi(id);
            frm.Text = "Chi thiết thông tin thiết bị";
            frm.MdiParent = MdiParent;
            frm.Show();
        }
        private void ADGVDanhSachTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            var row = ADGVDanhSachTB.SelectedRows[0];
            if (row != null)
            {
                if (e.KeyChar == (char)13)
                {
                    var id = row.Cells["SoHieu"].Value.ToString();
                    frmKhaiBaoThietBi frm = new frmKhaiBaoThietBi(id);
                    frm.Text = "Chi thiết thông tin thiết bị";
                    frm.MdiParent = MdiParent;
                    frm.Show();
                }
            }
        }
        private void ADGVDanhSachTB_MouseClick(object sender, MouseEventArgs e)
        {
            if (ADGVDanhSachTB.SelectedRows[0] != null)
            {
                if (e.Button == MouseButtons.Right)
                {
                    contextMenuStrip.Show(ADGVDanhSachTB, e.Location);
                }
            }
        }
        private void btnXemDSTB_Click(object sender, EventArgs e)
        {
            var id = ADGVDanhSachTB.SelectedRows[0].Cells["SoHieu"].Value.ToString();
            frmKhaiBaoThietBi frm = new frmKhaiBaoThietBi(id);
            frm.Text = "Chi thiết thông tin thiết bị";
            frm.MdiParent = MdiParent;
            frm.Show();
        }

        private void btnXoaDSTB_Click(object sender, EventArgs e)
        {
            var row = ADGVDanhSachTB.SelectedRows[0];
            var id = row.Cells["SoHieu"].Value.ToString();
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa thiết bị này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int result = new DbThietBiHandler().Delete(id);
                if (result == 1) MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("Xóa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ADGVDanhSachTB.Rows.Remove(row);
            }
        }
        #endregion
        #region Kiểm kê
        private void btnKiemKe_Click(object sender, EventArgs e)
        {
            if (!this.DoubleBuffered) this.DoubleBuffered = true;
            tabControlPanel3.SuspendLayout();
            pnlBackKiemKe.SuspendLayout();
            loadFormKiemKe();
            tabControlPanel3.ResumeLayout();
            pnlBackKiemKe.ResumeLayout();
        }
        #endregion
        #endregion
    }
}
