namespace RtmpPlayer.Window
{
    partial class CarmerSet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.carmerName = new System.Windows.Forms.TextBox();
            this.rtmpUrl = new System.Windows.Forms.TextBox();
            this.btn_true = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(66, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "摄像头名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(42, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "摄像头直播地址";
            // 
            // carmerName
            // 
            this.carmerName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.carmerName.Location = new System.Drawing.Point(172, 29);
            this.carmerName.Name = "carmerName";
            this.carmerName.Size = new System.Drawing.Size(253, 26);
            this.carmerName.TabIndex = 2;
            // 
            // rtmpUrl
            // 
            this.rtmpUrl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtmpUrl.Location = new System.Drawing.Point(172, 95);
            this.rtmpUrl.Name = "rtmpUrl";
            this.rtmpUrl.Size = new System.Drawing.Size(253, 26);
            this.rtmpUrl.TabIndex = 3;
            // 
            // btn_true
            // 
            this.btn_true.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_true.Location = new System.Drawing.Point(350, 187);
            this.btn_true.Name = "btn_true";
            this.btn_true.Size = new System.Drawing.Size(75, 23);
            this.btn_true.TabIndex = 5;
            this.btn_true.Text = "确定";
            this.btn_true.UseVisualStyleBackColor = true;
            this.btn_true.Click += new System.EventHandler(this.btn_true_Click);
            // 
            // CarmerSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 222);
            this.ControlBox = false;
            this.Controls.Add(this.btn_true);
            this.Controls.Add(this.rtmpUrl);
            this.Controls.Add(this.carmerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CarmerSet";
            this.Text = "摄像头配置";
            this.Load += new System.EventHandler(this.CarmerSet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox carmerName;
        private System.Windows.Forms.TextBox rtmpUrl;
        private System.Windows.Forms.Button btn_true;
    }
}