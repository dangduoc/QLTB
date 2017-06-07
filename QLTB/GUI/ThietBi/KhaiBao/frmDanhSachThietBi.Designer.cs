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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Âm nhạc");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Công nghệ");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Địa lý");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Dùng chung");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Giáo dục công dân");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Tất cả", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDanhSachThietBi));
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripNhanBan = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSua = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripBaoMat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripGhiTang = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripGhiGiam = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tvFilter = new System.Windows.Forms.TreeView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdioPhongBM = new System.Windows.Forms.RadioButton();
            this.rdioThietBi = new System.Windows.Forms.RadioButton();
            this.expandableSplitter1 = new DevComponents.DotNetBar.ExpandableSplitter();
            this.ribBarDSThietBi = new DevComponents.DotNetBar.RibbonBar();
            this.btnThemDSTB = new DevComponents.DotNetBar.ButtonItem();
            this.btnSuaDSTB = new DevComponents.DotNetBar.ButtonItem();
            this.btnXoaDSTB = new DevComponents.DotNetBar.ButtonItem();
            this.btnNapDSTB = new DevComponents.DotNetBar.ButtonItem();
            this.btnImportDSTB = new DevComponents.DotNetBar.ButtonItem();
            this.btnInDSTB = new DevComponents.DotNetBar.ButtonItem();
            this.btnHelpDSTB = new DevComponents.DotNetBar.ButtonItem();
            this.btnClose = new DevComponents.DotNetBar.ButtonItem();
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
            this.pnlBackDS = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tabThongTin = new DevComponents.DotNetBar.TabControl();
            this.tabControlPanel1 = new DevComponents.DotNetBar.TabControlPanel();
            this.layoutControl1 = new DevComponents.DotNetBar.Layout.LayoutControl();
            this.lbDangMuon = new DevComponents.DotNetBar.LabelX();
            this.lbConDungDuoc = new DevComponents.DotNetBar.LabelX();
            this.lbSoLuong = new DevComponents.DotNetBar.LabelX();
            this.lbPhongBM = new DevComponents.DotNetBar.LabelX();
            this.lbNoiDung = new DevComponents.DotNetBar.LabelX();
            this.lbKhoiLop = new DevComponents.DotNetBar.LabelX();
            this.lbQuyCach = new DevComponents.DotNetBar.LabelX();
            this.lbSoHieu = new DevComponents.DotNetBar.LabelX();
            this.lbTenTB = new DevComponents.DotNetBar.LabelX();
            this.lbMaTB = new DevComponents.DotNetBar.LabelX();
            this.layoutControlItem1 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutControlItem7 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutControlItem2 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutControlItem8 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutControlItem3 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutControlItem9 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutControlItem4 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutControlItem10 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutControlItem5 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutControlItem6 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.tabItem1 = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel2 = new DevComponents.DotNetBar.TabControlPanel();
            this.tabItem2 = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel3 = new DevComponents.DotNetBar.TabControlPanel();
            this.advancedDataGridView1 = new ADGV.AdvancedDataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.tabItem3 = new DevComponents.DotNetBar.TabItem(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlContentDSTB.SuspendLayout();
            this.panelEx1.SuspendLayout();
            this.panelEx3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ADGVDanhSach)).BeginInit();
            this.panelEx2.SuspendLayout();
            this.pnlBackDS.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabThongTin)).BeginInit();
            this.tabThongTin.SuspendLayout();
            this.tabControlPanel1.SuspendLayout();
            this.layoutControl1.SuspendLayout();
            this.tabControlPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripNhanBan,
            this.toolStripSua,
            this.toolStripXoa,
            this.toolStripBaoMat,
            this.toolStripGhiTang,
            this.toolStripGhiGiam});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(152, 136);
            // 
            // toolStripNhanBan
            // 
            this.toolStripNhanBan.Image = global::QLTB.Properties.Resources.tick;
            this.toolStripNhanBan.Name = "toolStripNhanBan";
            this.toolStripNhanBan.Size = new System.Drawing.Size(151, 22);
            this.toolStripNhanBan.Text = "Nhân bản";
            // 
            // toolStripSua
            // 
            this.toolStripSua.Image = global::QLTB.Properties.Resources.save_icon;
            this.toolStripSua.Name = "toolStripSua";
            this.toolStripSua.Size = new System.Drawing.Size(151, 22);
            this.toolStripSua.Text = "Sửa";
            // 
            // toolStripXoa
            // 
            this.toolStripXoa.Image = global::QLTB.Properties.Resources.b_drop;
            this.toolStripXoa.Name = "toolStripXoa";
            this.toolStripXoa.Size = new System.Drawing.Size(151, 22);
            this.toolStripXoa.Text = "Xóa";
            // 
            // toolStripBaoMat
            // 
            this.toolStripBaoMat.Name = "toolStripBaoMat";
            this.toolStripBaoMat.Size = new System.Drawing.Size(151, 22);
            this.toolStripBaoMat.Text = "Báo mất/hỏng";
            this.toolStripBaoMat.Click += new System.EventHandler(this.toolStripBaoMat_Click);
            // 
            // toolStripGhiTang
            // 
            this.toolStripGhiTang.Name = "toolStripGhiTang";
            this.toolStripGhiTang.Size = new System.Drawing.Size(151, 22);
            this.toolStripGhiTang.Text = "Tăng thiết bị";
            // 
            // toolStripGhiGiam
            // 
            this.toolStripGhiGiam.Name = "toolStripGhiGiam";
            this.toolStripGhiGiam.Size = new System.Drawing.Size(151, 22);
            this.toolStripGhiGiam.Text = "Giảm thiết bị";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tvFilter);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 530);
            this.panel1.TabIndex = 27;
            // 
            // tvFilter
            // 
            this.tvFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvFilter.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvFilter.Location = new System.Drawing.Point(0, 34);
            this.tvFilter.Name = "tvFilter";
            treeNode1.Name = "Node3";
            treeNode1.Text = "Âm nhạc";
            treeNode2.Name = "Node4";
            treeNode2.Text = "Công nghệ";
            treeNode3.Name = "Node5";
            treeNode3.Text = "Địa lý";
            treeNode4.Name = "Node6";
            treeNode4.Text = "Dùng chung";
            treeNode5.Name = "Node7";
            treeNode5.Text = "Giáo dục công dân";
            treeNode6.Name = "Node0";
            treeNode6.Text = "Tất cả";
            this.tvFilter.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6});
            this.tvFilter.Size = new System.Drawing.Size(247, 496);
            this.tvFilter.TabIndex = 1;
            this.tvFilter.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvFilter_NodeMouseDoubleClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdioPhongBM);
            this.panel2.Controls.Add(this.rdioThietBi);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(247, 34);
            this.panel2.TabIndex = 0;
            // 
            // rdioPhongBM
            // 
            this.rdioPhongBM.Dock = System.Windows.Forms.DockStyle.Left;
            this.rdioPhongBM.Location = new System.Drawing.Point(85, 0);
            this.rdioPhongBM.Name = "rdioPhongBM";
            this.rdioPhongBM.Size = new System.Drawing.Size(156, 34);
            this.rdioPhongBM.TabIndex = 1;
            this.rdioPhongBM.Text = "Kho/ Phòng bộ môn";
            this.rdioPhongBM.UseVisualStyleBackColor = true;
            this.rdioPhongBM.CheckedChanged += new System.EventHandler(this.rdioPhongBM_CheckedChanged);
            // 
            // rdioThietBi
            // 
            this.rdioThietBi.Checked = true;
            this.rdioThietBi.Dock = System.Windows.Forms.DockStyle.Left;
            this.rdioThietBi.Location = new System.Drawing.Point(0, 0);
            this.rdioThietBi.Name = "rdioThietBi";
            this.rdioThietBi.Size = new System.Drawing.Size(85, 34);
            this.rdioThietBi.TabIndex = 0;
            this.rdioThietBi.TabStop = true;
            this.rdioThietBi.Text = "Thiết bị";
            this.rdioThietBi.UseVisualStyleBackColor = true;
            this.rdioThietBi.CheckedChanged += new System.EventHandler(this.rdioTB_CheckedChanged);
            // 
            // expandableSplitter1
            // 
            this.expandableSplitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.expandableSplitter1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.expandableSplitter1.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter1.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandableSplitter1.ExpandFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.expandableSplitter1.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter1.ExpandLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expandableSplitter1.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter1.ForeColor = System.Drawing.Color.Black;
            this.expandableSplitter1.GripDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expandableSplitter1.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter1.GripLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.expandableSplitter1.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.expandableSplitter1.HotBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(151)))), ((int)(((byte)(61)))));
            this.expandableSplitter1.HotBackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(94)))));
            this.expandableSplitter1.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2;
            this.expandableSplitter1.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground;
            this.expandableSplitter1.HotExpandFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.expandableSplitter1.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter1.HotExpandLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expandableSplitter1.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter1.HotGripDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.expandableSplitter1.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter1.HotGripLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.expandableSplitter1.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.expandableSplitter1.Location = new System.Drawing.Point(247, 0);
            this.expandableSplitter1.Name = "expandableSplitter1";
            this.expandableSplitter1.Size = new System.Drawing.Size(6, 530);
            this.expandableSplitter1.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007;
            this.expandableSplitter1.TabIndex = 28;
            this.expandableSplitter1.TabStop = false;
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
            this.btnThemDSTB,
            this.btnSuaDSTB,
            this.btnXoaDSTB,
            this.btnNapDSTB,
            this.btnImportDSTB,
            this.btnInDSTB,
            this.btnHelpDSTB,
            this.btnClose});
            this.ribBarDSThietBi.ItemSpacing = 10;
            this.ribBarDSThietBi.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.ribBarDSThietBi.Location = new System.Drawing.Point(0, 0);
            this.ribBarDSThietBi.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.ribBarDSThietBi.Name = "ribBarDSThietBi";
            this.ribBarDSThietBi.ShowShortcutKeysInToolTips = true;
            this.ribBarDSThietBi.Size = new System.Drawing.Size(879, 34);
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
            // btnThemDSTB
            // 
            this.btnThemDSTB.BeginGroup = true;
            this.btnThemDSTB.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnThemDSTB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemDSTB.Image = global::QLTB.Properties.Resources.add;
            this.btnThemDSTB.ImagePaddingHorizontal = 20;
            this.btnThemDSTB.ImagePaddingVertical = 13;
            this.btnThemDSTB.Name = "btnThemDSTB";
            this.btnThemDSTB.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlN);
            this.btnThemDSTB.Text = "Khai báo thiết bị";
            this.btnThemDSTB.Tooltip = "Khai báo thiết bị";
            this.btnThemDSTB.Click += new System.EventHandler(this.BtnThemDSTB_Click);
            // 
            // btnSuaDSTB
            // 
            this.btnSuaDSTB.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnSuaDSTB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaDSTB.Image = global::QLTB.Properties.Resources.edit16;
            this.btnSuaDSTB.ImagePaddingHorizontal = 20;
            this.btnSuaDSTB.ImagePaddingVertical = 10;
            this.btnSuaDSTB.Name = "btnSuaDSTB";
            this.btnSuaDSTB.SubItemsExpandWidth = 14;
            this.btnSuaDSTB.Text = "Sửa";
            this.btnSuaDSTB.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnXoaDSTB
            // 
            this.btnXoaDSTB.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnXoaDSTB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaDSTB.Image = global::QLTB.Properties.Resources.b_drop;
            this.btnXoaDSTB.ImagePaddingHorizontal = 20;
            this.btnXoaDSTB.ImagePaddingVertical = 10;
            this.btnXoaDSTB.Name = "btnXoaDSTB";
            this.btnXoaDSTB.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlD);
            this.btnXoaDSTB.Text = "Xóa";
            this.btnXoaDSTB.Tooltip = "Xóa thiết bị";
            this.btnXoaDSTB.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnNapDSTB
            // 
            this.btnNapDSTB.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnNapDSTB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNapDSTB.Image = global::QLTB.Properties.Resources.Refresh16;
            this.btnNapDSTB.ImagePaddingHorizontal = 20;
            this.btnNapDSTB.ImagePaddingVertical = 10;
            this.btnNapDSTB.Name = "btnNapDSTB";
            this.btnNapDSTB.RibbonWordWrap = false;
            this.btnNapDSTB.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F5);
            this.btnNapDSTB.Text = "Nạp";
            this.btnNapDSTB.Tooltip = "Làm mới dữ liệu";
            this.btnNapDSTB.Click += new System.EventHandler(this.btnNapDSTB_Click);
            // 
            // btnImportDSTB
            // 
            this.btnImportDSTB.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnImportDSTB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImportDSTB.Image = global::QLTB.Properties.Resources.import16;
            this.btnImportDSTB.ImagePaddingHorizontal = 20;
            this.btnImportDSTB.ImagePaddingVertical = 10;
            this.btnImportDSTB.Name = "btnImportDSTB";
            this.btnImportDSTB.RibbonWordWrap = false;
            this.btnImportDSTB.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F7);
            this.btnImportDSTB.Text = "Nhập khẩu";
            this.btnImportDSTB.Tooltip = "Import dữ liệu";
            this.btnImportDSTB.Click += new System.EventHandler(this.btnImportDSTB_Click);
            // 
            // btnInDSTB
            // 
            this.btnInDSTB.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnInDSTB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInDSTB.Image = global::QLTB.Properties.Resources.print16;
            this.btnInDSTB.ImagePaddingHorizontal = 20;
            this.btnInDSTB.ImagePaddingVertical = 10;
            this.btnInDSTB.Name = "btnInDSTB";
            this.btnInDSTB.SubItemsExpandWidth = 14;
            this.btnInDSTB.Text = "In";
            this.btnInDSTB.Click += new System.EventHandler(this.btnInDSTB_Click);
            // 
            // btnHelpDSTB
            // 
            this.btnHelpDSTB.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnHelpDSTB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelpDSTB.Image = global::QLTB.Properties.Resources.Help_icon;
            this.btnHelpDSTB.ImagePaddingHorizontal = 20;
            this.btnHelpDSTB.ImagePaddingVertical = 10;
            this.btnHelpDSTB.Name = "btnHelpDSTB";
            this.btnHelpDSTB.SubItemsExpandWidth = 14;
            this.btnHelpDSTB.Text = "Trợ giúp";
            // 
            // btnClose
            // 
            this.btnClose.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = global::QLTB.Properties.Resources.close16;
            this.btnClose.Name = "btnClose";
            this.btnClose.SubItemsExpandWidth = 14;
            this.btnClose.Text = "Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlContentDSTB
            // 
            this.pnlContentDSTB.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlContentDSTB.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnlContentDSTB.Controls.Add(this.panelEx1);
            this.pnlContentDSTB.Controls.Add(this.SearchDSTB);
            this.pnlContentDSTB.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnlContentDSTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContentDSTB.Location = new System.Drawing.Point(0, 34);
            this.pnlContentDSTB.Name = "pnlContentDSTB";
            this.pnlContentDSTB.Size = new System.Drawing.Size(879, 268);
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
            this.panelEx1.Location = new System.Drawing.Point(0, 27);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(879, 241);
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
            this.panelEx3.Size = new System.Drawing.Size(879, 206);
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
            this.ADGVDanhSach.Location = new System.Drawing.Point(0, 0);
            this.ADGVDanhSach.Name = "ADGVDanhSach";
            this.ADGVDanhSach.ReadOnly = true;
            this.ADGVDanhSach.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ADGVDanhSach.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.ADGVDanhSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ADGVDanhSach.Size = new System.Drawing.Size(879, 206);
            this.ADGVDanhSach.TabIndex = 27;
            this.ADGVDanhSach.TimeFilter = false;
            this.ADGVDanhSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ADGVDanhSach_CellClick);
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
            this.panelEx2.Location = new System.Drawing.Point(0, 206);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(879, 35);
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
            this.currentPage.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentPage.ForeColor = System.Drawing.Color.Black;
            this.currentPage.Location = new System.Drawing.Point(70, 7);
            this.currentPage.Name = "currentPage";
            this.currentPage.PreventEnterBeep = true;
            this.currentPage.Size = new System.Drawing.Size(25, 21);
            this.currentPage.TabIndex = 7;
            this.currentPage.Text = "1";
            this.currentPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nextBtn
            // 
            this.nextBtn.AutoSize = true;
            this.nextBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextBtn.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextBtn.Location = new System.Drawing.Point(102, 9);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(54, 15);
            this.nextBtn.TabIndex = 6;
            this.nextBtn.TabStop = true;
            this.nextBtn.Text = "Trang sau";
            this.nextBtn.Click += new System.EventHandler(this.pageBtnClick);
            // 
            // prevBtn
            // 
            this.prevBtn.AutoSize = true;
            this.prevBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.prevBtn.DisabledLinkColor = System.Drawing.Color.Black;
            this.prevBtn.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prevBtn.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.prevBtn.Location = new System.Drawing.Point(3, 9);
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.Size = new System.Drawing.Size(64, 15);
            this.prevBtn.TabIndex = 5;
            this.prevBtn.TabStop = true;
            this.prevBtn.Text = "Trang trước";
            this.prevBtn.Click += new System.EventHandler(this.pageBtnClick);
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
            this.lbTotalRecord.Location = new System.Drawing.Point(762, 7);
            this.lbTotalRecord.Name = "lbTotalRecord";
            this.lbTotalRecord.Size = new System.Drawing.Size(109, 23);
            this.lbTotalRecord.TabIndex = 4;
            this.lbTotalRecord.Text = "- Tổng số: 0 bản ghi";
            // 
            // lbPaging
            // 
            this.lbPaging.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.lbPaging.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbPaging.ForeColor = System.Drawing.Color.Black;
            this.lbPaging.Location = new System.Drawing.Point(711, 8);
            this.lbPaging.Name = "lbPaging";
            this.lbPaging.Size = new System.Drawing.Size(57, 23);
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
            this.labelX1.Location = new System.Drawing.Point(207, 5);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(57, 23);
            this.labelX1.TabIndex = 2;
            this.labelX1.Text = "Số bản ghi:";
            // 
            // pageSize
            // 
            this.pageSize.DisplayMember = "Text";
            this.pageSize.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.pageSize.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageSize.ForeColor = System.Drawing.Color.Black;
            this.pageSize.FormattingEnabled = true;
            this.pageSize.ItemHeight = 15;
            this.pageSize.Items.AddRange(new object[] {
            this.comboItem3,
            this.comboItem1,
            this.comboItem2});
            this.pageSize.Location = new System.Drawing.Point(266, 6);
            this.pageSize.Name = "pageSize";
            this.pageSize.Size = new System.Drawing.Size(44, 23);
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
            this.SearchDSTB.Font = new System.Drawing.Font("Arial", 9F);
            this.SearchDSTB.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.SearchDSTB.Location = new System.Drawing.Point(0, 0);
            this.SearchDSTB.MaximumSize = new System.Drawing.Size(0, 27);
            this.SearchDSTB.MinimumSize = new System.Drawing.Size(0, 27);
            this.SearchDSTB.Name = "SearchDSTB";
            this.SearchDSTB.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.SearchDSTB.Size = new System.Drawing.Size(879, 27);
            this.SearchDSTB.TabIndex = 28;
            this.SearchDSTB.Text = "searchToolBar1";
            // 
            // pnlBackDS
            // 
            this.pnlBackDS.BackColor = System.Drawing.Color.Transparent;
            this.pnlBackDS.Controls.Add(this.pnlContentDSTB);
            this.pnlBackDS.Controls.Add(this.ribBarDSThietBi);
            this.pnlBackDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBackDS.Location = new System.Drawing.Point(0, 0);
            this.pnlBackDS.Name = "pnlBackDS";
            this.pnlBackDS.Size = new System.Drawing.Size(879, 302);
            this.pnlBackDS.TabIndex = 26;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.tabThongTin);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(253, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(879, 530);
            this.panel3.TabIndex = 29;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pnlBackDS);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(879, 302);
            this.panel4.TabIndex = 28;
            // 
            // tabThongTin
            // 
            this.tabThongTin.BackColor = System.Drawing.Color.White;
            this.tabThongTin.CanReorderTabs = true;
            this.tabThongTin.ColorScheme.TabBackground = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(221)))), ((int)(((byte)(238)))));
            this.tabThongTin.ColorScheme.TabBorder = System.Drawing.Color.White;
            this.tabThongTin.ColorScheme.TabItemBackground = System.Drawing.Color.Empty;
            this.tabThongTin.ColorScheme.TabItemSelectedBackground = System.Drawing.Color.White;
            this.tabThongTin.ColorScheme.TabItemText = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabThongTin.Controls.Add(this.tabControlPanel1);
            this.tabThongTin.Controls.Add(this.tabControlPanel2);
            this.tabThongTin.Controls.Add(this.tabControlPanel3);
            this.tabThongTin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabThongTin.ForeColor = System.Drawing.Color.Black;
            this.tabThongTin.Location = new System.Drawing.Point(0, 302);
            this.tabThongTin.Name = "tabThongTin";
            this.tabThongTin.SelectedTabFont = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.tabThongTin.SelectedTabIndex = 0;
            this.tabThongTin.Size = new System.Drawing.Size(879, 228);
            this.tabThongTin.Style = DevComponents.DotNetBar.eTabStripStyle.Flat;
            this.tabThongTin.TabIndex = 27;
            this.tabThongTin.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabThongTin.Tabs.Add(this.tabItem1);
            this.tabThongTin.Tabs.Add(this.tabItem3);
            this.tabThongTin.Tabs.Add(this.tabItem2);
            this.tabThongTin.Text = "tabControl1";
            this.tabThongTin.Visible = false;
            // 
            // tabControlPanel1
            // 
            this.tabControlPanel1.AutoScroll = true;
            this.tabControlPanel1.AutoScrollMinSize = new System.Drawing.Size(700, 290);
            this.tabControlPanel1.Controls.Add(this.layoutControl1);
            this.tabControlPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.tabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel1.Location = new System.Drawing.Point(0, 25);
            this.tabControlPanel1.Name = "tabControlPanel1";
            this.tabControlPanel1.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel1.Size = new System.Drawing.Size(879, 203);
            this.tabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.White;
            this.tabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel1.Style.BorderColor.Color = System.Drawing.SystemColors.ControlDark;
            this.tabControlPanel1.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel1.Style.GradientAngle = 90;
            this.tabControlPanel1.TabIndex = 1;
            this.tabControlPanel1.TabItem = this.tabItem1;
            // 
            // layoutControl1
            // 
            this.layoutControl1.BackColor = System.Drawing.Color.White;
            this.layoutControl1.Controls.Add(this.lbDangMuon);
            this.layoutControl1.Controls.Add(this.lbConDungDuoc);
            this.layoutControl1.Controls.Add(this.lbSoLuong);
            this.layoutControl1.Controls.Add(this.lbPhongBM);
            this.layoutControl1.Controls.Add(this.lbNoiDung);
            this.layoutControl1.Controls.Add(this.lbKhoiLop);
            this.layoutControl1.Controls.Add(this.lbQuyCach);
            this.layoutControl1.Controls.Add(this.lbSoHieu);
            this.layoutControl1.Controls.Add(this.lbTenTB);
            this.layoutControl1.Controls.Add(this.lbMaTB);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(1, 1);
            this.layoutControl1.Name = "layoutControl1";
            // 
            // 
            // 
            this.layoutControl1.RootGroup.Items.AddRange(new DevComponents.DotNetBar.Layout.LayoutItemBase[] {
            this.layoutControlItem1,
            this.layoutControlItem7,
            this.layoutControlItem2,
            this.layoutControlItem8,
            this.layoutControlItem3,
            this.layoutControlItem9,
            this.layoutControlItem4,
            this.layoutControlItem10,
            this.layoutControlItem5,
            this.layoutControlItem6});
            this.layoutControl1.Size = new System.Drawing.Size(860, 290);
            this.layoutControl1.TabIndex = 0;
            // 
            // lbDangMuon
            // 
            // 
            // 
            // 
            this.lbDangMuon.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbDangMuon.Location = new System.Drawing.Point(705, 109);
            this.lbDangMuon.Margin = new System.Windows.Forms.Padding(0);
            this.lbDangMuon.Name = "lbDangMuon";
            this.lbDangMuon.Size = new System.Drawing.Size(151, 27);
            this.lbDangMuon.TabIndex = 7;
            this.lbDangMuon.Text = "labelX13";
            // 
            // lbConDungDuoc
            // 
            // 
            // 
            // 
            this.lbConDungDuoc.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbConDungDuoc.Location = new System.Drawing.Point(705, 74);
            this.lbConDungDuoc.Margin = new System.Windows.Forms.Padding(0);
            this.lbConDungDuoc.Name = "lbConDungDuoc";
            this.lbConDungDuoc.Size = new System.Drawing.Size(151, 27);
            this.lbConDungDuoc.TabIndex = 5;
            this.lbConDungDuoc.Text = "labelX12";
            // 
            // lbSoLuong
            // 
            // 
            // 
            // 
            this.lbSoLuong.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbSoLuong.Location = new System.Drawing.Point(705, 39);
            this.lbSoLuong.Margin = new System.Windows.Forms.Padding(0);
            this.lbSoLuong.Name = "lbSoLuong";
            this.lbSoLuong.Size = new System.Drawing.Size(151, 27);
            this.lbSoLuong.TabIndex = 3;
            this.lbSoLuong.Text = "labelX11";
            // 
            // lbPhongBM
            // 
            // 
            // 
            // 
            this.lbPhongBM.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbPhongBM.Location = new System.Drawing.Point(705, 4);
            this.lbPhongBM.Margin = new System.Windows.Forms.Padding(0);
            this.lbPhongBM.Name = "lbPhongBM";
            this.lbPhongBM.Size = new System.Drawing.Size(151, 27);
            this.lbPhongBM.TabIndex = 1;
            this.lbPhongBM.Text = "labelX10";
            // 
            // lbNoiDung
            // 
            this.lbNoiDung.AllowDrop = true;
            // 
            // 
            // 
            this.lbNoiDung.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbNoiDung.Location = new System.Drawing.Point(151, 179);
            this.lbNoiDung.Margin = new System.Windows.Forms.Padding(0);
            this.lbNoiDung.Name = "lbNoiDung";
            this.lbNoiDung.PaddingTop = 5;
            this.lbNoiDung.Size = new System.Drawing.Size(705, 92);
            this.lbNoiDung.TabIndex = 9;
            this.lbNoiDung.Text = "labelX9";
            this.lbNoiDung.TextLineAlignment = System.Drawing.StringAlignment.Near;
            this.lbNoiDung.WordWrap = true;
            // 
            // lbKhoiLop
            // 
            // 
            // 
            // 
            this.lbKhoiLop.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbKhoiLop.Location = new System.Drawing.Point(151, 144);
            this.lbKhoiLop.Margin = new System.Windows.Forms.Padding(0);
            this.lbKhoiLop.Name = "lbKhoiLop";
            this.lbKhoiLop.Size = new System.Drawing.Size(705, 27);
            this.lbKhoiLop.TabIndex = 8;
            this.lbKhoiLop.Text = "labelX8";
            // 
            // lbQuyCach
            // 
            // 
            // 
            // 
            this.lbQuyCach.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbQuyCach.Location = new System.Drawing.Point(151, 109);
            this.lbQuyCach.Margin = new System.Windows.Forms.Padding(0);
            this.lbQuyCach.Name = "lbQuyCach";
            this.lbQuyCach.Size = new System.Drawing.Size(404, 27);
            this.lbQuyCach.TabIndex = 6;
            this.lbQuyCach.Text = "labelX7";
            // 
            // lbSoHieu
            // 
            // 
            // 
            // 
            this.lbSoHieu.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbSoHieu.Location = new System.Drawing.Point(151, 74);
            this.lbSoHieu.Margin = new System.Windows.Forms.Padding(0);
            this.lbSoHieu.Name = "lbSoHieu";
            this.lbSoHieu.Size = new System.Drawing.Size(404, 27);
            this.lbSoHieu.TabIndex = 4;
            this.lbSoHieu.Text = "labelX6";
            // 
            // lbTenTB
            // 
            // 
            // 
            // 
            this.lbTenTB.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbTenTB.Location = new System.Drawing.Point(151, 39);
            this.lbTenTB.Margin = new System.Windows.Forms.Padding(0);
            this.lbTenTB.Name = "lbTenTB";
            this.lbTenTB.Size = new System.Drawing.Size(404, 27);
            this.lbTenTB.TabIndex = 2;
            this.lbTenTB.Text = "labelX5";
            // 
            // lbMaTB
            // 
            // 
            // 
            // 
            this.lbMaTB.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbMaTB.Location = new System.Drawing.Point(151, 4);
            this.lbMaTB.Margin = new System.Windows.Forms.Padding(0);
            this.lbMaTB.Name = "lbMaTB";
            this.lbMaTB.Size = new System.Drawing.Size(404, 27);
            this.lbMaTB.TabIndex = 0;
            this.lbMaTB.Text = "Thiết bị số 1";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.lbMaTB;
            this.layoutControlItem1.Height = 35;
            this.layoutControlItem1.MinSize = new System.Drawing.Size(64, 18);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Style.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem1.Text = "<b>Mã thiết bị</b>";
            this.layoutControlItem1.TextControlSpacing = 30;
            this.layoutControlItem1.TextPadding = new System.Windows.Forms.Padding(5, 6, 0, 0);
            this.layoutControlItem1.TextPosition = DevComponents.DotNetBar.Layout.eLayoutPosition.Left;
            this.layoutControlItem1.Width = 65;
            this.layoutControlItem1.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.lbPhongBM;
            this.layoutControlItem7.Height = 31;
            this.layoutControlItem7.MinSize = new System.Drawing.Size(64, 18);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Style.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem7.Text = "<b>Kho/ Phòng bộ môn</b>";
            this.layoutControlItem7.TextControlSpacing = 30;
            this.layoutControlItem7.TextPadding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.layoutControlItem7.Width = 35;
            this.layoutControlItem7.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.lbTenTB;
            this.layoutControlItem2.Height = 35;
            this.layoutControlItem2.MinSize = new System.Drawing.Size(64, 18);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Style.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem2.Text = "<b>Tên thiết bị</b>";
            this.layoutControlItem2.TextControlSpacing = 30;
            this.layoutControlItem2.TextPadding = new System.Windows.Forms.Padding(5, 6, 0, 0);
            this.layoutControlItem2.Width = 65;
            this.layoutControlItem2.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.lbSoLuong;
            this.layoutControlItem8.Height = 31;
            this.layoutControlItem8.MinSize = new System.Drawing.Size(64, 18);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Style.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem8.Text = "<b>Số lượng</b>";
            this.layoutControlItem8.TextControlSpacing = 30;
            this.layoutControlItem8.TextPadding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.layoutControlItem8.Width = 35;
            this.layoutControlItem8.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.lbSoHieu;
            this.layoutControlItem3.Height = 35;
            this.layoutControlItem3.MinSize = new System.Drawing.Size(64, 18);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Style.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem3.Text = "<b>Số hiệu</b>";
            this.layoutControlItem3.TextControlSpacing = 30;
            this.layoutControlItem3.TextPadding = new System.Windows.Forms.Padding(5, 6, 0, 0);
            this.layoutControlItem3.Width = 65;
            this.layoutControlItem3.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.lbConDungDuoc;
            this.layoutControlItem9.Height = 31;
            this.layoutControlItem9.MinSize = new System.Drawing.Size(64, 18);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Style.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem9.Text = "<b>Còn dùng được</b>";
            this.layoutControlItem9.TextControlSpacing = 30;
            this.layoutControlItem9.TextPadding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.layoutControlItem9.Width = 35;
            this.layoutControlItem9.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.lbQuyCach;
            this.layoutControlItem4.Height = 35;
            this.layoutControlItem4.MinSize = new System.Drawing.Size(64, 18);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Style.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem4.Text = "<b>Quy cách</b>";
            this.layoutControlItem4.TextControlSpacing = 30;
            this.layoutControlItem4.TextPadding = new System.Windows.Forms.Padding(5, 6, 0, 0);
            this.layoutControlItem4.Width = 65;
            this.layoutControlItem4.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.lbDangMuon;
            this.layoutControlItem10.Height = 31;
            this.layoutControlItem10.MinSize = new System.Drawing.Size(64, 18);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Style.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem10.Text = "<b>Đang mượn</b>";
            this.layoutControlItem10.TextControlSpacing = 30;
            this.layoutControlItem10.TextPadding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.layoutControlItem10.Width = 35;
            this.layoutControlItem10.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.lbKhoiLop;
            this.layoutControlItem5.Height = 35;
            this.layoutControlItem5.MinSize = new System.Drawing.Size(64, 18);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Style.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem5.Text = "<b>Khối lớp</b>";
            this.layoutControlItem5.TextControlSpacing = 30;
            this.layoutControlItem5.TextPadding = new System.Windows.Forms.Padding(5, 6, 0, 0);
            this.layoutControlItem5.Width = 65;
            this.layoutControlItem5.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.lbNoiDung;
            this.layoutControlItem6.Height = 100;
            this.layoutControlItem6.MinSize = new System.Drawing.Size(64, 18);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Style.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem6.Text = "Nội dung";
            this.layoutControlItem6.TextControlSpacing = 30;
            this.layoutControlItem6.TextPadding = new System.Windows.Forms.Padding(5, 6, 0, 0);
            this.layoutControlItem6.Width = 65;
            this.layoutControlItem6.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // tabItem1
            // 
            this.tabItem1.AttachedControl = this.tabControlPanel1;
            this.tabItem1.Name = "tabItem1";
            this.tabItem1.Text = "Thông tin chi tiết";
            // 
            // tabControlPanel2
            // 
            this.tabControlPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.tabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel2.Location = new System.Drawing.Point(0, 25);
            this.tabControlPanel2.Name = "tabControlPanel2";
            this.tabControlPanel2.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel2.Size = new System.Drawing.Size(879, 203);
            this.tabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.White;
            this.tabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel2.Style.BorderColor.Color = System.Drawing.SystemColors.ControlDark;
            this.tabControlPanel2.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel2.Style.GradientAngle = 90;
            this.tabControlPanel2.TabIndex = 5;
            this.tabControlPanel2.TabItem = this.tabItem2;
            // 
            // tabItem2
            // 
            this.tabItem2.AttachedControl = this.tabControlPanel2;
            this.tabItem2.Name = "tabItem2";
            this.tabItem2.Text = "Lịch sử biến động";
            // 
            // tabControlPanel3
            // 
            this.tabControlPanel3.Controls.Add(this.advancedDataGridView1);
            this.tabControlPanel3.Controls.Add(this.panel5);
            this.tabControlPanel3.DisabledBackColor = System.Drawing.Color.Empty;
            this.tabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel3.Location = new System.Drawing.Point(0, 25);
            this.tabControlPanel3.Name = "tabControlPanel3";
            this.tabControlPanel3.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel3.Size = new System.Drawing.Size(879, 203);
            this.tabControlPanel3.Style.BackColor1.Color = System.Drawing.Color.White;
            this.tabControlPanel3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel3.Style.BorderColor.Color = System.Drawing.SystemColors.ControlDark;
            this.tabControlPanel3.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel3.Style.GradientAngle = 90;
            this.tabControlPanel3.TabIndex = 9;
            this.tabControlPanel3.TabItem = this.tabItem3;
            // 
            // advancedDataGridView1
            // 
            this.advancedDataGridView1.AutoGenerateContextFilters = true;
            this.advancedDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advancedDataGridView1.DateWithTime = false;
            this.advancedDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.advancedDataGridView1.Location = new System.Drawing.Point(1, 36);
            this.advancedDataGridView1.Name = "advancedDataGridView1";
            this.advancedDataGridView1.Size = new System.Drawing.Size(877, 166);
            this.advancedDataGridView1.TabIndex = 1;
            this.advancedDataGridView1.TimeFilter = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.radioButton5);
            this.panel5.Controls.Add(this.radioButton4);
            this.panel5.Controls.Add(this.radioButton3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(1, 1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(877, 35);
            this.panel5.TabIndex = 0;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButton5.Location = new System.Drawing.Point(205, 0);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.radioButton5.Size = new System.Drawing.Size(72, 35);
            this.radioButton5.TabIndex = 2;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Tất cả";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButton4.Location = new System.Drawing.Point(99, 0);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.radioButton4.Size = new System.Drawing.Size(106, 35);
            this.radioButton4.TabIndex = 1;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Trong tháng";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButton3.Location = new System.Drawing.Point(0, 0);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.radioButton3.Size = new System.Drawing.Size(99, 35);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Trong tuần";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // tabItem3
            // 
            this.tabItem3.AttachedControl = this.tabControlPanel3;
            this.tabItem3.Name = "tabItem3";
            this.tabItem3.Text = "Lịch sử mượn trả";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "forward.png");
            this.imageList1.Images.SetKeyName(1, "tick.png");
            // 
            // frmDanhSachThietBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 530);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.expandableSplitter1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmDanhSachThietBi";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh sách thiết bị";
            this.TopLeftCornerSize = 0;
            this.TopRightCornerSize = 0;
            this.Load += new System.EventHandler(this.frmDanhSachThietBi_Load);
            this.contextMenuStrip.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnlContentDSTB.ResumeLayout(false);
            this.pnlContentDSTB.PerformLayout();
            this.panelEx1.ResumeLayout(false);
            this.panelEx3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ADGVDanhSach)).EndInit();
            this.panelEx2.ResumeLayout(false);
            this.panelEx2.PerformLayout();
            this.pnlBackDS.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabThongTin)).EndInit();
            this.tabThongTin.ResumeLayout(false);
            this.tabControlPanel1.ResumeLayout(false);
            this.layoutControl1.ResumeLayout(false);
            this.tabControlPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripNhanBan;
        private System.Windows.Forms.ToolStripMenuItem toolStripSua;
        private System.Windows.Forms.ToolStripMenuItem toolStripXoa;
        private System.Windows.Forms.ToolStripMenuItem toolStripBaoMat;
        private System.Windows.Forms.ToolStripMenuItem toolStripGhiTang;
        private System.Windows.Forms.ToolStripMenuItem toolStripGhiGiam;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView tvFilter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdioPhongBM;
        private System.Windows.Forms.RadioButton rdioThietBi;
        private DevComponents.DotNetBar.ExpandableSplitter expandableSplitter1;
        private DevComponents.DotNetBar.RibbonBar ribBarDSThietBi;
        private DevComponents.DotNetBar.ButtonItem btnThemDSTB;
        private DevComponents.DotNetBar.ButtonItem btnSuaDSTB;
        private DevComponents.DotNetBar.ButtonItem btnXoaDSTB;
        private DevComponents.DotNetBar.ButtonItem btnNapDSTB;
        private DevComponents.DotNetBar.ButtonItem btnImportDSTB;
        private DevComponents.DotNetBar.ButtonItem btnInDSTB;
        private DevComponents.DotNetBar.ButtonItem btnHelpDSTB;
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
        private System.Windows.Forms.Panel pnlBackDS;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private DevComponents.DotNetBar.TabControl tabThongTin;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel3;
        private DevComponents.DotNetBar.TabItem tabItem3;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel2;
        private DevComponents.DotNetBar.TabItem tabItem2;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel1;
        private DevComponents.DotNetBar.TabItem tabItem1;
        private DevComponents.DotNetBar.Layout.LayoutControl layoutControl1;
        private DevComponents.DotNetBar.LabelX lbDangMuon;
        private DevComponents.DotNetBar.LabelX lbConDungDuoc;
        private DevComponents.DotNetBar.LabelX lbSoLuong;
        private DevComponents.DotNetBar.LabelX lbPhongBM;
        private DevComponents.DotNetBar.LabelX lbNoiDung;
        private DevComponents.DotNetBar.LabelX lbKhoiLop;
        private DevComponents.DotNetBar.LabelX lbQuyCach;
        private DevComponents.DotNetBar.LabelX lbSoHieu;
        private DevComponents.DotNetBar.LabelX lbTenTB;
        private DevComponents.DotNetBar.LabelX lbMaTB;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem1;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem7;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem2;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem8;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem3;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem9;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem4;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem10;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem5;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem6;
        private ADGV.AdvancedDataGridView advancedDataGridView1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.ImageList imageList1;
        private DevComponents.DotNetBar.ButtonItem btnClose;
    }
}