using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTB.Model;

namespace QLTB.GUI
{
    public partial class frmChiTietKiemKe : DevComponents.DotNetBar.Office2007Form
    {
        public frmChiTietKiemKe()
        {
            InitializeComponent();
        }
        private void loadForm()
        {


            this.dataGridView1.Columns.Add("JanWin", "Win");
            this.dataGridView1.Columns.Add("JanLoss", "Loss");
            this.dataGridView1.Columns.Add("FebWin", "Win");
            this.dataGridView1.Columns.Add("FebLoss", "Loss");
            this.dataGridView1.Columns.Add("MarWin", "Win");
            this.dataGridView1.Columns.Add("MarLoss", "Loss");
            this.dataGridView1.Columns.Add("AprWin", "Win");
            this.dataGridView1.Columns.Add("AprLoss", "Loss");
            this.dataGridView1.Columns.Add("MayWin", "Win");
            this.dataGridView1.Columns.Add("MayLoss", "Loss");

            for (int j = 0; j < this.dataGridView1.ColumnCount; j++)
            {
                this.dataGridView1.Columns[j].Width = 45;
            }

            this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView1.ColumnHeadersHeight = this.dataGridView1.ColumnHeadersHeight * 2;
            this.dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            this.dataGridView1.CellPainting += new DataGridViewCellPaintingEventHandler(dataGridView1_CellPainting);
            this.dataGridView1.Paint += new PaintEventHandler(dataGridView1_Paint);
            this.dataGridView1.Scroll += new ScrollEventHandler(dataGridView1_Scroll);
            this.dataGridView1.ColumnWidthChanged += new DataGridViewColumnEventHandler(dataGridView1_ColumnWidthChanged);













            //
            List<BanKiemKeGridDisplayModel> list = new List<BanKiemKeGridDisplayModel>();
            list.Add(new BanKiemKeGridDisplayModel
            {
                HoTen="Đặng Minh Được",
                ChucVu="Trưởng ban kiểm kê",
                DaiDien="Ban giám hiệu",
                VaiTro=""
            });
            DataGridViewLinkColumn col = new DataGridViewLinkColumn();
            DataGridViewLinkColumn col2 = new DataGridViewLinkColumn();
            col2.HeaderText = "STT";
            col2.Width = 30;
            col2.Text = "1";
            col2.LinkColor = Color.White;
            col2.UseColumnTextForLinkValue = true;
            col.Width = 50;
            col.HeaderText = "";
            gridBanKiemKe.Columns.Add(col2);
            gridBanKiemKe.Columns.Add(col);
            gridBanKiemKe.DataSource = list;
            gridBanKiemKe.Columns[2].HeaderText = "Họ tên";
            gridBanKiemKe.Columns[3].HeaderText = "Chức vụ";
            gridBanKiemKe.Columns[4].HeaderText = "Đại diện";
            gridBanKiemKe.Columns[5].HeaderText = "Vai trò";
            gridBanKiemKe.Columns[1].DisplayIndex = 5;
            gridBanKiemKe.Refresh();
            gridBanKiemKe.Update();
        }
        #region datagrid1
        private void dataGridView1_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            Rectangle rtHeader = this.dataGridView1.DisplayRectangle;
            rtHeader.Height = this.dataGridView1.ColumnHeadersHeight / 2;
            this.dataGridView1.Invalidate(rtHeader);
        }
        private void dataGridView1_Scroll(object sender, ScrollEventArgs e)
        {
            Rectangle rtHeader = this.dataGridView1.DisplayRectangle;
            rtHeader.Height = this.dataGridView1.ColumnHeadersHeight / 2;
            this.dataGridView1.Invalidate(rtHeader);
        }

        private void dataGridView1_Paint(object sender, PaintEventArgs e)
        {

            int[] columns = {6,8,10};   
            string[] monthes = {"Trước kiểm kê", "Sau kiểm kê", "Chênh lệch"};
            foreach(var item in columns)
            {
                Rectangle r1 = this.dataGridView1.GetCellDisplayRectangle(item, -1, true);
                int w2 = this.dataGridView1.GetCellDisplayRectangle(item + 1, -1, true).Width;
                r1.X += 1;
                r1.Y += 1;
                r1.Width = r1.Width + w2 - 2;
                r1.Height = r1.Height / 2 - 2;
                e.Graphics.FillRectangle(new SolidBrush(this.dataGridView1.ColumnHeadersDefaultCellStyle.BackColor), r1);
                StringFormat format = new StringFormat();
                format.Alignment = StringAlignment.Center;
                format.LineAlignment = StringAlignment.Center;
                e.Graphics.DrawString(monthes[item / 2],
                this.dataGridView1.ColumnHeadersDefaultCellStyle.Font,
                new SolidBrush(this.dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor),
                r1,
                format);
            }
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex > -1)
            {
                Rectangle r2 = e.CellBounds;
                r2.Y += e.CellBounds.Height / 2;
                r2.Height = e.CellBounds.Height / 2;
                e.PaintBackground(r2, true);
                e.PaintContent(r2);
                e.Handled = true;
            }
        }
        #endregion
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmChiTietKiemKe_Load(object sender, EventArgs e)
        {
            loadForm();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmChiTietKiemKe_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
