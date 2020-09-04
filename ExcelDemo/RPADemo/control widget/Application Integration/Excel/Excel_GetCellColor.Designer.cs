namespace ExcelDemo.control_widget
{
    partial class Excel_GetCellColor
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
            this.TB_CellName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "获取单元格颜色";
            // 
            // TB_SheetName
            // 
            this.TB_SheetName.Location = new System.Drawing.Point(42, 116);
            this.TB_SheetName.Name = "TB_SheetName";
            this.TB_SheetName.Size = new System.Drawing.Size(593, 42);
            this.TB_SheetName.TabIndex = 1;
            // 
            // TB_CellName
            // 
            this.TB_CellName.Location = new System.Drawing.Point(641, 116);
            this.TB_CellName.Name = "TB_CellName";
            this.TB_CellName.Size = new System.Drawing.Size(100, 42);
            this.TB_CellName.TabIndex = 2;
            // 
            // Excel_GetCellColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TB_CellName);
            this.Controls.Add(this.TB_SheetName);
            this.Controls.Add(this.label1);
            this.Name = "Excel_GetCellColor";
            this.Size = new System.Drawing.Size(800, 250);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_SheetName;
        private System.Windows.Forms.TextBox TB_CellName;
    }
}
