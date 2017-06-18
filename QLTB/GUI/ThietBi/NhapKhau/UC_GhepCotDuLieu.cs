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
    public partial class UC_GhepCotDuLieu : UserControl
    {
        private List<Columnmapping> desHeader, sourceHeader;
        private DataTable _data;
        public UC_GhepCotDuLieu(List<string> desHeader, List<string> sourceHeaders)
        {
            InitializeComponent();
            this.desHeader = new List<Columnmapping>();
            sourceHeader = new List<Columnmapping>();
            int i = 1;
            foreach (var item in desHeader)
            {
                this.desHeader.Add(new Columnmapping {
                    Index = i++,
                    Ten = item
                });
            }
            i = 1;
            foreach (var item in sourceHeaders)
            {
                this.sourceHeader.Add(new Columnmapping
                {
                    Index = i++,
                    Ten = item
                });
            }
           
        }
        private void loadGrid()
        {
            _data = new DataTable();
            DataColumn stt = new DataColumn("STT", typeof(int));
            DataColumn source = new DataColumn("sourceHeader", typeof(List<string>));
            DataColumn des = new DataColumn("desHeader", typeof(string));
            _data.Columns.Add(stt);
            _data.Columns.Add(des);
            _data.Columns.Add(source);


            try
            {
                gridView.AutoGenerateColumns = false;
                DataGridViewComboBoxColumn cbbcl = new DataGridViewComboBoxColumn();
                cbbcl.Name = "sourceHeader";
                cbbcl.DataPropertyName = cbbcl.Name;
                cbbcl.HeaderText = "Tiêu đề trong tiệp nguồn";
                //cbbcl.DataPropertyName = cbbcl.Name;
                // cbbcl.Items.AddRange(sourceHeaders);
                cbbcl.ValueType = typeof(int);
                cbbcl.DisplayMember = "Ten";
                cbbcl.ValueMember = "Index";
                cbbcl.DataSource = sourceHeader;
                cbbcl.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
                cbbcl.FlatStyle = FlatStyle.Standard;
           

                DataGridViewColumn descl = new DataGridViewColumn();
                descl.Name = "desHeader";
                descl.HeaderText = "Tiêu đề trong chương trình";
                descl.DataPropertyName = descl.Name;
                descl.ReadOnly = true;
                descl.CellTemplate = new DataGridViewTextBoxCell();
                //
                DataGridViewColumn sttcl = new DataGridViewColumn();
                sttcl.Name = "STT";
                sttcl.HeaderText = "STT";
                sttcl.Width = 50;
                sttcl.ReadOnly = true;
                sttcl.DataPropertyName = sttcl.Name;
                sttcl.CellTemplate = new DataGridViewTextBoxCell();
                sttcl.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


                gridView.Columns.Add(sttcl);
                gridView.Columns.Add(descl);
                gridView.Columns.Add(cbbcl);
            }
            catch (Exception ex)
            {

            }
        }

        private void UC_GhepCotDuLieu_Load(object sender, EventArgs e)
        {
            loadGrid();
            loadData();
        }

        private void loadData()
        {
            int stt = 1;
            foreach (var item in desHeader)
            {
                DataRow row = _data.NewRow();
                row["STT"] = stt++;
                row["desHeader"] = item.Ten;
               // row["sourceHeader"] = item.Index;        
                _data.Rows.Add(row);
            }
            BindingSource source = new BindingSource();
            source.DataSource = _data;
            gridView.DataSource = source;
        }
    }
}
