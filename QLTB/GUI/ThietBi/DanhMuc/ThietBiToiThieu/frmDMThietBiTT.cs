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
    public partial class frmDMThietBiTT : DevComponents.DotNetBar.Office2007Form
    {
        private BindingSource source = new BindingSource();
        private string defaultSearchValue = "Value for search";
        public frmDMThietBiTT()
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
        private void LoadForm()
        {
            //Clone
            List<ThietBiTTGridDisplayModel> list = new List<ThietBiTTGridDisplayModel>();
            list.Add(new ThietBiTTGridDisplayModel
            {
                ThietBiId = "CSCN1001",
                Ten = "Quy trình sản xuất vải sợi thiên nhiên",
                DonViTinh = "Cái",
                DungChoLop = "6,7,8,9",
                LoaiThietBi = "Tranh ảnh",
                MonHoc = "Công nghệ",
                DauMuc = "Máy in",
                SoLuong = "10",
                MoTa = "Kích th¬ước (790x540)mm dung sai 10mm, in offset 4 màu trên giấy couché có định lượng 200g/m2,  cán láng OPP mờ."
            });
            list.Add(new ThietBiTTGridDisplayModel
            {
                ThietBiId = "CSCN1002",
                Ten = "Quy trình sản xuất vải sợi hoá học",
                DonViTinh = "Cái",
                DungChoLop = "6,7,8,9",
                LoaiThietBi = "Tranh ảnh",
                MonHoc = "Công nghệ",
                DauMuc = "Máy in",
                SoLuong = "12",
                MoTa = "Kích th¬ước (790x540)mm dung sai 10mm, in offset 4 màu trên giấy couché có định lượng 200g/m2,  cán láng OPP mờ."
            });
            list.Add(new ThietBiTTGridDisplayModel
            {
                ThietBiId = "CSHH1001",
                Ten = "Ảnh hưởng của nhiệt độ đến độ tan của chất rắn và chất khí",
                DonViTinh = "Cái",
                DungChoLop = "6,7,8,9",
                LoaiThietBi = "Tranh ảnh",
                MonHoc = "Hóa học",
                DauMuc = "Máy in",
                SoLuong = "4",
                MoTa = "Kích th¬ước (790x540)mm dung sai 10mm, in offset 4 màu trên giấy couché có định lượng 200g/m2,  cán láng OPP mờ."
            });
            //
            List<string> headers = new List<string>();
            headers.Add("Mã thiết bị");
            headers.Add("Tên thiết bị");
            headers.Add("Đơn vị tính");
            headers.Add("Dùng cho lớp");
            headers.Add("Loại thiết bị");
            headers.Add("Môn học");
            headers.Add("Đầu mục");
            headers.Add("Số lượng");
            headers.Add("Mô tả");

            //
            DataTable tb = MyConvert.ToDataTable(list);
            source.DataSource = SetUpSearch(tb, headers);
            advancedDataGridView.DataSource = source;
            SetHeaderForGrid(advancedDataGridView, headers);
        }

        private void frmDMThietBiTT_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void advancedDataGridView_FilterStringChanged(object sender, EventArgs e)
        {
            source.Filter = advancedDataGridView.FilterString;
        }

        private void advancedDataGridView_SortStringChanged(object sender, EventArgs e)
        {
            source.Sort = advancedDataGridView.SortString;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
