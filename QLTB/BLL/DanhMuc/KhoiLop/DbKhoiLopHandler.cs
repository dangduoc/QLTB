using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTB.DAL;
using QLTB.DAL.Data;
using QLTB.Model;
using QLTB.Utils;

namespace QLTB.Handler
{
    public class DbKhoiLopHandler
    {
        public List<KhoiLopGridDisplayModel> GetAll()
        {
            using (var unitOfWork = new UnitOfWork())
            {
                try
                {
                    var data = unitOfWork.GetRepository<DM_KhoiLop>().GetAll().Where(p => p.CapTruongId == GlobalVariable.GetHeThong().DonVi.CapTruongId).AsEnumerable()
                                .Join(GlobalVariable.GetDS().CapTruong,
                                    kl => kl.CapTruongId,
                                    ct => ct.CapTruongId,
                                    (kl, ct) => new KhoiLopGridDisplayModel
                                    {
                                        KhoiLopId = kl.KhoiLopId.ToString(),
                                        CapTruong = ct.Ten,
                                        Ten = kl.Ten,
                                        GhiChu = kl.Ten
                                    }
                                )
                                .ToList();
                    return data;
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }
        public List<KhoiLopModel> GetAllModel()
        {
            using (var unitOfWork = new UnitOfWork())
            {
                try
                {
                    var data = unitOfWork.GetRepository<DM_KhoiLop>().GetAll()
                        .Where(p => p.CapTruongId == GlobalVariable.GetHeThong().DonVi.CapTruongId)
                                 .Select(p => new KhoiLopModel
                                 {
                                     KhoiLopId = p.KhoiLopId,
                                     Ten = p.Ten,
                                 })
                                .ToList();
                    return data;
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }
        public KhoiLopModel GetById(int Id)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var data = unitOfWork.GetRepository<DM_KhoiLop>().GetById(Id);
                    return MyConvert.ConvertSameData<KhoiLopModel>(data);
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        #region Create,Update,Remove
        public int Create(KhoiLopModel model)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    DM_KhoiLop entity = MyConvert.ConvertSameData<DM_KhoiLop>(model);
                    unitOfWork.GetRepository<DM_KhoiLop>().Add(entity);
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
        public int Update(KhoiLopModel model)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var data = unitOfWork.GetRepository<DM_KhoiLop>().GetById(model.KhoiLopId);
                   
                    if (data != null)
                    {
                        MyConvert.TransferValues(data, model);
                        unitOfWork.GetRepository<DM_KhoiLop>().Update(data);
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
                    var data = unitOfWork.GetRepository<DM_KhoiLop>().GetById(Id);
                    unitOfWork.GetRepository<DM_KhoiLop>().Delete(data);
                    if (unitOfWork.Save() >= 1)
                    {
                        return 1;
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
