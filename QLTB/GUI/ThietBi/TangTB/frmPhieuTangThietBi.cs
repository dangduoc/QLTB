using QLTB.Handler;
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
    public partial class frmPhieuTangThietBi : DevComponents.DotNetBar.Office2007Form
    {
        private PhieuTangTBModel Phieu;
        private List<ThietBiTangGridDisplayModel> dsThietBi = new List<ThietBiTangGridDisplayModel>();
        private DbGhiTangTBHandler handler = new DbGhiTangTBHandler();
        private DbDanhSachHandler dshandler = new DbDanhSachHandler();
        private BindingSource source = new BindingSource();
        public frmPhieuTangThietBi()
        {
            InitializeComponent();
        }
        public frmPhieuTangThietBi(string Id)
        {
            InitializeComponent();
            Phieu = handler.GetById(Id);
        }
        private void loadForm()
        {
            #region Loading data
            //load thong tin phieu 
            if (Phieu != null)
            {
                txtSoPhieu.Text = Phieu.PhieuGhiTangId;
                txtChungTu.Text = Phieu.ChungTuLienQuan;
                txtGhiChu.Text = Phieu.NoiDung;
                dPickerNgayLap.Value = Phieu.NgayLap;
                if (Phieu.ThietBis == null)
                {
                    Phieu.ThietBis = new List<ThietBiTangGridDisplayModel>();

                }
                else
                {
                    dsThietBi = Phieu.ThietBis;
                }
                source.DataSource = MyConvert.ToDataTable<ThietBiTangGridDisplayModel>(dsThietBi);
            }
            else
            {
                //txtSoPhieu.Text = handler.GenerateCode();
                source.DataSource = MyConvert.ToDataTable<ThietBiTangGridDisplayModel>(dsThietBi);
            }


            //load danh sach thiet bi muon
            ADGVDSTB.DataSource = source;
            #endregion
            #region Base Grid Display

            ADGVDSTB.Columns[0].HeaderText = "Mã thiết bị";
            ADGVDSTB.Columns[1].HeaderText = "Số hiệu";
            ADGVDSTB.Columns[2].HeaderText = "Tên thiết bị";
            ADGVDSTB.Columns[3].HeaderText = "Phòng bộ môn";
            ADGVDSTB.Columns[4].HeaderText = "Đơn vị tính";
            ADGVDSTB.Columns[0].ReadOnly = true;
            ADGVDSTB.Columns[1].ReadOnly = true;
            ADGVDSTB.Columns[2].ReadOnly = true;
            ADGVDSTB.Columns[3].ReadOnly = true;
            ADGVDSTB.Columns[4].ReadOnly = true;
            #endregion

            ADGVDSTB.Columns[5].HeaderText = "Số lượng";
            ADGVDSTB.Columns[6].HeaderText = "Đơn giá";
            ADGVDSTB.Columns[7].HeaderText = "Thành tiền";
            ADGVDSTB.Columns[8].HeaderText = "Nguồn kinh phí";




            ADGVDSTB.Columns[0].Width = 70;
            ADGVDSTB.Columns[1].Width = 100;
            ADGVDSTB.Columns[5].Width = 100;
            ADGVDSTB.Columns[4].Width = 100;

            //
            /*Cột xóa button*/
            DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn col1 = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            col1.Name = "Remove";
            col1.Image = imageList1.Images[0];
            col1.Text = "";
            col1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Left;
            col1.FlatStyle = FlatStyle.Flat;
            DevComponents.DotNetBar.ColorScheme color = new DevComponents.DotNetBar.ColorScheme();
            color.ItemBackground = Color.White;
            color.ItemBackground2 = Color.White;
            color.PanelBorder = Color.White;
            color.PanelBackground = Color.White;
            color.PanelBackground2 = Color.White;
            col1.Width = 30;
            col1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            col1.ColorScheme = color;
            col1.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            col1.ToolTipText = "Xóa";
            ADGVDSTB.Columns.Add(col1);
            ADGVDSTB.Columns["Remove"].HeaderText = "";
            //
            ADGVDSTB.CellValueChanged -= ADGVDSTB_CellValueChanged;
            ADGVDSTB.CellValueChanged += ADGVDSTB_CellValueChanged;
            //       
        }
        private void ADGVDSTB_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var sohieu = ADGVDSTB.Rows[e.RowIndex].Cells["SoHieu"].Value.ToString();
            var soluong = Convert.ToInt32(ADGVDSTB.Rows[e.RowIndex].Cells["SoLuongMuon"].Value);
            dsThietBi.Where(p => p.SoHieu.Equals(sohieu)).FirstOrDefault().SoLuongTang = soluong.ToString();
        }
        public void AddToGrid(List<ThietBiTangGridDisplayModel> list)
        {

            var listSoHieu = dsThietBi.Select(p => p.SoHieu).ToList();
            var repeatList = list.Where(p => listSoHieu.Contains(p.SoHieu)).ToList();
            list.RemoveAll(p => listSoHieu.Contains(p.SoHieu));

            dsThietBi = list;
            //

            source = new BindingSource();
            source.DataSource = MyConvert.ToDataTable<ThietBiTangGridDisplayModel>(dsThietBi);
            ADGVDSTB.DataSource = source;
            if (repeatList.Count > 0)
            {
                string str = "";
                foreach (var item in repeatList)
                {
                    str = str + item.SoHieu + ", ";
                }
                MessageBox.Show("Các số hiệu đã có trong danh sách: " + str, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            ADGVDSTB.CellValueChanged -= ADGVDSTB_CellValueChanged;
            ADGVDSTB.CellValueChanged += ADGVDSTB_CellValueChanged;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void saveData()
        {
            var PhieuMoi = new PhieuTangTBModel
            {
                PhieuGhiTangId=txtSoPhieu.Text,
                NgayLap=dPickerNgayLap.Value,
                ChungTuLienQuan=txtChungTu.Text,
                NoiDung=txtGhiChu.Text,
                
            };
            if (Phieu == null)
            {
                PhieuMoi.CreatedByUserId = GlobalVariable.GetUser().UserId;
                PhieuMoi.CreatedOnDate = DateTime.Now;
                PhieuMoi.UpdatedByUserId = PhieuMoi.CreatedByUserId;
                PhieuMoi.UpdatedOnDate = PhieuMoi.CreatedOnDate;
                PhieuMoi.ThietBis = dsThietBi;
                int result = handler.Create(PhieuMoi);
                if (result == 1)
                {
                    MessageBox.Show("Ghi tăng thiết bị thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (result == 0)
                {
                    MessageBox.Show("Ghi tăng thiết bị không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra, xin thử lại khi khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                PhieuMoi.ThietBis = Phieu.ThietBis;
                PhieuMoi.UpdatedByUserId = GlobalVariable.GetUser().UserId;
                PhieuMoi.UpdatedOnDate = DateTime.Now;
                int result = handler.Update(PhieuMoi,dsThietBi);
                if (result == 1)
                {
                    MessageBox.Show("Cập nhật thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (result == 0)
                {
                    MessageBox.Show("Cập nhật thông tin không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra, xin thử lại khi khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            saveData();
        }
        private void frmPhieuTangThietBi_Load(object sender, EventArgs e)
        {
            loadForm();
        }

        private void btnLayTB_Click(object sender, EventArgs e)
        {
            frmDialogDSThietBi frm = new frmDialogDSThietBi(p => p.TrangThai == 0);
            frm.Text = "Danh sách các thiết bị chưa ghi tăng";
            frm.ShowDialog(this);
        }

        private void frmPhieuTangThietBi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
