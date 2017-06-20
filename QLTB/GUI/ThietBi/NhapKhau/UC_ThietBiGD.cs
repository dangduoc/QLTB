using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTB.Handler;
using QLTB.Model;

namespace QLTB.GUI
{
    public partial class UC_ThietBiGD : UserControl
    {
        private List<string> Thietbis;
        private DbImportHandler handler = new DbImportHandler();
        private List<ThietBiImport> dstb = new List<ThietBiImport>();
        public UC_ThietBiGD(List<ThietBiImport> ds,List<string> tb)
        {
            InitializeComponent();
            Thietbis = tb;
            dstb = ds;
        }
        public void loadForm()
        {
            var desHeader = new List<Columnmapping>();
            #region Khởi tạo cột trong phần mềm
            int i = 1;
            desHeader.Add(new Columnmapping
            {
                Index = i++,
                Ten = "Mã thiết bị"
            });
            desHeader.Add(new Columnmapping
            {
                Index = i++,
                Ten = "Tên thiết bị"
            });
            desHeader.Add(new Columnmapping
            {
                Index = i++,
                Ten = "Phòng học"
            });
            desHeader.Add(new Columnmapping
            {
                Index = i++,
                Ten = "Quy cách sử dụng"
            });
            desHeader.Add(new Columnmapping
            {
                Index = i++,
                Ten = "Nguồn kinh phí"
            });
            desHeader.Add(new Columnmapping
            {
                Index = i++,
                Ten = "Năm đưa vào SD"
            });
            desHeader.Add(new Columnmapping
            {
                Index = i++,
                Ten = "Ngày đưa vào SD"
            });
            desHeader.Add(new Columnmapping
            {
                Index = i++,
                Ten = "Năm theo dõi"
            });
            desHeader.Add(new Columnmapping
            {
                Index = i++,
                Ten = "Số lượng"
            });
            desHeader.Add(new Columnmapping
            {
                Index = i++,
                Ten = "Đơn giá"
            });
            desHeader.Add(new Columnmapping
            {
                Index = i++,
                Ten = "Thành tiền"
            });
            desHeader.Add(new Columnmapping
            {
                Index = i++,
                Ten = "Nước sản xuất"
            });
            desHeader.Add(new Columnmapping
            {
                Index = i++,
                Ten = "Ngày sản xuất"
            });
            desHeader.Add(new Columnmapping
            {
                Index = i++,
                Ten = "Hạn sử dụng"
            });
            desHeader.Add(new Columnmapping
            {
                Index = i++,
                Ten = "Ghi chú"
            });
            #endregion
            //
            int j = 1;
            foreach(var item in Thietbis)
            {
                dstb.RemoveAll(p => p.ThietBiId.Equals(item, StringComparison.CurrentCultureIgnoreCase));
                listView.Items.Add(j++ +"Mã thiết bị: "+item);
            }
            lbSoLuong.Text = Thietbis.Count.ToString();
            BindingSource source = new BindingSource();
            source.DataSource = dstb;
            DSTBDaCo.DataSource = source;
        }

        private void UC_ThietBiGD_Load(object sender, EventArgs e)
        {
            loadForm();
        }
        public List<ThietBiImport> GetResult()
        {
            return dstb;
        }
    }
}
