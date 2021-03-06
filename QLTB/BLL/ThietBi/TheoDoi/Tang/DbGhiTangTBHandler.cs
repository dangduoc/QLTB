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
    public class DbGhiTangTBHandler
    {
        #region Get Data
        public Paging<List<PhieuTangTBGridDisplayModel>> GetAll(int page, int pageSize)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var TotalRecord = unitOfWork.GetRepository<TB_PhieuGhiTang>().GetAll().Where(p => p.IsDelete == false).Count();
                    var data = unitOfWork.GetRepository<TB_PhieuGhiTang>().GetAll().AsEnumerable()
                                 .Select(p => new PhieuTangTBGridDisplayModel
                                 {
                                     PhieuGhiTangId = p.PhieuGhiTangId,
                                     ChungTuLienQuan = p.ChungTuLienQuan,
                                     NgayLap = MyConvert.DateToString(p.NgayLap),
                                     NoiDung = p.NoiDung
                                 })
                                .OrderBy(p => p.PhieuGhiTangId)
                                .Skip(pageSize * (page - 1))
                                .Take(pageSize)
                                .ToList();

                    return new Paging<List<PhieuTangTBGridDisplayModel>>
                    {
                        CurrentPage = page,
                        Size = TotalRecord % pageSize == 0 ? TotalRecord / pageSize : TotalRecord / pageSize + 1,
                        TotalRecord = TotalRecord,
                        data = data,
                        NextPage = (pageSize * page) < TotalRecord ? true : false,
                        PreviousPage = page > 1 ? true : false
                    };

                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public PhieuTangTBModel GetById(string Id)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var data = unitOfWork.GetRepository<TB_PhieuGhiTang>().GetById(Id);
                    if (data != null)
                    {
                        var model = MyConvert.ConvertSameData<PhieuTangTBModel>(data);
                        var ds = unitOfWork.GetRepository<QH_PhieuGhiTang_ThietBi>().GetAll()
                            .Where(p => p.PhieuGhiTangId == data.PhieuGhiTangId)
                            .Join(unitOfWork.GetRepository<TB_ThongTinThietBi>().GetAll(),
                            pm => pm.SoHieuId,
                            tb => tb.SoHieu,
                            (pm, tb) => new
                            {
                                ThietBiId = tb.ThietBiId,
                                Ten = tb.Ten,
                                SoHieu = tb.SoHieu,
                                SoLuong = pm.SoLuong,
                                DVT = tb.DonViTinhId,
                                PhongBMId = tb.PhongHocId,
                                DonGia=tb.DonGia,
                                NguonKP=tb.NguonKinhPhiId,
                                ThanhTien=tb.ThanhTien
                                
                            }
                            ).Join(unitOfWork.GetRepository<DS_DonViTinh>().GetAll(),
                            tb => tb.DVT,
                            dvt => dvt.DonViTinhId,
                            (tb, dvt) => new
                            {
                                ThietBiId = tb.ThietBiId,
                                Ten = tb.Ten,
                                SoHieu = tb.SoHieu,
                                SoLuong = tb.SoLuong,
                                DVT = dvt.Ten,
                                PhongBMId = tb.PhongBMId,
                                DonGia = tb.DonGia,
                                NguonKP = tb.NguonKP,
                                ThanhTien = tb.ThanhTien
                            }
                            ).Join(unitOfWork.GetRepository<DM_PhongHocBoMon>().GetAll(),
                            tb => tb.PhongBMId,
                            ph => ph.PhongHocId,
                            (tb, ph) => new 
                            {
                                ThietBiId = tb.ThietBiId,
                                Ten = tb.Ten,
                                SoHieu = tb.SoHieu,
                                DonViTinh = tb.DVT,
                                PhongHoc = ph.Ten,
                                SoLuongTang=tb.SoLuong,
                                DonGia=tb.DonGia,
                                NguonKP = tb.NguonKP,
                                ThanhTien = tb.ThanhTien
                            })
                            .Join(unitOfWork.GetRepository<DM_NguonKinhPhi>().GetAll(),
                            tb=>tb.NguonKP,
                            tmp=>tmp.NguonKinhPhiId,
                            (tb,tmp)=> new ThietBiTangGridDisplayModel
                            {
                                ThietBiId = tb.ThietBiId,
                                Ten = tb.Ten,
                                SoHieu = tb.SoHieu,
                                DonViTinh = tb.DonViTinh,
                                PhongHoc = tb.PhongHoc,
                                SoLuongTang = tb.SoLuongTang.ToString(),
                                DonGia = tb.DonGia.ToString(),
                                NguonKinhPhi = tmp.Ten,
                                ThanhTien = tb.ThanhTien.ToString()
                            }
                            )
                            .ToList();
                        //
                        model.ThietBis = ds;
                        //
                        return model;
                    }
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        #endregion
        #region Create,Update,Delete
        public int Create(PhieuTangTBModel model)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var data = new TB_PhieuGhiTang();
                    data.IsDelete = false;
                    MyConvert.TransferValues(data, model);

                    unitOfWork.GetRepository<TB_PhieuGhiTang>().Add(data);
                    if (unitOfWork.Save() >= 1)
                    {
                        //saving devices and update quantity
                        foreach (var item in model.ThietBis)
                        {
                            var ThietBi = new QH_PhieuGhiTang_ThietBi
                            {
                                SoHieuId = item.SoHieu,
                                SoLuong = Convert.ToInt32(item.SoLuongTang),
                                PhieuGhiTangId = model.PhieuGhiTangId
                            };
                            unitOfWork.GetRepository<QH_PhieuGhiTang_ThietBi>().Add(ThietBi);
                            var thietbi = unitOfWork.GetRepository<TB_ThongTinThietBi>().GetById(item.SoHieu);
                            if (thietbi != null)
                            {
                                thietbi.SoLuong += (int)ThietBi.SoLuong;
                                thietbi.SoLuongCon+= (int)ThietBi.SoLuong;
                                thietbi.TrangThai = 1;
                                unitOfWork.GetRepository<TB_ThongTinThietBi>().Update(thietbi);
                            }
                        }
                        if (unitOfWork.Save() >= 1)
                        {
                            return 1;
                        }
                        else return 2;
                    }
                    return 0;
                }
            }
            catch (Exception ex)
            {
                return -1;

            }
        }
        public int Update(PhieuTangTBModel model,List<ThietBiTangGridDisplayModel> ds)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var data = unitOfWork.GetRepository<TB_PhieuGhiTang>().GetById(model.PhieuGhiTangId);
                    if (data != null)
                    {
                        MyConvert.TransferValues(data, model);
                        unitOfWork.GetRepository<TB_PhieuGhiTang>().Update(data);
                        foreach(var item in model.ThietBis)
                        {
                            var tmp=unitOfWork.GetRepository<QH_PhieuGhiTang_ThietBi>().GetAll().Where(p => p.PhieuGhiTangId.Equals(model.PhieuGhiTangId) && p.SoHieuId.Equals(item.SoHieu)).FirstOrDefault();
                            if(tmp!=null)
                            {
                                var thietbi = unitOfWork.GetRepository<TB_ThongTinThietBi>().GetById(item.SoHieu);
                                if (thietbi != null)
                                {
                                    thietbi.SoLuong -= Convert.ToInt32(item.SoLuongTang);
                                    thietbi.SoLuongCon-= Convert.ToInt32(item.SoLuongTang);
                                    if (thietbi.SoLuong <= 0)
                                    {
                                        thietbi.SoLuong = 0;
                                        thietbi.SoLuongCon = 0;
                                        thietbi.TrangThai = 0;
                                    }
                                    unitOfWork.GetRepository<TB_ThongTinThietBi>().Update(thietbi);
                                }
                                unitOfWork.GetRepository<QH_PhieuGhiTang_ThietBi>().Delete(tmp);
                            }
                            
                        }
                        foreach (var item in ds)
                        {
                            unitOfWork.GetRepository<QH_PhieuGhiTang_ThietBi>().Add(new QH_PhieuGhiTang_ThietBi
                            {
                                PhieuGhiTangId = model.PhieuGhiTangId,
                                SoHieuId = item.SoHieu,
                                SoLuong = Convert.ToInt32(item.SoLuongTang)
                            });
                            var thietbi = unitOfWork.GetRepository<TB_ThongTinThietBi>().GetById(item.SoHieu);
                            if (thietbi != null)
                            {
                                thietbi.SoLuong += Convert.ToInt32(item.SoLuongTang);
                                thietbi.SoLuongCon += Convert.ToInt32(item.SoLuongTang);
                                thietbi.TrangThai = 1;
                                unitOfWork.GetRepository<TB_ThongTinThietBi>().Update(thietbi);
                            }
                        }
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
                    var data = unitOfWork.GetRepository<TB_PhieuGhiTang>().GetById(Id);
                    if (data != null)
                    {
                        data.IsDelete = true;
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
        public string GenerateCode()
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    string newCode = "PTTB";
                    var last = unitOfWork.GetRepository<TB_PhieuThanhLyTB>().GetAll().OrderByDescending(p => p.PhieuThanhLyTBId).FirstOrDefault();
                    if (last != null)
                    {
                        var lastCode = last.PhieuThanhLyTBId;
                        var numberPart = lastCode.Replace("PTTB", "");
                        var number = Convert.ToInt32(numberPart.TrimStart('0'));
                        var suffix = number + 1;


                        int numberofzero = suffix / 10;
                        for (int i = 0; i < 5 - numberofzero; i++)
                        {
                            newCode += "0";
                        }
                        newCode += suffix.ToString();
                    }
                    else
                    {
                        newCode = "PTTB000001";
                    }
                    return newCode;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
