namespace QLTB.GUI.DanhMuc.CanBoThietBi
{
    partial class frmTaoCanBoTB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTaoCanBoTB));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.layoutControl1 = new DevComponents.DotNetBar.Layout.LayoutControl();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbbKetThuc = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbbBatDau = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtGhiChu = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cboxTrinhDoNV = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.txtTrinhDoVH = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cbbPhuTrach = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbbGioiTinh = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtTen = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtHoDem = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMaCanBo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.layoutControlItem1 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutControlItem2 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutControlItem3 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutControlItem4 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutSpacerItem1 = new DevComponents.DotNetBar.Layout.LayoutSpacerItem();
            this.layoutControlItem5 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutSpacerItem2 = new DevComponents.DotNetBar.Layout.LayoutSpacerItem();
            this.layoutControlItem6 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutControlItem7 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutSpacerItem4 = new DevComponents.DotNetBar.Layout.LayoutSpacerItem();
            this.layoutControlItem9 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutSpacerItem3 = new DevComponents.DotNetBar.Layout.LayoutSpacerItem();
            this.layoutControlItem10 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.layoutControl1.SuspendLayout();
            this.panel4.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(526, 362);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.layoutControl1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(526, 325);
            this.panel3.TabIndex = 2;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.panel4);
            this.layoutControl1.Controls.Add(this.txtGhiChu);
            this.layoutControl1.Controls.Add(this.cboxTrinhDoNV);
            this.layoutControl1.Controls.Add(this.txtTrinhDoVH);
            this.layoutControl1.Controls.Add(this.cbbPhuTrach);
            this.layoutControl1.Controls.Add(this.cbbGioiTinh);
            this.layoutControl1.Controls.Add(this.txtTen);
            this.layoutControl1.Controls.Add(this.txtHoDem);
            this.layoutControl1.Controls.Add(this.txtMaCanBo);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            // 
            // 
            // 
            this.layoutControl1.RootGroup.Items.AddRange(new DevComponents.DotNetBar.Layout.LayoutItemBase[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutSpacerItem1,
            this.layoutControlItem5,
            this.layoutSpacerItem2,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutSpacerItem4,
            this.layoutControlItem9,
            this.layoutSpacerItem3,
            this.layoutControlItem10});
            this.layoutControl1.Size = new System.Drawing.Size(526, 325);
            this.layoutControl1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cbbKetThuc);
            this.panel4.Controls.Add(this.cbbBatDau);
            this.panel4.Location = new System.Drawing.Point(109, 214);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(413, 27);
            this.panel4.TabIndex = 8;
            // 
            // cbbKetThuc
            // 
            this.cbbKetThuc.DisplayMember = "Text";
            this.cbbKetThuc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbKetThuc.FormatString = "dd/mm/yyyy";
            this.cbbKetThuc.FormattingEnabled = true;
            this.cbbKetThuc.ItemHeight = 18;
            this.cbbKetThuc.Location = new System.Drawing.Point(129, 1);
            this.cbbKetThuc.Name = "cbbKetThuc";
            this.cbbKetThuc.Size = new System.Drawing.Size(121, 24);
            this.cbbKetThuc.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbbKetThuc.TabIndex = 1;
            this.cbbKetThuc.WatermarkText = "dd/mm/yyyy";
            // 
            // cbbBatDau
            // 
            this.cbbBatDau.DisplayMember = "Text";
            this.cbbBatDau.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbBatDau.FormatString = "dd/mm/yyyy";
            this.cbbBatDau.FormattingEnabled = true;
            this.cbbBatDau.ItemHeight = 18;
            this.cbbBatDau.Location = new System.Drawing.Point(0, 1);
            this.cbbBatDau.Name = "cbbBatDau";
            this.cbbBatDau.Size = new System.Drawing.Size(123, 24);
            this.cbbBatDau.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbbBatDau.TabIndex = 0;
            this.cbbBatDau.WatermarkText = "dd/mm/yyyy";
            // 
            // txtGhiChu
            // 
            // 
            // 
            // 
            this.txtGhiChu.Border.Class = "TextBoxBorder";
            this.txtGhiChu.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtGhiChu.Location = new System.Drawing.Point(109, 284);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(0);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.PreventEnterBeep = true;
            this.txtGhiChu.Size = new System.Drawing.Size(413, 23);
            this.txtGhiChu.TabIndex = 12;
            // 
            // cboxTrinhDoNV
            // 
            // 
            // 
            // 
            this.cboxTrinhDoNV.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cboxTrinhDoNV.Checked = true;
            this.cboxTrinhDoNV.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboxTrinhDoNV.CheckValue = "Y";
            this.cboxTrinhDoNV.Location = new System.Drawing.Point(114, 249);
            this.cboxTrinhDoNV.Margin = new System.Windows.Forms.Padding(0);
            this.cboxTrinhDoNV.Name = "cboxTrinhDoNV";
            this.cboxTrinhDoNV.Size = new System.Drawing.Size(192, 27);
            this.cboxTrinhDoNV.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboxTrinhDoNV.TabIndex = 10;
            this.cboxTrinhDoNV.Text = "Có trình độ nghiệp vụ";
            this.cboxTrinhDoNV.TextColor = System.Drawing.Color.Black;
            // 
            // txtTrinhDoVH
            // 
            // 
            // 
            // 
            this.txtTrinhDoVH.Border.Class = "TextBoxBorder";
            this.txtTrinhDoVH.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTrinhDoVH.Location = new System.Drawing.Point(109, 179);
            this.txtTrinhDoVH.Margin = new System.Windows.Forms.Padding(0);
            this.txtTrinhDoVH.Name = "txtTrinhDoVH";
            this.txtTrinhDoVH.PreventEnterBeep = true;
            this.txtTrinhDoVH.Size = new System.Drawing.Size(413, 23);
            this.txtTrinhDoVH.TabIndex = 7;
            // 
            // cbbPhuTrach
            // 
            this.cbbPhuTrach.DisplayMember = "Text";
            this.cbbPhuTrach.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.cbbPhuTrach.FormattingEnabled = true;
            this.cbbPhuTrach.ItemHeight = 15;
            this.cbbPhuTrach.Location = new System.Drawing.Point(109, 144);
            this.cbbPhuTrach.Margin = new System.Windows.Forms.Padding(0);
            this.cbbPhuTrach.Name = "cbbPhuTrach";
            this.cbbPhuTrach.Size = new System.Drawing.Size(187, 23);
            this.cbbPhuTrach.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbbPhuTrach.TabIndex = 5;
            // 
            // cbbGioiTinh
            // 
            this.cbbGioiTinh.DisplayMember = "Text";
            this.cbbGioiTinh.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.cbbGioiTinh.FormattingEnabled = true;
            this.cbbGioiTinh.ItemHeight = 15;
            this.cbbGioiTinh.Location = new System.Drawing.Point(109, 109);
            this.cbbGioiTinh.Margin = new System.Windows.Forms.Padding(0);
            this.cbbGioiTinh.Name = "cbbGioiTinh";
            this.cbbGioiTinh.Size = new System.Drawing.Size(187, 23);
            this.cbbGioiTinh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbbGioiTinh.TabIndex = 3;
            // 
            // txtTen
            // 
            // 
            // 
            // 
            this.txtTen.Border.Class = "TextBoxBorder";
            this.txtTen.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTen.Location = new System.Drawing.Point(109, 74);
            this.txtTen.Margin = new System.Windows.Forms.Padding(0);
            this.txtTen.Name = "txtTen";
            this.txtTen.PreventEnterBeep = true;
            this.txtTen.Size = new System.Drawing.Size(413, 23);
            this.txtTen.TabIndex = 2;
            // 
            // txtHoDem
            // 
            // 
            // 
            // 
            this.txtHoDem.Border.Class = "TextBoxBorder";
            this.txtHoDem.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtHoDem.Location = new System.Drawing.Point(109, 39);
            this.txtHoDem.Margin = new System.Windows.Forms.Padding(0);
            this.txtHoDem.Name = "txtHoDem";
            this.txtHoDem.PreventEnterBeep = true;
            this.txtHoDem.Size = new System.Drawing.Size(413, 23);
            this.txtHoDem.TabIndex = 1;
            // 
            // txtMaCanBo
            // 
            // 
            // 
            // 
            this.txtMaCanBo.Border.Class = "TextBoxBorder";
            this.txtMaCanBo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMaCanBo.Location = new System.Drawing.Point(109, 4);
            this.txtMaCanBo.Margin = new System.Windows.Forms.Padding(0);
            this.txtMaCanBo.Name = "txtMaCanBo";
            this.txtMaCanBo.PreventEnterBeep = true;
            this.txtMaCanBo.Size = new System.Drawing.Size(413, 23);
            this.txtMaCanBo.TabIndex = 0;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtMaCanBo;
            this.layoutControlItem1.Height = 35;
            this.layoutControlItem1.MinSize = new System.Drawing.Size(120, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Text = "<b>Mã cán bộ <font color=\"#ED1C24\">(*)</font></b>";
            this.layoutControlItem1.Width = 100;
            this.layoutControlItem1.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtHoDem;
            this.layoutControlItem2.Height = 35;
            this.layoutControlItem2.MinSize = new System.Drawing.Size(120, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Text = "<b>Họ và tên đệm</b>";
            this.layoutControlItem2.Width = 100;
            this.layoutControlItem2.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtTen;
            this.layoutControlItem3.Height = 35;
            this.layoutControlItem3.MinSize = new System.Drawing.Size(120, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Text = "<b>Tên cán bộ <font color=\"#ED1C24\">(*)</font></b>";
            this.layoutControlItem3.Width = 100;
            this.layoutControlItem3.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.cbbGioiTinh;
            this.layoutControlItem4.Height = 35;
            this.layoutControlItem4.MinSize = new System.Drawing.Size(64, 18);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Text = "<b>Giới tính</b>";
            this.layoutControlItem4.Width = 300;
            // 
            // layoutSpacerItem1
            // 
            this.layoutSpacerItem1.Height = 32;
            this.layoutSpacerItem1.Name = "layoutSpacerItem1";
            this.layoutSpacerItem1.Width = 100;
            this.layoutSpacerItem1.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.cbbPhuTrach;
            this.layoutControlItem5.Height = 35;
            this.layoutControlItem5.MinSize = new System.Drawing.Size(64, 18);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Text = "<b>Phụ trách</b>";
            this.layoutControlItem5.Width = 300;
            // 
            // layoutSpacerItem2
            // 
            this.layoutSpacerItem2.Height = 32;
            this.layoutSpacerItem2.Name = "layoutSpacerItem2";
            this.layoutSpacerItem2.Width = 100;
            this.layoutSpacerItem2.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txtTrinhDoVH;
            this.layoutControlItem6.Height = 35;
            this.layoutControlItem6.MinSize = new System.Drawing.Size(120, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Text = "<b>Trình độ văn hóa</b>";
            this.layoutControlItem6.Width = 100;
            this.layoutControlItem6.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.panel4;
            this.layoutControlItem7.Height = 35;
            this.layoutControlItem7.MinSize = new System.Drawing.Size(64, 18);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Text = "<b>Thời gian quản lý</b>";
            this.layoutControlItem7.TextPadding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.layoutControlItem7.Width = 100;
            this.layoutControlItem7.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // layoutSpacerItem4
            // 
            this.layoutSpacerItem4.Height = 35;
            this.layoutSpacerItem4.Name = "layoutSpacerItem4";
            this.layoutSpacerItem4.Width = 110;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.cboxTrinhDoNV;
            this.layoutControlItem9.Height = 31;
            this.layoutControlItem9.MinSize = new System.Drawing.Size(64, 18);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Width = 200;
            // 
            // layoutSpacerItem3
            // 
            this.layoutSpacerItem3.Height = 32;
            this.layoutSpacerItem3.Name = "layoutSpacerItem3";
            this.layoutSpacerItem3.Width = 100;
            this.layoutSpacerItem3.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.txtGhiChu;
            this.layoutControlItem10.Height = 35;
            this.layoutControlItem10.MinSize = new System.Drawing.Size(120, 0);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Text = "<b>Ghi chú</b>";
            this.layoutControlItem10.Width = 100;
            this.layoutControlItem10.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 325);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(526, 37);
            this.panel2.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Image = global::QLTB.Properties.Resources.b_drop;
            this.btnCancel.Location = new System.Drawing.Point(434, 7);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 23);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Hủy bỏ";
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Image = global::QLTB.Properties.Resources.save_icon;
            this.btnSave.Location = new System.Drawing.Point(342, 7);
            this.btnSave.Margin = new System.Windows.Forms.Padding(0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 23);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Lưu";
            // 
            // frmTaoCanBoTB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(546, 382);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTaoCanBoTB";
            this.Padding = new System.Windows.Forms.Padding(10, 20, 10, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm cán bộ thiết bị";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.layoutControl1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.Layout.LayoutControl layoutControl1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtGhiChu;
        private DevComponents.DotNetBar.Controls.CheckBoxX cboxTrinhDoNV;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTrinhDoVH;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbbPhuTrach;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbbGioiTinh;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTen;
        private DevComponents.DotNetBar.Controls.TextBoxX txtHoDem;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaCanBo;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem1;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem2;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem3;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem4;
        private DevComponents.DotNetBar.Layout.LayoutSpacerItem layoutSpacerItem1;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem5;
        private DevComponents.DotNetBar.Layout.LayoutSpacerItem layoutSpacerItem2;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem6;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem7;
        private DevComponents.DotNetBar.Layout.LayoutSpacerItem layoutSpacerItem4;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem9;
        private DevComponents.DotNetBar.Layout.LayoutSpacerItem layoutSpacerItem3;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem10;
        private System.Windows.Forms.Panel panel2;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbbKetThuc;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbbBatDau;
    }
}