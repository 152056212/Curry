using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using System.Windows.Forms.DataVisualization.Charting;

namespace GitManagerTest
{
    public partial class SITJForm : BaseForm
    {
        private BLLSHStatics bllStatics;
        private ChartArea charArea = new ChartArea() { Name = "ca1" };
        //仓库库存统计
        List<int> txData2 = new List<int>() { 2011, 2012, 2013, 2014, 2015, 2016 };
        List<int> tyData2 = new List<int>() { 49, 6, 7, 4, 5, 4 };

        List<int> txData3 = new List<int>() { 2012 };
        List<int> tyData3 = new List<int>() { 7 };


        public SITJForm()
        {
            InitializeComponent();
            bllStatics = new BLLSHStatics();

        }
        private void StorehouseForm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“GitDBDataSet.pro_getProduct”中。您可以根据需要移动或删除它。
            this.pro_getProductTableAdapter.Fill(this.GitDBDataSet.pro_getProduct);

            mchart.ChartAreas.Add(charArea);     //背景框

            this.reportViewer1.RefreshReport();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            //仓库库存统计
            if (listView1.Items[0].Selected == true)
            {
                bllStatics.getKuCunTJ( this.mchart );
                //标题
                //mchart.Titles.Add("当前各仓库库存量");
            }
            //月出库统计
            if( listView1.Items[1].Selected == true ){
                bllStatics.getMonthOutTJ(mchart);
            }
            //月入库统计
            if( listView1.Items[2].Selected == true ){
                bllStatics.getMonthInTJ(mchart);
            }
            //商品类型数量统计
            if( listView1.Items[3].Selected == true ){
                bllStatics.getProTypeTJ(mchart);
            }
            //入库类型统计
            if( listView1.Items[4].Selected == true ){
                bllStatics.getInTyoeTJ(mchart);
            }
            if( listView1.Items[5].Selected == true ){
                bllStatics.getOutTyoeTJ(mchart);
            }
        }
       
        

    }
}
