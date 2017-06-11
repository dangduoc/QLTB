namespace QLTB.GUI
{
    partial class frmPhieuBaoHong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuBaoHong));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ADGVDSTB = new System.Windows.Forms.DataGridView();
            this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.btnLayTB = new DevComponents.DotNetBar.ButtonItem();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.pnlTTPhieuMuon = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.layoutTTC = new DevComponents.DotNetBar.Layout.LayoutControl();
            this.txtGhiChu = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.txtNguoiLamHong = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dpickerNgayLap = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.txtSoPhieu = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.layoutControlItem5 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutControlItem6 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutSpacerItem3 = new DevComponents.DotNetBar.Layout.LayoutSpacerItem();
            this.layoutControlItem7 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutSpacerItem4 = new DevComponents.DotNetBar.Layout.LayoutSpacerItem();
            this.layoutControlItem8 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.ribBarDSThietBi = new DevComponents.DotNetBar.RibbonBar();
            this.btnLuu = new DevComponents.DotNetBar.ButtonItem();
            this.btnXoa = new DevComponents.DotNetBar.ButtonItem();
            this.btnInDSTB = new DevComponents.DotNetBar.ButtonItem();
            this.btnHelpDSTB = new DevComponents.DotNetBar.ButtonItem();
            this.btnClose = new DevComponents.DotNetBar.ButtonItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ADGVDSTB)).BeginInit();
            this.pnlTTPhieuMuon.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.layoutTTC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dpickerNgayLap)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(995, 437);
            this.panel1.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ADGVDSTB);
            this.panel2.Controls.Add(this.ribbonBar1);
            this.panel2.Controls.Add(this.labelX1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 249);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.panel2.Size = new System.Drawing.Size(995, 188);
            this.panel2.TabIndex = 20;
            // 
            // ADGVDSTB
            // 
            this.ADGVDSTB.AllowUserToAddRows = false;
            this.ADGVDSTB.AllowUserToDeleteRows = false;
            this.ADGVDSTB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ADGVDSTB.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.ADGVDSTB.BackgroundColor = System.Drawing.Color.White;
            this.ADGVDSTB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ADGVDSTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ADGVDSTB.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.ADGVDSTB.Location = new System.Drawing.Point(6, 69);
            this.ADGVDSTB.Name = "ADGVDSTB";
            this.ADGVDSTB.Size = new System.Drawing.Size(989, 119);
            this.ADGVDSTB.TabIndex = 13;
            this.ADGVDSTB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDSThietBiMuon_CellContentClick);
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
            this.buttonItem1,
            this.btnLayTB});
            this.ribbonBar1.ItemSpacing = 10;
            this.ribbonBar1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.ribbonBar1.Location = new System.Drawing.Point(6, 34);
            this.ribbonBar1.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.ribbonBar1.Name = "ribbonBar1";
            this.ribbonBar1.ShowShortcutKeysInToolTips = true;
            this.ribbonBar1.Size = new System.Drawing.Size(989, 35);
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
            // buttonItem1
            // 
            this.buttonItem1.BeginGroup = true;
            this.buttonItem1.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonItem1.Image = global::QLTB.Properties.Resources.add;
            this.buttonItem1.ImagePaddingHorizontal = 20;
            this.buttonItem1.ImagePaddingVertical = 15;
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlN);
            this.buttonItem1.Text = "Thêm";
            this.buttonItem1.Tooltip = "Đăng ký mới";
            // 
            // btnLayTB
            // 
            this.btnLayTB.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnLayTB.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnLayTB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLayTB.Image = global::QLTB.Properties.Resources.cancel16;
            this.btnLayTB.Name = "btnLayTB";
            this.btnLayTB.SubItemsExpandWidth = 14;
            this.btnLayTB.Text = "Chọn nhiều thiết bị";
            this.btnLayTB.Click += new System.EventHandler(this.btnLayTB_Click);
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
            this.labelX1.Location = new System.Drawing.Point(6, 0);
            this.labelX1.Name = "labelX1";
            this.labelX1.PaddingLeft = 15;
            this.labelX1.Size = new System.Drawing.Size(989, 34);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Danh sách thiết bị";
            // 
            // pnlTTPhieuMuon
            // 
            this.pnlTTPhieuMuon.Controls.Add(this.panel3);
            this.pnlTTPhieuMuon.Controls.Add(this.labelX2);
            this.pnlTTPhieuMuon.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTTPhieuMuon.Location = new System.Drawing.Point(0, 35);
            this.pnlTTPhieuMuon.Name = "pnlTTPhieuMuon";
            this.pnlTTPhieuMuon.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.pnlTTPhieuMuon.Size = new System.Drawing.Size(995, 214);
            this.pnlTTPhieuMuon.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(6, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(989, 168);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.panel4.Size = new System.Drawing.Size(989, 168);
            this.panel4.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.layoutTTC);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(738, 152);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // layoutTTC
            // 
            this.layoutTTC.Controls.Add(this.txtGhiChu);
            this.layoutTTC.Controls.Add(this.txtNguoiLamHong);
            this.layoutTTC.Controls.Add(this.dpickerNgayLap);
            this.layoutTTC.Controls.Add(this.txtSoPhieu);
            this.layoutTTC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutTTC.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutTTC.Location = new System.Drawing.Point(3, 19);
            this.layoutTTC.Name = "layoutTTC";
            // 
            // 
            // 
            this.layoutTTC.RootGroup.Items.AddRange(new DevComponents.DotNetBar.Layout.LayoutItemBase[] {
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutSpacerItem3,
            this.layoutControlItem7,
            this.layoutSpacerItem4,
            this.layoutControlItem8});
            this.layoutTTC.Size = new System.Drawing.Size(732, 130);
            this.layoutTTC.TabIndex = 5;
            // 
            // txtGhiChu
            // 
            // 
            // 
            // 
            this.txtGhiChu.BackgroundStyle.Class = "RichTextBoxBorder";
            this.txtGhiChu.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtGhiChu.Location = new System.Drawing.Point(126, 76);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(0);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang1033{\\fonttbl{\\f0\\fnil\\fcharset0 Times New R" +
    "oman;}}\r\n\\viewkind4\\uc1\\pard\\f0\\fs20\\par\r\n}\r\n";
            this.txtGhiChu.Size = new System.Drawing.Size(570, 42);
            this.txtGhiChu.TabIndex = 5;
            // 
            // txtNguoiLamHong
            // 
            // 
            // 
            // 
            this.txtNguoiLamHong.Border.Class = "TextBoxBorder";
            this.txtNguoiLamHong.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNguoiLamHong.Location = new System.Drawing.Point(126, 40);
            this.txtNguoiLamHong.Margin = new System.Windows.Forms.Padding(0);
            this.txtNguoiLamHong.Name = "txtNguoiLamHong";
            this.txtNguoiLamHong.PreventEnterBeep = true;
            this.txtNguoiLamHong.Size = new System.Drawing.Size(220, 23);
            this.txtNguoiLamHong.TabIndex = 3;
            // 
            // dpickerNgayLap
            // 
            // 
            // 
            // 
            this.dpickerNgayLap.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dpickerNgayLap.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dpickerNgayLap.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dpickerNgayLap.ButtonDropDown.Visible = true;
            this.dpickerNgayLap.CustomFormat = "dd/mm/yyyy";
            this.dpickerNgayLap.IsPopupCalendarOpen = false;
            this.dpickerNgayLap.Location = new System.Drawing.Point(427, 4);
            this.dpickerNgayLap.Margin = new System.Windows.Forms.Padding(0);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dpickerNgayLap.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dpickerNgayLap.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dpickerNgayLap.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dpickerNgayLap.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dpickerNgayLap.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dpickerNgayLap.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dpickerNgayLap.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dpickerNgayLap.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dpickerNgayLap.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dpickerNgayLap.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dpickerNgayLap.MonthCalendar.DisplayMonth = new System.DateTime(2017, 5, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.dpickerNgayLap.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dpickerNgayLap.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dpickerNgayLap.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dpickerNgayLap.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dpickerNgayLap.MonthCalendar.TodayButtonVisible = true;
            this.dpickerNgayLap.Name = "dpickerNgayLap";
            this.dpickerNgayLap.Size = new System.Drawing.Size(152, 23);
            this.dpickerNgayLap.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dpickerNgayLap.TabIndex = 1;
            this.dpickerNgayLap.WatermarkText = "dd/mm/yyyy";
            // 
            // txtSoPhieu
            // 
            // 
            // 
            // 
            this.txtSoPhieu.Border.Class = "TextBoxBorder";
            this.txtSoPhieu.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSoPhieu.Location = new System.Drawing.Point(126, 4);
            this.txtSoPhieu.Margin = new System.Windows.Forms.Padding(0);
            this.txtSoPhieu.Name = "txtSoPhieu";
            this.txtSoPhieu.PreventEnterBeep = true;
            this.txtSoPhieu.ReadOnly = true;
            this.txtSoPhieu.Size = new System.Drawing.Size(220, 23);
            this.txtSoPhieu.TabIndex = 0;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txtSoPhieu;
            this.layoutControlItem5.Height = 35;
            this.layoutControlItem5.MinSize = new System.Drawing.Size(139, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Text = "<b>Số phiếu <font color=\"#ED1C24\">(*)</font></b>";
            this.layoutControlItem5.Width = 350;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.dpickerNgayLap;
            this.layoutControlItem6.Height = 35;
            this.layoutControlItem6.MinSize = new System.Drawing.Size(74, 20);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.SharedTextSizeEnabled = false;
            this.layoutControlItem6.Text = "<b>Ngày lập <font color=\"#ED1C24\">(*)</font></b>";
            this.layoutControlItem6.Width = 233;
            // 
            // layoutSpacerItem3
            // 
            this.layoutSpacerItem3.Height = 36;
            this.layoutSpacerItem3.Name = "layoutSpacerItem3";
            this.layoutSpacerItem3.Width = 100;
            this.layoutSpacerItem3.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.txtNguoiLamHong;
            this.layoutControlItem7.Height = 35;
            this.layoutControlItem7.MinSize = new System.Drawing.Size(139, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Text = "<b>Người làm hỏng/mất</b>";
            this.layoutControlItem7.Width = 350;
            // 
            // layoutSpacerItem4
            // 
            this.layoutSpacerItem4.Height = 36;
            this.layoutSpacerItem4.Name = "layoutSpacerItem4";
            this.layoutSpacerItem4.Width = 100;
            this.layoutSpacerItem4.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.txtGhiChu;
            this.layoutControlItem8.Height = 50;
            this.layoutControlItem8.MinSize = new System.Drawing.Size(74, 20);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Text = "<b>Ghi chú</b>";
            this.layoutControlItem8.Width = 700;
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
            this.labelX2.Location = new System.Drawing.Point(6, 0);
            this.labelX2.Name = "labelX2";
            this.labelX2.PaddingLeft = 10;
            this.labelX2.Size = new System.Drawing.Size(989, 46);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "Phiếu báo hỏng/ mất";
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
            this.btnInDSTB,
            this.btnHelpDSTB,
            this.btnClose});
            this.ribBarDSThietBi.ItemSpacing = 10;
            this.ribBarDSThietBi.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.ribBarDSThietBi.Location = new System.Drawing.Point(0, 0);
            this.ribBarDSThietBi.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.ribBarDSThietBi.Name = "ribBarDSThietBi";
            this.ribBarDSThietBi.ShowShortcutKeysInToolTips = true;
            this.ribBarDSThietBi.Size = new System.Drawing.Size(995, 35);
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
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.Image = global::QLTB.Properties.Resources.save_icon;
            this.btnLuu.ImagePaddingVertical = 13;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS);
            this.btnLuu.SubItemsExpandWidth = 14;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
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
            this.btnClose.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = global::QLTB.Properties.Resources.close16;
            this.btnClose.Name = "btnClose";
            this.btnClose.SubItemsExpandWidth = 14;
            this.btnClose.Text = "Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "b_drop.png");
            // 
            // frmPhieuBaoHong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(995, 437);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmPhieuBaoHong";
            this.Text = "Phiếu báo mất/hỏng thiết bị";
            this.Load += new System.EventHandler(this.frmPhieuBaoHong_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPhieuBaoHong_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ADGVDSTB)).EndInit();
            this.pnlTTPhieuMuon.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.layoutTTC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dpickerNgayLap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevComponents.DotNetBar.RibbonBar ribbonBar1;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.ButtonItem btnLayTB;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.Panel pnlTTPhieuMuon;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private DevComponents.DotNetBar.Layout.LayoutControl layoutTTC;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx txtGhiChu;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNguoiLamHong;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dpickerNgayLap;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSoPhieu;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem5;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem6;
        private DevComponents.DotNetBar.Layout.LayoutSpacerItem layoutSpacerItem3;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem7;
        private DevComponents.DotNetBar.Layout.LayoutSpacerItem layoutSpacerItem4;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem8;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.RibbonBar ribBarDSThietBi;
        private DevComponents.DotNetBar.ButtonItem btnLuu;
        private DevComponents.DotNetBar.ButtonItem btnXoa;
        private DevComponents.DotNetBar.ButtonItem btnInDSTB;
        private DevComponents.DotNetBar.ButtonItem btnHelpDSTB;
        private DevComponents.DotNetBar.ButtonItem btnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView ADGVDSTB;
        private System.Windows.Forms.ImageList imageList1;
    }
}