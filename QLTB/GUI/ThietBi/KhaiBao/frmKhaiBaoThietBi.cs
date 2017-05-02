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
    public partial class frmKhaiBaoThietBi : Form
    {
        private ThietBiModel ThietBi;
        private DbThietBiHandler handler = new DbThietBiHandler();
        public frmKhaiBaoThietBi(string Id)
        {
            InitializeComponent();
            ThietBi = handler.GetById(Id);
        }
        public frmKhaiBaoThietBi()
        {
            ThietBi = null;
        }
        private void loadData()
        {
            //combobox ma thiet bi toi thieu
            cbbMaThietBi.DisplayMember = "value";
            cbbMaThietBi.ValueMember = "key";
            cbbMaThietBi.DataSource = new DbThietBiTTHandler().GetMaTB();
            cbbPhongBM.DisplayMember = "value";
            cbbPhongBM.ValueMember = "key";
            cbbPhongBM.DataSource = new DbDanhSachHandler().GetPhongBM().Select(p=> new { key=p.PhongHocId,value=p.Ten}).ToList();
            cbbNguonKinhPhi.DisplayMember = "value";
            cbbNguonKinhPhi.ValueMember = "key";
            cbbNguonKinhPhi.DataSource = new DbNguonKinhPhiHandler().GetForCBB().Select(p => new { key = p.NguonKinhPhiId, value = p.Ten }).ToList();
            cbbMucDichSD.DisplayMember = "value";
            cbbMucDichSD.ValueMember = "key";
            cbbMucDichSD.DataSource = new DbDanhSachHandler().GetMucDichSDPhong().Select(p => new { key = p.MucDichSDPhongId, value = p.Ten }).ToList();
            cbbDVT.DisplayMember = "value";
            cbbDVT.ValueMember = "key";
            cbbDVT.DataSource = new DbDanhSachHandler().GetDVT().Select(p => new { key = p.DonViTinhId, value = p.Ten }).ToList();
            
            //
            if (ThietBi != null)
            {
                cbbMaThietBi.SelectedText = ThietBi.ThietBiId;
                cbbPhongBM.SelectedValue = ThietBi.PhongHocId;
                cbbNguonKinhPhi.SelectedValue = ThietBi.NguonKinhPhiId;
                cbbMucDichSD.SelectedValue = ThietBi.MucDichSDId;
                txtTen.Text = ThietBi.Ten;
                txtSoHieu.Text = ThietBi.SoHieu;
                txtQuyCach.Text = ThietBi.QuyCach;
                txtNamSD.Text = ThietBi.NamDuaVaoSD.ToString();
                txtNamTheoDoi.Text = ThietBi.NamTheoDoi.ToString();
                cbbDVT.SelectedValue = ThietBi.DonViTinhId;
                txtSoLuong.Text = ThietBi.SoLuong.ToString();
                txtDonGia.Text = ThietBi.DonGia.ToString();
                txtThanhTien.Text = ThietBi.ThanhTien.ToString();
                txtNuocSX.Text = ThietBi.NuocSX;
                cboxThietBiTuLam.Checked = ThietBi.IsThietBiTuLam;
                //
                if (ThietBi.HanSD != null)
                    dpickerHanSD.Value = ThietBi.HanSD.Value;
                if (ThietBi.NgaySanXuat != null)
                {
                    dpickNgaySX.Value = ThietBi.NgaySanXuat.Value;
                }
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
