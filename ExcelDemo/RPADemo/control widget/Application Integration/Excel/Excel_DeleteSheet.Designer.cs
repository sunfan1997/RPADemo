﻿namespace RPADemo.control_widget.Application_Integration.Excel
{
    partial class Excel_DeleteSheet
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
            this.TB_Sheet = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "删除sheet表";
            // 
            // TB_Sheet
            // 
            this.TB_Sheet.ForeColor = System.Drawing.Color.Black;
            this.TB_Sheet.Location = new System.Drawing.Point(26, 41);
            this.TB_Sheet.Name = "TB_Sheet";
            this.TB_Sheet.Size = new System.Drawing.Size(260, 21);
            this.TB_Sheet.TabIndex = 1;
            this.TB_Sheet.Text = "填入Index或表名";
            this.TB_Sheet.Click += new System.EventHandler(this.TB_Sheet_Click);
            // 
            // Excel_DeleteSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TB_Sheet);
            this.Controls.Add(this.label1);
            this.Name = "Excel_DeleteSheet";
            this.Size = new System.Drawing.Size(320, 100);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_Sheet;
    }
}
