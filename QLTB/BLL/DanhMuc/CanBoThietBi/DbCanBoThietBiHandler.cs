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
        public List<CanBoTBGridDisplayModel> GetAll()
        {
            using (var unitOfWork = new UnitOfWork())
            {
                try
                {
                    var data = unitOfWork.GetRepository<DM_CanBoThietBi>().GetAll()
                                .Join(unitOfWork.GetRepository<DS_GioiTinh>().GetAll(),
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
                                .Join(unitOfWork.GetRepository<DSPhuTrachCBTB>().GetAll(),
                                    cb => cb.PhuTrachId,
                                    ds => ds.PhuTrachCBTBId,
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
                                .ToList();
                    return data;
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
