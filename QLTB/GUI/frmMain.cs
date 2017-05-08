using QLTB.Model;
using QLTB.Utils;
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
    public partial class frmMain : DevComponents.DotNetBar.Office2007Form
    {
        private UserModel WorkingUser;
        public frmMain()
        {
            InitializeComponent();
            WorkingUser = GlobalVariable.GetUser();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            if (WorkingUser == null) Close();
            SetInformation();
        }
        private void SetInformation()
        {
            statusCurrentDay.Text = DateTime.Today.ToString("dd/M/yyyy");
            statusUser.Text = WorkingUser.UserName;
            //Set up role

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
        private void btnDanhSachTB_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (!CheckExistForm("frmDanhSachThietBi"))
                {
                    Application.DoEvents();
                    frmDanhSachThietBi childForm = new frmDanhSachThietBi();
                    childForm.MdiParent = this;
                    childForm.WindowState = FormWindowState.Maximized;
                    childForm.Show();

                }
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
            }
        }
        private void btnNhapTB_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (!CheckExistForm("frmKhaiBaoThietBi"))
                {
                    Application.DoEvents();
                    frmKhaiBaoThietBi childForm = new frmKhaiBaoThietBi();
                    childForm.MdiParent = this;
                    childForm.WindowState = FormWindowState.Maximized;
                    childForm.Show();

                }
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
            }
        }
        private void btnDMThietBi_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (!CheckExistForm("frmDMThietBiTT"))
                {
                    Application.DoEvents();
                    frmDMThietBiTT childForm = new frmDMThietBiTT();
                    childForm.MdiParent = this;
                    childForm.WindowState = FormWindowState.Maximized;
                    childForm.Show();

                }
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
            }
        }
        private void btnDMCanBoTB_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (!CheckExistForm("frmDMCanBoThietBi"))
                {
                    Application.DoEvents();
                    frmDMCanBoThietBi childForm = new frmDMCanBoThietBi();
                    childForm.MdiParent = this;
                    childForm.WindowState = FormWindowState.Maximized;
                    childForm.Show();

                }
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
            }
        }
        private void btnDMPhongBM_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (!CheckExistForm("frmDMPhongBoMon"))
                {
                    Application.DoEvents();
                    frmDMPhongBoMon childForm = new frmDMPhongBoMon();
                    childForm.MdiParent = this;
                    childForm.WindowState = FormWindowState.Maximized;
                    childForm.Show();

                }
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
            }
        }
        private void btnDMKhoiLop_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (!CheckExistForm("frmDMKhoiLop"))
                {
                    Application.DoEvents();
                    frmDMKhoiLop childForm = new frmDMKhoiLop();
                    childForm.MdiParent = this;
                    childForm.WindowState = FormWindowState.Maximized;
                    childForm.Show();

                }
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
            }
        }
        private void btnDMLopHoc_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (!CheckExistForm("frmDMLopHoc"))
                {
                    Application.DoEvents();
                    frmDMLopHoc childForm = new frmDMLopHoc();
                    childForm.MdiParent = this;
                    childForm.WindowState = FormWindowState.Maximized;
                    childForm.Show();

                }
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
            }
        }
        private void btnDMToBM_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (!CheckExistForm("frmDMToBoMon"))
                {
                    Application.DoEvents();
                    frmDMToBoMon childForm = new frmDMToBoMon();
                    childForm.MdiParent = this;
                    childForm.WindowState = FormWindowState.Maximized;
                    childForm.Show();

                }
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
            }
        }
        private void btnDMMonHoc_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (!CheckExistForm("frmDMMonHoc"))
                {
                    Application.DoEvents();
                    frmDMMonHoc childForm = new frmDMMonHoc();
                    childForm.MdiParent = this;
                    childForm.WindowState = FormWindowState.Maximized;
                    childForm.Show();

                }
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
            }
        }
        private void btnDMGiaoVien_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (!CheckExistForm("frmDMGiaoVien"))
                {
                    Application.DoEvents();
                    frmDMGiaoVien childForm = new frmDMGiaoVien();
                    childForm.MdiParent = this;
                    childForm.WindowState = FormWindowState.Maximized;
                    childForm.Show();

                }
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
            }
        }
        private void btnDMNguonKinhPhi_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (!CheckExistForm("frmDMNguonKinhPhi"))
                {
                    Application.DoEvents();
                    frmDMNguonKinhPhi childForm = new frmDMNguonKinhPhi();
                    childForm.MdiParent = this;
                    childForm.WindowState = FormWindowState.Maximized;
                    childForm.Show();

                }
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
            }
        }
        private void btnThongTinDV_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (!CheckExistForm("frmThongTinDonVi"))
                {
                    Application.DoEvents();
                    frmThongTinDonVi childForm = new frmThongTinDonVi();
                    childForm.MdiParent = this;
                    childForm.WindowState = FormWindowState.Maximized;
                    childForm.Show();

                }
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
            }
        }
        private void btnDSMuonThietBi_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (!CheckExistForm("frmDanhSachMuonTB"))
                {
                    Application.DoEvents();
                    frmDanhSachMuonTB childForm = new frmDanhSachMuonTB();
                    childForm.MdiParent = this;
                    childForm.WindowState = FormWindowState.Maximized;
                    childForm.Show();

                }
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
            }
        }
        private void btnDKMuonThietBi_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (!CheckExistForm("frmThietBiMuon"))
                {
                    Application.DoEvents();
                    frmThietBiMuon childForm = new frmThietBiMuon();
                    childForm.MdiParent = this;
                    childForm.WindowState = FormWindowState.Maximized;
                    childForm.Show();

                }
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
            }
        }
        private void btnKiemKeTB_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (!CheckExistForm("frmKiemKeTB"))
                {
                    Application.DoEvents();
                    frmKiemKeTB childForm = new frmKiemKeTB();
                    childForm.MdiParent = this;
                    childForm.WindowState = FormWindowState.Maximized;
                    childForm.Show();

                }
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
            }
        }
        private void btnTheoDoiHongMat_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (!CheckExistForm("frmDSThietBiHongMat"))
                {
                    Application.DoEvents();
                    frmDSThietBiHongMat childForm = new frmDSThietBiHongMat();
                    childForm.MdiParent = this;
                    childForm.WindowState = FormWindowState.Maximized;
                    childForm.Show();

                }
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
            }
        }
        private void btnTheoDoiSuaChua_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (!CheckExistForm("frmDSSuaChuaThietBi"))
                {
                    Application.DoEvents();
                    frmDSSuaChuaThietBi childForm = new frmDSSuaChuaThietBi();
                    childForm.MdiParent = this;
                    childForm.WindowState = FormWindowState.Maximized;
                    childForm.Show();

                }
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
            }
        }
        private void btnTheoDoiGiam_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (!CheckExistForm("frmDSGiamThietBi"))
                {
                    Application.DoEvents();
                    frmDSGiamThietBi childForm = new frmDSGiamThietBi();
                    childForm.MdiParent = this;
                    childForm.WindowState = FormWindowState.Maximized;
                    childForm.Show();

                }
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
            }
        }
        private void btnTheoDoiThanhLy_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (!CheckExistForm("frmDSThanhLyTB"))
                {
                    Application.DoEvents();
                    frmDSThanhLyTB  childForm = new frmDSThanhLyTB();
                    childForm.MdiParent = this;
                    childForm.WindowState = FormWindowState.Maximized;
                    childForm.Show();

                }
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
            }
        }
        private void btnDSMuonPhongBM_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (!CheckExistForm("frmDSMuonPhongBM"))
                {
                    Application.DoEvents();
                    frmDSMuonPhongBM childForm = new frmDSMuonPhongBM();
                    childForm.MdiParent = this;
                    childForm.WindowState = FormWindowState.Maximized;
                    childForm.Show();

                }
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
            }
        }
        private void btnDKMuonPhongBM_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (!CheckExistForm("frmCTPhieuMuonPhong"))
                {
                    Application.DoEvents();
                    frmCTPhieuMuonPhong childForm = new frmCTPhieuMuonPhong();
                    childForm.MdiParent = this;
                    childForm.WindowState = FormWindowState.Maximized;
                    childForm.Show();

                }
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void TreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (TreeView.SelectedNode == null) return;
            Done_Function_Menu(TreeView.SelectedNode.Name.Trim());
        }
       
        private void Done_Function_Menu(string NameFunction)
        {
            try
            {
                if (NameFunction.Trim().Substring(0, 3) != "btn") return;

                switch (NameFunction)
                {
                    #region CÁC CHỨC NĂNG
                    case "btnDanhSachTB":
                        btnDanhSachTB_Click(null, null);
                        break;
                    case "btnNhapTB":
                        btnNhapTB_Click(null, null);
                        break;
                    case "btnDMThietBi":
                        btnDMThietBi_Click(null, null);
                        break;
                    case "btnDMCanBoTB":
                        btnDMCanBoTB_Click(null, null);
                        break;
                    case "btnDMPhongBM":
                        btnDMPhongBM_Click(null, null);
                        break;
                    case "btnDMKhoiLop":
                        btnDMKhoiLop_Click(null, null);
                        break;
                    case "btnDMLopHoc":
                        btnDMLopHoc_Click(null, null);
                        break;
                    case "btnDMToBM":
                        btnDMToBM_Click(null, null);
                        break;
                    case "btnDMMonHoc":
                        btnDMMonHoc_Click(null, null);
                        break;
                    case "btnDMGiaoVien":
                        btnDMGiaoVien_Click(null, null);
                        break;
                    case "btnDMNguonKinhPhi":
                        btnDMNguonKinhPhi_Click(null, null);
                        break;
                    case "btnThongTinDV":
                        btnThongTinDV_Click(null, null);
                        break;
                    case "btnDSMuonThietBi":
                        btnDSMuonThietBi_Click(null, null);
                        break;
                    case "btnDKMuonThietBi":
                        btnDKMuonThietBi_Click(null, null);
                        break;
                    case "btnKiemKeTB":
                        btnKiemKeTB_Click(null, null);
                        break;
                    case "btnTheoDoiHongMat":
                        btnTheoDoiHongMat_Click(null, null);
                        break;
                    case "btnTheoDoiGiam":
                        btnTheoDoiGiam_Click(null, null);
                        break;
                    case "btnTheoDoiThanhLy":
                        btnTheoDoiThanhLy_Click(null, null);
                        break;
                    case "btnTheoDoiSuaChua":
                        btnTheoDoiSuaChua_Click(null, null);
                        break;
                    case "btnDSMuonPhongBM":
                        btnDSMuonPhongBM_Click(null, null);
                        break;
                    case "btnDKMuonPhongBM":
                        btnDKMuonPhongBM_Click(null, null);
                        break;
                    default:
                        MessageBox.Show("Chức năng này chưa được xây dựng ....");
                        break;
                        #endregion
                }
            }
            catch (Exception ex)
            {
               
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr= MessageBox.Show("Bạn có chắc muốn đóng phần mềm lại không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
        }

        private void TreeView_DoubleClick(object sender, EventArgs e)
        {

        }

        private void TreeView_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReLogin_Click(object sender, EventArgs e)
        {
            //DialogResult dr = MessageBox.Show("Bạn có chắc muốn đăng nhập lại chứ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if(dr==DialogResult.Yes)
            //{ 
                 
            //}
            Application.Restart();
        }
    }
}
