namespace QLTB.GUI
{
    partial class frmDMMonHoc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlBackDS = new System.Windows.Forms.Panel();
            this.pnlContentDSTB = new DevComponents.DotNetBar.PanelEx();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.panelEx3 = new DevComponents.DotNetBar.PanelEx();
            this.ADGVDanhSach = new ADGV.AdvancedDataGridView();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.comboBoxEx1 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.SearchDSTB = new ADGV.SearchToolBar();
            this.ribBarDSThietBi = new DevComponents.DotNetBar.RibbonBar();
            this.btnThemDSTB = new DevComponents.DotNetBar.ButtonItem();
            this.btnSuaDSTB = new DevComponents.DotNetBar.ButtonItem();
            this.btnXoaDSTB = new DevComponents.DotNetBar.ButtonItem();
            this.btnNapDSTB = new DevComponents.DotNetBar.ButtonItem();
            this.btnImportDSTB = new DevComponents.DotNetBar.ButtonItem();
            this.btnHelpDSTB = new DevComponents.DotNetBar.ButtonItem();
            this.btnClose = new DevComponents.DotNetBar.ButtonItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlBackDS.SuspendLayout();
            this.pnlContentDSTB.SuspendLayout();
            this.panelEx1.SuspendLayout();
            this.panelEx3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ADGVDanhSach)).BeginInit();
            this.panelEx2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlBackDS);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(904, 483);
            this.panel1.TabIndex = 23;
            // 
            // pnlBackDS
            // 
            this.pnlBackDS.BackColor = System.Drawing.Color.Transparent;
            this.pnlBackDS.Controls.Add(this.pnlContentDSTB);
            this.pnlBackDS.Controls.Add(this.ribBarDSThietBi);
            this.pnlBackDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBackDS.Location = new System.Drawing.Point(0, 40);
            this.pnlBackDS.Name = "pnlBackDS";
            this.pnlBackDS.Size = new System.Drawing.Size(904, 443);
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
            this.pnlContentDSTB.Size = new System.Drawing.Size(904, 408);
            this.pnlContentDSTB.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlContentDSTB.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnlContentDSTB.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
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
            this.panelEx1.Size = new System.Drawing.Size(904, 378);
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
            this.panelEx3.Controls.Add(this.ADGVDanhSach);
            this.panelEx3.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx3.Location = new System.Drawing.Point(0, 0);
            this.panelEx3.Name = "panelEx3";
            this.panelEx3.Size = new System.Drawing.Size(904, 343);
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
            // ADGVDanhSach
            // 
            this.ADGVDanhSach.AllowUserToAddRows = false;
            this.ADGVDanhSach.AllowUserToDeleteRows = false;
            this.ADGVDanhSach.AutoGenerateContextFilters = true;
            this.ADGVDanhSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ADGVDanhSach.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.ADGVDanhSach.BackgroundColor = System.Drawing.Color.White;
            this.ADGVDanhSach.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ADGVDanhSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ADGVDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ADGVDanhSach.DateWithTime = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ADGVDanhSach.DefaultCellStyle = dataGridViewCellStyle5;
            this.ADGVDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ADGVDanhSach.GridColor = System.Drawing.Color.Black;
            this.ADGVDanhSach.Location = new System.Drawing.Point(0, 0);
            this.ADGVDanhSach.Name = "ADGVDanhSach";
            this.ADGVDanhSach.ReadOnly = true;
            this.ADGVDanhSach.RowHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ADGVDanhSach.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.ADGVDanhSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ADGVDanhSach.Size = new System.Drawing.Size(904, 343);
            this.ADGVDanhSach.TabIndex = 27;
            this.ADGVDanhSach.TimeFilter = false;
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.textBoxX1);
            this.panelEx2.Controls.Add(this.linkLabel2);
            this.panelEx2.Controls.Add(this.linkLabel1);
            this.panelEx2.Controls.Add(this.labelX3);
            this.panelEx2.Controls.Add(this.labelX2);
            this.panelEx2.Controls.Add(this.labelX1);
            this.panelEx2.Controls.Add(this.comboBoxEx1);
            this.panelEx2.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEx2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelEx2.Location = new System.Drawing.Point(0, 343);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(904, 35);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 28;
            // 
            // textBoxX1
            // 
            this.textBoxX1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.textBoxX1.Border.Class = "TextBoxBorder";
            this.textBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX1.DisabledBackColor = System.Drawing.Color.White;
            this.textBoxX1.Location = new System.Drawing.Point(74, 7);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.PreventEnterBeep = true;
            this.textBoxX1.Size = new System.Drawing.Size(34, 21);
            this.textBoxX1.TabIndex = 7;
            this.textBoxX1.Text = "1";
            this.textBoxX1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // linkLabel2
            // 
            this.linkLabel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(118, 9);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(54, 15);
            this.linkLabel2.TabIndex = 6;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Trang sau";
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(5, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(64, 15);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Trang trước";
            // 
            // labelX3
            // 
            this.labelX3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.ForeColor = System.Drawing.Color.Black;
            this.labelX3.Location = new System.Drawing.Point(786, -3);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(108, 41);
            this.labelX3.TabIndex = 4;
            this.labelX3.Text = "- Tổng số: 9 bản ghi";
            // 
            // labelX2
            // 
            this.labelX2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(730, -3);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(56, 41);
            this.labelX2.TabIndex = 3;
            this.labelX2.Text = "Trang 1/1";
            // 
            // labelX1
            // 
            this.labelX1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(224, -3);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(59, 41);
            this.labelX1.TabIndex = 2;
            this.labelX1.Text = "Số bản ghi:";
            // 
            // comboBoxEx1
            // 
            this.comboBoxEx1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxEx1.DisplayMember = "Text";
            this.comboBoxEx1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxEx1.FormattingEnabled = true;
            this.comboBoxEx1.ItemHeight = 15;
            this.comboBoxEx1.Items.AddRange(new object[] {
            this.comboItem3,
            this.comboItem1,
            this.comboItem2});
            this.comboBoxEx1.Location = new System.Drawing.Point(289, 7);
            this.comboBoxEx1.Name = "comboBoxEx1";
            this.comboBoxEx1.Size = new System.Drawing.Size(56, 23);
            this.comboBoxEx1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxEx1.TabIndex = 0;
            this.comboBoxEx1.Text = "50";
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
            this.SearchDSTB.MaximumSize = new System.Drawing.Size(0, 40);
            this.SearchDSTB.MinimumSize = new System.Drawing.Size(0, 30);
            this.SearchDSTB.Name = "SearchDSTB";
            this.SearchDSTB.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.SearchDSTB.Size = new System.Drawing.Size(904, 30);
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
            this.btnThemDSTB,
            this.btnSuaDSTB,
            this.btnXoaDSTB,
            this.btnNapDSTB,
            this.btnImportDSTB,
            this.btnHelpDSTB,
            this.btnClose});
            this.ribBarDSThietBi.ItemSpacing = 10;
            this.ribBarDSThietBi.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.ribBarDSThietBi.Location = new System.Drawing.Point(0, 0);
            this.ribBarDSThietBi.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.ribBarDSThietBi.Name = "ribBarDSThietBi";
            this.ribBarDSThietBi.ShowShortcutKeysInToolTips = true;
            this.ribBarDSThietBi.Size = new System.Drawing.Size(904, 35);
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
            this.btnThemDSTB.ImagePaddingVertical = 14;
            this.btnThemDSTB.Name = "btnThemDSTB";
            this.btnThemDSTB.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlN);
            this.btnThemDSTB.Text = "Thêm";
            this.btnThemDSTB.Tooltip = "Khai báo thiết bị";
            this.btnThemDSTB.Click += new System.EventHandler(this.btnThemDSTB_Click);
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
            this.btnXoaDSTB.Tooltip = "Xóa thiết bị";
            this.btnXoaDSTB.Click += new System.EventHandler(this.btnXoaDSTB_Click);
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
            this.btnImportDSTB.Text = "Xuất khẩu";
            this.btnImportDSTB.Tooltip = "Xuất dữ liệu ra file excel";
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
            this.btnClose.BeginGroup = true;
            this.btnClose.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = global::QLTB.Properties.Resources.close16;
            this.btnClose.Name = "btnClose";
            this.btnClose.SubItemsExpandWidth = 14;
            this.btnClose.Text = "Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(904, 40);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(283, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "MÔN HỌC";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmDMMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 483);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmDMMonHoc";
            this.Text = "Danh mục môn học";
            this.Load += new System.EventHandler(this.frmDMMonHoc_Load);
            this.panel1.ResumeLayout(false);
            this.pnlBackDS.ResumeLayout(false);
            this.pnlContentDSTB.ResumeLayout(false);
            this.pnlContentDSTB.PerformLayout();
            this.panelEx1.ResumeLayout(false);
            this.panelEx3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ADGVDanhSach)).EndInit();
            this.panelEx2.ResumeLayout(false);
            this.panelEx2.PerformLayout();
            this.panel2.ResumeLayout(false);
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
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx1;
        private DevComponents.Editors.ComboItem comboItem3;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private ADGV.SearchToolBar SearchDSTB;
        private DevComponents.DotNetBar.RibbonBar ribBarDSThietBi;
        private DevComponents.DotNetBar.ButtonItem btnThemDSTB;
        private DevComponents.DotNetBar.ButtonItem btnSuaDSTB;
        private DevComponents.DotNetBar.ButtonItem btnXoaDSTB;
        private DevComponents.DotNetBar.ButtonItem btnNapDSTB;
        private DevComponents.DotNetBar.ButtonItem btnImportDSTB;
        private DevComponents.DotNetBar.ButtonItem btnHelpDSTB;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.ButtonItem btnClose;
    }
}