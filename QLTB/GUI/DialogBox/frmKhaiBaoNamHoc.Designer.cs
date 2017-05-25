namespace QLTB.GUI
{
    partial class frmKhaiBaoNamHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhaiBaoNamHoc));
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.dpickerEndYear = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dpickerStart2nd = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dpickerStart1st = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtEndYear = new System.Windows.Forms.NumericUpDown();
            this.txtStartYear = new System.Windows.Forms.NumericUpDown();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.txtGhiChu = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dpickerEndYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpickerStart2nd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpickerStart1st)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartYear)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Image = global::QLTB.Properties.Resources.tick;
            this.btnSave.Location = new System.Drawing.Point(177, 11);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 27);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Image = global::QLTB.Properties.Resources.b_drop;
            this.btnCancel.Location = new System.Drawing.Point(274, 11);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 27);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Hủy bỏ";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.ForeColor = System.Drawing.Color.Black;
            this.labelX4.Location = new System.Drawing.Point(13, 170);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(124, 27);
            this.labelX4.TabIndex = 8;
            this.labelX4.Text = "<b>Kết thúc năm học <font color=\"#ED1C24\">(*)</font></b>";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.ForeColor = System.Drawing.Color.Black;
            this.labelX3.Location = new System.Drawing.Point(13, 119);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(124, 27);
            this.labelX3.TabIndex = 7;
            this.labelX3.Text = "<b>Bắt đầu HKII <font color=\"#ED1C24\">(*)</font></b>";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(13, 71);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(124, 27);
            this.labelX2.TabIndex = 6;
            this.labelX2.Text = "<b>Bắt đầu HKI <font color=\"#ED1C24\">(*)</font></b>";
            // 
            // dpickerEndYear
            // 
            // 
            // 
            // 
            this.dpickerEndYear.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dpickerEndYear.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dpickerEndYear.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dpickerEndYear.ButtonDropDown.Visible = true;
            this.dpickerEndYear.CustomFormat = "dd/mm/yyyy";
            this.dpickerEndYear.IsPopupCalendarOpen = false;
            this.dpickerEndYear.Location = new System.Drawing.Point(143, 170);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dpickerEndYear.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dpickerEndYear.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dpickerEndYear.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dpickerEndYear.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dpickerEndYear.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dpickerEndYear.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dpickerEndYear.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dpickerEndYear.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dpickerEndYear.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dpickerEndYear.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dpickerEndYear.MonthCalendar.DisplayMonth = new System.DateTime(2017, 5, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.dpickerEndYear.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dpickerEndYear.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dpickerEndYear.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dpickerEndYear.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dpickerEndYear.MonthCalendar.TodayButtonVisible = true;
            this.dpickerEndYear.Name = "dpickerEndYear";
            this.dpickerEndYear.Size = new System.Drawing.Size(135, 23);
            this.dpickerEndYear.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dpickerEndYear.TabIndex = 5;
            this.dpickerEndYear.WatermarkText = "dd/mm/yyyy";
            // 
            // dpickerStart2nd
            // 
            // 
            // 
            // 
            this.dpickerStart2nd.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dpickerStart2nd.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dpickerStart2nd.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dpickerStart2nd.ButtonDropDown.Visible = true;
            this.dpickerStart2nd.CustomFormat = "dd/mm/yyyy";
            this.dpickerStart2nd.IsPopupCalendarOpen = false;
            this.dpickerStart2nd.Location = new System.Drawing.Point(143, 125);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dpickerStart2nd.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dpickerStart2nd.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dpickerStart2nd.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dpickerStart2nd.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dpickerStart2nd.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dpickerStart2nd.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dpickerStart2nd.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dpickerStart2nd.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dpickerStart2nd.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dpickerStart2nd.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dpickerStart2nd.MonthCalendar.DisplayMonth = new System.DateTime(2017, 5, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.dpickerStart2nd.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dpickerStart2nd.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dpickerStart2nd.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dpickerStart2nd.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dpickerStart2nd.MonthCalendar.TodayButtonVisible = true;
            this.dpickerStart2nd.Name = "dpickerStart2nd";
            this.dpickerStart2nd.Size = new System.Drawing.Size(135, 23);
            this.dpickerStart2nd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dpickerStart2nd.TabIndex = 4;
            this.dpickerStart2nd.WatermarkText = "dd/mm/yyyy";
            // 
            // dpickerStart1st
            // 
            // 
            // 
            // 
            this.dpickerStart1st.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dpickerStart1st.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dpickerStart1st.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dpickerStart1st.ButtonDropDown.Visible = true;
            this.dpickerStart1st.CustomFormat = "dd/mm/yyyy";
            this.dpickerStart1st.IsPopupCalendarOpen = false;
            this.dpickerStart1st.Location = new System.Drawing.Point(143, 75);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dpickerStart1st.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dpickerStart1st.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dpickerStart1st.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dpickerStart1st.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dpickerStart1st.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dpickerStart1st.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dpickerStart1st.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dpickerStart1st.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dpickerStart1st.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dpickerStart1st.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dpickerStart1st.MonthCalendar.DisplayMonth = new System.DateTime(2017, 5, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.dpickerStart1st.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dpickerStart1st.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dpickerStart1st.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dpickerStart1st.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dpickerStart1st.MonthCalendar.TodayButtonVisible = true;
            this.dpickerStart1st.Name = "dpickerStart1st";
            this.dpickerStart1st.Size = new System.Drawing.Size(135, 23);
            this.dpickerStart1st.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dpickerStart1st.TabIndex = 3;
            this.dpickerStart1st.WatermarkText = "dd/mm/yyyy";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(13, 21);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(124, 27);
            this.labelX1.TabIndex = 2;
            this.labelX1.Text = "<b>Năm học <font color=\"#ED1C24\">(*)</font></b>";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtEndYear);
            this.panel1.Controls.Add(this.txtStartYear);
            this.panel1.Controls.Add(this.labelX5);
            this.panel1.Controls.Add(this.txtGhiChu);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.labelX1);
            this.panel1.Controls.Add(this.dpickerStart1st);
            this.panel1.Controls.Add(this.labelX4);
            this.panel1.Controls.Add(this.dpickerStart2nd);
            this.panel1.Controls.Add(this.labelX3);
            this.panel1.Controls.Add(this.dpickerEndYear);
            this.panel1.Controls.Add(this.labelX2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 374);
            this.panel1.TabIndex = 4;
            // 
            // txtEndYear
            // 
            this.txtEndYear.Enabled = false;
            this.txtEndYear.Location = new System.Drawing.Point(213, 25);
            this.txtEndYear.Maximum = new decimal(new int[] {
            3001,
            0,
            0,
            0});
            this.txtEndYear.Name = "txtEndYear";
            this.txtEndYear.Size = new System.Drawing.Size(65, 23);
            this.txtEndYear.TabIndex = 13;
            this.txtEndYear.Value = new decimal(new int[] {
            2001,
            0,
            0,
            0});
            // 
            // txtStartYear
            // 
            this.txtStartYear.Location = new System.Drawing.Point(143, 25);
            this.txtStartYear.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.txtStartYear.Name = "txtStartYear";
            this.txtStartYear.Size = new System.Drawing.Size(64, 23);
            this.txtStartYear.TabIndex = 12;
            this.txtStartYear.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.txtStartYear.ValueChanged += new System.EventHandler(this.txtStartYear_ValueChanged);
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.ForeColor = System.Drawing.Color.Black;
            this.labelX5.Location = new System.Drawing.Point(13, 216);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(124, 27);
            this.labelX5.TabIndex = 11;
            this.labelX5.Text = "<b>Ghi chú </b>";
            // 
            // txtGhiChu
            // 
            // 
            // 
            // 
            this.txtGhiChu.BackgroundStyle.Class = "RichTextBoxBorder";
            this.txtGhiChu.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtGhiChu.Location = new System.Drawing.Point(143, 216);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang1033{\\fonttbl{\\f0\\fnil\\fcharset0 Times New R" +
    "oman;}}\r\n\\viewkind4\\uc1\\pard\\f0\\fs20\\par\r\n}\r\n";
            this.txtGhiChu.Size = new System.Drawing.Size(221, 100);
            this.txtGhiChu.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 328);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(373, 46);
            this.panel2.TabIndex = 9;
            // 
            // frmKhaiBaoNamHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(373, 374);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmKhaiBaoNamHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Khai báo năm học";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmKhaiBaoNamHoc_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dpickerEndYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpickerStart2nd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpickerStart1st)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtEndYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartYear)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dpickerEndYear;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dpickerStart2nd;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dpickerStart1st;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx txtGhiChu;
        private System.Windows.Forms.NumericUpDown txtEndYear;
        private System.Windows.Forms.NumericUpDown txtStartYear;
    }
}