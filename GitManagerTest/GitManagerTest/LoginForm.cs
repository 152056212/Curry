using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using Model;

namespace GitManagerTest
{
    public partial class LoginForm : Form
    {
        private int input_count = 0;
        public int Input_count
        {
            get { return input_count; }
        }
        public static User iUser;
        
        public LoginForm()
        {
            InitializeComponent();
            
        }
      
        private void Form1_Load(object sender, EventArgs e)
        {
            this.cb_usertype.SelectedIndex = 0;
        }
        private void tb_username_TextChanged(object sender, EventArgs e)
        {

        }
        private void tb_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 登录按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_Login_Click(object sender, System.EventArgs e)
        {
                if (this.tb_password.Text.Equals(""))
                {
                    this.lb_psw_tip.Text = "密码不能为空！";
                }
                else
                {
                    iUser = new User();
                    iUser.UserName = this.tb_username.Text;
                    iUser.Psw = this.tb_password.Text;
                    if (this.cb_usertype.Text.Equals("管理员"))
                        iUser.Type = 1;
                    else
                        if (this.cb_usertype.Text.Equals("普通用户"))
                            iUser.Type = 2;
                        else {
                            //非法用户
                            iUser.Type = 0;
                        }
                    BLL.userAccess user = new BLL.userAccess();
                    bool canLogin = user.userLogin(iUser);
                    if (canLogin)
                    {
                        MainForm mainForm = new MainForm(this,iUser);
                        mainForm.Show();
                        this.Dispose(false); 
                        //this.Hide();
                        //this.Close();
                        //this.Dispose();
                    }
                    else 
                    {
                        MessageBox.Show("用户名或密码错误！");
                    }
                    //userLogin.userQuery(iUser);
                    //userLogin.testProc();
                }
            

            
        }
        /// <summary>
        /// 敲击回车事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_password_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                if (this.tb_password.Text.Equals(""))
                {
                    this.lb_psw_tip.Text = "密码不能为空！";
                }
                else
                {
                    iUser = new User();
                    iUser.UserName = this.tb_username.Text;
                    iUser.Psw = this.tb_password.Text;
                    if (this.cb_usertype.Text.Equals("管理员"))
                        iUser.Type = 1;
                    else
                        if (this.cb_usertype.Text.Equals("普通用户"))
                            iUser.Type = 2;
                        else
                        {
                            //非法用户
                            iUser.Type = 0;
                        }
                    BLL.userAccess userLogin = new BLL.userAccess();
                    bool canLogin = userLogin.userLogin(iUser);
                    if (canLogin)
                    {
                        UiUtil.Output(this,"登陆成功");
                        MainForm mainForm = new MainForm(this,iUser);
                        mainForm.Show();
                        this.Dispose(false); 
                        //this.Hide();
                        //this.Close();
                        //this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("用户名或密码错误！");
                    }
                    //userLogin.userLogin(iUser);
                    //userLogin.userQuery(iUser);
                    //userLogin.testProc();
                }
            }
            
        }

        private void flp_root_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cb_usertype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
        

    }
}
