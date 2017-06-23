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
    public partial class frmReportDSHCHetHan : DevComponents.DotNetBar.Office2007Form
    {
        private DbThongKeHandler handler = new DbThongKeHandler();
        BindingSource source = new BindingSource();
        public frmReportDSHCHetHan()
        {
            InitializeComponent();
            source.DataSource = handler.HCHetHan(4);
        }

        private void frmReportDSHCHetHan_Load(object sender, EventArgs e)
        {

            HCHetHanReportModelBindingSource.DataSource = source;
            //
            Microsoft.Reporting.WinForms.ReportParameter[] rParams = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("DonViChuQuan",GlobalVariable.GetHeThong().DonVi.DonViChuQuan),
                new Microsoft.Reporting.WinForms.ReportParameter("TenTruong",GlobalVariable.GetHeThong().DonVi.Ten),
                 new Microsoft.Reporting.WinForms.ReportParameter("TenBaoCao","DANH MỤC HÓA CHẤT HẾT HẠN - PHÒNG THỰC HÀNH HÓA"),
                  new Microsoft.Reporting.WinForms.ReportParameter("NamHoc","NĂM HỌC: "+GlobalVariable.GetHeThong().NamHoc.NamBatDau.ToString()+" - "+GlobalVariable.GetHeThong().NamHoc.NamKetThuc.ToString())
            };
            reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            reportViewer1.LocalReport.SetParameters(rParams);
            this.reportViewer1.RefreshReport();
        }
    }
}
