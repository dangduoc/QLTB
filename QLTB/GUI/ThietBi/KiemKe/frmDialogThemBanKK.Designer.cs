namespace QLTB.GUI
{
    partial class frmDialogThemBanKK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDialogThemBanKK));
            this.panel1 = new System.Windows.Forms.Panel();
            this.layoutControl1 = new DevComponents.DotNetBar.Layout.LayoutControl();
            this.txtTen = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.layoutControlItem1 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.txtChucvu = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.layoutControlItem2 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.txtDaiDien = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.layoutControlItem3 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnThem = new DevComponents.DotNetBar.ButtonX();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.numVaiTro = new System.Windows.Forms.NumericUpDown();
            this.layoutControlItem4 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.panel1.SuspendLayout();
            this.layoutControl1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVaiTro)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.layoutControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 194);
            this.panel1.TabIndex = 0;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.numVaiTro);
            this.layoutControl1.Controls.Add(this.txtDaiDien);
            this.layoutControl1.Controls.Add(this.txtChucvu);
            this.layoutControl1.Controls.Add(this.txtTen);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            // 
            // 
            // 
            this.layoutControl1.RootGroup.Items.AddRange(new DevComponents.DotNetBar.Layout.LayoutItemBase[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.layoutControl1.Size = new System.Drawing.Size(321, 152);
            this.layoutControl1.TabIndex = 0;
            // 
            // txtTen
            // 
            // 
            // 
            // 
            this.txtTen.Border.Class = "TextBoxBorder";
            this.txtTen.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTen.Location = new System.Drawing.Point(56, 4);
            this.txtTen.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.txtTen.Name = "txtTen";
            this.txtTen.PreventEnterBeep = true;
            this.txtTen.Size = new System.Drawing.Size(261, 23);
            this.txtTen.TabIndex = 0;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtTen;
            this.layoutControlItem1.Height = 35;
            this.layoutControlItem1.MinSize = new System.Drawing.Size(120, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Text = "<b>Họ tên</b>";
            this.layoutControlItem1.Width = 100;
            this.layoutControlItem1.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // txtChucvu
            // 
            // 
            // 
            // 
            this.txtChucvu.Border.Class = "TextBoxBorder";
            this.txtChucvu.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtChucvu.Location = new System.Drawing.Point(56, 39);
            this.txtChucvu.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.txtChucvu.Name = "txtChucvu";
            this.txtChucvu.PreventEnterBeep = true;
            this.txtChucvu.Size = new System.Drawing.Size(261, 23);
            this.txtChucvu.TabIndex = 1;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtChucvu;
            this.layoutControlItem2.Height = 35;
            this.layoutControlItem2.MinSize = new System.Drawing.Size(120, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Text = "<b>Chức vụ</b>";
            this.layoutControlItem2.Width = 100;
            this.layoutControlItem2.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // txtDaiDien
            // 
            // 
            // 
            // 
            this.txtDaiDien.Border.Class = "TextBoxBorder";
            this.txtDaiDien.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDaiDien.Location = new System.Drawing.Point(56, 74);
            this.txtDaiDien.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.txtDaiDien.Name = "txtDaiDien";
            this.txtDaiDien.PreventEnterBeep = true;
            this.txtDaiDien.Size = new System.Drawing.Size(261, 23);
            this.txtDaiDien.TabIndex = 2;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtDaiDien;
            this.layoutControlItem3.Height = 35;
            this.layoutControlItem3.MinSize = new System.Drawing.Size(120, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Text = "<b>Đại diện</b>";
            this.layoutControlItem3.Width = 100;
            this.layoutControlItem3.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 151);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(321, 43);
            this.panel2.TabIndex = 1;
            // 
            // btnThem
            // 
            this.btnThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThem.Image = global::QLTB.Properties.Resources.tick;
            this.btnThem.Location = new System.Drawing.Point(162, 9);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 25);
            this.btnThem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Đồng ý";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClose.Image = global::QLTB.Properties.Resources.b_drop;
            this.btnClose.Location = new System.Drawing.Point(243, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(73, 25);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Hủy bỏ";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // numVaiTro
            // 
            this.numVaiTro.Location = new System.Drawing.Point(56, 109);
            this.numVaiTro.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.numVaiTro.Name = "numVaiTro";
            this.numVaiTro.Size = new System.Drawing.Size(68, 23);
            this.numVaiTro.TabIndex = 3;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.numVaiTro;
            this.layoutControlItem4.Height = 35;
            this.layoutControlItem4.MinSize = new System.Drawing.Size(64, 18);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Text = "<b>Vai trò</b>";
            this.layoutControlItem4.Width = 128;
            // 
            // frmDialogThemBanKK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(331, 204);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDialogThemBanKK";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ban kiểm kê";
            this.panel1.ResumeLayout(false);
            this.layoutControl1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numVaiTro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.Layout.LayoutControl layoutControl1;
        private System.Windows.Forms.Panel panel2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDaiDien;
        private DevComponents.DotNetBar.Controls.TextBoxX txtChucvu;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTen;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem1;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem2;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem3;
        private DevComponents.DotNetBar.ButtonX btnThem;
        private DevComponents.DotNetBar.ButtonX btnClose;
        private System.Windows.Forms.NumericUpDown numVaiTro;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem4;
    }
}