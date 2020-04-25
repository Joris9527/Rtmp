using System;
using System.Windows.Forms;

namespace RtmpPlayer.Window
{
    partial class PlayerFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerFrm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.exitImage = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dantu_btn = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.four_btn = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.six_btn = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.titleLable = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.main_panel = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.dantu_btn.SuspendLayout();
            this.four_btn.SuspendLayout();
            this.six_btn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripLabel2,
            this.toolStripLabel3,
            this.toolStripLabel4,
            this.exitImage});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(944, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(68, 22);
            this.toolStripLabel1.Text = "添加摄像头";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(56, 22);
            this.toolStripLabel2.Text = "轮播设置";
            this.toolStripLabel2.Click += new System.EventHandler(this.toolStripLabel2_Click);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(56, 22);
            this.toolStripLabel3.Text = "通道设置";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(68, 22);
            this.toolStripLabel4.Text = "电视机模式";
            // 
            // exitImage
            // 
            this.exitImage.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exitImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.exitImage.Image = global::RtmpPlayer.Properties.Resources.dianyuan;
            this.exitImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exitImage.Name = "exitImage";
            this.exitImage.Size = new System.Drawing.Size(23, 22);
            this.exitImage.Text = "退出系统";
            this.exitImage.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(164)))), ((int)(((byte)(234)))));
            this.panel2.Controls.Add(this.dantu_btn);
            this.panel2.Controls.Add(this.four_btn);
            this.panel2.Controls.Add(this.six_btn);
            this.panel2.Controls.Add(this.titleLable);
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.panel2.Size = new System.Drawing.Size(944, 69);
            this.panel2.TabIndex = 9;
            // 
            // dantu_btn
            // 
            this.dantu_btn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dantu_btn.AutoSize = true;
            this.dantu_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dantu_btn.Controls.Add(this.label4);
            this.dantu_btn.Location = new System.Drawing.Point(574, 16);
            this.dantu_btn.Name = "dantu_btn";
            this.dantu_btn.Size = new System.Drawing.Size(104, 36);
            this.dantu_btn.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("黑体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(164)))), ((int)(((byte)(234)))));
            this.label4.Location = new System.Drawing.Point(2, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "单图轮播";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // four_btn
            // 
            this.four_btn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.four_btn.AutoSize = true;
            this.four_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.four_btn.Controls.Add(this.label3);
            this.four_btn.Location = new System.Drawing.Point(698, 16);
            this.four_btn.Name = "four_btn";
            this.four_btn.Size = new System.Drawing.Size(104, 36);
            this.four_btn.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("黑体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(164)))), ((int)(((byte)(234)))));
            this.label3.Location = new System.Drawing.Point(2, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "四图轮播";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // six_btn
            // 
            this.six_btn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.six_btn.AutoSize = true;
            this.six_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.six_btn.Controls.Add(this.label2);
            this.six_btn.Location = new System.Drawing.Point(820, 16);
            this.six_btn.Name = "six_btn";
            this.six_btn.Size = new System.Drawing.Size(104, 36);
            this.six_btn.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("黑体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(164)))), ((int)(((byte)(234)))));
            this.label2.Location = new System.Drawing.Point(2, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "九图轮播";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // titleLable
            // 
            this.titleLable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titleLable.AutoEllipsis = true;
            this.titleLable.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.titleLable.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.titleLable.Location = new System.Drawing.Point(114, 5);
            this.titleLable.Name = "titleLable";
            this.titleLable.Size = new System.Drawing.Size(700, 54);
            this.titleLable.TabIndex = 0;
            this.titleLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titleLable.UseCompatibleTextRendering = true;
            this.titleLable.Click += new System.EventHandler(this.label5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox1.Location = new System.Drawing.Point(784, 214);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("黑体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(823, 367);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 0, 30, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "扫一扫";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("黑体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(812, 389);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 0, 30, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 22);
            this.label7.TabIndex = 11;
            this.label7.Text = "手机观看";
            // 
            // main_panel
            // 
            this.main_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.main_panel.AutoSize = true;
            this.main_panel.BackColor = System.Drawing.Color.White;
            this.main_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.main_panel.Location = new System.Drawing.Point(0, 94);
            this.main_panel.Margin = new System.Windows.Forms.Padding(20, 120, 20, 20);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(777, 449);
            this.main_panel.TabIndex = 12;
            // 
            // PlayerFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(944, 549);
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PlayerFrm";
            this.Text = "播放";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PlayerFrm_Load);
            this.Shown += new System.EventHandler(this.PlayerFrm_Shown);
            this.Resize += new System.EventHandler(this.Form_Resize);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.dantu_btn.ResumeLayout(false);
            this.dantu_btn.PerformLayout();
            this.four_btn.ResumeLayout(false);
            this.four_btn.PerformLayout();
            this.six_btn.ResumeLayout(false);
            this.six_btn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel six_btn;
        private System.Windows.Forms.Panel four_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label titleLable;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.Panel dantu_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private ToolStripButton exitImage;
    }
}