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
    public class DbPhieuBaoHongHandler
    {
        #region Get Data
        public Paging<List<PhieuBaoHongGridDisplayModel>> GetAll(int page, int pageSize)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var TotalRecord = unitOfWork.GetRepository<TB_PhieuBaoHong>().GetAll().Where(p => p.IsDelete==false).Count();
                    var data = unitOfWork.GetRepository<TB_PhieuBaoHong>().GetAll().Where(p => p.IsDelete == false)
                                    .Select(p => new PhieuBaoHongGridDisplayModel
                                    {
                                        PhieuBaoHongId=p.PhieuBaoHongId,
                                        NguoiLamHong=p.NguoiLamHong,
                                        NgayLap=p.NgayLap.ToString(),
                                        GhiChu=p.GhiChu
                                    })
                                    .OrderBy(p => p.PhieuBaoHongId)
                                .Skip(pageSize * (page - 1))
                                .Take(pageSize)
                                .ToList();

                    return new Paging<List<PhieuBaoHongGridDisplayModel>>
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
        public PhieuBaoHongModel GetById(string Id)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var data = unitOfWork.GetRepository<TB_PhieuBaoHong>().GetById(Id);
                    if (data != null)
                    {
                        var model = MyConvert.ConvertSameData<PhieuBaoHongModel>(data);
                        var ds = unitOfWork.GetRepository<QH_PhieuBaoHong_ThietBi>().GetAll()
                            .Where(p => p.PhieuBaoHongId == data.PhieuBaoHongId)
                            .Join(unitOfWork.GetRepository<TB_ThongTinThietBi>().GetAll(),
                            pm => pm.SoHieuTB,
                            tb => tb.SoHieu,
                            (pm, tb) => new
                            {
                                ThietBiId = tb.ThietBiId,
                                Ten = tb.Ten,
                                SoHieu = tb.SoHieu,
                                SoLuongMuon = pm.SoLuong,
                                DVT = tb.DonViTinhId,
                                PhongBMId = tb.PhongHocId,
                                LyDo = pm.LyDo,
                                TinhTrangId = pm.TinhTrangId,
                                TinhTrangHong = pm.TinhTrang

                            }
                            ).Join(unitOfWork.GetRepository<DS_DonViTinh>().GetAll(),
                            tb => tb.DVT,
                            dvt => dvt.DonViTinhId,
                            (tb, dvt) => new
                            {
                                ThietBiId = tb.ThietBiId,
                                Ten = tb.Ten,
                                SoHieu = tb.SoHieu,
                                SoLuongMuon = tb.SoLuongMuon,
                                DVT = dvt.Ten,
                                PhongBMId = tb.PhongBMId,
                                LyDo = tb.LyDo,
                                TinhTrangId = tb.TinhTrangId,
                                TinhTrangHong = tb.TinhTrangHong
                            }
                            ).Join(unitOfWork.GetRepository<DM_PhongHocBoMon>().GetAll(),
                            tb => tb.PhongBMId,
                            ph => ph.PhongHocId,
                            (tb, ph) => new
                            {
                                ThietBiId = tb.ThietBiId,
                                Ten = tb.Ten,
                                SoHieu = tb.SoHieu,
                                SoLuongMuon = tb.SoLuongMuon.ToString(),
                                DonViTinh = tb.DVT,
                                PhongHoc = ph.Ten,
                                LyDo = tb.LyDo,
                                TinhTrang = tb.TinhTrangId,
                                TinhTrangHong = tb.TinhTrangHong
                            }
                            ).AsEnumerable()
                            .Join(GlobalVariable.GetDS().TinhTrangPhieuBH,
                            tb => tb.TinhTrang,
                            ph => ph.Id,
                            (tb, ph) => new ThietBiHongGridDisplayModel
                            {
                                ThietBiId = tb.ThietBiId,
                                Ten = tb.Ten,
                                SoHieu = tb.SoHieu,
                                SoLuongMuon = tb.SoLuongMuon.ToString(),
                                DonViTinh = tb.DonViTinh,
                                PhongHoc = tb.Ten,
                                LyDo = tb.LyDo,
                                TinhTrang = ph.Ten,
                                TinhTrangHong = tb.TinhTrangHong
                            }).ToList();
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
        public int Create(PhieuBaoHongModel model)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var data = new TB_PhieuBaoHong();
                    MyConvert.TransferValues(data, model);
                    data.IsDelete = false;
                    unitOfWork.GetRepository<TB_PhieuBaoHong>().Add(data);
                    if (unitOfWork.Save() >= 1)
                    {
                        //saving devices and update quantity
                        foreach (var item in model.ThietBis)
                        {
                            var ThietBi = new QH_PhieuBaoHong_ThietBi
                            {
                                LyDo = item.LyDo,
                                PhieuBaoHongId=model.PhieuBaoHongId,
                                TinhTrang=item.TinhTrangHong,
                                TinhTrangId=Convert.ToInt32(item.TinhTrang),
                                SoHieuTB = item.SoHieu,
                                SoLuong = Convert.ToInt32(item.SoLuongMuon)
                            };
                            unitOfWork.GetRepository<QH_PhieuBaoHong_ThietBi>().Add(ThietBi);
                            var thietbi = unitOfWork.GetRepository<TB_ThongTinThietBi>().GetById(item.SoHieu);
                            if (thietbi != null)
                            {     
                                thietbi.SoLuongHong += model.ThietBis.Where(p => p.TinhTrang.Equals("1")).Count();
                                thietbi.SoLuongMat += model.ThietBis.Where(p => p.TinhTrang.Equals("2")).Count();
                                thietbi.SoLuongCon= thietbi.SoLuong - (thietbi.SoLuongHong + thietbi.SoLuongMat+thietbi.SoLuongMuon);
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
        public int Update(PhieuBaoHongModel model, List<ThietBiHongGridDisplayModel> ds)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var data = unitOfWork.GetRepository<TB_PhieuBaoHong>().GetById(model.PhieuBaoHongId);
                    if (data != null)
                    {
                        MyConvert.TransferValues(data, model);
                        unitOfWork.GetRepository<TB_PhieuBaoHong>().Update(data);
                        unitOfWork.GetRepository<QH_PhieuBaoHong_ThietBi>().Delete(p => p.PhieuBaoHongId == model.PhieuBaoHongId);
                        foreach (var item in ds)
                        {
                            int SoLuongMuon = Convert.ToInt32(item.SoLuongMuon);
                            unitOfWork.GetRepository<QH_PhieuBaoHong_ThietBi>().Add(new QH_PhieuBaoHong_ThietBi
                            {
                                LyDo = item.LyDo,
                                PhieuBaoHongId = model.PhieuBaoHongId,
                                TinhTrang = item.TinhTrangHong,
                                TinhTrangId = Convert.ToInt32(item.TinhTrang),
                                SoHieuTB = item.SoHieu,
                                SoLuong = Convert.ToInt32(item.SoLuongMuon)
                            });
                            var thietbi = unitOfWork.GetRepository<TB_ThongTinThietBi>().GetById(item.SoHieu);
                            if (thietbi != null)
                            {
                                thietbi.SoLuongHong += model.ThietBis.Where(p => p.TinhTrang.Equals("1")).Count();
                                thietbi.SoLuongMat += model.ThietBis.Where(p => p.TinhTrang.Equals("2")).Count();
                                thietbi.SoLuongCon = thietbi.SoLuong - (thietbi.SoLuongHong + thietbi.SoLuongMat + thietbi.SoLuongMuon);
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
        public int Delete(string PhieuBaoHongId)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var data = unitOfWork.GetRepository<TB_PhieuBaoHong>().GetById(PhieuBaoHongId);
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
        public int AddToList(List<ThietBiHongGridDisplayModel> list, string PhieuBaoHongId)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    foreach (var item in list)
                    {
                        QH_PhieuBaoHong_ThietBi tmp = new QH_PhieuBaoHong_ThietBi
                        {
                            LyDo=item.LyDo,
                            PhieuBaoHongId=PhieuBaoHongId,
                            TinhTrang=item.TinhTrangHong,
                            TinhTrangId=Convert.ToInt32(item.TinhTrang),
                            SoHieuTB = item.SoHieu,
                            SoLuong = Convert.ToInt32(item.SoLuongMuon),
                        };
                        unitOfWork.GetRepository<QH_PhieuBaoHong_ThietBi>().Add(tmp);
                    }

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
        public int RemoveFromList(string SoHieu, string PhieuBaoHongId)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var data = unitOfWork.GetRepository<QH_PhieuBaoHong_ThietBi>().GetAll().Where(p => p.SoHieuTB.Equals(SoHieu) && p.PhieuBaoHongId.Equals(PhieuBaoHongId)).FirstOrDefault();
                    if (data != null)
                    {
                        unitOfWork.GetRepository<QH_PhieuBaoHong_ThietBi>().Delete(data);
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
        public string GenerateCode()
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    string newCode = "";
                    var last = unitOfWork.GetRepository<TB_PhieuBaoHong>().GetAll().OrderByDescending(p => p.PhieuBaoHongId).FirstOrDefault();
                    if (last != null)
                    {
                        var lastCode = last.PhieuBaoHongId;
                        var numberPart = lastCode.Remove(0, 4);
                        var prefixPart = lastCode.Substring(0, 4);
                        var number = Convert.ToInt32(numberPart.TrimStart('0'));
                        var suffix = number + 1;
                        int sizePrefix = prefixPart.Length;
                        int sizeSuffix = suffix.ToString().Length;
                        string middle = "";
                        for (int i = 0; i < (10 - sizePrefix - sizeSuffix); i++)
                        {
                            middle += "0";
                        }
                        newCode = prefixPart + middle + suffix;
                        return newCode;
                    }
                    else
                    {
                        newCode = "PHBH000001";
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