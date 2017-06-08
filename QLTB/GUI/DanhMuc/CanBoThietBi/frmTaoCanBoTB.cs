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
                GioiTinhId = MyConvert.To<int?>(cbbGioiTinh.SelectedValue),
                PhuTrachId = MyConvert.To<int?>(cbbPhuTrach.SelectedValue),
                ThoiGianBatDau = cbbBatDau.Text,
                ThoiGianKetThuc = cbbKetThuc.Text,
                IsCoTrinhDoNghiepVu = cboxTrinhDoNV.Checked,
                TrangThai = 1
            };
            //Editing
            if (CanBo != null)
            {
                int result = handler.Create(CanBoMoi);
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
                int result = handler.Update(CanBoMoi);
                if (result == 1)
                {
                    MessageBox.Show("Thêm cán bộ thiết bị thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm cán bộ thiết bị không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
          
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveData();
        }
    }
}
