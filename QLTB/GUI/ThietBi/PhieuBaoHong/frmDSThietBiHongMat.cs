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
using QLTB.Utils;

namespace QLTB.GUI
{
    public partial class frmDSThietBiHongMat : Form
    {
        private BindingSource source = new BindingSource();
        private string defaultSearchValue = "Value for search";
        public frmDSThietBiHongMat()
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
            if (!textSearch.Equals(defaultSearchValue))
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
        private void loadForm()
        {
            List<PhieuBaoHongGridDisplayModel> list = new List<PhieuBaoHongGridDisplayModel>();
            list.Add(new PhieuBaoHongGridDisplayModel
            {
                PhieuBaoHongId="PBHTB00001",
                NguoiLamHong="Đặng Minh Được",
                NgayLap="21/11/2010",
                GhiChu="Hỏng rất nặng"
            });
            list.Add(new PhieuBaoHongGridDisplayModel
            {
                PhieuBaoHongId = "PBHTB00002",
                NguoiLamHong = "Đặng Ngọc Bích",
                NgayLap = "21/11/2010",
                GhiChu = ""
            });
            list.Add(new PhieuBaoHongGridDisplayModel
            {
                PhieuBaoHongId = "PBHTB00003",
                NguoiLamHong = "Nguyễn Văn Phú",
                NgayLap = "21/11/2010",
                GhiChu = "Hỏng rất nặng"
            });
            list.Add(new PhieuBaoHongGridDisplayModel
            {
                PhieuBaoHongId = "PBHTB00004",
                NguoiLamHong = "Phạm Ngọc Phi",
                NgayLap = "21/11/2010",
                GhiChu = ""
            });
            List<string> headers = new List<string>();
            headers.Add("Số phiếu");
            headers.Add("Ngày lập");
            headers.Add("Người làm hỏng/mất");
            headers.Add("Ghi chú");
            DataTable tb = MyConvert.ToDataTable(list);
            source.DataSource = SetUpSearch(tb, headers);
            advancedDataGridView.DataSource = source;
            SetHeaderForGrid(advancedDataGridView, headers);
            advancedDataGridView.Columns[0].Width = 100;
            advancedDataGridView.Columns[1].Width = 100;
            advancedDataGridView.Columns[2].Width = 150;
            advancedDataGridView.SortStringChanged += AdvancedDataGridView_SortStringChanged;
            advancedDataGridView.FilterStringChanged += AdvancedDataGridView_FilterStringChanged;
        }

        private void AdvancedDataGridView_FilterStringChanged(object sender, EventArgs e)
        {
            source.Filter = advancedDataGridView.FilterString;
        }

        private void AdvancedDataGridView_SortStringChanged(object sender, EventArgs e)
        {
            source.Sort = advancedDataGridView.SortString;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmPhieuBaoHong frm = new frmPhieuBaoHong();
            frm.MdiParent = MdiParent;
            frm.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDSThietBiHongMat_Load(object sender, EventArgs e)
        {
            loadForm();
        }
    }
}
