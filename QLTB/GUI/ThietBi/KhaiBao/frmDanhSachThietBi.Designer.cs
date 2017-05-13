namespace QLTB.GUI
{
    partial class frmDanhSachThietBi
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDanhSachThietBi));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rbChucNang = new DevComponents.DotNetBar.RibbonBar();
            this.btnXem = new DevComponents.DotNetBar.ButtonItem();
            this.btnThem = new DevComponents.DotNetBar.ButtonItem();
            this.btnXoa = new DevComponents.DotNetBar.ButtonItem();
            this.btnLamMoi = new DevComponents.DotNetBar.ButtonItem();
            this.btnImportTuExcel = new DevComponents.DotNetBar.ButtonItem();
            this.btnExportFileExcel = new DevComponents.DotNetBar.ButtonItem();
            this.btnThoat = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.pnlBack = new DevComponents.DotNetBar.PanelEx();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.panelEx3 = new DevComponents.DotNetBar.PanelEx();
            this.advancedDataGridView = new ADGV.AdvancedDataGridView();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.searchToolBar = new ADGV.SearchToolBar();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nhânBảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoMấthỏngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ghiTăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giảmThiếtBịToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlBack.SuspendLayout();
            this.panelEx1.SuspendLayout();
            this.panelEx3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView)).BeginInit();
            this.panelEx2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
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
            this.btnXoa,
            this.btnLamMoi,
            this.btnImportTuExcel,
            this.btnExportFileExcel,
            this.btnThoat});
            this.rbChucNang.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.rbChucNang.Location = new System.Drawing.Point(0, 0);
            this.rbChucNang.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.rbChucNang.Name = "rbChucNang";
            this.rbChucNang.ShowShortcutKeysInToolTips = true;
            this.rbChucNang.Size = new System.Drawing.Size(1050, 80);
            this.rbChucNang.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.rbChucNang.TabIndex = 8;
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
            this.btnXem.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnXem.Name = "btnXem";
            this.btnXem.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F3);
            this.btnXem.ShowSubItems = false;
            this.btnXem.Text = "Xem";
            this.btnXem.Tooltip = "Xem thông tin chi tiết";
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnThem
            // 
            this.btnThem.BeginGroup = true;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImagePaddingHorizontal = 50;
            this.btnThem.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnThem.Name = "btnThem";
            this.btnThem.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlN);
            this.btnThem.Text = "Khai báo thiết bị";
            this.btnThem.Tooltip = "Khai báo thiết bị";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlD);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Tooltip = "Xóa thiết bị";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BeginGroup = true;
            this.btnLamMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.Image")));
            this.btnLamMoi.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.RibbonWordWrap = false;
            this.btnLamMoi.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F5);
            this.btnLamMoi.Text = "Làm mới dữ liệu";
            this.btnLamMoi.Tooltip = "Làm mới dữ liệu";
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
            this.btnExportFileExcel.BeginGroup = true;
            this.btnExportFileExcel.Image = global::QLTB.Properties.Resources.Collap;
            this.btnExportFileExcel.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnExportFileExcel.Name = "btnExportFileExcel";
            this.btnExportFileExcel.RibbonWordWrap = false;
            this.btnExportFileExcel.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F7);
            this.btnExportFileExcel.Text = "Export ra file Excel";
            this.btnExportFileExcel.Tooltip = "Xuất dữ liệu ra file excel";
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
            // pnlBack
            // 
            this.pnlBack.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlBack.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnlBack.Controls.Add(this.panelEx1);
            this.pnlBack.Controls.Add(this.searchToolBar);
            this.pnlBack.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnlBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBack.Location = new System.Drawing.Point(0, 80);
            this.pnlBack.Name = "pnlBack";
            this.pnlBack.Size = new System.Drawing.Size(1050, 450);
            this.pnlBack.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlBack.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnlBack.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnlBack.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnlBack.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlBack.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlBack.Style.GradientAngle = 90;
            this.pnlBack.TabIndex = 22;
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.panelEx3);
            this.panelEx1.Controls.Add(this.panelEx2);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 27);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(1050, 423);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 29;
            // 
            // panelEx3
            // 
            this.panelEx3.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx3.Controls.Add(this.advancedDataGridView);
            this.panelEx3.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx3.Location = new System.Drawing.Point(0, 0);
            this.panelEx3.Name = "panelEx3";
            this.panelEx3.Size = new System.Drawing.Size(1050, 384);
            this.panelEx3.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx3.Style.GradientAngle = 90;
            this.panelEx3.TabIndex = 32;
            this.panelEx3.Text = "panelEx3";
            // 
            // advancedDataGridView
            // 
            this.advancedDataGridView.AllowUserToAddRows = false;
            this.advancedDataGridView.AllowUserToDeleteRows = false;
            this.advancedDataGridView.AutoGenerateContextFilters = true;
            this.advancedDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.advancedDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.advancedDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
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
            this.advancedDataGridView.Location = new System.Drawing.Point(0, 0);
            this.advancedDataGridView.Name = "advancedDataGridView";
            this.advancedDataGridView.ReadOnly = true;
            this.advancedDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.advancedDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.advancedDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.advancedDataGridView.Size = new System.Drawing.Size(1050, 384);
            this.advancedDataGridView.TabIndex = 27;
            this.advancedDataGridView.TimeFilter = false;
            this.advancedDataGridView.SortStringChanged += new System.EventHandler(this.advancedDataGridView_SortStringChanged);
            this.advancedDataGridView.FilterStringChanged += new System.EventHandler(this.advancedDataGridView_FilterStringChanged);
            this.advancedDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.advancedDataGridView_CellClick);
            this.advancedDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.advancedDataGridView_CellContentDoubleClick);
            this.advancedDataGridView.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.advancedDataGridView_KeyPress);
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.statusStrip1);
            this.panelEx2.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEx2.Location = new System.Drawing.Point(0, 384);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(1050, 39);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 28;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1050, 39);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Arial", 9F);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(124, 34);
            this.toolStripStatusLabel1.Text = "Tổng số thiết bị: 9";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.ForeColor = System.Drawing.Color.Red;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(44, 34);
            this.toolStripStatusLabel2.Text = "Chú ý: ";
            // 
            // searchToolBar
            // 
            this.searchToolBar.AllowMerge = false;
            this.searchToolBar.Font = new System.Drawing.Font("Arial", 9F);
            this.searchToolBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.searchToolBar.Location = new System.Drawing.Point(0, 0);
            this.searchToolBar.MaximumSize = new System.Drawing.Size(0, 27);
            this.searchToolBar.MinimumSize = new System.Drawing.Size(0, 27);
            this.searchToolBar.Name = "searchToolBar";
            this.searchToolBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.searchToolBar.Size = new System.Drawing.Size(1050, 27);
            this.searchToolBar.TabIndex = 28;
            this.searchToolBar.Text = "searchToolBar1";
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhânBảnToolStripMenuItem,
            this.sửaToolStripMenuItem,
            this.xóaToolStripMenuItem,
            this.báoMấthỏngToolStripMenuItem,
            this.ghiTăngToolStripMenuItem,
            this.giảmThiếtBịToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(152, 136);
            // 
            // nhânBảnToolStripMenuItem
            // 
            this.nhânBảnToolStripMenuItem.Image = global::QLTB.Properties.Resources.tick;
            this.nhânBảnToolStripMenuItem.Name = "nhânBảnToolStripMenuItem";
            this.nhânBảnToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.nhânBảnToolStripMenuItem.Text = "Nhân bản";
            // 
            // sửaToolStripMenuItem
            // 
            this.sửaToolStripMenuItem.Image = global::QLTB.Properties.Resources.save_icon;
            this.sửaToolStripMenuItem.Name = "sửaToolStripMenuItem";
            this.sửaToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.sửaToolStripMenuItem.Text = "Sửa";
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Image = global::QLTB.Properties.Resources.b_drop;
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.xóaToolStripMenuItem.Text = "Xóa";
            // 
            // báoMấthỏngToolStripMenuItem
            // 
            this.báoMấthỏngToolStripMenuItem.Name = "báoMấthỏngToolStripMenuItem";
            this.báoMấthỏngToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.báoMấthỏngToolStripMenuItem.Text = "Báo mất/hỏng";
            // 
            // ghiTăngToolStripMenuItem
            // 
            this.ghiTăngToolStripMenuItem.Name = "ghiTăngToolStripMenuItem";
            this.ghiTăngToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.ghiTăngToolStripMenuItem.Text = "Tăng thiết bị";
            // 
            // giảmThiếtBịToolStripMenuItem
            // 
            this.giảmThiếtBịToolStripMenuItem.Name = "giảmThiếtBịToolStripMenuItem";
            this.giảmThiếtBịToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.giảmThiếtBịToolStripMenuItem.Text = "Giảm thiết bị";
            // 
            // frmDanhSachThietBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 530);
            this.Controls.Add(this.pnlBack);
            this.Controls.Add(this.rbChucNang);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmDanhSachThietBi";
            this.Text = "Danh sách thiết bị";
            this.Load += new System.EventHandler(this.frmDanhSachThietBi_Load);
            this.pnlBack.ResumeLayout(false);
            this.pnlBack.PerformLayout();
            this.panelEx1.ResumeLayout(false);
            this.panelEx3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView)).EndInit();
            this.panelEx2.ResumeLayout(false);
            this.panelEx2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.RibbonBar rbChucNang;
        private DevComponents.DotNetBar.ButtonItem btnXem;
        private DevComponents.DotNetBar.ButtonItem btnThem;
        private DevComponents.DotNetBar.ButtonItem btnXoa;
        private DevComponents.DotNetBar.ButtonItem btnLamMoi;
        private DevComponents.DotNetBar.ButtonItem btnImportTuExcel;
        private DevComponents.DotNetBar.ButtonItem btnExportFileExcel;
        private DevComponents.DotNetBar.ButtonItem btnThoat;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.PanelEx pnlBack;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private ADGV.AdvancedDataGridView advancedDataGridView;
        private ADGV.SearchToolBar searchToolBar;
        private DevComponents.DotNetBar.PanelEx panelEx3;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem nhânBảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoMấthỏngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ghiTăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giảmThiếtBịToolStripMenuItem;
    }
}