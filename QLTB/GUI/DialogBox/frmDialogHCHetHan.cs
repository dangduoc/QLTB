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
using QLTB.Report.Model;
namespace QLTB.GUI
{
    public partial class frmDialogHCHetHan : DevComponents.DotNetBar.Office2007Form
    {
        private DbThietBiHandler handler = new DbThietBiHandler();
        public frmDialogHCHetHan()
        {
            InitializeComponent();
        }
        #region ADGB
        private BindingSource source = new BindingSource();
        private string defaultSearchValue = "Value for search";
        private DataTable SetUpSearch(DataTable tb, List<string> headers)
        {
            DataTable Table = tb;
            ToolStripTextBox textSearch = SearchDSTB.Items[3] as ToolStripTextBox;
            ToolStripButton searchCaseSensitive = SearchDSTB.Items[6] as ToolStripButton;
            ToolStripButton searchWholeText = SearchDSTB.Items[5] as ToolStripButton;
            ToolStripButton searchBegin = SearchDSTB.Items[4] as ToolStripButton;
            ToolStripComboBox columns = SearchDSTB.Items[2] as ToolStripComboBox;
            ToolStripLabel label = SearchDSTB.Items[1] as ToolStripLabel;
            label.Text = "Tìm kiếm";
            //
            //
            searchBegin.Checked = false;
            //
            textSearch.TextChanged += SearchStringChanged;
            //textSearch.ToolTipText = "Nhập vào giá trị tìm kiếm";
            //
            searchCaseSensitive.CheckedChanged += SearchOptionChanged;
            searchWholeText.CheckedChanged += SearchOptionChanged;
            searchBegin.CheckedChanged += SearchOptionChanged;

            columns.ComboBox.DisplayMember = "value";
            columns.ComboBox.ValueMember = "key";
            List<object> columValues = new List<object>();
            columValues.Add(new { key = "All", value = "Tất cả các cột" });
            for (int i = 0; i < headers.Count; i++)
            {
                columValues.Add(new { key = Table.Columns[i].ColumnName, value = headers[i] });
            }
            columns.ComboBox.DataSource = columValues;
            columns.ComboBox.SelectedValueChanged += SearchOptionChanged;
            columns.SelectedIndexChanged += SearchOptionChanged;
            return Table;
        }
        private void SetHeaderForGrid(ADGV.AdvancedDataGridView grid, List<string> headers)
        {
            for (int i = 0; i < headers.Count; i++)
            {
                grid.Columns[i].HeaderText = headers[i];
            }
        }
        private void SearchOptionChanged(object sender, EventArgs e)
        {
            searchChanged();
        }
        private void advancedDataGridView_SortStringChanged(object sender, EventArgs e)
        {
            source.Sort = ADGVDanhSach.SortString;
        }

        private void advancedDataGridView_FilterStringChanged(object sender, EventArgs e)
        {
            source.Filter = ADGVDanhSach.FilterString;
        }
        private void SearchStringChanged(object sender, EventArgs e)
        {
            ToolStripTextBox textSearch = sender as ToolStripTextBox;
            if (textSearch.Selected)
            {
                searchChanged();
            }
            else if (String.IsNullOrEmpty(textSearch.SelectedText))
            {
                source.Filter = null;
            }
        }
        public void searchChanged()
        {

            ToolStripTextBox textSearch = SearchDSTB.Items[3] as ToolStripTextBox;
            if (!textSearch.Text.Equals(defaultSearchValue))
            {
                ToolStripComboBox columns = SearchDSTB.Items[2] as ToolStripComboBox;
                ToolStripButton searchBegin = SearchDSTB.Items[4] as ToolStripButton;
                ToolStripButton searchWholeText = SearchDSTB.Items[5] as ToolStripButton;
                ToolStripButton searchCaseSensitive = SearchDSTB.Items[6] as ToolStripButton;
                string lastString = "%";
                string firstString = "%";
                if (searchBegin.Checked) firstString = string.Empty;
                if (searchWholeText.Checked) lastString = string.Empty;
                ((DataTable)source.DataSource).CaseSensitive = searchCaseSensitive.Checked;
                //
                StringBuilder filter = new StringBuilder();
                if (columns.ComboBox.SelectedValue.ToString().Equals("All"))
                {
                    foreach (DataGridViewColumn column in ADGVDanhSach.Columns)
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
        private void LoadForm()
        {
            ShowPage(1, 50);
        }
        private void ShowPage(int page, int pageSize)
        {
            var data = handler.ThietBiHetHan(page, pageSize,4);
            List<ThietBiGridDisplayModel> list = data.data;
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
        private void loadData(List<ThietBiGridDisplayModel> list)
        {
            List<string> headers = new List<string>();
            headers.Add("Số hiệu");
            headers.Add("Mã thiết bị");
            headers.Add("Tên thiết bị");
            headers.Add("Kho/Phòng bộ môn");
            headers.Add("Bộ môn");
            headers.Add("Số lượng");
            headers.Add("Đơn giá");
            headers.Add("Thành tiền");
            headers.Add("Nguồn kinh phí");
            headers.Add("Đơn vị tính");
            headers.Add("Còn");
            headers.Add("Mất");
            headers.Add("Hỏng");
            headers.Add("Trạng thái");
            DataTable tb = MyConvert.ToDataTable(list);
            this.Text = "Danh sách thiết bị giáo dục";

            DataGridViewCheckBoxColumn col = new DataGridViewCheckBoxColumn();
            col.Name = "checkBtn";
            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col.HeaderCell = new DGVColumnHeaderCheckBox();
            col.TrueValue = "T";
            col.FalseValue = "F";
            source.DataSource = SetUpSearch(tb, headers);
            ADGVDanhSach.DataSource = source;
            SetHeaderForGrid(ADGVDanhSach, headers);

            ADGVDanhSach.Columns.Add(col);

            ADGVDanhSach.Columns["checkBtn"].Width = 40;
            ADGVDanhSach.Columns["checkBtn"].HeaderText = "";
            ADGVDanhSach.Columns["checkBtn"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ADGVDanhSach.Columns["checkBtn"].DefaultCellStyle.Padding = new Padding(5, 0, 0, 0);
            ADGVDanhSach.Columns["Ten"].Width = 170;
            ADGVDanhSach.Columns["KhoPhong"].Width = 170;
            ADGVDanhSach.Columns["SoLuong"].Width = 80;
            ADGVDanhSach.Columns["SoLuongHong"].Width = 50;
            ADGVDanhSach.Columns["SoLuongMat"].Width = 50;

            ADGVDanhSach.SortStringChanged += advancedDataGridView_SortStringChanged;
            ADGVDanhSach.FilterStringChanged += advancedDataGridView_FilterStringChanged;
            //
            prevBtn.Click += pageBtnClick;
            nextBtn.Click += pageBtnClick;
            //
        }

        private void frmDialogHCHetHan_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmReportDSHCHetHan frm = new frmReportDSHCHetHan();
            frm.ShowDialog();
        }
    }
}
