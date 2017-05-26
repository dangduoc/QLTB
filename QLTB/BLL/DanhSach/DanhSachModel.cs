using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTB.Model
{
    public class DanhSachModel
    {
        private List<TrangThaiTB> trangthaitb = new List<TrangThaiTB>();
        private List<CapTruong> captruong = new List<CapTruong>();
        private List<KhoiTruong> khoitruong = new List<KhoiTruong>();
        private List<GioiTinh> gioitinh = new List<GioiTinh>();
        private List<HangTruong> hangtruong = new List<HangTruong>();
        private List<HinhThucDaoTao> hinhthucdaotao = new List<HinhThucDaoTao>();
        private List<DanhGiaMonHoc> danhgiamonhoc = new List<DanhGiaMonHoc>();
        private List<LoaiHinhTruong> loaihinhtruong = new List<LoaiHinhTruong>();
        private List<LoaiHopDong> loaihopdong = new List<LoaiHopDong>();
        private List<LoaiMonHoc> loaimonhoc = new List<LoaiMonHoc>();
        private List<LoaiPhongTN> loaiphongtn = new List<LoaiPhongTN>();
        private List<LoaiThietBi> loaithietbi = new List<LoaiThietBi>();
        private List<LoaiTruongChuyenBiet> loaitruongchuyenbiet = new List<LoaiTruongChuyenBiet>();
        private List<MucDichSDPhong> mucdichsdphong = new List<MucDichSDPhong>();
        private List<MucDichSDThietBi> mucdichsdthietbi = new List<MucDichSDThietBi>();
        private List<TrangThaiPhieuMuon> trangthaiphieumuon = new List<TrangThaiPhieuMuon>();
        private List<ThoiGianTrongNgay> thoigiantrongngay = new List<ThoiGianTrongNgay>();
        private List<TrinhDoChuan> trinhdochuan = new List<TrinhDoChuan>();
        private List<TrinhDoChuyenMon> trinhdochuyenmon = new List<TrinhDoChuyenMon>();
        private List<XepLoaiPhongBM> xeploaiphongbm = new List<XepLoaiPhongBM>();
        private List<ViTriGiaoVien> vitrigiaovien = new List<ViTriGiaoVien>();
        private List<VungMien> vungmien = new List<VungMien>();
        private List<ChucVuGiaoVien> chucvugiaovien = new List<ChucVuGiaoVien>();
        private List<PhuTrachCanBoTB> phutrachcanbotb = new List<PhuTrachCanBoTB>();
        private List<DauMucThietBi> daumucthietbi = new List<DauMucThietBi>();
        public DanhSachModel()
        {
            #region Trạng thái thiết bị
            trangthaitb.Add(new TrangThaiTB
            {
                Id = -1,
                Name = "Đã xóa",

            });
            trangthaitb.Add(new TrangThaiTB
            {
                Id = 0,
                Name = "Chưa ghi tăng",

            });
            trangthaitb.Add(new TrangThaiTB
            {
                Id = 1,
                Name = "Đã sử dụng",

            });
            #endregion
            #region Khối trường
            khoitruong.Add(new KhoiTruong
            {
                KhoiTruongId = 1,
                Ten = "Khối các trường tiểu học"
            });
            khoitruong.Add(new KhoiTruong
            {
                KhoiTruongId = 2,
                Ten = "Khối các trường trung học cơ sở"
            });
            khoitruong.Add(new KhoiTruong
            {
                KhoiTruongId = 3,
                Ten = "Khối các trường trung học phổ thông"
            });
            #endregion
            #region Cấp trường
            captruong.Add(new CapTruong
            {
                KhoiTruongId = 1,
                CapTruongId = 1,
                Ten = "Tiểu học"
            });
            captruong.Add(new CapTruong
            {
                KhoiTruongId = 2,
                CapTruongId = 2,
                Ten = "Trung học cơ sở"
            });
            captruong.Add(new CapTruong
            {
                KhoiTruongId = 3,
                CapTruongId = 3,
                Ten = "Trung học phổ thông"
            });
            #endregion
            #region Giới tính
            gioitinh.Add(new GioiTinh
            {
                GioiTinhId = 1,
                Ten = "Nam"
            });
            gioitinh.Add(new GioiTinh
            {
                GioiTinhId = 2,
                Ten = "Nữ"
            });
            #endregion
            #region Hạng trường
            hangtruong.Add(new HangTruong
            {
                Id=1,
                Ten="Hạng I"
            });
            hangtruong.Add(new HangTruong
            {
                Id = 2,
                Ten = "Hạng II"
            });
            hangtruong.Add(new HangTruong
            {
                Id = 3,
                Ten = "Hạng III"
            });
            #endregion
            #region Hình thức đào tạo
            hinhthucdaotao.Add(new HinhThucDaoTao
            {
                Id=1,
                Ten="Hệ phổ thông"
            });
            #endregion
            #region Đánh giá môn học
            danhgiamonhoc.Add(new DanhGiaMonHoc
            {
                Id=1,
                Ten="Tính điểm"
            });
            danhgiamonhoc.Add(new DanhGiaMonHoc
            {
                Id = 1,
                Ten = "Đạt hay không đạt"
            });
            #endregion
            #region Loại hình trường
            loaihinhtruong.Add(new LoaiHinhTruong
            {
                Id=1,
                Ten="Công lập"
            });
            loaihinhtruong.Add(new LoaiHinhTruong
            {
                Id = 2,
                Ten = "Dân lập"
            });
            loaihinhtruong.Add(new LoaiHinhTruong
            {
                Id = 3,
                Ten = "Bán công"
            });
            #endregion
            #region Loại hợp đồng
            loaihopdong.Add(new LoaiHopDong
            {
                Id = 1,
                Ten = "Hợp đồng không thời hạn"
            });
            loaihopdong.Add(new LoaiHopDong
            {
                Id = 2,
                Ten = "Hợp đồng có thời hạn"
            });

            #endregion
            #region Loại môn học
            loaimonhoc.Add(new LoaiMonHoc
            {
                Id = 1,
                Ten = "Bình thường"
            });
            #endregion
            #region Loại phòng tn
            loaiphongtn.Add(new LoaiPhongTN
            {
                Id = 1,
                Ten = "Phòng thí nghiệm"
            });
            #endregion
            #region Loại thiết bị
            loaithietbi.Add(new LoaiThietBi
            {
                Id = 1,
                Ten = "Tranh ảnh"
            });
            loaithietbi.Add(new LoaiThietBi
            {
                Id = 2,
                Ten = "Dụng cụ"
            });
            loaithietbi.Add(new LoaiThietBi
            {
                Id = 3,
                Ten = "Băng đĩa CD/ DVD"
            });
            #endregion
            #region Loại trường chuyên biệt
            loaitruongchuyenbiet.Add(new LoaiTruongChuyenBiet
            {
                Id = 1,
                Ten = "Trường bình thường"
            });

            #endregion
            #region Mục đích sử dụng phòng
            mucdichsdphong.Add(new MucDichSDPhong
            {
                Id = 1,
                Ten = "Giảng dạy"
            });

            #endregion
            #region Mục đích sử thiết bị
            mucdichsdthietbi.Add(new MucDichSDThietBi
            {
                Id = 1,
                Ten = "Giảng dạy"
            });

            #endregion
            #region Trạng thái phiếu mượn
            trangthaiphieumuon.Add(new TrangThaiPhieuMuon
            {
                Id = 0,
                Ten = "Chưa mượn"
            });
            trangthaiphieumuon.Add(new TrangThaiPhieuMuon
            {
                Id = 1,
                Ten = "Đang sử dụng"
            });
            #endregion
            #region Thời gian trong ngày
            thoigiantrongngay.Add(new ThoiGianTrongNgay
            {
                Id = 1,
                Ten = "Sáng"
            });
            thoigiantrongngay.Add(new ThoiGianTrongNgay
            {
                Id = 2,
                Ten = "Chiều"
            });
            #endregion
            #region Trình độ chuẩn
            trinhdochuan.Add(new TrinhDoChuan
            {
                Id = 1,
                Ten = "Trình độ đạt chuẩn"
            });
           
            #endregion
            #region Trình độ chuyên môn
            trinhdochuyenmon.Add(new TrinhDoChuyenMon
            {
                Id = 1,
                Ten = "Tiến sĩ"
            });
            trinhdochuyenmon.Add(new TrinhDoChuyenMon
            {
                Id = 2,
                Ten = "Thạc sĩ"
            });
            trinhdochuyenmon.Add(new TrinhDoChuyenMon
            {
                Id = 3,
                Ten = "Đại học sư phạm(4 năm)"
            });
            trinhdochuyenmon.Add(new TrinhDoChuyenMon
            {
                Id = 4,
                Ten = "Cao đẳng"
            });
            #endregion
            #region Xếp loại phòng bộ môn
            xeploaiphongbm.Add(new XepLoaiPhongBM
            {
                Id = 1,
                Ten = "Đạt chuẩn"
            });

            #endregion
            #region vị trí giáo viên
            vitrigiaovien.Add(new ViTriGiaoVien
            {
                CapHocId=1,
                Id=1,
                Ten="Giáo viên dạy lớp một"
            });
            vitrigiaovien.Add(new ViTriGiaoVien
            {
                CapHocId = 1,
                Id = 2,
                Ten = "Giáo viên dạy lớp hai"
            });
            vitrigiaovien.Add(new ViTriGiaoVien
            {
                CapHocId = 1,
                Id = 3,
                Ten = "Giáo viên dạy lớp ba"
            });
            vitrigiaovien.Add(new ViTriGiaoVien
            {
                CapHocId = 1,
                Id = 4,
                Ten = "Giáo viên dạy lớp bốn"
            });
            vitrigiaovien.Add(new ViTriGiaoVien
            {
                CapHocId = 1,
                Id = 5,
                Ten = "Giáo viên dạy lớp năm"
            });
            vitrigiaovien.Add(new ViTriGiaoVien
            {
                CapHocId = 2,
                Id = 1,
                Ten = "Giáo viên dạy lớp sáu"
            });
            vitrigiaovien.Add(new ViTriGiaoVien
            {
                CapHocId = 2,
                Id = 2,
                Ten = "Giáo viên dạy lớp bảy"
            });
            vitrigiaovien.Add(new ViTriGiaoVien
            {
                CapHocId = 2,
                Id = 3,
                Ten = "Giáo viên dạy lớp tám"
            });
            vitrigiaovien.Add(new ViTriGiaoVien
            {
                CapHocId = 2,
                Id = 4,
                Ten = "Giáo viên dạy lớp chín"
            });
            vitrigiaovien.Add(new ViTriGiaoVien
            {
                CapHocId = 3,
                Id = 1,
                Ten = "Giáo viên dạy lớp mười"
            });
            vitrigiaovien.Add(new ViTriGiaoVien
            {
                CapHocId = 3,
                Id = 2,
                Ten = "Giáo viên dạy lớp mười một"
            });
            vitrigiaovien.Add(new ViTriGiaoVien
            {
                CapHocId = 3,
                Id = 3,
                Ten = "Giáo viên dạy lớp mười hai"
            });
            #endregion
            #region Vùng miền
            vungmien.Add(new VungMien
            {
                Id=1,
                Ten="Đồng bằng"
            });
            vungmien.Add(new VungMien
            {
                Id = 2,
                Ten = "Miền núi"
            });
            #endregion
            #region Chuc vụ giáo viên
            chucvugiaovien.Add(new Model.ChucVuGiaoVien
            {
                Id=1,
                Ten="Giáo viên chủ nhiệm"
            });
            chucvugiaovien.Add(new Model.ChucVuGiaoVien
            {
                Id = 2,
                Ten = "Giáo viên bộ môn"
            });
            #endregion
            #region Phụ trách cán bộ thiết bị
            phutrachcanbotb.Add(new PhuTrachCanBoTB
            {
                Id=1,
                Ten="Chuyên trách"
            });
            #endregion
            #region Đầu mục thiết bị
            daumucthietbi.Add(new DauMucThietBi
            {
                Id=1,
                Ten="Máy in"
            });
            #endregion
        }
        public IEnumerable<TrangThaiTB> TrangThaiThietBi {
            get {return trangthaitb; } set {trangthaitb=value.ToList().ToList(); }
        }
        public IEnumerable<CapTruong> CapTruong
        {
            get { return captruong; }
            set { captruong = value.ToList(); }
        }
        public IEnumerable<KhoiTruong> KhoiTruong
        {
            get { return khoitruong; }
            set { khoitruong = value.ToList(); }
        }
        public IEnumerable<GioiTinh> GioiTinh
        {
            get { return gioitinh; }
            set { gioitinh = value.ToList(); }
        }
        public IEnumerable<HangTruong> HangTruong
        {
            get { return hangtruong; }
            set { hangtruong = value.ToList(); }
        }
        public IEnumerable<HinhThucDaoTao> HinhThucDaoTao
        {
            get { return hinhthucdaotao; }
            set { hinhthucdaotao = value.ToList(); }
        }
        public IEnumerable<DanhGiaMonHoc> DanhGiaMonHoc
        {
            get { return danhgiamonhoc; }
            set { danhgiamonhoc = value.ToList(); }
        }
        public IEnumerable<LoaiHinhTruong> LoaiHinhTruong
        {
            get { return loaihinhtruong; }
            set { loaihinhtruong = value.ToList(); }
        }
        public IEnumerable<LoaiHopDong> LoaiHopDong
        {
            get { return loaihopdong; }
            set { loaihopdong = value.ToList(); }
        }
        public IEnumerable<LoaiMonHoc> LoaiMonHoc
        {
            get { return loaimonhoc; }
            set { loaimonhoc = value.ToList(); }
        }
        public IEnumerable<LoaiPhongTN> LoaiPhongTN
        {
            get { return loaiphongtn; }
            set { loaiphongtn = value.ToList(); }
        }
        public IEnumerable<LoaiThietBi> LoaiThietBi
        {
            get { return loaithietbi; }
            set { loaithietbi = value.ToList(); }
        }
        public IEnumerable<LoaiTruongChuyenBiet> LoaiTruongChuyenBiet
        {
            get { return loaitruongchuyenbiet; }
            set { loaitruongchuyenbiet = value.ToList(); }
        }
        public IEnumerable<MucDichSDPhong> MucDichSDPhong
        {
            get { return mucdichsdphong; }
            set { mucdichsdphong = value.ToList(); }
        }
        public IEnumerable<MucDichSDThietBi> MucDichSDThietBi
        {
            get { return mucdichsdthietbi; }
            set { mucdichsdthietbi = value.ToList(); }
        }
        public IEnumerable<TrangThaiPhieuMuon> TrangThaiPhieuMuon
        {
            get { return trangthaiphieumuon; }
            set { trangthaiphieumuon = value.ToList(); }
        }
        public IEnumerable<ThoiGianTrongNgay> ThoiGianTrongNgay
        {
            get { return thoigiantrongngay; }
            set { thoigiantrongngay = value.ToList(); }
        }
        public IEnumerable<TrinhDoChuan> TrinhDoChuan
        {
            get { return trinhdochuan; }
            set { trinhdochuan = value.ToList(); }
        }
        public IEnumerable<TrinhDoChuyenMon> TrinhDoChuyenMon
        {
            get { return trinhdochuyenmon; }
            set { trinhdochuyenmon = value.ToList(); }
        }
        public IEnumerable<XepLoaiPhongBM> XepLoaiPhongBM
        {
            get { return xeploaiphongbm; }
            set { xeploaiphongbm = value.ToList(); }
        }
        public IEnumerable<ViTriGiaoVien> ViTriGiaoVien
        {
            get { return vitrigiaovien; }
            set { vitrigiaovien = value.ToList(); }
        }
        public IEnumerable<VungMien> VungMien
        {
            get { return vungmien; }
            set { vungmien = value.ToList(); }
        }
        public IEnumerable<ChucVuGiaoVien> ChucVuGiaoVien
        {
            get { return chucvugiaovien; }
            set { chucvugiaovien = value.ToList(); }
        }
        public IEnumerable<PhuTrachCanBoTB> PhuTrachCanBoTB
        {
            get { return phutrachcanbotb; }
            set { phutrachcanbotb = value.ToList(); }
        }
        public IEnumerable<DauMucThietBi> DauMucThietBi
        {
            get { return daumucthietbi; }
            set { daumucthietbi = value.ToList(); }
        }
    }
    public class TrangThaiTB{
       
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class CapTruong
    {
        public int KhoiTruongId { get; set; }
        public int CapTruongId { get; set; }
        public string Ten { get; set; }
    }
    public class KhoiTruong
    {
        public int KhoiTruongId { get; set; }
        public string Ten { get; set; }
    }
    public class GioiTinh
    {
        public int GioiTinhId { get; set; }
        public string Ten { get; set; }
    }
    public class HangTruong
    {
        public int Id { get; set; }
        public string Ten { get; set; }
    }
    public class HinhThucDaoTao
    {
        public int Id { get; set; }
        public string Ten { get; set; }
    }
    public class DanhGiaMonHoc
    {
        public int Id { get; set; }
        public string Ten { get; set; }
    }
    public class LoaiHinhTruong
    {
        public int Id { get; set; }
        public string Ten { get; set; }
    }
    public class LoaiHopDong
    {
        public int Id { get; set; }
        public string Ten { get; set; }
    }
    public class LoaiMonHoc
    {
        public int Id { get; set; }
        public string Ten { get; set; }
    }
    public class LoaiPhongTN
    {
        public int Id { get; set; }
        public string Ten { get; set; }
    }
    public class LoaiThietBi
    {
        public int Id { get; set; }
        public string Ten { get; set; }
    }
    public class LoaiTruongChuyenBiet
    {
        public int Id { get; set; }
        public string Ten { get; set; }
    }
    public class MucDichSDPhong
    {
        public int Id { get; set; }
        public string Ten { get; set; }
    }
    public class MucDichSDThietBi
    {
        public int Id { get; set; }
        public string Ten { get; set; }
    }
    public class TrangThaiPhieuMuon
    {
        public int Id { get; set; }
        public string Ten { get; set; }
    }
    public class ThoiGianTrongNgay
    {
        public int Id { get; set; }
        public string Ten { get; set; }
    }
    public class TrinhDoChuan
    {
        public int Id { get; set; }
        public string Ten { get; set; }
    }
    public class TrinhDoChuyenMon
    {
        public int Id { get; set; }
        public string Ten { get; set; }
    }
    public class XepLoaiPhongBM
    {
        public int Id { get; set; }
        public string Ten { get; set; }
    }
    public class ViTriGiaoVien
    {
        public int CapHocId { get; set; }
        public int Id { get; set; }
        public string Ten { get; set; }
    }
    public class ChucVuGiaoVien
    {
        
        public int Id { get; set; }
        public string Ten { get; set; }
    }
    public class VungMien
    {
        public int Id { get; set; }
        public string Ten { get; set; }
    }
    public class PhuTrachCanBoTB
    {
        public int Id { get; set; }
        public string Ten { get; set; }
    }
    public class DauMucThietBi
    {
        public int Id { get; set; }
        public string Ten { get; set; }
    }
    public class QuanLyGiaoDuc
    {
        public int Id { get; set; }
        public string Ten { get; set; }
    }
    public class QuanLyNhaNuoc
    {
        public int Id { get; set; }
        public string Ten { get; set; }
    }
    public class LyLuanChinhTri
    {
        public int Id { get; set; }
        public string Ten { get; set; }
    }

}
