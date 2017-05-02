using QLTB.DAL;
using QLTB.DAL.Data;
using QLTB.Model;
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
                    var data = unitOfWork.GetRepository<TB_ThongTinThietBi>().GetAll()
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
                    return ConvertData(data);
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
                NuocSX = source.NuocSanXuat,
                DonGia = source.DonGia,
                DonViTinhId = source.DonViTinhId,
                GhiChu = source.GhiChu,
                IsThietBiTuLam = source.IsThietBiTuLam,
                NamTheoDoi = source.NamTheoDoi,
                NguonKinhPhiId = source.NguonKinhPhiId,
                PhongHocId = source.PhongHocId,
                QuyCach = source.QuyCachSD,
                ThanhTien = source.ThanhTien
            };
            return result;
        }

    }
}
