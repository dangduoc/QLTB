using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTB.Handler;
using QLTB.Model;
namespace QLTB.GUI
{
    public partial class frmCTTaiKhoan : DevComponents.DotNetBar.Office2007Form
    {
        private UserHandler handler = new UserHandler();
        private UserModel User;
        public frmCTTaiKhoan()
        {
            InitializeComponent();
            User = null;
        }
        public frmCTTaiKhoan(int id)
        {
            InitializeComponent();
            User = handler.GetUserById(id);
            if (User == null)
            {
                MessageBox.Show("Không tìm thấy tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }
        private void loadForm()
        {
            //trường hợp sửa
            if (User != null)
            {
                txtUserName.Text = User.UserName;
                txtPassword.Text = User.PassWord;
                txtFullName.Text = User.Name;
                txtSDT.Text = User.PhoneNumber;
                txtEmail.Text = User.Email;
                txtGhiChu.Text = User.Note;
                cboxActive.Checked = User.isActived != null ? (bool)User.isActived : false;
                cboxAdmin.Checked = User.UserRoleId == 1;
            }
        }
        /// <summary>
        /// Saving data
        /// </summary>
        private void saveData()
        {
            UserModel NewUser = new UserModel
            {
                UserName = txtUserName.Text,
                PassWord = txtPassword.Text,
                Name = txtEmail.Text,
                Email = txtEmail.Text,
                PhoneNumber = txtSDT.Text,
                Note = txtGhiChu.Text,
                isActived = cboxActive.Checked,
                UserRoleId = cboxAdmin.Checked ? 1 : 0
            };
            //Editing
            if (User != null)
            {
                int result = handler.Update(NewUser);
                if (result == 1)
                {
                    MessageBox.Show("Thay đổi thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Thay đổi thông tin không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //Creating
            else
            {
                int result = handler.Create(NewUser);
                if (result == 1)
                {
                    MessageBox.Show("Thêm tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    resetForm();
                }
                else
                {
                    MessageBox.Show("Thêm tài khoản không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }
        private void resetForm()
        {
            txtGhiChu.Text = "";
            User = null;
            txtEmail.Text = "";
            txtFullName.Text = "";
            txtPassword.Text = "";
            txtSDT.Text = "";
            txtUserName.Text = "";
            cboxAdmin.Checked = false;
        }
        private void frmCTTaiKhoan_Load(object sender, EventArgs e)
        {
            try
            {
                loadForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Xảy ra lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                saveData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Xảy ra lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
