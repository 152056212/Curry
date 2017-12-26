using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model;
using BLL;

namespace GitManagerTest
{
    public partial class NewStoInForm : BaseForm
    {
        //默认类型是：供应商
        private StoreInManage siManager;
        private string proName = "";
        private string proType = "";
        private string proStyle = "";
        private string price = "";
        private string proNum = "";
        private string storeNo = "";
        private string stoIner = "";
        private int alarmDays = 0;
        private int vaild = 0;
        private List<Model.Employer> emsNew = new List<Employer>();
        private Dictionary<int, string> dicEm = new Dictionary<int, string>();

        public NewStoInForm(MainForm mainForm)
        {
            //this.changeListener = changeListener;
            //client = new Client();
            //this.cv = cv;
            siManager = new StoreInManage(mainForm);
            InitializeComponent();
        }

        private void bt_ok_Click(object sender, EventArgs e)
        {
            proName = tb_name.Text;
            if (cb_type.SelectedIndex!=-1)
                proType = cb_type.SelectedItem.ToString();
            proStyle = tb_style.Text;
            price = tb_price.Text;
            proNum = tb_num.Text;
            if (cb_storeNo.SelectedIndex!= -1)
                storeNo = cb_storeNo.SelectedItem.ToString();
            if (cb_eminer.SelectedIndex != -1)
                stoIner = cb_eminer.SelectedItem.ToString();
            if (proName.Equals(""))
            {
                MessageBox.Show("请填写商品名称！");
            }
            else {
                if (proStyle.Equals(""))
                {
                    MessageBox.Show("请选择商品类型！");
                }
                else {
                    if (price.Equals(""))
                    {
                        MessageBox.Show("请填写商品价格！");
                    }else if (!RegeUtil.isNum(price)) {
                        MessageBox.Show("商品价格必须为数字！");
                    }
                    else
                    {
                        if (proNum.Equals(""))
                        {
                            MessageBox.Show("请填写商品数量！");
                        }
                        else
                        {
                            if (storeNo.Equals(""))
                            {
                                MessageBox.Show("请选择库房编号！");
                            }
                            else
                            {
                                if (stoIner.Equals(""))
                                {
                                    MessageBox.Show("请选择入库员！");
                                }
                                else
                                {
                                    if( tb_alarmDays.Text.Equals("") ){
                                        MessageBox.Show("请填写提醒天数！");
                                    }
                                    else if (!RegeUtil.isNum(tb_alarmDays.Text))
                                    {
                                        MessageBox.Show("请正确填写提醒天数！");
                                    }
                                    else {
                                        if( !RegeUtil.isNum(tb_alarmDays.Text) ){
                                            
                                        }else
                                        if (this.tb_valid.Text.Equals("") )
                                        {
                                            MessageBox.Show("请填写商品有效期！");
                                        }
                                        else {
                                            if (!RegeUtil.isNum(tb_valid.Text))
                                            {
                                                MessageBox.Show("商品有效期为数字！");
                                            }
                                            else if ( cb_clients.SelectedIndex<0 )
                                                {
                                                    MessageBox.Show("请选择供应商类型！");
                                                }else if (cb_stointype.SelectedItem == null)
                                                {
                                                    MessageBox.Show("请选择入库类型！");
                                                }else {
                                                Model.Product product = new Model.Product();
                                                product.Pname = proName;
                                                product.TypeName = proType;
                                                product.Pstyle = proStyle;
                                                product.Unit = tb_unit.Text;
                                                product.Price = double.Parse(price);
                                                product.Pnum = proNum;
                                                product.ProStoNo = storeNo;
                                                product.StoIner =  dicEm[cb_eminer.SelectedIndex];
                                                UiUtil.Output(this,"入库员："+stoIner+"}");
                                                this.alarmDays = int.Parse(tb_alarmDays.Text);
                                                product.Alramdays = alarmDays;
                                                product.StoInType = cb_stointype.SelectedItem.ToString();
                                                if( !tb_valid.Text.Equals("") )
                                                    product.Valid = int.Parse( tb_valid.Text );
                                                List<Model.Client> clients = (List<Model.Client>)cb_clients.DataSource;
                                                product.ClientId = clients[cb_clients.SelectedIndex ].Id;
                                                bool isCheck = false;
                                                if( rb_check.Checked == true ){
                                                    isCheck = true;
                                                }
                                                //MessageBox.Show("" + product.ClientId+ isCheck );
                                                product.IsCheck = isCheck;
                                                siManager.addStoreIn(product);
                                                this.clear();
                                            }
                                        
                                        }
                                    }
                                    

                                }
                            }
                        }
                    }
                }
            }

        }

        private bool textisNull(TextBox textBox) 
        {
            if (textBox.Text.Equals(""))
            {
                return true;
            }
            else 
            {
                return false;
            }
        }


        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewStoInForm_Load(object sender, EventArgs e)
        {
            //初始化商品类型列表
            siManager.setTypeItem(this.cb_type);
            //初始化仓库列表
            siManager.setStorehouseItem( this.cb_storeNo );
            //初始化员工列表
            siManager.setEmployerItem(this.cb_eminer);
            emsNew = (List<Employer>)cb_eminer.DataSource;
            for (int i = 0; i < emsNew.Count;i++ )
            {
                dicEm.Add(i, emsNew[i].Emno);   
            }

            //初始化供应商列表
            siManager.setClientItem(cb_clients);
            TextHintUtil.SetCueText(this.tb_alarmDays,"请输入天数");
            this.setRBNotCheck();
            //this.proTypeList = siManager.TypeList;
            //siManager.getProductNo("","");
            
        }
        private void clear() {
            this.tb_name.Text = "";
            this.cb_type.Text = "";
            this.tb_num.Text = "";
            this.tb_alarmDays.Text = "";
            this.tb_price.Text = "";
            this.tb_style.Text = "";
            this.tb_unit.Text = "";
            this.tb_valid.Text = "";
            this.cb_storeNo.Text = "";
            this.cb_stointype.Text = "";
            
        }
        private void setRBCheck() {
            this.rb_check.Checked = true;
            this.rb_notcheck.Checked = false;
        }
        private void setRBNotCheck() {
            this.rb_check.Checked = false;
            this.rb_notcheck.Checked = true;
        }
        

    }
    
}
