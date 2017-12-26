using System.Windows.Forms;
using System.Drawing;
namespace GitManagerTest
{
    partial class SITJForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SITJForm));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "仓库库存统计"}, 0, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134))));
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "月出库统计"}, 0, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("宋体", 10F));
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "月入库统计"}, 0, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("宋体", 10F));
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "商品类型统计"}, 0, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("宋体", 10F));
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("入库类型统计", 0);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("出库类型统计", 0);
            this.pro_getProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GitDBDataSet = new GitManagerTest.GitDBDataSet();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItemDel = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemModify = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemReName = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.mchart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pro_getProductTableAdapter = new GitManagerTest.GitDBDataSetTableAdapters.pro_getProductTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pro_getProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GitDBDataSet)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mchart)).BeginInit();
            this.SuspendLayout();
            // 
            // pro_getProductBindingSource
            // 
            this.pro_getProductBindingSource.DataMember = "pro_getProduct";
            this.pro_getProductBindingSource.DataSource = this.GitDBDataSet;
            // 
            // GitDBDataSet
            // 
            this.GitDBDataSet.DataSetName = "GitDBDataSet";
            this.GitDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemDel,
            this.ToolStripMenuItemModify,
            this.ToolStripMenuItemReName});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextMenuStrip1.Size = new System.Drawing.Size(154, 76);
            this.contextMenuStrip1.Text = "删除";
            // 
            // ToolStripMenuItemDel
            // 
            this.ToolStripMenuItemDel.Name = "ToolStripMenuItemDel";
            this.ToolStripMenuItemDel.Size = new System.Drawing.Size(153, 24);
            this.ToolStripMenuItemDel.Text = "删除仓库";
            // 
            // ToolStripMenuItemModify
            // 
            this.ToolStripMenuItemModify.Name = "ToolStripMenuItemModify";
            this.ToolStripMenuItemModify.Size = new System.Drawing.Size(153, 24);
            this.ToolStripMenuItemModify.Text = "修改上限值";
            // 
            // ToolStripMenuItemReName
            // 
            this.ToolStripMenuItemReName.Name = "ToolStripMenuItemReName";
            this.ToolStripMenuItemReName.Size = new System.Drawing.Size(153, 24);
            this.ToolStripMenuItemReName.Text = "重命名";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "statistics.png");
            this.imageList1.Images.SetKeyName(1, "statistics.png");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1548, 991);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1542, 985);
            this.panel2.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.tabControl1.Location = new System.Drawing.Point(212, 11);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1323, 971);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.reportViewer1);
            this.tabPage1.Controls.Add(this.mchart);
            this.tabPage1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1315, 937);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "当前位置 ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoSize = true;
            reportDataSource1.Name = "DataSetProduct";
            reportDataSource1.Value = this.pro_getProductBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GitManagerTest.ReportProduct.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(15, 369);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1294, 562);
            this.reportViewer1.TabIndex = 2;
            // 
            // mchart
            // 
            chartArea1.Name = "ChartArea1";
            this.mchart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.mchart.Legends.Add(legend1);
            this.mchart.Location = new System.Drawing.Point(165, 6);
            this.mchart.Name = "mchart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series6";
            series1.XValueMember = "6";
            series1.YValueMembers = "6";
            this.mchart.Series.Add(series1);
            this.mchart.Size = new System.Drawing.Size(987, 342);
            this.mchart.TabIndex = 1;
            this.mchart.Text = "chart1";
            // 
            // listView1
            // 
            this.listView1.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            listViewItem1.StateImageIndex = 0;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6});
            this.listView1.Location = new System.Drawing.Point(25, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(217, 644);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "       入库统计";
            this.columnHeader1.Width = 159;
            // 
            // pro_getProductTableAdapter
            // 
            this.pro_getProductTableAdapter.ClearBeforeFill = true;
            // 
            // SITJForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1551, 990);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "SITJForm";
            this.Text = "StorehouseForm";
            this.Load += new System.EventHandler(this.StorehouseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pro_getProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GitDBDataSet)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mchart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        /// <summary>
        /// 设置添加按钮圆角
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void btn_add_Paint(object sender, PaintEventArgs e)
        {
            UiUtil.Draw(e.ClipRectangle, e.Graphics, 15, false, Color.FromArgb(0, 135, 255), Color.FromArgb(0, 135, 255));
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.DrawString("添加新仓库", new Font("微软雅黑", 9F, FontStyle.Regular), new SolidBrush(Color.White), new PointF(38, 6));
        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView listView1;
        private ImageList imageList1;
        private ColumnHeader columnHeader1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem ToolStripMenuItemDel;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private ToolStripMenuItem ToolStripMenuItemModify;
        private ToolStripMenuItem ToolStripMenuItemReName;
        private System.Windows.Forms.DataVisualization.Charting.Chart mchart;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private BindingSource pro_getProductBindingSource;
        private GitDBDataSet GitDBDataSet;
        private GitDBDataSetTableAdapters.pro_getProductTableAdapter pro_getProductTableAdapter;

    }
}