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
    public class DbToBoMonHandler
    {
        public List<ToBoMonDisplayModel> GetTreeNodes()
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var parentList = unitOfWork.GetRepository<DM_ToBoMon>().GetAll()
                        .Where(p => p.HasChildren == true)
                        .Select(p => new ToBoMonDisplayModel
                        {
                            ToBoMonId = p.ToBoMonId,
                            Ten = p.Ten,
                            MaBoMon = p.MaBoMon
                        }).ToList();

                    foreach (var item in parentList)
                    {
                        item.Children = new List<ToBoMonDisplayModel>();
                        item.Children.AddRange(unitOfWork.GetRepository<DM_ToBoMon>().GetAll()
                            .Where(p => p.ParentId == item.ToBoMonId)
                            .Select(p => new ToBoMonDisplayModel
                            {
                                ToBoMonId = p.ToBoMonId,
                                Ten = p.Ten,
                                MaBoMon = p.MaBoMon
                            }).AsEnumerable());
                    }
                    return parentList.ToList();
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public List<ToBoMonModel> GetAll()
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var list = unitOfWork.GetRepository<DM_ToBoMon>().GetAll()
                        .Where(p => p.ParentId != null)
                        .Select(p => new ToBoMonModel
                        {
                            ToBoMonId = p.ToBoMonId,
                            Ten = p.Ten,
                            MaBoMon = p.MaBoMon
                        }).ToList();

                    list.Add(unitOfWork.GetRepository<DM_ToBoMon>().GetAll().Where(p => p.ToBoMonId == 1).Select(p => new ToBoMonModel
                    {
                        ToBoMonId = p.ToBoMonId,
                        Ten = p.Ten,
                        MaBoMon = p.MaBoMon
                    }).FirstOrDefault());
                    return list;

                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
