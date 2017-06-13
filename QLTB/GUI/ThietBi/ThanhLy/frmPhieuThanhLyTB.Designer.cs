namespace QLTB.GUI
{
    partial class frmPhieuThanhLyTB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuThanhLyTB));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ADGVDSTB = new System.Windows.Forms.DataGridView();
            this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.btnLayTB = new DevComponents.DotNetBar.ButtonItem();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.pnlTTPhieuMuon = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.layoutControl2 = new DevComponents.DotNetBar.Layout.LayoutControl();
            this.txtHoiDongThanhLy = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.txtDiaDiem = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtNoiDung = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.dpickerNgayLap = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.txtSoPhieu = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.layoutControlItem6 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutControlItem7 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutSpacerItem2 = new DevComponents.DotNetBar.Layout.LayoutSpacerItem();
            this.layoutControlItem8 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutControlItem9 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutControlItem10 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.ribBarDSThietBi = new DevComponents.DotNetBar.RibbonBar();
            this.btnLuu = new DevComponents.DotNetBar.ButtonItem();
            this.btnXoa = new DevComponents.DotNetBar.ButtonItem();
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
            this.layoutControl2.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(961, 491);
            this.panel1.TabIndex = 33;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ADGVDSTB);
            this.panel2.Controls.Add(this.ribbonBar1);
            this.panel2.Controls.Add(this.labelX1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 342);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.panel2.Size = new System.Drawing.Size(961, 149);
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
            this.ADGVDSTB.Location = new System.Drawing.Point(5, 64);
            this.ADGVDSTB.Name = "ADGVDSTB";
            this.ADGVDSTB.Size = new System.Drawing.Size(956, 85);
            this.ADGVDSTB.TabIndex = 15;
            this.ADGVDSTB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ADGVDSTB_CellContentClick);
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
            this.ribbonBar1.Size = new System.Drawing.Size(956, 34);
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
            this.btnLayTB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLayTB.Image = global::QLTB.Properties.Resources.cancel16;
            this.btnLayTB.ImagePaddingVertical = 13;
            this.btnLayTB.Name = "btnLayTB";
            this.btnLayTB.SubItemsExpandWidth = 14;
            this.btnLayTB.Text = "Chọn từ danh sách thiết bị hỏng";
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
            this.labelX1.Location = new System.Drawing.Point(5, 0);
            this.labelX1.Name = "labelX1";
            this.labelX1.PaddingLeft = 15;
            this.labelX1.Size = new System.Drawing.Size(956, 30);
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
            this.pnlTTPhieuMuon.Size = new System.Drawing.Size(961, 308);
            this.pnlTTPhieuMuon.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(5, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(956, 268);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.panel4.Size = new System.Drawing.Size(956, 268);
            this.panel4.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.layoutControl2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 3, 20, 3);
            this.groupBox1.Size = new System.Drawing.Size(926, 256);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // layoutControl2
            // 
            this.layoutControl2.BackColor = System.Drawing.Color.White;
            this.layoutControl2.Controls.Add(this.txtHoiDongThanhLy);
            this.layoutControl2.Controls.Add(this.txtDiaDiem);
            this.layoutControl2.Controls.Add(this.txtNoiDung);
            this.layoutControl2.Controls.Add(this.dpickerNgayLap);
            this.layoutControl2.Controls.Add(this.txtSoPhieu);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControl2.ForeColor = System.Drawing.Color.Black;
            this.layoutControl2.Location = new System.Drawing.Point(5, 19);
            this.layoutControl2.Name = "layoutControl2";
            // 
            // 
            // 
            this.layoutControl2.RootGroup.Items.AddRange(new DevComponents.DotNetBar.Layout.LayoutItemBase[] {
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutSpacerItem2,
            this.layoutControlItem8,
            this.layoutControlItem9,
            this.layoutControlItem10});
            this.layoutControl2.Size = new System.Drawing.Size(901, 234);
            this.layoutControl2.TabIndex = 5;
            // 
            // txtHoiDongThanhLy
            // 
            // 
            // 
            // 
            this.txtHoiDongThanhLy.BackgroundStyle.Class = "RichTextBoxBorder";
            this.txtHoiDongThanhLy.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtHoiDongThanhLy.Location = new System.Drawing.Point(111, 75);
            this.txtHoiDongThanhLy.Margin = new System.Windows.Forms.Padding(0);
            this.txtHoiDongThanhLy.Name = "txtHoiDongThanhLy";
            this.txtHoiDongThanhLy.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang1033{\\fonttbl{\\f0\\fnil\\fcharset0 Times New R" +
    "oman;}}\r\n\\viewkind4\\uc1\\pard\\f0\\fs20\\par\r\n}\r\n";
            this.txtHoiDongThanhLy.Size = new System.Drawing.Size(786, 42);
            this.txtHoiDongThanhLy.TabIndex = 4;
            // 
            // txtDiaDiem
            // 
            this.txtDiaDiem.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtDiaDiem.Border.Class = "TextBoxBorder";
            this.txtDiaDiem.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDiaDiem.DisabledBackColor = System.Drawing.Color.White;
            this.txtDiaDiem.ForeColor = System.Drawing.Color.Black;
            this.txtDiaDiem.Location = new System.Drawing.Point(111, 40);
            this.txtDiaDiem.Margin = new System.Windows.Forms.Padding(0);
            this.txtDiaDiem.Name = "txtDiaDiem";
            this.txtDiaDiem.PreventEnterBeep = true;
            this.txtDiaDiem.Size = new System.Drawing.Size(786, 23);
            this.txtDiaDiem.TabIndex = 3;
            // 
            // txtNoiDung
            // 
            // 
            // 
            // 
            this.txtNoiDung.BackgroundStyle.Class = "RichTextBoxBorder";
            this.txtNoiDung.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNoiDung.Location = new System.Drawing.Point(111, 125);
            this.txtNoiDung.Margin = new System.Windows.Forms.Padding(0);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang1033{\\fonttbl{\\f0\\fnil\\fcharset0 Times New R" +
    "oman;}}\r\n\\viewkind4\\uc1\\pard\\f0\\fs20\\par\r\n}\r\n";
            this.txtNoiDung.Size = new System.Drawing.Size(786, 92);
            this.txtNoiDung.TabIndex = 5;
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
            this.dpickerNgayLap.IsPopupCalendarOpen = false;
            this.dpickerNgayLap.Location = new System.Drawing.Point(403, 4);
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
            this.dpickerNgayLap.Size = new System.Drawing.Size(142, 23);
            this.dpickerNgayLap.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dpickerNgayLap.TabIndex = 1;
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
            this.txtSoPhieu.Enabled = false;
            this.txtSoPhieu.ForeColor = System.Drawing.Color.Black;
            this.txtSoPhieu.Location = new System.Drawing.Point(111, 4);
            this.txtSoPhieu.Margin = new System.Windows.Forms.Padding(0);
            this.txtSoPhieu.Name = "txtSoPhieu";
            this.txtSoPhieu.PreventEnterBeep = true;
            this.txtSoPhieu.Size = new System.Drawing.Size(177, 23);
            this.txtSoPhieu.TabIndex = 0;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txtSoPhieu;
            this.layoutControlItem6.Height = 35;
            this.layoutControlItem6.MinSize = new System.Drawing.Size(139, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Text = "<b>Số phiếu <font color=\"#ED1C24\">(*)</font></b>";
            this.layoutControlItem6.Width = 292;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.dpickerNgayLap;
            this.layoutControlItem7.Height = 35;
            this.layoutControlItem7.MinSize = new System.Drawing.Size(74, 20);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Text = "<b>Ngày lập <font color=\"#ED1C24\">(*)</font></b>";
            this.layoutControlItem7.Width = 257;
            // 
            // layoutSpacerItem2
            // 
            this.layoutSpacerItem2.Height = 36;
            this.layoutSpacerItem2.Name = "layoutSpacerItem2";
            this.layoutSpacerItem2.Width = 100;
            this.layoutSpacerItem2.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.txtDiaDiem;
            this.layoutControlItem8.Height = 35;
            this.layoutControlItem8.MinSize = new System.Drawing.Size(139, 0);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Text = "<b>Địa điểm</b>";
            this.layoutControlItem8.Width = 100;
            this.layoutControlItem8.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.txtHoiDongThanhLy;
            this.layoutControlItem9.Height = 50;
            this.layoutControlItem9.MinSize = new System.Drawing.Size(74, 20);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Text = "<b>Hội đồng thanh lý</b>";
            this.layoutControlItem9.Width = 100;
            this.layoutControlItem9.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.txtNoiDung;
            this.layoutControlItem10.Height = 100;
            this.layoutControlItem10.MinSize = new System.Drawing.Size(74, 20);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Text = "<b>Nội dung</b>";
            this.layoutControlItem10.Width = 100;
            this.layoutControlItem10.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
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
            this.labelX2.Size = new System.Drawing.Size(956, 40);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "Phiếu thanh lý thiết bị";
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
            this.ribBarDSThietBi.Size = new System.Drawing.Size(961, 34);
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
            // frmPhieuThanhLyTB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(961, 491);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmPhieuThanhLyTB";
            this.Text = "Phiếu thanh lý thiết bị";
            this.Load += new System.EventHandler(this.frmPhieuThanhLyTB_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPhieuThanhLyTB_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ADGVDSTB)).EndInit();
            this.pnlTTPhieuMuon.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dpickerNgayLap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevComponents.DotNetBar.RibbonBar ribbonBar1;
        private DevComponents.DotNetBar.ButtonItem btnLayTB;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.Panel pnlTTPhieuMuon;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private DevComponents.DotNetBar.Layout.LayoutControl layoutControl2;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx txtHoiDongThanhLy;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDiaDiem;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx txtNoiDung;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dpickerNgayLap;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSoPhieu;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem6;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem7;
        private DevComponents.DotNetBar.Layout.LayoutSpacerItem layoutSpacerItem2;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem8;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem9;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem10;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.RibbonBar ribBarDSThietBi;
        private DevComponents.DotNetBar.ButtonItem btnLuu;
        private DevComponents.DotNetBar.ButtonItem btnXoa;
        private DevComponents.DotNetBar.ButtonItem btnHelpDSTB;
        private DevComponents.DotNetBar.ButtonItem btnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridView ADGVDSTB;
    }
}