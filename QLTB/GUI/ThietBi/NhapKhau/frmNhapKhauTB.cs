using QLTB.Model;
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
        private UC_ChonTiepNguon ChonTiepNguon;
        private UC_GhepCotDuLieu GhepCot;
        private UC_KhoPhongBM KhoPhong;
        public frmNhapKhauTB()
        {
            InitializeComponent();
            step = 1;
            ChonTiepNguon = new UC_ChonTiepNguon();
            NextStep(ChonTiepNguon);
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
        #region Perform steps
        public void PerformFirstStep()
        {
            var desHeader = new List<string>();
            foreach(var item in typeof(ThietBiImport).GetProperties())
            {
                desHeader.Add(item.Name);
            }
            var sourceHeader = ChonTiepNguon.GetHeaders();
            if (sourceHeader != null)
            {
                GhepCot = new UC_GhepCotDuLieu(desHeader, sourceHeader);
                NextStep(GhepCot);
                step++;
                btnBack.Visible = true;
            }
            else
            {
                MessageBox.Show("Đọc file không thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }
        public void PerformSecondStep(List<string> sourceHeaders, List<ThietBiModel> dsfromfile)
        {

        }
        #endregion
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
                    {
                        PerformFirstStep();
                        break;
                    }
                //case 2: { NextStep(thirdStep); step++;btnBack.Visible = true; break; }
                default: { MessageBox.Show("Đang xây dựng tiếp"); break; }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //if (step > 1)
            //{
            //    switch (step)
            //    {
            //        case 2:
            //            { NextStep(firstStep); step--; btnBack.Visible = false; break; }
            //        case 3: { NextStep(secondtStep); step--; btnBack.Visible = true; break; }
            //        default: { MessageBox.Show("Đang xây dựng tiếp"); break; }
            //    }
            //}
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
