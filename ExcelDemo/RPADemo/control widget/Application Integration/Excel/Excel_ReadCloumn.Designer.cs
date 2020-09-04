namespace ExcelDemo.control_widget
{
    partial class Excel_ReadCloumn
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.TB_SheetName = new System.Windows.Forms.TextBox();
            this.TB_ColumnName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "读取列";
            // 
            // TB_SheetName
            // 
            this.TB_SheetName.Location = new System.Drawing.Point(59, 113);
            this.TB_SheetName.Name = "TB_SheetName";
            this.TB_SheetName.Size = new System.Drawing.Size(578, 42);
            this.TB_SheetName.TabIndex = 1;
            // 
            // TB_ColumnName
            // 
            this.TB_ColumnName.Location = new System.Drawing.Point(643, 113);
            this.TB_ColumnName.Name = "TB_ColumnName";
            this.TB_ColumnName.Size = new System.Drawing.Size(100, 42);
            this.TB_ColumnName.TabIndex = 2;
            // 
            // Excel_ReadCloumn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TB_ColumnName);
            this.Controls.Add(this.TB_SheetName);
            this.Controls.Add(this.label1);
            this.Name = "Excel_ReadCloumn";
            this.Size = new System.Drawing.Size(800, 250);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_SheetName;
        private System.Windows.Forms.TextBox TB_ColumnName;
    }
}
