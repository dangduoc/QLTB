using QLTB.DAL;
using QLTB.DAL.Data;
using QLTB.Report.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTB.Handler
{
    public class DbThongKeHandler
    {
        /// <summary>
        /// Thống kê phiếu ghi tăng thiết bị theo năm học
        /// </summary>
        /// <param name="NamHocId">Mã năm học</param>
        /// <returns></returns>
        public List<GhiTangReportModel> DanhSachGhiTang(int NamHocId)
        {
            try
            {
                using (var unitOfWork= new UnitOfWork())
                {
                    var lst=unitOfWork.GetRepository<QH_PhieuGhiTang_ThietBi>().GetAll()
                    .Join(unitOfWork.GetRepository<TB_PhieuGhiTang>().GetAll(),
                    phieu => phieu.PhieuGhiTangId,
                    qh => qh.PhieuGhiTangId,
                    (phieu, qh) => new
                    {
                        NgayGhiTang = qh.NgayLap.ToString(),
                        PhieuGhiTangId = phieu.PhieuGhiTangId,
                        SoHieu = phieu.SoHieuId,
                        SoLuong = phieu.SoLuong,
                    })
                    .Join(unitOfWork.GetRepository<TB_ThongTinThietBi>().GetAll(),
                    phieu => phieu.SoHieu,
                    tb => tb.SoHieu,
                    (phieu, tb) => new
                    {
                        NgayGhiTang = phieu.NgayGhiTang,
                        PhieuGhiTangId = phieu.PhieuGhiTangId,
                        ThietBiId = tb.ThietBiId,
                        TenTB = tb.Ten,
                        SoHieu = phieu.SoHieu,
                        NuocSX = tb.NuocSanXuat,
                        PhongBM = tb.PhongHocId,
                        DVT = tb.DonViTinhId,
                        SoLuong = phieu.SoLuong,
                        DonGia = tb.DonGia,
                        ThanhTien = tb.ThanhTien,
                        NguonKP = tb.NguonKinhPhiId,
                        GhiChu = tb.GhiChu
                    })
                    .Join(unitOfWork.GetRepository<DM_PhongHocBoMon>().GetAll(),
                    tb => tb.PhongBM,
                    ph => ph.PhongHocId,
                    (tb, ph) => new
                    {
                        NgayGhiTang = tb.NgayGhiTang,
                        PhieuGhiTangId = tb.PhieuGhiTangId,
                        ThietBiId = tb.ThietBiId,
                        TenTB = tb.TenTB,
                        SoHieu = tb.SoHieu,
                        NuocSX = tb.NuocSX,
                        PhongBM = ph.Ten,
                        DVT = tb.DVT,
                        SoLuong = tb.SoLuong,
                        DonGia = tb.DonGia,
                        ThanhTien = tb.ThanhTien,
                        NguonKP = tb.NguonKP,
                        GhiChu = tb.GhiChu
                    })
                    .Join(unitOfWork.GetRepository<DS_DonViTinh>().GetAll(),
                    tb => tb.DVT,
                    dvt => dvt.DonViTinhId,
                    (tb, dvt) => new
                    {
                        NgayGhiTang = tb.NgayGhiTang,
                        PhieuGhiTangId = tb.PhieuGhiTangId,
                        ThietBiId = tb.ThietBiId,
                        TenTB = tb.TenTB,
                        SoHieu = tb.SoHieu,
                        NuocSX = tb.NuocSX,
                        PhongBM = tb.PhongBM,
                        DVT = dvt.Ten,
                        SoLuong = tb.SoLuong,
                        DonGia = tb.DonGia,
                        ThanhTien = tb.ThanhTien,
                        NguonKP = tb.NguonKP,
                        GhiChu = tb.GhiChu
                    }).Join(unitOfWork.GetRepository<DM_NguonKinhPhi>().GetAll(),
                    tb => tb.NguonKP,
                    ng => ng.NguonKinhPhiId,
                    (tb, ng) => new GhiTangReportModel
                    {
                        NgayGhiTang = tb.NgayGhiTang,
                        PhieuGhiTangId = tb.PhieuGhiTangId,
                        ThietBiId = tb.ThietBiId,
                        TenTB = tb.TenTB,
                        SoHieu = tb.SoHieu,
                        NuocSX = tb.NuocSX,
                        PhongBM = tb.PhongBM,
                        DVT = tb.DVT,
                        SoLuong = tb.SoLuong.ToString(),
                        DonGia = tb.DonGia.ToString(),
                        ThanhTien = tb.ThanhTien.ToString(),
                        NguonKP = ng.Ten,
                        GhiChu = tb.GhiChu
                    }).ToList();

                    return lst;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
