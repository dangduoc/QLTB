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
    public class DbDanhSachHandler
    {
        public List<PhongBoMonModel> GetPhongBM()
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var data = unitOfWork.GetRepository<DM_PhongHocBoMon>()
                        .GetAll().Select(p => new PhongBoMonModel { PhongHocId = p.PhongHocId, Ten = p.Ten }).ToList();
                    return data;

                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public List<NguonKinhPhiModel> GetNguonKP()
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var data = unitOfWork.GetRepository<DM_NguonKinhPhi>()
                        .GetAll().Select(p => new NguonKinhPhiModel { NguonKinhPhiId = p.NguonKinhPhiId, Ten = p.Ten }).ToList();
                    return data;

                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public List<DSMucDichSDPhong> GetMucDichSDPhong()
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var data = unitOfWork.GetRepository<DS_MucDichSDPHong>()
                        .GetAll().Select(p => new DSMucDichSDPhong { MucDichSDPhongId = p.MucDichSDPhongId, Ten = p.Ten }).ToList();
                    return data;

                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public List<DSDonViTinh> GetDVT()
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var data = unitOfWork.GetRepository<DS_DonViTinh>()
                        .GetAll().Select(p => new DSDonViTinh { DonViTinhId = p.DonViTinhId, Ten = p.Ten }).ToList();
                    return data;

                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public List<DSCapTruong> GetCapTruong()
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var data = unitOfWork.GetRepository<DS_CapTruong>()
                        .GetAll().Select(p => new DSCapTruong { CapTruongId = p.CapTruongId, Ten = p.Ten }).ToList();
                    return data;

                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public List<DSHangTruong> GetHangTruong()
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var data = unitOfWork.GetRepository<DS_HangTruong>()
                        .GetAll().Select(p => new DSHangTruong { HangTruongId = p.HangTruongId, Ten = p.Ten }).ToList();
                    return data;

                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public List<DSHinhThucDaoTao> GetHinhThucDaoTao()
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var data = unitOfWork.GetRepository<DS_HinhThucDaoTao>()
                        .GetAll().Select(p => new DSHinhThucDaoTao { HinhThucDaoTaoId = p.HinhThucDaoTaoId, Ten = p.Ten }).ToList();
                    return data;

                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public List<DSLoaiHinhTruong> GetLoaiHinhTruong()
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var data = unitOfWork.GetRepository<DS_LoaiHinhTruong>()
                        .GetAll().Select(p => new DSLoaiHinhTruong { LoaiHinhTruongId = p.LoaiHinhTruongId, Ten = p.Ten }).ToList();
                    return data;

                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public List<DSLoaiTruongChuyenBiet> GetLoaiTruongChuyenBiet()
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var data = unitOfWork.GetRepository<DS_LoaiTruongChuyenBiet>()
                        .GetAll().Select(p => new DSLoaiTruongChuyenBiet { LoaiTruongChuyenBietId = p.LoaiTruongChuyenBietId, Ten = p.Ten }).ToList();
                    return data;

                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public List<DSKhoiTruong> GetKhoiTruong()
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var data = unitOfWork.GetRepository<DS_KhoiTruong>()
                        .GetAll().Select(p => new DSKhoiTruong { KhoiTruongId = p.KhoiTruongId, Ten = p.Ten }).ToList();
                    return data;

                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public List<DSVungMien> GetVungMien()
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var data = unitOfWork.GetRepository<DS_VungMien>()
                        .GetAll().Select(p => new DSVungMien { VungMienId = p.VungMienId, Ten = p.Ten }).ToList();
                    return data;

                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public List<DSTinhThanh> GetTinhThanh()
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var data = unitOfWork.GetRepository<DS_TinhThanh>()
                        .GetAll().Select(p => new DSTinhThanh { TinhThanhId = p.TinhThanhId, Ten = p.Ten }).ToList();
                    return data;

                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public List<DSQuanHuyen> GetQuanHuyen()
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var data = unitOfWork.GetRepository<DS_QuanHuyen>()
                        .GetAll().Select(p => new DSQuanHuyen { QuanHuyenId = p.QuanHuyenId, Ten = p.Ten }).ToList();
                    return data;

                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public List<DSQuanHuyen> GetQuanHuyen(int TinhThanhId)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var data = unitOfWork.GetRepository<DS_QuanHuyen>()
                        .GetAll().Where(p=>p.TinhThanhId==TinhThanhId).Select(p => new DSQuanHuyen { QuanHuyenId = p.QuanHuyenId, Ten = p.Ten }).ToList();
                    return data;

                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public List<DSPhuongXa> GetPhuongXa()
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var data = unitOfWork.GetRepository<DS_PhuongXa>()
                        .GetAll().Select(p => new DSPhuongXa { QuanHuyenId = p.QuanHuyenId, Ten = p.Ten }).ToList();
                    return data;

                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public List<DSPhuongXa> GetPhuongXa(int QuanHuyenId)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var data = unitOfWork.GetRepository<DS_PhuongXa>()
                        .GetAll().Where(p=>p.QuanHuyenId==QuanHuyenId).Select(p => new DSPhuongXa { PhuongXaId = p.PhuongXaId, Ten = p.Ten }).ToList();
                    return data;

                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public List<BaseGiaoVienModel> GetGiaoVien()
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var data = unitOfWork.GetRepository<DM_GiaoVien>().GetAll()
                        .Select(p => new BaseGiaoVienModel {
                            GiaoVienId=p.GiaoVienId,
                            TenDayDu=p.TenDayDu
                        }).ToList();
                    return data;

                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public List<KhoiLopModel> GetKhoiLop()
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var data = unitOfWork.GetRepository<DM_KhoiLop>().GetAll()
                        .Select(p => new KhoiLopModel
                        {
                            KhoiLopId=p.KhoiLopId,
                            Ten=p.Ten
                        }).ToList();
                    return data;

                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public List<LopHocModel> GetLopHoc()
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var data = unitOfWork.GetRepository<DM_LopHoc>().GetAll()
                        .Select(p => new LopHocModel
                        {
                            LopHocId = p.LopHocId,
                            Ten=p.Ten,
                            KhoiLopId=p.KhoiLopId
                        }).ToList();
                    return data;

                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public List<DSMucDichSDThietBi> GetMucDichSDThietBi()
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var data = unitOfWork.GetRepository<DS_MucDichSDThietBi>().GetAll()
                        .Select(p => new DSMucDichSDThietBi
                        {
                            MucDichSDTBId=p.MucDichSDTBId,
                            Ten=p.Ten
                        }).ToList();
                    return data;

                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public List<MonHocModel> GetMonHoc()
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var data = unitOfWork.GetRepository<DM_MonHoc>().GetAll()
                        .Select(p => new MonHocModel
                        {
                            MonHocId=p.MonHocId,
                            Ten=p.Ten
                        }).ToList();
                    return data;

                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public List<DSThoiGianTrongNganh> GetTGTrongNgay()
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var data = unitOfWork.GetRepository<DS_ThoiGianTrongNgay>().GetAll()
                        .Select(p => new DSThoiGianTrongNganh
                        {
                            BuoiId=p.BuoiId,
                            Ten=p.Ten
                        }).ToList();
                    return data;

                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
