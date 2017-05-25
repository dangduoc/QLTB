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
        public Paging<List<ThietBiTTGridDisplayModel>> GetAll(int page, int pageSize)
        {
            using (var unitOfWork = new UnitOfWork())
            {
                try
                {
                    var TotalRecord = unitOfWork.GetRepository<TB_ThongTinThietBi>().GetAll().Count();
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
                                ).AsEnumerable()
                                 .Join(GlobalVariable.GetDS().LoaiThietBi,
                                    tb => tb.LoaiThietBiId,
                                    ltb => ltb.Id,
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
                                 .Join(GlobalVariable.GetDS().DauMucThietBi,
                                    tb => tb.DauMucId,
                                    dm => dm.Id,
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
                                 .OrderBy(p => p.MonHoc)
                                .Skip(pageSize * (page - 1))
                                .Take(pageSize)
                                .ToList();

                    return new Paging<List<ThietBiTTGridDisplayModel>>
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
