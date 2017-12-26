using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using BLL;
using Model;
using System.Windows.Forms;

namespace GitManagerTest
{
    public partial class SOForm : BaseForm
    {
        private StoOutManage stoutManage;
        private List<Model.Product> productList = new List<Product>();
        private Dictionary<int, int> dicProduct = new Dictionary<int, int>();
        private List<Model.Client> clients = new List<Client>();
        private Dictionary<int, int> dicClient = new Dictionary<int, int>();
        private MainForm mainForm;

        public SOForm( MainForm mainForm )
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }

        private void SOForm_Load_1(object sender, EventArgs e)
        {
            stoutManage = new StoOutManage( mainForm );
            stoutManage.setProList(cb_pro);
            stoutManage.setTypeItem(cb_type);
            stoutManage.setEmployerItem(cb_emouter);
            stoutManage.setStoItem(cb_storeNo);
            stoutManage.setClientItem(cb_seller);
            this.cb_stoOutype.SelectedIndex = 0 ;
            this.setRBNotCheck();
            this.productList = (List<Model.Product>)cb_pro.DataSource;
            for (int i = 0; i < productList.Count;i++ )
            {
                dicProduct.Add(i,productList[i].Pid);
            }
            this.clients = (List<Model.Client>)cb_seller.DataSource;
            for (int i = 0; i < clients.Count;i++ )
            {
                dicClient.Add(i, clients[i].Id);
            }
        }

        private void bt_ok_Click(object sender, EventArgs e)
        {

            if (cb_pro.SelectedIndex < 0 && cb_pro.Text.Equals(""))
            {
                MessageBox.Show("请选择或填写商品名称！");
            }
            else {
                if( tb_price.Text.Equals("") || !RegeUtil.isNum( tb_price.Text )  ){
                    MessageBox.Show("请正确输入商品价格！");
                }else
                if( tb_num.Text.Equals("") || !RegeUtil.isNum( tb_num.Text ) ){
                    MessageBox.Show("请正确填写商品出库数量！");
                }else
                if (cb_type.Text.Equals("") )
                {
                    MessageBox.Show("请选择商品类型！");
                }
                else {
                    if (cb_emouter.Text.Equals(""))
                    {
                        MessageBox.Show("请选择出库员！");
                    }
                    else {
                        if (cb_storeNo.Text.Equals(""))
                        {
                            MessageBox.Show("请选择仓库！");
                        }
                        else {
                            if (cb_seller.Text.Equals(""))
                            {
                                MessageBox.Show("请选择销售商！");
                            }
                            else {
                                if (cb_stoOutype.Text.Equals(""))
                                {

                                    MessageBox.Show("请选择出库类型！");
                                }
                                else {

                                    Model.StoreOut stoOut = new Model.StoreOut();
                                    stoOut.PId = dicProduct[cb_pro.SelectedIndex];
                                    stoOut.Sotype = cb_stoOutype.SelectedItem.ToString();
                                    stoOut.Pnum = int.Parse( tb_num.Text );
                                    int proNum  = int.Parse( productList[ cb_pro.SelectedIndex ].Pnum );
                                    if (stoOut.Pnum > proNum)
                                    {
                                        MessageBox.Show("库存不足！(" + productList[cb_pro.SelectedIndex].Pname + "的当前库存为 " + proNum + " ,请输入有效的商品出库数！)");
                                    }
                                    else {
                                        stoOut.StoreNo = cb_storeNo.Text;
                                        stoOut.SoerNo = cb_emouter.Text;
                                        if (rb_check.Checked == true)
                                        {
                                            stoOut.IsCheck = true;
                                        }
                                        else
                                            stoOut.IsCheck = false;
                                        stoOut.ClientId = dicClient[ cb_seller.SelectedIndex ] ;
                                        stoOut.POprice1 = int.Parse( tb_price.Text );
                                        stoutManage.addStoOut(stoOut, proNum);
                                    }
                                    

                                }
                            }
                        }
                    }
                }
            }
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void setRBCheck()
        {
            this.rb_check.Checked = true;
            this.rb_notcheck.Checked = false;
        }
        private void setRBNotCheck()
        {
            this.rb_check.Checked = false;
            this.rb_notcheck.Checked = true;
        }
    }
}
