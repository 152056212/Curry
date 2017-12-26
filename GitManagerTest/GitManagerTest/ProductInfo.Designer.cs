namespace GitManagerTest
{
    partial class ProductInfo
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
            this.GitDBDataSet = new GitManagerTest.GitDBDataSet();
            this.pro_getProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pro_getProductTableAdapter = new GitManagerTest.GitDBDataSetTableAdapters.pro_getProductTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GitDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pro_getProductBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1208, 809);
            this.panel1.TabIndex = 0;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetProduct";
            reportDataSource1.Value = this.pro_getProductBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GitManagerTest.ReportProduct.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(4, 4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1200, 802);
            this.reportViewer1.TabIndex = 0;
            // 
            // GitDBDataSet
            // 
            this.GitDBDataSet.DataSetName = "GitDBDataSet";
            this.GitDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pro_getProductBindingSource
            // 
            this.pro_getProductBindingSource.DataMember = "pro_getProduct";
            this.pro_getProductBindingSource.DataSource = this.GitDBDataSet;
            // 
            // pro_getProductTableAdapter
            // 
            this.pro_getProductTableAdapter.ClearBeforeFill = true;
            // 
            // ProductInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1209, 806);
            this.Controls.Add(this.panel1);
            this.Name = "ProductInfo";
            this.Text = "ProductInfo";
            this.Load += new System.EventHandler(this.ProductInfo_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GitDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pro_getProductBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource pro_getProductBindingSource;
        private GitDBDataSet GitDBDataSet;
        private GitDBDataSetTableAdapters.pro_getProductTableAdapter pro_getProductTableAdapter;
    }
}