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
    public class DbMonHocHandler
    {
        public List<MonHocGridDisplayModel> GetAll()
        {
            using (var unitOfWork = new UnitOfWork())
            {
                try
                {
                    var data = unitOfWork.GetRepository<DM_MonHoc>().GetAll()
                                .Join(unitOfWork.GetRepository<DS_LoaiMonHoc>().GetAll(),
                                    mh => mh.LoaiMonHocId,
                                    lmh => lmh.LoaiMonHocId,
                                    (mh, lmh) => new 
                                    {
                                        MonHocId = mh.MonHocId,
                                        Ten = mh.Ten,
                                        LoaiMonHoc = lmh.Ten,
                                        MaMonHoc = mh.MaMonHoc,
                                        LoaiDanhGiaId=mh.LoaiDanhGiaId
                                    }
                                )
                                .Join(unitOfWork.GetRepository<DS_LoaiDanhGiaMH>().GetAll(),
                                    mh => mh.LoaiDanhGiaId,
                                    ldg => ldg.LoaiDanhGiaId,
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
    }
}