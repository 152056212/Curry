namespace GitManagerTest
{
    partial class StoreInForm1
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
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_modify = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_clientFo_delete = new System.Windows.Forms.Button();
            this.btn_clientFo_new = new System.Windows.Forms.Button();
            this.btn_clientFo_query = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lb_clientType = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_ok);
            this.panel1.Controls.Add(this.btn_cancel);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.MaximumSize = new System.Drawing.Size(960, 610);
            this.panel1.MinimumSize = new System.Drawing.Size(931, 606);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 610);
            this.panel1.TabIndex = 0;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(325, 567);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(102, 28);
            this.btn_ok.TabIndex = 5;
            this.btn_ok.Text = "确认";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(504, 566);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(102, 28);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btn_modify);
            this.panel3.Controls.Add(this.btn_update);
            this.panel3.Controls.Add(this.btn_clientFo_delete);
            this.panel3.Controls.Add(this.btn_clientFo_new);
            this.panel3.Controls.Add(this.btn_clientFo_query);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.lb_clientType);
            this.panel3.Location = new System.Drawing.Point(15, 26);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(775, 80);
            this.panel3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(11, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "------** 客户类型( 1--供应商；2--购货商 )** ------";
            // 
            // btn_modify
            // 
            this.btn_modify.Location = new System.Drawing.Point(571, 19);
            this.btn_modify.Name = "btn_modify";
            this.btn_modify.Size = new System.Drawing.Size(75, 28);
            this.btn_modify.TabIndex = 8;
            this.btn_modify.Text = "修改";
            this.btn_modify.UseVisualStyleBackColor = true;
            this.btn_modify.Click += new System.EventHandler(this.btn_modify_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(672, 19);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 28);
            this.btn_update.TabIndex = 7;
            this.btn_update.Text = "刷新";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_clientFo_delete
            // 
            this.btn_clientFo_delete.Location = new System.Drawing.Point(470, 19);
            this.btn_clientFo_delete.Name = "btn_clientFo_delete";
            this.btn_clientFo_delete.Size = new System.Drawing.Size(75, 28);
            this.btn_clientFo_delete.TabIndex = 6;
            this.btn_clientFo_delete.Text = "删除";
            this.btn_clientFo_delete.UseVisualStyleBackColor = true;
            this.btn_clientFo_delete.Click += new System.EventHandler(this.btn_clientFo_delete_Click);
            // 
            // btn_clientFo_new
            // 
            this.btn_clientFo_new.Location = new System.Drawing.Point(366, 19);
            this.btn_clientFo_new.Name = "btn_clientFo_new";
            this.btn_clientFo_new.Size = new System.Drawing.Size(75, 28);
            this.btn_clientFo_new.TabIndex = 5;
            this.btn_clientFo_new.Text = "新建";
            this.btn_clientFo_new.UseVisualStyleBackColor = true;
            this.btn_clientFo_new.Click += new System.EventHandler(this.button_add_Click);
            // 
            // btn_clientFo_query
            // 
            this.btn_clientFo_query.Location = new System.Drawing.Point(270, 19);
            this.btn_clientFo_query.Name = "btn_clientFo_query";
            this.btn_clientFo_query.Size = new System.Drawing.Size(75, 28);
            this.btn_clientFo_query.TabIndex = 4;
            this.btn_clientFo_query.Text = "查询";
            this.btn_clientFo_query.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "供应商",
            "购货商"});
            this.comboBox1.Location = new System.Drawing.Point(117, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 26);
            this.comboBox1.TabIndex = 3;
            // 
            // lb_clientType
            // 
            this.lb_clientType.AutoSize = true;
            this.lb_clientType.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_clientType.Location = new System.Drawing.Point(10, 24);
            this.lb_clientType.Name = "lb_clientType";
            this.lb_clientType.Size = new System.Drawing.Size(100, 19);
            this.lb_clientType.TabIndex = 2;
            this.lb_clientType.Text = "客户类型:";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(11, 112);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(946, 437);
            this.panel2.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(934, 431);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // ClientInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 623);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(980, 670);
            this.MinimumSize = new System.Drawing.Size(980, 670);
            this.Name = "ClientInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "客户信息管理";
            this.Load += new System.EventHandler(this.ClientInfoForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_clientFo_new;
        private System.Windows.Forms.Button btn_clientFo_query;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lb_clientType;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_clientFo_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_modify;
        private System.Windows.Forms.Label label1;
    }
}