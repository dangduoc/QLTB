﻿using QLTB.DAL;
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
        public Paging<List<GiaoVienGirdDisplayModel>> GetAll(int page, int pageSize)
        {
            using (var unitOfWork = new UnitOfWork())
            {
                try
                {
                    var TotalRecord = unitOfWork.GetRepository<DM_GiaoVien>().GetAll().Count();
                    var data = unitOfWork.GetRepository<DM_GiaoVien>().GetAll()
                         .Join(unitOfWork.GetRepository<DS_PhongBan>().GetAll(),
                                    gv => gv.PhongBanId,
                                    pb => pb.PhongBanId,
                                    (gv, pb) => new
                                    {
                                        GiaoVienId = gv.GiaoVienId,
                                        Ten = gv.Ten,
                                        GioiTinhId = gv.GioiTinhId,
                                        NgaySinh = gv.NgaySinh,
                                        PhongBan = pb.Ten,
                                        ViTriId = gv.ViTriId,
                                        ChucVuId = gv.ChucVuId,
                                        MonHocId = gv.MonHocId,
                                        TrinhDoCMId = gv.TrinhDoId,
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
                                        GioiTinhId = gv.GioiTinhId,
                                        NgaySinh = gv.NgaySinh,
                                        PhongBan = gv.PhongBan,
                                        ViTriId = gv.ViTriId,
                                        ChucVuId = gv.ChucVuId,
                                        MonHoc = mh.Ten,
                                        TrinhDoCMId = gv.TrinhDoCMId,
                                        LoaiHopDongId = gv.LoaiHopDongId
                                    }
                                ).AsEnumerable()
                                .Join(GlobalVariable.GetDS().GioiTinh,
                                    gv => gv.GioiTinhId,
                                    gt => gt.GioiTinhId,
                                    (gv, gt) => new
                                    {
                                        GiaoVienId = gv.GiaoVienId,
                                        Ten = gv.Ten,
                                        GioiTinh = gt.Ten,
                                        NgaySinh = gv.NgaySinh,
                                        PhongBan = gv.PhongBan,
                                        ViTriId = gv.ViTriId,
                                        ChucVuId = gv.ChucVuId,
                                        MonHocId = gv.MonHoc,
                                        TrinhDoCMId = gv.TrinhDoCMId,
                                        LoaiHopDongId = gv.LoaiHopDongId
                                    }
                                )
                                .Join(GlobalVariable.GetDS().ViTriGiaoVien.Where(p => p.CapHocId == 2),
                                    gv => gv.ViTriId,
                                    vt => vt.Id,
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
                                 .Join(GlobalVariable.GetDS().ChucVuGiaoVien,
                                    gv => gv.ChucVuId,
                                    cv => cv.Id,
                                    (gv, cv) => new
                                    {
                                        GiaoVienId = gv.GiaoVienId,
                                        Ten = gv.Ten,
                                        GioiTinh = gv.GioiTinh,
                                        NgaySinh = gv.NgaySinh,
                                        PhongBan = gv.PhongBan,
                                        ViTri = gv.ViTri,
                                        ChucVu = cv.Ten,
                                        MonHoc = gv.MonHocId,
                                        TrinhDoCMId = gv.TrinhDoCMId,
                                        LoaiHopDongId = gv.LoaiHopDongId
                                    }
                                )
                                .Join(GlobalVariable.GetDS().TrinhDoChuyenMon,
                                    gv => gv.TrinhDoCMId,
                                    cd => cd.Id,
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
                                .Join(GlobalVariable.GetDS().LoaiHopDong,
                                    gv => gv.LoaiHopDongId,
                                    loai => loai.Id,
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
                                .Select(gv=> new GiaoVienGirdDisplayModel {
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
                                })
                                .OrderBy(p => p.GiaoVienId)
                                .Skip(pageSize * (page - 1))
                                .Take(pageSize)
                                .ToList();
                    return new Paging<List<GiaoVienGirdDisplayModel>>
                    {
                        CurrentPage = page,
                        Size = TotalRecord % pageSize == 0 ? TotalRecord / pageSize : TotalRecord / pageSize + 1,
                        TotalRecord = TotalRecord,
                        data = data,
                        NextPage = (pageSize * page) < TotalRecord ? true : false,
                        PreviousPage = page > 1 ? true : false
                    };
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
