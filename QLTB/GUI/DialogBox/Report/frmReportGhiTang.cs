using QLTB.Handler;
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
    public partial class frmReportGhiTang : DevComponents.DotNetBar.Office2007Form
    {
        private int NamHoc;
        private DbThongKeHandler handler = new DbThongKeHandler();
        public frmReportGhiTang(int NamHocId)
        {
            InitializeComponent();
            NamHoc = NamHocId;
        }

        private void frmReportGhiTang_Load(object sender, EventArgs e)
        {
            BindingSource source = new BindingSource();
            source.DataSource= handler.DanhSachGhiTang(NamHoc);
            GhiTangReportModelBindingSource.DataSource = source;
            //
            Microsoft.Reporting.WinForms.ReportParameter[] rParams = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("DonViChuQuan",GlobalVariable.GetHeThong().DonVi.DonViChuQuan),
                new Microsoft.Reporting.WinForms.ReportParameter("TenTruong",GlobalVariable.GetHeThong().DonVi.Ten),
                 new Microsoft.Reporting.WinForms.ReportParameter("TenBaoCao","SỔ THEO DÕI VIỆC GHI TĂNG THIẾT BỊ GIÁO DỤC"),
                  new Microsoft.Reporting.WinForms.ReportParameter("NamHoc","NĂM HỌC: "+GlobalVariable.GetHeThong().NamHoc.NamBatDau.ToString()+" - "+GlobalVariable.GetHeThong().NamHoc.NamKetThuc.ToString())

            };
            reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            reportViewer1.LocalReport.SetParameters(rParams);
            this.reportViewer1.RefreshReport();
        }
    }
}
