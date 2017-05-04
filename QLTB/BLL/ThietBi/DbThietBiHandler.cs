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
    public class DbThietBiHandler
    {
        public List<ThietBiGridDisplayModel> GetAll()
        {
            using (var unitOfWork = new UnitOfWork())
            {
                try
                {
                    var data = unitOfWork.GetRepository<TB_ThongTinThietBi>().GetAll().Where(p=>p.TrangThai==1)
                                .Join(unitOfWork.GetRepository<DM_ThietBiToiThieu>().GetAll(),
                                    tttb => tttb.ThietBiId,
                                    tbtt => tbtt.ThietBiId,
                                    (tttb, tbtt) => new
                                    {
                                        ThietBiId = tttb.ThietBiId,
                                        SoHieu = tttb.SoHieu,
                                        Ten = tttb.Ten,
                                        PhongHocId = tttb.PhongHocId,
                                        MonHoc = tbtt.MonHocId,
                                        SoLuong = tttb.SoLuong.ToString(),
                                        SoLuongMat = tttb.SoLuongMat.ToString(),
                                        SoLuongHong = tttb.SoLuongHong.ToString()
                                    }
                                )
                                .Join(unitOfWork.GetRepository<DM_PhongHocBoMon>().GetAll(),
                                    tb => tb.PhongHocId,
                                    ph => ph.PhongHocId,
                                    (tb, ph) => new { ThietBi = tb, PhongHoc = ph }
                                )
                                .Join(unitOfWork.GetRepository<DM_MonHoc>().GetAll(),
                                    tb => tb.ThietBi.MonHoc,
                                    mh => mh.MonHocId,
                                    (tmp1, mh) => new ThietBiGridDisplayModel
                                    {
                                        ThietBiId = tmp1.ThietBi.ThietBiId,
                                        SoHieu = tmp1.ThietBi.SoHieu,
                                        Ten = tmp1.ThietBi.Ten,
                                        KhoPhong = tmp1.PhongHoc.Ten,
                                        MonHoc = mh.Ten,
                                        SoLuong = tmp1.ThietBi.SoLuong.ToString(),
                                        SoLuongMat = tmp1.ThietBi.SoLuongMat.ToString(),
                                        SoLuongHong = tmp1.ThietBi.SoLuongHong.ToString()
                                    }
                                )
                                .ToList();
                    return data;
                }
                catch(Exception ex)
                {
                    return null;
                }
            }
        }
        public ThietBiModel GetById(string Id)
        {
            try
            {
                using (var unitOfWork= new UnitOfWork())
                {
                    var data=unitOfWork.GetRepository<TB_ThongTinThietBi>().GetById(Id);
                    return MyConvert.ConvertSameData<ThietBiModel>(data);
                }
            }
            catch(Exception ex)
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
                        var numberPart=lastCode.Substring(lastCode.LastIndexOf('.')+1);
                        var prefixPart = ThietBiId;
                        var number=Convert.ToInt32(numberPart.TrimStart('0'));
                        var suffix = number + 1;
                        
                        if (suffix < 10)
                        {
                            newCode = prefixPart + ".0" + suffix.ToString();
                        }
                        else
                        {
                            newCode = prefixPart + "."+suffix.ToString();
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
                    data.TrangThai = 0;
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
    }
}
