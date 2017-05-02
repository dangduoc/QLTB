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
                    var data = unitOfWork.GetRepository<DM_KhoiLop>().GetAll()
                                .Join(unitOfWork.GetRepository<DS_CapTruong>().GetAll(),
                                    kl => kl.CapTruongId,
                                    ct => ct.CapTruongId,
                                    (kl, ct) => new KhoiLopGridDisplayModel
                                    {
                                        KhoiLopId=kl.KhoiLopId.ToString(),
                                        CapTruong=ct.Ten,
                                        Ten=kl.Ten,
                                        GhiChu=kl.Ten
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
       
    }
}
