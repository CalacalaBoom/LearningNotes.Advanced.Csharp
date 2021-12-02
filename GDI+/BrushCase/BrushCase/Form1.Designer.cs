namespace BrushCase
{
    partial class Form1
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
            this.btnRed = new System.Windows.Forms.Button();
            this.btnPointBrush = new System.Windows.Forms.Button();
            this.btnLG = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRed
            // 
            this.btnRed.Location = new System.Drawing.Point(12, 397);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(121, 32);
            this.btnRed.TabIndex = 0;
            this.btnRed.Text = "绘制红色矩形";
            this.btnRed.UseVisualStyleBackColor = true;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // btnPointBrush
            // 
            this.btnPointBrush.Location = new System.Drawing.Point(165, 397);
            this.btnPointBrush.Name = "btnPointBrush";
            this.btnPointBrush.Size = new System.Drawing.Size(121, 32);
            this.btnPointBrush.TabIndex = 1;
            this.btnPointBrush.Text = "绘制长条图示";
            this.btnPointBrush.UseVisualStyleBackColor = true;
            this.btnPointBrush.Click += new System.EventHandler(this.btnPointBrush_Click);
            // 
            // btnLG
            // 
            this.btnLG.Location = new System.Drawing.Point(311, 397);
            this.btnLG.Name = "btnLG";
            this.btnLG.Size = new System.Drawing.Size(121, 32);
            this.btnLG.TabIndex = 2;
            this.btnLG.Text = "绘制渐变";
            this.btnLG.UseVisualStyleBackColor = true;
            this.btnLG.Click += new System.EventHandler(this.btnLG_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 441);
            this.Controls.Add(this.btnLG);
            this.Controls.Add(this.btnPointBrush);
            this.Controls.Add(this.btnRed);
            this.Name = "Form1";
            this.Text = "创建Brush对象";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnPointBrush;
        private System.Windows.Forms.Button btnLG;
    }
}

