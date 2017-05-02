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
                    var data = unitOfWork.GetRepository<DM_LopHoc>().GetAll()
                                .Join(unitOfWork.GetRepository<DM_KhoiLop>().GetAll(),
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
    }
}
