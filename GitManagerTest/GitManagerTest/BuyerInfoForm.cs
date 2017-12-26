using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GitManagerTest
{
    public partial class BuyerInfoForm : Form
    {
        public BuyerInfoForm()
        {
            InitializeComponent();
        }

        private void BuyerInfoForm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“GitDBDataSetBuyerInfo.pro_getClient2”中。您可以根据需要移动或删除它。
            this.pro_getClient2TableAdapter.Fill(this.GitDBDataSetBuyerInfo.pro_getClient2);

            this.reportViewer1.RefreshReport();
        }
    }
}
