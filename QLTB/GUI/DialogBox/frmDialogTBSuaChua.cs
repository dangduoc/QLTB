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

namespace QLTB.GUI.DialogBox
{
    public partial class frmDialogTBSuaChua : DevComponents.DotNetBar.Office2007Form
    {
        public frmDialogTBSuaChua()
        {
            InitializeComponent();
        }
        private void loadForm()
        {
            List<DSThietBiSuaGridDisplayModel> list = new List<DSThietBiSuaGridDisplayModel>();
            advancedDataGridView.DataSource = list;
            advancedDataGridView.Columns[0].HeaderText = "Số hiệu";
            advancedDataGridView.Columns[0].HeaderText = "Mã thiết bị";
            advancedDataGridView.Columns[0].HeaderText = "Tên thiết bị";
            advancedDataGridView.Columns[0].HeaderText = "Loại thiết bị";
            advancedDataGridView.Columns[0].HeaderText = "Tình trạng";
            advancedDataGridView.Columns[0].HeaderText = "Số phiếu báo hỏng/mất";
        }
    }
}
