namespace ExcelDemo.control_widget
{
    partial class Excel_AppendRange
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
            this.TB_DataSet = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "附加范围";
            // 
            // TB_SheetName
            // 
            this.TB_SheetName.Location = new System.Drawing.Point(22, 58);
            this.TB_SheetName.Margin = new System.Windows.Forms.Padding(1);
            this.TB_SheetName.Name = "TB_SheetName";
            this.TB_SheetName.Size = new System.Drawing.Size(280, 21);
            this.TB_SheetName.TabIndex = 1;
            // 
            // TB_DataSet
            // 
            this.TB_DataSet.Location = new System.Drawing.Point(22, 99);
            this.TB_DataSet.Margin = new System.Windows.Forms.Padding(1);
            this.TB_DataSet.Name = "TB_DataSet";
            this.TB_DataSet.Size = new System.Drawing.Size(280, 21);
            this.TB_DataSet.TabIndex = 2;
            // 
            // Excel_AppendRange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TB_DataSet);
            this.Controls.Add(this.TB_SheetName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Excel_AppendRange";
            this.Size = new System.Drawing.Size(320, 160);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TB_SheetName;
        private System.Windows.Forms.TextBox TB_DataSet;
        public System.Windows.Forms.Label label1;
    }
}
