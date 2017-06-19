namespace QLTB.GUI
{
    partial class UC_KhoPhongBM
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewComboBoxExColumn1 = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.columnmappingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TepNguon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhanMem = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.columnmappingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(903, 506);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gridView);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 59);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(903, 447);
            this.panel3.TabIndex = 2;
            // 
            // gridView
            // 
            this.gridView.AllowUserToAddRows = false;
            this.gridView.AllowUserToDeleteRows = false;
            this.gridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.gridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TepNguon,
            this.PhanMem});
            this.gridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridView.Location = new System.Drawing.Point(0, 0);
            this.gridView.Name = "gridView";
            this.gridView.RowHeadersVisible = false;
            this.gridView.Size = new System.Drawing.Size(903, 447);
            this.gridView.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelX1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(20, 0, 20, 10);
            this.panel2.Size = new System.Drawing.Size(903, 59);
            this.panel2.TabIndex = 1;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Yellow;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelX1.Image = global::QLTB.Properties.Resources.icon_about;
            this.labelX1.Location = new System.Drawing.Point(20, 0);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(863, 49);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Chú ý: Đây là chú ý, ghi chú ý gì đó ra đây";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 127.1574F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Kho/ Phòng trong tệp nhập khẩu";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 450;
            // 
            // dataGridViewComboBoxColumn1
            // 
            this.dataGridViewComboBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dataGridViewComboBoxColumn1.FillWeight = 127.1574F;
            this.dataGridViewComboBoxColumn1.HeaderText = "Tên kho/ phòng sẽ nhập khẩu";
            this.dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            this.dataGridViewComboBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn1.Width = 450;
            // 
            // dataGridViewComboBoxExColumn1
            // 
            this.dataGridViewComboBoxExColumn1.DisplayMember = "Ten";
            this.dataGridViewComboBoxExColumn1.DropDownHeight = 106;
            this.dataGridViewComboBoxExColumn1.DropDownWidth = 121;
            this.dataGridViewComboBoxExColumn1.FillWeight = 127.1574F;
            this.dataGridViewComboBoxExColumn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewComboBoxExColumn1.HeaderText = "Tên kho/ phòng sẽ nhập khẩu";
            this.dataGridViewComboBoxExColumn1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridViewComboBoxExColumn1.IntegralHeight = false;
            this.dataGridViewComboBoxExColumn1.ItemHeight = 15;
            this.dataGridViewComboBoxExColumn1.Name = "dataGridViewComboBoxExColumn1";
            this.dataGridViewComboBoxExColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxExColumn1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridViewComboBoxExColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewComboBoxExColumn1.ValueMember = "Index";
            this.dataGridViewComboBoxExColumn1.Width = 450;
            // 
            // columnmappingBindingSource
            // 
            this.columnmappingBindingSource.DataSource = typeof(QLTB.Model.Columnmapping);
            // 
            // TepNguon
            // 
            this.TepNguon.FillWeight = 127.1574F;
            this.TepNguon.HeaderText = "Kho/ Phòng trong tệp nhập khẩu";
            this.TepNguon.Name = "TepNguon";
            // 
            // PhanMem
            // 
            this.PhanMem.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.PhanMem.FillWeight = 127.1574F;
            this.PhanMem.HeaderText = "Tên kho/ phòng sẽ nhập khẩu";
            this.PhanMem.Name = "PhanMem";
            this.PhanMem.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // UC_KhoPhongBM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UC_KhoPhongBM";
            this.Size = new System.Drawing.Size(903, 506);
            this.Load += new System.EventHandler(this.UC_KhoPhongBM_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.columnmappingBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView gridView;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.BindingSource columnmappingBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn dataGridViewComboBoxExColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TepNguon;
        private System.Windows.Forms.DataGridViewComboBoxColumn PhanMem;
    }
}
