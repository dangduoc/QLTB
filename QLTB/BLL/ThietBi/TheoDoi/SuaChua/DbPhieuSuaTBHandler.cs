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
        public int Create(PhieuSuaTBModel model)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var data = new TB_PhieuSuaTB();
                    MyConvert.TransferValues(data, model);
                    data.IsDelete = false;
                    unitOfWork.GetRepository<TB_PhieuSuaTB>().Add(data);
                    //if (unitOfWork.Save() >= 1)
                    //{
                    //saving devices and update quantity
                    foreach (var item in model.ThietBis)
                    {
                        var ThietBi = new QH_PhieuSuaTB_ThietBi
                        {
                            SoHieu = item.SoHieu,
                            SoLuong = Convert.ToInt32(item.SoLuongCanSua),
                            PhieuSuaTBId = model.PhieuSuaTBId,
                            DonGia = Convert.ToDecimal(item.DonGiaSua),
                            GiaTri = Convert.ToDecimal(item.GiaTri),
                            PhieuBaoHongId = item.MaPhieuHongMat,
                            ThanhTien = Convert.ToDecimal(item.ThanhTien),
                            TinhTrangHong = item.TinhTrangHong
                        };
                        unitOfWork.GetRepository<QH_PhieuSuaTB_ThietBi>().Add(ThietBi);
                        //}

                    }
                    if (unitOfWork.Save() >= 1)
                    {
                        return 1;
                    }
                    else return 0;
                }
            }
            catch (Exception ex)
            {
                return -1;

            }
        }
        public int Update(PhieuSuaTBModel model)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var data = unitOfWork.GetRepository<TB_PhieuSuaTB>().GetById(model.PhieuSuaTBId);
                    if (data != null)
                    {
                        MyConvert.TransferValues(data, model);
                        unitOfWork.GetRepository<TB_PhieuSuaTB>().Update(data);

                        unitOfWork.GetRepository<QH_PhieuSuaTB_ThietBi>().Delete(p => p.PhieuSuaTBId.Equals(model.PhieuSuaTBId));

                        foreach (var item in model.ThietBis)
                        {
                            unitOfWork.GetRepository<QH_PhieuSuaTB_ThietBi>().Add(new QH_PhieuSuaTB_ThietBi
                            {
                                SoHieu = item.SoHieu,
                                SoLuong = Convert.ToInt32(item.SoLuongCanSua),
                                PhieuSuaTBId = model.PhieuSuaTBId,
                                DonGia = Convert.ToDecimal(item.DonGiaSua),
                                GiaTri = Convert.ToDecimal(item.GiaTri),
                                PhieuBaoHongId = item.MaPhieuHongMat,
                                ThanhTien = Convert.ToDecimal(item.ThanhTien),
                                TinhTrangHong = item.TinhTrangHong
                            });
                            var thietbi = unitOfWork.GetRepository<TB_ThongTinThietBi>().GetById(item.SoHieu);
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
        public int Delete(string id)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var data = unitOfWork.GetRepository<TB_PhieuSuaTB>().GetById(id);
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
                    string newCode = "PSTB";
                    var last = unitOfWork.GetRepository<TB_PhieuSuaTB>().GetAll().OrderByDescending(p => p.PhieuSuaTBId).FirstOrDefault();
                    if (last != null)
                    {
                        var lastCode = last.PhieuSuaTBId;
                        var numberPart = lastCode.Replace("PSTB", "");
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
                        newCode = "PSTB000001";
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
