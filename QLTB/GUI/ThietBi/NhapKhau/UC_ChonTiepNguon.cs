using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTB.Utils;
using QLTB.Model;
using QLTB.Handler;
namespace QLTB.GUI
{
    public partial class UC_ChonTiepNguon : UserControl
    {
        DbImportHandler handler = new DbImportHandler();
        public UC_ChonTiepNguon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter= "Excel Files|*.xls;*.xlsx;*.xlsm";
            if (open.ShowDialog() == DialogResult.OK)
            {
                txtFileName.Text = open.FileName;
                comboBoxEx1.DataSource = handler.GetSheets(open.FileName);
            }
        }
        public List<string> GetHeaders()
        {
            try
            {
                var lst= handler.GetSourceHeader(txtFileName.Text.Trim(), integerInput2.Value, comboBoxEx1.SelectedIndex + 1);
                if (lst.Count > 0) return lst;
                return null;
            }
            catch(Exception ex)
            {
                return null;
            }
        }
    }
}
