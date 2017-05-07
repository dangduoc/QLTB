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
    public partial class frmDialogDSThietBi : DevComponents.DotNetBar.Office2007Form
    {
        private BindingSource source = new BindingSource();
        private string defaultSearchValue = "Value for search";
        //
        public frmDialogDSThietBi()
        {
            InitializeComponent();
        }
        private DataTable SetUpSearch(DataTable tb, List<string> headers)
        {
            DataTable Table = tb;
            ToolStripTextBox textSearch = searchToolBar.Items[3] as ToolStripTextBox;
            ToolStripButton searchCaseSensitive = searchToolBar.Items[6] as ToolStripButton;
            ToolStripButton searchWholeText = searchToolBar.Items[5] as ToolStripButton;
            ToolStripButton searchBegin = searchToolBar.Items[4] as ToolStripButton;
            ToolStripComboBox columns = searchToolBar.Items[2] as ToolStripComboBox;
            ToolStripLabel label = searchToolBar.Items[1] as ToolStripLabel;
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

            ToolStripTextBox textSearch = searchToolBar.Items[3] as ToolStripTextBox;
            if (!textSearch.Text.Equals(defaultSearchValue))
            {
                ToolStripComboBox columns = searchToolBar.Items[2] as ToolStripComboBox;
                ToolStripButton searchBegin = searchToolBar.Items[4] as ToolStripButton;
                ToolStripButton searchWholeText = searchToolBar.Items[5] as ToolStripButton;
                ToolStripButton searchCaseSensitive = searchToolBar.Items[6] as ToolStripButton;
                string lastString = "%";
                string firstString = "%";
                if (searchBegin.Checked) firstString = string.Empty;
                if (searchWholeText.Checked) lastString = string.Empty;
                ((DataTable)source.DataSource).CaseSensitive = searchCaseSensitive.Checked;
                //
                StringBuilder filter = new StringBuilder();
                if (columns.ComboBox.SelectedValue.ToString().Equals("All"))
                {
                    foreach (DataGridViewColumn column in advancedDataGridView.Columns)
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
        private void LoadForm()
        {

            //Clone
            List<ThietBiGridDisplayModel> list = new DbThietBiHandler().GetAll();
           
            //
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

            DataTable tb = MyConvert.ToDataTable(list);
            DataGridViewCheckBoxColumn col = new DataGridViewCheckBoxColumn();
            col.Name = "checkBtn";
            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col.HeaderCell = new DGVColumnHeaderCheckBox();
            source.DataSource = SetUpSearch(tb, headers);
            advancedDataGridView.DataSource = source;
            SetHeaderForGrid(advancedDataGridView, headers);
            advancedDataGridView.Columns.Add(col);
  
            advancedDataGridView.Columns["checkBtn"].Width = 20;
            advancedDataGridView.Columns["checkBtn"].HeaderText = "";
            advancedDataGridView.Columns["checkBtn"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            advancedDataGridView.Columns["checkBtn"].DefaultCellStyle.Padding = new Padding(5,0,0,0);
            advancedDataGridView.Columns["Ten"].Width = 170;
            advancedDataGridView.Columns["KhoPhong"].Width = 170;
            advancedDataGridView.Columns["SoLuong"].Width = 80;
            advancedDataGridView.Columns["SoLuongHong"].Width = 50;
            advancedDataGridView.Columns["SoLuongMat"].Width = 50;
        }

        private void frmDialogDSThietBi_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void advancedDataGridView_SortStringChanged(object sender, EventArgs e)
        {
            source.Sort = advancedDataGridView.SortString;
        }

        private void advancedDataGridView_FilterStringChanged(object sender, EventArgs e)
        {
            source.Filter = advancedDataGridView.FilterString;
        }

        private void advancedDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex > 0)&&(e.ColumnIndex==advancedDataGridView.Columns["checkBtn"].Index))
            {
            }
        }

        private void advancedDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
           // DataGridViewButtonCell cell = advancedDataGridView.Rows[e.RowIndex].Cells["btnCol"] as DataGridViewButtonCell;
           
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var list = new List<ThietBiMuonGridDisplayModel>();
            foreach (DataGridViewRow item in advancedDataGridView.Rows)
            {
                if (item.Cells[9].Value!=null)
                {
                    var tmp = new ThietBiMuonGridDisplayModel
                    {
                        ThietBiId = item.Cells["ThietBiId"].Value.ToString(),
                        Ten = item.Cells["Ten"].Value.ToString(),
                        SoHieu = item.Cells["SoHieu"].Value.ToString(),
                        PhongBM = item.Cells["KhoPhong"].Value.ToString(),
                        DVT = item.Cells["DonViTinh"].Value.ToString(),
                        SoLuongMuon = item.Cells["SoLuongMat"].Value.ToString()
                    };
                    list.Add(tmp);
                }
            }
            if (list.Count > 0)
            {
                var owner = this.Owner.ActiveControl as frmThietBiMuon;
                owner.AddToGrid(list);
            }
            Close();
        }
    }
}
