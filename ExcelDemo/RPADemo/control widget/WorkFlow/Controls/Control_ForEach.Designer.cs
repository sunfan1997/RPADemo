﻿namespace RPADemo.control_widget.WorkFlow.Controls
{
    partial class Control_ForEach
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
            this.LB_Title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Pan_Body = new System.Windows.Forms.Panel();
            this.TB_Item = new System.Windows.Forms.TextBox();
            this.TB_Items = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LB_Title
            // 
            this.LB_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LB_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.LB_Title.Location = new System.Drawing.Point(0, 0);
            this.LB_Title.Name = "LB_Title";
            this.LB_Title.Size = new System.Drawing.Size(280, 12);
            this.LB_Title.TabIndex = 0;
            this.LB_Title.Text = "ForEach";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "ForEach";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "in";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "Body";
            // 
            // Pan_Body
            // 
            this.Pan_Body.Location = new System.Drawing.Point(18, 62);
            this.Pan_Body.Name = "Pan_Body";
            this.Pan_Body.Size = new System.Drawing.Size(242, 109);
            this.Pan_Body.TabIndex = 4;
            // 
            // TB_Item
            // 
            this.TB_Item.Location = new System.Drawing.Point(69, 23);
            this.TB_Item.Name = "TB_Item";
            this.TB_Item.Size = new System.Drawing.Size(47, 21);
            this.TB_Item.TabIndex = 5;
            // 
            // TB_Items
            // 
            this.TB_Items.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TB_Items.Location = new System.Drawing.Point(145, 23);
            this.TB_Items.Name = "TB_Items";
            this.TB_Items.Size = new System.Drawing.Size(115, 21);
            this.TB_Items.TabIndex = 6;
            this.TB_Items.Text = "输入表达式";
            // 
            // Control_ForEach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TB_Items);
            this.Controls.Add(this.TB_Item);
            this.Controls.Add(this.Pan_Body);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LB_Title);
            this.Name = "Control_ForEach";
            this.Size = new System.Drawing.Size(280, 180);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel Pan_Body;
        private System.Windows.Forms.TextBox TB_Item;
        private System.Windows.Forms.TextBox TB_Items;
    }
}
