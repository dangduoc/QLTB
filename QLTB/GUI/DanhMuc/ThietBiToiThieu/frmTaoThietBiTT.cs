﻿using System;
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
    public partial class frmTaoThietBiTT : DevComponents.DotNetBar.Office2007Form
    {
        public frmTaoThietBiTT()
        {
            InitializeComponent();
        }

        private void checkBoxX3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("chức năng đang xây dựng");
        }
    }
}
