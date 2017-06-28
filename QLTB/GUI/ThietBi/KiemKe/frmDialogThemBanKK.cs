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
    public partial class frmDialogThemBanKK : DevComponents.DotNetBar.Office2007Form
    {
        public frmDialogThemBanKK()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            BanKiemKeGridDisplayModel person = new BanKiemKeGridDisplayModel
            {
                ChucVu = txtChucvu.Text,
                DaiDien = txtDaiDien.Text,
                HoTen = txtTen.Text,
                VaiTro = (int)numVaiTro.Value
            };
            var parent = Owner.ActiveControl as Form2;
            parent.AddPerson(person);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
