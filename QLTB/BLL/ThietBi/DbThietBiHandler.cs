using QLTB.DAL;
using QLTB.DAL.Data;
using QLTB.Model;
using QLTB.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace QLTB.Handler
{
    public class DbThietBiHandler
    {
        public Paging<List<ThietBiGridDisplayModel>> GetAll(int page, int pageSize, Expression<Func<TB_ThongTinThietBi, bool>> predicate)
        {
            using (var unitOfWork = new UnitOfWork())
            {
                try
                {
                    var dstb = unitOfWork.GetRepository<TB_ThongTinThietBi>().GetAll().Where(predicate);
                    var TotalRecord = dstb.Count();
                    var data = dstb
                                .Join(unitOfWork.GetRepository<DM_PhongHocBoMon>().GetAll(),
                                    tb => tb.PhongHocId,
                                    ph => ph.PhongHocId,
                                    (tb, ph) => new
                                    {
                                        ThietBiId = tb.ThietBiId,
                                        SoHieu = tb.SoHieu,
                                        Ten = tb.Ten,
                                        KhoPhong = ph.Ten,
                                        MonHocId = tb.MonHocId,
                                        SoLuong = tb.SoLuong,
                                        SoLuongMat = tb.SoLuongMat,
                                        SoLuongHong = tb.SoLuongHong,
                                        DonViTinhId = tb.DonViTinhId,
                                        TrangThaiId = tb.TrangThai,
                                        SoLuongCon = tb.SoLuongCon,
                                        DonGia = tb.DonGia,
                                        ThanhTien = tb.ThanhTien,
                                        NguonKP = tb.NguonKinhPhiId
                                    }
                                )
                                .Join(unitOfWork.GetRepository<DM_MonHoc>().GetAll(),
                                    tb => tb.MonHocId,
                                    mh => mh.MonHocId,
                                    (tb, mh) => new
                                    {
                                        ThietBiId = tb.ThietBiId,
                                        SoHieu = tb.SoHieu,
                                        Ten = tb.Ten,
                                        KhoPhong = tb.KhoPhong,
                                        MonHoc = mh.Ten,
                                        SoLuong = tb.SoLuong,
                                        SoLuongMat = tb.SoLuongMat,
                                        SoLuongHong = tb.SoLuongHong,
                                        DonViTinhId = tb.DonViTinhId,
                                        TrangThaiId = tb.TrangThaiId,
                                        SoLuongCon = tb.SoLuongCon,
                                        DonGia = tb.DonGia,
                                        ThanhTien = tb.ThanhTien,
                                        NguonKP = tb.NguonKP
                                    }
                                )
                                 .Join(unitOfWork.GetRepository<DS_DonViTinh>().GetAll(),
                                    tb => tb.DonViTinhId,
                                    dvt => dvt.DonViTinhId,
                                    (tb, dvt) => new
                                    {
                                        ThietBiId = tb.ThietBiId,
                                        SoHieu = tb.SoHieu,
                                        Ten = tb.Ten,
                                        KhoPhong = tb.KhoPhong,
                                        MonHoc = tb.MonHoc,
                                        SoLuong = tb.SoLuong.ToString(),
                                        SoLuongMat = tb.SoLuongMat.ToString(),
                                        SoLuongHong = tb.SoLuongHong.ToString(),
                                        DonViTinh = dvt.Ten,
                                        TrangThaiId = tb.TrangThaiId,
                                        SoLuongCon = tb.SoLuongCon,
                                        DonGia = tb.DonGia,
                                        ThanhTien = tb.ThanhTien,
                                        NguonKP = tb.NguonKP

                                    }
                                )
                                .Join(unitOfWork.GetRepository<DM_NguonKinhPhi>().GetAll(),
                                tb => tb.NguonKP,
                                tmp => tmp.NguonKinhPhiId,
                                (tb, tmp) => new
                                {
                                    ThietBiId = tb.ThietBiId,
                                    SoHieu = tb.SoHieu,
                                    Ten = tb.Ten,
                                    KhoPhong = tb.KhoPhong,
                                    MonHoc = tb.MonHoc,
                                    SoLuong = tb.SoLuong,
                                    SoLuongCon = tb.SoLuongCon.ToString(),
                                    SoLuongMat = tb.SoLuongMat,
                                    SoLuongHong = tb.SoLuongHong,
                                    DonViTinh = tb.DonViTinh,
                                    TrangThaiId = tb.TrangThaiId,
                                    DonGia = tb.DonGia,
                                    ThanhTien = tb.ThanhTien,
                                    NguonKinhPhi = tmp.Ten
                                }
                                )
                                .AsEnumerable()
                                .Join(GlobalVariable.GetDS().TrangThaiThietBi,
                                    tb => tb.TrangThaiId,
                                    tt => tt.Id,
                                    (tb, tt) => new ThietBiGridDisplayModel
                                    {
                                        ThietBiId = tb.ThietBiId,
                                        SoHieu = tb.SoHieu,
                                        Ten = tb.Ten,
                                        KhoPhong = tb.KhoPhong,
                                        MonHoc = tb.MonHoc,
                                        SoLuong = tb.SoLuong,
                                        SoLuongCon = tb.SoLuongCon.ToString(),
                                        SoLuongMat = tb.SoLuongMat,
                                        SoLuongHong = tb.SoLuongHong,
                                        DonViTinh = tb.DonViTinh,
                                        TrangThai = tt.Name,
                                        DonGia = tb.DonGia.ToString(),
                                        ThanhTien = tb.ThanhTien.ToString(),
                                        NguonKinhPhi = tb.NguonKinhPhi
                                    }
                                )
                                .OrderBy(p => p.MonHoc)
                                .Skip(pageSize * (page - 1))
                                .Take(pageSize)
                                .ToList();
                    //



                    return new Paging<List<ThietBiGridDisplayModel>>
                    {
                        CurrentPage = page,
                        Size = TotalRecord % pageSize == 0 ? TotalRecord / pageSize : TotalRecord / pageSize + 1,
                        TotalRecord = TotalRecord,
                        data = data,
                        NextPage = (pageSize * page) < TotalRecord ? true : false,
                        PreviousPage = page > 1 ? true : false
                    };
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }
        public ThietBiModel GetById(string Id)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var data = unitOfWork.GetRepository<TB_ThongTinThietBi>().GetById(Id);
                    return MyConvert.ConvertSameData<ThietBiModel>(data);
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        private ThietBiModel ConvertData(TB_ThongTinThietBi source)
        {
            ThietBiModel result = new ThietBiModel
            {
                ThietBiId = source.ThietBiId,
                Ten = source.Ten,
                SoHieu = source.SoHieu,
                SoLuong = source.SoLuong,
                SoLuongHong = source.SoLuongHong,
                SoLuongMat = source.SoLuongMat,
                HanSD = source.HanSD,
                MucDichSDId = source.MucDichSDId,
                NamDuaVaoSD = source.NamDuaVaoSD,
                NgaySanXuat = source.NgaySanXuat,
                NuocSanXuat = source.NuocSanXuat,
                DonGia = source.DonGia,
                DonViTinhId = source.DonViTinhId,
                GhiChu = source.GhiChu,
                IsThietBiTuLam = source.IsThietBiTuLam,
                NamTheoDoi = source.NamTheoDoi,
                NguonKinhPhiId = source.NguonKinhPhiId,
                PhongHocId = source.PhongHocId,
                QuyCachSD = source.QuyCachSD,
                ThanhTien = source.ThanhTien
            };
            return result;
        }
        public string GenerateCode(string ThietBiId)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    string newCode = "";
                    var last = unitOfWork.GetRepository<TB_ThongTinThietBi>().GetAll().Where(p => p.ThietBiId.Equals(ThietBiId)).OrderByDescending(p => p.SoHieu).FirstOrDefault();
                    if (last != null)
                    {
                        var lastCode = last.SoHieu;
                        var numberPart = lastCode.Substring(lastCode.LastIndexOf('.') + 1);
                        var prefixPart = ThietBiId;
                        var number = Convert.ToInt32(numberPart.TrimStart('0'));
                        var suffix = number + 1;

                        if (suffix < 10)
                        {
                            newCode = prefixPart + ".0" + suffix.ToString();
                        }
                        else
                        {
                            newCode = prefixPart + "." + suffix.ToString();
                        }

                    }
                    else
                    {
                        newCode = ThietBiId + ".01";
                    }
                    return newCode;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public int Create(ThietBiModel model)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    TB_ThongTinThietBi entity = MyConvert.ConvertSameData<TB_ThongTinThietBi>(model);
                    unitOfWork.GetRepository<TB_ThongTinThietBi>().Add(entity);
                    if (unitOfWork.Save() >= 1)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
        public int Update(ThietBiModel model)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var data = unitOfWork.GetRepository<TB_ThongTinThietBi>().GetById(model.SoHieu);
                    //data.Ten = model.Ten;
                    //data.SoLuongMat = model.SoLuongMat;
                    //data.SoLuongHong = model.SoLuongHong;
                    //data.QuyCachSD = model.QuyCachSD;
                    //data.SoLuong = model.SoLuong;
                    //data.ThanhTien = model.ThanhTien;
                    //data.DonGia = model.DonGia;
                    //data.IsThietBiTuLam = model.IsThietBiTuLam;
                    //data.DonViTinhId = model.DonViTinhId;
                    //data.
                    if (data != null)
                    {
                        MyConvert.TransferValues(data, model);
                        unitOfWork.GetRepository<TB_ThongTinThietBi>().Update(data);
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
                    var data = unitOfWork.GetRepository<TB_ThongTinThietBi>().GetById(Id);
                    data.TrangThai = -1;
                    unitOfWork.GetRepository<TB_ThongTinThietBi>().Update(data);
                    if (unitOfWork.Save() >= 1)
                    {
                        return 1;
                    }
                    return 0;

                }
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
        #region Mượn trả
        public int UpdateLendCount(string SoHieu, int SoLuongMuon, int SoLuongMat, int SoLuongHong)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var data = unitOfWork.GetRepository<TB_ThongTinThietBi>().GetById(SoHieu);
                    if (data != null)
                    {
                        data.SoLuongMat = SoLuongMat;
                        data.SoLuongMuon = SoLuongMuon;
                        data.SoLuongHong = SoLuongHong;
                        data.SoLuongCon = data.SoLuong - (SoLuongMat + SoLuongMuon + SoLuongHong);
                        unitOfWork.GetRepository<TB_ThongTinThietBi>().Update(data);
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
