namespace RtmpPlayer
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
            this.msgLabel = new System.Windows.Forms.Label();
            this.playBtn = new System.Windows.Forms.Button();
            this.scanLocalVideoBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.urlTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // msgLabel
            // 
            this.msgLabel.AutoSize = true;
            this.msgLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.msgLabel.Location = new System.Drawing.Point(99, 13);
            this.msgLabel.Name = "msgLabel";
            this.msgLabel.Size = new System.Drawing.Size(0, 12);
            this.msgLabel.TabIndex = 2;
            // 
            // playBtn
            // 
            this.playBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.playBtn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.playBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.playBtn.Location = new System.Drawing.Point(425, 95);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(90, 34);
            this.playBtn.TabIndex = 3;
            this.playBtn.Text = "下一步";
            this.playBtn.UseVisualStyleBackColor = false;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // scanLocalVideoBtn
            // 
            this.scanLocalVideoBtn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.scanLocalVideoBtn.Location = new System.Drawing.Point(314, 95);
            this.scanLocalVideoBtn.Name = "scanLocalVideoBtn";
            this.scanLocalVideoBtn.Size = new System.Drawing.Size(90, 34);
            this.scanLocalVideoBtn.TabIndex = 5;
            this.scanLocalVideoBtn.Text = "取消";
            this.scanLocalVideoBtn.UseVisualStyleBackColor = true;
            this.scanLocalVideoBtn.Click += new System.EventHandler(this.scanLocalVideoBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(43, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "房间名称：";
            // 
            // urlTextbox
            // 
            this.urlTextbox.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.urlTextbox.Location = new System.Drawing.Point(137, 43);
            this.urlTextbox.Name = "urlTextbox";
            this.urlTextbox.Size = new System.Drawing.Size(252, 26);
            this.urlTextbox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 136);
            this.ControlBox = false;
            this.Controls.Add(this.urlTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scanLocalVideoBtn);
            this.Controls.Add(this.playBtn);
            this.Controls.Add(this.msgLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "设置";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label msgLabel;
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.Button scanLocalVideoBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox urlTextbox;
    }
}

