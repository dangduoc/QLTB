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
    }
}
