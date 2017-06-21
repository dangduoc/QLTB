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
    public partial class frmDialogError : DevComponents.DotNetBar.Office2007Form
    {
        public frmDialogError(List<FailImport> ds)
        {
            InitializeComponent();
         
            BindingSource src = new BindingSource();
            src.DataSource = ds;
            dataGridView1.DataSource = src;
            dataGridView1.Columns[0].HeaderText = "Mã thiết bị";
            dataGridView1.Columns[1].HeaderText = "Thông tin lỗi";
        }

        private void frmDialogError_Load(object sender, EventArgs e)
        {

        }
    }
}
