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
    public class DbPhieuThanhLyHandler
    {
        #region Get Data
        public Paging<List<PhieuTLGridDisplayModel>> GetAll(int page, int pageSize)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var TotalRecord = unitOfWork.GetRepository<TB_PhieuThanhLyTB>().GetAll().Where(p => p.IsDelete == false).Count();
                    var data = unitOfWork.GetRepository<TB_PhieuThanhLyTB>().GetAll().AsEnumerable()
                                 .Select(p => new PhieuTLGridDisplayModel
                                 {
                                     SoPhieu = p.PhieuThanhLyTBId,
                                     NgayLap = MyConvert.DateToString(p.NgapLap),
                                     GhiChu = p.NoiDung
                                 })
                                .OrderBy(p => p.SoPhieu)
                                .Skip(pageSize * (page - 1))
                                .Take(pageSize)
                                .ToList();

                    return new Paging<List<PhieuTLGridDisplayModel>>
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
        public PhieuThanhLyModel GetById(string Id)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var data = unitOfWork.GetRepository<TB_PhieuThanhLyTB>().GetById(Id);
                    if (data != null)
                    {
                        var model = MyConvert.ConvertSameData<PhieuThanhLyModel>(data);
                        var ds = unitOfWork.GetRepository<QH_PhieuThanhLyTB_ThietBi>().GetAll()
                            .Where(p => p.PhieuThanhLyTBId == data.PhieuThanhLyTBId)
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
                            (tb, ph) => new ThietBiTLGridDisplayModel
                            {
                                ThietBiId = tb.ThietBiId,
                                Ten = tb.Ten,
                                SoHieu = tb.SoHieu,
                                DonViTinh = tb.DVT,
                                PhongHoc = ph.Ten,
                                LyDo = tb.LyDo,
                                SoLuongTL = tb.SoLuong.ToString(),
                                SoPhieuBaoHong = tb.PhieuBaoHong
                            })
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
        public int Create(PhieuThanhLyModel model)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var data = new TB_PhieuThanhLyTB();
                    data.IsDelete = false;
                    MyConvert.TransferValues(data, model);

                    unitOfWork.GetRepository<TB_PhieuThanhLyTB>().Add(data);
                    if (unitOfWork.Save() >= 1)
                    {
                        //saving devices and update quantity
                        foreach (var item in model.ThietBis)
                        {
                            //Cap nhat danh sách thiets bị
                            var ThietBi = new QH_PhieuThanhLyTB_ThietBi
                            {
                                SoHieuTB=item.SoHieu,
                                LyDo=item.LyDo,
                                SoLuong=Convert.ToInt32(item.SoLuongTL),
                                PhieuBaoHongId=item.SoPhieuBaoHong,
                                PhieuThanhLyTBId=model.PhieuThanhLyTBId
                            };
                            unitOfWork.GetRepository<QH_PhieuThanhLyTB_ThietBi>().Add(ThietBi);


                            ////Cap nhat lai thong tin phieu bao hong
                            //var tmp= unitOfWork.GetRepository<QH_PhieuBaoHong_ThietBi>().GetAll().Where(p => p.PhieuBaoHongId.Equals(item.SoPhieuBaoHong) && p.SoHieuTB.Equals(item.SoHieu)).FirstOrDefault();
                            //tmp.SoLuong -= (int)ThietBi.SoLuong;
                            //unitOfWork.GetRepository<QH_PhieuBaoHong_ThietBi>().Update(tmp);



                            ////cap nhat lại so luong trong bang thiet bị
                            //var thietbi = unitOfWork.GetRepository<TB_ThongTinThietBi>().GetById(item.SoHieu);
                            //if (thietbi != null)
                            //{
                            //    thietbi.SoLuongHong -= (int)ThietBi.SoLuong;
                            //    thietbi.SoLuong -= (int)ThietBi.SoLuong;
                            //    unitOfWork.GetRepository<TB_ThongTinThietBi>().Update(thietbi);
                            //}
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
        public int Update(PhieuThanhLyModel model, List<ThietBiTLGridDisplayModel> ds)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var data = unitOfWork.GetRepository<TB_PhieuThanhLyTB>().GetById(model.PhieuThanhLyTBId);
                    if (data != null)
                    {
                        //Lưu thông tin chung
                        MyConvert.TransferValues(data, model);
                        unitOfWork.GetRepository<TB_PhieuThanhLyTB>().Update(data);
                        #region Cập nhật lại danh sách thiết bị cũ
                        foreach (var item in model.ThietBis)
                        {
                            unitOfWork.GetRepository<QH_PhieuThanhLyTB_ThietBi>()
                                .Delete(p => p.PhieuThanhLyTBId == model.PhieuThanhLyTBId && p.SoHieuTB == item.SoHieu);


                            ////Cap nhat lại phieu bao hong
                            //var tmp = unitOfWork.GetRepository<QH_PhieuBaoHong_ThietBi>().GetAll().Where(p => p.PhieuBaoHongId.Equals(item.SoPhieuBaoHong) && p.SoHieuTB.Equals(item.SoHieu)).FirstOrDefault();
                            //tmp.SoLuong += Convert.ToInt32(item.SoLuongTL);
                            //unitOfWork.GetRepository<QH_PhieuBaoHong_ThietBi>().Update(tmp);


                            ////Cap nhat lại thông tin số lượng thiết bị
                            //var thietbi = unitOfWork.GetRepository<TB_ThongTinThietBi>().GetById(item.SoHieu);
                            //if (thietbi != null)
                            //{
                            //    thietbi.SoLuongHong += Convert.ToInt32(item.SoLuongTL);
                            //    thietbi.SoLuong += Convert.ToInt32(item.SoLuongTL);
                            //    unitOfWork.GetRepository<TB_ThongTinThietBi>().Update(thietbi);
                            //}
                        }
                        #endregion
                        #region Cập nhật lại danh sách các thiết bị mới
                        foreach (var item in ds)
                        {
                            int SoLuongMuon = Convert.ToInt32(item.SoLuongTL);
                            unitOfWork.GetRepository<QH_PhieuThanhLyTB_ThietBi>().Add(new QH_PhieuThanhLyTB_ThietBi
                            {
                                SoHieuTB = item.SoHieu,
                                LyDo=item.LyDo,
                                SoLuong= SoLuongMuon,
                                PhieuBaoHongId=item.SoPhieuBaoHong,
                                PhieuThanhLyTBId=model.PhieuThanhLyTBId
                            });

                            ////Cap nhat lai thiet bi bao hong
                            //var tmp = unitOfWork.GetRepository<QH_PhieuBaoHong_ThietBi>().GetAll().Where(p => p.PhieuBaoHongId.Equals(item.SoPhieuBaoHong) && p.SoHieuTB.Equals(item.SoHieu)).FirstOrDefault();
                            //tmp.SoLuong -= Convert.ToInt32(item.SoLuongTL);
                            //unitOfWork.GetRepository<QH_PhieuBaoHong_ThietBi>().Update(tmp);


                            ////Cap nhat lại thông tin số lượng thiết bị
                            //var thietbi = unitOfWork.GetRepository<TB_ThongTinThietBi>().GetById(item.SoHieu);
                            //if (thietbi != null)
                            //{
                            //    thietbi.SoLuongMuon -= SoLuongMuon;
                            //    thietbi.SoLuongCon -= SoLuongMuon;
                            //    unitOfWork.GetRepository<TB_ThongTinThietBi>().Update(thietbi);
                            //}
                        }
                        #endregion
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
                    string newCode = "PTL";
                    var last = unitOfWork.GetRepository<TB_PhieuThanhLyTB>().GetAll().OrderByDescending(p => p.PhieuThanhLyTBId).FirstOrDefault();
                    if (last != null)
                    {
                        var lastCode = last.PhieuThanhLyTBId;
                        var numberPart = lastCode.Replace("PTL", "");
                        var number = Convert.ToInt32(numberPart.TrimStart('0'));
                        var suffix = number + 1;


                        int numberofzero = suffix / 10;
                        for (int i = 0; i < 6 - numberofzero; i++)
                        {
                            newCode += "0";
                        }
                        newCode += suffix.ToString();
                    }
                    else
                    {
                        newCode = "PTL0000001";
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
