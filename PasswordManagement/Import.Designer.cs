namespace PasswordManagement
{
    partial class Import
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Import));
            this.label1 = new System.Windows.Forms.Label();
            this.ImportPath = new System.Windows.Forms.TextBox();
            this.ImportPathButton = new System.Windows.Forms.Button();
            this.ImportInitialize = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ExportGauge = new Bunifu.Framework.UI.BunifuGauge();
            this.ImportExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select a path to import from:";
            // 
            // ImportPath
            // 
            this.ImportPath.Location = new System.Drawing.Point(23, 59);
            this.ImportPath.Multiline = true;
            this.ImportPath.Name = "ImportPath";
            this.ImportPath.Size = new System.Drawing.Size(430, 24);
            this.ImportPath.TabIndex = 6;
            // 
            // ImportPathButton
            // 
            this.ImportPathButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportPathButton.Location = new System.Drawing.Point(474, 59);
            this.ImportPathButton.Name = "ImportPathButton";
            this.ImportPathButton.Size = new System.Drawing.Size(62, 24);
            this.ImportPathButton.TabIndex = 7;
            this.ImportPathButton.Text = "...";
            this.ImportPathButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ImportPathButton.UseVisualStyleBackColor = true;
            // 
            // ImportInitialize
            // 
            this.ImportInitialize.ActiveBorderThickness = 2;
            this.ImportInitialize.ActiveCornerRadius = 1;
            this.ImportInitialize.ActiveFillColor = System.Drawing.Color.White;
            this.ImportInitialize.ActiveForecolor = System.Drawing.Color.Crimson;
            this.ImportInitialize.ActiveLineColor = System.Drawing.Color.Crimson;
            this.ImportInitialize.BackColor = System.Drawing.Color.Crimson;
            this.ImportInitialize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ImportInitialize.BackgroundImage")));
            this.ImportInitialize.ButtonText = "Import";
            this.ImportInitialize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImportInitialize.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportInitialize.ForeColor = System.Drawing.Color.Crimson;
            this.ImportInitialize.IdleBorderThickness = 1;
            this.ImportInitialize.IdleCornerRadius = 1;
            this.ImportInitialize.IdleFillColor = System.Drawing.Color.White;
            this.ImportInitialize.IdleForecolor = System.Drawing.Color.Crimson;
            this.ImportInitialize.IdleLineColor = System.Drawing.Color.White;
            this.ImportInitialize.Location = new System.Drawing.Point(198, 220);
            this.ImportInitialize.Margin = new System.Windows.Forms.Padding(8);
            this.ImportInitialize.Name = "ImportInitialize";
            this.ImportInitialize.Size = new System.Drawing.Size(174, 83);
            this.ImportInitialize.TabIndex = 18;
            this.ImportInitialize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExportGauge
            // 
            this.ExportGauge.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExportGauge.BackgroundImage")));
            this.ExportGauge.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.ExportGauge.Location = new System.Drawing.Point(198, 102);
            this.ExportGauge.Margin = new System.Windows.Forms.Padding(6);
            this.ExportGauge.Name = "ExportGauge";
            this.ExportGauge.ProgressBgColor = System.Drawing.Color.Gray;
            this.ExportGauge.ProgressColor1 = System.Drawing.Color.SeaGreen;
            this.ExportGauge.ProgressColor2 = System.Drawing.Color.Tomato;
            this.ExportGauge.Size = new System.Drawing.Size(174, 117);
            this.ExportGauge.Suffix = "";
            this.ExportGauge.TabIndex = 8;
            this.ExportGauge.Thickness = 30;
            this.ExportGauge.Value = 0;
            // 
            // ImportExit
            // 
            this.ImportExit.BackColor = System.Drawing.Color.White;
            this.ImportExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImportExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportExit.ForeColor = System.Drawing.Color.Crimson;
            this.ImportExit.Location = new System.Drawing.Point(548, 2);
            this.ImportExit.Name = "ImportExit";
            this.ImportExit.Size = new System.Drawing.Size(19, 19);
            this.ImportExit.TabIndex = 20;
            this.ImportExit.Text = "X";
            this.ImportExit.UseVisualStyleBackColor = false;
            // 
            // Import
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(570, 320);
            this.Controls.Add(this.ImportExit);
            this.Controls.Add(this.ImportInitialize);
            this.Controls.Add(this.ExportGauge);
            this.Controls.Add(this.ImportPathButton);
            this.Controls.Add(this.ImportPath);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Import";
            this.Text = "Import";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ImportPath;
        private System.Windows.Forms.Button ImportPathButton;
        private Bunifu.Framework.UI.BunifuGauge ExportGauge;
        private Bunifu.Framework.UI.BunifuThinButton2 ImportInitialize;
        private System.Windows.Forms.Button ImportExit;
    }
}