using QLTB.DAL;
using QLTB.DAL.Data;
using QLTB.Report.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTB.Handler
{
    public class DbThongKeHandler
    {
        /// <summary>
        /// Thống kê phiếu ghi tăng thiết bị theo năm học
        /// </summary>
        /// <param name="NamHocId">Mã năm học</param>
        /// <returns></returns>
        public List<GhiTangReportModel> DanhSachGhiTang(int NamHocId)
        {
            try
            {
                using (var unitOfWork= new UnitOfWork())
                {
                    unitOfWork.GetRepository<QH_PhieuGhiTang_ThietBi>().GetAll()
                    .Join(unitOfWork.GetRepository<TB_PhieuGhiTang>().GetAll(),
                    phieu=>phieu.PhieuGhiTangId,
                    qh=>qh.PhieuGhiTangId,
                    (phieu, qh)=> new 
                    {

                    })

                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
