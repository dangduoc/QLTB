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
    public class DbPhongBMHandler
    {
        public List<PhongBoMonGridDisplayModel> GetAll()
        {
            using (var unitOfWork = new UnitOfWork())
            {
                try
                {
                    var data = unitOfWork.GetRepository<DM_PhongHocBoMon>().GetAll()
                                .Join(unitOfWork.GetRepository<DS_LoaiPhongTN>().GetAll(),
                                    ph => ph.LoaiPhongTNId,
                                    lp => lp.LoaiPhongTNId,
                                    (ph, lp) => new
                                    {
                                        PhongHocId = ph.PhongHocId,
                                        Ten = ph.Ten,
                                        LoaiPhongTN = lp.Ten,
                                        MonHocId = ph.MonHocId,
                                        DienTich = ph.DienTich,
                                        SoCanBo = ph.SoCanBo,
                                        NamDuaVaoSD = ph.NamDuaVaoSD,
                                        IsPhongChucNang = ph.IsPhongChucNang,
                                        XepLoaiId = ph.XepLoaiId
                                    }
                                )
                                .Join(unitOfWork.GetRepository<DM_MonHoc>().GetAll(),
                                    ph => ph.MonHocId,
                                    mh => mh.MonHocId,
                                    (ph, mh) => new
                                    {
                                        PhongHocId = ph.PhongHocId,
                                        Ten = ph.Ten,
                                        LoaiPhongTN = ph.LoaiPhongTN,
                                        MonHoc = mh.Ten,
                                        DienTich = ph.DienTich,
                                        SoCanBo = ph.SoCanBo,
                                        NamDuaVaoSD = ph.NamDuaVaoSD,
                                        IsPhongChucNang = ph.IsPhongChucNang,
                                        XepLoaiId = ph.XepLoaiId
                                    }
                                )
                                 .Join(unitOfWork.GetRepository<DS_XepLoaiPhongHocBM>().GetAll(),
                                    ph => ph.XepLoaiId,
                                    xl => xl.XepLoaiPhongBMId,
                                    (ph, xl) => new
                                    {
                                        PhongHocId = ph.PhongHocId.ToString(),
                                        Ten = ph.Ten,
                                        LoaiPhongTN = ph.LoaiPhongTN,
                                        MonHoc = ph.MonHoc,
                                        DienTich = ph.DienTich.ToString(),
                                        SoCanBo = ph.SoCanBo.ToString(),
                                        NamDuaVaoSD = ph.NamDuaVaoSD.ToString(),
                                        IsPhongChucNang = ph.IsPhongChucNang,
                                        XepLoai = xl.Ten
                                    }
                                )
                                .OrderBy(ph => ph.PhongHocId).ToList()
                                .Select(ph => new PhongBoMonGridDisplayModel
                                {
                                    PhongHocId = ph.PhongHocId.ToString(),
                                    Ten = ph.Ten,
                                    LoaiPhongTN = ph.LoaiPhongTN,
                                    MonHoc = ph.MonHoc,
                                    DienTich = ph.DienTich.ToString(),
                                    SoCanBo = ph.SoCanBo.ToString(),
                                    NamDuaVaoSD = ph.NamDuaVaoSD.ToString(),
                                    IsPhongChucNang = MyConvert.BoolToString((bool)ph.IsPhongChucNang, "Có", "Không"),
                                    XepLoai = ph.XepLoai
                                }).ToList();
                    return data;
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }
        public PhongBoMonModel GetById(int Id)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    var data = unitOfWork.GetRepository<DM_PhongHocBoMon>().GetById(Id);
                    return MyConvert.ConvertSameData<PhongBoMonModel>(data);
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        
    }
}
