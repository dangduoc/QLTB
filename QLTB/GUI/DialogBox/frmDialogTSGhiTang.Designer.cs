﻿namespace QLTB.GUI
{
    partial class frmDialogTSGhiTang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDialogTSGhiTang));
            this.line1 = new DevComponents.DotNetBar.Controls.Line();
            this.line2 = new DevComponents.DotNetBar.Controls.Line();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdioThoiGian = new System.Windows.Forms.RadioButton();
            this.ridoNamHoc = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbNamHoc = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnThem = new DevComponents.DotNetBar.ButtonX();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // line1
            // 
            this.line1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.line1.Location = new System.Drawing.Point(0, 38);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(284, 12);
            this.line1.TabIndex = 0;
            this.line1.Text = "line1";
            // 
            // line2
            // 
            this.line2.Dock = System.Windows.Forms.DockStyle.Top;
            this.line2.Location = new System.Drawing.Point(0, 0);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(284, 14);
            this.line2.TabIndex = 1;
            this.line2.Text = "line2";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdioThoiGian);
            this.panel1.Controls.Add(this.ridoNamHoc);
            this.panel1.Controls.Add(this.line1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(15, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 50);
            this.panel1.TabIndex = 2;
            // 
            // rdioThoiGian
            // 
            this.rdioThoiGian.AutoSize = true;
            this.rdioThoiGian.Location = new System.Drawing.Point(111, 12);
            this.rdioThoiGian.Name = "rdioThoiGian";
            this.rdioThoiGian.Size = new System.Drawing.Size(79, 20);
            this.rdioThoiGian.TabIndex = 2;
            this.rdioThoiGian.Text = "Thời gian";
            this.rdioThoiGian.UseVisualStyleBackColor = true;
            // 
            // ridoNamHoc
            // 
            this.ridoNamHoc.AutoSize = true;
            this.ridoNamHoc.Checked = true;
            this.ridoNamHoc.Location = new System.Drawing.Point(14, 12);
            this.ridoNamHoc.Name = "ridoNamHoc";
            this.ridoNamHoc.Size = new System.Drawing.Size(80, 20);
            this.ridoNamHoc.TabIndex = 1;
            this.ridoNamHoc.TabStop = true;
            this.ridoNamHoc.Text = "Năm Học";
            this.ridoNamHoc.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.line2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(15, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(284, 59);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.cbbNamHoc);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(15, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(284, 52);
            this.panel3.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Năm học";
            // 
            // cbbNamHoc
            // 
            this.cbbNamHoc.DisplayMember = "Text";
            this.cbbNamHoc.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.cbbNamHoc.FormattingEnabled = true;
            this.cbbNamHoc.ItemHeight = 15;
            this.cbbNamHoc.Location = new System.Drawing.Point(80, 10);
            this.cbbNamHoc.Name = "cbbNamHoc";
            this.cbbNamHoc.Size = new System.Drawing.Size(200, 23);
            this.cbbNamHoc.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbbNamHoc.TabIndex = 0;
            // 
            // btnThem
            // 
            this.btnThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.Image = global::QLTB.Properties.Resources.tick;
            this.btnThem.Location = new System.Drawing.Point(128, 20);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(72, 25);
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
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = global::QLTB.Properties.Resources.b_drop;
            this.btnClose.Location = new System.Drawing.Point(205, 20);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 25);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Hủy bỏ";
            // 
            // frmDialogTSGhiTang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(314, 161);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDialogTSGhiTang";
            this.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tham số báo cáo";
            this.Load += new System.EventHandler(this.frmDialogTSGhiTang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.Line line1;
        private DevComponents.DotNetBar.Controls.Line line2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdioThoiGian;
        private System.Windows.Forms.RadioButton ridoNamHoc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbbNamHoc;
        private DevComponents.DotNetBar.ButtonX btnThem;
        private DevComponents.DotNetBar.ButtonX btnClose;
    }
}