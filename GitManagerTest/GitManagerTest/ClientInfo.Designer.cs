namespace GitManagerTest
{
    partial class ClientInfo
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
            this.GitDBDataSetClientInfo = new GitManagerTest.GitDBDataSetClientInfo();
            this.pro_getClientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pro_getClientTableAdapter = new GitManagerTest.GitDBDataSetClientInfoTableAdapters.pro_getClientTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GitDBDataSetClientInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pro_getClientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Location = new System.Drawing.Point(1, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1189, 701);
            this.panel1.TabIndex = 0;
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoSize = true;
            reportDataSource1.Name = "DataSetClientInfo";
            reportDataSource1.Value = this.pro_getClientBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GitManagerTest.ReportClienInfo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1183, 695);
            this.reportViewer1.TabIndex = 0;
            // 
            // GitDBDataSetClientInfo
            // 
            this.GitDBDataSetClientInfo.DataSetName = "GitDBDataSetClientInfo";
            this.GitDBDataSetClientInfo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pro_getClientBindingSource
            // 
            this.pro_getClientBindingSource.DataMember = "pro_getClient";
            this.pro_getClientBindingSource.DataSource = this.GitDBDataSetClientInfo;
            // 
            // pro_getClientTableAdapter
            // 
            this.pro_getClientTableAdapter.ClearBeforeFill = true;
            // 
            // ClientInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1189, 694);
            this.Controls.Add(this.panel1);
            this.Name = "ClientInfo";
            this.Text = "ClientInfo";
            this.Load += new System.EventHandler(this.ClientInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GitDBDataSetClientInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pro_getClientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource pro_getClientBindingSource;
        private GitDBDataSetClientInfo GitDBDataSetClientInfo;
        private GitDBDataSetClientInfoTableAdapters.pro_getClientTableAdapter pro_getClientTableAdapter;
    }
}