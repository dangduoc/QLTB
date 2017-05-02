using QLTB.DAL;
using QLTB.DAL.Data;
using QLTB.Model;
using QLTB.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTB.Handler
{
    public class DbThietBiTTHandler
    {
        public List<ThietBiTTGridDisplayModel> GetAll()
        {
            using (var unitOfWork = new UnitOfWork())
            {
                try
                {
                    var data = unitOfWork.GetRepository<DM_ThietBiToiThieu>().GetAll()
                                .Join(unitOfWork.GetRepository<DS_DonViTinh>().GetAll(),
                                    tb => tb.DonViTinhId,
                                    dvt => dvt.DonViTinhId,
                                    (tb, dvt) => new
                                    {
                                        ThietBiId = tb.ThietBiId,
                                        Ten = tb.Ten,
                                        DonViTinh = dvt.Ten,
                                        DungChoLop = tb.DungChoLopHienThi,
                                        LoaiThietBiId = tb.LoaiThietBiId,
                                        MonHocId = tb.MonHocId,
                                        DauMucId = tb.DauMucId,
                                        SoLuong = tb.SoLuong,
                                        MoTa = tb.MoTa
                                    }
                                )
                                .Join(unitOfWork.GetRepository<DM_MonHoc>().GetAll(),
                                    tb => tb.MonHocId,
                                    mh => mh.MonHocId,
                                    (tb, mh) => new
                                    {
                                        ThietBiId = tb.ThietBiId,
                                        Ten = tb.Ten,
                                        DonViTinh = tb.DonViTinh,
                                        DungChoLop = tb.DungChoLop,
                                        LoaiThietBiId = tb.LoaiThietBiId,
                                        MonHoc = mh.Ten,
                                        DauMucId = tb.DauMucId,
                                        SoLuong = tb.SoLuong,
                                        MoTa = tb.MoTa
                                    }
                                )
                                 .Join(unitOfWork.GetRepository<DS_LoaiThietBi>().GetAll(),
                                    tb => tb.LoaiThietBiId,
                                    ltb => ltb.LoaiThietBiId,
                                    (tb, ltb) => new
                                    {
                                        ThietBiId = tb.ThietBiId,
                                        Ten = tb.Ten,
                                        DonViTinh = tb.DonViTinh,
                                        DungChoLop = tb.DungChoLop,
                                        LoaiThietBi = ltb.Ten,
                                        MonHoc = tb.MonHoc,
                                        DauMucId = tb.DauMucId,
                                        SoLuong = tb.SoLuong,
                                        MoTa = tb.MoTa
                                    }
                                )
                                 .Join(unitOfWork.GetRepository<DS_DauMucThietBi>().GetAll(),
                                    tb => tb.DauMucId,
                                    dm => dm.DauMucThietBiId,
                                    (tb, dm) => new ThietBiTTGridDisplayModel
                                    {
                                        ThietBiId = tb.ThietBiId,
                                        Ten = tb.Ten,
                                        DonViTinh = tb.DonViTinh,
                                        DungChoLop = tb.DungChoLop,
                                        LoaiThietBi = tb.LoaiThietBi,
                                        MonHoc = tb.MonHoc,
                                        DauMuc = dm.Ten,
                                        SoLuong = tb.SoLuong.ToString(),
                                        MoTa = tb.MoTa
                                    }
                                )
                                .OrderBy(ph => ph.MonHoc).ToList();
                               
                    return data;
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }
        public ThietBiToiThieuModel GetById(string Id)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var data = unitOfWork.GetRepository<DM_ThietBiToiThieu>().GetById(Id);
                    return MyConvert.ConvertSameData<ThietBiToiThieuModel>(data);
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public List<string> GetMaTB()
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var data = unitOfWork.GetRepository<DM_ThietBiToiThieu>().GetAll().Select(p => p.ThietBiId).ToList();
                    return data;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
