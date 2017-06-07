using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTB.Model
{
    public class BaseCanBoThietBiModel
    {
        public string CanBoThietBiId { get; set; }
        public string HoVaDem { get; set; }
        public string Ten { get; set; }
    }
    public class CanBoThietBiModel: BaseCanBoThietBiModel
    {
        public Nullable<int> GioiTinhId { get; set; }
        public Nullable<int> PhuTrachId { get; set; }
        public string TrinhDoVanHoa { get; set; }
        public Nullable<bool> IsCoTrinhDoNghiepVu { get; set; }
        public string GhiChu { get; set; }
        public int TrangThai { get; set; }
        public string ThoiGianBatDau { get; set; }
        public string ThoiGianKetThuc { get; set; }
    }
    public class CanBoTBGridDisplayModel
    {
        public string CanBoThietBiId { get; set; }
        public string HoVaDem { get; set; }
        public string Ten { get; set; }
        public string GioiTinh { get; set; }
        public string PhuTrach { get; set; }
        public string TrinhDoVanHoa { get; set; }
        public string TGBatDauQL { get; set; }
        public string TGKetThucQL { get; set; }
        public string IsCoTrinhDoNghiepVu { get; set; }
        public string GhiChu { get; set; }
        
    }
    public class CanBoThietBiCreateModel
    {
        public string HoVaDem { get; set; }
        public string Ten { get; set; }
        public Nullable<int> GioiTinhId { get; set; }
        public Nullable<int> PhuTrachId { get; set; }
        public string TrinhDoVanHoa { get; set; }
        public Nullable<System.DateTime> ThoiGianBatDau { get; set; }
        public Nullable<System.DateTime> ThoiGianKetThuc { get; set; }
        public Nullable<bool> IsCoTrinhDoNghiepVu { get; set; }
        public string GhiChu { get; set; }
    }
    public class CanBoThietBiUpdateModel
    {
        public string HoVaDem { get; set; }
        public string Ten { get; set; }
        public Nullable<int> GioiTinhId { get; set; }
        public Nullable<int> PhuTrachId { get; set; }
        public string TrinhDoVanHoa { get; set; }
        public Nullable<System.DateTime> ThoiGianBatDau { get; set; }
        public Nullable<System.DateTime> ThoiGianKetThuc { get; set; }
        public Nullable<bool> IsCoTrinhDoNghiepVu { get; set; }
        public string GhiChu { get; set; }
    }
}
