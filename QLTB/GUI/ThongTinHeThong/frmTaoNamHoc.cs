using QLTB.Handler;
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
    public partial class frmTaoNamHoc : DevComponents.DotNetBar.Office2007Form
    {
        private DbThongTinNHHandler handler = new DbThongTinNHHandler();
        private ThongTinNamHocModel workingObject;
        public frmTaoNamHoc()
        {
            InitializeComponent();
            workingObject = null;
        }
        public frmTaoNamHoc(int Id)
        {
            InitializeComponent();
            workingObject = handler.GetById(Id);
        }
        private void loadForm()
        {
            if (workingObject != null)
            {
                txtStartYear.Value = workingObject.NamBatDau;
                txtEndYear.Value = workingObject.NamKetThuc;
                dpickerStart1st.Value = workingObject.BatDauHK1;
                dpickerStart2nd.Value = workingObject.BatDauHK2;
                dpickerEndYear.Value = workingObject.KetThucNamHoc;
                txtGhiChu.Text = workingObject.GhiChu;
            }
            else
            {

            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (workingObject != null)
            {
                workingObject.NamBatDau = (int)txtStartYear.Value;
                workingObject.NamKetThuc = (int)txtEndYear.Value;
                workingObject.BatDauHK1 = dpickerStart1st.Value;
                workingObject.BatDauHK2 = dpickerStart2nd.Value;
                workingObject.KetThucNamHoc = dpickerEndYear.Value;
                workingObject.GhiChu = txtGhiChu.Text;
                int result = handler.Update(workingObject);
                if (result == 1)
                {
                    MessageBox.Show("Thông tin năm học được thay đổi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thay đổi thông tin năm học không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                workingObject = new ThongTinNamHocModel();
                workingObject.NamBatDau = (int)txtStartYear.Value;
                workingObject.NamKetThuc = (int)txtEndYear.Value;
                workingObject.BatDauHK1 = dpickerStart1st.Value;
                workingObject.BatDauHK2 = dpickerStart2nd.Value;
                workingObject.KetThucNamHoc = dpickerEndYear.Value;
                workingObject.GhiChu = txtGhiChu.Text;

                int result = handler.Create(workingObject);
                if (result == 1)
                {
                    MessageBox.Show("Khởi tạo thông tin năm học thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Khởi tạo thông tin năm học không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
        }

        private void txtStartYear_ValueChanged(object sender, EventArgs e)
        {
            int nam = (int)txtStartYear.Value;
            dpickerStart1st.Value = new DateTime(nam, 1, 1);
            dpickerStart2nd.Value = new DateTime(nam, 1, 1);
            dpickerEndYear.Value = new DateTime(nam, 1, 1);
        }

        private void txtStartYear_ValueChanged_1(object sender, EventArgs e)
        {
            txtEndYear.Value = txtStartYear.Value + 1;
        }

        private void frmTaoNamHoc_Load(object sender, EventArgs e)
        {
            loadForm();
        }

        private void frmTaoNamHoc_FormClosed(object sender, FormClosedEventArgs e)
        {
            var owner = Owner as Form1;
            var ds = owner.ActiveControl as frmDanhSachNamHoc;
            ds.ReloadData();
        }

        private void frmTaoNamHoc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave_Click(null, null);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
