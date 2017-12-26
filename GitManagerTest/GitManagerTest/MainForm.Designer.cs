using System.Windows.Forms;

namespace GitManagerTest
{
    partial class MainForm
    {
        private System.Windows.Forms.FlowLayoutPanel flp_root;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));

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
            this.flp_root = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_goodsInfo = new System.Windows.Forms.ToolStripButton();
            this.tsb_clientInfo = new System.Windows.Forms.ToolStripButton();
            this.tsb_supplierInfo = new System.Windows.Forms.ToolStripButton();
            this.tsb_purchaseInfo = new System.Windows.Forms.ToolStripButton();
            this.tsb_salesInfo = new System.Windows.Forms.ToolStripButton();
            this.tsb_stockInfo = new System.Windows.Forms.ToolStripButton();
            this.tsb_allocate = new System.Windows.Forms.ToolStripButton();
            this.tsb_systemset = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_exit = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_menu = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tp_menu = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.flp_produce = new System.Windows.Forms.FlowLayoutPanel();
            this.label14 = new System.Windows.Forms.Label();
            this.lb_pruduction = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.flp_storage_3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.lb_out = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.flp_storage_2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label30 = new System.Windows.Forms.Label();
            this.lb_in = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.flp_storage_1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label21 = new System.Windows.Forms.Label();
            this.lb_adjust = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.flp_input_1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_buy = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.flp_yewu_1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_pay = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.bt_questatistic = new System.Windows.Forms.Button();
            this.bt_queinput = new System.Windows.Forms.Button();
            this.bt_queoutput = new System.Windows.Forms.Button();
            this.bt_notify = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sl_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.sl_userInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.sl_currentdate = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsm_Info = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_clientInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_storageInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_userInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_input = new System.Windows.Forms.ToolStripMenuItem();
            this.Itsm_regoods = new System.Windows.Forms.ToolStripMenuItem();
            this.Itsm_purcharse = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_output = new System.Windows.Forms.ToolStripMenuItem();
            this.Itsm_sales = new System.Windows.Forms.ToolStripMenuItem();
            this.Itsm_regood_sales = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_storage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_checkStorage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_warnning = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_statistic = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_systemset = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_backup = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_resert = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_help = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.flp_root.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tab_menu.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tp_menu.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.flp_produce.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel6.SuspendLayout();
            this.flp_storage_3.SuspendLayout();
            this.flp_storage_2.SuspendLayout();
            this.flp_storage_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel5.SuspendLayout();
            this.flp_input_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel4.SuspendLayout();
            this.flp_yewu_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flp_root
            // 
            this.flp_root.Controls.Add(this.panel1);
            this.flp_root.Controls.Add(this.toolStrip1);
            this.flp_root.Controls.Add(this.tabControl1);
            this.flp_root.Controls.Add(this.statusStrip1);
            this.flp_root.Location = new System.Drawing.Point(1, 37);
            this.flp_root.Name = "flp_root";
            this.flp_root.Size = new System.Drawing.Size(1440, 972);
            this.flp_root.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(15, 15);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_goodsInfo,
            this.tsb_clientInfo,
            this.tsb_supplierInfo,
            this.tsb_purchaseInfo,
            this.tsb_salesInfo,
            this.tsb_stockInfo,
            this.tsb_allocate,
            this.tsb_systemset,
            this.toolStripSeparator1,
            this.tsb_exit});
            this.toolStrip1.Location = new System.Drawing.Point(6, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1080, 88);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_goodsInfo
            // 
            this.tsb_goodsInfo.Image = global::GitManagerTest.Properties.Resources.box3;
            this.tsb_goodsInfo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsb_goodsInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_goodsInfo.Name = "tsb_goodsInfo";
            this.tsb_goodsInfo.Size = new System.Drawing.Size(73, 85);
            this.tsb_goodsInfo.Text = "员工资料";
            this.tsb_goodsInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsb_goodsInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsb_goodsInfo.Click += new System.EventHandler(this.tsb_goodsInfo_Click);
            // 
            // tsb_clientInfo
            // 
            this.tsb_clientInfo.Image = global::GitManagerTest.Properties.Resources.client3;
            this.tsb_clientInfo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsb_clientInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_clientInfo.Name = "tsb_clientInfo";
            this.tsb_clientInfo.Size = new System.Drawing.Size(88, 85);
            this.tsb_clientInfo.Text = "购货商资料";
            this.tsb_clientInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsb_clientInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsb_clientInfo.Click += new System.EventHandler(this.tsb_clientInfo_Click);
            // 
            // tsb_supplierInfo
            // 
            this.tsb_supplierInfo.Image = global::GitManagerTest.Properties.Resources.supplier;
            this.tsb_supplierInfo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsb_supplierInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_supplierInfo.Name = "tsb_supplierInfo";
            this.tsb_supplierInfo.Size = new System.Drawing.Size(88, 85);
            this.tsb_supplierInfo.Text = "供应商资料";
            this.tsb_supplierInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsb_supplierInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsb_supplierInfo.Click += new System.EventHandler(this.tsb_supplierInfo_Click);
            // 
            // tsb_purchaseInfo
            // 
            this.tsb_purchaseInfo.Image = global::GitManagerTest.Properties.Resources.purcharse1;
            this.tsb_purchaseInfo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsb_purchaseInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_purchaseInfo.Name = "tsb_purchaseInfo";
            this.tsb_purchaseInfo.Size = new System.Drawing.Size(73, 85);
            this.tsb_purchaseInfo.Text = "采购进货";
            this.tsb_purchaseInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsb_purchaseInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsb_purchaseInfo.Click += new System.EventHandler(this.tsb_purchaseInfo_Click);
            // 
            // tsb_salesInfo
            // 
            this.tsb_salesInfo.Image = global::GitManagerTest.Properties.Resources.sales;
            this.tsb_salesInfo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsb_salesInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_salesInfo.Name = "tsb_salesInfo";
            this.tsb_salesInfo.Size = new System.Drawing.Size(73, 85);
            this.tsb_salesInfo.Text = "销售出库";
            this.tsb_salesInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsb_salesInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsb_salesInfo.Click += new System.EventHandler(this.tsb_salesInfo_Click);
            // 
            // tsb_stockInfo
            // 
            this.tsb_stockInfo.Image = global::GitManagerTest.Properties.Resources.stock;
            this.tsb_stockInfo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsb_stockInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_stockInfo.Name = "tsb_stockInfo";
            this.tsb_stockInfo.Size = new System.Drawing.Size(73, 85);
            this.tsb_stockInfo.Text = "商品库存";
            this.tsb_stockInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsb_stockInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsb_allocate
            // 
            this.tsb_allocate.Image = global::GitManagerTest.Properties.Resources.allocate;
            this.tsb_allocate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsb_allocate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_allocate.Name = "tsb_allocate";
            this.tsb_allocate.Size = new System.Drawing.Size(73, 85);
            this.tsb_allocate.Text = "库存调拨";
            this.tsb_allocate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsb_allocate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsb_systemset
            // 
            this.tsb_systemset.Image = global::GitManagerTest.Properties.Resources.system_set1;
            this.tsb_systemset.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsb_systemset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_systemset.Name = "tsb_systemset";
            this.tsb_systemset.Size = new System.Drawing.Size(73, 85);
            this.tsb_systemset.Text = "系统设置";
            this.tsb_systemset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsb_systemset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 88);
            // 
            // tsb_exit
            // 
            this.tsb_exit.Image = global::GitManagerTest.Properties.Resources.exit;
            this.tsb_exit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsb_exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_exit.Name = "tsb_exit";
            this.tsb_exit.Size = new System.Drawing.Size(73, 85);
            this.tsb_exit.Text = "退出系统";
            this.tsb_exit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsb_exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsb_exit.Click += new System.EventHandler(this.tsb_exit_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_menu);
            this.tabControl1.Location = new System.Drawing.Point(3, 91);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1416, 753);
            this.tabControl1.TabIndex = 2;
            // 
            // tab_menu
            // 
            this.tab_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(123)))), ((int)(((byte)(185)))));
            this.tab_menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tab_menu.Controls.Add(this.panel3);
            this.tab_menu.Controls.Add(this.panel2);
            this.tab_menu.Controls.Add(this.label1);
            this.tab_menu.Location = new System.Drawing.Point(4, 25);
            this.tab_menu.Name = "tab_menu";
            this.tab_menu.Padding = new System.Windows.Forms.Padding(3);
            this.tab_menu.Size = new System.Drawing.Size(1408, 724);
            this.tab_menu.TabIndex = 0;
            this.tab_menu.Text = "功能导航";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.tabControl2);
            this.panel3.Location = new System.Drawing.Point(321, 109);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1102, 607);
            this.panel3.TabIndex = 2;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tp_menu);
            this.tabControl2.Location = new System.Drawing.Point(4, 4);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1086, 600);
            this.tabControl2.TabIndex = 0;
            // 
            // tp_menu
            // 
            this.tp_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tp_menu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tp_menu.Controls.Add(this.tableLayoutPanel1);
            this.tp_menu.Font = new System.Drawing.Font("华文细黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tp_menu.Location = new System.Drawing.Point(4, 25);
            this.tp_menu.Name = "tp_menu";
            this.tp_menu.Padding = new System.Windows.Forms.Padding(3);
            this.tp_menu.Size = new System.Drawing.Size(1078, 571);
            this.tp_menu.TabIndex = 0;
            this.tp_menu.Text = "系统提醒";
            this.tp_menu.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(58, 36);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(689, 488);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.flp_produce);
            this.panel7.Controls.Add(this.label17);
            this.panel7.Controls.Add(this.pictureBox5);
            this.panel7.Location = new System.Drawing.Point(3, 363);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(683, 112);
            this.panel7.TabIndex = 3;
            // 
            // flp_produce
            // 
            this.flp_produce.Controls.Add(this.label14);
            this.flp_produce.Controls.Add(this.lb_pruduction);
            this.flp_produce.Controls.Add(this.label16);
            this.flp_produce.Location = new System.Drawing.Point(112, 62);
            this.flp_produce.Name = "flp_produce";
            this.flp_produce.Size = new System.Drawing.Size(285, 30);
            this.flp_produce.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("华文细黑", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(3, 3);
            this.label14.Margin = new System.Windows.Forms.Padding(3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 17);
            this.label14.TabIndex = 5;
            this.label14.Text = "待审核生产";
            // 
            // lb_pruduction
            // 
            this.lb_pruduction.AutoSize = true;
            this.lb_pruduction.Font = new System.Drawing.Font("华文细黑", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_pruduction.ForeColor = System.Drawing.Color.Red;
            this.lb_pruduction.Location = new System.Drawing.Point(94, 5);
            this.lb_pruduction.Margin = new System.Windows.Forms.Padding(0, 5, 0, 3);
            this.lb_pruduction.Name = "lb_pruduction";
            this.lb_pruduction.Size = new System.Drawing.Size(17, 16);
            this.lb_pruduction.TabIndex = 6;
            this.lb_pruduction.Text = "0";
            this.lb_pruduction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("华文细黑", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(114, 3);
            this.label16.Margin = new System.Windows.Forms.Padding(3);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(24, 17);
            this.label16.TabIndex = 7;
            this.label16.Text = "笔";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("华文细黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label17.Location = new System.Drawing.Point(112, 35);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(94, 21);
            this.label17.TabIndex = 1;
            this.label17.Text = "生产模块";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::GitManagerTest.Properties.Resources.produce;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(26, 19);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(15, 15, 0, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(72, 72);
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.flp_storage_3);
            this.panel6.Controls.Add(this.flp_storage_2);
            this.panel6.Controls.Add(this.flp_storage_1);
            this.panel6.Controls.Add(this.flowLayoutPanel3);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Controls.Add(this.pictureBox4);
            this.panel6.Location = new System.Drawing.Point(3, 243);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(683, 114);
            this.panel6.TabIndex = 2;
            // 
            // flp_storage_3
            // 
            this.flp_storage_3.Controls.Add(this.label10);
            this.flp_storage_3.Controls.Add(this.lb_out);
            this.flp_storage_3.Controls.Add(this.label12);
            this.flp_storage_3.Location = new System.Drawing.Point(413, 62);
            this.flp_storage_3.Name = "flp_storage_3";
            this.flp_storage_3.Size = new System.Drawing.Size(179, 30);
            this.flp_storage_3.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("华文细黑", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(3, 3);
            this.label10.Margin = new System.Windows.Forms.Padding(3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "待审核出库";
            // 
            // lb_out
            // 
            this.lb_out.AutoSize = true;
            this.lb_out.Font = new System.Drawing.Font("华文细黑", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lb_out.ForeColor = System.Drawing.Color.Red;
            this.lb_out.Location = new System.Drawing.Point(94, 5);
            this.lb_out.Margin = new System.Windows.Forms.Padding(0, 5, 0, 3);
            this.lb_out.Name = "lb_out";
            this.lb_out.Size = new System.Drawing.Size(19, 19);
            this.lb_out.TabIndex = 9;
            this.lb_out.Text = "0";
            this.lb_out.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_out.Click += new System.EventHandler(this.lb_out_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("华文细黑", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(116, 3);
            this.label12.Margin = new System.Windows.Forms.Padding(3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 17);
            this.label12.TabIndex = 10;
            this.label12.Text = "笔，";
            // 
            // flp_storage_2
            // 
            this.flp_storage_2.Controls.Add(this.label30);
            this.flp_storage_2.Controls.Add(this.lb_in);
            this.flp_storage_2.Controls.Add(this.label32);
            this.flp_storage_2.Location = new System.Drawing.Point(261, 61);
            this.flp_storage_2.Name = "flp_storage_2";
            this.flp_storage_2.Size = new System.Drawing.Size(179, 30);
            this.flp_storage_2.TabIndex = 7;
            this.flp_storage_2.Paint += new System.Windows.Forms.PaintEventHandler(this.flp_storage_2_Paint);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("华文细黑", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label30.Location = new System.Drawing.Point(3, 3);
            this.label30.Margin = new System.Windows.Forms.Padding(3);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(88, 17);
            this.label30.TabIndex = 8;
            this.label30.Text = "待审核入库";
            // 
            // lb_in
            // 
            this.lb_in.AutoSize = true;
            this.lb_in.Font = new System.Drawing.Font("华文细黑", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lb_in.ForeColor = System.Drawing.Color.Red;
            this.lb_in.Location = new System.Drawing.Point(94, 5);
            this.lb_in.Margin = new System.Windows.Forms.Padding(0, 5, 0, 3);
            this.lb_in.Name = "lb_in";
            this.lb_in.Size = new System.Drawing.Size(19, 19);
            this.lb_in.TabIndex = 9;
            this.lb_in.Text = "0";
            this.lb_in.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_in.Click += new System.EventHandler(this.lb_in_Click);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("华文细黑", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label32.Location = new System.Drawing.Point(116, 3);
            this.label32.Margin = new System.Windows.Forms.Padding(3);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(40, 17);
            this.label32.TabIndex = 10;
            this.label32.Text = "笔，";
            // 
            // flp_storage_1
            // 
            this.flp_storage_1.Controls.Add(this.label21);
            this.flp_storage_1.Controls.Add(this.lb_adjust);
            this.flp_storage_1.Controls.Add(this.label23);
            this.flp_storage_1.Location = new System.Drawing.Point(112, 61);
            this.flp_storage_1.Name = "flp_storage_1";
            this.flp_storage_1.Size = new System.Drawing.Size(179, 30);
            this.flp_storage_1.TabIndex = 6;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("华文细黑", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label21.Location = new System.Drawing.Point(3, 3);
            this.label21.Margin = new System.Windows.Forms.Padding(3);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(88, 17);
            this.label21.TabIndex = 5;
            this.label21.Text = "待审核调拨";
            this.label21.Click += new System.EventHandler(this.label21_Click);
            // 
            // lb_adjust
            // 
            this.lb_adjust.AutoSize = true;
            this.lb_adjust.Font = new System.Drawing.Font("华文细黑", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lb_adjust.ForeColor = System.Drawing.Color.Red;
            this.lb_adjust.Location = new System.Drawing.Point(94, 5);
            this.lb_adjust.Margin = new System.Windows.Forms.Padding(0, 5, 0, 3);
            this.lb_adjust.Name = "lb_adjust";
            this.lb_adjust.Size = new System.Drawing.Size(19, 19);
            this.lb_adjust.TabIndex = 6;
            this.lb_adjust.Text = "0";
            this.lb_adjust.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("华文细黑", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label23.Location = new System.Drawing.Point(116, 3);
            this.label23.Margin = new System.Windows.Forms.Padding(3);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(40, 17);
            this.label23.TabIndex = 7;
            this.label23.Text = "笔，";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Location = new System.Drawing.Point(112, 62);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(568, 30);
            this.flowLayoutPanel3.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("华文细黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label13.Location = new System.Drawing.Point(112, 35);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 21);
            this.label13.TabIndex = 1;
            this.label13.Text = "库存";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::GitManagerTest.Properties.Resources.produce1;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(26, 19);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(15, 15, 0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(72, 72);
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.flp_input_1);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.pictureBox3);
            this.panel5.Location = new System.Drawing.Point(3, 123);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(683, 114);
            this.panel5.TabIndex = 1;
            // 
            // flp_input_1
            // 
            this.flp_input_1.Controls.Add(this.label6);
            this.flp_input_1.Controls.Add(this.lb_buy);
            this.flp_input_1.Controls.Add(this.label8);
            this.flp_input_1.Location = new System.Drawing.Point(112, 62);
            this.flp_input_1.Name = "flp_input_1";
            this.flp_input_1.Size = new System.Drawing.Size(285, 30);
            this.flp_input_1.TabIndex = 5;
            this.flp_input_1.Paint += new System.Windows.Forms.PaintEventHandler(this.flp_input_1_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("华文细黑", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(3, 3);
            this.label6.Margin = new System.Windows.Forms.Padding(3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "最新采购";
            // 
            // lb_buy
            // 
            this.lb_buy.AutoSize = true;
            this.lb_buy.Font = new System.Drawing.Font("华文细黑", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_buy.ForeColor = System.Drawing.Color.Red;
            this.lb_buy.Location = new System.Drawing.Point(78, 5);
            this.lb_buy.Margin = new System.Windows.Forms.Padding(0, 5, 0, 3);
            this.lb_buy.Name = "lb_buy";
            this.lb_buy.Size = new System.Drawing.Size(17, 16);
            this.lb_buy.TabIndex = 6;
            this.lb_buy.Text = "0";
            this.lb_buy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("华文细黑", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(98, 3);
            this.label8.Margin = new System.Windows.Forms.Padding(3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "笔";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("华文细黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label9.Location = new System.Drawing.Point(112, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 21);
            this.label9.TabIndex = 1;
            this.label9.Text = "采购模块";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::GitManagerTest.Properties.Resources.MyInput;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(26, 19);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(15, 15, 0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(72, 72);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.flp_yewu_1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(683, 114);
            this.panel4.TabIndex = 0;
            // 
            // flp_yewu_1
            // 
            this.flp_yewu_1.Controls.Add(this.label3);
            this.flp_yewu_1.Controls.Add(this.lb_pay);
            this.flp_yewu_1.Controls.Add(this.label5);
            this.flp_yewu_1.Location = new System.Drawing.Point(112, 61);
            this.flp_yewu_1.Name = "flp_yewu_1";
            this.flp_yewu_1.Size = new System.Drawing.Size(285, 30);
            this.flp_yewu_1.TabIndex = 5;
            this.flp_yewu_1.Paint += new System.Windows.Forms.PaintEventHandler(this.flp_yewu_1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("华文细黑", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "待收款销售";
            // 
            // lb_pay
            // 
            this.lb_pay.AutoSize = true;
            this.lb_pay.Font = new System.Drawing.Font("华文细黑", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_pay.ForeColor = System.Drawing.Color.Red;
            this.lb_pay.Location = new System.Drawing.Point(94, 5);
            this.lb_pay.Margin = new System.Windows.Forms.Padding(0, 5, 0, 3);
            this.lb_pay.Name = "lb_pay";
            this.lb_pay.Size = new System.Drawing.Size(17, 16);
            this.lb_pay.TabIndex = 6;
            this.lb_pay.Text = "0";
            this.lb_pay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("华文细黑", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(114, 3);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "笔";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("华文细黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(112, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "业务模块";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::GitManagerTest.Properties.Resources.yewu;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(26, 19);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(15, 15, 0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(72, 72);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.monthCalendar1);
            this.panel2.Controls.Add(this.bt_questatistic);
            this.panel2.Controls.Add(this.bt_queinput);
            this.panel2.Controls.Add(this.bt_queoutput);
            this.panel2.Controls.Add(this.bt_notify);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(6, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(305, 589);
            this.panel2.TabIndex = 1;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(8, 355);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 5;
            // 
            // bt_questatistic
            // 
            this.bt_questatistic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(254)))));
            this.bt_questatistic.Image = global::GitManagerTest.Properties.Resources.box3;
            this.bt_questatistic.Location = new System.Drawing.Point(10, 280);
            this.bt_questatistic.Margin = new System.Windows.Forms.Padding(10);
            this.bt_questatistic.Name = "bt_questatistic";
            this.bt_questatistic.Size = new System.Drawing.Size(285, 56);
            this.bt_questatistic.TabIndex = 4;
            this.bt_questatistic.Text = "报表查询 ";
            this.bt_questatistic.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_questatistic.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_questatistic.UseVisualStyleBackColor = false;
            this.bt_questatistic.MouseEnter += new System.EventHandler(this.bt_questatistic_MouseEnter);
            this.bt_questatistic.MouseLeave += new System.EventHandler(this.bt_questatistic_MouseLeave);
            // 
            // bt_queinput
            // 
            this.bt_queinput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(254)))));
            this.bt_queinput.Image = global::GitManagerTest.Properties.Resources.box3;
            this.bt_queinput.Location = new System.Drawing.Point(10, 207);
            this.bt_queinput.Margin = new System.Windows.Forms.Padding(10);
            this.bt_queinput.Name = "bt_queinput";
            this.bt_queinput.Size = new System.Drawing.Size(285, 56);
            this.bt_queinput.TabIndex = 3;
            this.bt_queinput.Text = "入库查询  ";
            this.bt_queinput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_queinput.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_queinput.UseVisualStyleBackColor = false;
            this.bt_queinput.MouseEnter += new System.EventHandler(this.bt_queinput_MouseEnter);
            this.bt_queinput.MouseLeave += new System.EventHandler(this.bt_queinput_MouseLeave);
            // 
            // bt_queoutput
            // 
            this.bt_queoutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(254)))));
            this.bt_queoutput.Image = global::GitManagerTest.Properties.Resources.box3;
            this.bt_queoutput.Location = new System.Drawing.Point(10, 135);
            this.bt_queoutput.Margin = new System.Windows.Forms.Padding(10);
            this.bt_queoutput.Name = "bt_queoutput";
            this.bt_queoutput.Size = new System.Drawing.Size(285, 56);
            this.bt_queoutput.TabIndex = 2;
            this.bt_queoutput.Text = "出库查询  ";
            this.bt_queoutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_queoutput.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_queoutput.UseVisualStyleBackColor = false;
            this.bt_queoutput.MouseEnter += new System.EventHandler(this.bt_queoutput_MouseEnter);
            this.bt_queoutput.MouseLeave += new System.EventHandler(this.bt_queoutput_MouseLeave);
            // 
            // bt_notify
            // 
            this.bt_notify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(224)))), ((int)(((byte)(254)))));
            this.bt_notify.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_notify.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bt_notify.Image = global::GitManagerTest.Properties.Resources.box3;
            this.bt_notify.Location = new System.Drawing.Point(10, 66);
            this.bt_notify.Margin = new System.Windows.Forms.Padding(10);
            this.bt_notify.Name = "bt_notify";
            this.bt_notify.Size = new System.Drawing.Size(285, 56);
            this.bt_notify.TabIndex = 1;
            this.bt_notify.Text = "系统提醒  ";
            this.bt_notify.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_notify.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_notify.UseVisualStyleBackColor = false;
            this.bt_notify.MouseEnter += new System.EventHandler(this.bt_notify_MouseEnter);
            this.bt_notify.MouseLeave += new System.EventHandler(this.bt_notify_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GitManagerTest.Properties.Resources.navigation;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(305, 53);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(33, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "仓库管理软件";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sl_status,
            this.sl_userInfo,
            this.sl_currentdate});
            this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.statusStrip1.Location = new System.Drawing.Point(0, 847);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip1.Size = new System.Drawing.Size(694, 25);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // sl_status
            // 
            this.sl_status.Margin = new System.Windows.Forms.Padding(0, 3, 300, 2);
            this.sl_status.Name = "sl_status";
            this.sl_status.Size = new System.Drawing.Size(39, 20);
            this.sl_status.Text = "正常";
            // 
            // sl_userInfo
            // 
            this.sl_userInfo.Margin = new System.Windows.Forms.Padding(0, 3, 200, 2);
            this.sl_userInfo.Name = "sl_userInfo";
            this.sl_userInfo.Size = new System.Drawing.Size(54, 20);
            this.sl_userInfo.Text = "管理员";
            // 
            // sl_currentdate
            // 
            this.sl_currentdate.Name = "sl_currentdate";
            this.sl_currentdate.Size = new System.Drawing.Size(84, 20);
            this.sl_currentdate.Text = "当前时间：";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_Info,
            this.tsm_input,
            this.tsm_output,
            this.tsm_storage,
            this.tsm_statistic,
            this.tsm_systemset,
            this.tsm_help});
            this.menuStrip1.Location = new System.Drawing.Point(2, 2);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 0, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1418, 26);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsm_Info
            // 
            this.tsm_Info.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_clientInfo,
            this.tsm_storageInfo,
            this.tsm_userInfo});
            this.tsm_Info.Name = "tsm_Info";
            this.tsm_Info.Size = new System.Drawing.Size(81, 24);
            this.tsm_Info.Text = "基本信息";
            // 
            // tsm_clientInfo
            // 
            this.tsm_clientInfo.Name = "tsm_clientInfo";
            this.tsm_clientInfo.Size = new System.Drawing.Size(138, 24);
            this.tsm_clientInfo.Text = "客户信息";
            this.tsm_clientInfo.Click += new System.EventHandler(this.tsm_clientInfo_Click);
            // 
            // tsm_storageInfo
            // 
            this.tsm_storageInfo.Name = "tsm_storageInfo";
            this.tsm_storageInfo.Size = new System.Drawing.Size(138, 24);
            this.tsm_storageInfo.Text = "仓库信息";
            this.tsm_storageInfo.Click += new System.EventHandler(this.tsm_storageInfo_Click);
            // 
            // tsm_userInfo
            // 
            this.tsm_userInfo.Name = "tsm_userInfo";
            this.tsm_userInfo.Size = new System.Drawing.Size(138, 24);
            this.tsm_userInfo.Text = "用户信息";
            this.tsm_userInfo.Click += new System.EventHandler(this.tsm_userInfo_Click);
            // 
            // tsm_input
            // 
            this.tsm_input.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Itsm_regoods,
            this.Itsm_purcharse});
            this.tsm_input.Name = "tsm_input";
            this.tsm_input.Size = new System.Drawing.Size(81, 24);
            this.tsm_input.Text = "入库管理";
            // 
            // Itsm_regoods
            // 
            this.Itsm_regoods.Name = "Itsm_regoods";
            this.Itsm_regoods.Size = new System.Drawing.Size(138, 24);
            this.Itsm_regoods.Text = "退购入库";
            this.Itsm_regoods.Click += new System.EventHandler(this.Itsm_regoods_Click);
            // 
            // Itsm_purcharse
            // 
            this.Itsm_purcharse.Name = "Itsm_purcharse";
            this.Itsm_purcharse.Size = new System.Drawing.Size(138, 24);
            this.Itsm_purcharse.Text = "采购入库";
            this.Itsm_purcharse.Click += new System.EventHandler(this.Itsm_purcharse_Click);
            // 
            // tsm_output
            // 
            this.tsm_output.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Itsm_sales,
            this.Itsm_regood_sales});
            this.tsm_output.Name = "tsm_output";
            this.tsm_output.Size = new System.Drawing.Size(81, 24);
            this.tsm_output.Text = "出库管理";
            // 
            // Itsm_sales
            // 
            this.Itsm_sales.Name = "Itsm_sales";
            this.Itsm_sales.Size = new System.Drawing.Size(138, 24);
            this.Itsm_sales.Text = "销售出库";
            this.Itsm_sales.Click += new System.EventHandler(this.Itsm_sales_Click);
            // 
            // Itsm_regood_sales
            // 
            this.Itsm_regood_sales.Name = "Itsm_regood_sales";
            this.Itsm_regood_sales.Size = new System.Drawing.Size(138, 24);
            this.Itsm_regood_sales.Text = "退货出库";
            this.Itsm_regood_sales.Click += new System.EventHandler(this.Itsm_regood_sales_Click);
            // 
            // tsm_storage
            // 
            this.tsm_storage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_checkStorage,
            this.tsm_warnning});
            this.tsm_storage.Name = "tsm_storage";
            this.tsm_storage.Size = new System.Drawing.Size(81, 24);
            this.tsm_storage.Text = "库存管理";
            // 
            // tsm_checkStorage
            // 
            this.tsm_checkStorage.Name = "tsm_checkStorage";
            this.tsm_checkStorage.Size = new System.Drawing.Size(138, 24);
            this.tsm_checkStorage.Text = "库存盘点";
            // 
            // tsm_warnning
            // 
            this.tsm_warnning.Name = "tsm_warnning";
            this.tsm_warnning.Size = new System.Drawing.Size(138, 24);
            this.tsm_warnning.Text = "库存警示";
            // 
            // tsm_statistic
            // 
            this.tsm_statistic.Name = "tsm_statistic";
            this.tsm_statistic.Size = new System.Drawing.Size(81, 24);
            this.tsm_statistic.Text = "统计报表";
            this.tsm_statistic.Click += new System.EventHandler(this.tsm_statistic_Click);
            // 
            // tsm_systemset
            // 
            this.tsm_systemset.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_backup,
            this.tsm_resert});
            this.tsm_systemset.Name = "tsm_systemset";
            this.tsm_systemset.Size = new System.Drawing.Size(81, 24);
            this.tsm_systemset.Text = "系统管理";
            // 
            // tsm_backup
            // 
            this.tsm_backup.Name = "tsm_backup";
            this.tsm_backup.Size = new System.Drawing.Size(138, 24);
            this.tsm_backup.Text = "数据备份";
            // 
            // tsm_resert
            // 
            this.tsm_resert.Name = "tsm_resert";
            this.tsm_resert.Size = new System.Drawing.Size(138, 24);
            this.tsm_resert.Text = "重置仓库";
            // 
            // tsm_help
            // 
            this.tsm_help.Name = "tsm_help";
            this.tsm_help.Size = new System.Drawing.Size(51, 24);
            this.tsm_help.Text = "帮助";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1422, 903);
            this.Controls.Add(this.flp_root);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1440, 950);
            this.MinimumSize = new System.Drawing.Size(1440, 950);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "库存管理系统";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.flp_root.ResumeLayout(false);
            this.flp_root.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tab_menu.ResumeLayout(false);
            this.tab_menu.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tp_menu.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.flp_produce.ResumeLayout(false);
            this.flp_produce.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.flp_storage_3.ResumeLayout(false);
            this.flp_storage_3.PerformLayout();
            this.flp_storage_2.ResumeLayout(false);
            this.flp_storage_2.PerformLayout();
            this.flp_storage_1.ResumeLayout(false);
            this.flp_storage_1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.flp_input_1.ResumeLayout(false);
            this.flp_input_1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.flp_yewu_1.ResumeLayout(false);
            this.flp_yewu_1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        
        void bt_questatistic_MouseLeave(object sender, System.EventArgs e)
        {
            this.bt_questatistic.BackColor = System.Drawing.Color.FromArgb(255, 201, 224, 254);                        
        }

        void bt_questatistic_MouseEnter(object sender, System.EventArgs e)
        {
            this.bt_questatistic.BackColor = System.Drawing.Color.FromArgb(255, 253, 201, 131);
        }

        void bt_queinput_MouseLeave(object sender, System.EventArgs e)
        {
            this.bt_queinput.BackColor = System.Drawing.Color.FromArgb(255, 201, 224, 254);            
        }

        void bt_queinput_MouseEnter(object sender, System.EventArgs e)
        {
            this.bt_queinput.BackColor = System.Drawing.Color.FromArgb(255, 253, 201, 131);
            
        }

        void bt_queoutput_MouseLeave(object sender, System.EventArgs e)
        {
            this.bt_queoutput.BackColor = System.Drawing.Color.FromArgb(255, 201, 224, 254);
        }

        void bt_queoutput_MouseEnter(object sender, System.EventArgs e)
        {
            this.bt_queoutput.BackColor = System.Drawing.Color.FromArgb(255, 253, 201, 131);            
        }
        void bt_notify_MouseLeave(object sender, System.EventArgs e)
        {
            this.bt_notify.BackColor = System.Drawing.Color.FromArgb(255,201,224,254);
        }

        void bt_notify_MouseEnter(object sender, System.EventArgs e)
        {
            this.bt_notify.BackColor = System.Drawing.Color.FromArgb( 255,253,201,131 );
        }
        

        void toolStripButton1_MouseLeave(object sender, System.EventArgs e)
        {
            
        }

        void toolStripButton1_MouseEnter(object sender, System.EventArgs e)
        {
           // UiUtil.Output("" + this.BackColor.ToString() + " " + this.toolStripButton1.ForeColor.ToArgb().ToString());
            
            
        }

       

        


        #endregion

        private Panel panel1;
        private ToolStrip toolStrip1;
        private ToolStripButton tsb_goodsInfo;
        private ToolStripButton tsb_clientInfo;
        private ToolStripButton tsb_supplierInfo;
        private ToolStripButton tsb_purchaseInfo;
        private ToolStripButton tsb_salesInfo;
        private ToolStripButton tsb_stockInfo;
        private ToolStripButton tsb_allocate;
        private ToolStripButton tsb_systemset;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsb_exit;
        private TabPage tab_menu;
        private TabControl tabControl1;
        private Label label1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button bt_questatistic;
        private Button bt_queinput;
        private Button bt_queoutput;
        private Button bt_notify;
        private MonthCalendar monthCalendar1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel sl_status;
        private ToolStripStatusLabel sl_userInfo;
        private Panel panel3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsm_Info;
        private ToolStripMenuItem tsm_input;
        private ToolStripMenuItem tsm_output;
        private ToolStripMenuItem tsm_storage;
        private ToolStripMenuItem tsm_statistic;
        private ToolStripMenuItem tsm_systemset;
        private ToolStripMenuItem tsm_help;
        private ToolStripMenuItem tsm_clientInfo;
        private ToolStripMenuItem tsm_storageInfo;
        private ToolStripMenuItem tsm_userInfo;
        private ToolStripMenuItem tsm_checkStorage;
        private ToolStripMenuItem tsm_warnning;
        private ToolStripMenuItem tsm_backup;
        private ToolStripMenuItem tsm_resert;
        private ToolStripMenuItem Itsm_purcharse;
        private ToolStripMenuItem Itsm_regoods;
        private ToolStripMenuItem Itsm_sales;
        private ToolStripMenuItem Itsm_regood_sales;
        private TabControl tabControl2;
        private TabPage tp_menu;
        private PictureBox pictureBox2;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel4;
        private Label label2;
        private FlowLayoutPanel flp_yewu_1;
        private Label label3;
        private Label lb_pay;
        private Label label5;
        private Panel panel7;
        private FlowLayoutPanel flp_produce;
        private Label label14;
        private Label lb_pruduction;
        private Label label16;
        private Label label17;
        private PictureBox pictureBox5;
        private Panel panel6;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label label13;
        private PictureBox pictureBox4;
        private Panel panel5;
        private FlowLayoutPanel flp_input_1;
        private Label label6;
        private Label lb_buy;
        private Label label8;
        private Label label9;
        private PictureBox pictureBox3;
        private FlowLayoutPanel flp_storage_1;
        private Label label21;
        private Label lb_adjust;
        private Label label23;
        private FlowLayoutPanel flp_storage_2;
        private Label label30;
        private Label lb_in;
        private Label label32;
        private FlowLayoutPanel flp_storage_3;
        private Label label10;
        private Label lb_out;
        private Label label12;
        private ToolStripStatusLabel sl_currentdate;
        private Timer timer1;
        


    }
}