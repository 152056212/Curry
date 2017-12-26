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
    public partial class ProductInfo : Form
    {
        public ProductInfo()
        {
            InitializeComponent();
        }

        private void ProductInfo_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“GitDBDataSet.pro_getProduct”中。您可以根据需要移动或删除它。
            this.pro_getProductTableAdapter.Fill(this.GitDBDataSet.pro_getProduct);

            this.reportViewer1.RefreshReport();
        }
    }
}
