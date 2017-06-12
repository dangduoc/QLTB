namespace QLTB.GUI
{
    partial class frmChiTietSuaChuaTB
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.btnLayTB = new DevComponents.DotNetBar.ButtonItem();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.pnlTTPhieuMuon = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.layoutControl2 = new DevComponents.DotNetBar.Layout.LayoutControl();
            this.richTextBoxEx2 = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.dateTimeInput2 = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.layoutControlItem3 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutControlItem4 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutSpacerItem2 = new DevComponents.DotNetBar.Layout.LayoutSpacerItem();
            this.layoutControlItem6 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.ribBarDSThietBi = new DevComponents.DotNetBar.RibbonBar();
            this.btnLuu = new DevComponents.DotNetBar.ButtonItem();
            this.btnXoa = new DevComponents.DotNetBar.ButtonItem();
            this.btnHelpDSTB = new DevComponents.DotNetBar.ButtonItem();
            this.btnClose = new DevComponents.DotNetBar.ButtonItem();
            this.ADGVDSTB = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlTTPhieuMuon.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInput2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ADGVDSTB)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1015, 545);
            this.panel1.TabIndex = 29;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ADGVDSTB);
            this.panel2.Controls.Add(this.ribbonBar1);
            this.panel2.Controls.Add(this.labelX1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 264);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.panel2.Size = new System.Drawing.Size(1015, 281);
            this.panel2.TabIndex = 20;
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
            this.ribbonBar1.Size = new System.Drawing.Size(1010, 34);
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
            this.labelX1.Size = new System.Drawing.Size(1010, 30);
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
            this.pnlTTPhieuMuon.Size = new System.Drawing.Size(1015, 230);
            this.pnlTTPhieuMuon.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(5, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1010, 190);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.panel4.Size = new System.Drawing.Size(1010, 190);
            this.panel4.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.layoutControl2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(733, 171);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.richTextBoxEx2);
            this.layoutControl2.Controls.Add(this.dateTimeInput2);
            this.layoutControl2.Controls.Add(this.textBoxX1);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControl2.Location = new System.Drawing.Point(3, 19);
            this.layoutControl2.Name = "layoutControl2";
            // 
            // 
            // 
            this.layoutControl2.RootGroup.Items.AddRange(new DevComponents.DotNetBar.Layout.LayoutItemBase[] {
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutSpacerItem2,
            this.layoutControlItem6});
            this.layoutControl2.Size = new System.Drawing.Size(727, 149);
            this.layoutControl2.TabIndex = 5;
            // 
            // richTextBoxEx2
            // 
            // 
            // 
            // 
            this.richTextBoxEx2.BackgroundStyle.Class = "RichTextBoxBorder";
            this.richTextBoxEx2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.richTextBoxEx2.Location = new System.Drawing.Point(77, 40);
            this.richTextBoxEx2.Margin = new System.Windows.Forms.Padding(0);
            this.richTextBoxEx2.Name = "richTextBoxEx2";
            this.richTextBoxEx2.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang1033{\\fonttbl{\\f0\\fnil\\fcharset0 Times New R" +
    "oman;}}\r\n\\viewkind4\\uc1\\pard\\f0\\fs20\\par\r\n}\r\n";
            this.richTextBoxEx2.Size = new System.Drawing.Size(619, 92);
            this.richTextBoxEx2.TabIndex = 3;
            // 
            // dateTimeInput2
            // 
            // 
            // 
            // 
            this.dateTimeInput2.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateTimeInput2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInput2.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateTimeInput2.ButtonDropDown.Visible = true;
            this.dateTimeInput2.CustomFormat = "dd/mm/yyyy";
            this.dateTimeInput2.IsPopupCalendarOpen = false;
            this.dateTimeInput2.Location = new System.Drawing.Point(369, 4);
            this.dateTimeInput2.Margin = new System.Windows.Forms.Padding(0);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dateTimeInput2.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInput2.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dateTimeInput2.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dateTimeInput2.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dateTimeInput2.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeInput2.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dateTimeInput2.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dateTimeInput2.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dateTimeInput2.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dateTimeInput2.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInput2.MonthCalendar.DisplayMonth = new System.DateTime(2017, 5, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.dateTimeInput2.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dateTimeInput2.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeInput2.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dateTimeInput2.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInput2.MonthCalendar.TodayButtonVisible = true;
            this.dateTimeInput2.Name = "dateTimeInput2";
            this.dateTimeInput2.Size = new System.Drawing.Size(176, 23);
            this.dateTimeInput2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dateTimeInput2.TabIndex = 1;
            this.dateTimeInput2.WatermarkText = "dd/mm/yyyy";
            // 
            // textBoxX1
            // 
            // 
            // 
            // 
            this.textBoxX1.Border.Class = "TextBoxBorder";
            this.textBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX1.Location = new System.Drawing.Point(77, 4);
            this.textBoxX1.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.PreventEnterBeep = true;
            this.textBoxX1.Size = new System.Drawing.Size(211, 23);
            this.textBoxX1.TabIndex = 0;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.textBoxX1;
            this.layoutControlItem3.Height = 35;
            this.layoutControlItem3.MinSize = new System.Drawing.Size(139, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Text = "<b>Số phiếu <font color=\"#ED1C24\">(*)</font></b>";
            this.layoutControlItem3.Width = 292;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.dateTimeInput2;
            this.layoutControlItem4.Height = 35;
            this.layoutControlItem4.MinSize = new System.Drawing.Size(74, 20);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Text = "<b>Ngày lập <font color=\"#ED1C24\">(*)</font></b>";
            this.layoutControlItem4.Width = 257;
            // 
            // layoutSpacerItem2
            // 
            this.layoutSpacerItem2.Height = 36;
            this.layoutSpacerItem2.Name = "layoutSpacerItem2";
            this.layoutSpacerItem2.Width = 100;
            this.layoutSpacerItem2.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.richTextBoxEx2;
            this.layoutControlItem6.Height = 100;
            this.layoutControlItem6.MinSize = new System.Drawing.Size(74, 20);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Text = "<b>Ghi chú</b>";
            this.layoutControlItem6.Width = 700;
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
            this.labelX2.Size = new System.Drawing.Size(1010, 40);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "Đề nghị sửa chữa thiết bị";
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
            this.ribBarDSThietBi.Size = new System.Drawing.Size(1015, 34);
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
            this.btnLuu.SubItemsExpandWidth = 14;
            this.btnLuu.Text = "Lưu";
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
            this.ADGVDSTB.Size = new System.Drawing.Size(1010, 217);
            this.ADGVDSTB.TabIndex = 15;
            // 
            // frmChiTietSuaChuaTB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1015, 545);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmChiTietSuaChuaTB";
            this.Text = "Theo dõi việc sửa chữa thiết bị";
            this.Load += new System.EventHandler(this.frmChiTietSuaChuaTB_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnlTTPhieuMuon.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInput2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ADGVDSTB)).EndInit();
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
        private DevComponents.DotNetBar.Controls.RichTextBoxEx richTextBoxEx2;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateTimeInput2;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem3;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem4;
        private DevComponents.DotNetBar.Layout.LayoutSpacerItem layoutSpacerItem2;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem6;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.RibbonBar ribBarDSThietBi;
        private DevComponents.DotNetBar.ButtonItem btnLuu;
        private DevComponents.DotNetBar.ButtonItem btnXoa;
        private DevComponents.DotNetBar.ButtonItem btnHelpDSTB;
        private DevComponents.DotNetBar.ButtonItem btnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView ADGVDSTB;
    }
}