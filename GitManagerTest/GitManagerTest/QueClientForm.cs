using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model;

namespace GitManagerTest
{
    public partial class QueClientInfoForm : BaseForm
    {
        private Client cli;

        public QueClientInfoForm()
        {
            InitializeComponent();
        }
        //控件还未绘制
        private void QueClientInfoForm_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 点击一键查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_query_Click(object sender, EventArgs e)
        {
            cli = new Client();
            //客户类型
            string type = this.cbb_type.Text;
            if( type.Equals("供应商") )
            {
                //供应商
                cli.ClientType = ModConst.APPLIER;
            }
            else
            {
                if( type.Equals("供货商") )
                {
                    //购货商
                    cli.ClientType = ModConst.PURCHASER;
                }
            }
            //客户名称
            cli.Cname = this.tb_name.Text;
            //联系人
            cli.Client_contact = this.tb_contact.Text;
            //通信地址
            cli.Address = this.tb_address.Text;
            //邮政编码
            cli.Postcode = this.tb_postcode.Text;
            //传真
            cli.Fax = this.tb_fox.Text;


        }

        private void btn_query_KeyDown(object sender, KeyEventArgs e)
        {

        }
        

    }
}
