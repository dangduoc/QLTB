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
        public List<PhieuMuonPhongGridDisplayModel> GetAll()
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
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
                                  ).Join(unitOfWork.GetRepository<DM_MonHoc>().GetAll(),
                                      tb => tb.MonHocId,
                                      ltb => ltb.MonHocId,
                                      (tb, ltb) => new PhieuMuonPhongGridDisplayModel
                                      {
                                          PhieuMuonPhongId = tb.PhieuMuonPhongId,
                                          NgayMuon = tb.NgayMuon.ToString("dd/M/yyyy"),
                                          SoTiet = tb.SoTiet.ToString(),
                                          BaiDay = tb.BaiDay,
                                          MonHoc = ltb.Ten,
                                          LopHoc = tb.LopHoc,
                                          GiaoVien = tb.GiaoVien
                                      }
                                  ).ToList();

                    return data;

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
        //public int Create(PhieuMuonThietBiCreateModel model)
        //{
        //    try
        //    {
        //        using (var unitOfWork= new UnitOfWork())
        //        {

        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //}
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
    }
}
