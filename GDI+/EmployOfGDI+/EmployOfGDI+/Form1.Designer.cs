namespace EmployOfGDI_
{
    partial class MainForm
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBarC = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnPie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBarC
            // 
            this.btnBarC.Location = new System.Drawing.Point(76, 12);
            this.btnBarC.Name = "btnBarC";
            this.btnBarC.Size = new System.Drawing.Size(181, 41);
            this.btnBarC.TabIndex = 0;
            this.btnBarC.Text = "投票统计柱形图";
            this.btnBarC.UseVisualStyleBackColor = true;
            this.btnBarC.Click += new System.EventHandler(this.btnBarC_Click);
            // 
            // btnLine
            // 
            this.btnLine.Location = new System.Drawing.Point(76, 93);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(181, 41);
            this.btnLine.TabIndex = 1;
            this.btnLine.Text = "绘制折线图";
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // btnPie
            // 
            this.btnPie.Location = new System.Drawing.Point(76, 174);
            this.btnPie.Name = "btnPie";
            this.btnPie.Size = new System.Drawing.Size(181, 41);
            this.btnPie.TabIndex = 2;
            this.btnPie.Text = "绘制饼状图";
            this.btnPie.UseVisualStyleBackColor = true;
            this.btnPie.Click += new System.EventHandler(this.btnPie_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 236);
            this.Controls.Add(this.btnPie);
            this.Controls.Add(this.btnLine);
            this.Controls.Add(this.btnBarC);
            this.Name = "MainForm";
            this.Text = "GDI+绘图的应用";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBarC;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnPie;
    }
}

