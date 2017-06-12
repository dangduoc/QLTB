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

namespace QLTB.GUI
{
    public partial class frmDialogTBBaoHong : DevComponents.DotNetBar.Office2007Form
    {
        private List<BaseThietBiGridDisplayModel> dsThietBi = new List<BaseThietBiGridDisplayModel>();
        public frmDialogTBBaoHong(List<BaseThietBiGridDisplayModel> ds)
        {
            InitializeComponent();
            dsThietBi = ds;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var parent = Owner as Form1;
            var childfrm = parent.ActiveControl as Form;

            //
            var list = new List<BaseThietBiGridDisplayModel>();
            foreach (DataGridViewRow item in ADGVDanhSach.Rows)
            {
                if ((string)item.Cells["checkBtn"].Value == "T")
                {
                    var tmp = new BaseThietBiGridDisplayModel
                    {
                        ThietBiId = item.Cells["ThietBiId"].Value.ToString(),
                        Ten = item.Cells["Ten"].Value.ToString(),
                        SoHieu = item.Cells["SoHieu"].Value.ToString(),
                        PhongHoc = item.Cells["PhongHoc"].Value.ToString(),
                        DonViTinh = item.Cells["DonViTinh"].Value.ToString()
                    };
                    list.Add(tmp);
                }
            }
            //
            if (childfrm.Name.Equals("frmPhieuBaoHong"))
            {
               
                if (list.Count > 0)
                {
                    var owner = this.Owner.ActiveControl as IFrmPhieuBaseTB;
                    owner.AddToGrid(list);
                }
            }
            else
            {
                frmPhieuBaoHong frm = new frmPhieuBaoHong(list);
                parent.OpenFrmChild(frm);             
            }
            Close();
        }
        private void loadForm()
        {
            BindingSource source = new BindingSource();
            source.DataSource = MyConvert.ToDataTable<BaseThietBiGridDisplayModel>(dsThietBi);
            ADGVDanhSach.DataSource = source;
            ADGVDanhSach.Columns["ThietBiId"].HeaderText = "";
            ADGVDanhSach.Columns["SoHieu"].HeaderText = "";
            ADGVDanhSach.Columns["Ten"].HeaderText = "";
            ADGVDanhSach.Columns["PhongHoc"].HeaderText = "";
            ADGVDanhSach.Columns["DonViTinh"].HeaderText = "";
            DataGridViewCheckBoxColumn col = new DataGridViewCheckBoxColumn();
            col.Name = "checkBtn";
            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col.HeaderCell = new DGVColumnHeaderCheckBox();
            col.TrueValue = "T";
            col.FalseValue = "F";
            ADGVDanhSach.Columns.Add(col);

            ADGVDanhSach.Columns["checkBtn"].Width = 40;
            ADGVDanhSach.Columns["checkBtn"].HeaderText = "";
            ADGVDanhSach.Columns["checkBtn"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ADGVDanhSach.Columns["checkBtn"].DefaultCellStyle.Padding = new Padding(5, 0, 0, 0);
        }
        private void frmDialogTBBaoHong_Load(object sender, EventArgs e)
        {
            loadForm();
        }
    }
}
