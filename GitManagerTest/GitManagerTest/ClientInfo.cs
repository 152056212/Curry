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
    public partial class ClientInfo : Form
    {
        public ClientInfo()
        {
            InitializeComponent();
        }

        private void ClientInfo_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“GitDBDataSetClientInfo.pro_getClient”中。您可以根据需要移动或删除它。
            this.pro_getClientTableAdapter.Fill(this.GitDBDataSetClientInfo.pro_getClient);

            this.reportViewer1.RefreshReport();
        }
    }
}
