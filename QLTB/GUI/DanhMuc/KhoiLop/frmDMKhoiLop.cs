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
    public partial class frmDMKhoiLop : Form
    {
        private BindingSource source = new BindingSource();
        private string defaultSearchValue = "Value for search";
        public frmDMKhoiLop()
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
            List<KhoiLopGridDisplayModel> list = new DbKhoiLopHandler().GetAll();
            
            //
            List<string> headers = new List<string>();
            headers.Add("Cấp trường");
            headers.Add("Mã khối lớp");
            headers.Add("Tên");
            headers.Add("Ghi chú");
            //
            DataTable tb = MyConvert.ToDataTable(list);
            source.DataSource = SetUpSearch(tb, headers);
            advancedDataGridView.DataSource = source;
            SetHeaderForGrid(advancedDataGridView, headers);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDMKhoiLop_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void advancedDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((e.RowIndex > 0) && (e.ColumnIndex == 0))
            {
                if (advancedDataGridView[0, e.RowIndex - 1].Value.ToString().Equals(e.Value.ToString()))
                { e.Value = ""; e.FormattingApplied = true; }
            }
        }

        private void advancedDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            e.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
            if ((e.RowIndex >= 1) && (e.ColumnIndex >= 0))
            {

                if (advancedDataGridView[0, e.RowIndex - 1].Value.ToString().Equals(e.Value.ToString()))
                    e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
                else
                {
                    e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.Single;
                }
            }
        }
    }
}
