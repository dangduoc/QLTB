﻿using QLTB.DAL;
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
    public class DbPhongBMHandler
    {
        public Paging<List<PhongBoMonGridDisplayModel>> GetAll(int page, int pageSize)
        {
            using (var unitOfWork = new UnitOfWork())
            {
                try
                {
                    var TotalRecord = unitOfWork.GetRepository<DM_PhongHocBoMon>().GetAll().Count();
                    var data = unitOfWork.GetRepository<DM_PhongHocBoMon>().GetAll()
                        .Join(unitOfWork.GetRepository<DM_MonHoc>().GetAll(),
                                    ph => ph.MonHocId,
                                    mh => mh.MonHocId,
                                    (ph, mh) => new
                                    {
                                        PhongHocId = ph.PhongHocId,
                                        Ten = ph.Ten,
                                        LoaiPhongTNId = ph.LoaiPhongTNId,
                                        MonHoc = mh.Ten,
                                        DienTich = ph.DienTich,
                                        SoCanBo = ph.SoCanBo,
                                        NamDuaVaoSD = ph.NamDuaVaoSD,
                                        IsPhongChucNang = ph.IsPhongChucNang,
                                        XepLoaiId = ph.XepLoaiId
                                    }
                                ).AsEnumerable()
                                .Join(GlobalVariable.GetDS().LoaiPhongTN,
                                    ph => ph.LoaiPhongTNId,
                                    lp => lp.Id,
                                    (ph, lp) => new
                                    {
                                        PhongHocId = ph.PhongHocId,
                                        Ten = ph.Ten,
                                        LoaiPhongTN = lp.Ten,
                                        MonHoc = ph.MonHoc,
                                        DienTich = ph.DienTich,
                                        SoCanBo = ph.SoCanBo,
                                        NamDuaVaoSD = ph.NamDuaVaoSD,
                                        IsPhongChucNang = ph.IsPhongChucNang,
                                        XepLoaiId = ph.XepLoaiId
                                    }
                                )
                                 .Join(GlobalVariable.GetDS().XepLoaiPhongBM,
                                    ph => ph.XepLoaiId,
                                    xl => xl.Id,
                                    (ph, xl) => new
                                    {
                                        PhongHocId = ph.PhongHocId.ToString(),
                                        Ten = ph.Ten,
                                        LoaiPhongTN = ph.LoaiPhongTN,
                                        MonHoc = ph.MonHoc,
                                        DienTich = ph.DienTich.ToString(),
                                        SoCanBo = ph.SoCanBo.ToString(),
                                        NamDuaVaoSD = ph.NamDuaVaoSD.ToString(),
                                        IsPhongChucNang = ph.IsPhongChucNang,
                                        XepLoai = xl.Ten
                                    }
                                )
                                .Select(ph => new PhongBoMonGridDisplayModel
                                {
                                    PhongHocId = ph.PhongHocId.ToString(),
                                    Ten = ph.Ten,
                                    LoaiPhongTN = ph.LoaiPhongTN,
                                    MonHoc = ph.MonHoc,
                                    DienTich = ph.DienTich.ToString(),
                                    SoCanBo = ph.SoCanBo.ToString(),
                                    NamDuaVaoSD = ph.NamDuaVaoSD.ToString(),
                                    IsPhongChucNang = MyConvert.BoolToString(ph.IsPhongChucNang, "Có", "Không"),
                                    XepLoai = ph.XepLoai

                                })
                                .OrderBy(p => p.PhongHocId)
                                .Skip(pageSize * (page - 1))
                                .Take(pageSize)
                                .ToList();

                    return new Paging<List<PhongBoMonGridDisplayModel>>
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
        public PhongBoMonModel GetById(int Id)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var data = unitOfWork.GetRepository<DM_PhongHocBoMon>().GetById(Id);
                    return MyConvert.ConvertSameData<PhongBoMonModel>(data);
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public List<PhongBoMonModel> GetNames()
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var data = unitOfWork.GetRepository<DM_PhongHocBoMon>().GetAll()
                        .Select(p => new PhongBoMonModel
                        {
                            PhongHocId = p.PhongHocId,
                            Ten = p.Ten
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
        public int Create(PhongBoMonModel model)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var last = unitOfWork.GetRepository<DM_PhongHocBoMon>().GetAll().OrderByDescending(p => p.PhongHocId).FirstOrDefault();
                    DM_PhongHocBoMon entity = MyConvert.ConvertSameData<DM_PhongHocBoMon>(model);
                    if (last != null)
                        entity.PhongHocId = last.PhongHocId + 1;
                    else
                        entity.PhongHocId = 1;
                    
                    unitOfWork.GetRepository<DM_PhongHocBoMon>().Add(entity);
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
        public int Update(PhongBoMonModel model)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var data = unitOfWork.GetRepository<DM_PhongHocBoMon>().GetById(model.PhongHocId);

                    if (data != null)
                    {
                        MyConvert.TransferValues(data, model);
                        unitOfWork.GetRepository<DM_PhongHocBoMon>().Update(data);
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
                    var data = unitOfWork.GetRepository<DM_PhongHocBoMon>().GetById(Id);
                    if (data != null)
                    {
                        data.TrangThai = -1;
                        unitOfWork.GetRepository<DM_PhongHocBoMon>().Update(data);
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
