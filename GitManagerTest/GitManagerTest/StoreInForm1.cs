using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;

namespace GitManagerTest
{
    public partial class StoreInForm1 : Form,IChangedListener
    {
        private StoreInManage storeIn;
        private BllClient bclient;
        //存放单元格发生改变的Client
        private List<Model.Client> changelist = new List<Model.Client>() { };
        //存放原来的对象的集合
        private List<Model.Client> oldClients = new List<Model.Client>() { };
        
        //private List<Model.Client> oldClientsList = new List<Model.Client>() { };

        //存放选中的行对应的索引
        private List<int> listSelected ;
        private List<Model.Client> up_client_list = new List<Model.Client> { };

        public StoreInForm1( MainForm mainForm )
        {
            InitializeComponent();
            bclient = new BllClient(this);
            storeIn = new StoreInManage( mainForm );
        }
        /// <summary>
        /// 点击添加用户按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_add_Click(object sender, EventArgs e)
        {
            AddClientForm addClient = new AddClientForm(this, bclient);
            addClient.Show();
        }

        private void ClientInfoForm_Load(object sender, EventArgs e)
        {
            if (bclient != null) 
            {
                storeIn.initGridView(this.dataGridView1);
                dataGridView1.Columns[0].HeaderText = "入库单号";
                dataGridView1.Columns[1].HeaderText = "商品名称";
                dataGridView1.Columns[2].HeaderText = "入库类型";
                dataGridView1.Columns[3].HeaderText = "入库数量";
                dataGridView1.Columns[4].HeaderText = "仓库编号";
                dataGridView1.Columns[5].HeaderText = "入库员";
                dataGridView1.Columns[6].HeaderText = "入库日期";
                
            }
            this.btn_ok.Visible = false;
            this.btn_cancel.Visible = false;
        }
        /// <summary>
        /// 数据更新回调
        /// </summary>
        public void changed()
        {
            BLLUtil.Output(this, "数据更新回调 数据更新中。。。。。");
            removeCheckBox();
            bclient.setGridView(this.dataGridView1, 1);
            
        }
        /// <summary>
        /// 刷新按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_update_Click(object sender, EventArgs e)
        {
            if (dataGridView1.ColumnCount >= 10)
            {
                for (int i = 9; i < dataGridView1.ColumnCount; i++)
                {
                    dataGridView1.Columns.Remove(dataGridView1.Columns[i]);
                }
            }
            BLLUtil.Output(this, "数据更新中。。。。。" + dataGridView1.Columns.Count+"  "+dataGridView1.ColumnCount);
            bclient.setGridView(this.dataGridView1, 1);
            
        }
        /// <summary>
        /// 行标题点击事件
        /// 1.添加/删除一列checkbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left && e.Clicks == 1 && dataGridView1.ColumnCount == 9 )
            {
                this.addCheckBox();
            }
            else 
            {
                if (e.Button == System.Windows.Forms.MouseButtons.Left && e.Clicks == 1 )
                {
                    if (dataGridView1.ColumnCount >= 10) {
                        for (int i = 9; i < dataGridView1.ColumnCount;i++ )
                        {
                            dataGridView1.Columns.RemoveAt(i);
                        }
                    }
                }
            }

            
        }
        /// <summary>
        /// 添加checkbox列
        /// </summary>
        private void addCheckBox() 
        {
            //添加CheckBox列
            DataGridViewCheckBoxColumn columncb = new DataGridViewCheckBoxColumn();
            columncb.HeaderText = "选择";
            columncb.Name = "cb_check";
            columncb.TrueValue = true;
            columncb.FalseValue = false;
            this.dataGridView1.Columns.Add(columncb);
        }
        /// <summary>
        /// 移除checkbox列
        /// </summary>
        private void removeCheckBox() 
        {
            if (dataGridView1.ColumnCount >= 10)
            {
                for (int i = 9; i < dataGridView1.ColumnCount; i++)
                {
                    dataGridView1.Columns.RemoveAt(i);
                }
            }
        }
        /// <summary>
        /// 获取选中的checkbox对应的行
        /// </summary>
        /// <returns></returns>
        private List<int> getSelectCheckBox() 
        {
            List<int> listSelected = new List<int> { };
            if (this.dataGridView1.Columns.Count>9)
            {
                int numRows = dataGridView1.Rows.Count;
                int num = 0;
                UiUtil.Output(this,"Sum:"+numRows);
                listSelected.Clear();
                for (int i = 0; i < numRows; i++)
                {
                    DataGridViewCheckBoxCell chkBoxCell = (DataGridViewCheckBoxCell)dataGridView1.Rows[i].Cells[9];

                    if (chkBoxCell != null && ((bool)chkBoxCell.FormattedValue == true || (bool)chkBoxCell.EditingCellFormattedValue == true))
                    {
                        UiUtil.Output(this, "NO." + (i + 1) + " chkBoxCell.EditingCellFormattedValue之后: " + (bool)chkBoxCell.EditingCellFormattedValue + "   chkBoxCell.FormattedValue之前：" + (bool)chkBoxCell.FormattedValue);
                        listSelected.Add(i);
                        num++;
                    }
                    //|| (bool)chkBoxCell.FormattedValue == true (bool)chkBoxCell.EditingCellFormattedValue == true
                }
                UiUtil.Output(this, "" + num);
                
            }
            return listSelected;
            
        }
        
        /// <summary>
        /// 删除按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_clientFo_delete_Click(object sender, EventArgs e)
        {
            UiUtil.Output(this,"点击了删除按钮！");
            //1.是否出现 checkbox
            if (dataGridView1.ColumnCount >= 10)
            {
                if (dataGridView1.ColumnCount > 10) {
                    for (int i = 10; i < dataGridView1.ColumnCount; i++)
                    {
                        //dataGridView1.Columns.Remove(dataGridView1.Columns[i]);
                        dataGridView1.Columns.RemoveAt(i);
                    }
                }
                //this.addCheckBox();
                this.btn_cancel.Visible = false;
                this.btn_ok.Visible = false;
                //MessageBox.Show("请选择要删除的内容！");
                DialogResult result = MessageBox.Show("确认删除？","提示",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning,MessageBoxDefaultButton.Button2);
                if(result == DialogResult.OK)
                {
                    //2.出现：删除 checkbox 对应的行（提示确认删除）
                    listSelected = getSelectCheckBox();
                    if (listSelected.Count != 0)
                    {
                        List<Model.Client> cList = new List<Model.Client> { };
                        foreach (int index in listSelected)
                        {
                            string id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                            UiUtil.Output(this, "选中的索引：" + index + " id: " + id);
                            Model.Client mClient = new Model.Client();
                            mClient.Id = int.Parse(id);
                            cList.Add(mClient);
                        }
                        if (cList.Count != 0)
                        {
                            //逻辑层删除
                            bclient.deleteClient(cList);
                            //this.oldClientsList.Clear();
                            this.changelist.Clear();
                            this.oldClients.Clear();
                            
                            for (int i = 0; i < dataGridView1.RowCount;i++ )
                            {
                                for (int k = 0; k < dataGridView1.Rows[i].Cells.Count;k++ )
                                {
                                    UiUtil.Output(this, "确认了删除之后："+k+" " + dataGridView1.Rows[i].Cells[k].Value.ToString());
                                }
                            }
                            //bclient.setGridView(this.dataGridView1);                        
                        }
                    }
                    else {
                        MessageBox.Show("未选中内容！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                  }
            }
            else 
            {
                this.addCheckBox();
                MessageBox.Show("请选择要删除的内容！");
            }
        }

        /// <summary>
        /// 列标题点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            UiUtil.Output(this, "列索引：" + e.ColumnIndex);
            if (this.dataGridView1.Columns.Count > 9)
            {
                if (e.ColumnIndex == 9 && dataGridView1.Columns[9].HeaderText.Equals("全选"))
                {
                    UiUtil.Output(this,"点击了 全选 ！");
                    string type = dataGridView1.Columns[9].GetType().ToString();
                    DataGridViewCheckBoxColumn dr = ((DataGridViewCheckBoxColumn)dataGridView1.Columns[9]);
                    dr.TrueValue = true;
                    UiUtil.Output(this, "类型" + type + " " + dr.TrueValue);
                    for (int i = 0; i < dataGridView1.Rows.Count;i++ )
                    {
                        DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)dataGridView1.Rows[i].Cells[9];
                        Boolean flag = Convert.ToBoolean(checkCell.EditedFormattedValue);
                        UiUtil.Output(this,"NO."+i+" "+flag);

                        if (flag == false)
                        {
                            UiUtil.Output(this, "" + dataGridView1.Rows[i].Cells[9].ToString());
                            Boolean ifalse = (Boolean)true;
                            checkCell.Value = (object)ifalse;
                        }
                    }
                }
            }
           
        }
        /// <summary>
        /// 全选单元格点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if( e.ColumnIndex == 9  )
            {
                dataGridView1.Columns[9].HeaderText = "全选";
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            UiUtil.Output(this,"值改变了！");

            if ( e.ColumnIndex != 9 && e.RowIndex!=-1 && e.ColumnIndex !=-1 ) 
            {
                UiUtil.Output(this, " " + "id: " + dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() + " " + e.ColumnIndex + "," + e.RowIndex);
                Model.Client changeClient = new Model.Client();
                changeClient.Id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                changeClient.Cname = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                if (dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString().TrimEnd(' ').Equals("1"))
                {
                    changeClient.ClientType = 1;
                }
                else {
                    if (dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString().TrimEnd(' ').Equals("2"))
                    {
                        changeClient.ClientType = 2;
                    }
                    else {
                        MessageBox.Show("客户类型格式有误(可选类型：1(供应商)/2(购货商))","警告",MessageBoxButtons.RetryCancel,MessageBoxIcon.Error);
                    }
                    
                }
                changeClient.Client_contact = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                changeClient.Address = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                changeClient.Postcode = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                if (RegeUtil.isPhoneNum(dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString().TrimEnd(' ')))
                {
                    changeClient.Phone = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString().TrimEnd(' ');
                }
                else {
                    DialogResult result = MessageBox.Show("手机号码格式有误！(可能包含空格等非法字符)", "提示", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (result == System.Windows.Forms.DialogResult.Cancel) {
                        dataGridView1.Rows[e.RowIndex].Cells[6].Value = "";
                    }
                }
                changeClient.Fax = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                changeClient.Memo = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                int index = getClient(changeClient);
                if (index == -1)
                {
                    //没有就添加
                    changelist.Add(changeClient);
                }
                else {
                    //有就修改
                    this.setClient(changelist[index], changeClient);
                }
                UiUtil.Output(this, "值改变了： " + changeClient.Fax + " "+index);
                //在即将发生改变的对象集合中更新改变
                //this.setClient(oldClientsList[index],changeClient);
            }

        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if( e.KeyCode == Keys.Enter )
            {
                UiUtil.Output(this,"回车键！");
            }
        }
        /// <summary>
        /// 修改按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_modify_Click(object sender, EventArgs e)
        {
            if (dataGridView1.ColumnCount >= 10)
            {
                for (int i = 9; i < dataGridView1.ColumnCount; i++)
                {
                    dataGridView1.Columns.Remove(dataGridView1.Columns[i]);
                }
            }

            MessageBox.Show("点击任意单元格进行修改！","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.btn_cancel.Visible = true;
            this.btn_ok.Visible = true;
            for (int i = 0; i < dataGridView1.Rows.Count;i++ )
            {
                Model.Client oldclient = this.getClient(dataGridView1.Rows[i]);
                //修改为：只有单元格的值改变的时候再修改
                //备份点击修改按钮之前的状态
                oldClients.Add(oldclient);
            
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确认修改吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                //更新数据库
                if (changelist.Count != 0)
                {
                    this.bclient.updateClient(changelist);
                    //并更新表
                    BLLUtil.Output(this, "数据更新中。。。。。");
                    bclient.setGridView(this.dataGridView1, 1);
                    changelist.Clear();
                    oldClients.Clear();
                }
                else
                {
                    MessageBox.Show("选中内容为空，未作修改！","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                this.btn_cancel.Visible = false;
                this.btn_ok.Visible = false;
            }
            else { 
                
            }

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            BLLUtil.Output(this, "数据更新中。。。。。");
            bclient.setGridView(this.dataGridView1, 1);
            this.btn_ok.Visible = false;
            this.btn_cancel.Visible = false;
        }

        private Model.Client getClient( DataGridViewRow row ) {

            //UiUtil.Output(this,"是null吗？" + row.Cells[0].Value.ToString());
            if ( row.Cells[0].Value != null)
            {
                Model.Client oldClient = new Model.Client();
                oldClient.Id = int.Parse(row.Cells[0].Value.ToString());
                oldClient.Cname = row.Cells[1].Value.ToString();
                if (row.Cells[2].Value.ToString().Equals("供应商"))
                {
                    oldClient.ClientType = 1;
                }
                else
                {
                    oldClient.ClientType = 2;
                }
                oldClient.Client_contact = row.Cells[3].Value.ToString();
                oldClient.Address = row.Cells[4].Value.ToString();
                oldClient.Postcode = row.Cells[5].Value.ToString();
                oldClient.Phone = row.Cells[6].Value.ToString();
                oldClient.Fax = row.Cells[7].Value.ToString();
                oldClient.Memo = row.Cells[8].Value.ToString();
                return oldClient;
            }
            else { return null; }
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UiUtil.Output( this,"单元格点击了,所在："+e.ColumnIndex );
            //1.假设此单元格对象要发生改变
            //2.将其存放在集合中
            //3.如果原来就存在，则不存放
            //4.否则存放
            if (e.RowIndex != -1 && e.ColumnIndex !=9 && e.ColumnIndex !=-1 )
            {
                //单元格对应的对象
                Model.Client old = getClient(dataGridView1.Rows[e.RowIndex]);
                if (old != null) {
                    //判断发生改变的对象集合中是否存在此对象
                    int index = getClient(old);
                    if (index == -1)
                    {
                        //不存在时
                        //oldClientsList.Add(old);
                        changelist.Add(old);
                        UiUtil.Output(this, "单元格点击了 index:" + index + " " + old.Id);
                    }
                }
            }
                
        }

        private int getClient( Model.Client client ) 
        {
            if (changelist.Count != 0)
            {
                for (int i = 0; i < changelist.Count;i++ )
                {
                    if (client.Id == changelist[i].Id) {
                        return i;
                    }
                }
            }
            return -1;
        }

        private Model.Client setClient(Model.Client newClient,Model.Client oldClient) 
        {
            newClient.Id = oldClient.Id;
            newClient.Cname = oldClient.Cname;
            newClient.ClientType = oldClient.ClientType;
            newClient.Client_contact = oldClient.Client_contact;
            newClient.Phone = oldClient.Phone;
            newClient.Postcode = oldClient.Postcode;
            newClient.Fax = oldClient.Fax;
            newClient.Memo = oldClient.Memo;
            UiUtil.Output(this,"旧Fax："+oldClient.Fax+" 新Fax："+newClient.Fax);
            return newClient;
        }

    }
}
