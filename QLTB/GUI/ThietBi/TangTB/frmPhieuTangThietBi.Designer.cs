﻿namespace QLTB.GUI
{
    partial class frmPhieuTangThietBi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuTangThietBi));
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
            this.layoutTTC = new DevComponents.DotNetBar.Layout.LayoutControl();
            this.txtChungTu = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtGhiChu = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.dPickerNgayLap = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.txtSoPhieu = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.layoutControlItem1 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutControlItem3 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutSpacerItem1 = new DevComponents.DotNetBar.Layout.LayoutSpacerItem();
            this.layoutControlItem4 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutControlItem2 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
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
            this.layoutTTC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dPickerNgayLap)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(909, 499);
            this.panel1.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ADGVDSTB);
            this.panel2.Controls.Add(this.ribbonBar1);
            this.panel2.Controls.Add(this.labelX1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 298);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.panel2.Size = new System.Drawing.Size(909, 201);
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
            this.ADGVDSTB.Size = new System.Drawing.Size(903, 132);
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
            this.ribbonBar1.Location = new System.Drawing.Point(6, 34);
            this.ribbonBar1.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.ribbonBar1.Name = "ribbonBar1";
            this.ribbonBar1.ShowShortcutKeysInToolTips = true;
            this.ribbonBar1.Size = new System.Drawing.Size(903, 35);
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
            this.btnLayTB.Image = global::QLTB.Properties.Resources.add;
            this.btnLayTB.ImagePaddingVertical = 13;
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
            this.labelX1.Size = new System.Drawing.Size(903, 34);
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
            this.pnlTTPhieuMuon.Size = new System.Drawing.Size(909, 263);
            this.pnlTTPhieuMuon.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(6, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(903, 217);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.panel4.Size = new System.Drawing.Size(903, 217);
            this.panel4.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.layoutTTC);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(731, 209);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // layoutTTC
            // 
            this.layoutTTC.BackColor = System.Drawing.Color.White;
            this.layoutTTC.Controls.Add(this.txtChungTu);
            this.layoutTTC.Controls.Add(this.txtGhiChu);
            this.layoutTTC.Controls.Add(this.dPickerNgayLap);
            this.layoutTTC.Controls.Add(this.txtSoPhieu);
            this.layoutTTC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutTTC.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutTTC.ForeColor = System.Drawing.Color.Black;
            this.layoutTTC.Location = new System.Drawing.Point(3, 19);
            this.layoutTTC.Name = "layoutTTC";
            // 
            // 
            // 
            this.layoutTTC.RootGroup.Items.AddRange(new DevComponents.DotNetBar.Layout.LayoutItemBase[] {
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutSpacerItem1,
            this.layoutControlItem4,
            this.layoutControlItem2});
            this.layoutTTC.Size = new System.Drawing.Size(725, 187);
            this.layoutTTC.TabIndex = 4;
            // 
            // txtChungTu
            // 
            this.txtChungTu.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtChungTu.Border.Class = "TextBoxBorder";
            this.txtChungTu.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtChungTu.DisabledBackColor = System.Drawing.Color.White;
            this.txtChungTu.ForeColor = System.Drawing.Color.Black;
            this.txtChungTu.Location = new System.Drawing.Point(119, 45);
            this.txtChungTu.Margin = new System.Windows.Forms.Padding(0);
            this.txtChungTu.Name = "txtChungTu";
            this.txtChungTu.PreventEnterBeep = true;
            this.txtChungTu.Size = new System.Drawing.Size(577, 23);
            this.txtChungTu.TabIndex = 3;
            // 
            // txtGhiChu
            // 
            // 
            // 
            // 
            this.txtGhiChu.BackgroundStyle.Class = "RichTextBoxBorder";
            this.txtGhiChu.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtGhiChu.Location = new System.Drawing.Point(119, 86);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(0);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang1033{\\fonttbl{\\f0\\fnil\\fcharset0 Times New R" +
    "oman;}}\r\n\\viewkind4\\uc1\\pard\\f0\\fs20\\par\r\n}\r\n";
            this.txtGhiChu.Size = new System.Drawing.Size(577, 92);
            this.txtGhiChu.TabIndex = 4;
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
            this.dPickerNgayLap.Location = new System.Drawing.Point(413, 4);
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
            this.dPickerNgayLap.Size = new System.Drawing.Size(167, 21);
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
            this.txtSoPhieu.Location = new System.Drawing.Point(119, 4);
            this.txtSoPhieu.Margin = new System.Windows.Forms.Padding(0);
            this.txtSoPhieu.Name = "txtSoPhieu";
            this.txtSoPhieu.PreventEnterBeep = true;
            this.txtSoPhieu.Size = new System.Drawing.Size(169, 21);
            this.txtSoPhieu.TabIndex = 0;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtSoPhieu;
            this.layoutControlItem1.Height = 41;
            this.layoutControlItem1.MinSize = new System.Drawing.Size(162, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Text = "<b>Số phiếu <font color=\"#ED1C24\">(*)</font></b>";
            this.layoutControlItem1.Width = 292;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.dPickerNgayLap;
            this.layoutControlItem3.Height = 41;
            this.layoutControlItem3.MinSize = new System.Drawing.Size(86, 22);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Text = "<b>Ngày ghi tăng <font color=\"#ED1C24\">(*)</font></b>";
            this.layoutControlItem3.TextControlSpacing = 5;
            this.layoutControlItem3.Width = 292;
            // 
            // layoutSpacerItem1
            // 
            this.layoutSpacerItem1.Height = 36;
            this.layoutSpacerItem1.Name = "layoutSpacerItem1";
            this.layoutSpacerItem1.Width = 100;
            this.layoutSpacerItem1.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtChungTu;
            this.layoutControlItem4.Height = 41;
            this.layoutControlItem4.MinSize = new System.Drawing.Size(139, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Text = "<b>Chứng từ liên quan</b>";
            this.layoutControlItem4.Width = 700;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtGhiChu;
            this.layoutControlItem2.Height = 100;
            this.layoutControlItem2.MinSize = new System.Drawing.Size(74, 20);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Text = "<b>Ghi chú</b>";
            this.layoutControlItem2.Width = 700;
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
            this.labelX2.Size = new System.Drawing.Size(903, 46);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "Ghi tăng thiết bị";
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
            this.ribBarDSThietBi.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.ribBarDSThietBi.Name = "ribBarDSThietBi";
            this.ribBarDSThietBi.ShowShortcutKeysInToolTips = true;
            this.ribBarDSThietBi.Size = new System.Drawing.Size(909, 35);
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
            this.btnXoa.Tooltip = "Xóa thiết bị";
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
            // frmPhieuTangThietBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(909, 499);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmPhieuTangThietBi";
            this.ShowIcon = false;
            this.Text = "Phiếu tăng thiết bị";
            this.Load += new System.EventHandler(this.frmPhieuTangThietBi_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPhieuTangThietBi_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ADGVDSTB)).EndInit();
            this.pnlTTPhieuMuon.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.layoutTTC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dPickerNgayLap)).EndInit();
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
        private DevComponents.DotNetBar.Layout.LayoutControl layoutTTC;
        private DevComponents.DotNetBar.Controls.TextBoxX txtChungTu;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx txtGhiChu;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dPickerNgayLap;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSoPhieu;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem1;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem3;
        private DevComponents.DotNetBar.Layout.LayoutSpacerItem layoutSpacerItem1;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem4;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem2;
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