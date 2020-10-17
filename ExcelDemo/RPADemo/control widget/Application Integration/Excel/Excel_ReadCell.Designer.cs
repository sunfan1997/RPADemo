namespace ExcelDemo.control_widget
{
    partial class Excel_ReadCell
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
            this.TB_CellName = new System.Windows.Forms.TextBox();
            this.TB_SheetName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TB_CellName
            // 
            this.TB_CellName.Location = new System.Drawing.Point(257, 42);
            this.TB_CellName.Margin = new System.Windows.Forms.Padding(1);
            this.TB_CellName.Name = "TB_CellName";
            this.TB_CellName.Size = new System.Drawing.Size(42, 21);
            this.TB_CellName.TabIndex = 4;
            // 
            // TB_SheetName
            // 
            this.TB_SheetName.Location = new System.Drawing.Point(23, 42);
            this.TB_SheetName.Margin = new System.Windows.Forms.Padding(1);
            this.TB_SheetName.Name = "TB_SheetName";
            this.TB_SheetName.Size = new System.Drawing.Size(234, 21);
            this.TB_SheetName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "读取单元格";
            // 
            // Excel_ReadCell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_CellName);
            this.Controls.Add(this.TB_SheetName);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Excel_ReadCell";
            this.Size = new System.Drawing.Size(320, 100);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TB_CellName;
        private System.Windows.Forms.TextBox TB_SheetName;
        private System.Windows.Forms.Label label1;
    }
}
