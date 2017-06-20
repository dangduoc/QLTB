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
        public ExcelFileInfo Info;
        public UC_ChonTiepNguon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            if (open.ShowDialog() == DialogResult.OK)
            {
                Cursor = Cursors.WaitCursor;
                txtFileName.Text = open.FileName;
                comboBoxEx1.DataSource = handler.GetSheets(open.FileName);
                Cursor = Cursors.Default;
            }
        }
        public bool setData()
        {
            Info = null;
            Info = handler.GetFileInfo(txtFileName.Text.Trim(), integerInput2.Value, comboBoxEx1.SelectedIndex + 1);
            if (Info != null)
            {
                Info.sheetindex = comboBoxEx1.SelectedIndex + 1;
                Info.headerindex = integerInput2.Value;
                Info.filename = txtFileName.Text.Trim();
            }
            return Info != null;
        }
    }
}
