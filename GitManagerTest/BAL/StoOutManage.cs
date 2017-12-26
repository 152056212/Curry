using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DAL;
using System.Windows.Forms;

namespace BLL
{
    public class StoOutManage
    {
        private DBStoreManage dbsm;
        private DBProType dbtype;
        private DBEmployer dbem;
        private DBStore dbSto;
        private DBClient dbClient;
        private List<Model.Product> products = new List<Product>();
        private List<Model.ProType> typeList = new List<ProType>();
        private List<Model.Employer> ems = new List<Employer>();
        private List<Model.Storehouse> stos = new List<Storehouse>();
        private List<Model.Client> clients = new List<Client>();
        private string sqlgetPriduct = " select * from Product ";
        private IProductListener productListener;

        public StoOutManage( IProductListener productListener ) {
            dbsm = new DBStoreManage();
            dbtype = new DBProType();
            dbem = new DBEmployer();
            dbSto = new DBStore();
            dbClient = new DBClient();
            this.productListener = productListener;
        }

        public void setProList( ComboBox cb ) {

            products = dbsm.getProList();
            cb.DataSource = products;
            cb.DisplayMember = "Pname";
        }
        public void setTypeItem( ComboBox cb ) {
            typeList = dbtype.getTypelistNew();
            cb.DataSource = typeList;
            cb.DisplayMember = "Name";

        }
        public void setEmployerItem(ComboBox cb) {
            ems = dbem.getInEmployers(2);
            cb.DataSource = ems;
            cb.DisplayMember = "Emno";

        }
        public void setStoItem(ComboBox cb) {
            stos = dbSto.getStoList();
            cb.DataSource = stos;
            cb.DisplayMember = "Sno";
        }
        public void setClientItem(ComboBox cb)
        {
            clients = dbClient.getClients(2);
            cb.DataSource = clients;
            cb.DisplayMember = "Cname";
        }
        /// <summary>
        /// 生成出库单号
        /// </summary>
        /// <param name="stoNo">仓库编号</param>
        /// <returns></returns>
        private string getOutNo(string stoNo)
        {

            DateTime date = DateTime.Now;
            string month = date.Month.ToString();
            if (date.Month < 10)
            {
                month = "0" + month;
            }
            string day = date.Day.ToString();
            if (date.Day < 10)
            {
                day = "0" + day;
            }
            string hour = date.Hour.ToString();
            if (date.Hour < 10)
            {
                hour = "0" + hour;
            }
            string min = date.Minute.ToString();
            if (date.Minute < 10)
            {
                min = "0" + min;
            }
            string sec = date.Second.ToString();
            if (date.Second < 10)
            {
                sec = "0" + sec;
            }
            string no = "0" + stoNo + "-" + date.Year.ToString() + month + day + hour + min + sec;
            return no;
        }
        /// <summary>
        /// 生成出库单
        /// </summary>
        /// <param name="stoOut"></param>
        /// <param name="oldNum">出库前的商品库存数</param>
        public void addStoOut(Model.StoreOut stoOut, int oldNum)
        {
            //1.初始化编号
            stoOut.SOno1 = this.getOutNo(stoOut.StoreNo);
            //2.初始化日期
            DateTime dt = DateTime.Now;
            stoOut.Optdate = dt;
            //出库
            bool isOut = dbsm.addStoreOut(stoOut,oldNum);
            if (isOut)
            {
                if (stoOut.IsCheck)
                {
                    MessageBox.Show("出库成功！");
                }
                else {
                    int num = dbsm.getOutChecked();
                    productListener.isOutCheck(num);
                    MessageBox.Show("出库成功，等待审核！");
                }

            }
            else {
                MessageBox.Show("出库失败！请检查出库信息是否正确！");
            }
        }

    }
}
