namespace auto_distribution
{
    partial class Tool
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.StuffNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gettool = new System.Windows.Forms.Button();
            this.ToolNo = new System.Windows.Forms.TextBox();
            this.returntool = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StuffNo
            // 
            this.StuffNo.Location = new System.Drawing.Point(149, 57);
            this.StuffNo.Name = "StuffNo";
            this.StuffNo.Size = new System.Drawing.Size(100, 21);
            this.StuffNo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "员工号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "工具号";
            // 
            // gettool
            // 
            this.gettool.Location = new System.Drawing.Point(149, 109);
            this.gettool.Name = "gettool";
            this.gettool.Size = new System.Drawing.Size(75, 23);
            this.gettool.TabIndex = 3;
            this.gettool.Text = "取工具";
            this.gettool.UseVisualStyleBackColor = true;
            this.gettool.Click += new System.EventHandler(this.gettool_Click);
            // 
            // ToolNo
            // 
            this.ToolNo.Location = new System.Drawing.Point(411, 57);
            this.ToolNo.Name = "ToolNo";
            this.ToolNo.Size = new System.Drawing.Size(100, 21);
            this.ToolNo.TabIndex = 4;
            // 
            // returntool
            // 
            this.returntool.Location = new System.Drawing.Point(411, 109);
            this.returntool.Name = "returntool";
            this.returntool.Size = new System.Drawing.Size(75, 23);
            this.returntool.TabIndex = 5;
            this.returntool.Text = "归还工具";
            this.returntool.UseVisualStyleBackColor = true;
            this.returntool.Click += new System.EventHandler(this.returntool_Click);
            // 
            // Tool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 289);
            this.Controls.Add(this.returntool);
            this.Controls.Add(this.ToolNo);
            this.Controls.Add(this.gettool);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StuffNo);
            this.Name = "Tool";
            this.Text = "工具分配终端";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox StuffNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button gettool;
        private System.Windows.Forms.TextBox ToolNo;
        private System.Windows.Forms.Button returntool;
    }
}

