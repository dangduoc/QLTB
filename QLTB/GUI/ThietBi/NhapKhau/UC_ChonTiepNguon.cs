using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTB.GUI.ThietBi.NhapKhau
{
    public partial class UC_ChonTiepNguon : UserControl
    {
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
            }
        }
    }
}
