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
    public class DbMuaSamTBHandler
    {
        #region Get Data
        public Paging<List<DeNghiMuaGridDisplayModel>> GetAll(int page, int pageSize)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var TotalRecord = unitOfWork.GetRepository<TB_PhieuDeNghiMuaSam>().GetAll().Count();
                    var data = unitOfWork.GetRepository<TB_PhieuDeNghiMuaSam>().GetAll().AsEnumerable()
                                 .Select(p => new DeNghiMuaGridDisplayModel
                                 {
                                     SoPhieu = p.PhieuDeNghiId,
                                     TrangThai = p.TrangThaiId == 0 ? "Chưa gửi" : "Đã gửi",
                                     Ten = p.Ten,
                                     NamHoc = p.Ten,
                                     NgayLap = MyConvert.DateToString(p.NgayLap)
                                 })
                                .OrderBy(p => p.SoPhieu)
                                .Skip(pageSize * (page - 1))
                                .Take(pageSize)
                                .ToList();

                    return new Paging<List<DeNghiMuaGridDisplayModel>>
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
        public PhieuMuaSamTBModel GetById(string Id)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var data = unitOfWork.GetRepository<TB_PhieuDeNghiMuaSam>().GetById(Id);
                    if (data != null)
                    {
                        var model = MyConvert.ConvertSameData<PhieuMuaSamTBModel>(data);
                        var ds = unitOfWork.GetRepository<QH_PhieuDenNghiMS_ThietBi>().GetAll()
                            .Where(p => p.PhieuDeNghiId.Equals(data.PhieuDeNghiId))
                            .Join(unitOfWork.GetRepository<DM_ThietBiToiThieu>().GetAll(),
                            pm => pm.ThietBiId,
                            tb => tb.ThietBiId,
                            (pm, tb) => new
                            {
                                Ma = tb.ThietBiId,
                                Ten = tb.Ten,
                                Loai = tb.LoaiThietBiId,
                                SoLuongDangCo = pm.SoLuong,
                                SoLuongDeNghi = pm.SoLuongDeNghi,
                                DonGia = pm.DonGia,
                                ThanhTien = pm.ThanhTien
                            }
                            ).AsEnumerable()
                            .Join(GlobalVariable.GetDS().LoaiThietBi,
                            tb => tb.Loai,
                            l => l.Id,
                            (tb, l) => new ThietBiMuaGridDisplayModel
                            {
                                MaThietBi = tb.Ma,
                                Ten = tb.Ten,
                                DonGia = tb.DonGia.ToString(),
                                SoLuongDangCo = tb.SoLuongDangCo.ToString(),
                                SoLuongDeNghi = tb.SoLuongDeNghi.ToString(),
                                LoaiTB = l.Ten,
                                ThanhTien = tb.ThanhTien.ToString()
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
        public int Create(PhieuMuaSamTBModel model)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var data = new TB_PhieuDeNghiMuaSam();
                    data.TrangThaiId = 0;
                    MyConvert.TransferValues(data, model);

                    unitOfWork.GetRepository<TB_PhieuDeNghiMuaSam>().Add(data);
                    if (unitOfWork.Save() >= 1)
                    {
                        //saving devices and update quantity
                        foreach (var item in model.ThietBis)
                        {
                            //Cap nhat danh sách thiets bị
                            var ThietBi = new QH_PhieuDenNghiMS_ThietBi
                            {
                                PhieuDeNghiId = model.PhieuDeNghiId,
                                SoLuong = Convert.ToInt32(item.SoLuongDangCo),
                                SoLuongDeNghi = Convert.ToInt32(item.SoLuongDeNghi),
                                DonGia = Convert.ToDecimal(item.DonGia),
                                IsTuMua = item.isTuMua,
                                ThanhTien = Convert.ToDecimal(item.ThanhTien),
                                ThietBiId = item.MaThietBi
                            };
                            unitOfWork.GetRepository<QH_PhieuDenNghiMS_ThietBi>().Add(ThietBi);
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
        public int Update(PhieuMuaSamTBModel model, List<ThietBiMuaGridDisplayModel> ds)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var data = unitOfWork.GetRepository<TB_PhieuDeNghiMuaSam>().GetById(model.PhieuDeNghiId);
                    if (data != null)
                    {
                        //Lưu thông tin chung
                        MyConvert.TransferValues(data, model);
                        unitOfWork.GetRepository<TB_PhieuDeNghiMuaSam>().Update(data);
                        #region Cập nhật lại danh sách thiết bị cũ
                        unitOfWork.GetRepository<QH_PhieuDenNghiMS_ThietBi>()
                            .Delete(p => p.PhieuDeNghiId.Equals(model.PhieuDeNghiId));
                        #endregion
                        #region Cập nhật lại danh sách các thiết bị mới
                        foreach (var item in ds)
                        {  
                            unitOfWork.GetRepository<QH_PhieuDenNghiMS_ThietBi>().Add(new QH_PhieuDenNghiMS_ThietBi
                            {
                                PhieuDeNghiId = model.PhieuDeNghiId,
                                SoLuong = Convert.ToInt32(item.SoLuongDangCo),
                                SoLuongDeNghi = Convert.ToInt32(item.SoLuongDeNghi),
                                DonGia = Convert.ToDecimal(item.DonGia),
                                IsTuMua = item.isTuMua,
                                ThanhTien = Convert.ToDecimal(item.ThanhTien),
                                ThietBiId = item.MaThietBi
                            });
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
        //public int Delete(string Id)
        //{
        //    try
        //    {
        //        using (var unitOfWork = new UnitOfWork())
        //        {
        //            var data = unitOfWork.GetRepository<TB_PhieuGhiTang>().GetById(Id);
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
        public string GenerateCode()
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    string newCode = "DNMS";
                    var last = unitOfWork.GetRepository<TB_PhieuDeNghiMuaSam>().GetAll().OrderByDescending(p => p.PhieuDeNghiId).FirstOrDefault();
                    if (last != null)
                    {
                        var lastCode = last.PhieuDeNghiId;
                        var numberPart = lastCode.Replace("DNMS", "");
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
                        newCode = "DNMS000001";
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
