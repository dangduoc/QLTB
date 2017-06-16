using QLTB.DAL;
using QLTB.DAL.Data;
using QLTB.Report.Model;
using QLTB.Utils;
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
                    var lst = unitOfWork.GetRepository<QH_PhieuGhiTang_ThietBi>().GetAll()
                    .Join(unitOfWork.GetRepository<TB_PhieuGhiTang>().GetAll(),
                    phieu => phieu.PhieuGhiTangId,
                    qh => qh.PhieuGhiTangId,
                    (phieu, qh) => new
                    {
                        NgayGhiTang = qh.NgayLap,
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
                    (tb, ng) => new
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
                    }).AsEnumerable().
                    Select(tb => new GhiTangReportModel
                    {
                        NgayGhiTang = MyConvert.DateToString(tb.NgayGhiTang),
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
                        NguonKP = tb.NguonKP,
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
        /// <summary>
        /// Thống kê danh sách thiết bị
        /// </summary>
        /// <returns></returns>
        public List<ThietBiReportModel> DanhSachThietBi()
        {
            using (var unitOfWork = new UnitOfWork())
            {
                try
                {
                    var dstb = unitOfWork.GetRepository<TB_ThongTinThietBi>().GetAll().Where(p=>p.TrangThai>=0);
                    var data = dstb
                                .Join(unitOfWork.GetRepository<DM_PhongHocBoMon>().GetAll(),
                                    tb => tb.PhongHocId,
                                    ph => ph.PhongHocId,
                                    (tb, ph) => new
                                    {
                                        ThietBiId = tb.ThietBiId,
                                        SoHieu = tb.SoHieu,
                                        Ten = tb.Ten,
                                        KhoPhong = ph.Ten,
                                        MonHocId = tb.MonHocId,
                                        SoLuong = tb.SoLuong,
                                        SoLuongMat = tb.SoLuongMat,
                                        SoLuongHong = tb.SoLuongHong,
                                        DonViTinhId = tb.DonViTinhId,
                                        TrangThaiId = tb.TrangThai,
                                        SoLuongCon = tb.SoLuongCon,
                                        DonGia = tb.DonGia,
                                        ThanhTien = tb.ThanhTien,
                                        NguonKP = tb.NguonKinhPhiId,
                                        NamDuaVaoSD=tb.NamDuaVaoSD,
                                        NamTheoDoi=tb.NamTheoDoi,
                                        GhiChu=tb.GhiChu,
                                        QuyCachSD=tb.QuyCachSD,
                                        SoLuongMuon = tb.SoLuongMuon

                                    }
                                )
                                .Join(unitOfWork.GetRepository<DM_MonHoc>().GetAll(),
                                    tb => tb.MonHocId,
                                    mh => mh.MonHocId,
                                    (tb, mh) => new
                                    {
                                        ThietBiId = tb.ThietBiId,
                                        SoHieu = tb.SoHieu,
                                        Ten = tb.Ten,
                                        KhoPhong = tb.KhoPhong,
                                        MonHoc = mh.Ten,
                                        SoLuong = tb.SoLuong,
                                        SoLuongMat = tb.SoLuongMat,
                                        SoLuongHong = tb.SoLuongHong,
                                        DonViTinhId = tb.DonViTinhId,
                                        TrangThaiId = tb.TrangThaiId,
                                        SoLuongCon = tb.SoLuongCon,
                                        DonGia = tb.DonGia,
                                        ThanhTien = tb.ThanhTien,
                                        NamDuaVaoSD = tb.NamDuaVaoSD,
                                        NamTheoDoi = tb.NamTheoDoi,
                                        GhiChu = tb.GhiChu,
                                        QuyCachSD = tb.QuyCachSD,
                                        SoLuongMuon = tb.SoLuongMuon
                                    }
                                )
                                 .Join(unitOfWork.GetRepository<DS_DonViTinh>().GetAll(),
                                    tb => tb.DonViTinhId,
                                    dvt => dvt.DonViTinhId,
                                    (tb, dvt) => new ThietBiReportModel
                                    {
                                        ThietBiId = tb.ThietBiId,
                                        SoHieu = tb.SoHieu,
                                        Ten = tb.Ten,
                                        MonHoc = tb.MonHoc,
                                        SoLuong = tb.SoLuong,
                                        SoLuongCon = tb.SoLuongCon,
                                        SoLuongMat = tb.SoLuongMat,
                                        SoLuongHong = tb.SoLuongHong,
                                        DonViTinh = dvt.Ten,
                                        DonGia = tb.DonGia.ToString(),
                                        ThanhTien = tb.ThanhTien.ToString(),
                                        NamDuaVaoSD = tb.NamDuaVaoSD.ToString(),
                                        NamTheoDoi = tb.NamTheoDoi.ToString(),
                                        GhiChu = tb.GhiChu,
                                        PhongBM=tb.KhoPhong,
                                        QuyCachSD = tb.QuyCachSD,
                                        SoLuongMuon = tb.SoLuongMuon
                                    }
                                )
                                .OrderBy(p => p)
                                .ToList();
                    //



                    return data;
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Danh sách thiết bị đề nghị mua sắm của phiếu đề nghị mua sắm
        /// </summary>
        /// <param name="id">mã phiếu</param>
        /// <returns></returns>
        public List<ThietBiMuaReportModel> ThietBiMuSam(string id)
        {
            try
            {
                using (var unitOfWork=new UnitOfWork())
                {
                    var ds = unitOfWork.GetRepository<QH_PhieuDenNghiMS_ThietBi>().GetAll()
                           .Where(p => p.PhieuDeNghiId.Equals(id))
                           .Join(unitOfWork.GetRepository<DM_ThietBiToiThieu>().GetAll(),
                           pm => pm.ThietBiId,
                           tb => tb.ThietBiId,
                           (pm, tb) => new
                           {
                               Ma = tb.ThietBiId,
                               Ten = tb.Ten,
                               Loai = tb.LoaiThietBiId,
                               SoLuongDangCo = pm.SoLuong,
                               SoLuongDeNghi = pm.SoLuongDeNghi,
                               DonGia = pm.DonGia,
                               ThanhTien = pm.ThanhTien,
                               IsTuMua=pm.IsTuMua
                           }
                           ).AsEnumerable()
                           .Join(GlobalVariable.GetDS().LoaiThietBi,
                           tb => tb.Loai,
                           l => l.Id,
                           (tb, l) => new ThietBiMuaReportModel
                           {
                               MaThietBi = tb.Ma,
                               Ten = tb.Ten,
                               DonGia = tb.DonGia.ToString(),
                               SoLuongDangCo = tb.SoLuongDangCo.ToString(),
                               SoLuongDeNghi = tb.SoLuongDeNghi.ToString(),
                               LoaiTB = l.Ten,
                               ThanhTien = tb.ThanhTien.ToString(),
                               isTuMua = (bool)tb.IsTuMua
                           })
                           .ToList();
                    return ds;
                }
            }
            catch(Exception ex)
            {
                return null;
            }
        }
    }
}
