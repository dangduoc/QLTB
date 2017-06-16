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
using QLTB.Model;
namespace QLTB.GUI
{
    public partial class frmReportMuaSam : DevComponents.DotNetBar.Office2007Form
    {
        private DbThongKeHandler handler = new DbThongKeHandler();
        BindingSource source = new BindingSource();
        private string namhoc = "",tenbaocao="";
        public frmReportMuaSam(string id,string namhoc,string tenbaocao)
        {
            InitializeComponent();
            source.DataSource = handler.ThietBiMuSam(id);
            this.namhoc = namhoc;
            this.tenbaocao = tenbaocao;
        }

        private void frmReportMuaSam_Load(object sender, EventArgs e)
        {
           
            
            ThietBiMuaReportModelBindingSource.DataSource = source;
            //
            Microsoft.Reporting.WinForms.ReportParameter[] rParams = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("DonViChuQuan",GlobalVariable.GetHeThong().DonVi.DonViChuQuan),
                new Microsoft.Reporting.WinForms.ReportParameter("TenTruong",GlobalVariable.GetHeThong().DonVi.Ten),
                 new Microsoft.Reporting.WinForms.ReportParameter("TenBaoCao",tenbaocao.ToUpper()),
                  new Microsoft.Reporting.WinForms.ReportParameter("NamHoc",namhoc)

            };
            reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            reportViewer1.LocalReport.SetParameters(rParams);
            this.reportViewer1.RefreshReport();
        }
    }
}
