namespace QLTB.GUI
{
    partial class frmDSMuonPhongBM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDSMuonPhongBM));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rbChucNang = new DevComponents.DotNetBar.RibbonBar();
            this.btnXem = new DevComponents.DotNetBar.ButtonItem();
            this.btnThem = new DevComponents.DotNetBar.ButtonItem();
            this.btnSua = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem2 = new DevComponents.DotNetBar.ButtonItem();
            this.btnXoa = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem3 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem4 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem5 = new DevComponents.DotNetBar.ButtonItem();
            this.btnImportTuExcel = new DevComponents.DotNetBar.ButtonItem();
            this.btnExportFileExcel = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem6 = new DevComponents.DotNetBar.ButtonItem();
            this.btnThoat = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.advancedDataGridView = new ADGV.AdvancedDataGridView();
            this.searchToolBar = new ADGV.SearchToolBar();
            this.expandablePanel1 = new DevComponents.DotNetBar.ExpandablePanel();
            this.gridDSThietBiMuon = new ADGV.AdvancedDataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView)).BeginInit();
            this.expandablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDSThietBiMuon)).BeginInit();
            this.SuspendLayout();
            // 
            // rbChucNang
            // 
            this.rbChucNang.AutoOverflowEnabled = true;
            this.rbChucNang.BackColor = System.Drawing.Color.Transparent;
            this.rbChucNang.BackgroundHoverEnabled = false;
            // 
            // 
            // 
            this.rbChucNang.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rbChucNang.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rbChucNang.ContainerControlProcessDialogKey = true;
            this.rbChucNang.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbChucNang.DragDropSupport = true;
            this.rbChucNang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
            this.rbChucNang.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnXem,
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.buttonItem3,
            this.buttonItem4,
            this.buttonItem5,
            this.btnImportTuExcel,
            this.btnExportFileExcel,
            this.buttonItem6,
            this.btnThoat});
            this.rbChucNang.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.rbChucNang.Location = new System.Drawing.Point(0, 0);
            this.rbChucNang.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.rbChucNang.Name = "rbChucNang";
            this.rbChucNang.ShowShortcutKeysInToolTips = true;
            this.rbChucNang.Size = new System.Drawing.Size(884, 92);
            this.rbChucNang.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.rbChucNang.TabIndex = 14;
            // 
            // 
            // 
            this.rbChucNang.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rbChucNang.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnXem
            // 
            this.btnXem.BeginGroup = true;
            this.btnXem.Image = global::QLTB.Properties.Resources.xem;
            this.btnXem.ImagePaddingHorizontal = 10;
            this.btnXem.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnXem.Name = "btnXem";
            this.btnXem.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F3);
            this.btnXem.ShowSubItems = false;
            this.btnXem.Text = "Xem";
            this.btnXem.Tooltip = "Xem thông tin chi tiết";
            // 
            // btnThem
            // 
            this.btnThem.BeginGroup = true;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnThem.Name = "btnThem";
            this.btnThem.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlN);
            this.btnThem.Text = "Thêm";
            this.btnThem.Tooltip = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnSua.Name = "btnSua";
            this.btnSua.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F2);
            this.btnSua.ShowSubItems = false;
            this.btnSua.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem2});
            this.btnSua.Text = "Sửa";
            this.btnSua.Tooltip = "Sửa thông tin";
            // 
            // buttonItem2
            // 
            this.buttonItem2.BeginGroup = true;
            this.buttonItem2.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem2.Image")));
            this.buttonItem2.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem2.Name = "buttonItem2";
            this.buttonItem2.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F2);
            this.buttonItem2.Text = "Sửa";
            this.buttonItem2.Tooltip = "Sửa thông tin";
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlD);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Tooltip = "Xóa thiết bị";
            // 
            // buttonItem3
            // 
            this.buttonItem3.BeginGroup = true;
            this.buttonItem3.Image = global::QLTB.Properties.Resources.cancel2;
            this.buttonItem3.ImagePaddingHorizontal = 25;
            this.buttonItem3.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem3.Name = "buttonItem3";
            this.buttonItem3.SubItemsExpandWidth = 14;
            this.buttonItem3.Text = "Ghi mượn";
            // 
            // buttonItem4
            // 
            this.buttonItem4.Image = global::QLTB.Properties.Resources.DuyetGiaoDich;
            this.buttonItem4.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem4.Name = "buttonItem4";
            this.buttonItem4.SubItemsExpandWidth = 14;
            this.buttonItem4.Text = "Ghi trả";
            // 
            // buttonItem5
            // 
            this.buttonItem5.BeginGroup = true;
            this.buttonItem5.Image = global::QLTB.Properties.Resources.properties_f2;
            this.buttonItem5.ImagePaddingHorizontal = 30;
            this.buttonItem5.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem5.Name = "buttonItem5";
            this.buttonItem5.SubItemsExpandWidth = 14;
            this.buttonItem5.Text = "Báo hỏng/mất";
            // 
            // btnImportTuExcel
            // 
            this.btnImportTuExcel.BeginGroup = true;
            this.btnImportTuExcel.Image = global::QLTB.Properties.Resources.Expand;
            this.btnImportTuExcel.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnImportTuExcel.Name = "btnImportTuExcel";
            this.btnImportTuExcel.RibbonWordWrap = false;
            this.btnImportTuExcel.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F6);
            this.btnImportTuExcel.Text = "Import từ file Excel";
            this.btnImportTuExcel.Tooltip = "Nhập dữ liệu từ file excel";
            // 
            // btnExportFileExcel
            // 
            this.btnExportFileExcel.Image = global::QLTB.Properties.Resources.Collap;
            this.btnExportFileExcel.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnExportFileExcel.Name = "btnExportFileExcel";
            this.btnExportFileExcel.RibbonWordWrap = false;
            this.btnExportFileExcel.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F7);
            this.btnExportFileExcel.Text = "Export ra file Excel";
            this.btnExportFileExcel.Tooltip = "Xuất dữ liệu ra file excel";
            // 
            // buttonItem6
            // 
            this.buttonItem6.BeginGroup = true;
            this.buttonItem6.Image = global::QLTB.Properties.Resources.icon_pagesetup;
            this.buttonItem6.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem6.Name = "buttonItem6";
            this.buttonItem6.SubItemsExpandWidth = 14;
            this.buttonItem6.Text = "In";
            // 
            // btnThoat
            // 
            this.btnThoat.BeginGroup = true;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlF4);
            this.btnThoat.ShowSubItems = false;
            this.btnThoat.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem1});
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Tooltip = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // buttonItem1
            // 
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.Text = "buttonItem1";
            // 
            // advancedDataGridView
            // 
            this.advancedDataGridView.AllowUserToAddRows = false;
            this.advancedDataGridView.AllowUserToDeleteRows = false;
            this.advancedDataGridView.AutoGenerateContextFilters = true;
            this.advancedDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.advancedDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.advancedDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.advancedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advancedDataGridView.DateWithTime = false;
            this.advancedDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.advancedDataGridView.Location = new System.Drawing.Point(0, 123);
            this.advancedDataGridView.Name = "advancedDataGridView";
            this.advancedDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.advancedDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.advancedDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.advancedDataGridView.Size = new System.Drawing.Size(884, 67);
            this.advancedDataGridView.TabIndex = 27;
            this.advancedDataGridView.TimeFilter = false;
            this.advancedDataGridView.SortStringChanged += new System.EventHandler(this.advancedDataGridView_SortStringChanged);
            this.advancedDataGridView.FilterStringChanged += new System.EventHandler(this.advancedDataGridView_FilterStringChanged);
            // 
            // searchToolBar
            // 
            this.searchToolBar.AllowMerge = false;
            this.searchToolBar.Font = new System.Drawing.Font("Arial", 9F);
            this.searchToolBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.searchToolBar.Location = new System.Drawing.Point(0, 92);
            this.searchToolBar.MaximumSize = new System.Drawing.Size(0, 31);
            this.searchToolBar.MinimumSize = new System.Drawing.Size(0, 31);
            this.searchToolBar.Name = "searchToolBar";
            this.searchToolBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.searchToolBar.Size = new System.Drawing.Size(884, 31);
            this.searchToolBar.TabIndex = 28;
            this.searchToolBar.Text = "searchToolBar1";
            // 
            // expandablePanel1
            // 
            this.expandablePanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.expandablePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.expandablePanel1.Controls.Add(this.gridDSThietBiMuon);
            this.expandablePanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.expandablePanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.expandablePanel1.HideControlsWhenCollapsed = true;
            this.expandablePanel1.Location = new System.Drawing.Point(0, 229);
            this.expandablePanel1.Name = "expandablePanel1";
            this.expandablePanel1.Size = new System.Drawing.Size(884, 221);
            this.expandablePanel1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expandablePanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.expandablePanel1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.expandablePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandablePanel1.Style.GradientAngle = 90;
            this.expandablePanel1.TabIndex = 22;
            this.expandablePanel1.TitleHeight = 30;
            this.expandablePanel1.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel1.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expandablePanel1.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.expandablePanel1.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandablePanel1.TitleStyle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expandablePanel1.TitleStyle.ForeColor.Color = System.Drawing.Color.Black;
            this.expandablePanel1.TitleStyle.GradientAngle = 90;
            this.expandablePanel1.TitleStyle.MarginLeft = 5;
            this.expandablePanel1.TitleText = "Danh sách thiết bị cho mượn";
            // 
            // gridDSThietBiMuon
            // 
            this.gridDSThietBiMuon.AllowUserToAddRows = false;
            this.gridDSThietBiMuon.AllowUserToDeleteRows = false;
            this.gridDSThietBiMuon.AutoGenerateContextFilters = true;
            this.gridDSThietBiMuon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridDSThietBiMuon.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDSThietBiMuon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridDSThietBiMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDSThietBiMuon.DateWithTime = false;
            this.gridDSThietBiMuon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDSThietBiMuon.Location = new System.Drawing.Point(0, 30);
            this.gridDSThietBiMuon.Name = "gridDSThietBiMuon";
            this.gridDSThietBiMuon.ReadOnly = true;
            this.gridDSThietBiMuon.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDSThietBiMuon.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridDSThietBiMuon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDSThietBiMuon.Size = new System.Drawing.Size(884, 191);
            this.gridDSThietBiMuon.TabIndex = 29;
            this.gridDSThietBiMuon.TimeFilter = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.Location = new System.Drawing.Point(0, 190);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(884, 39);
            this.statusStrip1.TabIndex = 26;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // frmDSMuonPhongBM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 450);
            this.Controls.Add(this.advancedDataGridView);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.searchToolBar);
            this.Controls.Add(this.expandablePanel1);
            this.Controls.Add(this.rbChucNang);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmDSMuonPhongBM";
            this.Text = "Danh sách phiếu mượn phòng học bộ môn";
            this.Load += new System.EventHandler(this.frmDSMuonPhongBM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView)).EndInit();
            this.expandablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDSThietBiMuon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.RibbonBar rbChucNang;
        private DevComponents.DotNetBar.ButtonItem btnXem;
        private DevComponents.DotNetBar.ButtonItem btnThem;
        private DevComponents.DotNetBar.ButtonItem btnSua;
        private DevComponents.DotNetBar.ButtonItem buttonItem2;
        private DevComponents.DotNetBar.ButtonItem btnXoa;
        private DevComponents.DotNetBar.ButtonItem btnImportTuExcel;
        private DevComponents.DotNetBar.ButtonItem btnExportFileExcel;
        private DevComponents.DotNetBar.ButtonItem btnThoat;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private ADGV.AdvancedDataGridView advancedDataGridView;
        private ADGV.SearchToolBar searchToolBar;
        private DevComponents.DotNetBar.ExpandablePanel expandablePanel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private DevComponents.DotNetBar.ButtonItem buttonItem3;
        private DevComponents.DotNetBar.ButtonItem buttonItem4;
        private DevComponents.DotNetBar.ButtonItem buttonItem5;
        private DevComponents.DotNetBar.ButtonItem buttonItem6;
        private ADGV.AdvancedDataGridView gridDSThietBiMuon;
    }
}