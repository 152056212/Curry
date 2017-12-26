using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GitManagerTest
{
    public partial class SetHighValueForm : BaseForm
    {
        public int newHighValue = -110;

        public SetHighValueForm()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            string str = tb_highValue.Text;
            if (str.Length != 0)
            {
                UiUtil.Output(this, "数字:" + str);
                bool isNum = RegeUtil.isNum(str);
                if (isNum)
                {
                    int newValue = int.Parse(str);
                    newHighValue = newValue;
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    UiUtil.Output(this, "数字:" + newValue);
                }
                else
                {
                    MessageBox.Show("输入值含有非法字符！");
                    this.DialogResult = System.Windows.Forms.DialogResult.None;
                }
            }
            else {
                MessageBox.Show("请输入有效值！");
                this.DialogResult = System.Windows.Forms.DialogResult.None;

            }
            
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
