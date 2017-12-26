namespace GitManagerTest
{
    partial class EmployerInfoForm
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
            this.GitDBDataSetEmployerInfo = new GitManagerTest.GitDBDataSetEmployerInfo();
            this.pro_getEmployerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pro_getEmployerTableAdapter = new GitManagerTest.GitDBDataSetEmployerInfoTableAdapters.pro_getEmployerTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GitDBDataSetEmployerInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pro_getEmployerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 585);
            this.panel1.TabIndex = 0;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetEmployerInfo";
            reportDataSource1.Value = this.pro_getEmployerBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GitManagerTest.ReportEmployerInfo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(4, 4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(665, 578);
            this.reportViewer1.TabIndex = 0;
            // 
            // GitDBDataSetEmployerInfo
            // 
            this.GitDBDataSetEmployerInfo.DataSetName = "GitDBDataSetEmployerInfo";
            this.GitDBDataSetEmployerInfo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pro_getEmployerBindingSource
            // 
            this.pro_getEmployerBindingSource.DataMember = "pro_getEmployer";
            this.pro_getEmployerBindingSource.DataSource = this.GitDBDataSetEmployerInfo;
            // 
            // pro_getEmployerTableAdapter
            // 
            this.pro_getEmployerTableAdapter.ClearBeforeFill = true;
            // 
            // EmployerInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(675, 587);
            this.Controls.Add(this.panel1);
            this.Name = "EmployerInfoForm";
            this.Text = "EmployerInfoForm";
            this.Load += new System.EventHandler(this.EmployerInfoForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GitDBDataSetEmployerInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pro_getEmployerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource pro_getEmployerBindingSource;
        private GitDBDataSetEmployerInfo GitDBDataSetEmployerInfo;
        private GitDBDataSetEmployerInfoTableAdapters.pro_getEmployerTableAdapter pro_getEmployerTableAdapter;
    }
}