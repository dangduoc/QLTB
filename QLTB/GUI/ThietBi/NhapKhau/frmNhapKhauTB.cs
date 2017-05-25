using QLTB.GUI.ThietBi.NhapKhau;
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
        private int step;
        private UC_ChonTiepNguon firstStep = new UC_ChonTiepNguon();
        private UC_GhepCotDuLieu secondtStep = new UC_GhepCotDuLieu();
        private UC_KhoPhongBM thirdStep = new UC_KhoPhongBM();
        public frmNhapKhauTB()
        {
            InitializeComponent();
            step = 1;
            NextStep(firstStep);
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
        private void NextStep(UserControl u)
        {
            pnlHolder.SuspendLayout();
            pnlHolder.Visible = false;
            pnlHolder.Controls.Clear();
            u.Dock = DockStyle.Fill;
            pnlHolder.Controls.Add(u);
            pnlHolder.ResumeLayout();
            pnlHolder.Visible = true;
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            switch (step)
            {
                case 1:
                    { NextStep(secondtStep);step++; btnBack.Visible = true; break; }
                case 2: { NextStep(thirdStep); step++;btnBack.Visible = true; break; }
                default: { MessageBox.Show("Đang xây dựng tiếp"); break; }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (step > 1)
            {
                switch (step)
                {
                    case 2:
                        { NextStep(firstStep); step--; btnBack.Visible = false; break; }
                    case 3: { NextStep(secondtStep); step--; btnBack.Visible = true; break; }
                    default: { MessageBox.Show("Đang xây dựng tiếp"); break; }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
