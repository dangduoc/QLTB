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
    public class DbPhieuTraTBHandler
    {
        /// <summary>
        /// Khai báo phiếu trả các thiết bị đã mượn
        /// </summary>
        /// <param name="model">PhieuTraTBModel</param>
        /// <returns>
        /// -1-Xảy ra lỗi
        /// 0-không thành công
        /// 1-Thành công
        /// 2-Update thiết bị bị lỗi
        /// </returns>
        public int Create(PhieuTraTBModel model)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    //Đổi trạng thái phiếu mượn sang "đã trả"
                    var entity = unitOfWork.GetRepository<TB_PhieuMuonTB>().GetById(model.PhieuMuonId);
                    //
                    entity.TrangThaiId = 2;
                    unitOfWork.GetRepository<TB_PhieuMuonTB>().Update(entity);
                    //Update thông tin các thiết bị sau khi trả
                    if (unitOfWork.Save() >= 1)
                    {
                        
                        foreach (var item in model.ThietBis)
                        {
                            //Tìm thiết bị
                            var tb = unitOfWork.GetRepository<QH_PhieuMuonTB_ThietBi>().GetAll().Where(p => p.PhieuMuonTBId.Equals(model.PhieuMuonId) && p.SoHieuTB.Equals(item.SoHieu)).FirstOrDefault();
                            //
                            if (tb != null)
                            {
                                tb.TieuHao = item.TieuHao;
                                tb.TinhTrangKhiTra = item.TinhTrangKhiTra;
                                tb.IsDaTra = true;
                                //
                                unitOfWork.GetRepository<QH_PhieuMuonTB_ThietBi>().Update(tb);
                                //Update số lượng mượn,còn,mất
                                var thietbi = unitOfWork.GetRepository<TB_ThongTinThietBi>().GetById(item.SoHieu);
                                if (thietbi != null)
                                {
                                    thietbi.SoLuongMuon -= tb.SoLuong;
                                    thietbi.SoLuongCon += tb.SoLuong;
                                    unitOfWork.GetRepository<TB_ThongTinThietBi>().Update(thietbi);
                                }
                            }
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
    }
}
