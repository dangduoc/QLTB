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
    public partial class frmNhapKhauTB : DevComponents.DotNetBar.Office2007Form
    {
        public frmNhapKhauTB()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Button item in toolmenuTB.Controls.OfType<Button>())
            {
                item.BackColor = Color.Transparent;
            }
            Button btn = sender as Button;
            btn.BackColor = Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
        }
    }
}
