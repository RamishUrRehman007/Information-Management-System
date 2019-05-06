namespace PasswordManagement
{
    partial class UserDashboard
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.DashLogout = new System.Windows.Forms.Button();
            this.DashNew = new System.Windows.Forms.Button();
            this.DashUpdate = new System.Windows.Forms.Button();
            this.DashDelete = new System.Windows.Forms.Button();
            this.DashExport = new System.Windows.Forms.Button();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DashDataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SidePanel.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            this.LogoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DashDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.White;
            this.SidePanel.Controls.Add(this.DashLogout);
            this.SidePanel.Controls.Add(this.DashNew);
            this.SidePanel.Controls.Add(this.DashUpdate);
            this.SidePanel.Controls.Add(this.DashDelete);
            this.SidePanel.Controls.Add(this.DashExport);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanel.Location = new System.Drawing.Point(0, 0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(196, 506);
            this.SidePanel.TabIndex = 0;
            // 
            // DashLogout
            // 
            this.DashLogout.BackColor = System.Drawing.Color.Crimson;
            this.DashLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DashLogout.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashLogout.ForeColor = System.Drawing.Color.White;
            this.DashLogout.Image = global::PasswordManagement.Properties.Resources.Export_26px;
            this.DashLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DashLogout.Location = new System.Drawing.Point(27, 457);
            this.DashLogout.Name = "DashLogout";
            this.DashLogout.Size = new System.Drawing.Size(134, 37);
            this.DashLogout.TabIndex = 11;
            this.DashLogout.Text = "Logout";
            this.DashLogout.UseVisualStyleBackColor = false;
            this.DashLogout.Click += new System.EventHandler(this.DashLogout_Click);
            // 
            // DashNew
            // 
            this.DashNew.BackColor = System.Drawing.Color.Crimson;
            this.DashNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DashNew.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashNew.ForeColor = System.Drawing.Color.White;
            this.DashNew.Image = global::PasswordManagement.Properties.Resources.Add_File_26px;
            this.DashNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DashNew.Location = new System.Drawing.Point(14, 90);
            this.DashNew.Name = "DashNew";
            this.DashNew.Size = new System.Drawing.Size(164, 39);
            this.DashNew.TabIndex = 10;
            this.DashNew.Text = "New";
            this.DashNew.UseVisualStyleBackColor = false;
            this.DashNew.Click += new System.EventHandler(this.DashNew_Click);
            // 
            // DashUpdate
            // 
            this.DashUpdate.BackColor = System.Drawing.Color.Crimson;
            this.DashUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DashUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashUpdate.ForeColor = System.Drawing.Color.White;
            this.DashUpdate.Image = global::PasswordManagement.Properties.Resources.Edit_File_26px;
            this.DashUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DashUpdate.Location = new System.Drawing.Point(14, 144);
            this.DashUpdate.Name = "DashUpdate";
            this.DashUpdate.Size = new System.Drawing.Size(164, 39);
            this.DashUpdate.TabIndex = 9;
            this.DashUpdate.Text = "Update";
            this.DashUpdate.UseVisualStyleBackColor = false;
            this.DashUpdate.Click += new System.EventHandler(this.button4_Click);
            // 
            // DashDelete
            // 
            this.DashDelete.BackColor = System.Drawing.Color.Crimson;
            this.DashDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DashDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashDelete.ForeColor = System.Drawing.Color.White;
            this.DashDelete.Image = global::PasswordManagement.Properties.Resources.Delete_File_26px;
            this.DashDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DashDelete.Location = new System.Drawing.Point(12, 198);
            this.DashDelete.Name = "DashDelete";
            this.DashDelete.Size = new System.Drawing.Size(166, 39);
            this.DashDelete.TabIndex = 8;
            this.DashDelete.Text = "Delete";
            this.DashDelete.UseVisualStyleBackColor = false;
            this.DashDelete.Click += new System.EventHandler(this.DashDelete_Click);
            // 
            // DashExport
            // 
            this.DashExport.BackColor = System.Drawing.Color.Crimson;
            this.DashExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DashExport.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashExport.ForeColor = System.Drawing.Color.White;
            this.DashExport.Image = global::PasswordManagement.Properties.Resources.Logout_Rounded_Up_26px;
            this.DashExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DashExport.Location = new System.Drawing.Point(14, 254);
            this.DashExport.Name = "DashExport";
            this.DashExport.Size = new System.Drawing.Size(164, 39);
            this.DashExport.TabIndex = 7;
            this.DashExport.Text = "Export";
            this.DashExport.UseVisualStyleBackColor = false;
            this.DashExport.Click += new System.EventHandler(this.DashExport_Click);
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.White;
            this.HeaderPanel.Controls.Add(this.textBox2);
            this.HeaderPanel.Controls.Add(this.textBox1);
            this.HeaderPanel.Location = new System.Drawing.Point(193, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(528, 74);
            this.HeaderPanel.TabIndex = 1;
            this.HeaderPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.HeaderPanel_Paint);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(309, 23);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(198, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Crimson;
            this.textBox1.Location = new System.Drawing.Point(9, 23);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(241, 29);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LogoPanel
            // 
            this.LogoPanel.Controls.Add(this.pictureBox1);
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(196, 74);
            this.LogoPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::PasswordManagement.Properties.Resources._42260131_242855233089756_4559570992631906304_n;
            this.pictureBox1.Location = new System.Drawing.Point(10, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // DashDataGrid
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DashDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DashDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DashDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DashDataGrid.BackgroundColor = System.Drawing.Color.Crimson;
            this.DashDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DashDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DashDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DashDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DashDataGrid.DoubleBuffered = true;
            this.DashDataGrid.EnableHeadersVisualStyles = false;
            this.DashDataGrid.GridColor = System.Drawing.SystemColors.ControlText;
            this.DashDataGrid.HeaderBgColor = System.Drawing.Color.LightCoral;
            this.DashDataGrid.HeaderForeColor = System.Drawing.Color.White;
            this.DashDataGrid.Location = new System.Drawing.Point(202, 72);
            this.DashDataGrid.Name = "DashDataGrid";
            this.DashDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DashDataGrid.Size = new System.Drawing.Size(476, 434);
            this.DashDataGrid.TabIndex = 2;
            this.DashDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DashDataGrid_CellContentClick);
            this.DashDataGrid.Click += new System.EventHandler(this.DashDataGrid_Click);
            this.DashDataGrid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DashDataGrid_KeyPress);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // UserDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(720, 506);
            this.Controls.Add(this.DashDataGrid);
            this.Controls.Add(this.LogoPanel);
            this.Controls.Add(this.HeaderPanel);
            this.Controls.Add(this.SidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserDashboard";
            this.SidePanel.ResumeLayout(false);
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.LogoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DashDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button DashExport;
        private System.Windows.Forms.Button DashDelete;
        private System.Windows.Forms.Button DashUpdate;
        private System.Windows.Forms.Button DashNew;
        private System.Windows.Forms.Button DashLogout;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DashDataGrid;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;

    }
}