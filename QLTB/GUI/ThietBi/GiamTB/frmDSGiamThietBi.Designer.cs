namespace QLTB.GUI
{
    partial class frmDSGiamThietBi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDSGiamThietBi));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rbChucNang = new DevComponents.DotNetBar.RibbonBar();
            this.btnThem = new DevComponents.DotNetBar.ButtonItem();
            this.btnSua = new DevComponents.DotNetBar.ButtonItem();
            this.btnXoa = new DevComponents.DotNetBar.ButtonItem();
            this.btnNap = new DevComponents.DotNetBar.ButtonItem();
            this.btnIn = new DevComponents.DotNetBar.ButtonItem();
            this.btnTroGiup = new DevComponents.DotNetBar.ButtonItem();
            this.btnThoat = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.pnlBack = new DevComponents.DotNetBar.PanelEx();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.panelEx3 = new DevComponents.DotNetBar.PanelEx();
            this.advancedDataGridView = new ADGV.AdvancedDataGridView();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.searchToolBar = new ADGV.SearchToolBar();
            this.pnlBack.SuspendLayout();
            this.panelEx1.SuspendLayout();
            this.panelEx3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView)).BeginInit();
            this.panelEx2.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbChucNang
            // 
            this.rbChucNang.AutoOverflowEnabled = true;
            this.rbChucNang.BackColor = System.Drawing.Color.Transparent;
            this.rbChucNang.BackgroundHoverEnabled = false;
            // 
            // 
            // 
            this.rbChucNang.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rbChucNang.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rbChucNang.ContainerControlProcessDialogKey = true;
            this.rbChucNang.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbChucNang.DragDropSupport = true;
            this.rbChucNang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
            this.rbChucNang.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnNap,
            this.btnIn,
            this.btnTroGiup,
            this.btnThoat});
            this.rbChucNang.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.rbChucNang.Location = new System.Drawing.Point(0, 0);
            this.rbChucNang.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.rbChucNang.Name = "rbChucNang";
            this.rbChucNang.ShowShortcutKeysInToolTips = true;
            this.rbChucNang.Size = new System.Drawing.Size(756, 80);
            this.rbChucNang.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.rbChucNang.TabIndex = 13;
            // 
            // 
            // 
            this.rbChucNang.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rbChucNang.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnThem
            // 
            this.btnThem.BeginGroup = true;
            this.btnThem.Image = global::QLTB.Properties.Resources.add1;
            this.btnThem.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnThem.Name = "btnThem";
            this.btnThem.SubItemsExpandWidth = 14;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = global::QLTB.Properties.Resources.edit;
            this.btnSua.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnSua.Name = "btnSua";
            this.btnSua.SubItemsExpandWidth = 14;
            this.btnSua.Text = "Sửa";
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlD);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Tooltip = "Xóa đối tượng";
            // 
            // btnNap
            // 
            this.btnNap.BeginGroup = true;
            this.btnNap.Image = global::QLTB.Properties.Resources.reload_f2;
            this.btnNap.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnNap.Name = "btnNap";
            this.btnNap.SubItemsExpandWidth = 14;
            this.btnNap.Text = "Nạp";
            // 
            // btnIn
            // 
            this.btnIn.BeginGroup = true;
            this.btnIn.Image = global::QLTB.Properties.Resources.icon_pagesetup;
            this.btnIn.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnIn.Name = "btnIn";
            this.btnIn.SubItemsExpandWidth = 14;
            this.btnIn.Text = "In";
            // 
            // btnTroGiup
            // 
            this.btnTroGiup.BeginGroup = true;
            this.btnTroGiup.Image = global::QLTB.Properties.Resources.icon_about;
            this.btnTroGiup.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnTroGiup.Name = "btnTroGiup";
            this.btnTroGiup.RibbonWordWrap = false;
            this.btnTroGiup.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F1);
            this.btnTroGiup.Text = "Trợ giúp";
            this.btnTroGiup.Tooltip = "Thông tin trợ giúp";
            // 
            // btnThoat
            // 
            this.btnThoat.BeginGroup = true;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlF4);
            this.btnThoat.ShowSubItems = false;
            this.btnThoat.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem1});
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Tooltip = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // buttonItem1
            // 
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.Text = "buttonItem1";
            // 
            // pnlBack
            // 
            this.pnlBack.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlBack.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnlBack.Controls.Add(this.panelEx1);
            this.pnlBack.Controls.Add(this.searchToolBar);
            this.pnlBack.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnlBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBack.Location = new System.Drawing.Point(0, 80);
            this.pnlBack.Name = "pnlBack";
            this.pnlBack.Size = new System.Drawing.Size(756, 320);
            this.pnlBack.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlBack.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnlBack.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnlBack.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnlBack.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlBack.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlBack.Style.GradientAngle = 90;
            this.pnlBack.TabIndex = 38;
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
            this.panelEx1.Size = new System.Drawing.Size(756, 289);
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
            this.panelEx3.Controls.Add(this.advancedDataGridView);
            this.panelEx3.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx3.Location = new System.Drawing.Point(0, 0);
            this.panelEx3.Name = "panelEx3";
            this.panelEx3.Size = new System.Drawing.Size(756, 244);
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
            // advancedDataGridView
            // 
            this.advancedDataGridView.AllowUserToAddRows = false;
            this.advancedDataGridView.AllowUserToDeleteRows = false;
            this.advancedDataGridView.AutoGenerateContextFilters = true;
            this.advancedDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.advancedDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.advancedDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.advancedDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.advancedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advancedDataGridView.DateWithTime = false;
            this.advancedDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.advancedDataGridView.Location = new System.Drawing.Point(0, 0);
            this.advancedDataGridView.Name = "advancedDataGridView";
            this.advancedDataGridView.ReadOnly = true;
            this.advancedDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.advancedDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.advancedDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.advancedDataGridView.Size = new System.Drawing.Size(756, 244);
            this.advancedDataGridView.TabIndex = 27;
            this.advancedDataGridView.TimeFilter = false;
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.statusStrip2);
            this.panelEx2.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEx2.Location = new System.Drawing.Point(0, 244);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(756, 45);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 28;
            // 
            // statusStrip2
            // 
            this.statusStrip2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.statusStrip2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip2.Location = new System.Drawing.Point(0, 0);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip2.Size = new System.Drawing.Size(756, 45);
            this.statusStrip2.TabIndex = 0;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Arial", 9F);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(124, 40);
            this.toolStripStatusLabel1.Text = "Tổng số thiết bị: 9";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.ForeColor = System.Drawing.Color.Red;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(44, 40);
            this.toolStripStatusLabel2.Text = "Chú ý: ";
            // 
            // searchToolBar
            // 
            this.searchToolBar.AllowMerge = false;
            this.searchToolBar.Font = new System.Drawing.Font("Arial", 9F);
            this.searchToolBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.searchToolBar.Location = new System.Drawing.Point(0, 0);
            this.searchToolBar.MaximumSize = new System.Drawing.Size(0, 31);
            this.searchToolBar.MinimumSize = new System.Drawing.Size(0, 31);
            this.searchToolBar.Name = "searchToolBar";
            this.searchToolBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.searchToolBar.Size = new System.Drawing.Size(756, 31);
            this.searchToolBar.TabIndex = 28;
            this.searchToolBar.Text = "searchToolBar1";
            // 
            // frmDSGiamThietBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 400);
            this.Controls.Add(this.pnlBack);
            this.Controls.Add(this.rbChucNang);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmDSGiamThietBi";
            this.Text = "frmDSGiamThietBi";
            this.Load += new System.EventHandler(this.frmDSGiamThietBi_Load);
            this.pnlBack.ResumeLayout(false);
            this.pnlBack.PerformLayout();
            this.panelEx1.ResumeLayout(false);
            this.panelEx3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView)).EndInit();
            this.panelEx2.ResumeLayout(false);
            this.panelEx2.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.RibbonBar rbChucNang;
        private DevComponents.DotNetBar.ButtonItem btnThem;
        private DevComponents.DotNetBar.ButtonItem btnSua;
        private DevComponents.DotNetBar.ButtonItem btnXoa;
        private DevComponents.DotNetBar.ButtonItem btnNap;
        private DevComponents.DotNetBar.ButtonItem btnIn;
        private DevComponents.DotNetBar.ButtonItem btnTroGiup;
        private DevComponents.DotNetBar.ButtonItem btnThoat;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.PanelEx pnlBack;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.PanelEx panelEx3;
        private ADGV.AdvancedDataGridView advancedDataGridView;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private ADGV.SearchToolBar searchToolBar;
    }
}