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
using QLTB.Handler;

namespace QLTB.GUI
{
    public partial class frmDanhSachThietBi : DevComponents.DotNetBar.Office2007Form
    {
        DbThietBiHandler handler = new DbThietBiHandler();
        public frmDanhSachThietBi()
        {
            InitializeComponent();
            toolStripXoa.Click += btnXoa_Click;
            toolStripSua.Click += btnXem_Click;
            
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
            columns.ComboBox.DropDownStyle = ComboBoxStyle.DropDown;
            columns.ComboBox.FlatStyle = FlatStyle.Standard;
            columns.ComboBox.DrawMode = DrawMode.Normal;
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
        private void ADGVDanhSach_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = ADGVDanhSach.Rows[e.RowIndex].Cells["SoHieu"].Value.ToString();
            frmKhaiBaoThietBi frm = new frmKhaiBaoThietBi(id);
            frm.Text = "Chi thiết thông tin thiết bị";
            frm.MdiParent = MdiParent;
            frm.Show();
        }
        private void ADGVDanhSach_KeyPress(object sender, KeyPressEventArgs e)
        {
            var row = ADGVDanhSach.SelectedRows[0];
            if (row != null)
            {
                if (e.KeyChar == (char)13)
                {
                    var id = row.Cells["SoHieu"].Value.ToString();
                    frmKhaiBaoThietBi frm = new frmKhaiBaoThietBi(id);
                    frm.Text = "Chi thiết thông tin thiết bị";
                    frm.MdiParent = MdiParent;
                    frm.Show();
                }
            }
        }
        private void ADGVDanhSach_MouseClick(object sender, MouseEventArgs e)
        {
            var row = ADGVDanhSach.SelectedRows[0];
            
            if (row != null)
            {
                var status = row.Cells["TrangThai"].Value.ToString();
                if (e.Button == MouseButtons.Right)
                {
                    if(status.Equals("Chưa ghi tăng"))
                    {
                        toolStripGhiTang.Enabled = true;
                        toolStripGhiGiam.Enabled = false;
                    }
                    else
                    {
                        toolStripGhiTang.Enabled = false;
                        toolStripGhiGiam.Enabled = true;
                    }
                    contextMenuStrip.Show(ADGVDanhSach, e.Location);
                    
                }
            }
        }
        #endregion
        private void LoadForm()
        {
            ShowPage(1,50);
            var parent=MdiParent as Form1;
            parent.pnlLoading.Visible = false;
        }
        private void ShowPage(int page,int pageSize)
        {
            var data = handler.GetAll(page, pageSize,p=>p.TrangThai>=0);
            List<ThietBiGridDisplayModel> list = data.data;
            if (list.Count > 0)
            {
                loadData(list);
                loadTVMonHoc();
                prevBtn.Enabled = data.PreviousPage;
                prevBtn.Tag = page - 1;
                nextBtn.Enabled = data.NextPage;
                nextBtn.Tag = page+1;
                currentPage.Text = data.CurrentPage.ToString();
                lbPaging.Text = "Trang " + currentPage.Text + "/" + data.Size;
                lbTotalRecord.Text = "- Tổng số bản ghi: " + data.TotalRecord;
            }
        }
        private void pageBtnClick(object sender, EventArgs e)
        {
            var btn = sender as LinkLabel;
            int page = Convert.ToInt32(btn.Tag);
            ShowPage(page,Convert.ToInt32(pageSize.SelectedValue.ToString()));
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
            //
            DataTable tb = MyConvert.ToDataTable(list);
            SetUpSearch(SearchDSTB, tb, headers, ADGVDanhSach);
            SetHeaderForGrid(ADGVDanhSach, headers);
            ADGVDanhSach.Columns["ThietBiId"].Frozen = true;
            ADGVDanhSach.Columns["SoHieu"].Frozen = true;
            ADGVDanhSach.Columns[2].Width = 170;
            ADGVDanhSach.Columns["KhoPhong"].Width = 200;
            ADGVDanhSach.Columns["SoLuong"].Width = 120;
            ADGVDanhSach.Columns["SoLuongHong"].Width = 80;
            ADGVDanhSach.Columns["SoLuongMat"].Width = 80;
            ADGVDanhSach.Columns["Ten"].Width = 300;
            ADGVDanhSach.Columns["DonViTinh"].Width = 120;
            ADGVDanhSach.FilterStringChanged += advancedDataGridView_FilterStringChanged;
            ADGVDanhSach.SortStringChanged += advancedDataGridView_SortStringChanged;
            ADGVDanhSach.CellContentDoubleClick += ADGVDanhSach_CellContentDoubleClick;
            ADGVDanhSach.KeyPress += ADGVDanhSach_KeyPress;
            ADGVDanhSach.MouseClick += ADGVDanhSach_MouseClick;
            //
            //
        }
        private void loadTVMonHoc()
        {
            tvFilter.Tag = 1;
            tvFilter.Nodes.Clear();
            var listMH = new DbMonHocHandler().GetNames();
            TreeNode rootNode = new TreeNode();
            rootNode.Name = "0";
            rootNode.Text = "Tất cả";
            foreach (var mh in listMH)
            {
                TreeNode childNode = new TreeNode();
                childNode.Text = mh.Ten;
                childNode.Name = mh.MonHocId.ToString();
                //childNode.Tag = state.UserRoleId;
                rootNode.Nodes.Add(childNode);
            }
            tvFilter.Nodes.Add(rootNode);
            tvFilter.ExpandAll();
        }
        private void loadTVPhongHo()
        {
            tvFilter.Tag = 2;
            tvFilter.Nodes.Clear();
            var listPH = new DbPhongBMHandler().GetNames();
            TreeNode rootNode = new TreeNode();
            rootNode.Text = "Tất cả";
            foreach (var mh in listPH)
            {
                TreeNode childNode = new TreeNode();
                childNode.Text = mh.Ten;
                childNode.Name = mh.PhongHocId.ToString();
                //childNode.Tag = state.UserRoleId;
                rootNode.Nodes.Add(childNode);
            }
            tvFilter.Nodes.Add(rootNode);
        }
        private void BtnThemDSTB_Click(object sender, EventArgs e)
        {
            frmKhaiBaoThietBi frm = new frmKhaiBaoThietBi();
            frm.MdiParent = MdiParent;
            frm.Show();
        }
        private void btnXem_Click(object sender, EventArgs e)
        {
            var id = ADGVDanhSach.SelectedRows[0].Cells["SoHieu"].Value.ToString();
            frmKhaiBaoThietBi frm = new frmKhaiBaoThietBi(id);
            frm.Text = "Chi thiết thông tin thiết bị";
            frm.MdiParent = MdiParent;
            frm.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var row = ADGVDanhSach.SelectedRows[0];
            var id = row.Cells["SoHieu"].Value.ToString();
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa thiết bị này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int result = new DbThietBiHandler().Delete(id);
                if (result == 1)
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ADGVDanhSach.Rows.Remove(row);
                }
                else MessageBox.Show("Xóa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmDanhSachThietBi_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void ADGVDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var SoHieu = ADGVDanhSach.Rows[e.RowIndex].Cells["SoHieu"].Value.ToString();
            var tb = handler.GetById(SoHieu);
            //
            lbMaTB.Text = tb.ThietBiId;
            lbSoHieu.Text = tb.SoHieu;
            lbSoLuong.Text = tb.SoLuong.ToString();
            lbConDungDuoc.Text = tb.SoLuongCon.ToString();
            lbDangMuon.Text = tb.SoLuongMuon.ToString();
            lbTenTB.Text = tb.Ten;
            lbQuyCach.Text = tb.QuyCachSD;
            lbKhoiLop.Text = "";
            lbNoiDung.Text = tb.GhiChu;
            lbPhongBM.Text = ADGVDanhSach.Rows[e.RowIndex].Cells["KhoPhong"].Value.ToString();

        }

        private void btnImportDSTB_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            frmNhapKhauTB frm = new frmNhapKhauTB();
            frm.MdiParent = MdiParent;
            frm.Show();
            Cursor = Cursors.Default;
        }

        private void rdioTB_CheckedChanged(object sender, EventArgs e)
        {

            if (rdioTB.Checked == true)
            {
                loadTVMonHoc();
            }

        }

        private void tvFilter_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            ToolStripComboBox columns = SearchDSTB.Items[2] as ToolStripComboBox;
            ToolStripTextBox textSearch = SearchDSTB.Items[3] as ToolStripTextBox;


            var filterString = tvFilter.SelectedNode.Text.Trim();
            int type = Convert.ToInt32(tvFilter.Tag);
            //mon hoc
            if (type == 1)
            {
                if(filterString.Equals("Tất cả"))
                {
                    columns.ComboBox.SelectedValue = "All";
                    textSearch.Text = "";
                }
                else
                {
                    columns.ComboBox.SelectedValue = "MonHoc";
                    textSearch.Text = filterString;
                }
                
                searchChanged(SearchDSTB, ADGVDanhSach);
            }
            else if (type == 2)
            {
                source.Filter = "KhoPhong Like '" + filterString + "'";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNapDSTB_Click(object sender, EventArgs e)
        {
            ShowPage(1, 50);
        }

        private void toolStripBaoMat_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            frmPhieuBaoHong frm = new frmPhieuBaoHong();
            frm.MdiParent = MdiParent;
            frm.Show();
            Cursor = Cursors.Default;
        }
    }
}
