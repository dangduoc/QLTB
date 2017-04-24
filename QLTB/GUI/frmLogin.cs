﻿using QLTB.DAL;
using QLTB.DAL.Data;
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
    public partial class frmLogin : DevComponents.DotNetBar.Office2007Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (var unitOfWork= new UnitOfWork())
            {
                var list = unitOfWork.GetRepository<DM_LopHoc>().GetAll().FirstOrDefault();
            }
                DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
