namespace PasswordManagement
{
    partial class Export
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Export));
            this.ExportPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ExportPathDirectory = new System.Windows.Forms.Button();
            this.ExportInitialize = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ExportGauge = new Bunifu.Framework.UI.BunifuGauge();
            this.ExportExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExportPath
            // 
            this.ExportPath.Location = new System.Drawing.Point(30, 52);
            this.ExportPath.Multiline = true;
            this.ExportPath.Name = "ExportPath";
            this.ExportPath.Size = new System.Drawing.Size(430, 24);
            this.ExportPath.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select a path to export:";
            // 
            // ExportPathDirectory
            // 
            this.ExportPathDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportPathDirectory.Location = new System.Drawing.Point(466, 52);
            this.ExportPathDirectory.Name = "ExportPathDirectory";
            this.ExportPathDirectory.Size = new System.Drawing.Size(62, 24);
            this.ExportPathDirectory.TabIndex = 5;
            this.ExportPathDirectory.Text = "...";
            this.ExportPathDirectory.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ExportPathDirectory.UseVisualStyleBackColor = true;
            // 
            // ExportInitialize
            // 
            this.ExportInitialize.ActiveBorderThickness = 2;
            this.ExportInitialize.ActiveCornerRadius = 1;
            this.ExportInitialize.ActiveFillColor = System.Drawing.Color.White;
            this.ExportInitialize.ActiveForecolor = System.Drawing.Color.Crimson;
            this.ExportInitialize.ActiveLineColor = System.Drawing.Color.Crimson;
            this.ExportInitialize.BackColor = System.Drawing.Color.Crimson;
            this.ExportInitialize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExportInitialize.BackgroundImage")));
            this.ExportInitialize.ButtonText = "Export";
            this.ExportInitialize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExportInitialize.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportInitialize.ForeColor = System.Drawing.Color.Crimson;
            this.ExportInitialize.IdleBorderThickness = 1;
            this.ExportInitialize.IdleCornerRadius = 1;
            this.ExportInitialize.IdleFillColor = System.Drawing.Color.White;
            this.ExportInitialize.IdleForecolor = System.Drawing.Color.Crimson;
            this.ExportInitialize.IdleLineColor = System.Drawing.Color.White;
            this.ExportInitialize.Location = new System.Drawing.Point(187, 220);
            this.ExportInitialize.Margin = new System.Windows.Forms.Padding(8);
            this.ExportInitialize.Name = "ExportInitialize";
            this.ExportInitialize.Size = new System.Drawing.Size(173, 83);
            this.ExportInitialize.TabIndex = 17;
            this.ExportInitialize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExportGauge
            // 
            this.ExportGauge.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExportGauge.BackgroundImage")));
            this.ExportGauge.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.ExportGauge.Location = new System.Drawing.Point(187, 89);
            this.ExportGauge.Margin = new System.Windows.Forms.Padding(6);
            this.ExportGauge.Name = "ExportGauge";
            this.ExportGauge.ProgressBgColor = System.Drawing.Color.Gray;
            this.ExportGauge.ProgressColor1 = System.Drawing.Color.SeaGreen;
            this.ExportGauge.ProgressColor2 = System.Drawing.Color.Tomato;
            this.ExportGauge.Size = new System.Drawing.Size(173, 117);
            this.ExportGauge.Suffix = "";
            this.ExportGauge.TabIndex = 6;
            this.ExportGauge.Thickness = 30;
            this.ExportGauge.Value = 0;
            // 
            // ExportExit
            // 
            this.ExportExit.BackColor = System.Drawing.Color.White;
            this.ExportExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExportExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportExit.ForeColor = System.Drawing.Color.Crimson;
            this.ExportExit.Location = new System.Drawing.Point(548, 3);
            this.ExportExit.Name = "ExportExit";
            this.ExportExit.Size = new System.Drawing.Size(19, 19);
            this.ExportExit.TabIndex = 18;
            this.ExportExit.Text = "X";
            this.ExportExit.UseVisualStyleBackColor = false;
            // 
            // Export
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(570, 320);
            this.Controls.Add(this.ExportExit);
            this.Controls.Add(this.ExportInitialize);
            this.Controls.Add(this.ExportGauge);
            this.Controls.Add(this.ExportPathDirectory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExportPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Export";
            this.Text = "Export";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ExportPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ExportPathDirectory;
        private Bunifu.Framework.UI.BunifuGauge ExportGauge;
        private Bunifu.Framework.UI.BunifuThinButton2 ExportInitialize;
        private System.Windows.Forms.Button ExportExit;
    }
}