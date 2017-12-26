namespace GitManagerTest
{
    partial class BuyerInfoForm
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.GitDBDataSetBuyerInfo = new GitManagerTest.GitDBDataSetBuyerInfo();
            this.pro_getClient2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pro_getClient2TableAdapter = new GitManagerTest.GitDBDataSetBuyerInfoTableAdapters.pro_getClient2TableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GitDBDataSetBuyerInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pro_getClient2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Location = new System.Drawing.Point(2, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 566);
            this.panel1.TabIndex = 0;
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoSize = true;
            reportDataSource1.Name = "DataSetBuyer";
            reportDataSource1.Value = this.pro_getClient2BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GitManagerTest.ReportBuyer.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(4, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(927, 563);
            this.reportViewer1.TabIndex = 0;
            // 
            // GitDBDataSetBuyerInfo
            // 
            this.GitDBDataSetBuyerInfo.DataSetName = "GitDBDataSetBuyerInfo";
            this.GitDBDataSetBuyerInfo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pro_getClient2BindingSource
            // 
            this.pro_getClient2BindingSource.DataMember = "pro_getClient2";
            this.pro_getClient2BindingSource.DataSource = this.GitDBDataSetBuyerInfo;
            // 
            // pro_getClient2TableAdapter
            // 
            this.pro_getClient2TableAdapter.ClearBeforeFill = true;
            // 
            // BuyerInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(934, 573);
            this.Controls.Add(this.panel1);
            this.Name = "BuyerInfoForm";
            this.Text = "BuyerInfoForm";
            this.Load += new System.EventHandler(this.BuyerInfoForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GitDBDataSetBuyerInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pro_getClient2BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource pro_getClient2BindingSource;
        private GitDBDataSetBuyerInfo GitDBDataSetBuyerInfo;
        private GitDBDataSetBuyerInfoTableAdapters.pro_getClient2TableAdapter pro_getClient2TableAdapter;
    }
}