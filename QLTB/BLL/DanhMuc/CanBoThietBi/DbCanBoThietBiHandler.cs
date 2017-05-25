using QLTB.DAL;
using QLTB.DAL.Data;
using QLTB.Model;
using QLTB.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTB.handler
{
    public class DbCanBoThietBiHandler
    {
        public Paging<List<CanBoTBGridDisplayModel>> GetAll(int page, int pageSize)
        {
            using (var unitOfWork = new UnitOfWork())
            {
                try
                {
                    var TotalRecord = unitOfWork.GetRepository<DM_CanBoThietBi>().GetAll().Count();
                    var data = unitOfWork.GetRepository<DM_CanBoThietBi>().GetAll().AsEnumerable()
                                .Join(GlobalVariable.GetDS().GioiTinh,
                                    cb => cb.GioiTinhId,
                                    gt => gt.GioiTinhId,
                                    (cb, gt) => new
                                    {
                                        CanBoThietBiId = cb.CanBoThietBiId,
                                        Ho=cb.HoVaDem,
                                        Ten=cb.Ten,
                                        GioiTinh=gt.Ten,
                                        PhuTrachId=cb.PhuTrachId,
                                        TrinhDoVH=cb.TrinhDoVanHoa,
                                        TGBatDauQL=MyConvert.DateToString(cb.ThoiGianBatDau),
                                        TGKetThucQL=MyConvert.DateToString(cb.ThoiGianKetThuc),
                                        CoTrinhDoNV=MyConvert.BoolToString((bool)cb.IsCoTrinhDoNghiepVu,"Có","Không"),
                                        GhiChu=cb.GhiChu
                                    }
                                )
                                .Join(GlobalVariable.GetDS().PhuTrachCanBoTB,
                                    cb => cb.PhuTrachId,
                                    ds => ds.Id,
                                    (cb, ds) => new CanBoTBGridDisplayModel
                                    {
                                        CanBoThietBiId=cb.CanBoThietBiId,
                                        HoVaDem=cb.Ho,
                                        Ten=cb.Ten,
                                        GioiTinh=cb.GioiTinh,
                                        PhuTrach=ds.Ten,
                                        TrinhDoVanHoa=cb.TrinhDoVH,
                                        TGBatDauQL=cb.TGBatDauQL,
                                        TGKetThucQL=cb.TGKetThucQL,
                                        IsCoTrinhDoNghiepVu=cb.CoTrinhDoNV,
                                        GhiChu=cb.GhiChu
                                    }
                                )
                                .OrderBy(p => p.CanBoThietBiId)
                                .Skip(pageSize * (page - 1))
                                .Take(pageSize)
                                .ToList();
                    return new Paging<List<CanBoTBGridDisplayModel>>
                    {
                        CurrentPage = page,
                        Size = TotalRecord % pageSize == 0 ? TotalRecord / pageSize : TotalRecord / pageSize + 1,
                        TotalRecord = TotalRecord,
                        data = data,
                        NextPage = (pageSize * page) < TotalRecord ? true : false,
                        PreviousPage = page > 1 ? true : false
                    };
                }
                catch(Exception ex)
                {
                    return null;
                }
            }
        }
        public CanBoThietBiModel GetById(string Id)
        {
            try
            {
                using (var unitOfWork=new UnitOfWork())
                {
                    var data=unitOfWork.GetRepository<DM_CanBoThietBi>().GetById(Id);
                    return ConvertData(data);
                }
            }
            catch(Exception ex)
            {
                return null;
            }
        }
        public CanBoThietBiModel ConvertData(DM_CanBoThietBi source)
        {
            var result = new CanBoThietBiModel
            {
                CanBoThietBiId = source.CanBoThietBiId,
                GhiChu = source.GhiChu,
                GioiTinhId = source.GioiTinhId,
                HoVaDem = source.HoVaDem,
                IsCoTrinhDoNghiepVu = source.IsCoTrinhDoNghiepVu,
                PhuTrachId = source.PhuTrachId,
                Ten = source.Ten,
                ThoiGianBatDau = source.ThoiGianBatDau,
                ThoiGianKetThuc = source.ThoiGianKetThuc,
                TrinhDoVanHoa = source.TrinhDoVanHoa
            };
            return result;
        }
    }
}
