﻿namespace WebSever
{
    partial class Sever
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
            this.label1 = new System.Windows.Forms.Label();
            this.t_Ipdress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.t_duankou = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.t_texttalk = new System.Windows.Forms.TextBox();
            this.b_startjian = new System.Windows.Forms.Button();
            this.t_send = new System.Windows.Forms.TextBox();
            this.b_send = new System.Windows.Forms.Button();
            this.l_tishi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "监听IP";
            // 
            // t_Ipdress
            // 
            this.t_Ipdress.Location = new System.Drawing.Point(71, 6);
            this.t_Ipdress.Name = "t_Ipdress";
            this.t_Ipdress.Size = new System.Drawing.Size(100, 25);
            this.t_Ipdress.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "端口";
            // 
            // t_duankou
            // 
            this.t_duankou.Location = new System.Drawing.Point(221, 6);
            this.t_duankou.Name = "t_duankou";
            this.t_duankou.Size = new System.Drawing.Size(49, 25);
            this.t_duankou.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "消息框";
            // 
            // t_texttalk
            // 
            this.t_texttalk.Location = new System.Drawing.Point(18, 84);
            this.t_texttalk.Multiline = true;
            this.t_texttalk.Name = "t_texttalk";
            this.t_texttalk.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.t_texttalk.Size = new System.Drawing.Size(252, 191);
            this.t_texttalk.TabIndex = 5;
            this.t_texttalk.TextChanged += new System.EventHandler(this.t_texttalk_TextChanged);
            // 
            // b_startjian
            // 
            this.b_startjian.Location = new System.Drawing.Point(111, 48);
            this.b_startjian.Name = "b_startjian";
            this.b_startjian.Size = new System.Drawing.Size(75, 23);
            this.b_startjian.TabIndex = 6;
            this.b_startjian.Text = "开始监听";
            this.b_startjian.UseVisualStyleBackColor = true;
            this.b_startjian.Click += new System.EventHandler(this.b_startjian_Click);
            // 
            // t_send
            // 
            this.t_send.Location = new System.Drawing.Point(18, 321);
            this.t_send.Multiline = true;
            this.t_send.Name = "t_send";
            this.t_send.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.t_send.Size = new System.Drawing.Size(252, 92);
            this.t_send.TabIndex = 7;
            // 
            // b_send
            // 
            this.b_send.Location = new System.Drawing.Point(195, 419);
            this.b_send.Name = "b_send";
            this.b_send.Size = new System.Drawing.Size(75, 23);
            this.b_send.TabIndex = 8;
            this.b_send.Text = "发送消息";
            this.b_send.UseVisualStyleBackColor = true;
            this.b_send.Click += new System.EventHandler(this.b_send_Click_1);
            // 
            // l_tishi
            // 
            this.l_tishi.AutoSize = true;
            this.l_tishi.Location = new System.Drawing.Point(15, 292);
            this.l_tishi.Name = "l_tishi";
            this.l_tishi.Size = new System.Drawing.Size(0, 15);
            this.l_tishi.TabIndex = 9;
            // 
            // Sever
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 450);
            this.Controls.Add(this.l_tishi);
            this.Controls.Add(this.b_send);
            this.Controls.Add(this.t_send);
            this.Controls.Add(this.b_startjian);
            this.Controls.Add(this.t_texttalk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.t_duankou);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.t_Ipdress);
            this.Controls.Add(this.label1);
            this.Name = "Sever";
            this.Text = "Tcp服务端";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Sever_FormClosing);
            this.Load += new System.EventHandler(this.Sever_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox t_Ipdress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox t_duankou;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox t_texttalk;
        private System.Windows.Forms.Button b_startjian;
        private System.Windows.Forms.TextBox t_send;
        private System.Windows.Forms.Button b_send;
        private System.Windows.Forms.Label l_tishi;
    }
}

