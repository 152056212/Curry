using System.Windows.Forms;
using System.Drawing;
namespace GitManagerTest
{
    partial class StorehouseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StorehouseForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_add = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItemDel = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemModify = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemReName = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1070, 709);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Controls.Add(this.btn_add);
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1064, 702);
            this.panel2.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.tabControl1.Location = new System.Drawing.Point(190, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(868, 684);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(860, 650);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "当前位置 -> 仓库1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 6);
            this.dataGridView1.MaximumSize = new System.Drawing.Size(854, 641);
            this.dataGridView1.MinimumSize = new System.Drawing.Size(854, 641);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 46;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(854, 641);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Location = new System.Drawing.Point(5, 662);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(177, 35);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "1";
            this.btn_add.UseMnemonic = false;
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            this.btn_add.Paint += new System.Windows.Forms.PaintEventHandler(this.btn_add_Paint);
            // 
            // listView1
            // 
            this.listView1.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.Location = new System.Drawing.Point(6, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(177, 645);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.listView1_AfterLabelEdit);
            this.listView1.BeforeLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.listView1_BeforeLabelEdit);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "    当前仓库";
            this.columnHeader1.Width = 116;
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
            this.ToolStripMenuItemDel.Click += new System.EventHandler(this.ToolStripMenuItemDel_Click);
            // 
            // ToolStripMenuItemModify
            // 
            this.ToolStripMenuItemModify.Name = "ToolStripMenuItemModify";
            this.ToolStripMenuItemModify.Size = new System.Drawing.Size(153, 24);
            this.ToolStripMenuItemModify.Text = "修改上限值";
            this.ToolStripMenuItemModify.Click += new System.EventHandler(this.ToolStripMenuItemModify_Click);
            // 
            // ToolStripMenuItemReName
            // 
            this.ToolStripMenuItemReName.Name = "ToolStripMenuItemReName";
            this.ToolStripMenuItemReName.Size = new System.Drawing.Size(153, 24);
            this.ToolStripMenuItemReName.Text = "重命名";
            this.ToolStripMenuItemReName.Click += new System.EventHandler(this.ToolStripMenuItemReName_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "storehouse.png");
            this.imageList1.Images.SetKeyName(1, "storehouse.png");
            this.imageList1.Images.SetKeyName(2, "storehouse.png");
            this.imageList1.Images.SetKeyName(3, "storehouse.png");
            this.imageList1.Images.SetKeyName(4, "storehouse.png");
            this.imageList1.Images.SetKeyName(5, "storehouse.png");
            this.imageList1.Images.SetKeyName(6, "storehouse.png");
            this.imageList1.Images.SetKeyName(7, "storehouse.png");
            this.imageList1.Images.SetKeyName(8, "storehouse.png");
            this.imageList1.Images.SetKeyName(9, "storehouse.png");
            // 
            // StorehouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 709);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "StorehouseForm";
            this.Text = "StorehouseForm";
            this.Load += new System.EventHandler(this.StorehouseForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
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
        private System.Windows.Forms.Button btn_add;
        private ImageList imageList1;
        private ColumnHeader columnHeader1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem ToolStripMenuItemDel;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private ToolStripMenuItem ToolStripMenuItemModify;
        private DataGridView dataGridView1;
        private ToolStripMenuItem ToolStripMenuItemReName;
    }
}