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
    public partial class frmReportDSThietBi : DevComponents.DotNetBar.Office2007Form
    {
        private DbThongKeHandler handler = new DbThongKeHandler();
        public frmReportDSThietBi()
        {
            InitializeComponent();
        }

        private void frmReportDSThietBi_Load(object sender, EventArgs e)
        {

            BindingSource source = new BindingSource();
            source.DataSource = handler.DanhSachThietBi();
            ThietBiReportModelBindingSource.DataSource = source;
            //
            Microsoft.Reporting.WinForms.ReportParameter[] rParams = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("DonViChuQuan",GlobalVariable.GetHeThong().DonVi.DonViChuQuan),
                new Microsoft.Reporting.WinForms.ReportParameter("TenTruong",GlobalVariable.GetHeThong().DonVi.Ten),
                 new Microsoft.Reporting.WinForms.ReportParameter("TenBaoCao","DANH SÁCH THIẾT BỊ"),
                  new Microsoft.Reporting.WinForms.ReportParameter("NgayXuat",MyConvert.DateToString(DateTime.Today))
            };
            reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            reportViewer1.LocalReport.SetParameters(rParams);
            this.reportViewer1.RefreshReport();
        }
    }
}
