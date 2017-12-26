using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Windows.Forms;
using System.Data;

namespace BLL
{
    public class BllClient : BLL.IClient
    {
        private DBClient client;
        public DBClient Client
        {
            get { return client; }
            set { client = value; }
        }
        private IChangedListener clientListener;
        

        public BllClient(IChangedListener clientListener) 
        {
            this.clientListener = clientListener;
            this.client = new DBClient();
        }
        public void setGridView(DataGridView drd,int typeId ) 
        {
            DataSet ds = client.getClientDataSet( typeId );
            if (ds != null) 
            {
                drd.DataSource = ds.Tables[0];
            }
        }
       
        public bool addClient(Model.Client client)
        {
            BLLUtil.Output(this,"添加用户方法中: "+client.ToString());
            bool isAdd = this.client.add(client);
            if (isAdd)
            {
                return true;
            }
            else
                return false;

        }

        public void deleteClient(List<Model.Client> clientList)
        {
            bool isdelete = this.client.delete(clientList);
            foreach( Model.Client ci in clientList ){
                BLLUtil.Output(this,"要删除的id: "+ci.Id);
            }
            if(isdelete)
            {
                clientListener.changed();
            }
        }

        public void updateClient(List<Model.Client> clientList) 
        {
            //DAL层
            this.client.update(clientList);
        }

        public void setClientTypeItem(ComboBox cb) {
            
        }
    }
}
