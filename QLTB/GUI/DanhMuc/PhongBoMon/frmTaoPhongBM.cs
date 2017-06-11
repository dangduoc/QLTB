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
using QLTB.Utils;

namespace QLTB.GUI
{
    public partial class frmTaoPhongBM : DevComponents.DotNetBar.Office2007Form
    {
        private DbPhongBMHandler handler = new DbPhongBMHandler();
        private DanhSachModel dshandler = new DanhSachModel();
        private PhongBoMonModel Phong;
        public frmTaoPhongBM()
        {
            InitializeComponent();
        }
        public frmTaoPhongBM(int id)
        {
            InitializeComponent();
            Phong = handler.GetById(id);
            if (Phong == null)
            {
                MessageBox.Show("Không tìm thấy phòng bộ môn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }
        private void loadForm()
        {
            foreach(var item in layoutControl1.Controls.OfType<DevComponents.DotNetBar.Controls.ComboBoxEx>())
            {
                item.ValueMember = "key";
                item.DisplayMember = "value";
            }
            //
            cbbLoaiPhong.DataSource = dshandler.LoaiPhongTN.Select(p => new { value = p.Ten, key = p.Id }).ToList();
            cbbMonHoc.DataSource=new DbMonHocHandler().GetNames().Select(p => new { value = p.Ten, key = p.MonHocId }).ToList();
            cbbXepLoai.DataSource=dshandler.XepLoaiPhongBM.Select(p => new { value = p.Ten, key = p.Id }).ToList();
            if (Phong != null)
            {
                txtTen.Text = Phong.Ten;
                txtDienTich.Text = Phong.DienTich.ToString();
                txtSoCanBo.Text = Phong.SoCanBo.ToString();
                txtNamBatDauSD.Text = Phong.NamDuaVaoSD.ToString();
                txtNamKetThucSD.Text = (Phong.NamDuaVaoSD + 1).ToString();
                cboxPhongChucNang.Checked = (bool)Phong.IsPhongChucNang;
            }
            DisableHighlightCBB();
        }
        private void saveData()
        {
            PhongBoMonModel PhongMoi = new PhongBoMonModel
            {
                Ten = txtTen.Text,
                SoCanBo = Convert.ToInt16(txtSoCanBo.Text),
                NamDuaVaoSD = Convert.ToInt16(txtNamBatDauSD.Text),
                DienTich = Convert.ToDouble(txtDienTich.Text),
                IsPhongChucNang = cboxPhongChucNang.Checked,
                LoaiPhongTNId =  (int?)MyConvert.ChangeType(cbbLoaiPhong.SelectedValue,typeof(int?)),
                MonHocId= (int?)MyConvert.ChangeType(cbbMonHoc.SelectedValue, typeof(int?)),
                XepLoaiId= (int?)MyConvert.ChangeType(cbbXepLoai.SelectedValue, typeof(int?)),
                
            };
            if (Phong != null)
            {
                PhongMoi.TrangThai = Phong.TrangThai;
                PhongMoi.PhongHocId = Phong.PhongHocId;
                int result = handler.Update(PhongMoi);
                if (result == 1)
                {
                    MessageBox.Show("Cập nhật thông tin phòng học thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin phòng học không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                PhongMoi.TrangThai = 1;
                int result = handler.Create(PhongMoi);
                if (result == 1)
                {
                    MessageBox.Show("Thêm mới phòng học thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm mới phòng học không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void DisableHighlightCBB()
        {
            foreach (var item in layoutControl1.Controls.OfType<DevComponents.DotNetBar.Controls.ComboBoxEx>())
            {
                BeginInvoke(new Action(() => { item.Select(0, 0); }));
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            saveData();
        }

        private void frmTaoPhongBM_Load(object sender, EventArgs e)
        {
            loadForm();
        }

        private void txtNamBatDauSD_Leave(object sender, EventArgs e)
        {
            int tmp;
            if(int.TryParse(txtNamBatDauSD.Text, out tmp))
            {
                txtNamKetThucSD.Text = (tmp + 1).ToString();
            }

        }

        private void frmTaoPhongBM_KeyDown(object sender, KeyEventArgs e)
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
