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
using System.Threading;

namespace GitManagerTest
{
    public partial class MainForm : BaseForm,IProductListener
    {
        private User iUser;
        private Color old_color;
        private LoginForm loginForm;
        private Color new_color = Color.FromArgb(41, 108, 204);
        private string curTime;
        private SynchronizationContext m_SyncContext = null;
        private Thread timer;
        private StoreInManage stoInManage;
        

        public MainForm(LoginForm loginForm, User iUser)
        {
            this.loginForm = loginForm;
            this.iUser = iUser;
            UiUtil.Output(this,"");
            InitializeComponent();
            m_SyncContext = SynchronizationContext.Current;
            stoInManage = new StoreInManage(this);

        }
        private void ThreadProSafePost() {
            while(true){
                m_SyncContext.Post(SetTextSafePost, "This text was set safely by SynchronizationContext-Post.");
                Thread.Sleep(10000);
            }
        }
        private void SetTextSafePost(object text)
        {
            DateTime date = DateTime.Now;
            this.sl_currentdate.Text = "当前时间： "+date.Hour.ToString()+":"+date.Minute.ToString();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if( iUser.Type ==1 ) 
            {
                this.sl_userInfo.Text = "当前用户：管理员";
            }
            if( iUser.Type ==2 )
            {
                this.sl_userInfo.Text = "当前用户：普通用户";
            }
            this.timer = new Thread(new ThreadStart(this.ThreadProSafePost));
            this.timer.Start();
            //thread.Start(); 
            stoInManage.setInCheckedLabel(this.lb_in);
            stoInManage.setOutCheckLabel(this.lb_out);

        }
        
        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //这时后台线程已经完成，并返回了主线程，所以可以直接使用UI控件了   
            this.sl_currentdate.Text = e.Result.ToString();
        } 
        //用户信息点击事件
        private void tsm_userInfo_Click(object sender, System.EventArgs e)
        {
            
        }
        //仓库信息点击事件
        private void tsm_storageInfo_Click(object sender, System.EventArgs e)
        {
            StorehouseForm storeForm = new StorehouseForm();
            storeForm.Show();
        }
        //客户信息点击事件
        private void tsm_clientInfo_Click(object sender, System.EventArgs e)
        {
            ClientInfoForm cif = new ClientInfoForm();
            cif.Show();
        }


        private void tsm_baseInfo_MouseLeave(object sender, System.EventArgs e)
        {
            //this.tsm_baseInfo.BackColor = System.Drawing.Color.FromArgb();
        }



        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }
        //业务模块_1
        private void flp_yewu_1_Paint(object sender, PaintEventArgs e)
        {

        }
        //采购模块_1
        private void flp_input_1_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void flp_storage_2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try 
            {
                UiUtil.Output(this, "closed");
                System.Environment.Exit(0);  
            }catch(Exception exc)
            {
                UiUtil.Output(this, exc.Message);
            }
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }
        /// <summary>
        /// 采购商品入库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Itsm_purcharse_Click(object sender, EventArgs e)
        {
            NewStoInForm sin = new NewStoInForm(this);
            sin.Show();
        }
        /// <summary>
        /// 退购商品入库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Itsm_regoods_Click(object sender, EventArgs e)
        {
            NewStoInForm sin = new NewStoInForm(this);
            sin.Show();
        }
        /// <summary>
        /// 工具栏：采购进货
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsb_purchaseInfo_Click(object sender, EventArgs e)
        {
            NewStoInForm storeIn = new NewStoInForm(this);
            storeIn.Show();
        }
        /// <summary>
        /// 退出系统
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsb_exit_Click(object sender, EventArgs e)
        {
            loginForm.Close();
            Close();
            System.Environment.Exit(0);  
        }
        /// <summary>
        /// 库存调拨回调
        /// </summary>
        /// <param name="adjustNum"></param>
        public void isAdjustChecked(int adjustNum)
        {
            
        }
        /// <summary>
        /// 入库审核回调
        /// </summary>
        /// <param name="inNum"></param>
        public void isInCheck(int inNum)
        {
            
        }
        /// <summary>
        /// 出库审核回调
        /// </summary>
        /// <param name="outNum"></param>
        public void isOutCheck(int outNum)
        {
            this.lb_out.Text = outNum.ToString();
        }
        /// <summary>
        /// 最新购买入库回调
        /// </summary>
        /// <param name="buyNum"></param>
        public void storehouseInput(int buyNum)
        {
        }
        /// <summary>
        /// 付款回调
        /// </summary>
        /// <param name="payNum"></param>
        public void isPay(int payNum)
        {
            
        }

        public void isNewProduct(int productNum)
        {
           
        }

        private void tsb_salesInfo_Click(object sender, EventArgs e)
        {
            SOForm sout = new SOForm( this );
            sout.Show();
        }

        private void lb_in_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("审核");
        }

        private void lb_out_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("审核");
        }

        private void Itsm_sales_Click(object sender, EventArgs e)
        {
            SOForm sout = new SOForm(this);
            sout.Show();
        }

        private void Itsm_regood_sales_Click(object sender, EventArgs e)
        {
            SOForm sout = new SOForm(this);
            sout.Show();
        }

        private void tsb_goodsInfo_Click(object sender, EventArgs e)
        {
            //ProductInfo productFrom = new ProductInfo();
            //productFrom.Show();
            EmployerInfoForm emInfo = new EmployerInfoForm();
            emInfo.Show();

        }

        private void tsb_supplierInfo_Click(object sender, EventArgs e)
        {
            ClientInfo GYSForm = new ClientInfo();
            GYSForm.Show();
        }

        private void tsb_clientInfo_Click(object sender, EventArgs e)
        {
            BuyerInfoForm buerInfo = new BuyerInfoForm();
            buerInfo.Show();
        }

        private void tsm_statistic_Click(object sender, EventArgs e)
        {
            SITJForm tj = new SITJForm();
            tj.Show();
        }
    }
}
