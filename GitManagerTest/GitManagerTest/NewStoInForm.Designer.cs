namespace GitManagerTest
{
    partial class NewStoInForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_stointype = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_unit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_alarmDays = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_valid = new System.Windows.Forms.TextBox();
            this.lb_valid = new System.Windows.Forms.Label();
            this.cb_eminer = new System.Windows.Forms.ComboBox();
            this.cb_storeNo = new System.Windows.Forms.ComboBox();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.bt_ok = new System.Windows.Forms.Button();
            this.lb_memo = new System.Windows.Forms.Label();
            this.lb_fax = new System.Windows.Forms.Label();
            this.lb_phone = new System.Windows.Forms.Label();
            this.tb_num = new System.Windows.Forms.TextBox();
            this.lb_postcode = new System.Windows.Forms.Label();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.lb_price = new System.Windows.Forms.Label();
            this.tb_style = new System.Windows.Forms.TextBox();
            this.lb_style = new System.Windows.Forms.Label();
            this.cb_type = new System.Windows.Forms.ComboBox();
            this.lb_type = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.lb_name = new System.Windows.Forms.Label();
            this.cb_clients = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rb_check = new System.Windows.Forms.RadioButton();
            this.rb_notcheck = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rb_notcheck);
            this.panel1.Controls.Add(this.rb_check);
            this.panel1.Controls.Add(this.cb_clients);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cb_stointype);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tb_unit);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tb_alarmDays);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tb_valid);
            this.panel1.Controls.Add(this.lb_valid);
            this.panel1.Controls.Add(this.cb_eminer);
            this.panel1.Controls.Add(this.cb_storeNo);
            this.panel1.Controls.Add(this.bt_cancel);
            this.panel1.Controls.Add(this.bt_ok);
            this.panel1.Controls.Add(this.lb_memo);
            this.panel1.Controls.Add(this.lb_fax);
            this.panel1.Controls.Add(this.lb_phone);
            this.panel1.Controls.Add(this.tb_num);
            this.panel1.Controls.Add(this.lb_postcode);
            this.panel1.Controls.Add(this.tb_price);
            this.panel1.Controls.Add(this.lb_price);
            this.panel1.Controls.Add(this.tb_style);
            this.panel1.Controls.Add(this.lb_style);
            this.panel1.Controls.Add(this.cb_type);
            this.panel1.Controls.Add(this.lb_type);
            this.panel1.Controls.Add(this.tb_name);
            this.panel1.Controls.Add(this.lb_name);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(703, 576);
            this.panel1.TabIndex = 0;
            // 
            // cb_stointype
            // 
            this.cb_stointype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_stointype.FormattingEnabled = true;
            this.cb_stointype.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.cb_stointype.Items.AddRange(new object[] {
            "采购入库",
            "退购入库"});
            this.cb_stointype.Location = new System.Drawing.Point(477, 414);
            this.cb_stointype.Name = "cb_stointype";
            this.cb_stointype.Size = new System.Drawing.Size(144, 23);
            this.cb_stointype.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(379, 420);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "入库类型: ";
            // 
            // tb_unit
            // 
            this.tb_unit.Location = new System.Drawing.Point(474, 189);
            this.tb_unit.Name = "tb_unit";
            this.tb_unit.Size = new System.Drawing.Size(144, 25);
            this.tb_unit.TabIndex = 30;
            this.tb_unit.Text = "个";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(373, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "单位: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(86, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 15);
            this.label2.TabIndex = 28;
            this.label2.Text = "---距到期时刻还剩几天便提醒您！---";
            // 
            // tb_alarmDays
            // 
            this.tb_alarmDays.Location = new System.Drawing.Point(181, 326);
            this.tb_alarmDays.Name = "tb_alarmDays";
            this.tb_alarmDays.Size = new System.Drawing.Size(169, 25);
            this.tb_alarmDays.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(80, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "提醒: ";
            // 
            // tb_valid
            // 
            this.tb_valid.Location = new System.Drawing.Point(474, 326);
            this.tb_valid.Name = "tb_valid";
            this.tb_valid.Size = new System.Drawing.Size(144, 25);
            this.tb_valid.TabIndex = 25;
            // 
            // lb_valid
            // 
            this.lb_valid.AutoSize = true;
            this.lb_valid.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_valid.Location = new System.Drawing.Point(373, 329);
            this.lb_valid.Name = "lb_valid";
            this.lb_valid.Size = new System.Drawing.Size(77, 17);
            this.lb_valid.TabIndex = 24;
            this.lb_valid.Text = "有效期: ";
            // 
            // cb_eminer
            // 
            this.cb_eminer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_eminer.FormattingEnabled = true;
            this.cb_eminer.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.cb_eminer.Location = new System.Drawing.Point(181, 260);
            this.cb_eminer.Name = "cb_eminer";
            this.cb_eminer.Size = new System.Drawing.Size(169, 23);
            this.cb_eminer.TabIndex = 23;
            // 
            // cb_storeNo
            // 
            this.cb_storeNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_storeNo.FormattingEnabled = true;
            this.cb_storeNo.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.cb_storeNo.Location = new System.Drawing.Point(474, 258);
            this.cb_storeNo.Name = "cb_storeNo";
            this.cb_storeNo.Size = new System.Drawing.Size(144, 23);
            this.cb_storeNo.TabIndex = 22;
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(416, 519);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Padding = new System.Windows.Forms.Padding(3);
            this.bt_cancel.Size = new System.Drawing.Size(138, 30);
            this.bt_cancel.TabIndex = 21;
            this.bt_cancel.Text = "取消";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // bt_ok
            // 
            this.bt_ok.Location = new System.Drawing.Point(181, 519);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Padding = new System.Windows.Forms.Padding(3);
            this.bt_ok.Size = new System.Drawing.Size(144, 30);
            this.bt_ok.TabIndex = 20;
            this.bt_ok.Text = "确认";
            this.bt_ok.UseVisualStyleBackColor = true;
            this.bt_ok.Click += new System.EventHandler(this.bt_ok_Click);
            // 
            // lb_memo
            // 
            this.lb_memo.AutoSize = true;
            this.lb_memo.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_memo.Location = new System.Drawing.Point(80, 337);
            this.lb_memo.Name = "lb_memo";
            this.lb_memo.Size = new System.Drawing.Size(0, 17);
            this.lb_memo.TabIndex = 18;
            // 
            // lb_fax
            // 
            this.lb_fax.AutoSize = true;
            this.lb_fax.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_fax.Location = new System.Drawing.Point(80, 266);
            this.lb_fax.Name = "lb_fax";
            this.lb_fax.Size = new System.Drawing.Size(77, 17);
            this.lb_fax.TabIndex = 14;
            this.lb_fax.Text = "入库员: ";
            // 
            // lb_phone
            // 
            this.lb_phone.AutoSize = true;
            this.lb_phone.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_phone.Location = new System.Drawing.Point(373, 264);
            this.lb_phone.Name = "lb_phone";
            this.lb_phone.Size = new System.Drawing.Size(60, 17);
            this.lb_phone.TabIndex = 12;
            this.lb_phone.Text = "库号: ";
            // 
            // tb_num
            // 
            this.tb_num.Location = new System.Drawing.Point(181, 189);
            this.tb_num.Name = "tb_num";
            this.tb_num.Size = new System.Drawing.Size(169, 25);
            this.tb_num.TabIndex = 11;
            // 
            // lb_postcode
            // 
            this.lb_postcode.AutoSize = true;
            this.lb_postcode.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_postcode.Location = new System.Drawing.Point(80, 193);
            this.lb_postcode.Name = "lb_postcode";
            this.lb_postcode.Size = new System.Drawing.Size(60, 17);
            this.lb_postcode.TabIndex = 10;
            this.lb_postcode.Text = "数量: ";
            // 
            // tb_price
            // 
            this.tb_price.Location = new System.Drawing.Point(474, 126);
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(144, 25);
            this.tb_price.TabIndex = 9;
            // 
            // lb_price
            // 
            this.lb_price.AutoSize = true;
            this.lb_price.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_price.Location = new System.Drawing.Point(373, 130);
            this.lb_price.Name = "lb_price";
            this.lb_price.Size = new System.Drawing.Size(60, 17);
            this.lb_price.TabIndex = 8;
            this.lb_price.Text = "单价: ";
            // 
            // tb_style
            // 
            this.tb_style.Location = new System.Drawing.Point(181, 126);
            this.tb_style.Name = "tb_style";
            this.tb_style.Size = new System.Drawing.Size(169, 25);
            this.tb_style.TabIndex = 7;
            this.tb_style.Text = "GB";
            // 
            // lb_style
            // 
            this.lb_style.AutoSize = true;
            this.lb_style.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_style.Location = new System.Drawing.Point(80, 130);
            this.lb_style.Name = "lb_style";
            this.lb_style.Size = new System.Drawing.Size(60, 17);
            this.lb_style.TabIndex = 6;
            this.lb_style.Text = "规格: ";
            // 
            // cb_type
            // 
            this.cb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_type.FormattingEnabled = true;
            this.cb_type.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.cb_type.Location = new System.Drawing.Point(474, 69);
            this.cb_type.Name = "cb_type";
            this.cb_type.Size = new System.Drawing.Size(144, 23);
            this.cb_type.TabIndex = 5;
            // 
            // lb_type
            // 
            this.lb_type.AutoSize = true;
            this.lb_type.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_type.Location = new System.Drawing.Point(373, 69);
            this.lb_type.Name = "lb_type";
            this.lb_type.Size = new System.Drawing.Size(94, 17);
            this.lb_type.TabIndex = 4;
            this.lb_type.Text = "商品类型: ";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(181, 65);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(169, 25);
            this.tb_name.TabIndex = 1;
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_name.Location = new System.Drawing.Point(80, 69);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(94, 17);
            this.lb_name.TabIndex = 0;
            this.lb_name.Text = "商品名称: ";
            // 
            // cb_clients
            // 
            this.cb_clients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_clients.FormattingEnabled = true;
            this.cb_clients.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.cb_clients.Items.AddRange(new object[] {
            "采购入库",
            "退购入库"});
            this.cb_clients.Location = new System.Drawing.Point(181, 419);
            this.cb_clients.Name = "cb_clients";
            this.cb_clients.Size = new System.Drawing.Size(170, 23);
            this.cb_clients.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(86, 425);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 33;
            this.label5.Text = "供应商: ";
            // 
            // rb_check
            // 
            this.rb_check.AutoSize = true;
            this.rb_check.Location = new System.Drawing.Point(292, 478);
            this.rb_check.Name = "rb_check";
            this.rb_check.Size = new System.Drawing.Size(58, 19);
            this.rb_check.TabIndex = 35;
            this.rb_check.TabStop = true;
            this.rb_check.Text = "审核";
            this.rb_check.UseVisualStyleBackColor = true;
            // 
            // rb_notcheck
            // 
            this.rb_notcheck.AutoSize = true;
            this.rb_notcheck.Location = new System.Drawing.Point(392, 478);
            this.rb_notcheck.Name = "rb_notcheck";
            this.rb_notcheck.Size = new System.Drawing.Size(73, 19);
            this.rb_notcheck.TabIndex = 36;
            this.rb_notcheck.TabStop = true;
            this.rb_notcheck.Text = "待审核";
            this.rb_notcheck.UseVisualStyleBackColor = true;
            // 
            // NewStoInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 583);
            this.Controls.Add(this.panel1);
            this.Name = "NewStoInForm";
            this.Text = "新建入库单";
            this.Load += new System.EventHandler(this.NewStoInForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.ComboBox cb_type;
        private System.Windows.Forms.Label lb_type;
        private System.Windows.Forms.TextBox tb_style;
        private System.Windows.Forms.Label lb_style;
        private System.Windows.Forms.TextBox tb_price;
        private System.Windows.Forms.Label lb_price;
        private System.Windows.Forms.TextBox tb_num;
        private System.Windows.Forms.Label lb_postcode;
        private System.Windows.Forms.Label lb_phone;
        private System.Windows.Forms.Label lb_fax;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.Button bt_ok;
        private System.Windows.Forms.Label lb_memo;
        private System.Windows.Forms.ComboBox cb_storeNo;
        private System.Windows.Forms.ComboBox cb_eminer;
        private System.Windows.Forms.TextBox tb_alarmDays;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_valid;
        private System.Windows.Forms.Label lb_valid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_unit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_stointype;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_clients;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rb_notcheck;
        private System.Windows.Forms.RadioButton rb_check;
    }
}