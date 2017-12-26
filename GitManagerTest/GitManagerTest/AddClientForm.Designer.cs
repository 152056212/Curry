namespace GitManagerTest
{
    partial class AddClientForm
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
            this.bt_cancel = new System.Windows.Forms.Button();
            this.bt_ok = new System.Windows.Forms.Button();
            this.tb_memo = new System.Windows.Forms.TextBox();
            this.lb_memo = new System.Windows.Forms.Label();
            this.tb_fax = new System.Windows.Forms.TextBox();
            this.lb_fax = new System.Windows.Forms.Label();
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.lb_phone = new System.Windows.Forms.Label();
            this.tb_postcode = new System.Windows.Forms.TextBox();
            this.lb_postcode = new System.Windows.Forms.Label();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.lb_address = new System.Windows.Forms.Label();
            this.tb_contact = new System.Windows.Forms.TextBox();
            this.lb_contact = new System.Windows.Forms.Label();
            this.cb_type = new System.Windows.Forms.ComboBox();
            this.lb_type = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.lb_name = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_cancel);
            this.panel1.Controls.Add(this.bt_ok);
            this.panel1.Controls.Add(this.tb_memo);
            this.panel1.Controls.Add(this.lb_memo);
            this.panel1.Controls.Add(this.tb_fax);
            this.panel1.Controls.Add(this.lb_fax);
            this.panel1.Controls.Add(this.tb_phone);
            this.panel1.Controls.Add(this.lb_phone);
            this.panel1.Controls.Add(this.tb_postcode);
            this.panel1.Controls.Add(this.lb_postcode);
            this.panel1.Controls.Add(this.tb_address);
            this.panel1.Controls.Add(this.lb_address);
            this.panel1.Controls.Add(this.tb_contact);
            this.panel1.Controls.Add(this.lb_contact);
            this.panel1.Controls.Add(this.cb_type);
            this.panel1.Controls.Add(this.lb_type);
            this.panel1.Controls.Add(this.tb_name);
            this.panel1.Controls.Add(this.lb_name);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(703, 528);
            this.panel1.TabIndex = 0;
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(457, 476);
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
            this.bt_ok.Location = new System.Drawing.Point(186, 476);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Padding = new System.Windows.Forms.Padding(3);
            this.bt_ok.Size = new System.Drawing.Size(144, 30);
            this.bt_ok.TabIndex = 20;
            this.bt_ok.Text = "确认";
            this.bt_ok.UseVisualStyleBackColor = true;
            this.bt_ok.Click += new System.EventHandler(this.bt_ok_Click);
            // 
            // tb_memo
            // 
            this.tb_memo.Location = new System.Drawing.Point(181, 333);
            this.tb_memo.Multiline = true;
            this.tb_memo.Name = "tb_memo";
            this.tb_memo.Size = new System.Drawing.Size(437, 119);
            this.tb_memo.TabIndex = 19;
            // 
            // lb_memo
            // 
            this.lb_memo.AutoSize = true;
            this.lb_memo.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_memo.Location = new System.Drawing.Point(80, 337);
            this.lb_memo.Name = "lb_memo";
            this.lb_memo.Size = new System.Drawing.Size(60, 17);
            this.lb_memo.TabIndex = 18;
            this.lb_memo.Text = "备注: ";
            // 
            // tb_fax
            // 
            this.tb_fax.Location = new System.Drawing.Point(181, 266);
            this.tb_fax.Name = "tb_fax";
            this.tb_fax.Size = new System.Drawing.Size(144, 25);
            this.tb_fax.TabIndex = 15;
            // 
            // lb_fax
            // 
            this.lb_fax.AutoSize = true;
            this.lb_fax.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_fax.Location = new System.Drawing.Point(80, 270);
            this.lb_fax.Name = "lb_fax";
            this.lb_fax.Size = new System.Drawing.Size(60, 17);
            this.lb_fax.TabIndex = 14;
            this.lb_fax.Text = "传真: ";
            // 
            // tb_phone
            // 
            this.tb_phone.Location = new System.Drawing.Point(474, 189);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(144, 25);
            this.tb_phone.TabIndex = 13;
            // 
            // lb_phone
            // 
            this.lb_phone.AutoSize = true;
            this.lb_phone.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_phone.Location = new System.Drawing.Point(373, 193);
            this.lb_phone.Name = "lb_phone";
            this.lb_phone.Size = new System.Drawing.Size(94, 17);
            this.lb_phone.TabIndex = 12;
            this.lb_phone.Text = "联系电话: ";
            // 
            // tb_postcode
            // 
            this.tb_postcode.Location = new System.Drawing.Point(181, 189);
            this.tb_postcode.Name = "tb_postcode";
            this.tb_postcode.Size = new System.Drawing.Size(144, 25);
            this.tb_postcode.TabIndex = 11;
            // 
            // lb_postcode
            // 
            this.lb_postcode.AutoSize = true;
            this.lb_postcode.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_postcode.Location = new System.Drawing.Point(80, 193);
            this.lb_postcode.Name = "lb_postcode";
            this.lb_postcode.Size = new System.Drawing.Size(94, 17);
            this.lb_postcode.TabIndex = 10;
            this.lb_postcode.Text = "邮政编码: ";
            // 
            // tb_address
            // 
            this.tb_address.Location = new System.Drawing.Point(474, 126);
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(144, 25);
            this.tb_address.TabIndex = 9;
            // 
            // lb_address
            // 
            this.lb_address.AutoSize = true;
            this.lb_address.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_address.Location = new System.Drawing.Point(373, 130);
            this.lb_address.Name = "lb_address";
            this.lb_address.Size = new System.Drawing.Size(94, 17);
            this.lb_address.TabIndex = 8;
            this.lb_address.Text = "联系地址: ";
            // 
            // tb_contact
            // 
            this.tb_contact.Location = new System.Drawing.Point(181, 126);
            this.tb_contact.Name = "tb_contact";
            this.tb_contact.Size = new System.Drawing.Size(144, 25);
            this.tb_contact.TabIndex = 7;
            // 
            // lb_contact
            // 
            this.lb_contact.AutoSize = true;
            this.lb_contact.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_contact.Location = new System.Drawing.Point(80, 130);
            this.lb_contact.Name = "lb_contact";
            this.lb_contact.Size = new System.Drawing.Size(77, 17);
            this.lb_contact.TabIndex = 6;
            this.lb_contact.Text = "联系人: ";
            // 
            // cb_type
            // 
            this.cb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_type.FormattingEnabled = true;
            this.cb_type.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.cb_type.Items.AddRange(new object[] {
            "供应商",
            "购货商"});
            this.cb_type.Location = new System.Drawing.Point(474, 69);
            this.cb_type.Name = "cb_type";
            this.cb_type.Size = new System.Drawing.Size(144, 23);
            this.cb_type.TabIndex = 5;
            this.cb_type.Text = "供应商";
            // 
            // lb_type
            // 
            this.lb_type.AutoSize = true;
            this.lb_type.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_type.Location = new System.Drawing.Point(373, 69);
            this.lb_type.Name = "lb_type";
            this.lb_type.Size = new System.Drawing.Size(94, 17);
            this.lb_type.TabIndex = 4;
            this.lb_type.Text = "客户类型: ";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(181, 65);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(144, 25);
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
            this.lb_name.Text = "客户姓名: ";
            // 
            // AddClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 531);
            this.Controls.Add(this.panel1);
            this.Name = "AddClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddClientForm";
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
        private System.Windows.Forms.TextBox tb_contact;
        private System.Windows.Forms.Label lb_contact;
        private System.Windows.Forms.TextBox tb_address;
        private System.Windows.Forms.Label lb_address;
        private System.Windows.Forms.TextBox tb_postcode;
        private System.Windows.Forms.Label lb_postcode;
        private System.Windows.Forms.TextBox tb_phone;
        private System.Windows.Forms.Label lb_phone;
        private System.Windows.Forms.TextBox tb_fax;
        private System.Windows.Forms.Label lb_fax;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.Button bt_ok;
        private System.Windows.Forms.TextBox tb_memo;
        private System.Windows.Forms.Label lb_memo;
    }
}