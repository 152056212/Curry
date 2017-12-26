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
    public partial class AddClientForm : Form
    {
        //默认类型是：供应商
        private Client client;
        private BllClient cv;
        private IChangedListener changeListener;

        public AddClientForm(IChangedListener changeListener,BLL.BllClient cv)
        {
            this.changeListener = changeListener;
            client = new Client();
            this.cv = cv;
            InitializeComponent();
        }

        private void bt_ok_Click(object sender, EventArgs e)
        {
            //客户名称不能为空
            //客户类型不能为空
            //客户联系人不能为空
            //通信地址不能为空
            //联系电话不能为空
            if (textisNull(this.tb_name))
            {
                //参数1：显示的文本；参数2：标题内容；参数3：显示不同的按钮(MessageBoxButtons)；参数4：显示不同含义的图标(MessageBoxIcon)；
                MessageBox.Show("客户姓名不能为空！", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else 
            {
                if (textisNull(this.tb_contact))
                {
                    MessageBox.Show("联系人不能为空！", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else 
                {
                    if (textisNull(this.tb_address))
                    {
                        MessageBox.Show("联系地址不能为空！", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                    else 
                    {
                        if (textisNull(this.tb_phone))
                        {
                            MessageBox.Show("联系电话不能为空！", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        }
                        else 
                        {
                            bool isPhoneNum = RegeUtil.isPhoneNum(tb_phone.Text);
                            if(!isPhoneNum)
                            {
                                DialogResult dr = MessageBox.Show("联系电话格式有误！", "提示", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                                if(dr == System.Windows.Forms.DialogResult.Retry)
                                {
                                    tb_phone.Text = "";
                                }
                            }
                            else
                            {
                                //清除之前的设置
                                client.clear();
                                client.Cname = tb_name.Text;
                                if (cb_type.SelectedIndex == -1)
                                {
                                    client.ClientType = 1;
                                }
                                else {
                                    client.ClientType = cb_type.SelectedIndex + 1;
                                }
                                UiUtil.Output(this,"客户类型："+client.ClientType);
                                client.Client_contact = tb_contact.Text;
                                client.Address = tb_address.Text;
                                client.Postcode = tb_postcode.Text;
                                client.Phone = tb_phone.Text;
                                client.Fax = tb_fax.Text;
                                client.Memo = tb_memo.Text;
                                bool isAdd = this.cv.addClient(client);
                                if (isAdd) 
                                {
                                    this.changeListener.changed();
                                    tb_name.Text = "";
                                    tb_contact.Text = "";
                                    tb_address.Text = "";
                                    tb_postcode.Text = "";
                                    tb_phone.Text = "";
                                    tb_fax.Text = "";
                                    tb_memo.Text = "";
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

    }
    
}
