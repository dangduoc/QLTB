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
    public class DbPhieuSuaTBHandler
    {
        #region Get Data
        public Paging<List<PhieuSuaTBGridDisplayModel>> GetAll(int page, int pageSize)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var TotalRecord = unitOfWork.GetRepository<TB_PhieuSuaTB>().GetAll().Count();
                    var data = unitOfWork.GetRepository<TB_PhieuSuaTB>().GetAll().AsEnumerable()
                                    .Select(p => new PhieuSuaTBGridDisplayModel
                                    {
                                        PhieuSuaTBId = p.PhieuSuaTBId,
                                        GhiChu = p.GhiChu,
                                        NgayLap = MyConvert.DateToString(p.NgayLap)
                                    })
                                    .OrderBy(p => p.PhieuSuaTBId)
                                .Skip(pageSize * (page - 1))
                                .Take(pageSize)
                                .ToList();

                    return new Paging<List<PhieuSuaTBGridDisplayModel>>
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
        public PhieuSuaTBModel GetById(string Id)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var data = unitOfWork.GetRepository<TB_PhieuSuaTB>().GetById(Id);
                    if (data != null)
                    {
                        var model = MyConvert.ConvertSameData<PhieuSuaTBModel>(data);
                        var ds = unitOfWork.GetRepository<QH_PhieuSuaTB_ThietBi>().GetAll()
                            .Where(p => p.PhieuSuaTBId == data.PhieuSuaTBId)
                            .Join(unitOfWork.GetRepository<TB_ThongTinThietBi>().GetAll(),
                            pm => pm.SoHieu,
                            tb => tb.SoHieu,
                            (pm, tb) => new
                            {
                                ThietBiId = tb.ThietBiId,
                                Ten = tb.Ten,
                                SoHieu = tb.SoHieu,
                                DVT = tb.DonViTinhId,
                                PhongBMId = tb.PhongHocId,
                                SoLuongCanSua = pm.SoLuong,
                                GiaTri = pm.GiaTri,
                                DonGiaSua = pm.DonGia,
                                ThanhTien = pm.ThanhTien,
                                TinhTrangHong = pm.TinhTrangHong,
                                PhieuBaoHong = pm.PhieuBaoHongId
                            }
                            ).Join(unitOfWork.GetRepository<DS_DonViTinh>().GetAll(),
                            tb => tb.DVT,
                            dvt => dvt.DonViTinhId,
                            (tb, dvt) => new
                            {
                                ThietBiId = tb.ThietBiId,
                                Ten = tb.Ten,
                                SoHieu = tb.SoHieu,
                                DVT = dvt.Ten,
                                PhongBMId = tb.PhongBMId,
                                SoLuongCanSua = tb.SoLuongCanSua,
                                GiaTri = tb.GiaTri,
                                DonGiaSua = tb.DonGiaSua,
                                ThanhTien = tb.ThanhTien,
                                TinhTrangHong = tb.TinhTrangHong,
                                PhieuBaoHong = tb.PhieuBaoHong
                            }
                            ).Join(unitOfWork.GetRepository<DM_PhongHocBoMon>().GetAll(),
                            tb => tb.PhongBMId,
                            ph => ph.PhongHocId,
                            (tb, ph) => new ThietBiSuaGridDisplayModel
                            {
                                ThietBiId = tb.ThietBiId,
                                Ten = tb.Ten,
                                SoHieu = tb.SoHieu,
                                DonViTinh = tb.DVT,
                                PhongHoc = ph.Ten,
                                SoLuongCanSua = tb.SoLuongCanSua.ToString(),
                                GiaTri = tb.GiaTri.ToString(),
                                DonGiaSua = tb.DonGiaSua.ToString(),
                                ThanhTien = tb.ThanhTien.ToString(),
                                TinhTrangHong = tb.TinhTrangHong,
                                LoaiTB = "",
                                MaPhieuHongMat = tb.PhieuBaoHong
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
                            int tinhtrang = Convert.ToInt32(item.TinhTrang);
                            var ThietBi = new QH_PhieuBaoHong_ThietBi
                            {
                                LyDo = item.LyDo,
                                PhieuBaoHongId = model.PhieuBaoHongId,
                                TinhTrang = item.TinhTrangHong,
                                TinhTrangId = Convert.ToInt32(item.TinhTrang),
                                SoHieuTB = item.SoHieu,
                                SoLuong = Convert.ToInt32(item.SoLuongMuon)
                            };
                            unitOfWork.GetRepository<QH_PhieuBaoHong_ThietBi>().Add(ThietBi);
                            var thietbi = unitOfWork.GetRepository<TB_ThongTinThietBi>().GetById(item.SoHieu);
                            if (thietbi != null)
                            {
                                if (tinhtrang == 1)
                                {
                                    thietbi.SoLuongHong += Convert.ToInt32(item.SoLuongMuon);
                                }
                                else if (tinhtrang == 2)
                                {
                                    thietbi.SoLuongMat += Convert.ToInt32(item.SoLuongMuon);
                                }
                                thietbi.SoLuongCon -= Convert.ToInt32(item.SoLuongMuon);
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

                        foreach (var item in ds)
                        {
                            int tinhtrang = Convert.ToInt32(item.TinhTrang);
                            int soluong = Convert.ToInt32(item.SoLuongMuon);
                            int SoLuongHong = tinhtrang == 1 ? soluong : 0;
                            int SoLuongMat = tinhtrang == 2 ? soluong : 0;
                            var tmp = unitOfWork.GetRepository<QH_PhieuBaoHong_ThietBi>().GetAll()
                                .Where(p => p.PhieuBaoHongId.Equals(model.PhieuBaoHongId) && p.SoHieuTB.Equals(item.SoHieu))
                                .FirstOrDefault();

                            if (tmp != null)
                            {
                                unitOfWork.GetRepository<QH_PhieuBaoHong_ThietBi>().Delete(tmp);
                                //
                                var thietbi = unitOfWork.GetRepository<TB_ThongTinThietBi>().GetById(item.SoHieu);
                                if (thietbi != null)
                                {
                                    if (tinhtrang == 1)
                                    {
                                        thietbi.SoLuongHong -= Convert.ToInt32(item.SoLuongMuon);
                                    }
                                    else if (tinhtrang == 2)
                                    {
                                        thietbi.SoLuongMat -= Convert.ToInt32(item.SoLuongMuon);
                                    }
                                    thietbi.SoLuongCon += Convert.ToInt32(item.SoLuongMuon);
                                    unitOfWork.GetRepository<TB_ThongTinThietBi>().Update(thietbi);
                                }
                            }
                        }

                        foreach (var item in model.ThietBis)
                        {
                            int tinhtrang = Convert.ToInt32(item.TinhTrang);
                            int soluong = Convert.ToInt32(item.SoLuongMuon);
                            int SoLuongHong = tinhtrang == 1 ? soluong : 0;
                            int SoLuongMat = tinhtrang == 2 ? soluong : 0;
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
                                if (tinhtrang == 1)
                                {
                                    thietbi.SoLuongHong += Convert.ToInt32(item.SoLuongMuon);
                                }
                                else if (tinhtrang == 2)
                                {
                                    thietbi.SoLuongMat += Convert.ToInt32(item.SoLuongMuon);
                                }
                                thietbi.SoLuongCon -= Convert.ToInt32(item.SoLuongMuon);
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
