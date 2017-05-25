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
    public class DbThongTinNHHandler
    {
        public List<ThongTinNamHocGridModel> GetAll()
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    return unitOfWork.GetRepository<ThongTinNamHoc>().GetAll()
                        .Select(p => new ThongTinNamHocGridModel
                        {
                            NamHocId = p.NamHocId.ToString(),
                            ThoiGian = p.NamBatDau.ToString() + " - " + p.NamKetThuc.ToString(),
                            BatDauHK1 = p.BatDauHK1.ToString(),
                            BatDauHK2 = p.BatDauHK2.ToString(),
                            KetThucNamHoc = p.KetThucNamHoc.ToString(),
                            GhiChu = p.GhiChu
                        }).ToList();
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public ThongTinNamHocModel GetById(int Id)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var data = unitOfWork.GetRepository<ThongTinNamHoc>().GetById(Id);
                    return MyConvert.ConvertSameData<ThongTinNamHocModel>(data);
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public int Create(ThongTinNamHocModel model)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var entity = MyConvert.ConvertSameData<ThongTinNamHoc>(model);
                    var last = unitOfWork.GetRepository<ThongTinNamHoc>().GetAll().OrderByDescending(p => p.NamHocId).FirstOrDefault();
                    if (last != null) entity.NamHocId = last.NamHocId + 1;
                    else entity.NamHocId = 1;
                    unitOfWork.GetRepository<ThongTinNamHoc>().Add(entity);
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
        public int Update(ThongTinNamHocModel model)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var entity = unitOfWork.GetRepository<ThongTinNamHoc>().GetById(model.NamHocId);
                    if (entity != null)
                    {
                        MyConvert.TransferValues(entity, model);
                        unitOfWork.GetRepository<ThongTinNamHoc>().Update(entity);
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
        public int Delete(int Id)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var entity = unitOfWork.GetRepository<ThongTinNamHoc>().GetById(Id);
                    if (entity != null)
                    {

                        unitOfWork.GetRepository<ThongTinNamHoc>().Delete(entity);
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
        public ThongTinNamHocModel GetNamHocActive()
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var data = unitOfWork.GetRepository<ThongTinNamHoc>().GetAll().Where(p => p.IsActive == true).FirstOrDefault();
                    if (data != null)
                    {
                        return MyConvert.ConvertSameData<ThongTinNamHocModel>(data);
                    }
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
