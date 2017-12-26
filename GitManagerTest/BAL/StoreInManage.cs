using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DAL;
using Model;
using System.Windows.Forms;

namespace BLL
{
    public class StoreInManage
    {
        private DBStoreManage dbsm;
        private DBProType dbProType;
        private DBEmployer dbEm;
        private DBClient dbclient;
        private List<Model.ProType> typeList;
        private IProductListener productListner;

        public List<Model.ProType> TypeList
        {
            get { return typeList; }
        }
        private List<Model.Storehouse> storeList;
        public List<Model.Storehouse> StoreList
        {
            get { return storeList; }
        }
        private List<Model.Employer> ems;
        public List<Model.Employer> Ems
        {
            get { return ems; }
        }
        
        private List<Model.Client> clients = new List<Client>();
        private Dictionary<string, string> dicType = new Dictionary<string, string>() { };
        private Dictionary<string, string> dicStoNo = new Dictionary<string, string>() { };
        private Dictionary<string, string> dicSIerNo = new Dictionary<string, string>() { };
        private List<Model.Employer> emsNew = new List<Employer>();
        private Dictionary<int, int> didEm = new Dictionary<int, int>();
        private Model.StoreIn mStoreIn;
        private Model.Product mPro;
        

        public StoreInManage( IProductListener productListner ) {
            dbsm = new DBStoreManage();
            dbProType = new DBProType();
            dbEm = new DBEmployer();
            dbclient = new DBClient();
            this.productListner = productListner;
        }
        public void initGridView( DataGridView dgv ) {

            DataSet ds = dbsm.init();
            dgv.DataSource = ds.Tables[0];
        }
        //初始化类型列表
        public void setTypeItem( ComboBox cb ) {

            typeList = dbProType.getTypeList();
            if (typeList != null)
            {
                foreach (Model.ProType pt in typeList)
                {
                    cb.Items.Add(pt.Name);
                    //类型名称为key
                    dicType.Add( pt.Name,pt.No );
                }
            }
            else {
                return;
            }
        
        }
        /// <summary>
        /// 初始化仓库列表
        /// </summary>
        /// <param name="cb"></param>
        public void setStorehouseItem( ComboBox cb ) {

            storeList = dbsm.getStorehouses();
            if (storeList != null)
            {
                foreach (Model.Storehouse sto in storeList)
                {
                    cb.Items.Add(sto.Sno);
                }
            }
            else {
                return;
            }
            
        }
        /// <summary>
        /// 初始化员工列表
        /// </summary>
        /// <param name="cb"></param>
        public void setEmployerItem(ComboBox cb) {
            ems = dbEm.getInEmployers();
            cb.DataSource = ems;
            cb.DisplayMember = "Emno";

        }

        public void setClientItem( ComboBox cb ) {

            List<Model.Client> clients = dbclient.getClients(1);
            cb.DataSource = clients;
            cb.DisplayMember = "Cname";

        }
        /// <summary>
        /// 入库
        /// </summary>
        /// <param name="stoInPro"></param>
        public void addStoreIn( Model.Product stoInPro ) {
            mPro = new Product();
            //先生成商品表(商品表：01-001-00003)
            string pno = stoInPro.ProStoNo+"-"+dicType[stoInPro.TypeName]+"-";
            stoInPro.Pno = this.getProductNo(stoInPro.ProStoNo, dicType[stoInPro.TypeName]);
            bool isAdd = dbsm.addProduct(stoInPro);
            if (isAdd)
            {
                //生成入库表
                BLLUtil.Output(this, "" + mPro.Pno);
                mStoreIn = new StoreIn();
                string pid = dbsm.getPid(stoInPro.Pname);
                if( !pid.Equals("") ){
                    mStoreIn.SiNo = this.getInNo( stoInPro.ProStoNo );
                    mStoreIn.PId = int.Parse( pid );
                    mStoreIn.Stype = stoInPro.StoInType;
                    mStoreIn.Pnum = int.Parse( stoInPro.Pnum ); 
                    mStoreIn.StoreNo = stoInPro.ProStoNo;
                    mStoreIn.SierNo = stoInPro.StoIner.Substring(0,8);
                    DateTime date = DateTime.Now;
                    mStoreIn.Optdate = date;
                    mStoreIn.IsCheck = stoInPro.IsCheck;
                    mStoreIn.ClientId = stoInPro.ClientId; 
                    string date1 =  date.Year.ToString() + date.Month.ToString() + date.Day.ToString() + date.Hour.ToString() + date.Minute.ToString() + date.Second.ToString();
                    BLLUtil.Output(this, "入库单：" + mStoreIn.SiNo + " " + mStoreIn.PId + " " + mStoreIn.Stype + " " + mStoreIn.Pnum + " " + mStoreIn.StoreNo + " " + mStoreIn.SierNo + " " + "////" + date1);
                    bool isUpdate = dbsm.addStoreIn(mStoreIn);
                    if (isUpdate)
                    {
                        if (mStoreIn.IsCheck)
                            MessageBox.Show("入库成功！");
                        else {
                            int num = dbsm.getInChecked();
                            productListner.isInCheck(num);
                            MessageBox.Show("入库成功，等待审核！");
                        }
                    }
                    else {
                        MessageBox.Show("商品信息有误，请重试！");
                    }
                }else{
                    MessageBox.Show("商品信息有误，请重试！");
                }
                
            }
            else {
                MessageBox.Show("商品信息异常，请重试！");
            }
            

        }
        /// <summary>
        /// 生成商品编号
        /// </summary>
        /// <param name="stoNo">仓库编号</param>
        /// <param name="typeNo">商品类型编号</param>
        /// <returns></returns>
        public string getProductNo( string stoNo,string typeNo ) {

            string id =( int.Parse( dbsm.getMaxPid() )+1 ).ToString();
            string no = id;
            if (!id.Equals("")) {
                int len = id.Length;
                for (int i = 0; i < 5-len;i++ )
                {
                    no = "0" + no;
                }
                BLLUtil.Output(this,"编号结果：" + no);

            }
            string pno = stoNo + "-" + typeNo + "-" + no ;
            return pno;
        }
        /// <summary>
        /// 生成入库单号
        /// </summary>
        /// <param name="stoNo">仓库编号</param>
        /// <returns></returns>
        private string getInNo(string stoNo) {

            DateTime date = DateTime.Now;
            string month = date.Month.ToString();
            if( date.Month < 10 ){
                month = "0" + month;
            }
            string day = date.Day.ToString();
            if( date.Day < 10 ){
                day = "0" + day;
            }
            string hour = date.Hour.ToString();
            if( date.Hour < 10 ){
                hour = "0" + hour;
            }
            string min = date.Minute.ToString();
            if( date.Minute <10 ){
                min = "0" + min;
            }
            string sec = date.Second.ToString();
            if( date.Second < 10 ){
                sec = "0"+sec;
            }
            string no = "1" + stoNo + "-" + date.Year.ToString() + month + day + hour +min + sec ;
            return no;
        }

        public void setAdjustCheckedLabel( Label lb )
        { 
            
        }
        public void setInCheckedLabel(Label lb)
        {
            lb.Text = dbsm.getInChecked().ToString();
        }
        public void setOutCheckLabel(Label lb) {
            lb.Text = dbsm.getOutChecked().ToString();
        }

    }
}
