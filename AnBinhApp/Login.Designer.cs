
namespace AnBinhApp
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.usernameHoverLine = new System.Windows.Forms.Panel();
            this.passwordLine = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkRememberLogin = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.loginBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Inter Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên người dùng";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Inter Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(38, 308);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(429, 25);
            this.textBox1.TabIndex = 1;
            this.textBox1.Click += new System.EventHandler(this.username_click);
            this.textBox1.Enter += new System.EventHandler(this.username_click);
            this.textBox1.MouseEnter += new System.EventHandler(this.username_hover);
            this.textBox1.MouseLeave += new System.EventHandler(this.username_leave);
            // 
            // usernameHoverLine
            // 
            this.usernameHoverLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.usernameHoverLine.Location = new System.Drawing.Point(38, 335);
            this.usernameHoverLine.Name = "usernameHoverLine";
            this.usernameHoverLine.Size = new System.Drawing.Size(430, 3);
            this.usernameHoverLine.TabIndex = 2;
            // 
            // passwordLine
            // 
            this.passwordLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.passwordLine.Location = new System.Drawing.Point(38, 448);
            this.passwordLine.Name = "passwordLine";
            this.passwordLine.Size = new System.Drawing.Size(430, 3);
            this.passwordLine.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Inter Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(38, 421);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(429, 25);
            this.textBox2.TabIndex = 4;
            this.textBox2.Click += new System.EventHandler(this.password_click);
            this.textBox2.MouseEnter += new System.EventHandler(this.password_enter);
            this.textBox2.MouseLeave += new System.EventHandler(this.password_leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Inter Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mật khẩu";
            // 
            // checkRememberLogin
            // 
            this.checkRememberLogin.AutoSize = true;
            this.checkRememberLogin.Font = new System.Drawing.Font("Inter Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkRememberLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(156)))), ((int)(((byte)(240)))));
            this.checkRememberLogin.Location = new System.Drawing.Point(38, 516);
            this.checkRememberLogin.Name = "checkRememberLogin";
            this.checkRememberLogin.Size = new System.Drawing.Size(149, 24);
            this.checkRememberLogin.TabIndex = 7;
            this.checkRememberLogin.Text = "Lưu đăng nhập";
            this.checkRememberLogin.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Inter Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(156)))), ((int)(((byte)(240)))));
            this.linkLabel1.Location = new System.Drawing.Point(357, 520);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(130, 20);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Quên mật khẩu";
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(156)))), ((int)(((byte)(240)))));
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Inter Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginBtn.Location = new System.Drawing.Point(37, 634);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(430, 59);
            this.loginBtn.TabIndex = 9;
            this.loginBtn.Text = "Đăng nhập";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.clickLogin);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Inter Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(171, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Đăng nhập để tiếp tục";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Inter Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(136, 579);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Chưa có tài khoản?";
            // 
            // linkLabel2
            // 
            this.linkLabel2.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Inter Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(156)))), ((int)(((byte)(240)))));
            this.linkLabel2.Location = new System.Drawing.Point(293, 579);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(73, 20);
            this.linkLabel2.TabIndex = 12;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Đăng ký";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.clickRegister);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(188, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 140);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(505, 722);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.checkRememberLogin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.passwordLine);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.usernameHoverLine);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel usernameHoverLine;
        private System.Windows.Forms.Panel passwordLine;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkRememberLogin;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}