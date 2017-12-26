namespace GitManagerTest
{
    partial class SetHighValueForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_highValue = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入值：";
            // 
            // tb_highValue
            // 
            this.tb_highValue.Location = new System.Drawing.Point(181, 45);
            this.tb_highValue.Name = "tb_highValue";
            this.tb_highValue.Size = new System.Drawing.Size(209, 25);
            this.tb_highValue.TabIndex = 1;
            // 
            // btn_ok
            // 
            this.btn_ok.AutoSize = true;
            this.btn_ok.Font = new System.Drawing.Font("宋体", 10F);
            this.btn_ok.Location = new System.Drawing.Point(123, 98);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Padding = new System.Windows.Forms.Padding(2);
            this.btn_ok.Size = new System.Drawing.Size(75, 31);
            this.btn_ok.TabIndex = 2;
            this.btn_ok.Text = "确认";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.AutoSize = true;
            this.btn_cancel.Location = new System.Drawing.Point(284, 97);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Padding = new System.Windows.Forms.Padding(2);
            this.btn_cancel.Size = new System.Drawing.Size(75, 32);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // SetHighValueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 151);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.tb_highValue);
            this.Controls.Add(this.label1);
            this.Name = "SetHighValueForm";
            this.Text = "SetHighValueForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_highValue;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
    }
}