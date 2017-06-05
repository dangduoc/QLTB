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
    public class DbLopHocHandler
    {
        public List<LopHocGridDisplayModel> GetAll()
        {
            using (var unitOfWork = new UnitOfWork())
            {
                try
                {
                    var khoilops = new DbKhoiLopHandler().GetAllModel();
                    var data = unitOfWork.GetRepository<DM_LopHoc>().GetAll()
                                .Join(khoilops,
                                    lh => lh.KhoiLopId,
                                    kl => kl.KhoiLopId,
                                    (lh, kl) => new LopHocGridDisplayModel
                                    {
                                        KhoiLop = kl.Ten,
                                        LopHocId = lh.LopHocId.ToString(),
                                        Ten = lh.Ten,
                                        GhiChu = lh.GhiChu
                                    }
                                )
                                .OrderBy(p => p.KhoiLop).ToList();
                    return data;
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }
        public LopHocModel GetById(string Id)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var data = unitOfWork.GetRepository<DM_LopHoc>().GetById(Id);
                    return MyConvert.ConvertSameData<LopHocModel>(data);
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        #region Create,Update,Remove
        public int Create(LopHocModel model)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    DM_LopHoc entity = MyConvert.ConvertSameData<DM_LopHoc>(model);
                    unitOfWork.GetRepository<DM_LopHoc>().Add(entity);
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
        public int Update(LopHocModel model)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var data = unitOfWork.GetRepository<DM_LopHoc>().GetById(model.LopHocId);
                   
                    if (data != null)
                    {
                        MyConvert.TransferValues(data, model);
                        unitOfWork.GetRepository<DM_LopHoc>().Update(data);
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
                    var data = unitOfWork.GetRepository<DM_LopHoc>().GetById(Id);
                    unitOfWork.GetRepository<DM_LopHoc>().Delete(data);
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
