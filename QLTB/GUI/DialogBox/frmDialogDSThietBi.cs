using QLTB.Handler;
using QLTB.Model;
using QLTB.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTB.GUI
{
    public partial class frmDialogDSThietBi : DevComponents.DotNetBar.Office2007Form
    {
        private BindingSource source = new BindingSource();
        public frmDialogDSThietBi()
        {
            InitializeComponent();
        }
        private void SetHeaderForGrid(ADGV.AdvancedDataGridView grid, List<string> headers)
        {
            for (int i = 0; i < headers.Count; i++)
            {
                grid.Columns[i].HeaderText = headers[i];
            }
        }
        private void LoadForm()
        {

            //Clone
            List<ThietBiTTGridDisplayModel> list = new DbThietBiTTHandler().GetAll();
           
            //
            List<string> headers = new List<string>();
            headers.Add("Mã thiết bị");
            headers.Add("Tên thiết bị");
            headers.Add("Đơn vị tính");
            headers.Add("Dùng cho lớp");
            headers.Add("Loại thiết bị");
            headers.Add("Môn học");
            headers.Add("Đầu mục");
            headers.Add("Số lượng");
            headers.Add("Mô tả");

            //
            DataTable tb = MyConvert.ToDataTable(list);
            dataGridView.DataSource = list;
            DataGridViewCheckBoxColumn colCB = new DataGridViewCheckBoxColumn();
            DatagridViewCheckBoxHeaderCell cbHeader = new DatagridViewCheckBoxHeaderCell();
            colCB.DefaultCellStyle.Alignment= DataGridViewContentAlignment.MiddleCenter;
            colCB.HeaderCell = cbHeader;
            colCB.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colCB.Name = "checkbox";
            dataGridView.Columns.Add(colCB);
            dataGridView.Columns["checkbox"].DisplayIndex = 0;
            dataGridView.Columns["checkbox"].Width = 20;      
            dataGridView.Columns["checkbox"].HeaderText = "";
            dataGridView.Columns["checkbox"].DefaultCellStyle.Alignment= DataGridViewContentAlignment.MiddleCenter;
            //

        }

        private void cbHeader_OnCheckBoxClicked(bool state)
        {
            foreach(DataGridViewRow r in dataGridView.Rows)
            {
                r.Cells["checkbox"].Value = state;
            }
        }
        private void frmDialogDSThietBi_Load(object sender, EventArgs e)
        {
            LoadForm();
        }
    }
}
