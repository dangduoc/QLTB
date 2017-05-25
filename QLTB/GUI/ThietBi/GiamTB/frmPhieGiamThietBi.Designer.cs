namespace QLTB.GUI
{
    partial class frmPhieGiamThietBi
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.ADGVDSTB = new ADGV.AdvancedDataGridView();
            this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.btnLayTB = new DevComponents.DotNetBar.ButtonItem();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.pnlTTPhieuMuon = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.layoutControl1 = new DevComponents.DotNetBar.Layout.LayoutControl();
            this.txtGhiChu = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.dPickerNgayLap = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.txtSoPhieu = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.layoutControlItem1 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutControlItem3 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutSpacerItem1 = new DevComponents.DotNetBar.Layout.LayoutSpacerItem();
            this.layoutControlItem2 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.ribBarDSThietBi = new DevComponents.DotNetBar.RibbonBar();
            this.btnLuu = new DevComponents.DotNetBar.ButtonItem();
            this.btnXoa = new DevComponents.DotNetBar.ButtonItem();
            this.btnHelpDSTB = new DevComponents.DotNetBar.ButtonItem();
            this.btnClose = new DevComponents.DotNetBar.ButtonItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ADGVDSTB)).BeginInit();
            this.pnlTTPhieuMuon.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dPickerNgayLap)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pnlTTPhieuMuon);
            this.panel1.Controls.Add(this.ribBarDSThietBi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 485);
            this.panel1.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ADGVDSTB);
            this.panel2.Controls.Add(this.ribbonBar1);
            this.panel2.Controls.Add(this.labelX1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 270);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.panel2.Size = new System.Drawing.Size(950, 215);
            this.panel2.TabIndex = 20;
            // 
            // ADGVDSTB
            // 
            this.ADGVDSTB.AllowUserToAddRows = false;
            this.ADGVDSTB.AllowUserToDeleteRows = false;
            this.ADGVDSTB.AutoGenerateContextFilters = true;
            this.ADGVDSTB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ADGVDSTB.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.ADGVDSTB.BackgroundColor = System.Drawing.Color.White;
            this.ADGVDSTB.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ADGVDSTB.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ADGVDSTB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ADGVDSTB.DateWithTime = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ADGVDSTB.DefaultCellStyle = dataGridViewCellStyle5;
            this.ADGVDSTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ADGVDSTB.GridColor = System.Drawing.Color.Black;
            this.ADGVDSTB.Location = new System.Drawing.Point(5, 64);
            this.ADGVDSTB.Name = "ADGVDSTB";
            this.ADGVDSTB.ReadOnly = true;
            this.ADGVDSTB.RowHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ADGVDSTB.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.ADGVDSTB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ADGVDSTB.Size = new System.Drawing.Size(945, 151);
            this.ADGVDSTB.TabIndex = 29;
            this.ADGVDSTB.TimeFilter = false;
            // 
            // ribbonBar1
            // 
            this.ribbonBar1.AutoOverflowEnabled = true;
            this.ribbonBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(221)))), ((int)(((byte)(238)))));
            this.ribbonBar1.BackgroundHoverEnabled = false;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar1.ContainerControlProcessDialogKey = true;
            this.ribbonBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonBar1.DragDropSupport = true;
            this.ribbonBar1.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.ribbonBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnLayTB});
            this.ribbonBar1.ItemSpacing = 10;
            this.ribbonBar1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.ribbonBar1.Location = new System.Drawing.Point(5, 30);
            this.ribbonBar1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.ribbonBar1.Name = "ribbonBar1";
            this.ribbonBar1.ShowShortcutKeysInToolTips = true;
            this.ribbonBar1.Size = new System.Drawing.Size(945, 34);
            this.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar1.TabIndex = 12;
            // 
            // 
            // 
            this.ribbonBar1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnLayTB
            // 
            this.btnLayTB.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnLayTB.Image = global::QLTB.Properties.Resources.cancel16;
            this.btnLayTB.Name = "btnLayTB";
            this.btnLayTB.SubItemsExpandWidth = 14;
            this.btnLayTB.Text = "Chọn nhiều thiết bị";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelX1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(5, 0);
            this.labelX1.Name = "labelX1";
            this.labelX1.PaddingLeft = 15;
            this.labelX1.Size = new System.Drawing.Size(945, 30);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Danh sách thiết bị";
            // 
            // pnlTTPhieuMuon
            // 
            this.pnlTTPhieuMuon.Controls.Add(this.panel3);
            this.pnlTTPhieuMuon.Controls.Add(this.labelX2);
            this.pnlTTPhieuMuon.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTTPhieuMuon.Location = new System.Drawing.Point(0, 34);
            this.pnlTTPhieuMuon.Name = "pnlTTPhieuMuon";
            this.pnlTTPhieuMuon.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.pnlTTPhieuMuon.Size = new System.Drawing.Size(950, 236);
            this.pnlTTPhieuMuon.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(5, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(945, 196);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.panel4.Size = new System.Drawing.Size(945, 196);
            this.panel4.TabIndex = 1;
            // 
            // layoutControl1
            // 
            this.layoutControl1.BackColor = System.Drawing.Color.White;
            this.layoutControl1.Controls.Add(this.txtGhiChu);
            this.layoutControl1.Controls.Add(this.dPickerNgayLap);
            this.layoutControl1.Controls.Add(this.txtSoPhieu);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControl1.ForeColor = System.Drawing.Color.Black;
            this.layoutControl1.Location = new System.Drawing.Point(3, 31);
            this.layoutControl1.Name = "layoutControl1";
            // 
            // 
            // 
            this.layoutControl1.RootGroup.Items.AddRange(new DevComponents.DotNetBar.Layout.LayoutItemBase[] {
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutSpacerItem1,
            this.layoutControlItem2});
            this.layoutControl1.Size = new System.Drawing.Size(532, 150);
            this.layoutControl1.TabIndex = 4;
            // 
            // txtGhiChu
            // 
            // 
            // 
            // 
            this.txtGhiChu.BackgroundStyle.Class = "RichTextBoxBorder";
            this.txtGhiChu.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtGhiChu.Location = new System.Drawing.Point(77, 39);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(0);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang1033{\\fonttbl{\\f0\\fnil\\fcharset0 Times New R" +
    "oman;}}\r\n\\viewkind4\\uc1\\pard\\f0\\fs20\\par\r\n}\r\n";
            this.txtGhiChu.Size = new System.Drawing.Size(419, 100);
            this.txtGhiChu.TabIndex = 3;
            // 
            // dPickerNgayLap
            // 
            // 
            // 
            // 
            this.dPickerNgayLap.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dPickerNgayLap.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dPickerNgayLap.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dPickerNgayLap.ButtonDropDown.Visible = true;
            this.dPickerNgayLap.CustomFormat = "dd/mm/yyyy";
            this.dPickerNgayLap.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dPickerNgayLap.IsPopupCalendarOpen = false;
            this.dPickerNgayLap.Location = new System.Drawing.Point(279, 4);
            this.dPickerNgayLap.Margin = new System.Windows.Forms.Padding(0);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dPickerNgayLap.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dPickerNgayLap.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dPickerNgayLap.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dPickerNgayLap.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dPickerNgayLap.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dPickerNgayLap.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dPickerNgayLap.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dPickerNgayLap.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dPickerNgayLap.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dPickerNgayLap.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dPickerNgayLap.MonthCalendar.DisplayMonth = new System.DateTime(2017, 4, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.dPickerNgayLap.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dPickerNgayLap.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dPickerNgayLap.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dPickerNgayLap.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dPickerNgayLap.MonthCalendar.TodayButtonVisible = true;
            this.dPickerNgayLap.Name = "dPickerNgayLap";
            this.dPickerNgayLap.Size = new System.Drawing.Size(117, 21);
            this.dPickerNgayLap.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dPickerNgayLap.TabIndex = 1;
            this.dPickerNgayLap.WatermarkText = "dd/mm/yyyy";
            // 
            // txtSoPhieu
            // 
            this.txtSoPhieu.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtSoPhieu.Border.Class = "TextBoxBorder";
            this.txtSoPhieu.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSoPhieu.DisabledBackColor = System.Drawing.Color.White;
            this.txtSoPhieu.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoPhieu.ForeColor = System.Drawing.Color.Black;
            this.txtSoPhieu.Location = new System.Drawing.Point(77, 4);
            this.txtSoPhieu.Margin = new System.Windows.Forms.Padding(0);
            this.txtSoPhieu.Name = "txtSoPhieu";
            this.txtSoPhieu.PreventEnterBeep = true;
            this.txtSoPhieu.Size = new System.Drawing.Size(119, 21);
            this.txtSoPhieu.TabIndex = 0;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtSoPhieu;
            this.layoutControlItem1.Height = 35;
            this.layoutControlItem1.MinSize = new System.Drawing.Size(139, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Text = "<b>Số phiếu <font color=\"#ED1C24\">(*)</font></b>";
            this.layoutControlItem1.Width = 200;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.dPickerNgayLap;
            this.layoutControlItem3.Height = 35;
            this.layoutControlItem3.MinSize = new System.Drawing.Size(74, 20);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Text = "<b>Ngày lập <font color=\"#ED1C24\">(*)</font></b>";
            this.layoutControlItem3.TextControlSpacing = 5;
            this.layoutControlItem3.Width = 200;
            // 
            // layoutSpacerItem1
            // 
            this.layoutSpacerItem1.Height = 32;
            this.layoutSpacerItem1.Name = "layoutSpacerItem1";
            this.layoutSpacerItem1.Width = 100;
            this.layoutSpacerItem1.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtGhiChu;
            this.layoutControlItem2.Height = 108;
            this.layoutControlItem2.MinSize = new System.Drawing.Size(64, 18);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Text = "<b>Ghi chú</b>";
            this.layoutControlItem2.Width = 500;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelX2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(5, 0);
            this.labelX2.Name = "labelX2";
            this.labelX2.PaddingLeft = 10;
            this.labelX2.Size = new System.Drawing.Size(945, 40);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "Phiếu giảm thiết bị";
            // 
            // ribBarDSThietBi
            // 
            this.ribBarDSThietBi.AutoOverflowEnabled = true;
            this.ribBarDSThietBi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(221)))), ((int)(((byte)(238)))));
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
            this.btnLuu,
            this.btnXoa,
            this.btnHelpDSTB,
            this.btnClose});
            this.ribBarDSThietBi.ItemSpacing = 10;
            this.ribBarDSThietBi.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.ribBarDSThietBi.Location = new System.Drawing.Point(0, 0);
            this.ribBarDSThietBi.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.ribBarDSThietBi.Name = "ribBarDSThietBi";
            this.ribBarDSThietBi.ShowShortcutKeysInToolTips = true;
            this.ribBarDSThietBi.Size = new System.Drawing.Size(950, 34);
            this.ribBarDSThietBi.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribBarDSThietBi.TabIndex = 11;
            // 
            // 
            // 
            this.ribBarDSThietBi.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribBarDSThietBi.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnLuu
            // 
            this.btnLuu.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnLuu.Image = global::QLTB.Properties.Resources.save_icon;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.SubItemsExpandWidth = 14;
            this.btnLuu.Text = "Lưu";
            // 
            // btnXoa
            // 
            this.btnXoa.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnXoa.Image = global::QLTB.Properties.Resources.b_drop;
            this.btnXoa.ImagePaddingHorizontal = 20;
            this.btnXoa.ImagePaddingVertical = 10;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlD);
            this.btnXoa.Text = "Xóa";
            // 
            // btnHelpDSTB
            // 
            this.btnHelpDSTB.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
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
            this.btnClose.Image = global::QLTB.Properties.Resources.close16;
            this.btnClose.Name = "btnClose";
            this.btnClose.SubItemsExpandWidth = 14;
            this.btnClose.Text = "Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.layoutControl1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.groupBox1.Size = new System.Drawing.Size(538, 184);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // frmPhieGiamThietBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(950, 485);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmPhieGiamThietBi";
            this.Text = "Phiếu giảm thiết bị";
            this.Load += new System.EventHandler(this.frmPhieGiamThietBi_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ADGVDSTB)).EndInit();
            this.pnlTTPhieuMuon.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dPickerNgayLap)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private ADGV.AdvancedDataGridView ADGVDSTB;
        private DevComponents.DotNetBar.RibbonBar ribbonBar1;
        private DevComponents.DotNetBar.ButtonItem btnLayTB;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.Panel pnlTTPhieuMuon;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private DevComponents.DotNetBar.Layout.LayoutControl layoutControl1;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx txtGhiChu;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dPickerNgayLap;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSoPhieu;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem1;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem3;
        private DevComponents.DotNetBar.Layout.LayoutSpacerItem layoutSpacerItem1;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem2;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.RibbonBar ribBarDSThietBi;
        private DevComponents.DotNetBar.ButtonItem btnLuu;
        private DevComponents.DotNetBar.ButtonItem btnXoa;
        private DevComponents.DotNetBar.ButtonItem btnHelpDSTB;
        private DevComponents.DotNetBar.ButtonItem btnClose;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}