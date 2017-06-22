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
    class DbPhieuMuonPhongHandler
    {
        public Paging<List<PhieuMuonPhongGridDisplayModel>> GetAll(int page, int pageSize)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var TotalRecord = unitOfWork.GetRepository<TB_PhieuMuonPhong>().GetAll().Where(p => p.IsDelete == false).Count();
                    var data = unitOfWork.GetRepository<TB_PhieuMuonPhong>().GetAll()
                                  .Join(unitOfWork.GetRepository<DS_BaiGiang>().GetAll(),
                                      tb => tb.BaiDayId,
                                      dvt => dvt.BaiGiangId,
                                      (tb, dvt) => new
                                      {
                                          PhieuMuonPhongId = tb.PhieuMuonPhongId,
                                          NgayMuon = tb.NgayMuon,
                                          SoTiet = tb.SoTiet,
                                          BaiDay = dvt.Ten,
                                          MonHocId = tb.MonHocId,
                                          LopHocId = tb.LopHocId,
                                          GiaoVienId = tb.GiaoVienId
                                      }
                                  )
                                  .Join(unitOfWork.GetRepository<DM_LopHoc>().GetAll(),
                                      tb => tb.LopHocId,
                                      lh => lh.LopHocId,
                                      (tb, lh) => new
                                      {
                                          PhieuMuonPhongId = tb.PhieuMuonPhongId,
                                          NgayMuon = tb.NgayMuon,
                                          SoTiet = tb.SoTiet,
                                          BaiDay = tb.BaiDay,
                                          MonHocId = tb.MonHocId,
                                          LopHoc = lh.Ten,
                                          GiaoVienId = tb.GiaoVienId
                                      }
                                  )
                                   .Join(unitOfWork.GetRepository<DM_GiaoVien>().GetAll(),
                                      tb => tb.GiaoVienId,
                                      ltb => ltb.GiaoVienId,
                                      (tb, ltb) => new
                                      {
                                          PhieuMuonPhongId = tb.PhieuMuonPhongId,
                                          NgayMuon = tb.NgayMuon,
                                          SoTiet = tb.SoTiet,
                                          BaiDay = tb.BaiDay,
                                          MonHocId = tb.MonHocId,
                                          LopHoc = tb.LopHoc,
                                          GiaoVien = ltb.Ten
                                      }
                                  ).AsEnumerable()
                                  .Join(unitOfWork.GetRepository<DM_MonHoc>().GetAll().AsEnumerable(),
                                      tb => tb.MonHocId,
                                      ltb => ltb.MonHocId,
                                      (tb, ltb) => new PhieuMuonPhongGridDisplayModel
                                      {
                                          PhieuMuonPhongId = tb.PhieuMuonPhongId,
                                          NgayMuon = MyConvert.DateToString(tb.NgayMuon),
                                          SoTiet = tb.SoTiet.ToString(),
                                          BaiDay = tb.BaiDay,
                                          MonHoc = ltb.Ten,
                                          LopHoc = tb.LopHoc,
                                          GiaoVien = tb.GiaoVien
                                      }
                                  )
                                  .OrderBy(p => p.PhieuMuonPhongId)
                                .Skip(pageSize * (page - 1))
                                .Take(pageSize)
                                .ToList();
                    return new Paging<List<PhieuMuonPhongGridDisplayModel>>
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
        public PhieuMuonPhongModel GetById(string Id)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var data = unitOfWork.GetRepository<TB_PhieuMuonPhong>().GetById(Id);
                    if (data != null)
                    {
                        var model = MyConvert.ConvertSameData<PhieuMuonPhongModel>(data);
                        var ds = unitOfWork.GetRepository<DAL.Data.QH_PhieuMuonPhong_ThietBi>().GetAll()
                            .Where(p => p.PhieuMuonPhongId == data.PhieuMuonPhongId)
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
                                DonViTinh = tb.DVT,
                                PhongHoc = ph.Ten
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
        #region Create,Update,Delete
        public int Create(PhieuMuonPhongModel model)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var data = new TB_PhieuMuonPhong();
                    MyConvert.TransferValues(data, model);
                    data.IsDelete = false;
                    data.TrangThaiId = 0;
                    unitOfWork.GetRepository<TB_PhieuMuonPhong>().Add(data);
                    if (unitOfWork.Save() >= 1)
                    {
                        //saving devices and update quantity
                        foreach (var item in model.ThietBis)
                        {
                            var ThietBi = new QH_PhieuMuonPhong_ThietBi
                            {
                                PhieuMuonPhongId = model.PhieuMuonPhongId,
                                SoHieuTB = item.SoHieu,
                                SoLuong = Convert.ToInt32(item.SoLuongMuon)
                            };
                            unitOfWork.GetRepository<QH_PhieuMuonPhong_ThietBi>().Add(ThietBi);

                            var thietbi = unitOfWork.GetRepository<TB_ThongTinThietBi>().GetById(item.SoHieu);
                            if (thietbi != null)
                            {
                                thietbi.SoLuongMuon += Convert.ToInt32(item.SoLuongMuon);
                                thietbi.SoLuongCon -= thietbi.SoLuongMuon;
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
        public int Update(PhieuMuonPhongModel model, List<ThietBiMuonGridDisplayModel> ds)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var data = unitOfWork.GetRepository<TB_PhieuMuonPhong>().GetById(model.PhieuMuonPhongId);
                    if (data != null)
                    {
                        //Lưu thông tin chung
                        MyConvert.TransferValues(data, model);
                        unitOfWork.GetRepository<TB_PhieuMuonPhong>().Update(data);
                        //Các thiết bị mượn cũ
                        foreach (var item in model.ThietBis)
                        {
                            unitOfWork.GetRepository<QH_PhieuMuonPhong_ThietBi>()
                                .Delete(p => p.PhieuMuonPhongId == model.PhieuMuonPhongId && p.SoHieuTB == item.SoHieu);
                            var thietbi = unitOfWork.GetRepository<TB_ThongTinThietBi>().GetById(item.SoHieu);
                            if (thietbi != null)
                            {
                                thietbi.SoLuongMuon -= Convert.ToInt32(item.SoLuongMuon);
                                thietbi.SoLuongCon += Convert.ToInt32(item.SoLuongMuon);
                                unitOfWork.GetRepository<TB_ThongTinThietBi>().Update(thietbi);
                            }
                        }
                        //Các thiết bị mượn mới
                        foreach (var item in ds)
                        {
                            int SoLuongMuon = Convert.ToInt32(item.SoLuongMuon);
                            unitOfWork.GetRepository<QH_PhieuMuonPhong_ThietBi>().Add(new QH_PhieuMuonPhong_ThietBi
                            {
                                SoHieuTB = item.SoHieu,
                                PhieuMuonPhongId = model.PhieuMuonPhongId,
                                SoLuong = SoLuongMuon
                            });
                            var thietbi = unitOfWork.GetRepository<TB_ThongTinThietBi>().GetById(item.SoHieu);
                            if (thietbi != null)
                            {
                                thietbi.SoLuongMuon += Convert.ToInt32(item.SoLuongMuon);
                                thietbi.SoLuongCon += Convert.ToInt32(item.SoLuongMuon);
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
        public int Delete(string PhieuMuonId)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var data = unitOfWork.GetRepository<TB_PhieuMuonPhong>().GetById(PhieuMuonId);
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
                    string newCode = "";
                    var last = unitOfWork.GetRepository<TB_PhieuMuonPhong>().GetAll().OrderByDescending(p => p.PhieuMuonPhongId).FirstOrDefault();
                    if (last != null)
                    {
                        var lastCode = last.PhieuMuonPhongId;
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
                        newCode = "PHMP000001";
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
