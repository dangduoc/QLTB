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
    public partial class frmDialogTBToiThieu : DevComponents.DotNetBar.Office2007Form
    {
        private DbThietBiTTHandler handler = new DbThietBiTTHandler();
        public frmDialogTBToiThieu()
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
        private void ShowPage(int page, int pageSize)
        {
            var data = handler.GetAll(page, pageSize);
            List<ThietBiTTGridDisplayModel> list = data.data;
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
        }
        private void loadData(List<ThietBiTTGridDisplayModel> list)
        {
            BindingSource source = new BindingSource();
            source.DataSource = MyConvert.ToDataTable<ThietBiTTGridDisplayModel>(list);
            ADGVDanhSach.DataSource = source;
        }

        private void LoadForm()
        {
            #region Init Gridview
            List<ThietBiTTGridDisplayModel> list = new List<ThietBiTTGridDisplayModel>();
            //
            List<string> headers = new List<string>();
            headers.Add("Mã thiết bị");
            headers.Add("Tên thiết bị");
            headers.Add("Dùng cho lớp");
            headers.Add("Loại thiết bị");
            headers.Add("Môn học");
            headers.Add("Đầu mục");
            headers.Add("Số lượng");
            headers.Add("Đơn vị tính");
            headers.Add("Mô tả");

            //
            DataTable tb = MyConvert.ToDataTable(list);;
            source.DataSource = SetUpSearch(tb, headers);
            ADGVDanhSach.DataSource = source;
            SetHeaderForGrid(ADGVDanhSach, headers);
            ADGVDanhSach.Columns["ThietBiId"].Width = 80;
            ADGVDanhSach.Columns["DungChoLop"].Width = 80;
            ADGVDanhSach.Columns["LoaiThietBi"].Width = 80;
            ADGVDanhSach.Columns["DauMuc"].Width = 60;
            ADGVDanhSach.Columns["SoLuong"].Width = 60;
            ADGVDanhSach.Columns["DonViTinh"].Width = 60;
            ADGVDanhSach.Columns["MonHoc"].Width = 100;

            ADGVDanhSach.SortStringChanged += advancedDataGridView_SortStringChanged;
            ADGVDanhSach.FilterStringChanged += advancedDataGridView_FilterStringChanged;
            //
            prevBtn.Click += pageBtnClick;
            nextBtn.Click += pageBtnClick;

            #endregion

            ShowPage(1, 50);
        }
        private void frmDialogTBToiThieu_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var item = ADGVDanhSach.SelectedRows[0];
            if (item != null)
            {
                var tb = new ThietBiTTDialogModel
                {
                    ThietBiId = item.Cells["ThietBiId"].Value.ToString(),
                    Ten = item.Cells["Ten"].Value.ToString(),
                    LoaiThietBi = item.Cells["LoaiThietBi"].Value.ToString()
                };
                tb.SoLuongCon = new DbThietBiHandler().GetSoLuong(tb.ThietBiId);
                var owner = this.Owner.ActiveControl as frmPhieuMuaThietBi;
                owner.AddToGrid(tb);
                Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
