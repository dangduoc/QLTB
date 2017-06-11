﻿namespace QLTB.GUI
{
    partial class frmDSPhieuTangTB
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
            this.btnSuaDSTB = new DevComponents.DotNetBar.ButtonItem();
            this.btnXoaDSTB = new DevComponents.DotNetBar.ButtonItem();
            this.btnNapDSTB = new DevComponents.DotNetBar.ButtonItem();
            this.btnImportDSTB = new DevComponents.DotNetBar.ButtonItem();
            this.btnInDSTB = new DevComponents.DotNetBar.ButtonItem();
            this.btnHelpDSTB = new DevComponents.DotNetBar.ButtonItem();
            this.btnClose = new DevComponents.DotNetBar.ButtonItem();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nhânBảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoMấthỏngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ghiTăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giảmThiếtBịToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlBackDS.SuspendLayout();
            this.pnlContentDSTB.SuspendLayout();
            this.panelEx1.SuspendLayout();
            this.panelEx3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ADGVDanhSach)).BeginInit();
            this.panelEx2.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBackDS
            // 
            this.pnlBackDS.BackColor = System.Drawing.Color.Transparent;
            this.pnlBackDS.Controls.Add(this.pnlContentDSTB);
            this.pnlBackDS.Controls.Add(this.ribBarDSThietBi);
            this.pnlBackDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBackDS.Location = new System.Drawing.Point(0, 0);
            this.pnlBackDS.Name = "pnlBackDS";
            this.pnlBackDS.Size = new System.Drawing.Size(976, 546);
            this.pnlBackDS.TabIndex = 46;
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
            this.pnlContentDSTB.Size = new System.Drawing.Size(976, 511);
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
            this.panelEx1.Location = new System.Drawing.Point(0, 31);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(976, 480);
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
            this.panelEx3.Size = new System.Drawing.Size(976, 444);
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
            this.ADGVDanhSach.Location = new System.Drawing.Point(0, 0);
            this.ADGVDanhSach.Name = "ADGVDanhSach";
            this.ADGVDanhSach.ReadOnly = true;
            this.ADGVDanhSach.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ADGVDanhSach.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.ADGVDanhSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ADGVDanhSach.Size = new System.Drawing.Size(976, 444);
            this.ADGVDanhSach.TabIndex = 27;
            this.ADGVDanhSach.TimeFilter = false;
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
            this.panelEx2.Location = new System.Drawing.Point(0, 444);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(976, 36);
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
            this.currentPage.Location = new System.Drawing.Point(74, 7);
            this.currentPage.Name = "currentPage";
            this.currentPage.PreventEnterBeep = true;
            this.currentPage.Size = new System.Drawing.Size(29, 21);
            this.currentPage.TabIndex = 7;
            this.currentPage.Text = "1";
            this.currentPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nextBtn
            // 
            this.nextBtn.AutoSize = true;
            this.nextBtn.Location = new System.Drawing.Point(110, 10);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(54, 15);
            this.nextBtn.TabIndex = 6;
            this.nextBtn.TabStop = true;
            this.nextBtn.Text = "Trang sau";
            // 
            // prevBtn
            // 
            this.prevBtn.AutoSize = true;
            this.prevBtn.Location = new System.Drawing.Point(4, 10);
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
            this.lbTotalRecord.Location = new System.Drawing.Point(842, 4);
            this.lbTotalRecord.Name = "lbTotalRecord";
            this.lbTotalRecord.Size = new System.Drawing.Size(127, 27);
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
            this.lbPaging.Location = new System.Drawing.Point(791, 4);
            this.lbPaging.Name = "lbPaging";
            this.lbPaging.Size = new System.Drawing.Size(51, 27);
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
            this.labelX1.Location = new System.Drawing.Point(206, 3);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(64, 27);
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
            this.pageSize.Location = new System.Drawing.Point(274, 6);
            this.pageSize.Name = "pageSize";
            this.pageSize.Size = new System.Drawing.Size(51, 23);
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
            this.SearchDSTB.MaximumSize = new System.Drawing.Size(0, 31);
            this.SearchDSTB.MinimumSize = new System.Drawing.Size(0, 31);
            this.SearchDSTB.Name = "SearchDSTB";
            this.SearchDSTB.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.SearchDSTB.Size = new System.Drawing.Size(976, 31);
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
            this.ribBarDSThietBi.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.ribBarDSThietBi.Name = "ribBarDSThietBi";
            this.ribBarDSThietBi.ShowShortcutKeysInToolTips = true;
            this.ribBarDSThietBi.Size = new System.Drawing.Size(976, 35);
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
            this.btnThem.ImagePaddingVertical = 14;
            this.btnThem.Name = "btnThem";
            this.btnThem.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlN);
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSuaDSTB
            // 
            this.btnSuaDSTB.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnSuaDSTB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaDSTB.Image = global::QLTB.Properties.Resources.edit16;
            this.btnSuaDSTB.ImagePaddingHorizontal = 20;
            this.btnSuaDSTB.ImagePaddingVertical = 10;
            this.btnSuaDSTB.Name = "btnSuaDSTB";
            this.btnSuaDSTB.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F2);
            this.btnSuaDSTB.SubItemsExpandWidth = 14;
            this.btnSuaDSTB.Text = "Sửa";
            this.btnSuaDSTB.Click += new System.EventHandler(this.btnSuaDSTB_Click);
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
            // 
            // btnInDSTB
            // 
            this.btnInDSTB.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnInDSTB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInDSTB.Image = global::QLTB.Properties.Resources.print16;
            this.btnInDSTB.ImagePaddingHorizontal = 20;
            this.btnInDSTB.ImagePaddingVertical = 10;
            this.btnInDSTB.Name = "btnInDSTB";
            this.btnInDSTB.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlP);
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
            this.btnHelpDSTB.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F1);
            this.btnHelpDSTB.SubItemsExpandWidth = 14;
            this.btnHelpDSTB.Text = "Trợ giúp";
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
            // frmDSPhieuTangTB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 546);
            this.Controls.Add(this.pnlBackDS);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmDSPhieuTangTB";
            this.ShowIcon = false;
            this.Text = "Danh sách phiếu ghi tăng thiết bị";
            this.Load += new System.EventHandler(this.frmDSPhieuTangTB_Load);
            this.pnlBackDS.ResumeLayout(false);
            this.pnlContentDSTB.ResumeLayout(false);
            this.pnlContentDSTB.PerformLayout();
            this.panelEx1.ResumeLayout(false);
            this.panelEx3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ADGVDanhSach)).EndInit();
            this.panelEx2.ResumeLayout(false);
            this.panelEx2.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

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
        private DevComponents.DotNetBar.ButtonItem btnSuaDSTB;
        private DevComponents.DotNetBar.ButtonItem btnXoaDSTB;
        private DevComponents.DotNetBar.ButtonItem btnNapDSTB;
        private DevComponents.DotNetBar.ButtonItem btnImportDSTB;
        private DevComponents.DotNetBar.ButtonItem btnInDSTB;
        private DevComponents.DotNetBar.ButtonItem btnHelpDSTB;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem nhânBảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoMấthỏngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ghiTăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giảmThiếtBịToolStripMenuItem;
        private DevComponents.DotNetBar.ButtonItem btnClose;
    }
}