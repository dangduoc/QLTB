using QLTB.DAL;
using QLTB.DAL.Data;
using QLTB.Model;
using QLTB.Utils;
using System;
using System.Collections.Generic;
using System.Data.Entity.SqlServer;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTB.Handler
{
    public class DbGiaoVienHandler
    {
        public List<GiaoVienGirdDisplayModel> GetAll()
        {
            using (var unitOfWork = new UnitOfWork())
            {
                try
                {
                    var data = unitOfWork.GetRepository<DM_GiaoVien>().GetAll()
                                .Join(unitOfWork.GetRepository<DS_GioiTinh>().GetAll(),
                                    gv => gv.GioiTinhId,
                                    gt => gt.GioiTinhId,
                                    (gv, gt) => new
                                    {
                                        GiaoVienId = gv.GiaoVienId,
                                        Ten = gv.TenDayDu,
                                        GioiTinh = gt.Ten,
                                        NgaySinh = gv.NgaySinh,
                                        PhongBanId = gv.PhongBanId,
                                        ViTriId = gv.ViTriId,
                                        ChucVuId = gv.ChucVuId,
                                        MonHocId = gv.MonHocId,
                                        TrinhDoCMId = gv.TrinhDoId,
                                        LoaiHopDongId = gv.LoaiHopDongId
                                    }
                                )
                                .Join(unitOfWork.GetRepository<DS_PhongBan>().GetAll(),
                                    gv => gv.PhongBanId,
                                    pb => pb.PhongBanId,
                                    (gv, pb) => new
                                    {
                                        GiaoVienId = gv.GiaoVienId,
                                        Ten = gv.Ten,
                                        GioiTinh = gv.GioiTinh,
                                        NgaySinh = gv.NgaySinh,
                                        PhongBan = pb.Ten,
                                        ViTriId = gv.ViTriId,
                                        ChucVuId = gv.ChucVuId,
                                        MonHocId = gv.MonHocId,
                                        TrinhDoCMId = gv.TrinhDoCMId,
                                        LoaiHopDongId = gv.LoaiHopDongId
                                    }
                                )
                                .Join(unitOfWork.GetRepository<DS_ViTriGiaoVien>().GetAll(),
                                    gv => gv.ViTriId,
                                    vt => vt.ViTriGiaoVienId,
                                    (gv, vt) => new
                                    {
                                        GiaoVienId = gv.GiaoVienId,
                                        Ten = gv.Ten,
                                        GioiTinh = gv.GioiTinh,
                                        NgaySinh = gv.NgaySinh,
                                        PhongBan = gv.PhongBan,
                                        ViTri = vt.Ten,
                                        ChucVuId = gv.ChucVuId,
                                        MonHocId = gv.MonHocId,
                                        TrinhDoCMId = gv.TrinhDoCMId,
                                        LoaiHopDongId = gv.LoaiHopDongId
                                    }
                                )
                                 .Join(unitOfWork.GetRepository<DS_ChucVuGiaoVien>().GetAll(),
                                    gv => gv.ChucVuId,
                                    cv => cv.ChucVuGiaoVienId,
                                    (gv, cv) => new
                                    {
                                        GiaoVienId = gv.GiaoVienId,
                                        Ten = gv.Ten,
                                        GioiTinh = gv.GioiTinh,
                                        NgaySinh = gv.NgaySinh,
                                        PhongBan = gv.PhongBan,
                                        ViTri = gv.ViTri,
                                        ChucVu = cv.Ten,
                                        MonHocId = gv.MonHocId,
                                        TrinhDoCMId = gv.TrinhDoCMId,
                                        LoaiHopDongId = gv.LoaiHopDongId
                                    }
                                )
                                 .Join(unitOfWork.GetRepository<DM_MonHoc>().GetAll(),
                                    gv => gv.MonHocId,
                                    mh => mh.MonHocId,
                                    (gv, mh) => new
                                    {
                                        GiaoVienId = gv.GiaoVienId,
                                        Ten = gv.Ten,
                                        GioiTinh = gv.GioiTinh,
                                        NgaySinh = gv.NgaySinh,
                                        PhongBan = gv.PhongBan,
                                        ViTri = gv.ViTri,
                                        ChucVu = gv.ChucVu,
                                        MonHoc = mh.Ten,
                                        TrinhDoCMId = gv.TrinhDoCMId,
                                        LoaiHopDongId = gv.LoaiHopDongId
                                    }
                                )
                                .Join(unitOfWork.GetRepository<DS_TrinhDoChuyenMon>().GetAll(),
                                    gv => gv.TrinhDoCMId,
                                    cd => cd.TrinhDoChuyenMonId,
                                    (gv, cd) => new
                                    {
                                        GiaoVienId = gv.GiaoVienId,
                                        Ten = gv.Ten,
                                        GioiTinh = gv.GioiTinh,
                                        NgaySinh = gv.NgaySinh,
                                        PhongBan = gv.PhongBan,
                                        ViTri = gv.ViTri,
                                        ChucVu = gv.ChucVu,
                                        MonHoc = gv.MonHoc,
                                        TrinhDoCM = cd.Ten,
                                        LoaiHopDongId = gv.LoaiHopDongId
                                    }
                                )
                                .Join(unitOfWork.GetRepository<DS_LoaiHopDong>().GetAll(),
                                    gv => gv.LoaiHopDongId,
                                    loai => loai.LoaiHopDongId,
                                    (gv, loai) => new 
                                    {
                                        GiaoVienId = gv.GiaoVienId,
                                        TenDayDu = gv.Ten,
                                        GioiTinh = gv.GioiTinh,
                                        NgaySinh = gv.NgaySinh,
                                        PhongBan = gv.PhongBan,
                                        ViTriViecLam = gv.ViTri,
                                        ChucVu = gv.ChucVu,
                                        DayMon = gv.MonHoc,
                                        TrinhDoChuyenMon = gv.TrinhDoCM,
                                        LoaiHopDong = loai.Ten
                                    }
                                )
                                .ToList().Select(gv=> new GiaoVienGirdDisplayModel {
                                    GiaoVienId = gv.GiaoVienId,
                                    TenDayDu = gv.TenDayDu,
                                    GioiTinh = gv.GioiTinh,
                                    NgaySinh = MyConvert.DateToString(gv.NgaySinh),
                                    PhongBan = gv.PhongBan,
                                    ViTriViecLam = gv.ViTriViecLam,
                                    ChucVu = gv.ChucVu,
                                    DayMon = gv.DayMon,
                                    TrinhDoChuyenMon = gv.TrinhDoChuyenMon,
                                    LoaiHopDong = gv.LoaiHopDong
                                }).ToList();
                    return data;
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }
        public GiaoVienModel GetById(string Id)
        {
            try
            {
                using (var unitOfWork= new UnitOfWork())
                {
                    var data=unitOfWork.GetRepository<DM_GiaoVien>().GetById(Id);
                    return MyConvert.ConvertSameData<GiaoVienModel>(data);
                }
            }
            catch(Exception ex)
            {
                return null;
            }
        }
      
    }
}
