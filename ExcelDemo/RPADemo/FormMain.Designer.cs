namespace RPADemo
{
    partial class FormMain
    {

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btnSpire = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.mainlabel = new System.Windows.Forms.ToolStripLabel();
            this.designlabel = new System.Windows.Forms.ToolStripLabel();
            this.debuglabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.Tssbtn_New = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.流程图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.状态机ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.全局处理程序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.测试用例ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据驱动测试用例ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_Save = new System.Windows.Forms.ToolStripSplitButton();
            this.Btn_Saveas = new System.Windows.Forms.ToolStripMenuItem();
            this.全部保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Tsb_Run = new System.Windows.Forms.ToolStripSplitButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Pan_Main = new System.Windows.Forms.Panel();
            this.DGV_Variable = new System.Windows.Forms.DataGridView();
            this.Varname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Range = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.DefaultValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip_DGV = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.TSBtn_Variable = new System.Windows.Forms.ToolStripButton();
            this.TSBtn_Parameter = new System.Windows.Forms.ToolStripButton();
            this.TSBtn_Import = new System.Windows.Forms.ToolStripButton();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Pan_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Variable)).BeginInit();
            this.contextMenuStrip_DGV.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSpire
            // 
            resources.ApplyResources(this.btnSpire, "btnSpire");
            this.btnSpire.Name = "btnSpire";
            this.btnSpire.UseVisualStyleBackColor = true;
            this.btnSpire.Click += new System.EventHandler(this.btnSpire_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "证件照.jpg");
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainlabel,
            this.designlabel,
            this.debuglabel});
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.Name = "toolStrip1";
            // 
            // mainlabel
            // 
            this.mainlabel.Name = "mainlabel";
            resources.ApplyResources(this.mainlabel, "mainlabel");
            // 
            // designlabel
            // 
            this.designlabel.Name = "designlabel";
            resources.ApplyResources(this.designlabel, "designlabel");
            // 
            // debuglabel
            // 
            this.debuglabel.Name = "debuglabel";
            resources.ApplyResources(this.debuglabel, "debuglabel");
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tssbtn_New,
            this.Btn_Save,
            this.toolStripSeparator1,
            this.Tsb_Run});
            resources.ApplyResources(this.toolStrip2, "toolStrip2");
            this.toolStrip2.Name = "toolStrip2";
            // 
            // Tssbtn_New
            // 
            this.Tssbtn_New.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Tssbtn_New.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.流程图ToolStripMenuItem,
            this.状态机ToolStripMenuItem,
            this.全局处理程序ToolStripMenuItem,
            this.测试用例ToolStripMenuItem,
            this.数据驱动测试用例ToolStripMenuItem});
            resources.ApplyResources(this.Tssbtn_New, "Tssbtn_New");
            this.Tssbtn_New.Name = "Tssbtn_New";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            // 
            // 流程图ToolStripMenuItem
            // 
            this.流程图ToolStripMenuItem.Name = "流程图ToolStripMenuItem";
            resources.ApplyResources(this.流程图ToolStripMenuItem, "流程图ToolStripMenuItem");
            // 
            // 状态机ToolStripMenuItem
            // 
            this.状态机ToolStripMenuItem.Name = "状态机ToolStripMenuItem";
            resources.ApplyResources(this.状态机ToolStripMenuItem, "状态机ToolStripMenuItem");
            // 
            // 全局处理程序ToolStripMenuItem
            // 
            this.全局处理程序ToolStripMenuItem.Name = "全局处理程序ToolStripMenuItem";
            resources.ApplyResources(this.全局处理程序ToolStripMenuItem, "全局处理程序ToolStripMenuItem");
            // 
            // 测试用例ToolStripMenuItem
            // 
            this.测试用例ToolStripMenuItem.Name = "测试用例ToolStripMenuItem";
            resources.ApplyResources(this.测试用例ToolStripMenuItem, "测试用例ToolStripMenuItem");
            // 
            // 数据驱动测试用例ToolStripMenuItem
            // 
            this.数据驱动测试用例ToolStripMenuItem.Name = "数据驱动测试用例ToolStripMenuItem";
            resources.ApplyResources(this.数据驱动测试用例ToolStripMenuItem, "数据驱动测试用例ToolStripMenuItem");
            // 
            // Btn_Save
            // 
            this.Btn_Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Btn_Save.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Btn_Saveas,
            this.全部保存ToolStripMenuItem});
            resources.ApplyResources(this.Btn_Save, "Btn_Save");
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.ButtonClick += new System.EventHandler(this.Btn_Save_ButtonClick);
            // 
            // Btn_Saveas
            // 
            this.Btn_Saveas.Name = "Btn_Saveas";
            resources.ApplyResources(this.Btn_Saveas, "Btn_Saveas");
            this.Btn_Saveas.Click += new System.EventHandler(this.Btn_Saveas_Click);
            // 
            // 全部保存ToolStripMenuItem
            // 
            this.全部保存ToolStripMenuItem.Name = "全部保存ToolStripMenuItem";
            resources.ApplyResources(this.全部保存ToolStripMenuItem, "全部保存ToolStripMenuItem");
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // Tsb_Run
            // 
            this.Tsb_Run.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.Tsb_Run, "Tsb_Run");
            this.Tsb_Run.Name = "Tsb_Run";
            this.Tsb_Run.ButtonClick += new System.EventHandler(this.Tsb_Run_ButtonClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Pan_Main);
            this.panel1.Controls.Add(this.treeView1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // Pan_Main
            // 
            this.Pan_Main.BackColor = System.Drawing.Color.White;
            this.Pan_Main.Controls.Add(this.DGV_Variable);
            this.Pan_Main.Controls.Add(this.toolStrip3);
            resources.ApplyResources(this.Pan_Main, "Pan_Main");
            this.Pan_Main.Name = "Pan_Main";
            this.Pan_Main.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.Pan_Main.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.Pan_Main.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // DGV_Variable
            // 
            this.DGV_Variable.BackgroundColor = System.Drawing.Color.White;
            this.DGV_Variable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGV_Variable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Variable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Varname,
            this.Type,
            this.Range,
            this.DefaultValue});
            this.DGV_Variable.ContextMenuStrip = this.contextMenuStrip_DGV;
            resources.ApplyResources(this.DGV_Variable, "DGV_Variable");
            this.DGV_Variable.GridColor = System.Drawing.SystemColors.Control;
            this.DGV_Variable.Name = "DGV_Variable";
            this.DGV_Variable.RowTemplate.Height = 23;
            this.DGV_Variable.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_Variable_CellMouseUp);
            this.DGV_Variable.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.DGV_Variable_RowStateChanged);
            // 
            // Varname
            // 
            this.Varname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.Varname, "Varname");
            this.Varname.Name = "Varname";
            // 
            // Type
            // 
            this.Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.Type, "Type");
            this.Type.Items.AddRange(new object[] {
            "String",
            "bool",
            "Int32",
            "Object",
            "Array of[T]"});
            this.Type.Name = "Type";
            this.Type.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Range
            // 
            this.Range.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.Range, "Range");
            this.Range.Name = "Range";
            this.Range.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Range.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // DefaultValue
            // 
            this.DefaultValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.DefaultValue, "DefaultValue");
            this.DefaultValue.Name = "DefaultValue";
            // 
            // contextMenuStrip_DGV
            // 
            this.contextMenuStrip_DGV.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Delete});
            this.contextMenuStrip_DGV.Name = "contextMenuStrip_DGV";
            resources.ApplyResources(this.contextMenuStrip_DGV, "contextMenuStrip_DGV");
            // 
            // ToolStripMenuItem_Delete
            // 
            this.ToolStripMenuItem_Delete.Name = "ToolStripMenuItem_Delete";
            resources.ApplyResources(this.ToolStripMenuItem_Delete, "ToolStripMenuItem_Delete");
            this.ToolStripMenuItem_Delete.Click += new System.EventHandler(this.ToolStripMenuItem_Delete_Click);
            // 
            // toolStrip3
            // 
            resources.ApplyResources(this.toolStrip3, "toolStrip3");
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSBtn_Variable,
            this.TSBtn_Parameter,
            this.TSBtn_Import});
            this.toolStrip3.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip3.Name = "toolStrip3";
            // 
            // TSBtn_Variable
            // 
            this.TSBtn_Variable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.TSBtn_Variable, "TSBtn_Variable");
            this.TSBtn_Variable.Name = "TSBtn_Variable";
            this.TSBtn_Variable.Click += new System.EventHandler(this.TSBtn_Variable_Click);
            // 
            // TSBtn_Parameter
            // 
            this.TSBtn_Parameter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.TSBtn_Parameter, "TSBtn_Parameter");
            this.TSBtn_Parameter.Name = "TSBtn_Parameter";
            // 
            // TSBtn_Import
            // 
            this.TSBtn_Import.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.TSBtn_Import, "TSBtn_Import");
            this.TSBtn_Import.Name = "TSBtn_Import";
            // 
            // treeView1
            // 
            this.treeView1.AllowDrop = true;
            this.treeView1.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.treeView1, "treeView1");
            this.treeView1.HotTracking = true;
            this.treeView1.Name = "treeView1";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            ((System.Windows.Forms.TreeNode)(resources.GetObject("treeView1.Nodes")))});
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            this.treeView1.MouseLeave += new System.EventHandler(this.treeView1_MouseLeave);
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnSpire);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "FormMain";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.Pan_Main.ResumeLayout(false);
            this.Pan_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Variable)).EndInit();
            this.contextMenuStrip_DGV.ResumeLayout(false);
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnSpire;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel mainlabel;
        private System.Windows.Forms.ToolStripLabel designlabel;
        private System.Windows.Forms.ToolStripLabel debuglabel;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripSplitButton Tssbtn_New;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 流程图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 状态机ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 全局处理程序ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 测试用例ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据驱动测试用例ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton Btn_Save;
        private System.Windows.Forms.ToolStripMenuItem Btn_Saveas;
        private System.Windows.Forms.ToolStripMenuItem 全部保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Pan_Main;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ToolStripSplitButton Tsb_Run;
        private System.Windows.Forms.DataGridView DGV_Variable;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton TSBtn_Variable;
        private System.Windows.Forms.ToolStripButton TSBtn_Parameter;
        private System.Windows.Forms.ToolStripButton TSBtn_Import;
        private System.Windows.Forms.DataGridViewTextBoxColumn Varname;
        private System.Windows.Forms.DataGridViewComboBoxColumn Type;
        private System.Windows.Forms.DataGridViewComboBoxColumn Range;
        private System.Windows.Forms.DataGridViewTextBoxColumn DefaultValue;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_DGV;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Delete;
    }
}

