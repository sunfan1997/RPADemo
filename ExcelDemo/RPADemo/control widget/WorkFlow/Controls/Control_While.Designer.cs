namespace RPADemo.control_widget.WorkFlow.Controls
{
    partial class Control_While
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
            this.Pan_Body = new System.Windows.Forms.Panel();
            this.TB_Condition = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LB_Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Pan_Body
            // 
            this.Pan_Body.Location = new System.Drawing.Point(19, 75);
            this.Pan_Body.Name = "Pan_Body";
            this.Pan_Body.Size = new System.Drawing.Size(281, 119);
            this.Pan_Body.TabIndex = 9;
            // 
            // TB_Condition
            // 
            this.TB_Condition.ForeColor = System.Drawing.Color.Gray;
            this.TB_Condition.Location = new System.Drawing.Point(19, 36);
            this.TB_Condition.Name = "TB_Condition";
            this.TB_Condition.Size = new System.Drawing.Size(281, 21);
            this.TB_Condition.TabIndex = 8;
            this.TB_Condition.Text = "输入表达式";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "Condition";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "Body";
            // 
            // LB_Title
            // 
            this.LB_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LB_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.LB_Title.Location = new System.Drawing.Point(0, 0);
            this.LB_Title.Name = "LB_Title";
            this.LB_Title.Size = new System.Drawing.Size(320, 12);
            this.LB_Title.TabIndex = 5;
            this.LB_Title.Text = "While";
            // 
            // Control_While
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Pan_Body);
            this.Controls.Add(this.TB_Condition);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LB_Title);
            this.Name = "Control_While";
            this.Size = new System.Drawing.Size(320, 200);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pan_Body;
        private System.Windows.Forms.TextBox TB_Condition;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LB_Title;
    }
}
