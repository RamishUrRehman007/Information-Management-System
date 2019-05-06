namespace PasswordManagement
{
    partial class EntryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntryForm));
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.EntrySiteName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.EntryUsername = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.EntryPassword = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.EntryEmail = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.EntryNumber = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.EntryCreate = new Bunifu.Framework.UI.BunifuThinButton2();
            this.EntryExit = new System.Windows.Forms.Button();
            this.EntryUpdate = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(19, 37);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(117, 20);
            this.bunifuCustomLabel1.TabIndex = 6;
            this.bunifuCustomLabel1.Text = "Website Name:";
            this.bunifuCustomLabel1.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // EntrySiteName
            // 
            this.EntrySiteName.BackColor = System.Drawing.Color.White;
            this.EntrySiteName.BorderColorFocused = System.Drawing.Color.Blue;
            this.EntrySiteName.BorderColorIdle = System.Drawing.Color.White;
            this.EntrySiteName.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.EntrySiteName.BorderThickness = 3;
            this.EntrySiteName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EntrySiteName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.EntrySiteName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EntrySiteName.isPassword = false;
            this.EntrySiteName.Location = new System.Drawing.Point(143, 32);
            this.EntrySiteName.Margin = new System.Windows.Forms.Padding(4);
            this.EntrySiteName.Name = "EntrySiteName";
            this.EntrySiteName.Size = new System.Drawing.Size(257, 25);
            this.EntrySiteName.TabIndex = 7;
            this.EntrySiteName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // EntryUsername
            // 
            this.EntryUsername.BackColor = System.Drawing.Color.White;
            this.EntryUsername.BorderColorFocused = System.Drawing.Color.Blue;
            this.EntryUsername.BorderColorIdle = System.Drawing.Color.White;
            this.EntryUsername.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.EntryUsername.BorderThickness = 3;
            this.EntryUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EntryUsername.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.EntryUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EntryUsername.isPassword = false;
            this.EntryUsername.Location = new System.Drawing.Point(143, 67);
            this.EntryUsername.Margin = new System.Windows.Forms.Padding(4);
            this.EntryUsername.Name = "EntryUsername";
            this.EntryUsername.Size = new System.Drawing.Size(257, 25);
            this.EntryUsername.TabIndex = 8;
            this.EntryUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // EntryPassword
            // 
            this.EntryPassword.BackColor = System.Drawing.Color.White;
            this.EntryPassword.BorderColorFocused = System.Drawing.Color.Blue;
            this.EntryPassword.BorderColorIdle = System.Drawing.Color.White;
            this.EntryPassword.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.EntryPassword.BorderThickness = 3;
            this.EntryPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EntryPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.EntryPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EntryPassword.isPassword = false;
            this.EntryPassword.Location = new System.Drawing.Point(143, 100);
            this.EntryPassword.Margin = new System.Windows.Forms.Padding(4);
            this.EntryPassword.Name = "EntryPassword";
            this.EntryPassword.Size = new System.Drawing.Size(257, 25);
            this.EntryPassword.TabIndex = 9;
            this.EntryPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // EntryEmail
            // 
            this.EntryEmail.BackColor = System.Drawing.Color.White;
            this.EntryEmail.BorderColorFocused = System.Drawing.Color.Blue;
            this.EntryEmail.BorderColorIdle = System.Drawing.Color.White;
            this.EntryEmail.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.EntryEmail.BorderThickness = 3;
            this.EntryEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EntryEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.EntryEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EntryEmail.isPassword = false;
            this.EntryEmail.Location = new System.Drawing.Point(143, 133);
            this.EntryEmail.Margin = new System.Windows.Forms.Padding(4);
            this.EntryEmail.Name = "EntryEmail";
            this.EntryEmail.Size = new System.Drawing.Size(257, 25);
            this.EntryEmail.TabIndex = 10;
            this.EntryEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // EntryNumber
            // 
            this.EntryNumber.BackColor = System.Drawing.Color.White;
            this.EntryNumber.BorderColorFocused = System.Drawing.Color.Blue;
            this.EntryNumber.BorderColorIdle = System.Drawing.Color.White;
            this.EntryNumber.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.EntryNumber.BorderThickness = 3;
            this.EntryNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EntryNumber.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.EntryNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EntryNumber.isPassword = false;
            this.EntryNumber.Location = new System.Drawing.Point(143, 166);
            this.EntryNumber.Margin = new System.Windows.Forms.Padding(4);
            this.EntryNumber.Name = "EntryNumber";
            this.EntryNumber.Size = new System.Drawing.Size(257, 25);
            this.EntryNumber.TabIndex = 11;
            this.EntryNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(49, 67);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(87, 20);
            this.bunifuCustomLabel2.TabIndex = 12;
            this.bunifuCustomLabel2.Text = "Username:";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(54, 100);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(82, 20);
            this.bunifuCustomLabel3.TabIndex = 13;
            this.bunifuCustomLabel3.Text = "Password:";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(84, 133);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(52, 20);
            this.bunifuCustomLabel4.TabIndex = 14;
            this.bunifuCustomLabel4.Text = "Email:";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(37, 166);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(99, 20);
            this.bunifuCustomLabel5.TabIndex = 15;
            this.bunifuCustomLabel5.Text = "Cell Number:";
            // 
            // EntryCreate
            // 
            this.EntryCreate.ActiveBorderThickness = 2;
            this.EntryCreate.ActiveCornerRadius = 1;
            this.EntryCreate.ActiveFillColor = System.Drawing.Color.White;
            this.EntryCreate.ActiveForecolor = System.Drawing.Color.Crimson;
            this.EntryCreate.ActiveLineColor = System.Drawing.Color.Crimson;
            this.EntryCreate.BackColor = System.Drawing.Color.Crimson;
            this.EntryCreate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EntryCreate.BackgroundImage")));
            this.EntryCreate.ButtonText = "Create";
            this.EntryCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EntryCreate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntryCreate.ForeColor = System.Drawing.Color.Crimson;
            this.EntryCreate.IdleBorderThickness = 1;
            this.EntryCreate.IdleCornerRadius = 1;
            this.EntryCreate.IdleFillColor = System.Drawing.Color.White;
            this.EntryCreate.IdleForecolor = System.Drawing.Color.Crimson;
            this.EntryCreate.IdleLineColor = System.Drawing.Color.White;
            this.EntryCreate.Location = new System.Drawing.Point(227, 213);
            this.EntryCreate.Margin = new System.Windows.Forms.Padding(8);
            this.EntryCreate.Name = "EntryCreate";
            this.EntryCreate.Size = new System.Drawing.Size(132, 73);
            this.EntryCreate.TabIndex = 16;
            this.EntryCreate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EntryCreate.Visible = false;
            this.EntryCreate.Click += new System.EventHandler(this.EntryCreate_Click);
            // 
            // EntryExit
            // 
            this.EntryExit.BackColor = System.Drawing.Color.White;
            this.EntryExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EntryExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntryExit.ForeColor = System.Drawing.Color.Crimson;
            this.EntryExit.Location = new System.Drawing.Point(403, 2);
            this.EntryExit.Name = "EntryExit";
            this.EntryExit.Size = new System.Drawing.Size(19, 19);
            this.EntryExit.TabIndex = 20;
            this.EntryExit.Text = "X";
            this.EntryExit.UseVisualStyleBackColor = false;
            this.EntryExit.Click += new System.EventHandler(this.EntryExit_Click);
            // 
            // EntryUpdate
            // 
            this.EntryUpdate.ActiveBorderThickness = 2;
            this.EntryUpdate.ActiveCornerRadius = 1;
            this.EntryUpdate.ActiveFillColor = System.Drawing.Color.White;
            this.EntryUpdate.ActiveForecolor = System.Drawing.Color.Crimson;
            this.EntryUpdate.ActiveLineColor = System.Drawing.Color.Crimson;
            this.EntryUpdate.BackColor = System.Drawing.Color.Crimson;
            this.EntryUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EntryUpdate.BackgroundImage")));
            this.EntryUpdate.ButtonText = "Update";
            this.EntryUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EntryUpdate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntryUpdate.ForeColor = System.Drawing.Color.Crimson;
            this.EntryUpdate.IdleBorderThickness = 1;
            this.EntryUpdate.IdleCornerRadius = 1;
            this.EntryUpdate.IdleFillColor = System.Drawing.Color.White;
            this.EntryUpdate.IdleForecolor = System.Drawing.Color.Crimson;
            this.EntryUpdate.IdleLineColor = System.Drawing.Color.White;
            this.EntryUpdate.Location = new System.Drawing.Point(53, 213);
            this.EntryUpdate.Margin = new System.Windows.Forms.Padding(8);
            this.EntryUpdate.Name = "EntryUpdate";
            this.EntryUpdate.Size = new System.Drawing.Size(120, 73);
            this.EntryUpdate.TabIndex = 21;
            this.EntryUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EntryUpdate.Visible = false;
            this.EntryUpdate.Click += new System.EventHandler(this.EntryUpdate_Click);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 2;
            this.bunifuThinButton21.ActiveCornerRadius = 1;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.Crimson;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.Crimson;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.Crimson;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "OK";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.Crimson;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 1;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.Crimson;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.White;
            this.bunifuThinButton21.Location = new System.Drawing.Point(367, 311);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(8);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(52, 46);
            this.bunifuThinButton21.TabIndex = 22;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // EntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(424, 360);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.EntryUpdate);
            this.Controls.Add(this.EntryExit);
            this.Controls.Add(this.EntryCreate);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.EntryNumber);
            this.Controls.Add(this.EntryEmail);
            this.Controls.Add(this.EntryPassword);
            this.Controls.Add(this.EntryUsername);
            this.Controls.Add(this.EntrySiteName);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EntryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EntryForm";
            this.Load += new System.EventHandler(this.EntryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMetroTextbox EntrySiteName;
        private Bunifu.Framework.UI.BunifuMetroTextbox EntryUsername;
        private Bunifu.Framework.UI.BunifuMetroTextbox EntryPassword;
        private Bunifu.Framework.UI.BunifuMetroTextbox EntryEmail;
        private Bunifu.Framework.UI.BunifuMetroTextbox EntryNumber;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuThinButton2 EntryCreate;
        private System.Windows.Forms.Button EntryExit;
        private Bunifu.Framework.UI.BunifuThinButton2 EntryUpdate;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;

    }
}