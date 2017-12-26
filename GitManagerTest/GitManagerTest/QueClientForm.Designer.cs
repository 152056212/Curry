using System.Windows.Forms;
namespace GitManagerTest
{
    partial class QueClientInfoForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_query = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_fox = new System.Windows.Forms.TextBox();
            this.lb_fox = new System.Windows.Forms.Label();
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.lb_phone = new System.Windows.Forms.Label();
            this.tb_postcode = new System.Windows.Forms.TextBox();
            this.lb_postcode = new System.Windows.Forms.Label();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.lb_address = new System.Windows.Forms.Label();
            this.tb_contact = new System.Windows.Forms.TextBox();
            this.lb_contact = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.lb_name = new System.Windows.Forms.Label();
            this.cbb_type = new System.Windows.Forms.ComboBox();
            this.lb_type = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.btn_query);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tb_fox);
            this.panel1.Controls.Add(this.lb_fox);
            this.panel1.Controls.Add(this.tb_phone);
            this.panel1.Controls.Add(this.lb_phone);
            this.panel1.Controls.Add(this.tb_postcode);
            this.panel1.Controls.Add(this.lb_postcode);
            this.panel1.Controls.Add(this.tb_address);
            this.panel1.Controls.Add(this.lb_address);
            this.panel1.Controls.Add(this.tb_contact);
            this.panel1.Controls.Add(this.lb_contact);
            this.panel1.Controls.Add(this.tb_name);
            this.panel1.Controls.Add(this.lb_name);
            this.panel1.Controls.Add(this.cbb_type);
            this.panel1.Controls.Add(this.lb_type);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.MaximumSize = new System.Drawing.Size(1202, 900);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.panel1.Size = new System.Drawing.Size(1088, 736);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 157);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1067, 570);
            this.dataGridView1.TabIndex = 16;
            // 
            // btn_query
            // 
            this.btn_query.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(255)))));
            this.btn_query.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_query.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_query.Location = new System.Drawing.Point(830, 96);
            this.btn_query.Name = "btn_query";
            this.btn_query.Size = new System.Drawing.Size(220, 30);
            this.btn_query.TabIndex = 15;
            this.btn_query.Text = "一键查询";
            this.btn_query.UseVisualStyleBackColor = false;
            this.btn_query.Click += new System.EventHandler(this.btn_query_Click);
            this.btn_query.KeyDown += new System.Windows.Forms.KeyEventHandler(btn_query_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(32, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "------ ** 请在以下的输入框中输入您要查询的关键字 **------";
            // 
            // tb_fox
            // 
            this.tb_fox.Location = new System.Drawing.Point(646, 99);
            this.tb_fox.Name = "tb_fox";
            this.tb_fox.Size = new System.Drawing.Size(129, 25);
            this.tb_fox.TabIndex = 13;
            // 
            // lb_fox
            // 
            this.lb_fox.AutoSize = true;
            this.lb_fox.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_fox.Location = new System.Drawing.Point(575, 103);
            this.lb_fox.Name = "lb_fox";
            this.lb_fox.Size = new System.Drawing.Size(51, 17);
            this.lb_fox.TabIndex = 12;
            this.lb_fox.Text = "传真:";
            // 
            // tb_phone
            // 
            this.tb_phone.Location = new System.Drawing.Point(393, 101);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(129, 25);
            this.tb_phone.TabIndex = 11;
            // 
            // lb_phone
            // 
            this.lb_phone.AutoSize = true;
            this.lb_phone.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_phone.Location = new System.Drawing.Point(302, 103);
            this.lb_phone.Name = "lb_phone";
            this.lb_phone.Size = new System.Drawing.Size(85, 17);
            this.lb_phone.TabIndex = 10;
            this.lb_phone.Text = "联系电话:";
            // 
            // tb_postcode
            // 
            this.tb_postcode.Location = new System.Drawing.Point(127, 101);
            this.tb_postcode.Name = "tb_postcode";
            this.tb_postcode.Size = new System.Drawing.Size(120, 25);
            this.tb_postcode.TabIndex = 9;
            // 
            // lb_postcode
            // 
            this.lb_postcode.AutoSize = true;
            this.lb_postcode.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_postcode.Location = new System.Drawing.Point(29, 103);
            this.lb_postcode.Name = "lb_postcode";
            this.lb_postcode.Size = new System.Drawing.Size(85, 17);
            this.lb_postcode.TabIndex = 8;
            this.lb_postcode.Text = "邮政编码:";
            // 
            // tb_address
            // 
            this.tb_address.Location = new System.Drawing.Point(918, 50);
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(129, 25);
            this.tb_address.TabIndex = 7;
            // 
            // lb_address
            // 
            this.lb_address.AutoSize = true;
            this.lb_address.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_address.Location = new System.Drawing.Point(827, 54);
            this.lb_address.Name = "lb_address";
            this.lb_address.Size = new System.Drawing.Size(85, 17);
            this.lb_address.TabIndex = 6;
            this.lb_address.Text = "通信地址:";
            // 
            // tb_contact
            // 
            this.tb_contact.Location = new System.Drawing.Point(646, 50);
            this.tb_contact.Name = "tb_contact";
            this.tb_contact.Size = new System.Drawing.Size(129, 25);
            this.tb_contact.TabIndex = 5;
            // 
            // lb_contact
            // 
            this.lb_contact.AutoSize = true;
            this.lb_contact.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_contact.Location = new System.Drawing.Point(575, 54);
            this.lb_contact.Name = "lb_contact";
            this.lb_contact.Size = new System.Drawing.Size(68, 17);
            this.lb_contact.TabIndex = 4;
            this.lb_contact.Text = "联系人:";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(393, 51);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(129, 25);
            this.tb_name.TabIndex = 3;
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_name.Location = new System.Drawing.Point(302, 54);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(85, 17);
            this.lb_name.TabIndex = 2;
            this.lb_name.Text = "客户名称:";
            // 
            // cbb_type
            // 
            this.cbb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_type.FormattingEnabled = true;
            this.cbb_type.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbb_type.Items.AddRange(new object[] {
            "供应商",
            "购货商"});
            this.cbb_type.Location = new System.Drawing.Point(126, 52);
            this.cbb_type.Name = "cbb_type";
            this.cbb_type.Size = new System.Drawing.Size(121, 23);
            this.cbb_type.TabIndex = 1;
            // 
            // lb_type
            // 
            this.lb_type.AutoSize = true;
            this.lb_type.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_type.Location = new System.Drawing.Point(29, 55);
            this.lb_type.Name = "lb_type";
            this.lb_type.Size = new System.Drawing.Size(85, 17);
            this.lb_type.TabIndex = 0;
            this.lb_type.Text = "客户类型:";
            // 
            // QueClientInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1091, 740);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1220, 900);
            this.Name = "QueClientInfoForm";
            this.Text = "查询客户信息";
            this.Load += new System.EventHandler(this.QueClientInfoForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbb_type;
        private System.Windows.Forms.Label lb_type;
        private System.Windows.Forms.TextBox tb_address;
        private System.Windows.Forms.Label lb_address;
        private System.Windows.Forms.TextBox tb_contact;
        private System.Windows.Forms.Label lb_contact;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.TextBox tb_postcode;
        private System.Windows.Forms.Label lb_postcode;
        private System.Windows.Forms.TextBox tb_phone;
        private System.Windows.Forms.Label lb_phone;
        private System.Windows.Forms.TextBox tb_fox;
        private System.Windows.Forms.Label lb_fox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_query;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}