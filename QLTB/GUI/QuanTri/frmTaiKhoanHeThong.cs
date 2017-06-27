﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTB.Model;
using QLTB.Handler;
using QLTB.Utils;

namespace QLTB.GUI
{
    public partial class frmTaiKhoanHeThong : Form
    {
        private UserHandler handler = new UserHandler();
        public frmTaiKhoanHeThong()
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
            //if (ADGVDanhSach.SelectedRows[0] != null)
            //{
            //    if (e.Button == MouseButtons.Right)
            //    {
            //        contextMenuStrip.Show(ADGVDanhSach, e.Location);
            //    }
            //}
        }
        #endregion
        private void loadForm()
        {
            List<UserGridDisplayModel> list = handler.GetAll();

            //
            List<string> headers = new List<string>();
            headers.Add("Mã");
            headers.Add("Tên tài khoản");
            headers.Add("Loại tài khoản");
            headers.Add("Tên người dùng");
            headers.Add("Ghi chú");
            headers.Add("Trạng thái");
            //
            DataTable tb = MyConvert.ToDataTable(list);
            SetUpSearch(SearchDSTB, tb, headers, ADGVDanhSach);
            SetHeaderForGrid(ADGVDanhSach, headers);
            ADGVDanhSach.FilterStringChanged += advancedDataGridView_FilterStringChanged;
            ADGVDanhSach.SortStringChanged += advancedDataGridView_SortStringChanged;
            ADGVDanhSach.CellContentDoubleClick += ADGVDanhSach_CellContentDoubleClick;
            ADGVDanhSach.KeyPress += ADGVDanhSach_KeyPress;
            ADGVDanhSach.MouseClick += ADGVDanhSach_MouseClick;
        }
        private void frmTaiKhoanHeThong_Load(object sender, EventArgs e)
        {
            try
            {
                loadForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Xảy ra lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThemDSTB_Click(object sender, EventArgs e)
        {
            frmCTTaiKhoan frm = new frmCTTaiKhoan();
            frm.ShowDialog();
        }

        private void btnSuaDSTB_Click(object sender, EventArgs e)
        {
            if (ADGVDanhSach.SelectedRows.Count > 0)
            {
                var row = ADGVDanhSach.SelectedRows[0];
                int id = Convert.ToInt32(row.Cells["UserId"].Value);
                frmCTTaiKhoan frm = new frmCTTaiKhoan(id);
                frm.ShowDialog();
            }
        }

       

        private void tắtTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ADGVDanhSach.SelectedRows.Count > 0)
            {
                var row = ADGVDanhSach.SelectedRows[0];
                int id = Convert.ToInt32(row.Cells["UserId"].Value);
                var user = handler.GetUserById(id);
                user.isActived = !user.isActived;
                if (handler.Update(user) != 1)
                {
                    MessageBox.Show("Thao tác không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ADGVDanhSach_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (ADGVDanhSach.SelectedRows.Count > 0)
                {
                    var row = ADGVDanhSach.SelectedRows[0];
                    int id = Convert.ToInt32(row.Cells["UserId"].Value);
                    var user = handler.GetUserById(id);
                    if ((bool)user.isActived)
                    {
                        tắtTàiKhoảnToolStripMenuItem.Text = "Tắt tài khoản";
                        tắtTàiKhoảnToolStripMenuItem.Tag = true;
                    }
                    else
                    {
                        tắtTàiKhoảnToolStripMenuItem.Text = "Kích hoạt tài khoản";
                        tắtTàiKhoảnToolStripMenuItem.Tag = false;
                    }
                    contextMenuStrip1.Show(ADGVDanhSach, e.Location);
                }
            }
        }
    }
}
