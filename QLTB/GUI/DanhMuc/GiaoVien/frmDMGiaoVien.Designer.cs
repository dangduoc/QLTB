namespace QLTB.GUI
{
    partial class frmDMGiaoVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDMGiaoVien));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnlBackDS = new System.Windows.Forms.Panel();
            this.pnlContentDSTB = new DevComponents.DotNetBar.PanelEx();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.panelEx3 = new DevComponents.DotNetBar.PanelEx();
            this.ADGVDanhSach = new ADGV.AdvancedDataGridView();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.currentPage = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.nextBtn = new System.Windows.Forms.LinkLabel();
            this.prevBtn = new System.Windows.Forms.LinkLabel();
            this.lbTotalRecord = new DevComponents.DotNetBar.LabelX();
            this.lbPaging = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.pageSize = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.SearchDSTB = new ADGV.SearchToolBar();
            this.ribBarDSThietBi = new DevComponents.DotNetBar.RibbonBar();
            this.btnThem = new DevComponents.DotNetBar.ButtonItem();
            this.btnSua = new DevComponents.DotNetBar.ButtonItem();
            this.btnXoa = new DevComponents.DotNetBar.ButtonItem();
            this.btnNap = new DevComponents.DotNetBar.ButtonItem();
            this.btnImport = new DevComponents.DotNetBar.ButtonItem();
            this.btnExport = new DevComponents.DotNetBar.ButtonItem();
            this.btnHelp = new DevComponents.DotNetBar.ButtonItem();
            this.btnClose = new DevComponents.DotNetBar.ButtonItem();
            this.expandableSplitter1 = new DevComponents.DotNetBar.ExpandableSplitter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TVToBoMon = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripChuyenPB = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnlBackDS.SuspendLayout();
            this.pnlContentDSTB.SuspendLayout();
            this.panelEx1.SuspendLayout();
            this.panelEx3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ADGVDanhSach)).BeginInit();
            this.panelEx2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.expandableSplitter1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1032, 479);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pnlBackDS);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(269, 40);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(763, 439);
            this.panel4.TabIndex = 31;
            // 
            // pnlBackDS
            // 
            this.pnlBackDS.BackColor = System.Drawing.Color.Transparent;
            this.pnlBackDS.Controls.Add(this.pnlContentDSTB);
            this.pnlBackDS.Controls.Add(this.ribBarDSThietBi);
            this.pnlBackDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBackDS.Location = new System.Drawing.Point(0, 0);
            this.pnlBackDS.Name = "pnlBackDS";
            this.pnlBackDS.Size = new System.Drawing.Size(763, 439);
            this.pnlBackDS.TabIndex = 29;
            // 
            // pnlContentDSTB
            // 
            this.pnlContentDSTB.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlContentDSTB.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnlContentDSTB.Controls.Add(this.panelEx1);
            this.pnlContentDSTB.Controls.Add(this.SearchDSTB);
            this.pnlContentDSTB.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnlContentDSTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContentDSTB.Location = new System.Drawing.Point(0, 35);
            this.pnlContentDSTB.Name = "pnlContentDSTB";
            this.pnlContentDSTB.Size = new System.Drawing.Size(763, 404);
            this.pnlContentDSTB.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlContentDSTB.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnlContentDSTB.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnlContentDSTB.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlContentDSTB.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlContentDSTB.Style.GradientAngle = 90;
            this.pnlContentDSTB.TabIndex = 26;
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.panelEx3);
            this.panelEx1.Controls.Add(this.panelEx2);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 30);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(763, 374);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
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
            this.panelEx3.Controls.Add(this.ADGVDanhSach);
            this.panelEx3.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx3.Location = new System.Drawing.Point(0, 0);
            this.panelEx3.Name = "panelEx3";
            this.panelEx3.Size = new System.Drawing.Size(763, 339);
            this.panelEx3.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx3.Style.GradientAngle = 90;
            this.panelEx3.TabIndex = 32;
            this.panelEx3.Text = "panelEx3";
            // 
            // ADGVDanhSach
            // 
            this.ADGVDanhSach.AllowUserToAddRows = false;
            this.ADGVDanhSach.AllowUserToDeleteRows = false;
            this.ADGVDanhSach.AutoGenerateContextFilters = true;
            this.ADGVDanhSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ADGVDanhSach.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.ADGVDanhSach.BackgroundColor = System.Drawing.Color.White;
            this.ADGVDanhSach.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ADGVDanhSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ADGVDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ADGVDanhSach.DateWithTime = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ADGVDanhSach.DefaultCellStyle = dataGridViewCellStyle2;
            this.ADGVDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ADGVDanhSach.GridColor = System.Drawing.Color.Black;
            this.ADGVDanhSach.Location = new System.Drawing.Point(0, 0);
            this.ADGVDanhSach.Name = "ADGVDanhSach";
            this.ADGVDanhSach.ReadOnly = true;
            this.ADGVDanhSach.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ADGVDanhSach.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.ADGVDanhSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ADGVDanhSach.Size = new System.Drawing.Size(763, 339);
            this.ADGVDanhSach.TabIndex = 27;
            this.ADGVDanhSach.TimeFilter = false;
            this.ADGVDanhSach.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ADGVDanhSach_MouseClick_1);
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.currentPage);
            this.panelEx2.Controls.Add(this.nextBtn);
            this.panelEx2.Controls.Add(this.prevBtn);
            this.panelEx2.Controls.Add(this.lbTotalRecord);
            this.panelEx2.Controls.Add(this.lbPaging);
            this.panelEx2.Controls.Add(this.labelX1);
            this.panelEx2.Controls.Add(this.pageSize);
            this.panelEx2.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEx2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelEx2.Location = new System.Drawing.Point(0, 339);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(763, 35);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 28;
            // 
            // currentPage
            // 
            this.currentPage.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.currentPage.Border.Class = "TextBoxBorder";
            this.currentPage.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.currentPage.DisabledBackColor = System.Drawing.Color.White;
            this.currentPage.ForeColor = System.Drawing.Color.Black;
            this.currentPage.Location = new System.Drawing.Point(76, 6);
            this.currentPage.Name = "currentPage";
            this.currentPage.PreventEnterBeep = true;
            this.currentPage.Size = new System.Drawing.Size(34, 21);
            this.currentPage.TabIndex = 7;
            this.currentPage.Text = "1";
            this.currentPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nextBtn
            // 
            this.nextBtn.AutoSize = true;
            this.nextBtn.Location = new System.Drawing.Point(116, 9);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(54, 15);
            this.nextBtn.TabIndex = 6;
            this.nextBtn.TabStop = true;
            this.nextBtn.Text = "Trang sau";
            // 
            // prevBtn
            // 
            this.prevBtn.AutoSize = true;
            this.prevBtn.Location = new System.Drawing.Point(6, 9);
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.Size = new System.Drawing.Size(64, 15);
            this.prevBtn.TabIndex = 5;
            this.prevBtn.TabStop = true;
            this.prevBtn.Text = "Trang trước";
            // 
            // lbTotalRecord
            // 
            this.lbTotalRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.lbTotalRecord.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbTotalRecord.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalRecord.ForeColor = System.Drawing.Color.Black;
            this.lbTotalRecord.Location = new System.Drawing.Point(634, 1);
            this.lbTotalRecord.Name = "lbTotalRecord";
            this.lbTotalRecord.Size = new System.Drawing.Size(127, 31);
            this.lbTotalRecord.TabIndex = 4;
            this.lbTotalRecord.Text = "- Tổng số: 9 bản ghi";
            // 
            // lbPaging
            // 
            this.lbPaging.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.lbPaging.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbPaging.ForeColor = System.Drawing.Color.Black;
            this.lbPaging.Location = new System.Drawing.Point(580, 1);
            this.lbPaging.Name = "lbPaging";
            this.lbPaging.Size = new System.Drawing.Size(50, 31);
            this.lbPaging.TabIndex = 3;
            this.lbPaging.Text = "Trang 1/1";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(192, 2);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(59, 31);
            this.labelX1.TabIndex = 2;
            this.labelX1.Text = "Số bản ghi:";
            // 
            // pageSize
            // 
            this.pageSize.DisplayMember = "Text";
            this.pageSize.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.pageSize.ForeColor = System.Drawing.Color.Black;
            this.pageSize.FormattingEnabled = true;
            this.pageSize.ItemHeight = 15;
            this.pageSize.Items.AddRange(new object[] {
            this.comboItem3,
            this.comboItem1,
            this.comboItem2});
            this.pageSize.Location = new System.Drawing.Point(254, 6);
            this.pageSize.Name = "pageSize";
            this.pageSize.Size = new System.Drawing.Size(59, 23);
            this.pageSize.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pageSize.TabIndex = 0;
            this.pageSize.Text = "50";
            // 
            // comboItem3
            // 
            this.comboItem3.Text = "100";
            this.comboItem3.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "50";
            this.comboItem1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "25";
            this.comboItem2.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // SearchDSTB
            // 
            this.SearchDSTB.AllowMerge = false;
            this.SearchDSTB.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.SearchDSTB.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.SearchDSTB.Location = new System.Drawing.Point(0, 0);
            this.SearchDSTB.MaximumSize = new System.Drawing.Size(0, 30);
            this.SearchDSTB.MinimumSize = new System.Drawing.Size(0, 30);
            this.SearchDSTB.Name = "SearchDSTB";
            this.SearchDSTB.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.SearchDSTB.Size = new System.Drawing.Size(763, 30);
            this.SearchDSTB.TabIndex = 28;
            this.SearchDSTB.Text = "searchToolBar1";
            // 
            // ribBarDSThietBi
            // 
            this.ribBarDSThietBi.AutoOverflowEnabled = true;
            this.ribBarDSThietBi.BackColor = System.Drawing.Color.Transparent;
            this.ribBarDSThietBi.BackgroundHoverEnabled = false;
            // 
            // 
            // 
            this.ribBarDSThietBi.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribBarDSThietBi.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribBarDSThietBi.ContainerControlProcessDialogKey = true;
            this.ribBarDSThietBi.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribBarDSThietBi.DragDropSupport = true;
            this.ribBarDSThietBi.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.ribBarDSThietBi.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnNap,
            this.btnImport,
            this.btnExport,
            this.btnHelp,
            this.btnClose});
            this.ribBarDSThietBi.ItemSpacing = 10;
            this.ribBarDSThietBi.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.ribBarDSThietBi.Location = new System.Drawing.Point(0, 0);
            this.ribBarDSThietBi.Margin = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.ribBarDSThietBi.Name = "ribBarDSThietBi";
            this.ribBarDSThietBi.ShowShortcutKeysInToolTips = true;
            this.ribBarDSThietBi.Size = new System.Drawing.Size(763, 35);
            this.ribBarDSThietBi.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribBarDSThietBi.TabIndex = 10;
            // 
            // 
            // 
            this.ribBarDSThietBi.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribBarDSThietBi.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnThem
            // 
            this.btnThem.BeginGroup = true;
            this.btnThem.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.Image = global::QLTB.Properties.Resources.add;
            this.btnThem.ImagePaddingHorizontal = 20;
            this.btnThem.ImagePaddingVertical = 15;
            this.btnThem.Name = "btnThem";
            this.btnThem.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlN);
            this.btnThem.Text = "Thêm";
            this.btnThem.Tooltip = "Khai báo thiết bị";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.Image = global::QLTB.Properties.Resources.edit16;
            this.btnSua.ImagePaddingHorizontal = 20;
            this.btnSua.ImagePaddingVertical = 10;
            this.btnSua.Name = "btnSua";
            this.btnSua.SubItemsExpandWidth = 14;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.Image = global::QLTB.Properties.Resources.b_drop;
            this.btnXoa.ImagePaddingHorizontal = 20;
            this.btnXoa.ImagePaddingVertical = 10;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlD);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Tooltip = "Xóa thiết bị";
            // 
            // btnNap
            // 
            this.btnNap.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnNap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNap.Image = global::QLTB.Properties.Resources.Refresh16;
            this.btnNap.ImagePaddingHorizontal = 20;
            this.btnNap.ImagePaddingVertical = 10;
            this.btnNap.Name = "btnNap";
            this.btnNap.RibbonWordWrap = false;
            this.btnNap.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F5);
            this.btnNap.Text = "Nạp";
            this.btnNap.Tooltip = "Làm mới dữ liệu";
            // 
            // btnImport
            // 
            this.btnImport.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImport.Image = global::QLTB.Properties.Resources.import16;
            this.btnImport.Name = "btnImport";
            this.btnImport.SubItemsExpandWidth = 14;
            this.btnImport.Text = "Nhập khẩu";
            // 
            // btnExport
            // 
            this.btnExport.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.Image = global::QLTB.Properties.Resources.import16;
            this.btnExport.ImagePaddingHorizontal = 20;
            this.btnExport.ImagePaddingVertical = 10;
            this.btnExport.Name = "btnExport";
            this.btnExport.RibbonWordWrap = false;
            this.btnExport.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F7);
            this.btnExport.Text = "Xuất khẩu";
            this.btnExport.Tooltip = "Xuất dữ liệu ra file excel";
            // 
            // btnHelp
            // 
            this.btnHelp.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelp.Image = global::QLTB.Properties.Resources.Help_icon;
            this.btnHelp.ImagePaddingHorizontal = 20;
            this.btnHelp.ImagePaddingVertical = 10;
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.SubItemsExpandWidth = 14;
            this.btnHelp.Text = "Trợ giúp";
            // 
            // btnClose
            // 
            this.btnClose.BeginGroup = true;
            this.btnClose.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = global::QLTB.Properties.Resources.close16;
            this.btnClose.Name = "btnClose";
            this.btnClose.SubItemsExpandWidth = 14;
            this.btnClose.Text = "Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // expandableSplitter1
            // 
            this.expandableSplitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.expandableSplitter1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(108)))), ((int)(((byte)(122)))));
            this.expandableSplitter1.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter1.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandableSplitter1.ExpandFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(108)))), ((int)(((byte)(122)))));
            this.expandableSplitter1.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter1.ExpandLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(120)))));
            this.expandableSplitter1.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter1.ForeColor = System.Drawing.Color.Black;
            this.expandableSplitter1.GripDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(120)))));
            this.expandableSplitter1.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter1.GripLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(232)))), ((int)(((byte)(246)))));
            this.expandableSplitter1.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.expandableSplitter1.HotBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(200)))), ((int)(((byte)(103)))));
            this.expandableSplitter1.HotBackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(226)))), ((int)(((byte)(135)))));
            this.expandableSplitter1.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2;
            this.expandableSplitter1.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground;
            this.expandableSplitter1.HotExpandFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(108)))), ((int)(((byte)(122)))));
            this.expandableSplitter1.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter1.HotExpandLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(120)))));
            this.expandableSplitter1.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter1.HotGripDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(108)))), ((int)(((byte)(122)))));
            this.expandableSplitter1.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter1.HotGripLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(232)))), ((int)(((byte)(246)))));
            this.expandableSplitter1.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.expandableSplitter1.Location = new System.Drawing.Point(262, 40);
            this.expandableSplitter1.Name = "expandableSplitter1";
            this.expandableSplitter1.Size = new System.Drawing.Size(7, 439);
            this.expandableSplitter1.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007;
            this.expandableSplitter1.TabIndex = 30;
            this.expandableSplitter1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.TVToBoMon);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(262, 439);
            this.panel3.TabIndex = 1;
            // 
            // TVToBoMon
            // 
            this.TVToBoMon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TVToBoMon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TVToBoMon.ImageIndex = 0;
            this.TVToBoMon.ImageList = this.imageList1;
            this.TVToBoMon.Location = new System.Drawing.Point(0, 0);
            this.TVToBoMon.Name = "TVToBoMon";
            this.TVToBoMon.SelectedImageIndex = 0;
            this.TVToBoMon.Size = new System.Drawing.Size(262, 439);
            this.TVToBoMon.TabIndex = 0;
            this.TVToBoMon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TVToBoMon_MouseDoubleClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "conference-icon.png");
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1032, 40);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(209, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "CÁN BỘ GIÁO VIÊN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripChuyenPB});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(177, 26);
            // 
            // ToolStripChuyenPB
            // 
            this.ToolStripChuyenPB.Name = "ToolStripChuyenPB";
            this.ToolStripChuyenPB.Size = new System.Drawing.Size(176, 22);
            this.ToolStripChuyenPB.Text = "Chuyển phòng ban";
            // 
            // frmDMGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 479);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmDMGiaoVien";
            this.Text = "Danh mục giáo viên";
            this.Load += new System.EventHandler(this.frmDMGiaoVien_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.pnlBackDS.ResumeLayout(false);
            this.pnlContentDSTB.ResumeLayout(false);
            this.pnlContentDSTB.PerformLayout();
            this.panelEx1.ResumeLayout(false);
            this.panelEx3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ADGVDanhSach)).EndInit();
            this.panelEx2.ResumeLayout(false);
            this.panelEx2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlBackDS;
        private DevComponents.DotNetBar.PanelEx pnlContentDSTB;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.PanelEx panelEx3;
        private ADGV.AdvancedDataGridView ADGVDanhSach;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.Controls.TextBoxX currentPage;
        private System.Windows.Forms.LinkLabel nextBtn;
        private System.Windows.Forms.LinkLabel prevBtn;
        private DevComponents.DotNetBar.LabelX lbTotalRecord;
        private DevComponents.DotNetBar.LabelX lbPaging;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx pageSize;
        private DevComponents.Editors.ComboItem comboItem3;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private ADGV.SearchToolBar SearchDSTB;
        private DevComponents.DotNetBar.RibbonBar ribBarDSThietBi;
        private DevComponents.DotNetBar.ButtonItem btnThem;
        private DevComponents.DotNetBar.ButtonItem btnSua;
        private DevComponents.DotNetBar.ButtonItem btnXoa;
        private DevComponents.DotNetBar.ButtonItem btnNap;
        private DevComponents.DotNetBar.ButtonItem btnExport;
        private DevComponents.DotNetBar.ButtonItem btnHelp;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private DevComponents.DotNetBar.ExpandableSplitter expandableSplitter1;
        private System.Windows.Forms.TreeView TVToBoMon;
        private System.Windows.Forms.ImageList imageList1;
        private DevComponents.DotNetBar.ButtonItem btnImport;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.ButtonItem btnClose;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripChuyenPB;
    }
}