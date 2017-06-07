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
    public partial class frmDSPhieuTangTB : DevComponents.DotNetBar.Office2007Form
    {
        private DbGhiTangTBHandler handler = new DbGhiTangTBHandler();
        public frmDSPhieuTangTB()
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
        private void ADGVDanhSach_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = ADGVDanhSach.Rows[e.RowIndex].Cells["SoHieu"].Value.ToString();
            frmKhaiBaoThietBi frm = new frmKhaiBaoThietBi(id);
            frm.Text = "Chi thiết thông tin thiết bị";
            frm.MdiParent = MdiParent;
            frm.Show();
        }
        private void ADGVDanhSach_KeyPress(object sender, KeyPressEventArgs e)
        {
            var row = ADGVDanhSach.SelectedRows[0];
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
        private void ShowPage(int page, int pageSize)
        {
            var data = handler.GetAll(page, pageSize);
            List<PhieuTangTBGridDisplayModel> list = data.data;
            if (list.Count > 0)
            {
                loadData(list);
                prevBtn.Enabled = data.PreviousPage;
                prevBtn.Tag = page - 1;
                nextBtn.Enabled = data.NextPage;
                nextBtn.Tag = page + 1;
                currentPage.Text = data.CurrentPage.ToString();
                lbPaging.Text = "Trang " + currentPage.Text + "/" + data.Size;
                lbTotalRecord.Text = "- Tổng số bản ghi: " + data.TotalRecord;
            }
        }
        private void pageBtnClick(object sender, EventArgs e)
        {
            var btn = sender as LinkLabel;
            int page = Convert.ToInt32(btn.Tag);
            ShowPage(page, Convert.ToInt32(pageSize.SelectedValue.ToString()));
            //ShowPage(page, 4);
        }
        private void loadData(List<PhieuTangTBGridDisplayModel> list)
        {
            List<string> headers = new List<string>();
            headers.Add("Số phiếu");
            headers.Add("Ngày lập");
            headers.Add("Chứng từ liên quan");
            headers.Add("Nội dung");
            DataTable tb = MyConvert.ToDataTable(list);
            SetUpSearch(SearchDSTB, tb, headers, ADGVDanhSach);
            SetHeaderForGrid(ADGVDanhSach, headers);
            ADGVDanhSach.FilterStringChanged += advancedDataGridView_FilterStringChanged;
            ADGVDanhSach.SortStringChanged += advancedDataGridView_SortStringChanged;
            ADGVDanhSach.CellContentDoubleClick += ADGVDanhSach_CellContentDoubleClick;
            ADGVDanhSach.KeyPress += ADGVDanhSach_KeyPress;
            ADGVDanhSach.MouseClick += ADGVDanhSach_MouseClick;
        }
        private void LoadForm()
        {
            ShowPage(1, 50);
        }
        private void frmDSPhieuTangTB_Load(object sender, EventArgs e)
        {
            LoadForm();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            frmPhieuTangThietBi frm = new frmPhieuTangThietBi();
            frm.MdiParent = MdiParent;
            frm.Show();
            Cursor = Cursors.Default;
        }
        private void btnInDSTB_Click(object sender, EventArgs e)
        {
            

            frmDialogTSGhiTang frm = new frmDialogTSGhiTang();
            frm.ShowDialog(this);
        }

        private void btnSuaDSTB_Click(object sender, EventArgs e)
        {
            var SoPhieu = ADGVDanhSach.SelectedRows[0].Cells["PhieuGhiTangId"].Value.ToString();
            Cursor = Cursors.WaitCursor;
            frmPhieuTangThietBi frm = new frmPhieuTangThietBi(SoPhieu);
            frm.MdiParent = MdiParent;
            frm.Show();
            Cursor = Cursors.Default;
        }
    }
}
