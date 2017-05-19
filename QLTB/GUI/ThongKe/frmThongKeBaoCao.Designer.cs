namespace QLTB.GUI
{
    partial class frmThongKeBaoCao
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Thông kế tình hình mượn thiết bị theo môn học");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Thống kê tình hình mượn thiết bị theo giáo viên");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Báo cáo", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Sổ thiết bị giáo dục");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Sổ sách", new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.rbChucNang = new DevComponents.DotNetBar.RibbonBar();
            this.buttonItem2 = new DevComponents.DotNetBar.ButtonItem();
            this.btnTroGiup = new DevComponents.DotNetBar.ButtonItem();
            this.btnThoat = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.expandablePanel1 = new DevComponents.DotNetBar.ExpandablePanel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.expandablePanel1.SuspendLayout();
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
            this.rbChucNang.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.rbChucNang.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem2,
            this.btnTroGiup,
            this.btnThoat});
            this.rbChucNang.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.rbChucNang.Location = new System.Drawing.Point(0, 0);
            this.rbChucNang.Margin = new System.Windows.Forms.Padding(9, 5, 9, 5);
            this.rbChucNang.Name = "rbChucNang";
            this.rbChucNang.ShowShortcutKeysInToolTips = true;
            this.rbChucNang.Size = new System.Drawing.Size(995, 38);
            this.rbChucNang.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.rbChucNang.TabIndex = 14;
            // 
            // 
            // 
            this.rbChucNang.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rbChucNang.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // buttonItem2
            // 
            this.buttonItem2.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem2.Image = global::QLTB.Properties.Resources.tick;
            this.buttonItem2.ImagePaddingVertical = 15;
            this.buttonItem2.Name = "buttonItem2";
            this.buttonItem2.SubItemsExpandWidth = 14;
            this.buttonItem2.Text = "Xem báo cáo";
            // 
            // btnTroGiup
            // 
            this.btnTroGiup.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnTroGiup.Image = global::QLTB.Properties.Resources.Help_icon;
            this.btnTroGiup.ImagePaddingHorizontal = 20;
            this.btnTroGiup.Name = "btnTroGiup";
            this.btnTroGiup.SubItemsExpandWidth = 14;
            this.btnTroGiup.Text = "Trợ giúp";
            // 
            // btnThoat
            // 
            this.btnThoat.BeginGroup = true;
            this.btnThoat.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnThoat.Image = global::QLTB.Properties.Resources.close16;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlF4);
            this.btnThoat.ShowSubItems = false;
            this.btnThoat.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem1});
            this.btnThoat.Text = "Đóng";
            this.btnThoat.Tooltip = "Đóng";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // buttonItem1
            // 
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.Text = "buttonItem1";
            // 
            // expandablePanel1
            // 
            this.expandablePanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.expandablePanel1.CollapseDirection = DevComponents.DotNetBar.eCollapseDirection.RightToLeft;
            this.expandablePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.expandablePanel1.Controls.Add(this.treeView1);
            this.expandablePanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.expandablePanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.expandablePanel1.HideControlsWhenCollapsed = true;
            this.expandablePanel1.Location = new System.Drawing.Point(0, 38);
            this.expandablePanel1.Name = "expandablePanel1";
            this.expandablePanel1.Size = new System.Drawing.Size(319, 502);
            this.expandablePanel1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.expandablePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandablePanel1.Style.GradientAngle = 90;
            this.expandablePanel1.TabIndex = 15;
            this.expandablePanel1.TitleHeight = 30;
            this.expandablePanel1.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel1.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.expandablePanel1.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandablePanel1.TitleStyle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expandablePanel1.TitleStyle.ForeColor.Color = System.Drawing.Color.Black;
            this.expandablePanel1.TitleStyle.GradientAngle = 90;
            this.expandablePanel1.TitleStyle.MarginLeft = 5;
            this.expandablePanel1.TitleText = "Danh sách tập tin";
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.Location = new System.Drawing.Point(0, 30);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node2";
            treeNode1.Text = "Thông kế tình hình mượn thiết bị theo môn học";
            treeNode2.Name = "Node3";
            treeNode2.Text = "Thống kê tình hình mượn thiết bị theo giáo viên";
            treeNode3.Name = "Node0";
            treeNode3.Text = "Báo cáo";
            treeNode4.Name = "Node5";
            treeNode4.Text = "Sổ thiết bị giáo dục";
            treeNode5.Name = "Node1";
            treeNode5.Text = "Sổ sách";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode5});
            this.treeView1.Size = new System.Drawing.Size(319, 472);
            this.treeView1.TabIndex = 4;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(319, 38);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(676, 502);
            this.reportViewer1.TabIndex = 23;
            // 
            // frmThongKeBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 540);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.expandablePanel1);
            this.Controls.Add(this.rbChucNang);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmThongKeBaoCao";
            this.Text = "Thống kê báo cáo";
            this.Load += new System.EventHandler(this.frmThongKeBaoCao_Load);
            this.expandablePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.RibbonBar rbChucNang;
        private DevComponents.DotNetBar.ButtonItem btnTroGiup;
        private DevComponents.DotNetBar.ButtonItem btnThoat;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.ExpandablePanel expandablePanel1;
        private System.Windows.Forms.TreeView treeView1;
        private DevComponents.DotNetBar.ButtonItem buttonItem2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}