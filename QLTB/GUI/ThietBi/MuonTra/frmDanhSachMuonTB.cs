using DevComponents.DotNetBar.Schedule;
using DevComponents.Schedule.Model;
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
    public partial class frmDanhSachMuonTB : DevComponents.DotNetBar.Office2007Form
    {
        private DbPhieuMuonTBHandler handler = new DbPhieuMuonTBHandler();
        public frmDanhSachMuonTB()
        {
            InitializeComponent();
            calendarView1.CalendarModel = new CalendarModel();
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
            List<PhieuMuonTBGridDisplayModel> list = data.data;
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
        private void loadData(List<PhieuMuonTBGridDisplayModel> list)
        {
            List<string> headers = new List<string>();
            headers.Add("Số phiếu");
            headers.Add("Ngày mượn");
            headers.Add("Ngày trả");
            headers.Add("Bài dạy");
            headers.Add("Lớp học");
            headers.Add("Giáo viên");
            headers.Add("Trạng thái");
            //




            //
            DataTable tb = MyConvert.ToDataTable(list);
            SetUpSearch(SearchDSTB, tb, headers, ADGVDanhSach);
            SetHeaderForGrid(ADGVDanhSach, headers);
            ADGVDanhSach.FilterStringChanged += advancedDataGridView_FilterStringChanged;
            ADGVDanhSach.SortStringChanged += advancedDataGridView_SortStringChanged;
            ADGVDanhSach.CellContentDoubleClick += advancedDataGridView_CellContentDoubleClick;
            ADGVDanhSach.KeyPress += advancedDataGridView_KeyPress;
            ADGVDanhSach.MouseClick += ADGVDanhSach_MouseClick;

            //
        }
        private void LoadForm()
        {

            ShowPage(1, 50);
            //
            List<ThietBiMuonGridDisplayModel> listTB = new List<ThietBiMuonGridDisplayModel>();
            List<string> headers = new List<string>();
            headers.Add("Mã thiết bị");
            headers.Add("Tên thiết bị");
            headers.Add("Số hiệu");
            headers.Add("Phòng bộ môn");
            headers.Add("Số lượng");
            headers.Add("Đơn vị tính");
            BindingSource source = new BindingSource();
            source.DataSource = MyConvert.ToDataTable<ThietBiMuonGridDisplayModel>(listTB);
            ADGVDSTB.DataSource = source;
            SetHeaderForGrid(ADGVDSTB, headers);
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            var row = ADGVDanhSach.SelectedRows[0];
            var id = row.Cells["PhieuMuonTBId"].Value.ToString();
            frmThietBiMuon frm = new frmThietBiMuon(id);
            frm.MdiParent = MdiParent;
            frm.Show();
            Cursor = Cursors.Default;
        }

        private void frmDanhSachMuonTB_Load(object sender, EventArgs e)
        {
            LoadForm();
            var parent = MdiParent as Form1;
            parent.pnlLoading.Visible = false;
            dateTimeInput1.Value = DateTime.Today;
        }
        private void advancedDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var Id = ADGVDanhSach.Rows[e.RowIndex].Cells["PhieuMuonTBId"].Value.ToString();
            frmThietBiMuon frm = new frmThietBiMuon(Id);
            frm.MdiParent = MdiParent;
            frm.Show();
        }
        private void advancedDataGridView_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                var row = ADGVDanhSach.SelectedRows[0];
                if (row != null)
                {
                    var Id = row.Cells["PhieuMuonTBId"].Value.ToString();
                    frmThietBiMuon frm = new frmThietBiMuon(Id);
                    frm.MdiParent = MdiParent;
                    frm.Show();
                }
            }
        }

        private void btnGhiTra_Click(object sender, EventArgs e)
        {
            var row = ADGVDanhSach.SelectedRows[0];
            if (row != null)
            {
                var Id = row.Cells["PhieuMuonTBId"].Value.ToString();
                frmGhiNhanTraTB frm = new frmGhiNhanTraTB(Id);
                var owner = MdiParent as Form1;
                owner.OpenFrmChild(frm);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var owner = MdiParent as Form1;
            frmThietBiMuon frm = new frmThietBiMuon();
            owner.OpenFrmChild(frm);   
        }

        private void ADGVDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var id = ADGVDanhSach.Rows[e.RowIndex].Cells[0].Value.ToString();

                var lst = handler.GetById(id).ThietBis;
                if (lst != null)
                {
                    BindingSource source = new BindingSource();
                    source.DataSource = MyConvert.ToDataTable<ThietBiMuonGridDisplayModel>(lst);
                    ADGVDSTB.DataSource = source;
                }

            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void btnBaoHong_Click(object sender, EventArgs e)
        {
            if (ADGVDanhSach.SelectedRows[0] != null)
            {
                var id = ADGVDanhSach.SelectedRows[0].Cells[0].Value.ToString();

                var ds = handler.GetById(id).ThietBis;

                List<BaseThietBiGridDisplayModel> lst = new List<BaseThietBiGridDisplayModel>();
                foreach (var item in ds)
                {
                    lst.Add(new BaseThietBiGridDisplayModel
                    {
                        ThietBiId = item.ThietBiId,
                        Ten = item.Ten,
                        SoHieu = item.SoHieu,
                        DonViTinh = item.DonViTinh,
                        PhongHoc = item.PhongHoc
                    });
                }
                frmDialogTBBaoHong frm = new frmDialogTBBaoHong(lst);
                frm.ShowDialog(this);
            }
        }

        private void btnNapDSTB_Click(object sender, EventArgs e)
        {
            ShowPage(1, 50);
        }

        private void rdioWeek_CheckedChanged(object sender, EventArgs e)
        {
            if (rdioWeek.Checked)
            {
                if (pnlCalendar.Visible==false)
                {
                    pnlCalendar.Visible = true;
                    pnlDS.Visible = false;
                    pnlCalendar.Dock = DockStyle.Fill;
                }
               
                calendarView1.SelectedView = eCalendarView.Week;
            }
        }

        private void rdioMonth_CheckedChanged(object sender, EventArgs e)
        {
            if (rdioMonth.Checked)
            {
                if (pnlCalendar.Visible==false)
                {
                    pnlCalendar.Visible = true;
                    pnlDS.Visible = false;
                    pnlCalendar.Dock = DockStyle.Fill;
                }
                calendarView1.SelectedView = eCalendarView.Month;
            }
        }

        private void rdioDanhSach_CheckedChanged(object sender, EventArgs e)
        {
            if (rdioDanhSach.Checked)
            {
                pnlDS.Visible = true;
                pnlCalendar.Visible = false;
                pnlDS.Dock = DockStyle.Fill;
            }
        }

        private void dateTimeInput1_ValueChanged(object sender, EventArgs e)
        {
            calendarView1.ShowDate(dateTimeInput1.Value);
        }

        private void calendarView1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void calendarView1_ItemDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}
