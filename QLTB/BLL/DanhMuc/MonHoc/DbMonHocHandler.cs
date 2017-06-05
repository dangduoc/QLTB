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
    public class DbMonHocHandler
    {
        public List<MonHocGridDisplayModel> GetAll()
        {
            using (var unitOfWork = new UnitOfWork())
            {
                try
                {
                    var data = unitOfWork.GetRepository<DM_MonHoc>().GetAll().AsEnumerable()
                                .Join(GlobalVariable.GetDS().LoaiMonHoc,
                                    mh => mh.LoaiMonHocId,
                                    lmh => lmh.Id,
                                    (mh, lmh) => new 
                                    {
                                        MonHocId = mh.MonHocId,
                                        Ten = mh.Ten,
                                        LoaiMonHoc = lmh.Ten,
                                        MaMonHoc = mh.MaMonHoc,
                                        LoaiDanhGiaId=mh.LoaiDanhGiaId
                                    }
                                )
                                .Join(GlobalVariable.GetDS().DanhGiaMonHoc,
                                    mh => mh.LoaiDanhGiaId,
                                    ldg => ldg.Id,
                                    (mh, ldg) => new MonHocGridDisplayModel
                                    {
                                        MonHocId = mh.MonHocId.ToString(),
                                        Ten = mh.Ten,
                                        LoaiMonHoc = mh.LoaiMonHoc,
                                        MaMonHoc = mh.MaMonHoc,
                                        LoaiDanhGia = ldg.Ten
                                    }
                                )
                                .OrderBy(p=>p.Ten).ToList();
                    return data;
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }
        public MonHocModel GetById(int Id)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var data = unitOfWork.GetRepository<DM_MonHoc>().GetById(Id);
                    return MyConvert.ConvertSameData<MonHocModel>(data);
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public List<MonHocModel> GetNames()
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var data = unitOfWork.GetRepository<DM_MonHoc>().GetAll()
                        .Select(p => new MonHocModel
                        {
                            MonHocId = p.MonHocId,
                            Ten = p.Ten,
                            LoaiMonHocId=p.LoaiMonHocId
                        }).ToList();
                    return data;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        #region Create,Update,Remove
        public int Create(MonHocModel model)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    DM_MonHoc entity = MyConvert.ConvertSameData<DM_MonHoc>(model);
                    unitOfWork.GetRepository<DM_MonHoc>().Add(entity);
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
        public int Update(MonHocModel model)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var data = unitOfWork.GetRepository<DM_MonHoc>().GetById(model.MonHocId);
             
                    if (data != null)
                    {
                        MyConvert.TransferValues(data, model);
                        unitOfWork.GetRepository<DM_MonHoc>().Update(data);
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
                    var data = unitOfWork.GetRepository<DM_MonHoc>().GetById(Id);
                    unitOfWork.GetRepository<DM_MonHoc>().Delete(data);
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
