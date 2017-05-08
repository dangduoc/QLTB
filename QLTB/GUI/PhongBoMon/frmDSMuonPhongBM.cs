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
    public partial class frmDSMuonPhongBM : DevComponents.DotNetBar.Office2007Form
    {
        private BindingSource source = new BindingSource();
        private string defaultSearchValue = "Value for search";
        public frmDSMuonPhongBM()
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
            List<PhieuMuonPhongGridDisplayModel> list = new List<PhieuMuonPhongGridDisplayModel>();
            list.Add(new PhieuMuonPhongGridDisplayModel
            {
                PhieuMuonPhongId="PMPBM00001",
                BaiDay="Phản ứng hóa học số 1",
                MonHoc="Hóa học",
                SoTiet="3",
                GiaoVien="Đặng Minh Được",
                LopHoc="Lớp 7A1",
                NgayMuon="21/11/2010",
                TrangThai="Đang sử dụng"
            });
            List<string> headers = new List<string>();
            headers.Add("Số phiếu");
            headers.Add("Ngày mượn");
            headers.Add("Số tiết");
            headers.Add("Bài dạy");
            headers.Add("Môn học");
            headers.Add("Lớp học");
            headers.Add("Giáo viên");
            headers.Add("Trạng thái");
            //
            DataTable tb = MyConvert.ToDataTable(list);
            source.DataSource = SetUpSearch(tb, headers);
            advancedDataGridView.DataSource = source;
            SetHeaderForGrid(advancedDataGridView, headers);
            //
            List<ThietBiMuonGridDisplayModel> listTB = new List<ThietBiMuonGridDisplayModel>();
            gridDSThietBiMuon.DataSource = listTB;
            listTB.Add(new ThietBiMuonGridDisplayModel {
                ThietBiId="CSCN00001",
                SoHieu="CSCN00001.01",
                Ten="Giỏ hoa cảnh",
                DVT="Cái",
                SoLuongMuon="2",
                PhongBM="Phòng thực hành công nghệ"
            });
            listTB.Add(new ThietBiMuonGridDisplayModel
            {
                ThietBiId = "CSCN00001",
                SoHieu = "CSCN00001.02",
                Ten = "Chậu đất",
                DVT = "Cái",
                SoLuongMuon = "4",
                PhongBM = "Phòng thực hành công nghệ"
            });
            DataGridViewLinkColumn linkColEdit = new DataGridViewLinkColumn();
            linkColEdit.Text = "Thay đổi";
            linkColEdit.Name = "Edit";
            linkColEdit.LinkColor = Color.Blue;
            linkColEdit.LinkBehavior = LinkBehavior.NeverUnderline;
            linkColEdit.UseColumnTextForLinkValue = true;
            linkColEdit.HeaderText = "";
            DataGridViewLinkColumn linkColDelete = new DataGridViewLinkColumn();
            linkColDelete.Text = "Xóa bỏ";
            linkColDelete.Name = "Delete";
            linkColDelete.LinkColor = Color.Red;
            linkColDelete.LinkBehavior = LinkBehavior.NeverUnderline;
            linkColDelete.UseColumnTextForLinkValue = true;
            linkColDelete.HeaderText = "";

            gridDSThietBiMuon.Columns.Add(linkColEdit);
            gridDSThietBiMuon.Columns.Add(linkColDelete);
            //
            gridDSThietBiMuon.Columns[1].HeaderText = "Mã thiết bị";
            gridDSThietBiMuon.Columns[2].HeaderText = "Tên thiết bị";
            gridDSThietBiMuon.Columns[3].HeaderText = "Số hiệu";
            gridDSThietBiMuon.Columns[4].HeaderText = "Phòng bộ môn";
            gridDSThietBiMuon.Columns[5].HeaderText = "Số lượng mượn";
            gridDSThietBiMuon.Columns[6].HeaderText = "Đơn vị tính";
        }

        private void advancedDataGridView_SortStringChanged(object sender, EventArgs e)
        {
            source.Sort = advancedDataGridView.SortString;
        }

        private void advancedDataGridView_FilterStringChanged(object sender, EventArgs e)
        {
            source.Filter = advancedDataGridView.FilterString;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmCTPhieuMuonPhong frm = new frmCTPhieuMuonPhong();
            frm.MdiParent = MdiParent;
            frm.Show();
        }

        private void frmDSMuonPhongBM_Load(object sender, EventArgs e)
        {
            LoadForm();
        }
    }
}
