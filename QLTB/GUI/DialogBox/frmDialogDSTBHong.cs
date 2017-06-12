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
    public partial class frmDialogDSTBHong : DevComponents.DotNetBar.Office2007Form
    {
        private DbPhieuBaoHongHandler handler = new DbPhieuBaoHongHandler();
        public frmDialogDSTBHong()
        {
            InitializeComponent();
            ADGVDanhSach.SortStringChanged += advancedDataGridView_SortStringChanged;
            ADGVDanhSach.FilterStringChanged += advancedDataGridView_FilterStringChanged;
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
            var data = handler.GetAllTB(page,pageSize);
            List<BaseThietBiHongGridDisplayModel> list = data.data;
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
        private void loadData(List<BaseThietBiHongGridDisplayModel> list)
        {
            List<string> headers = new List<string>();
            headers.Add("Số hiệu");
            headers.Add("Mã thiết bị");
            headers.Add("Tên");
            headers.Add("Loại thiết bị");
            headers.Add("Tình trạng");
            headers.Add("Số phiếu báo hỏng");
            headers.Add("Phòng học");
            headers.Add("Đơn vị tính");
            DataTable tb = MyConvert.ToDataTable(list);
            this.Text = "Chọn thiết bị hỏng/mất";
            DataGridViewCheckBoxColumn col = new DataGridViewCheckBoxColumn();
            col.Name = "checkBtn";
            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col.HeaderCell = new DGVColumnHeaderCheckBox();
            source.DataSource = SetUpSearch(tb, headers);
            ADGVDanhSach.DataSource = source;
            SetHeaderForGrid(ADGVDanhSach, headers);
            ADGVDanhSach.Columns.Add(col);

            ADGVDanhSach.Columns["checkBtn"].Width = 40;
            ADGVDanhSach.Columns["checkBtn"].HeaderText = "";
            ADGVDanhSach.Columns["checkBtn"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ADGVDanhSach.Columns["checkBtn"].DefaultCellStyle.Padding = new Padding(5, 0, 0, 0);
            //
        }

        private void frmDialogDSTBHong_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var list = new List<BaseThietBiHongGridDisplayModel>();
            foreach (DataGridViewRow item in ADGVDanhSach.Rows)
            {
                if (item.Cells["checkBtn"].Value != null)
                {
                    var tmp = new BaseThietBiHongGridDisplayModel
                    {
                        ThietBiId = item.Cells["ThietBiId"].Value.ToString(),
                        Ten = item.Cells["Ten"].Value.ToString(),
                        SoHieu = item.Cells["SoHieu"].Value.ToString(),
                        PhongHoc = item.Cells["PhongHoc"].Value.ToString(),
                        DonViTinh = item.Cells["DonViTinh"].Value.ToString(),
                        Loai=item.Cells["Loai"].Value.ToString(),
                        SoPhieuBaoHong=item.Cells["SoPhieuBaoHong"].Value.ToString(),
                        TinhTrang=item.Cells["TinhTrang"].Value.ToString()
                    };
                    list.Add(tmp);
                }
            }
            if (list.Count > 0)
            {
                
                var owner = this.Owner.ActiveControl as IFrmPhieuTBHong;
                owner.AddToGrid(list);
            }
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Đang xây dựng");
            radioButton2.Checked = false;
        }
    }
}
