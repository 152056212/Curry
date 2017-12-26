using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Client
    {
        //客户编号
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        //客户名称(不能为空)
        private string cname = ""; 
        public string Cname
        {
            get { return cname; }
            set { cname = value; }
        }
        //客户类型（1.供应商；2.购货商）(不能为空)
        private int clientType = 1;
        public int ClientType
        {
            get { return clientType; }
            set { clientType = value; }
        }
        //客户联系人(不能为空)
        private string client_contact;
        public string Client_contact
        {
            get { return client_contact; }
            set { client_contact = value; }
        }
        //通信地址(不能为空)
        private string address;
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        //邮政编码
        private string postcode;
        public string Postcode
        {
            get { return postcode; }
            set { postcode = value; }
        }
        //联系电话(不能为空)
        private string phone;
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        //传真
        private string fax;
        public string Fax
        {
            get { return fax; }
            set { fax = value; }
        }
        //备注信息
        private string memo;
        public string Memo
        {
            get { return memo; }
            set { memo = value; }
        }

        public Client() 
        { 

        }
        public void clear() 
        {
            this.Cname = "";
            this.ClientType = 1;
            this.Client_contact = "";
            this.Address = "";
            this.Postcode = "";
            this.Phone = "";
            this.Fax = "";
            this.Memo = "";
        }

        public string ToString() 
        {
            return "姓名："+this.Cname + " 电话:" + this.Phone;
        }
    }
}
