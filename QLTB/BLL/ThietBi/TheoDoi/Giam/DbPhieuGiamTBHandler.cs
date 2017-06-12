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
    public class DbPhieuGiamTBHandler
    {
        #region Get Data
        public Paging<List<PhieuGiamTBGridDisplayModel>> GetAll(int page, int pageSize)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var TotalRecord = unitOfWork.GetRepository<TB_PhieuGiamTB>().GetAll().Where(p => p.IsDelete == false).Count();
                    var data = unitOfWork.GetRepository<TB_PhieuGiamTB>().GetAll().AsEnumerable()
                                 .Select(p => new PhieuGiamTBGridDisplayModel
                                 {
                                     SoPhieu=p.PhieuGiamTBId,
                                     GhiChu=p.GhiChu,
                                     NgayLap=MyConvert.DateToString(p.NgayLap)
                                 })
                                .OrderBy(p => p.SoPhieu)
                                .Skip(pageSize * (page - 1))
                                .Take(pageSize)
                                .ToList();

                    return new Paging<List<PhieuGiamTBGridDisplayModel>>
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
        public PhieuGiamTBModel GetById(string Id)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var data = unitOfWork.GetRepository<TB_PhieuGiamTB>().GetById(Id);
                    if (data != null)
                    {
                        var model = MyConvert.ConvertSameData<PhieuGiamTBModel>(data);
                        var ds = unitOfWork.GetRepository<QH_PhieuGiamTB_ThietBi>().GetAll()
                            .Where(p => p.PhieuGiamTBId == data.PhieuGiamTBId)
                            .Join(unitOfWork.GetRepository<TB_ThongTinThietBi>().GetAll(),
                            pm => pm.SoHieuTB,
                            tb => tb.SoHieu,
                            (pm, tb) => new
                            {
                                ThietBiId = tb.ThietBiId,
                                Ten = tb.Ten,
                                SoHieu = tb.SoHieu,
                                SoLuong = pm.SoLuong,
                                DVT = tb.DonViTinhId,
                                PhongBMId = tb.PhongHocId,
                                PhieuBaoHong = pm.PhieuBaoHongId,
                                LyDo = pm.LyDo
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
                                PhieuBaoHong = tb.PhieuBaoHong,
                                LyDo = tb.LyDo
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
                                LyDoGiam = tb.LyDo,
                                SoLuongGiam = tb.SoLuong.ToString(),
                                SoPhieuBaoHong = tb.PhieuBaoHong
                            })
                            .Join(unitOfWork.GetRepository<DM_ThietBiToiThieu>().GetAll(),
                            tb => tb.ThietBiId,
                            tbtt => tbtt.ThietBiId,
                            (tb, tbtt) => new
                            {
                                ThietBiId = tb.ThietBiId,
                                Ten = tb.Ten,
                                SoHieu = tb.SoHieu,
                                DonViTinh = tb.DonViTinh,
                                PhongHoc = tb.PhongHoc,
                                LyDoGiam = tb.LyDoGiam,
                                SoLuongGiam = tb.SoLuongGiam,
                                SoPhieuBaoHong = tb.SoPhieuBaoHong,
                                LoaiThietBi = tbtt.LoaiThietBiId
                            }).AsEnumerable()
                            .Join(GlobalVariable.GetDS().LoaiThietBi,
                            tb => tb.LoaiThietBi,
                            l => l.Id,
                            (tb, l) => new ThietBiGiamGridDisplayModel
                            {
                                ThietBiId = tb.ThietBiId,
                                Ten = tb.Ten,
                                SoHieu = tb.SoHieu,
                                DonViTinh = tb.DonViTinh,
                                PhongHoc = tb.PhongHoc,
                                LyDoGiam = tb.LyDoGiam,
                                SoLuongGiam = tb.SoLuongGiam,
                                SoPhieuBaoHong = tb.SoPhieuBaoHong,
                                LoaiThietBi = l.Ten
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
        #endregion
        #region Create,Update,Delete
        public int Create(PhieuGiamTBModel model)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var data = new TB_PhieuGiamTB();
                    data.IsDelete = false;
                    MyConvert.TransferValues(data, model);

                    unitOfWork.GetRepository<TB_PhieuGiamTB>().Add(data);
                    if (unitOfWork.Save() >= 1)
                    {
                        //saving devices and update quantity
                        foreach (var item in model.ThietBis)
                        {
                            var ThietBi = new QH_PhieuGiamTB_ThietBi
                            {
                                PhieuBaoHongId=item.SoPhieuBaoHong,
                                SoHieuTB=item.SoHieu,
                                LyDo=item.LyDoGiam,
                                SoLuong=Convert.ToInt32(item.SoLuongGiam),
                                PhieuGiamTBId=model.PhieuGiamTBId
                            };
                            unitOfWork.GetRepository<QH_PhieuGiamTB_ThietBi>().Add(ThietBi);
                            var thietbi = unitOfWork.GetRepository<TB_ThongTinThietBi>().GetById(item.SoHieu);
                            if (thietbi != null)
                            {
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
        public int Update(PhieuTangTBModel model)
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
                        unitOfWork.GetRepository<QH_PhieuGhiTang_ThietBi>().Delete(p => p.PhieuGhiTangId == model.PhieuGhiTangId);
                        foreach (var item in model.ThietBis)
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
    }
}
