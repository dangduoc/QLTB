namespace QLTB.GUI
{
    partial class frmTaoMonHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTaoMonHoc));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.layoutControl = new DevComponents.DotNetBar.Layout.LayoutControl();
            this.txtMaMonHoc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cbbLoaiDanhGia = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbbKieuMon = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtTen = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.layoutControlItem4 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutControlItem1 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutControlItem2 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutSpacerItem1 = new DevComponents.DotNetBar.Layout.LayoutSpacerItem();
            this.layoutControlItem3 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutSpacerItem2 = new DevComponents.DotNetBar.Layout.LayoutSpacerItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.layoutControl.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 199);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.layoutControl);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(363, 160);
            this.panel3.TabIndex = 2;
            // 
            // layoutControl
            // 
            this.layoutControl.Controls.Add(this.txtMaMonHoc);
            this.layoutControl.Controls.Add(this.cbbLoaiDanhGia);
            this.layoutControl.Controls.Add(this.cbbKieuMon);
            this.layoutControl.Controls.Add(this.txtTen);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 0);
            this.layoutControl.Name = "layoutControl";
            // 
            // 
            // 
            this.layoutControl.RootGroup.Items.AddRange(new DevComponents.DotNetBar.Layout.LayoutItemBase[] {
            this.layoutControlItem4,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutSpacerItem1,
            this.layoutControlItem3,
            this.layoutSpacerItem2});
            this.layoutControl.Size = new System.Drawing.Size(363, 160);
            this.layoutControl.TabIndex = 0;
            // 
            // txtMaMonHoc
            // 
            // 
            // 
            // 
            this.txtMaMonHoc.Border.Class = "TextBoxBorder";
            this.txtMaMonHoc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMaMonHoc.Location = new System.Drawing.Point(104, 4);
            this.txtMaMonHoc.Margin = new System.Windows.Forms.Padding(0);
            this.txtMaMonHoc.Name = "txtMaMonHoc";
            this.txtMaMonHoc.PreventEnterBeep = true;
            this.txtMaMonHoc.Size = new System.Drawing.Size(255, 23);
            this.txtMaMonHoc.TabIndex = 0;
            // 
            // cbbLoaiDanhGia
            // 
            this.cbbLoaiDanhGia.DisplayMember = "Text";
            this.cbbLoaiDanhGia.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.cbbLoaiDanhGia.FormattingEnabled = true;
            this.cbbLoaiDanhGia.ItemHeight = 15;
            this.cbbLoaiDanhGia.Location = new System.Drawing.Point(104, 109);
            this.cbbLoaiDanhGia.Margin = new System.Windows.Forms.Padding(0);
            this.cbbLoaiDanhGia.Name = "cbbLoaiDanhGia";
            this.cbbLoaiDanhGia.Size = new System.Drawing.Size(192, 23);
            this.cbbLoaiDanhGia.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbbLoaiDanhGia.TabIndex = 4;
            // 
            // cbbKieuMon
            // 
            this.cbbKieuMon.DisplayMember = "Text";
            this.cbbKieuMon.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.cbbKieuMon.FormattingEnabled = true;
            this.cbbKieuMon.ItemHeight = 15;
            this.cbbKieuMon.Location = new System.Drawing.Point(104, 74);
            this.cbbKieuMon.Margin = new System.Windows.Forms.Padding(0);
            this.cbbKieuMon.Name = "cbbKieuMon";
            this.cbbKieuMon.Size = new System.Drawing.Size(192, 23);
            this.cbbKieuMon.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbbKieuMon.TabIndex = 2;
            // 
            // txtTen
            // 
            // 
            // 
            // 
            this.txtTen.Border.Class = "TextBoxBorder";
            this.txtTen.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTen.Location = new System.Drawing.Point(104, 39);
            this.txtTen.Margin = new System.Windows.Forms.Padding(0);
            this.txtTen.Name = "txtTen";
            this.txtTen.PreventEnterBeep = true;
            this.txtTen.Size = new System.Drawing.Size(255, 23);
            this.txtTen.TabIndex = 1;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtMaMonHoc;
            this.layoutControlItem4.Height = 35;
            this.layoutControlItem4.MinSize = new System.Drawing.Size(120, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Text = "<b>Mã môn học <font color=\"#ED1C24\">(*)</font></b>";
            this.layoutControlItem4.Width = 100;
            this.layoutControlItem4.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtTen;
            this.layoutControlItem1.Height = 35;
            this.layoutControlItem1.MinSize = new System.Drawing.Size(120, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Text = "<b>Tên môn học <font color=\"#ED1C24\">(*)</font></b>";
            this.layoutControlItem1.Width = 100;
            this.layoutControlItem1.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.cbbKieuMon;
            this.layoutControlItem2.Height = 35;
            this.layoutControlItem2.MinSize = new System.Drawing.Size(64, 18);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Text = "<b>Kiểu môn <font color=\"#ED1C24\">(*)</font></b>";
            this.layoutControlItem2.Width = 300;
            // 
            // layoutSpacerItem1
            // 
            this.layoutSpacerItem1.Height = 32;
            this.layoutSpacerItem1.Name = "layoutSpacerItem1";
            this.layoutSpacerItem1.Width = 100;
            this.layoutSpacerItem1.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.cbbLoaiDanhGia;
            this.layoutControlItem3.Height = 35;
            this.layoutControlItem3.MinSize = new System.Drawing.Size(64, 18);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Text = "<b>Loại đánh giá <font color=\"#ED1C24\">(*)</font></b>";
            this.layoutControlItem3.Width = 300;
            // 
            // layoutSpacerItem2
            // 
            this.layoutSpacerItem2.Height = 32;
            this.layoutSpacerItem2.Name = "layoutSpacerItem2";
            this.layoutSpacerItem2.Width = 100;
            this.layoutSpacerItem2.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 160);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(363, 39);
            this.panel2.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Image = global::QLTB.Properties.Resources.b_drop;
            this.btnCancel.Location = new System.Drawing.Point(269, 7);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 23);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Hủy bỏ";
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Image = global::QLTB.Properties.Resources.save_icon;
            this.btnSave.Location = new System.Drawing.Point(177, 7);
            this.btnSave.Margin = new System.Windows.Forms.Padding(0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 23);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmTaoMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(383, 219);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTaoMonHoc";
            this.Padding = new System.Windows.Forms.Padding(10, 20, 10, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Môn học";
            this.Load += new System.EventHandler(this.frmTaoMonHoc_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmTaoMonHoc_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.layoutControl.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private DevComponents.DotNetBar.Layout.LayoutControl layoutControl;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbbLoaiDanhGia;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbbKieuMon;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTen;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem1;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem2;
        private DevComponents.DotNetBar.Layout.LayoutSpacerItem layoutSpacerItem1;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem3;
        private DevComponents.DotNetBar.Layout.LayoutSpacerItem layoutSpacerItem2;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaMonHoc;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem4;
    }
}