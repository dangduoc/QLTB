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
    public partial class frmTaoCanBoTB : DevComponents.DotNetBar.Office2007Form
    {
        private CanBoThietBiModel CanBo;
        private DanhSachModel dshandler = new DanhSachModel();
        private DbCanBoThietBiHandler handler = new DbCanBoThietBiHandler();
        public frmTaoCanBoTB()
        {
            InitializeComponent();
            CanBo = null;
        }
        public frmTaoCanBoTB(string Id)
        {
            InitializeComponent();
            CanBo = handler.GetById(Id);
            txtMaCanBo.Enabled = false;
            if (CanBo == null)
            {
                MessageBox.Show("Không tìm thấy cán bộ");
                Close();
            }
        }
        /// <summary>
        /// Loading form
        /// </summary>
        private void loadForm()
        {
            //Comboboxes
            foreach (var item in layoutControl1.Controls.OfType<DevComponents.DotNetBar.Controls.ComboBoxEx>())
            {
                item.DisplayMember = "value";
                item.ValueMember = "key";
            }
            //phụ trách
            cbbPhuTrach.DataSource = dshandler.PhuTrachCanBoTB.Select(p => new { key = p.Id, value = p.Ten }).ToList();
            //Gioi tinh
            cbbGioiTinh.DataSource = dshandler.GioiTinh.Select(p => new { key = p.GioiTinhId, value = p.Ten }).ToList();
            //thoi gian quan ly
            cbbBatDau.DataSource = new DbThongTinNHHandler().GetAll().Select(p => new { key = p.NamHocId, value = p.ThoiGian }).ToList();
            cbbKetThuc.DataSource = new DbThongTinNHHandler().GetAll().Select(p => new { key = p.NamHocId, value = p.ThoiGian }).ToList();

            //trường hợp sửa
            if (CanBo != null)
            {
                txtMaCanBo.Text = CanBo.CanBoThietBiId;
                txtHoDem.Text = CanBo.HoVaDem;
                txtTen.Text = CanBo.Ten;
                txtTrinhDoVH.Text = CanBo.TrinhDoVanHoa;
                txtGhiChu.Text = CanBo.GhiChu;
                //
                cbbGioiTinh.SelectedValue = CanBo.GioiTinhId;
                cbbPhuTrach.SelectedValue = CanBo.PhuTrachId;
                cbbBatDau.SelectedText = CanBo.ThoiGianBatDau;
                cbbKetThuc.SelectedText = CanBo.ThoiGianKetThuc;
                //
                cboxTrinhDoNV.Checked = (bool)CanBo.IsCoTrinhDoNghiepVu;
            }
            else
            {
                txtMaCanBo.Text = handler.GenerateCode();
                txtMaCanBo.Enabled = false;
            }

        }
        /// <summary>
        /// Saving data
        /// </summary>
        private void saveData()
        {
            CanBoThietBiModel CanBoMoi = new CanBoThietBiModel
            {
                CanBoThietBiId = txtMaCanBo.Text,
                HoVaDem = txtHoDem.Text,
                Ten = txtTen.Text,
                TrinhDoVanHoa = txtTrinhDoVH.Text,
                GhiChu = txtGhiChu.Text,
                GioiTinhId = (int?)MyConvert.ChangeType(cbbGioiTinh.SelectedValue, typeof(int?)),
                PhuTrachId = (int?)MyConvert.ChangeType(cbbPhuTrach.SelectedValue, typeof(int?)),
                ThoiGianBatDau = cbbBatDau.Text,
                ThoiGianKetThuc = cbbKetThuc.Text,
                IsCoTrinhDoNghiepVu = cboxTrinhDoNV.Checked,
                TrangThai = 1
            };
            //Editing
            if (CanBo != null)
            {
                int result = handler.Update(CanBoMoi);
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
                int result = handler.Create(CanBoMoi);
                if (result == 1)
                {
                    MessageBox.Show("Thêm cán bộ thiết bị thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    resetForm();
                }
                else
                {
                    MessageBox.Show("Thêm cán bộ thiết bị không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }
        private void resetForm()
        {
            txtGhiChu.Text = "";
            txtHoDem.Text = "";
            txtMaCanBo.Text = "";
            txtTen.Text = "";
            txtTrinhDoVH.Text = "";
            cbbBatDau.Text = "";
            cbbKetThuc.Text = "";
            cbbGioiTinh.SelectedIndex = 0;
            cbbPhuTrach.SelectedIndex = 0;
            CanBo = null;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                saveData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Xảy ra lỗi", MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
            }

        }

        private void frmTaoCanBoTB_Load(object sender, EventArgs e)
        {
            try
            {
                loadForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Xảy ra lỗi", MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmTaoCanBoTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                btnSave_Click(null, null);
            }
        }
    }
}
