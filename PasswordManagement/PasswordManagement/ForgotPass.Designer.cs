namespace PasswordManagement
{
    partial class ForgotPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPass));
            this.CodeSend = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SMSSend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CodeConfirm = new System.Windows.Forms.TextBox();
            this.CodeContinue = new Bunifu.Framework.UI.BunifuThinButton2();
            this.CodeExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CodeSend
            // 
            this.CodeSend.Location = new System.Drawing.Point(12, 85);
            this.CodeSend.Name = "CodeSend";
            this.CodeSend.Size = new System.Drawing.Size(151, 20);
            this.CodeSend.TabIndex = 0;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(9, 42);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(505, 30);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "A 6 digit code will be sent to your registered phone number to help you login to " +
    "your account.\r\nEnter your phone number below:";
            this.bunifuCustomLabel1.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // SMSSend
            // 
            this.SMSSend.Location = new System.Drawing.Point(169, 83);
            this.SMSSend.Name = "SMSSend";
            this.SMSSend.Size = new System.Drawing.Size(75, 23);
            this.SMSSend.TabIndex = 2;
            this.SMSSend.Text = "Send Code";
            this.SMSSend.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter the 6 digit code below to continue:";
            // 
            // CodeConfirm
            // 
            this.CodeConfirm.Location = new System.Drawing.Point(12, 146);
            this.CodeConfirm.Name = "CodeConfirm";
            this.CodeConfirm.Size = new System.Drawing.Size(120, 20);
            this.CodeConfirm.TabIndex = 4;
            // 
            // CodeContinue
            // 
            this.CodeContinue.ActiveBorderThickness = 1;
            this.CodeContinue.ActiveCornerRadius = 2;
            this.CodeContinue.ActiveFillColor = System.Drawing.Color.White;
            this.CodeContinue.ActiveForecolor = System.Drawing.Color.Crimson;
            this.CodeContinue.ActiveLineColor = System.Drawing.Color.White;
            this.CodeContinue.BackColor = System.Drawing.Color.Crimson;
            this.CodeContinue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CodeContinue.BackgroundImage")));
            this.CodeContinue.ButtonText = "Continue";
            this.CodeContinue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CodeContinue.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodeContinue.ForeColor = System.Drawing.Color.Crimson;
            this.CodeContinue.IdleBorderThickness = 1;
            this.CodeContinue.IdleCornerRadius = 1;
            this.CodeContinue.IdleFillColor = System.Drawing.Color.White;
            this.CodeContinue.IdleForecolor = System.Drawing.Color.Crimson;
            this.CodeContinue.IdleLineColor = System.Drawing.Color.White;
            this.CodeContinue.Location = new System.Drawing.Point(318, 193);
            this.CodeContinue.Margin = new System.Windows.Forms.Padding(5);
            this.CodeContinue.Name = "CodeContinue";
            this.CodeContinue.Size = new System.Drawing.Size(181, 41);
            this.CodeContinue.TabIndex = 5;
            this.CodeContinue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CodeExit
            // 
            this.CodeExit.BackColor = System.Drawing.Color.White;
            this.CodeExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CodeExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodeExit.ForeColor = System.Drawing.Color.Crimson;
            this.CodeExit.Location = new System.Drawing.Point(489, 6);
            this.CodeExit.Name = "CodeExit";
            this.CodeExit.Size = new System.Drawing.Size(19, 19);
            this.CodeExit.TabIndex = 19;
            this.CodeExit.Text = "X";
            this.CodeExit.UseVisualStyleBackColor = false;
            // 
            // ForgotPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(513, 248);
            this.Controls.Add(this.CodeExit);
            this.Controls.Add(this.CodeContinue);
            this.Controls.Add(this.CodeConfirm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SMSSend);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.CodeSend);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ForgotPass";
            this.Text = "ForgotPass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CodeSend;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Button SMSSend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CodeConfirm;
        private Bunifu.Framework.UI.BunifuThinButton2 CodeContinue;
        private System.Windows.Forms.Button CodeExit;
    }
}