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
