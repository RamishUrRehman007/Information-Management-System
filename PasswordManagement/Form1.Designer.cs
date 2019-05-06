namespace PasswordManagement
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.LoginUsername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.LoginPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.LoginForgotPass = new System.Windows.Forms.LinkLabel();
            this.LoginSignUp = new Bunifu.Framework.UI.BunifuThinButton2();
            this.LoginButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LoginExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginUsername
            // 
            this.LoginUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LoginUsername.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LoginUsername.ForeColor = System.Drawing.Color.White;
            this.LoginUsername.HintForeColor = System.Drawing.Color.White;
            this.LoginUsername.HintText = "Username";
            this.LoginUsername.isPassword = false;
            this.LoginUsername.LineFocusedColor = System.Drawing.SystemColors.HighlightText;
            this.LoginUsername.LineIdleColor = System.Drawing.SystemColors.HighlightText;
            this.LoginUsername.LineMouseHoverColor = System.Drawing.SystemColors.HighlightText;
            this.LoginUsername.LineThickness = 3;
            this.LoginUsername.Location = new System.Drawing.Point(129, 183);
            this.LoginUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LoginUsername.Name = "LoginUsername";
            this.LoginUsername.Size = new System.Drawing.Size(267, 33);
            this.LoginUsername.TabIndex = 1;
            this.LoginUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.LoginUsername.OnValueChanged += new System.EventHandler(this.LoginUsername_OnValueChanged);
            // 
            // LoginPassword
            // 
            this.LoginPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LoginPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LoginPassword.ForeColor = System.Drawing.Color.White;
            this.LoginPassword.HintForeColor = System.Drawing.Color.White;
            this.LoginPassword.HintText = "Password";
            this.LoginPassword.isPassword = false;
            this.LoginPassword.LineFocusedColor = System.Drawing.SystemColors.HighlightText;
            this.LoginPassword.LineIdleColor = System.Drawing.SystemColors.HighlightText;
            this.LoginPassword.LineMouseHoverColor = System.Drawing.SystemColors.HighlightText;
            this.LoginPassword.LineThickness = 3;
            this.LoginPassword.Location = new System.Drawing.Point(129, 233);
            this.LoginPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LoginPassword.Name = "LoginPassword";
            this.LoginPassword.Size = new System.Drawing.Size(267, 33);
            this.LoginPassword.TabIndex = 2;
            this.LoginPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.LoginPassword.OnValueChanged += new System.EventHandler(this.LoginPassword_OnValueChanged);
            // 
            // LoginForgotPass
            // 
            this.LoginForgotPass.ActiveLinkColor = System.Drawing.Color.Cyan;
            this.LoginForgotPass.AutoSize = true;
            this.LoginForgotPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginForgotPass.LinkColor = System.Drawing.Color.Cyan;
            this.LoginForgotPass.Location = new System.Drawing.Point(205, 335);
            this.LoginForgotPass.Name = "LoginForgotPass";
            this.LoginForgotPass.Size = new System.Drawing.Size(106, 15);
            this.LoginForgotPass.TabIndex = 5;
            this.LoginForgotPass.TabStop = true;
            this.LoginForgotPass.Text = "Forgot Password?";
            this.LoginForgotPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // LoginSignUp
            // 
            this.LoginSignUp.ActiveBorderThickness = 2;
            this.LoginSignUp.ActiveCornerRadius = 1;
            this.LoginSignUp.ActiveFillColor = System.Drawing.Color.White;
            this.LoginSignUp.ActiveForecolor = System.Drawing.Color.Crimson;
            this.LoginSignUp.ActiveLineColor = System.Drawing.Color.Crimson;
            this.LoginSignUp.BackColor = System.Drawing.Color.Crimson;
            this.LoginSignUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoginSignUp.BackgroundImage")));
            this.LoginSignUp.ButtonText = "Sign Up";
            this.LoginSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginSignUp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginSignUp.ForeColor = System.Drawing.Color.Crimson;
            this.LoginSignUp.IdleBorderThickness = 1;
            this.LoginSignUp.IdleCornerRadius = 1;
            this.LoginSignUp.IdleFillColor = System.Drawing.Color.White;
            this.LoginSignUp.IdleForecolor = System.Drawing.Color.Crimson;
            this.LoginSignUp.IdleLineColor = System.Drawing.Color.White;
            this.LoginSignUp.Location = new System.Drawing.Point(272, 289);
            this.LoginSignUp.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.LoginSignUp.Name = "LoginSignUp";
            this.LoginSignUp.Size = new System.Drawing.Size(124, 41);
            this.LoginSignUp.TabIndex = 4;
            this.LoginSignUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LoginSignUp.Click += new System.EventHandler(this.LoginSignUp_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.ActiveBorderThickness = 2;
            this.LoginButton.ActiveCornerRadius = 1;
            this.LoginButton.ActiveFillColor = System.Drawing.Color.White;
            this.LoginButton.ActiveForecolor = System.Drawing.Color.Crimson;
            this.LoginButton.ActiveLineColor = System.Drawing.Color.Crimson;
            this.LoginButton.BackColor = System.Drawing.Color.Crimson;
            this.LoginButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoginButton.BackgroundImage")));
            this.LoginButton.ButtonText = "Login";
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.Color.Crimson;
            this.LoginButton.IdleBorderThickness = 1;
            this.LoginButton.IdleCornerRadius = 1;
            this.LoginButton.IdleFillColor = System.Drawing.Color.White;
            this.LoginButton.IdleForecolor = System.Drawing.Color.Crimson;
            this.LoginButton.IdleLineColor = System.Drawing.Color.White;
            this.LoginButton.Location = new System.Drawing.Point(129, 289);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(124, 41);
            this.LoginButton.TabIndex = 3;
            this.LoginButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LoginButton.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PasswordManagement.Properties.Resources._42290597_266235364024150_2241645398600974336_n;
            this.pictureBox1.Location = new System.Drawing.Point(50, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(413, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LoginExit
            // 
            this.LoginExit.BackColor = System.Drawing.Color.White;
            this.LoginExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginExit.ForeColor = System.Drawing.Color.Crimson;
            this.LoginExit.Location = new System.Drawing.Point(491, 2);
            this.LoginExit.Name = "LoginExit";
            this.LoginExit.Size = new System.Drawing.Size(19, 19);
            this.LoginExit.TabIndex = 20;
            this.LoginExit.Text = "X";
            this.LoginExit.UseVisualStyleBackColor = false;
            this.LoginExit.Click += new System.EventHandler(this.LoginExit_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(511, 369);
            this.Controls.Add(this.LoginExit);
            this.Controls.Add(this.LoginForgotPass);
            this.Controls.Add(this.LoginSignUp);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.LoginPassword);
            this.Controls.Add(this.LoginUsername);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox LoginUsername;
        private Bunifu.Framework.UI.BunifuMaterialTextbox LoginPassword;
        private Bunifu.Framework.UI.BunifuThinButton2 LoginButton;
        private Bunifu.Framework.UI.BunifuThinButton2 LoginSignUp;
        private System.Windows.Forms.LinkLabel LoginForgotPass;
        private System.Windows.Forms.Button LoginExit;
    }
}

