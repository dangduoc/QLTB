using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTB.GUI
{
    public partial class UC_KhoPhongBM : UserControl
    {
        private List<string> desHeader, sourceHeaders;
        private DataTable _data;
        public UC_KhoPhongBM(List<string> desHeader, List<string> sourceHeaders)
        {
            InitializeComponent();
            this.sourceHeaders = sourceHeaders;
            this.desHeader = desHeader;
        }
        private void loadGrid()
        {
            _data = new DataTable();
            DataColumn source = new DataColumn("sourceHeader", typeof(string), "", MappingType.Attribute);
            DataColumn des = new DataColumn("desHeader", typeof(List<string>), "", MappingType.Attribute);
            _data.Columns.Add(des);
            _data.Columns.Add(source);


            try
            {
                gridView.AutoGenerateColumns = false;
                DataGridViewColumn cl;
                foreach (DataColumn column in _data.Columns)
                {
                    cl = new DataGridViewColumn();
                    cl.Name = column.ColumnName;
                    cl.HeaderText = column.Caption;
                    cl.DataPropertyName = column.ColumnName;

                    if (column.DataType == typeof(List<string>))
                    {
                        cl.CellTemplate = new DataGridViewComboBoxCell();
                    }
                    else
                    {
                        cl.CellTemplate = new DataGridViewTextBoxCell();
                    }

                    switch (cl.Name)
                    {
                      
                        case "sourceHeader":
                            cl.Visible = true;
                            break;
                        case "desHeader":
                            cl.Visible = true;
                            break;
                        default:
                            break;
                    }
                    gridView.Columns.Add(cl);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void UC_KhoPhongBM_Load(object sender, EventArgs e)
        {
            loadGrid();
            loadData();
        }

        private void loadData()
        {
            foreach (var item in desHeader)
            {
                DataRow row = _data.NewRow();
                row["desHeader"] = item;
                row["sourceHeader"] = sourceHeaders;
                _data.Rows.Add(row);
            }
        }
    }
}
