﻿using QLTB.Model;
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
namespace QLTB.GUI
{
    public partial class frmNhapKhauTB : DevComponents.DotNetBar.Office2007Form
    {
        private int step;
        private UC_ChonTiepNguon ChonTiepNguon;
        private UC_GhepCotDuLieu GhepCot;
        private UC_KhoPhongBM KhoPhong;
        private UC_NguonKinhPhi NguonKP;
        private UC_ThietBiGD ThietBiGD;
        private List<Columnmapping> Cot;
        private List<Columnmapping> PhongHoc;
        private List<Columnmapping> NguonKp;
        private bool firstLoad = true;
        public frmNhapKhauTB()
        {
            InitializeComponent();
            step = 1;
            ChonTiepNguon = new UC_ChonTiepNguon();
            NextStep(ChonTiepNguon);
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
        #region Perform steps
        /// <summary>
        /// Chọn tệp nguôn
        /// </summary>
        public void PerformFirstStep()
        {
            if (ChonTiepNguon.setData())
            {

                #region Khởi tạo cột trong phần mềm
                var desHeader = new List<Columnmapping>();
                int i = 1;
                desHeader.Add(new Columnmapping
                {
                    Index = i++,
                    Ten = "Mã thiết bị"
                });
                desHeader.Add(new Columnmapping
                {
                    Index = i++,
                    Ten = "Tên thiết bị"
                });
                desHeader.Add(new Columnmapping
                {
                    Index = i++,
                    Ten = "Phòng học"
                });
                desHeader.Add(new Columnmapping
                {
                    Index = i++,
                    Ten = "Quy cách sử dụng"
                });
                desHeader.Add(new Columnmapping
                {
                    Index = i++,
                    Ten = "Nguồn kinh phí"
                });
                desHeader.Add(new Columnmapping
                {
                    Index = i++,
                    Ten = "Năm đưa vào SD"
                });
                desHeader.Add(new Columnmapping
                {
                    Index = i++,
                    Ten = "Ngày đưa vào SD"
                });
                desHeader.Add(new Columnmapping
                {
                    Index = i++,
                    Ten = "Năm theo dõi"
                });
                desHeader.Add(new Columnmapping
                {
                    Index = i++,
                    Ten = "Số lượng"
                });
                desHeader.Add(new Columnmapping
                {
                    Index = i++,
                    Ten = "Đơn giá"
                });
                desHeader.Add(new Columnmapping
                {
                    Index = i++,
                    Ten = "Thành tiền"
                });
                desHeader.Add(new Columnmapping
                {
                    Index = i++,
                    Ten = "Nước sản xuất"
                });
                desHeader.Add(new Columnmapping
                {
                    Index = i++,
                    Ten = "Ngày sản xuất"
                });
                desHeader.Add(new Columnmapping
                {
                    Index = i++,
                    Ten = "Hạn sử dụng"
                });
                desHeader.Add(new Columnmapping
                {
                    Index = i++,
                    Ten = "Ghi chú"
                });
                #endregion
                #region Khởi tạo cột dữ liệu
                var headername = new List<Columnmapping>();
                i = 1;
                headername.Add(new Columnmapping
                {
                    Index = i++,
                    Ten = "ThietBiId"
                });
                headername.Add(new Columnmapping
                {
                    Index = i++,
                    Ten = "Ten"
                });
                headername.Add(new Columnmapping
                {
                    Index = i++,
                    Ten = "PhongHocId"
                });
                headername.Add(new Columnmapping
                {
                    Index = i++,
                    Ten = "QuyCachSD"
                });
                headername.Add(new Columnmapping
                {
                    Index = i++,
                    Ten = "NguonKinhPhiId"
                });
                headername.Add(new Columnmapping
                {
                    Index = i++,
                    Ten = "NamDuaVaoSD"
                });
                headername.Add(new Columnmapping
                {
                    Index = i++,
                    Ten = "NgayDuaVaoSD"
                });
                headername.Add(new Columnmapping
                {
                    Index = i++,
                    Ten = "NamTheoDoi"
                });
                headername.Add(new Columnmapping
                {
                    Index = i++,
                    Ten = "SoLuong"
                });
                headername.Add(new Columnmapping
                {
                    Index = i++,
                    Ten = "DonGia"
                });
                headername.Add(new Columnmapping
                {
                    Index = i++,
                    Ten = "ThanhTien"
                });
                headername.Add(new Columnmapping
                {
                    Index = i++,
                    Ten = "NuocSanXuat"
                });
                headername.Add(new Columnmapping
                {
                    Index = i++,
                    Ten = "NgaySanXuat"
                });
                headername.Add(new Columnmapping
                {
                    Index = i++,
                    Ten = "HanSD"
                });
                headername.Add(new Columnmapping
                {
                    Index = i++,
                    Ten = "GhiChu"
                });
                #endregion
                var sourceHeader = ChonTiepNguon.Info.header;
                if (sourceHeader != null)
                {
                    GhepCot = new UC_GhepCotDuLieu(desHeader, sourceHeader, headername);
                    NextStep(GhepCot);
                    step++;
                    btnBack.Visible = true;
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Đọc file không thành công", "Thông báo");
            }
        }
        /// <summary>
        /// Ghép cột dữ liệu
        /// </summary>
        public void PerformSecondStep()
        {
            Cot = GhepCot.GetResult();
            var desKhoPhong = new List<Columnmapping>();
            var khophong = new DbPhongBMHandler().GetNames();
            foreach (var item in khophong)
            {
                desKhoPhong.Add(new Columnmapping
                {
                    Index = item.PhongHocId,
                    Ten = item.Ten
                });
            }
            var srcKhoPhong = ChonTiepNguon.Info.khophong;
            if (srcKhoPhong != null)
            {
                KhoPhong = new UC_KhoPhongBM(desKhoPhong, srcKhoPhong);
                NextStep(KhoPhong);
                step++;
                btnBack.Visible = true;
            }
            else
            {
                MessageBox.Show("Đọc file không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        /// <summary>
        /// Kho phòng bộ môn
        /// </summary>
        public void PerformThirdStep()
        {
            PhongHoc = KhoPhong.GetResult();
            //
            //Danh sách nguồn kinh phí trong thiết bị nguồn
            var src = ChonTiepNguon.Info.nguonkinhphi;
            var des = new DbNguonKinhPhiHandler().GetForImport();
            if ((src != null) && (des != null))
            {
                NguonKP = new UC_NguonKinhPhi(des, src);
                NextStep(NguonKP);
                step++;
                btnBack.Visible = true;
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Thiết bị giáo dục
        /// </summary>
        public void PerformFourthStep()
        {
            NguonKp = NguonKP.GetResult();
            try
            {
                var ds = new DbImportHandler().Read(ChonTiepNguon.Info.filename, ChonTiepNguon.Info.headerindex, ChonTiepNguon.Info.sheetindex, Cot, PhongHoc, NguonKp);
                ThietBiGD = new UC_ThietBiGD(ds, ChonTiepNguon.Info.thietbichuaco);
                NextStep(ThietBiGD);
                step++;
                btnBack.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Nguồn kinh phí
        /// </summary>
        public void PerformFifthStep()
        {


        }
        #endregion
        private void NextStep(UserControl u)
        {
            pnlHolder.SuspendLayout();
            pnlHolder.Visible = false;
            pnlHolder.Controls.Clear();
            u.Dock = DockStyle.Fill;
            pnlHolder.Controls.Add(u);
            pnlHolder.ResumeLayout();
            pnlHolder.Visible = true;
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            switch (step)
            {
                case 1:
                    {
                        PerformFirstStep();
                        break;
                    }
                case 2: { PerformSecondStep(); break; }
                case 3: { PerformThirdStep(); break; }
                case 4: { PerformFourthStep(); break; }
                case 5: { PerformFifthStep(); break; }
                default: { MessageBox.Show("Đang xây dựng tiếp"); break; }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //if (step > 1)
            //{
            //    switch (step)
            //    {
            //        case 2:
            //            { NextStep(firstStep); step--; btnBack.Visible = false; break; }
            //        case 3: { NextStep(secondtStep); step--; btnBack.Visible = true; break; }
            //        default: { MessageBox.Show("Đang xây dựng tiếp"); break; }
            //    }
            //}
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
