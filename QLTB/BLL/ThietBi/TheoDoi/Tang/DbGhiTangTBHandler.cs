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
    public class DbGhiTangTBHandler
    {
        #region Create,Update,Delete
        public int Create(PhieuTangTBModel model)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var data = new TB_PhieuGhiTang();
                    MyConvert.TransferValues(data, model);
                    
                    unitOfWork.GetRepository<TB_PhieuGhiTang>().Add(data);
                    if (unitOfWork.Save() >= 1)
                    {
                        //saving devices and update quantity
                        foreach (var item in model.ThietBis)
                        {
                            var ThietBi = new QH_PhieuGhiTang_ThietBi
                            {
                                SoHieuId=item.SoHieu,
                                SoLuong=item.SoLuongTang,
                                PhieuGhiTangId=model.PhieuGhiTangId
                            };
                            unitOfWork.GetRepository<QH_PhieuGhiTang_ThietBi>().Add(ThietBi);
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
        //public int Update(PhieuMuonThietBiModel model, List<ThietBiMuonGridDisplayModel> ds)
        //{
        //    try
        //    {
        //        using (var unitOfWork = new UnitOfWork())
        //        {
        //            var data = unitOfWork.GetRepository<TB_PhieuMuonTB>().GetById(model.PhieuMuonTBId);
        //            if (data != null)
        //            {
        //                MyConvert.TransferValues(data, model);
        //                unitOfWork.GetRepository<TB_PhieuMuonTB>().Update(data);
        //                unitOfWork.GetRepository<QH_PhieuMuonTB_ThietBi>().Delete(p => p.PhieuMuonTBId == model.PhieuMuonTBId);
        //                foreach (var item in ds)
        //                {
        //                    int SoLuongMuon = Convert.ToInt32(item.SoLuongMuon);
        //                    unitOfWork.GetRepository<QH_PhieuMuonTB_ThietBi>().Add(new QH_PhieuMuonTB_ThietBi
        //                    {
        //                        SoHieuTB = item.SoHieu,
        //                        PhieuMuonTBId = model.PhieuMuonTBId,
        //                        SoLuong = SoLuongMuon,
        //                        IsDaTra = false
        //                    });
        //                    var thietbi = unitOfWork.GetRepository<TB_ThongTinThietBi>().GetById(item.SoHieu);
        //                    if (thietbi != null)
        //                    {
        //                        thietbi.SoLuongMuon += Convert.ToInt32(item.SoLuongMuon);
        //                        thietbi.SoLuongCon = thietbi.SoLuong - (thietbi.SoLuongMuon + thietbi.SoLuongHong + thietbi.SoLuongMat);
        //                        unitOfWork.GetRepository<TB_ThongTinThietBi>().Update(thietbi);
        //                    }
        //                }
        //                if (unitOfWork.Save() >= 1)
        //                {
        //                    return 1;
        //                }
        //            }
        //            return 0;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return -1;
        //    }
        //}
        //public int Delete(string PhieuMuonId)
        //{
        //    try
        //    {
        //        using (var unitOfWork = new UnitOfWork())
        //        {
        //            var data = unitOfWork.GetRepository<TB_PhieuMuonTB>().GetById(PhieuMuonId);
        //            if (data != null)
        //            {
        //                data.IsDelete = true;
        //                if (unitOfWork.Save() >= 1)
        //                {
        //                    return 1;
        //                }
        //            }
        //            return 0;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return -1;
        //    }
        //}
        #endregion

    }
}
