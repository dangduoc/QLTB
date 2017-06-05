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
        #region Create,Update,Remove
        public int Create(ThietBiToiThieuModel model)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    DM_ThietBiToiThieu entity = MyConvert.ConvertSameData<DM_ThietBiToiThieu>(model);
                    unitOfWork.GetRepository<DM_ThietBiToiThieu>().Add(entity);
                    if (unitOfWork.Save() >= 1)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
        public int Update(ThietBiToiThieuModel model)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var data = unitOfWork.GetRepository<DM_ThietBiToiThieu>().GetById(model.ThietBiId);

                    if (data != null)
                    {
                        MyConvert.TransferValues(data, model);
                        unitOfWork.GetRepository<DM_ThietBiToiThieu>().Update(data);
                        if (unitOfWork.Save() >= 1)
                        {
                            return 1;
                        }
                    }
                    return 0;
                }
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
        public int Delete(string Id)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var data = unitOfWork.GetRepository<DM_ThietBiToiThieu>().GetById(Id);
                    if (data != null)
                    {
                        data.TrangThai = -1;
                        unitOfWork.GetRepository<DM_ThietBiToiThieu>().Update(data);
                        if (unitOfWork.Save() >= 1)
                        {
                            return 1;
                        }
                    }
                    return 0;

                }
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
        #endregion
    }
}
