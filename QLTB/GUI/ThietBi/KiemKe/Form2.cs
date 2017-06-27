using DevComponents.DotNetBar.SuperGrid;
using DevComponents.DotNetBar.SuperGrid.Style;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QLTB.Model;
using QLTB.Handler;
using QLTB.Utils;

namespace QLTB.GUI
{
    public partial class Form2 : Form
    {
        #region Private variables

        private DataSet _DataSet;
        private Random _Rand = new Random();

        private int _BaseColumnCount;
        private int _HeaderCount;
        private int _StartColIndex;
        private int _EndColIndex;

        private GridColumn _HitColumn;
        private ColumnGroupHeader _HitGroupHeader;
        private List<ColumnGroupHeader> _SelectedGroupHeaders;

        private Point[] _ChartData1;
        private Point[] _ChartData2;

        #endregion
        public Form2()
        {
            InitializeComponent();
            InitializeGrid();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            GridPanel panel = superGridControl1.PrimaryGrid;
            GridColumnCollection columns = panel.Columns;
            //columns["CompanyName"].HeaderStyles.Default.Image = imageList3.Images["factory"];
            //columns["CompanyName"].HeaderStyles.Default.ImageAlignment = Alignment.BottomCenter;
            //columns["CompanyName"].HeaderStyles.Default.ImagePadding = new DevComponents.DotNetBar.SuperGrid.Style.Padding(0, 0, 0, 15);

            // Create and add the subordinate headers

            panel.ColumnHeader.GroupHeaders.Add(GetClChenhLechHeader(columns));
            panel.ColumnHeader.GroupHeaders.Add(GetClSauHeader(columns));
            panel.ColumnHeader.GroupHeaders.Add(GetClTruocHeader(columns));
        }
        #region GetClCurrentInfoHeader
        private ColumnGroupHeader GetClTruocHeader(GridColumnCollection columns)
        {
            ColumnGroupHeader cgh = new ColumnGroupHeader();

            cgh.Name = "TruocKiemKe";
            cgh.HeaderText = "Trước kiểm kê";
            cgh.MinRowHeight = 36;
            cgh.StartDisplayIndex = GetDisplayIndex(columns, "MatTruoc");
            cgh.EndDisplayIndex = GetDisplayIndex(columns, "HongTruoc");

            return (cgh);
        }
        private ColumnGroupHeader GetClSauHeader(GridColumnCollection columns)
        {
            ColumnGroupHeader cgh = new ColumnGroupHeader();

            cgh.Name = "SauKiemKe";
            cgh.HeaderText = "Sau kiểm kê";
            cgh.MinRowHeight = 36;
            cgh.StartDisplayIndex = GetDisplayIndex(columns, "MatSau");
            cgh.EndDisplayIndex = GetDisplayIndex(columns, "ConDungDuoc");

            return (cgh);
        }
        private ColumnGroupHeader GetClChenhLechHeader(GridColumnCollection columns)
        {
            ColumnGroupHeader cgh = new ColumnGroupHeader();

            cgh.Name = "ChenhLech";
            cgh.HeaderText = "Chênh lệch";
            cgh.MinRowHeight = 36;
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

            panel.Name = "Customers";
            panel.MinRowHeight = 20;

            // Bind to our customer data and hook a few SuperGrid events.

            BindCustomerData();

            //superGridControl1.ColumnHeaderClick += ColumnHeaderClick;
            //superGridControl1.ColumnGroupHeaderClick += GroupHeaderClick;

            //superGridControl1.PostRenderColumnGroupHeader += SuperGridControl1PostRenderColumnGroupHeader;
            //superGridControl1.ColumnGroupHeaderResized += SuperGridControl1ColumnGroupHeaderResized;

            //superGridControl1.ColumnGroupHeaderMarkupLinkClick += SuperGridControl1ColumnGroupHeaderMarkupLinkClick;
            //superGridControl1.ColumnHeaderMarkupLinkClick += SuperGridControl1ColumnHeaderMarkupLinkClick;

            superGridControl1.DataBindingComplete += SuperGridControl1DataBindingComplete;
        }

        #region BindCustomerData

        /// <summary>
        /// Creates and binds our data to the grid
        /// </summary>
        private void BindCustomerData()
        {
            DataTable table = new DataTable();
            List<ThietBiKKGridDisplayModel> lst = new List<ThietBiKKGridDisplayModel>();
            table= MyConvert.ToDataTable(lst);


            BindingSource src = new BindingSource();
            src.DataSource = table;
            _BaseColumnCount = table.Columns.Count;
            // Fill the newly added columns with
            // 'useful' data.
            // Bind our grid to the created dataset.
            
            superGridControl1.PrimaryGrid.DataSource = src;
            superGridControl1.PrimaryGrid.DataMember = "Customers";
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

            SetColumnTw(columns, "Ten", "Tên", 200);
            SetColumnTw(columns, "SoHieu", "Số hiệu", 100);
            SetColumnTw(columns, "PhongHoc", "Kho/ Phòng bộ môn", 120);
            SetColumnTw(columns, "SoLuong", "Số lượng", 100);
            SetColumnTw(columns, "DonViTinh", "Đơn vị tính", 100);
            SetColumnTw(columns, "MatTruoc", "Mất", 100);
            SetColumnTw(columns, "HongTruoc", "Số lượng", 100);
            SetColumnTw(columns, "MatSau", "Số lượng", 100);
            SetColumnTw(columns, "HongSau", "Số lượng", 100);
            SetColumnTw(columns, "ConDungDuoc", "Số lượng", 100);
            SetColumnTw(columns, "ChenhLechMat", "Số lượng", 100);
            SetColumnTw(columns, "ChenhLechHong", "Số lượng", 100);
            SetColumnTw(columns, "GhiChu", "Ghi chú", 200);
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
    }
}
