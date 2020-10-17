namespace ExcelDemo.control_widget
{
    partial class Excel_WriteCell
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
            this.TB_Content = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "写入单元格";
            // 
            // TB_SheetName
            // 
            this.TB_SheetName.Location = new System.Drawing.Point(31, 31);
            this.TB_SheetName.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.TB_SheetName.Name = "TB_SheetName";
            this.TB_SheetName.Size = new System.Drawing.Size(198, 21);
            this.TB_SheetName.TabIndex = 1;
            // 
            // TB_CellName
            // 
            this.TB_CellName.Location = new System.Drawing.Point(233, 31);
            this.TB_CellName.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.TB_CellName.Name = "TB_CellName";
            this.TB_CellName.Size = new System.Drawing.Size(58, 21);
            this.TB_CellName.TabIndex = 2;
            // 
            // TB_Content
            // 
            this.TB_Content.Location = new System.Drawing.Point(31, 60);
            this.TB_Content.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.TB_Content.Name = "TB_Content";
            this.TB_Content.Size = new System.Drawing.Size(260, 21);
            this.TB_Content.TabIndex = 3;
            // 
            // Excel_WriteCell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TB_Content);
            this.Controls.Add(this.TB_CellName);
            this.Controls.Add(this.TB_SheetName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.Name = "Excel_WriteCell";
            this.Size = new System.Drawing.Size(320, 100);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_SheetName;
        private System.Windows.Forms.TextBox TB_CellName;
        private System.Windows.Forms.TextBox TB_Content;
    }
}
