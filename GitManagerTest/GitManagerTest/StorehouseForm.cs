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
    public partial class StorehouseForm : BaseForm
    {
        private StoreManage stoManage;
        private int count;
        private List<int> listDel = new List<int>() { };
        private List<Model.Storehouse> stolist;
        private Dictionary<int, string> dicDel = new Dictionary<int, string>() { };
        private string beforeName = "";
        private string aferName = "";
        private int curIndex = 0;

        public StorehouseForm()
        {
            InitializeComponent();
            stoManage = new StoreManage();
        }
        private void StorehouseForm_Load(object sender, EventArgs e)
        {
            stolist = stoManage.getStoreList();
            for (int i = 0; i < stolist.Count; i++)
            {
                System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            stolist[i].Name }, 0, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("微软雅黑", 10.8F));
                listView1.Items.Add(listViewItem1);

            }
            this.stoManage.setDataGirdView(this.dataGridView1, stolist[0].Sno);
            dataGridView1.Columns[0].HeaderText = "编号";
            dataGridView1.Columns[1].HeaderText = "商品名称";
            dataGridView1.Columns[2].HeaderText = "商品类型";
            dataGridView1.Columns[3].HeaderText = "单位";
            dataGridView1.Columns[4].HeaderText = "价格";
            dataGridView1.Columns[5].HeaderText = "总数";
            
            
        }
        /// <summary>
        /// 添加仓库事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (listDel.Count != 0)
            {
                System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            dicDel[listDel[0]] }, 0, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("微软雅黑", 10.8F));
                
                if (listDel[0] < 10)
                {
                    bool isAdd = stoManage.addStore("0" + listDel[0].ToString(), dicDel[listDel[0]]);
                    if (isAdd)
                    {
                        MessageBox.Show("添加成功！");
                        this.listView1.Items.Add(listViewItem1);
                    }
                    
                }
                else {
                    bool isAdd = stoManage.addStore(listDel[0].ToString(), dicDel[listDel[0]]);
                    if (isAdd)
                    {
                        MessageBox.Show("添加成功！");
                        this.listView1.Items.Add(listViewItem1);

                    }
                    
                }
                dicDel.Remove(listDel[0]);
                listDel.RemoveAt(0);
                stolist = stoManage.getStoreList();
                UiUtil.Output(this,"还有："+listDel.Count+" 个");
                
            }
            else {
                int totalNum = listView1.Items.Count + 1;
                System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            " 仓库 "+ totalNum }, 0, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("微软雅黑", 10.8F));
                if (totalNum < 10)
                {
                   bool isAdd = stoManage.addStore("0" + totalNum.ToString(), " 仓库 " + totalNum);
                   if (isAdd)
                   {
                       MessageBox.Show("添加成功！");
                   }
                   else {
                       MessageBox.Show("已存在！请重命名！");
                   }
                }
                else {
                    bool isAdd =  stoManage.addStore(totalNum.ToString(), " 仓库 " + totalNum);
                    if (isAdd)
                    {
                        MessageBox.Show("添加成功！");
                    }
                    else
                    {
                        MessageBox.Show("已存在！请重命名！");
                    }
                }

                this.listView1.Items.Add(listViewItem1);
                for (int i = 0; i < listDel.Count;i++ )
                {
                    if (totalNum == listDel[i])
                    {
                        listDel.RemoveAt(i);
                        dicDel.Remove(listDel[i]);
                        break;
                    }
                }
            }
            
        }
        /// <summary>
        /// 打开仓库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
            for (int i = 0; i < listView1.Items.Count;i++ )
            {
                if( listView1.Items[i].Selected == true ){
                    this.stoManage.setDataGirdView(this.dataGridView1, stolist[i].Sno);
                    this.tabPage1.Text = "当前位置 -> "+stolist[i].Name;
                }
            }
            
        }
        /// <summary>
        /// 右键菜单--修改仓库上限值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItemModify_Click(object sender, EventArgs e)
        {
            SetHighValueForm highForm = new SetHighValueForm();
            DialogResult result = highForm.ShowDialog();
            int newHighValue = highForm.newHighValue;
            if( result == System.Windows.Forms.DialogResult.OK ){
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    
                    if (listView1.Items[i].Selected == true)
                    {
                        if (i < 10)
                        {
                            if( newHighValue!=-110 ){
                                //不是无效值
                                 stoManage.setHighValue( "0"+(i+1).ToString(),newHighValue.ToString() ) ;
                            }
                           
                        }
                        else
                        {
                             if( newHighValue!=-110 ){
                                //不是无效值
                                 stoManage.setHighValue((i + 1).ToString(), newHighValue.ToString());
                             }
                        }
                    }

                }
            }
            
        }
        /// <summary>
        /// 右键菜单--删除仓库事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItemDel_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listView1.Items.Count;i++ )
            {
                if (listView1.Items[i].Selected == true)
                {
                    UiUtil.Output(this, "右删除" + i);
                    curIndex = i;
                    DialogResult result = MessageBox.Show("确认删除？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
                    if (result == System.Windows.Forms.DialogResult.OK)
                    {
                        
                        bool isExists = false;
                        //将当前删除的item 对应的数值存起来
                        int curindex = RegeUtil.getNum(listView1.Items[i].Text.TrimEnd());
                        
                        if (curindex != -110) { 
                            //不是无效值时
                            for (int k = 0; k < listDel.Count; k++)
                            {
                                if (curindex == listDel[k])
                                {
                                    isExists = true;
                                }

                            }
                            if (!isExists)
                            {
                                listDel.Add(curindex);
                                int m = curindex + 1;
                                dicDel.Add(curindex, "仓库 " + curindex.ToString());
                                if (curindex < 10)
                                {
                                    stoManage.deleteStore("0" + curindex.ToString());
                                }else
                                    stoManage.deleteStore(curindex.ToString());
                                listView1.Items.RemoveAt(i);
                                break;
                            }
                            

                        }
                        
                    }
                }
            }
        }
        /// <summary>
        /// 右键菜单--重命名仓库事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItemReName_Click(object sender, EventArgs e)
        {
            for (int i=0; i < listView1.Items.Count;i++ )
            {
                if ( listView1.Items[i].Selected == true ){
                    listView1.Items[i].Focused = true;
                    listView1.LabelEdit = true;
                    listView1.FocusedItem.BeginEdit();
                    curIndex = i;
                    beforeName = listView1.FocusedItem.Text;
                    UiUtil.Output(this,"编辑："+beforeName);
                    break;
                }
            }
        }

        private void listView1_BeforeLabelEdit(object sender, LabelEditEventArgs e)
        {
            UiUtil.Output( this,""+e.Label );
        }

        private void listView1_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            UiUtil.Output(this, "之前："+beforeName+" 之后：" + e.Label);
            aferName = e.Label;
            if (stoManage != null) {
               bool isUpdate= stoManage.setName( beforeName,aferName  );
               if (isUpdate)
               {
                   MessageBox.Show("更新成功！");
                   stolist = stoManage.getStoreList();
               }
               else {
                   MessageBox.Show("数据更新异常，请重试！");
               }
            }
            
        }

        

    }
}
