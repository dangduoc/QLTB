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
    public partial class UC_ThucHienImport : UserControl
    {
        private List<FailImport> ds = new List<FailImport>();
        public UC_ThucHienImport(int thanhcong,List<FailImport> ds)
        {
            InitializeComponent();
            lbThanhCong.Text = thanhcong.ToString();
            lbKhongThanhCong.Text = ds.Count.ToString();
            this.ds = ds;
            if (ds.Count <= 0) linkLabel1.Enabled = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDialogError frm = new frmDialogError(ds);
            frm.ShowDialog(this);
        }
    }
}
