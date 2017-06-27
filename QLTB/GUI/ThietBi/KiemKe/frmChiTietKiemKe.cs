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
using DevComponents.DotNetBar.SuperGrid;
using DevComponents.DotNetBar.SuperGrid.Style;

namespace QLTB.GUI
{
    public partial class frmChiTietKiemKe : DevComponents.DotNetBar.Office2007Form
    {
        private int _BaseColumnCount;
        public frmChiTietKiemKe()
        {
            InitializeComponent();
        }
        private void loadForm()
        {
            //
            List<BanKiemKeGridDisplayModel> list = new List<BanKiemKeGridDisplayModel>();
           
            DataGridViewLinkColumn col = new DataGridViewLinkColumn();
            DataGridViewLinkColumn col2 = new DataGridViewLinkColumn();
            col2.HeaderText = "STT";
            col2.Width = 30;
            col2.Text = "1";
            col2.LinkColor = Color.White;
            col2.UseColumnTextForLinkValue = true;
            col.Width = 50;
            col.HeaderText = "";
            gridBanKiemKe.Columns.Add(col2);
            gridBanKiemKe.Columns.Add(col);
            gridBanKiemKe.DataSource = list;
            gridBanKiemKe.Columns[2].HeaderText = "Họ tên";
            gridBanKiemKe.Columns[3].HeaderText = "Chức vụ";
            gridBanKiemKe.Columns[4].HeaderText = "Đại diện";
            gridBanKiemKe.Columns[5].HeaderText = "Vai trò";
            gridBanKiemKe.Columns[1].DisplayIndex = 5;
            gridBanKiemKe.Refresh();
            gridBanKiemKe.Update();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void frmChiTietKiemKe_Load(object sender, EventArgs e)
        {
            loadForm();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void frmChiTietKiemKe_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
        #region Cài đặt SuperGridView
        #region Tạo column trước kiểm kê

        /// <summary>
        /// Creates and returns the 'Current Info' header.
        /// </summary>
        /// <param name="columns"></param>
        /// <returns></returns>
        private ColumnGroupHeader GetClTruocKiemKeHeader(GridColumnCollection columns)
        {
            ColumnGroupHeader cgh = new ColumnGroupHeader();

            cgh.Name = "TruocKiemKe";
            cgh.HeaderText = "Trước kiểm kê";

            cgh.MinRowHeight = 36;

            // Create the 'Sales' header and add it to the group

            //ColumnGroupHeader cshSales = GetCiSalesHeader(columns);

            //cgh.GroupHeaders.Add(cshSales);

            // We want to also include the "T1" column to the left
            // of the added sales range, so we must set the start
            // display index to include it.

            cgh.StartDisplayIndex = GetDisplayIndex(columns, "MatTruoc");
            cgh.EndDisplayIndex = GetDisplayIndex(columns, "HongTruoc");

            return (cgh);
        }
        #endregion
        #region Tạo column sau kiểm kê

        /// <summary>
        /// Creates and returns the 'Projected Info' header.
        /// </summary>
        /// <param name="columns"></param>
        /// <returns></returns>
        private ColumnGroupHeader GetClSauKiemKeHeader(GridColumnCollection columns)
        {
            ColumnGroupHeader cgh = new ColumnGroupHeader();

            cgh.Name = "SauKiemKe";
            cgh.HeaderText = "Sau kiểm kê";

            cgh.MinRowHeight = 36;

            // Set the group's start and end indicees

            cgh.StartDisplayIndex = GetDisplayIndex(columns, "MatSau");
            cgh.EndDisplayIndex = GetDisplayIndex(columns, "HongSau");

            return (cgh);
        }

        #endregion
        #region Tạo column chênh lệch

        /// <summary>
        /// Creates and returns the 'Projected Info' header.
        /// </summary>
        /// <param name="columns"></param>
        /// <returns></returns>
        private ColumnGroupHeader GetClChenhLechHeader(GridColumnCollection columns)
        {
            ColumnGroupHeader cgh = new ColumnGroupHeader();

            cgh.Name = "ChenhLech";
            cgh.HeaderText = "Chênh lệch";

            cgh.MinRowHeight = 36;

            // Set the group's start and end indicees

            cgh.StartDisplayIndex = GetDisplayIndex(columns, "ChenhLechMat");
            cgh.EndDisplayIndex = GetDisplayIndex(columns, "ChenhLechHong");

            return (cgh);
        }

        #endregion
        private int GetDisplayIndex(GridColumnCollection columns, string name)
        {
            return (columns.GetDisplayIndex(columns[name]));
        }
        private void ShowColumn(
           GridColumnCollection columns, string name, int dindex, string headerText)
        {
            GridColumn col = columns[name];

            col.Visible = true;
            col.DisplayIndex = dindex;

            if (headerText != null)
                col.HeaderText = headerText;
        }
        private void HideColumn(GridColumnCollection columns, string name)
        {
            columns[name].Visible = false;
        }
        #region InitializeGrid
        /// <summary>
        /// Initializes the default grid
        /// </summary>
        private void InitializeGrid()
        {
            GridPanel panel = superGridControl1.PrimaryGrid;
            panel.Name = "DSTB";
            panel.MinRowHeight = 20;
            BindCustomerData();
            superGridControl1.DataBindingComplete += SuperGridControl1DataBindingComplete;
        }

        #region BindCustomerData

        /// <summary>
        /// Creates and binds our data to the grid
        /// </summary>
        private void BindCustomerData()
        {
            DataTable table = new DataTable("DSTB");

            table.Columns.Add(new DataColumn("CustomerID"));
            table.Columns.Add(new DataColumn("Monday"));
            table.Columns.Add(new DataColumn("Tuesday"));
            table.Columns.Add(new DataColumn("Wednesday"));


            BindingSource src = new BindingSource();
            src.DataSource = table;
            _BaseColumnCount = table.Columns.Count;
            // Fill the newly added columns with
            // 'useful' data.
            // Bind our grid to the created dataset.

            superGridControl1.PrimaryGrid.DataSource = src;
            superGridControl1.PrimaryGrid.DataMember = "DSTB";
        }
        #region AddNewColumns

        /// <summary>
        /// Adds a set of new columns to the given table
        /// </summary>
        /// <param name="table"></param>
        /// <param name="names"></param>
        private void AddNewColumns(DataTable table, IEnumerable<string> names)
        {
            Type type = Type.GetType("System.Decimal");

            foreach (string name in names)
                table.Columns.Add(new DataColumn(name, type));
        }

        #endregion
        #endregion
        #endregion
        #region SuperGridControl1DataBindingComplete
        /// <summary>
        /// This routine is called after the data bind operation has
        /// been completed. This call-out lets you customize the display
        /// or visibility of the data however the application needs.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SuperGridControl1DataBindingComplete(
            object sender, GridDataBindingCompleteEventArgs e)
        {
            GridPanel panel = e.GridPanel;
            GridColumnCollection columns = panel.Columns;

            // Set a few default panel properties

            panel.DefaultRowHeight = 40;
            panel.UseAlternateRowStyle = true;

            // Set initial column defaults

            foreach (GridColumn col in columns)
            {
                col.CellStyles.Default.AllowWrap = Tbool.True;

                col.ColumnSortMode = ColumnSortMode.Multiple;
                col.EnableHeaderMarkup = true;
            }

            SetColumnTw(columns, "CustomerID", "ID", 50);
            SetColumnTw(columns, "Monday", "Thứ 2", 100);
            SetColumnTw(columns, "Tuesday", "Thứ 3", 100);
            SetColumnTw(columns, "Wednesday", "Thứ 4", 100);

            //SetupCurrencyColumns(columns, new string[] { "MTD", "YTD", "LTD", "T1", "T2", "T3" });
            // SetupPctColumns(columns, new string[] { "P1", "P2", "P3", "P4" });

            ResetLayout();
        }
        #region SetColumnTw

        /// <summary>
        /// Sets the header text and width for the given column.
        /// </summary>
        /// <param name="columns"></param>
        /// <param name="name"></param>
        /// <param name="text"></param>
        /// <param name="width"></param>
        private void SetColumnTw(GridColumnCollection columns,
            string name, string text, int width)
        {
            GridColumn col = columns[name];

            if (col != null)
            {
                col.HeaderText = text;
                col.Width = width;
            }
        }

        #endregion
        #region SetupCurrencyColumns

        /// <summary>
        /// Sets up the given columns to render/edit
        /// as a center-aligned Currency column.
        /// </summary>
        /// <param name="columns"></param>
        /// <param name="names"></param>
        private void SetupCurrencyColumns(GridColumnCollection columns, string[] names)
        {
            foreach (string name in names)
            {
                GridColumn column = columns[name];

                column.EditorType = typeof(MyCurrencyEditControl);

                column.CellStyles.Default.Alignment = Alignment.MiddleCenter;
            }
        }

        #region MyCurrencyEditControl

        /// <summary>
        /// Currency DoubleInput edit control
        /// </summary>
        public class MyCurrencyEditControl : GridDoubleInputEditControl
        {
            public MyCurrencyEditControl()
            {
                DisplayFormat = "C";
            }
        }

        #endregion

        #endregion
        #region SetupPctColumns

        /// <summary>
        /// Sets up the given column to render/edit
        /// as a center-aligned "percent" column.
        /// </summary>
        /// <param name="columns"></param>
        /// <param name="names"></param>
        private void SetupPctColumns(GridColumnCollection columns, string[] names)
        {
            foreach (string name in names)
            {
                GridColumn column = columns[name];

                column.EditorType = typeof(MyPercentEditControl);

                column.CellStyles.Default.Alignment = Alignment.MiddleCenter;
            }
        }

        #region MyPercentEditControl

        /// <summary>
        /// Percent DoubleInput edit control
        /// </summary>
        public class MyPercentEditControl : GridDoubleInputEditControl
        {
            public MyPercentEditControl()
            {
                DisplayFormat = "P";
            }
        }

        #endregion

        #endregion
        #endregion
        #region ResetLayout

        /// <summary>
        /// Reset the grid layout back to its default.
        /// </summary>
        private void ResetLayout()
        {
            GridPanel panel = superGridControl1.PrimaryGrid;
            GridColumnCollection columns = panel.Columns;

            for (int i = 0; i < columns.Count; i++)
            {
                GridColumn col = columns[i];

                col.Visible = (i < _BaseColumnCount);
                col.DisplayIndex = -1;

                col.HeaderStyles.Default.Image = null;
                col.HeaderStyles.Default.Background = null;
                col.HeaderStyles.MouseOver.Background = null;
                col.CellStyles.Default.Background = null;
            }

            // columns["Country"].HeaderText = null;

            panel.ColumnHeader.GroupHeaders.Clear();
            panel.ClearAll();
        }

        #endregion
        #endregion
    }
}
