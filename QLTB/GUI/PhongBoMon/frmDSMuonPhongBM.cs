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
       
        public frmDSMuonPhongBM()
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
        private void ADGVDanhSach_MouseClick(object sender, MouseEventArgs e)
        {
            //if (ADGVDanhSach.SelectedRows[0] != null)
            //{
            //    if (e.Button == MouseButtons.Right)
            //    {
            //        contextMenuStrip.Show(ADGVDanhSach, e.Location);
            //    }
            //}
        }
        #endregion
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
            SetUpSearch(SearchDSTB, tb, headers, ADGVDanhSach);
            SetHeaderForGrid(ADGVDanhSach, headers);
            ADGVDanhSach.FilterStringChanged += advancedDataGridView_FilterStringChanged;
            ADGVDanhSach.SortStringChanged += advancedDataGridView_SortStringChanged;
            //ADGVDanhSach.CellContentDoubleClick += advancedDataGridView_CellContentDoubleClick;
            //ADGVDanhSach.KeyPress += advancedDataGridView_KeyPress;
            ADGVDanhSach.MouseClick += ADGVDanhSach_MouseClick;
            ADGVDanhSach.CellClick += ADGVDanhSach_CellClick;
            //

            //
           
        }

        private void ADGVDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            List<ThietBiMuonGridDisplayModel> listTB = new List<ThietBiMuonGridDisplayModel>();
            BindingSource source = new BindingSource();
            source.DataSource = MyConvert.ToDataTable<ThietBiMuonGridDisplayModel>(listTB);
            ADGVDSTB.DataSource = source;
            listTB.Add(new ThietBiMuonGridDisplayModel
            {
                ThietBiId = "CSCN00001",
                SoHieu = "CSCN00001.01",
                Ten = "Giỏ hoa cảnh",
                DonViTinh = "Cái",
                SoLuongMuon = "2",
                PhongHoc = "Phòng thực hành công nghệ"
            });
            listTB.Add(new ThietBiMuonGridDisplayModel
            {
                ThietBiId = "CSCN00001",
                SoHieu = "CSCN00001.02",
                Ten = "Chậu đất",
                DonViTinh = "Cái",
                SoLuongMuon = "4",
                PhongHoc = "Phòng thực hành công nghệ"
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

            ADGVDSTB.Columns.Add(linkColEdit);
            ADGVDSTB.Columns.Add(linkColDelete);
            //
            ADGVDSTB.Columns[1].HeaderText = "Mã thiết bị";
            ADGVDSTB.Columns[2].HeaderText = "Tên thiết bị";
            ADGVDSTB.Columns[3].HeaderText = "Số hiệu";
            ADGVDSTB.Columns[4].HeaderText = "Phòng bộ môn";
            ADGVDSTB.Columns[5].HeaderText = "Số lượng mượn";
            ADGVDSTB.Columns[6].HeaderText = "Đơn vị tính";
        }

        private void frmDSMuonPhongBM_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmCTPhieuMuonPhong frm = new frmCTPhieuMuonPhong();
            frm.MdiParent = MdiParent;
            frm.Show();
        }

        private void btnBaoHong_Click(object sender, EventArgs e)
        {
            frmPhieuBaoHong frm = new frmPhieuBaoHong();
            frm.MdiParent = MdiParent;
            frm.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
