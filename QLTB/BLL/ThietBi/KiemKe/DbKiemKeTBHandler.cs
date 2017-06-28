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
    public class DbKiemKeTBHandler
    {
        #region Get Data
        public Paging<List<KiemKeTBGridDisplayModel>> GetAll(int page, int pageSize)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var TotalRecord = unitOfWork.GetRepository<TB_PhieuKiemKe>().GetAll().Count();
                    var data = unitOfWork.GetRepository<TB_PhieuKiemKe>().GetAll().AsEnumerable()
                                .Select(p => new KiemKeTBGridDisplayModel
                                {
                                    SoPhieu = p.SoPhieu,
                                    NgayLap = MyConvert.DateToString(p.NgayLap),
                                    NgayKiemKe = MyConvert.DateToString(p.NgayKiemKe),
                                    GhiChu = p.GhiChu
                                })
                                .OrderBy(p => p.SoPhieu)
                                .Skip(pageSize * (page - 1))
                                .Take(pageSize)
                                .ToList();

                    return new Paging<List<KiemKeTBGridDisplayModel>>
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
        public PhieuKiemKeThietBiModel GetById(string Id)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var data = unitOfWork.GetRepository<TB_PhieuKiemKe>().GetById(Id);
                    if (data != null)
                    {
                        var model = MyConvert.ConvertSameData<PhieuKiemKeThietBiModel>(data);
                        var ds = unitOfWork.GetRepository<QH_PhieuKiemKe_ThietBi>().GetAll()
                            .Where(p => p.SoPhieu.Equals(data.SoPhieu))
                            .Join(unitOfWork.GetRepository<TB_ThongTinThietBi>().GetAll(),
                            tb => tb.SoHieu,
                            tmp => tmp.SoHieu,
                            (tb, tmp) => new
                            {
                                SoHieu = tb.SoHieu,
                                SoLuong = tb.SoLuong,
                                HongSau = tb.HongSau,
                                HongTruoc = tb.HongTruoc,
                                MatSau = tb.MatSau,
                                ChenhLechHong = tb.ChenhLechHong,
                                ChenhLechMat = tb.ChenhLechMat,
                                ConDungDuoc = tb.ConDungDuoc,
                                DonViTinh = tb.DonViTinhId,
                                GhiChu = tb.GhiChu,
                                MatTruoc = tb.MatTruoc,
                                PhongHoc = tb.PhongHocId,
                                Ten = tmp.Ten
                            }
                            )
                            .Join(unitOfWork.GetRepository<DS_DonViTinh>().GetAll(),
                            tb => tb.DonViTinh,
                            dvt => dvt.DonViTinhId,
                            (tb, dvt) => new
                            {
                                SoHieu = tb.SoHieu,
                                SoLuong = tb.SoLuong,
                                HongSau = tb.HongSau,
                                HongTruoc = tb.HongTruoc,
                                MatSau = tb.MatSau,
                                ChenhLechHong = tb.ChenhLechHong,
                                ChenhLechMat = tb.ChenhLechMat,
                                ConDungDuoc = tb.ConDungDuoc,
                                DonViTinh = dvt.Ten,
                                GhiChu = tb.GhiChu,
                                MatTruoc = tb.MatTruoc,
                                PhongHoc = tb.PhongHoc,
                                Ten = tb.Ten
                            }
                            )
                            .Join(unitOfWork.GetRepository<DM_PhongHocBoMon>().GetAll(),
                            tb => tb.PhongHoc,
                            ph => ph.PhongHocId,
                            (tb, ph) => new
                            {
                                SoHieu = tb.SoHieu,
                                SoLuong = tb.SoLuong,
                                HongSau = tb.HongSau,
                                HongTruoc = tb.HongTruoc,
                                MatSau = tb.MatSau,
                                ChenhLechHong = tb.ChenhLechHong,
                                ChenhLechMat = tb.ChenhLechMat,
                                ConDungDuoc = tb.ConDungDuoc,
                                DonViTinh = tb.DonViTinh,
                                GhiChu = tb.GhiChu,
                                MatTruoc = tb.MatTruoc,
                                PhongHoc = ph.Ten,
                                Ten = tb.Ten
                            }
                            )
                           .Select(p => new ThietBiKKGridDisplayModel
                           {
                               SoHieu = p.SoHieu,
                               SoLuong = p.SoLuong,
                               HongSau = p.HongSau,
                               HongTruoc = p.HongTruoc,
                               MatSau = p.MatSau,
                               ChenhLechHong = p.ChenhLechHong,
                               ChenhLechMat = p.ChenhLechMat,
                               ConDungDuoc = p.ConDungDuoc,
                               DonViTinh = p.DonViTinh,
                               GhiChu = p.GhiChu,
                               MatTruoc = p.MatTruoc,
                               PhongHoc = p.PhongHoc
                           }).ToList();
                        //
                        model.ThietBis = ds;
                        //
                        var bankiemke = unitOfWork.GetRepository<QH_PhieuKiemKe_BanKiemKe>().GetAll()
                            .Where(p => p.SoPhieu.Equals(model.SoPhieu))
                            .Select(p => new BanKiemKeGridDisplayModel
                            {
                                HoTen = p.Ten,
                                ChucVu = p.ChucVu,
                                DaiDien = p.DaiDien,
                                VaiTro = p.VaiTro
                            }).ToList();
                        model.BanKiemKe = bankiemke;
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
        public int Create(PhieuKiemKeThietBiModel model)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var data = new TB_PhieuKiemKe();
                    MyConvert.TransferValues(data, model);

                    unitOfWork.GetRepository<TB_PhieuKiemKe>().Add(data);
                    if (unitOfWork.Save() >= 1)
                    {
                        #region Danh sách thiết bị
                        foreach (var item in model.ThietBis)
                        {
                            //Cap nhat danh sách thiets bị
                            var ThietBi = new QH_PhieuKiemKe_ThietBi
                            {
                                SoHieu = item.SoHieu,
                                SoLuong = item.SoLuong,
                                SoPhieu = model.SoPhieu,
                                HongSau = item.HongSau,
                                MatSau = item.MatSau,
                                ChenhLechMat = item.ChenhLechMat,
                                ChenhLechHong = item.ChenhLechHong,
                                ConDungDuoc = item.ConDungDuoc,
                                GhiChu = item.GhiChu,
                                MatTruoc = item.MatTruoc,
                                HongTruoc = item.HongTruoc
                        
                            };
                            var tmp = unitOfWork.GetRepository<TB_ThongTinThietBi>().GetById(item.SoHieu);
                            if (tmp != null)
                            {
                                ThietBi.PhongHocId = tmp.PhongHocId;
                                ThietBi.DonViTinhId = tmp.DonViTinhId;
                                ThietBi.MonHocId = tmp.MonHocId;
                            }
                            unitOfWork.GetRepository<QH_PhieuKiemKe_ThietBi>().Add(ThietBi);
                        }
                        #endregion
                        #region Danh sách ban kiểm kê
                        foreach (var item in model.BanKiemKe)
                        {
                            unitOfWork.GetRepository<QH_PhieuKiemKe_BanKiemKe>().Add(new QH_PhieuKiemKe_BanKiemKe
                            {
                                SoPhieu = model.SoPhieu,
                                ChucVu = item.ChucVu,
                                DaiDien=item.DaiDien,
                                Ten=item.HoTen,
                                VaiTro=item.VaiTro
                            });
                        }
                        #endregion
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
        public int Update(PhieuKiemKeThietBiModel model)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                   
                    var data = unitOfWork.GetRepository<TB_PhieuKiemKe>().GetById(model.SoPhieu);
                    if (data != null)
                    {
                        //Lưu thông tin chung
                        MyConvert.TransferValues(data, model);
                        unitOfWork.GetRepository<TB_PhieuKiemKe>().Update(data);
                        #region Cập nhật lại danh sách thiết bị cũ
                        unitOfWork.GetRepository<QH_PhieuKiemKe_ThietBi>()
                            .Delete(p => p.SoPhieu.Equals(model.SoPhieu));
                        #endregion
                        #region Cập nhật lại danh sách các thiết bị mới
                        foreach (var item in model.ThietBis)
                        {
                            var ThietBi = new QH_PhieuKiemKe_ThietBi
                            {
                                SoHieu = item.SoHieu,
                                SoLuong = item.SoLuong,
                                SoPhieu = model.SoPhieu,
                                HongSau = item.HongSau,
                                MatSau = item.MatSau,
                                ChenhLechMat = item.ChenhLechMat,
                                ChenhLechHong = item.ChenhLechHong,
                                ConDungDuoc = item.ConDungDuoc,
                                GhiChu = item.GhiChu,
                                MatTruoc = item.MatTruoc,
                                HongTruoc = item.HongTruoc
                            };
                            var tmp = unitOfWork.GetRepository<TB_ThongTinThietBi>().GetById(item.SoHieu);
                            if (tmp != null)
                            {
                                ThietBi.PhongHocId = tmp.PhongHocId;
                                ThietBi.DonViTinhId = tmp.DonViTinhId;
                                ThietBi.MonHocId = tmp.MonHocId;
                            }
                            unitOfWork.GetRepository<QH_PhieuKiemKe_ThietBi>().Add(ThietBi);
                        }
                        #endregion
                        #region Sửa danh sách ban kiểm kê
                        unitOfWork.GetRepository<QH_PhieuKiemKe_BanKiemKe>().Delete(p => p.SoPhieu.Equals(model.SoPhieu));
                        foreach (var item in model.BanKiemKe)
                        {
                            unitOfWork.GetRepository<QH_PhieuKiemKe_BanKiemKe>().Add(new QH_PhieuKiemKe_BanKiemKe
                            {
                                SoPhieu = model.SoPhieu,
                                ChucVu = item.ChucVu,
                                DaiDien = item.DaiDien,
                                Ten = item.HoTen,
                                VaiTro = item.VaiTro
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
        #endregion
        public string GenerateCode()
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    string newCode = "KTTB";
                    var last = unitOfWork.GetRepository<TB_PhieuKiemKe>().GetAll().OrderByDescending(p => p.SoPhieu).FirstOrDefault();
                    if (last != null)
                    {
                        var lastCode = last.SoPhieu;
                        var numberPart = lastCode.Replace("KTTB", "");
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
                        newCode = "KTTB000001";
                    }
                    return newCode;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public List<ThietBiKKGridDisplayModel> GetTB()
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var data = unitOfWork.GetRepository<TB_ThongTinThietBi>().GetAll().Where(p=>p.TrangThai>=1);
                    if (data != null)
                    {
                        var ds = data
                            .Join(unitOfWork.GetRepository<DS_DonViTinh>().GetAll(),
                            tb => tb.DonViTinhId,
                            dvt => dvt.DonViTinhId,
                            (tb, dvt) => new
                            {
                                SoHieu = tb.SoHieu,
                                SoLuong = tb.SoLuong,
                                DonViTinh = dvt.Ten,
                                GhiChu = tb.GhiChu,
                                Ten = tb.Ten,
                                PhongHocId=tb.PhongHocId,
                                Mat=tb.SoLuongMat,
                                Hong=tb.SoLuongHong,
                                MonHoc=tb.MonHocId
                            }
                            )
                            .Join(unitOfWork.GetRepository<DM_PhongHocBoMon>().GetAll(),
                            tb => tb.PhongHocId,
                            ph => ph.PhongHocId,
                            (tb, ph) => new
                            {
                                SoHieu = tb.SoHieu,
                                SoLuong = tb.SoLuong,
                                DonViTinh = tb.DonViTinh,
                                GhiChu = tb.GhiChu,
                                PhongHoc = ph.Ten,
                                Ten = tb.Ten,
                                Mat = tb.Mat,
                                Hong = tb.Hong,
                                MonHoc = tb.MonHoc
                            }
                            )
                            .Join(unitOfWork.GetRepository<DM_MonHoc>().GetAll(),
                            tb=>tb.MonHoc,
                            mh=>mh.MonHocId,
                            (tb, mh) => new
                            {
                                SoHieu = tb.SoHieu,
                                SoLuong = tb.SoLuong,
                                DonViTinh = tb.DonViTinh,
                                GhiChu = tb.GhiChu,
                                PhongHoc = tb.PhongHoc,
                                Ten = tb.Ten,
                                Mat = tb.Mat,
                                Hong = tb.Hong,
                                MonHoc = mh.Ten
                            }
                            )
                           .Select(p => new ThietBiKKGridDisplayModel
                           {
                               Ten=p.Ten,
                               SoHieu = p.SoHieu,
                               SoLuong = p.SoLuong,
                               HongSau = 0,
                               HongTruoc = p.Hong,
                               MatSau = 0,
                               ChenhLechHong = 0,
                               ChenhLechMat = 0,
                               ConDungDuoc = 0,
                               DonViTinh = p.DonViTinh,
                               GhiChu = p.GhiChu,
                               MatTruoc = p.Mat,
                               PhongHoc = p.PhongHoc,
                               MonHoc=p.MonHoc
                           }).ToList();
                        //
                       
                        return ds;
                    }
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
