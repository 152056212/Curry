﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GitManagerTest
{
    public partial class EmployerInfoForm : Form
    {
        public EmployerInfoForm()
        {
            InitializeComponent();
        }

        private void EmployerInfoForm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“GitDBDataSetEmployerInfo.pro_getEmployer”中。您可以根据需要移动或删除它。
            this.pro_getEmployerTableAdapter.Fill(this.GitDBDataSetEmployerInfo.pro_getEmployer);

            this.reportViewer1.RefreshReport();
        }
    }
}
