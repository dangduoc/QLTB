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
    public partial class frmTaoThietBiTT : DevComponents.DotNetBar.Office2007Form
    {
        private DbThietBiTTHandler handler = new DbThietBiTTHandler();
        private DanhSachModel dshandler = new DanhSachModel();
        private ThietBiToiThieuModel ThietBi;
        public frmTaoThietBiTT()
        {
            InitializeComponent();
            ThietBi = null;
        }
        public frmTaoThietBiTT(string id)
        {
            InitializeComponent();
            ThietBi = handler.GetById(id);

            if (ThietBi == null)
            {
                MessageBox.Show("Không tìm thấy thiết bị với mã này");
                Close();
            }
            else
            {
                txtMaTB.Enabled = false;
            }
        }
        private void loadForm()
        {
            //combobox
            foreach(var item in layoutControl1.Controls.OfType<DevComponents.DotNetBar.Controls.ComboBoxEx>())
            {
                item.DisplayMember = "value";
                item.ValueMember = "key";
            }
            //
            //loai thiet bi
            cbbLoaiTB.DataSource = dshandler.LoaiThietBi.Select(p => new { key = p.Id, value = p.Ten }).ToList();
            //don vi tinh
            cbbDVT.DataSource=new DbDanhSachHandler().GetDVT().Select(p => new { key = p.DonViTinhId, value = p.Ten }).ToList();
            //mon hoc
            cbbMonHoc.DataSource=new DbDanhSachHandler().GetMonHoc().Select(p => new { key = p.MonHocId, value = p.Ten }).ToList();
            //dau muc thiet bi
            cbbThuocDauMuc.DataSource= dshandler.DauMucThietBi.Select(p => new { key = p.Id, value = p.Ten }).ToList();
            //
            if (ThietBi != null)
            {
                txtMaTB.Text = ThietBi.ThietBiId;
                txtMoTa.Text = ThietBi.MoTa;
                txtSoLuongTT.Text = ThietBi.SoLuong.ToString();
                txtTenTB.Text = ThietBi.Ten;
                cbbDVT.SelectedValue = ThietBi.DonViTinhId;
                cbbLoaiTB.SelectedValue = ThietBi.LoaiThietBiId;
                cbbMonHoc.SelectedValue = ThietBi.MonHocId;
                cbbThuocDauMuc.SelectedValue = ThietBi.DauMucId;
                cboxDanhChoGV.Checked = ThietBi.IsDanhChoGV;
                cboxDanhChoHS.Checked = ThietBi.IsDanhChoHS;
                cboxThuocDM.Checked = ThietBi.IsThuocDMTT;
            }
            DisableHighlightCBB();
        }
        private void DisableHighlightCBB()
        {
            foreach (var item in layoutControl1.Controls.OfType<DevComponents.DotNetBar.Controls.ComboBoxEx>())
            {
                BeginInvoke(new Action(() => { item.Select(0, 0); }));
            }
        }
        private void saveData()
        {
            ThietBiToiThieuModel ThietBiMoi = new ThietBiToiThieuModel
            {
                ThietBiId=txtMaTB.Text,
                Ten=txtTenTB.Text,
                SoLuong= Convert.ToInt16(txtSoLuongTT.Text),
                DauMucId = (int?)MyConvert.ChangeType(cbbThuocDauMuc.SelectedValue, typeof(int?)),
                DonViTinhId=(int)cbbDVT.SelectedValue,
                MonHocId=(int)cbbMonHoc.SelectedValue,
                LoaiThietBiId=(int)cbbLoaiTB.SelectedValue,
                MoTa=txtMoTa.Text,
                IsDanhChoGV=cboxDanhChoGV.Checked,
                IsDanhChoHS=cboxDanhChoHS.Checked,
                IsThuocDMTT=cboxThuocDM.Checked
            };

            foreach(var item in pnlDungChoLop.Controls.OfType<DevComponents.DotNetBar.Controls.CheckBoxX>())
            {
                if (item.Checked)
                {
                    ThietBiMoi.DungChoLopHienThi += item.Text+", ";
                }
            }
            if (!string.IsNullOrEmpty(ThietBiMoi.DungChoLopHienThi))
            {
                ThietBiMoi.DungChoLopHienThi.Remove(ThietBiMoi.DungChoLopHienThi.Length - 2, 2);
            }
            if (ThietBi == null)
            {
               int result= handler.Create(ThietBiMoi);
                if (result == 1)
                {
                    MessageBox.Show("Tạo thành công thiết bị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Tạo thiết bị không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                int result=handler.Update(ThietBiMoi);
                if (result == 1)
                {
                    MessageBox.Show("Cập nhật thông tin thiết bị thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin thiết bị không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           
        }
        private void buttonX2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            string message = "";
            if (handler.CheckId(txtMaTB.Text,out message))
            {
                saveData();
            }
            else
            {
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmTaoThietBiTT_Load(object sender, EventArgs e)
        {
            loadForm();
        }
    }
}
