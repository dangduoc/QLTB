using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTB.Model;

namespace QLTB.GUI
{
    public partial class UC_NguonKinhPhi : UserControl
    {
        private List<Columnmapping> desData, srcData;
        private DataTable _data;
        public UC_NguonKinhPhi(List<Columnmapping> desData, List<Columnmapping> srcData)
        {
            InitializeComponent();
            this.desData = desData;
            this.srcData = srcData;
        }
        private void loadGrid()
        {
            _data = new DataTable();
            DataColumn source = new DataColumn("src", typeof(string));
            DataColumn des = new DataColumn("des", typeof(int));
            _data.Columns.Add(des);
            _data.Columns.Add(source);
        }
        private void loadData()
        {
            try
            {
                gridView.Columns["TepNguon"].DataPropertyName = "src";
                gridView.Columns["PhanMem"].DataPropertyName = "des";
                ((DataGridViewComboBoxColumn)gridView.Columns["PhanMem"]).DisplayMember = "Ten";
                ((DataGridViewComboBoxColumn)gridView.Columns["PhanMem"]).ValueMember = "Index";
                BindingSource desPhanMem = new BindingSource();
                desPhanMem.DataSource = desData;
                ((DataGridViewComboBoxColumn)gridView.Columns["PhanMem"]).DataSource = desPhanMem;
                foreach (var item in srcData)
                {
                    DataRow row = _data.NewRow();
                    row["src"] = item.Ten;
                    //  row["src"] = srcData;
                    _data.Rows.Add(row);
                }
                BindingSource src = new BindingSource();
                src.DataSource = _data;
                gridView.DataSource = src;
                gridView.CellValueChanged -= gridview_CellValueChanged;
                gridView.CellValueChanged += gridview_CellValueChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi đọc dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void gridview_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == gridView.Columns["PhanMem"].Index)
                {
                    var row = gridView.Rows[e.RowIndex];
                    if (!String.IsNullOrEmpty(row.Cells["TepNguon"].Value.ToString()))
                    {
                        string srcName = row.Cells["TepNguon"].Value.ToString();
                        srcData.Where(p => p.Ten.Equals(srcName)).FirstOrDefault().Index = (int)row.Cells["PhanMem"].Value;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UC_NguonKinhPhi_Load(object sender, EventArgs e)
        {
            loadGrid();
            loadData();
        }

        public List<Columnmapping> GetResult()
        {
            return srcData;
        }
    }
}
