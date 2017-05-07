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
    public class DbPhieuMuonTBHandler
    {
        public List<PhieuMuonTBGridDisplayModel> GetAll()
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var data = unitOfWork.GetRepository<TB_PhieuMuonTB>().GetAll()
                                  .Join(unitOfWork.GetRepository<DM_LopHoc>().GetAll(),
                                      tb => tb.LopHocId,
                                      lh => lh.LopHocId,
                                      (tb, lh) => new
                                      {
                                          PhieuMuonTBId = tb.PhieuMuonTBId,
                                          NgayMuon = tb.NgayMuon,
                                          NgayTra = tb.NgayTra,
                                          BaiDayId = tb.BaiDayId,
                                          LopHoc = lh.Ten,
                                          GiaoVienId = tb.GiaoVienId,
                                          TrangThaiId = tb.TrangThaiId
                                      }
                                  )
                                   .Join(unitOfWork.GetRepository<DM_GiaoVien>().GetAll(),
                                      tb => tb.GiaoVienId,
                                      gv => gv.GiaoVienId,
                                      (tb, gv) => new
                                      {
                                          PhieuMuonTBId = tb.PhieuMuonTBId,
                                          NgayMuon = tb.NgayMuon,
                                          NgayTra = tb.NgayTra,
                                          BaiDayId = tb.BaiDayId,
                                          LopHoc = tb.LopHoc,
                                          GiaoVien = gv.Ten,
                                          TrangThaiId = tb.TrangThaiId
                                      }
                                  ).Join(unitOfWork.GetRepository<DS_TrangThaiPhieuMuon>().GetAll(),
                                      tb => tb.TrangThaiId,
                                      tt => tt.TrangThaiPMTBId,
                                      (tb, tt) => new 
                                      {
                                          PhieuMuonTBId = tb.PhieuMuonTBId,
                                          NgayMuon = tb.NgayMuon,
                                          NgayTra = tb.NgayTra,
                                          BaiDay = tb.BaiDayId,
                                          LopHoc = tb.LopHoc,
                                          GiaoVien = tb.GiaoVien,
                                          TrangThai = tt.Ten
                                      }
                                    ).GroupJoin(unitOfWork.GetRepository<DS_BaiGiang>().GetAll(),
                                      tb => tb.BaiDay,
                                      bg => bg.BaiGiangId,
                                      (tb, g) => g
                                      .Select(bg => new
                                      {
                                          PhieuMuonTBId = tb.PhieuMuonTBId,
                                          NgayMuon = tb.NgayMuon,
                                          NgayTra = tb.NgayTra,
                                          BaiDay = bg.Ten,
                                          LopHoc = tb.LopHoc,
                                          GiaoVien = tb.GiaoVien,
                                          TrangThai = tb.TrangThai
                                      }).DefaultIfEmpty(new
                                      {
                                          PhieuMuonTBId = tb.PhieuMuonTBId,
                                          NgayMuon = tb.NgayMuon,
                                          NgayTra = tb.NgayTra,
                                          BaiDay = "",
                                          LopHoc = tb.LopHoc,
                                          GiaoVien = tb.GiaoVien,
                                          TrangThai = tb.TrangThai
                                      })
                                  ).SelectMany(g => g).ToList()
                                    .Select(tb => new PhieuMuonTBGridDisplayModel
                                    {
                                        PhieuMuonTBId = tb.PhieuMuonTBId,
                                        NgayMuon = MyConvert.DateToString(tb.NgayMuon),
                                        NgayTra = MyConvert.DateToString(tb.NgayTra),
                                        BaiDay = tb.BaiDay,
                                        LopHoc = tb.LopHoc,
                                        GiaoVien = tb.GiaoVien,
                                        TrangThai = tb.TrangThai
                                    }).ToList();

                    return data;

                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public PhieuMuonThietBiModel GetById(string Id)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var data = unitOfWork.GetRepository<TB_PhieuMuonTB>().GetById(Id);
                    if (data != null)
                    {
                        var model = MyConvert.ConvertSameData<PhieuMuonThietBiModel>(data);
                        var ds = unitOfWork.GetRepository<DAL.Data.QH_PhieuMuonTB_ThietBi>().GetAll()
                            .Where(p => p.PhieuMuonTBId == data.PhieuMuonTBId)
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
                                PhongBMId = tb.PhongHocId
                            }
                            ).Join(unitOfWork.GetRepository<DS_DonViTinh>().GetAll(),
                            tb => tb.DVT,
                            dvt => dvt.DonViTinhId,
                            (tb, dvt) => new
                            {
                                ThietBiId = tb.ThietBiId,
                                Ten = tb.Ten,
                                SoHieu = tb.SoHieu,
                                SoLuongMuon = tb.SoLuongMuon.ToString(),
                                DVT = dvt.Ten,
                                PhongBMId = tb.PhongBMId
                            }
                            ).Join(unitOfWork.GetRepository<DM_PhongHocBoMon>().GetAll(),
                            tb => tb.PhongBMId,
                            ph => ph.PhongHocId,
                            (tb, ph) => new ThietBiMuonGridDisplayModel
                            {
                                ThietBiId = tb.ThietBiId,
                                Ten = tb.Ten,
                                SoHieu = tb.SoHieu,
                                SoLuongMuon = tb.SoLuongMuon.ToString(),
                                DVT = tb.DVT,
                                PhongBM = ph.Ten
                            }
                            ).ToList();
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
        public int Create(PhieuMuonThietBiModel model)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var data = new TB_PhieuMuonTB();
                    MyConvert.TransferValues(data, model);
                    data.IsDelete = false;
                    data.TrangThaiId = 1;
                    unitOfWork.GetRepository<TB_PhieuMuonTB>().Add(data);
                    if (unitOfWork.Save() >= 1)
                    {
                        //saveing devices
                        foreach (var item in model.ThietBis)
                        {
                            var ThietBi = new DAL.Data.QH_PhieuMuonTB_ThietBi
                            {
                                IsDaTra = false,
                                SoHieuTB = item.SoHieu,
                                SoLuong = Convert.ToInt32(item.SoLuongMuon),
                                PhieuMuonTBId = model.PhieuMuonTBId
                            };
                            unitOfWork.GetRepository<DAL.Data.QH_PhieuMuonTB_ThietBi>().Add(ThietBi);
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
        //public int Update(PhieuMuonThietBiCreateModel model)
        //{
        //    try
        //    {
        //        using (var unitOfWork = new UnitOfWork())
        //        {

        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //}
        //public int Delete(PhieuMuonThietBiCreateModel model)
        //{
        //    try
        //    {
        //        using (var unitOfWork = new UnitOfWork())
        //        {

        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //}
        public string GenerateCode()
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    string newCode = "";
                    var last = unitOfWork.GetRepository<TB_PhieuMuonTB>().GetAll().OrderByDescending(p => p.PhieuMuonTBId).FirstOrDefault();
                    if (last != null)
                    {
                        var lastCode = last.PhieuMuonTBId;
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
                        newCode = "PMTB000001";
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
