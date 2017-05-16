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
    public partial class Form1 : DevComponents.DotNetBar.Office2007Form
    {
        public Form1()
        {
            InitializeComponent();
            bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;

            //
            btnDMCanBo.Click += BtnDMCanBo_Click;
            btnDMGiaoVien.Click += BtnDMGiaoVien_Click;
            btnDMKhoiLop.Click += BtnDMKhoiLop_Click;
            btnDMLopHoc.Click += BtnDMLopHoc_Click;
            btnDMMonHoc.Click += BtnDMMonHoc_Click;
            btnDMNguonKP.Click += BtnDMNguonKP_Click;
            btnDMPhongBM.Click += BtnDMPhongBM_Click;
            btnDMTB.Click += BtnDMTB_Click;
            btnDMToBoMon.Click += BtnDMToBoMon_Click;
        }

        private void BtnDMToBoMon_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnDMTB_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                if (!CheckExistForm("frmDMThietBiTT"))
                {
                    frmDMThietBiTT frm = new frmDMThietBiTT();
                    frm.MdiParent = this;
                    frm.WindowState = FormWindowState.Maximized;
                    frm.Show();
                }

            }
            catch (Exception ex)
            {

            }
            Cursor = Cursors.Default;
        }

        private void BtnDMPhongBM_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                if (!CheckExistForm("frmDMPhongBoMon"))
                {
                    frmDMPhongBoMon frm = new frmDMPhongBoMon();
                    frm.MdiParent = this;
                    frm.WindowState = FormWindowState.Maximized;
                    frm.Show();
                }

            }
            catch (Exception ex)
            {

            }
            Cursor = Cursors.Default;
        }

        private void BtnDMNguonKP_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                if (!CheckExistForm("frmDMNguonKinhPhi"))
                {
                    frmDMNguonKinhPhi frm = new frmDMNguonKinhPhi();
                    frm.MdiParent = this;
                    frm.WindowState = FormWindowState.Maximized;
                    frm.Show();
                }

            }
            catch (Exception ex)
            {

            }
            Cursor = Cursors.Default;
        }

        private void BtnDMMonHoc_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                if (!CheckExistForm("frmDMMonHoc"))
                {
                    frmDMMonHoc frm = new frmDMMonHoc();
                    frm.MdiParent = this;
                    frm.WindowState = FormWindowState.Maximized;
                    frm.Show();
                }

            }
            catch (Exception ex)
            {

            }
            Cursor = Cursors.Default;
        }

        private void BtnDMLopHoc_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                if (!CheckExistForm("frmDMLopHoc"))
                {
                    frmDMLopHoc frm = new frmDMLopHoc();
                    frm.MdiParent = this;
                    frm.WindowState = FormWindowState.Maximized;
                    frm.Show();
                }

            }
            catch (Exception ex)
            {

            }
            Cursor = Cursors.Default;
        }

        private void BtnDMKhoiLop_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                if (!CheckExistForm("frmDMKhoiLop"))
                {
                    frmDMKhoiLop frm = new frmDMKhoiLop();
                    frm.MdiParent = this;
                    frm.WindowState = FormWindowState.Maximized;
                    frm.Show();
                }

            }
            catch (Exception ex)
            {

            }
            Cursor = Cursors.Default;
        }

        private void BtnDMGiaoVien_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                if (!CheckExistForm("frmDMGiaoVien"))
                {
                    frmDMGiaoVien frm = new frmDMGiaoVien();
                    frm.MdiParent = this;
                    frm.WindowState = FormWindowState.Maximized;
                    frm.Show();
                }
                
            }
            catch (Exception ex)
            {

            }
            Cursor = Cursors.Default;
        }

        private void BtnDMCanBo_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                if (!CheckExistForm("frmDMGiaoVien"))
                {
                    frmDMCanBoThietBi frm = new frmDMCanBoThietBi();
                    frm.MdiParent = this;
                    frm.WindowState = FormWindowState.Maximized;
                    frm.Show();
                }
            }
            catch (Exception ex)
            {

            }
            Cursor = Cursors.Default;
        }

        public bool CheckExistForm(string formName)
        {
            foreach (Form cForm in this.MdiChildren)
            {
                if (cForm.Name == formName)
                {
                    cForm.Activate();
                    return true;
                }
            }
            return false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonItem7_Click(object sender, EventArgs e)
        {

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
        private void btnDSThietBi_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                if (!CheckExistForm("frmDanhSachThietBi"))
                {
                    frmDanhSachThietBi frm = new frmDanhSachThietBi();
                    frm.MdiParent = this;
                    frm.SuspendLayout();
                    frm.WindowState = FormWindowState.Maximized;
                    frm.Show();
                    frm.ResumeLayout();
                }
            }
            catch (Exception ex)
            {

            }
            Cursor = Cursors.Default;
        }
        private void btnKiemKe_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                if (!CheckExistForm("frmKiemKeTB"))
                {
                    frmKiemKeTB frm = new frmKiemKeTB();
                    frm.MdiParent = this;
                    frm.SuspendLayout();
                    frm.WindowState = FormWindowState.Maximized;
                    frm.Show();
                    frm.ResumeLayout();
                }
            }
            catch (Exception ex)
            {

            }
            Cursor = Cursors.Default;
        }
        private void btnTheoDoiHong_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                if (!CheckExistForm("frmDSThietBiHongMat"))
                {
                    frmDSThietBiHongMat frm = new frmDSThietBiHongMat();
                    frm.MdiParent = this;
                    frm.SuspendLayout();
                    frm.WindowState = FormWindowState.Maximized;
                    frm.Show();
                    frm.ResumeLayout();
                }
            }
            catch (Exception ex)
            {

            }
            Cursor = Cursors.Default;
        }
        private void BtnThanhLy_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                if (!CheckExistForm("frmDSThanhLyTB"))
                {
                    frmDSThanhLyTB frm = new frmDSThanhLyTB();
                    frm.MdiParent = this;
                    frm.SuspendLayout();
                    frm.WindowState = FormWindowState.Maximized;
                    frm.Show();
                    frm.ResumeLayout();
                }
            }
            catch (Exception ex)
            {

            }
            Cursor = Cursors.Default;

        }
        private void btnGiamTB_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                if (!CheckExistForm("frmDSGiamThietBi"))
                {
                    frmDSGiamThietBi frm = new frmDSGiamThietBi();
                    frm.MdiParent = this;
                    frm.SuspendLayout();
                    frm.WindowState = FormWindowState.Maximized;
                    frm.Show();
                    frm.ResumeLayout();
                }
            }
            catch (Exception ex)
            {

            }
            Cursor = Cursors.Default;

        }
        private void btnSuaChua_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                if (!CheckExistForm("frmDSSuaChuaThietBi"))
                {
                    frmDSSuaChuaThietBi frm = new frmDSSuaChuaThietBi();
                    frm.MdiParent = this;
                    frm.SuspendLayout();
                    frm.WindowState = FormWindowState.Maximized;
                    frm.Show();
                    frm.ResumeLayout();
                }
            }
            catch (Exception ex)
            {

            }
            Cursor = Cursors.Default;

        }
        private void btnTangTB_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                if (!CheckExistForm("frmDSPhieuTangTB"))
                {
                    frmDSPhieuTangTB frm = new frmDSPhieuTangTB();
                    frm.MdiParent = this;
                    frm.SuspendLayout();
                    frm.WindowState = FormWindowState.Maximized;
                    frm.Show();
                    frm.ResumeLayout();
                }
            }
            catch (Exception ex)
            {

            }
            Cursor = Cursors.Default;
        }
        private void btnDeNghiMua_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                if (!CheckExistForm("frmDSDeNghiMuaThietBi"))
                {
                    frmDSDeNghiMuaThietBi frm = new frmDSDeNghiMuaThietBi();
                    frm.MdiParent = this;
                    frm.SuspendLayout();
                    frm.WindowState = FormWindowState.Maximized;
                    frm.Show();
                    frm.ResumeLayout();
                }
            }
            catch (Exception ex)
            {

            }
            Cursor = Cursors.Default;
        }

        private void btnThietBi_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            toolmenuTB.Visible = true;
            btnDSThietBi.Click += btnDSThietBi_Click;
            btnKiemKe.Click += btnKiemKe_Click;
            btnTheoDoiHong.Click += btnTheoDoiHong_Click;
            btnThanhLy.Click += BtnThanhLy_Click;
            btnGiamTB.Click += btnGiamTB_Click;
            btnSuaChua.Click += btnSuaChua_Click;
            btnTangTB.Click += btnTangTB_Click;
            btnDeNghiMua.Click += btnDeNghiMua_Click;
            btnDSThietBi.PerformClick();
        }

        private void btnMuonTra_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                if (!CheckExistForm("frmDanhSachMuonTB"))
                {
                    frmDanhSachMuonTB frm = new frmDanhSachMuonTB();
                    frm.SuspendLayout();
                    frm.MdiParent = this;
                    frm.WindowState = FormWindowState.Maximized;
                    frm.Show();
                    frm.ResumeLayout();
                }
            }
            catch (Exception ex)
            {

            }
            Cursor = Cursors.Default;

        }
    }
}
