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
    public class DbDanhSachHandler
    {
        public DanhSachModel DanhSachCoDinh = new DanhSachModel();
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
                    var captuong = GlobalVariable.GetHeThong().DonVi.CapTruongId;
                    var data = unitOfWork.GetRepository<DM_KhoiLop>().GetAll().Where(p=>p.CapTruongId== captuong)
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
        public List<LopHocModel> GetLopHoc(int KhoiLopId)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var data = unitOfWork.GetRepository<DM_LopHoc>().GetAll().Where(p=>p.KhoiLopId==KhoiLopId)
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
        public List<DSBaiGiang> GetBaiGiang(int MonHocId)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var data = unitOfWork.GetRepository<DS_BaiGiang>().GetAll().Where(p=>p.MonHocId==MonHocId)
                        .Select(p => new DSBaiGiang
                        {
                            BaiGiangId = p.BaiGiangId,
                            Ten = p.Ten
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
