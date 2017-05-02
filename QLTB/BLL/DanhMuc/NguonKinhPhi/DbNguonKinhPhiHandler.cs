using QLTB.DAL;
using QLTB.DAL.Data;
using QLTB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTB.Handler
{
    public class DbNguonKinhPhiHandler
    {
        public List<NguonKinhPhiModel> GetForCBB()
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var data = unitOfWork.GetRepository<DM_NguonKinhPhi>()
                        .GetAll().Select(p => new NguonKinhPhiModel { NguonKinhPhiId = p.NguonKinhPhiId, Ten = p.Ten }).ToList();
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
