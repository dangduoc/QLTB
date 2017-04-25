using QLTB.Model;
using QLTB.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTB.GUI.DialogBox
{
    public partial class frmDialogDSThietBi : DevComponents.DotNetBar.Office2007Form
    {
        private BindingSource source = new BindingSource();
        public frmDialogDSThietBi()
        {
            InitializeComponent();
        }
        private void SetHeaderForGrid(ADGV.AdvancedDataGridView grid, List<string> headers)
        {
            for (int i = 0; i < headers.Count; i++)
            {
                grid.Columns[i].HeaderText = headers[i];
            }
        }
        private void LoadForm()
        {
            //Clone
            List<ThietBiTTGridDisplayModel> list = new List<ThietBiTTGridDisplayModel>();
            list.Add(new ThietBiTTGridDisplayModel
            {
                ThietBiId = "CSCN1001",
                Ten = "Quy trình sản xuất vải sợi thiên nhiên",
                DonViTinh = "Cái",
                DungChoLop = "6,7,8,9",
                LoaiThietBi = "Tranh ảnh",
                MonHoc = "Công nghệ",
                DauMuc = "Máy in",
                SoLuong = "10",
                MoTa = "Kích th¬ước (790x540)mm dung sai 10mm, in offset 4 màu trên giấy couché có định lượng 200g/m2,  cán láng OPP mờ."
            });
            list.Add(new ThietBiTTGridDisplayModel
            {
                ThietBiId = "CSCN1002",
                Ten = "Quy trình sản xuất vải sợi hoá học",
                DonViTinh = "Cái",
                DungChoLop = "6,7,8,9",
                LoaiThietBi = "Tranh ảnh",
                MonHoc = "Công nghệ",
                DauMuc = "Máy in",
                SoLuong = "12",
                MoTa = "Kích th¬ước (790x540)mm dung sai 10mm, in offset 4 màu trên giấy couché có định lượng 200g/m2,  cán láng OPP mờ."
            });
            list.Add(new ThietBiTTGridDisplayModel
            {
                ThietBiId = "CSHH1001",
                Ten = "Ảnh hưởng của nhiệt độ đến độ tan của chất rắn và chất khí",
                DonViTinh = "Cái",
                DungChoLop = "6,7,8,9",
                LoaiThietBi = "Tranh ảnh",
                MonHoc = "Hóa học",
                DauMuc = "Máy in",
                SoLuong = "4",
                MoTa = "Kích th¬ước (790x540)mm dung sai 10mm, in offset 4 màu trên giấy couché có định lượng 200g/m2,  cán láng OPP mờ."
            });
            //
            List<string> headers = new List<string>();
            headers.Add("Mã thiết bị");
            headers.Add("Tên thiết bị");
            headers.Add("Đơn vị tính");
            headers.Add("Dùng cho lớp");
            headers.Add("Loại thiết bị");
            headers.Add("Môn học");
            headers.Add("Đầu mục");
            headers.Add("Số lượng");
            headers.Add("Mô tả");

            //
            DataTable tb = MyConvert.ToDataTable(list);
            tb.Columns.Add("check", typeof(DataGridViewCheckBoxColumn));
            source.DataSource = tb; // SetUpSearch(tb, headers);
            advancedDataGridView.DataSource = source;
            SetHeaderForGrid(advancedDataGridView, headers);
        }

        private void advancedDataGridView_FilterStringChanged(object sender, EventArgs e)
        {
            source.Filter = advancedDataGridView.FilterString;
        }

        private void advancedDataGridView_SortStringChanged(object sender, EventArgs e)
        {
            source.Sort = advancedDataGridView.SortString;
        }
    }
}
