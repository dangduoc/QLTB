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
                                  .Join(unitOfWork.GetRepository<DS_BaiGiang>().GetAll(),
                                      tb => tb.BaiDayId,
                                      dvt => dvt.BaiGiangId,
                                      (tb, dvt) => new
                                      {
                                          PhieuMuonTBId = tb.PhieuMuonTBId,
                                          NgayMuon = tb.NgayMuon,
                                          NgayTra = tb.NgayTra,
                                          BaiDay = dvt.Ten,
                                          LopHocId = tb.LopHocId,
                                          GiaoVienId = tb.GiaoVienId,
                                          TrangThaiId = tb.TrangThaiId
                                      }
                                  )
                                  .Join(unitOfWork.GetRepository<DM_LopHoc>().GetAll(),
                                      tb => tb.LopHocId,
                                      lh => lh.LopHocId,
                                      (tb, lh) => new
                                      {
                                          PhieuMuonTBId = tb.PhieuMuonTBId,
                                          NgayMuon = tb.NgayMuon,
                                          NgayTra = tb.NgayTra,
                                          BaiDay = tb.BaiDay,
                                          LopHoc = lh.Ten,
                                          GiaoVienId = tb.GiaoVienId,
                                          TrangThaiId = tb.TrangThaiId
                                      }
                                  )
                                   .Join(unitOfWork.GetRepository<DM_GiaoVien>().GetAll(),
                                      tb => tb.GiaoVienId,
                                      ltb => ltb.GiaoVienId,
                                      (tb, ltb) => new
                                      {
                                          PhieuMuonTBId = tb.PhieuMuonTBId,
                                          NgayMuon = tb.NgayMuon,
                                          NgayTra = tb.NgayTra,
                                          BaiDay = tb.BaiDay,
                                          LopHoc = tb.LopHoc,
                                          GiaoVien = ltb.Ten,
                                          TrangThaiId = tb.TrangThaiId
                                      }
                                  ).Join(unitOfWork.GetRepository<DS_TrangThaiPhieuMuon>().GetAll(),
                                      tb => tb.TrangThaiId,
                                      ltb => ltb.TrangThaiPMTBId,
                                      (tb, ltb) => new PhieuMuonTBGridDisplayModel
                                      {
                                          PhieuMuonTBId = tb.PhieuMuonTBId,
                                          NgayMuon = tb.NgayMuon.ToString("dd/M/yyyy"),
                                          NgayTra = tb.NgayTra.ToString("dd/M/yyyy"),
                                          BaiDay = tb.BaiDay,
                                          LopHoc = tb.LopHoc,
                                          GiaoVien = ltb.Ten,
                                          TrangThai = ltb.Ten
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
