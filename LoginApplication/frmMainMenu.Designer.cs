namespace LoginApplication
{
    partial class frmMainMenu
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
            this.header = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.minimalize = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.bt_Contact = new System.Windows.Forms.Button();
            this.bt_Classification = new System.Windows.Forms.Button();
            this.bt_Players = new System.Windows.Forms.Button();
            this.bt_Database = new System.Windows.Forms.Button();
            this.bt_Logout = new System.Windows.Forms.Button();
            this.bt_Home = new System.Windows.Forms.Button();
            this.panelTimer = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.header.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.DarkRed;
            this.header.Controls.Add(this.label1);
            this.header.Controls.Add(this.minimalize);
            this.header.Controls.Add(this.exit);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1200, 35);
            this.header.TabIndex = 1;
            this.header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.header_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "ChessData";
            // 
            // minimalize
            // 
            this.minimalize.AutoSize = true;
            this.minimalize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimalize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minimalize.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.minimalize.Location = new System.Drawing.Point(1137, 5);
            this.minimalize.Name = "minimalize";
            this.minimalize.Size = new System.Drawing.Size(19, 25);
            this.minimalize.TabIndex = 1;
            this.minimalize.Text = "-";
            this.minimalize.Click += new System.EventHandler(this.minimalize_Click);
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.exit.Location = new System.Drawing.Point(1162, 5);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(26, 25);
            this.exit.TabIndex = 0;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.bt_Contact);
            this.panelMenu.Controls.Add(this.bt_Classification);
            this.panelMenu.Controls.Add(this.bt_Players);
            this.panelMenu.Controls.Add(this.bt_Database);
            this.panelMenu.Controls.Add(this.bt_Logout);
            this.panelMenu.Controls.Add(this.bt_Home);
            this.panelMenu.Controls.Add(this.panelTimer);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 35);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(240, 565);
            this.panelMenu.TabIndex = 2;
            // 
            // bt_Contact
            // 
            this.bt_Contact.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_Contact.FlatAppearance.BorderSize = 0;
            this.bt_Contact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Contact.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F);
            this.bt_Contact.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bt_Contact.Image = global::LoginApplication.Properties.Resources.contact;
            this.bt_Contact.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Contact.Location = new System.Drawing.Point(0, 341);
            this.bt_Contact.Name = "bt_Contact";
            this.bt_Contact.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.bt_Contact.Size = new System.Drawing.Size(240, 65);
            this.bt_Contact.TabIndex = 14;
            this.bt_Contact.Text = "   Contact";
            this.bt_Contact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Contact.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Contact.UseVisualStyleBackColor = true;
            this.bt_Contact.Click += new System.EventHandler(this.bt_Contact_Click);
            // 
            // bt_Classification
            // 
            this.bt_Classification.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_Classification.FlatAppearance.BorderSize = 0;
            this.bt_Classification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Classification.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F);
            this.bt_Classification.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bt_Classification.Image = global::LoginApplication.Properties.Resources.classification;
            this.bt_Classification.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Classification.Location = new System.Drawing.Point(0, 276);
            this.bt_Classification.Name = "bt_Classification";
            this.bt_Classification.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.bt_Classification.Size = new System.Drawing.Size(240, 65);
            this.bt_Classification.TabIndex = 13;
            this.bt_Classification.Text = "   Classification";
            this.bt_Classification.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Classification.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Classification.UseVisualStyleBackColor = true;
            this.bt_Classification.Click += new System.EventHandler(this.bt_Classification_Click);
            // 
            // bt_Players
            // 
            this.bt_Players.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_Players.FlatAppearance.BorderSize = 0;
            this.bt_Players.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Players.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F);
            this.bt_Players.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bt_Players.Image = global::LoginApplication.Properties.Resources.user;
            this.bt_Players.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Players.Location = new System.Drawing.Point(0, 211);
            this.bt_Players.Name = "bt_Players";
            this.bt_Players.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.bt_Players.Size = new System.Drawing.Size(240, 65);
            this.bt_Players.TabIndex = 12;
            this.bt_Players.Text = "   Players";
            this.bt_Players.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Players.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Players.UseVisualStyleBackColor = true;
            this.bt_Players.Click += new System.EventHandler(this.bt_Players_Click);
            // 
            // bt_Database
            // 
            this.bt_Database.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_Database.FlatAppearance.BorderSize = 0;
            this.bt_Database.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Database.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F);
            this.bt_Database.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bt_Database.Image = global::LoginApplication.Properties.Resources._base;
            this.bt_Database.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Database.Location = new System.Drawing.Point(0, 146);
            this.bt_Database.Name = "bt_Database";
            this.bt_Database.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.bt_Database.Size = new System.Drawing.Size(240, 65);
            this.bt_Database.TabIndex = 11;
            this.bt_Database.Text = "   Database";
            this.bt_Database.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Database.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Database.UseVisualStyleBackColor = true;
            this.bt_Database.Click += new System.EventHandler(this.bt_Database_Click);
            // 
            // bt_Logout
            // 
            this.bt_Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(0)))));
            this.bt_Logout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bt_Logout.FlatAppearance.BorderSize = 0;
            this.bt_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Logout.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F);
            this.bt_Logout.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bt_Logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Logout.Location = new System.Drawing.Point(0, 496);
            this.bt_Logout.Name = "bt_Logout";
            this.bt_Logout.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.bt_Logout.Size = new System.Drawing.Size(240, 69);
            this.bt_Logout.TabIndex = 9;
            this.bt_Logout.Text = "Logout";
            this.bt_Logout.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.bt_Logout.UseVisualStyleBackColor = false;
            this.bt_Logout.Click += new System.EventHandler(this.bt_Logout_Click);
            // 
            // bt_Home
            // 
            this.bt_Home.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_Home.FlatAppearance.BorderSize = 0;
            this.bt_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Home.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F);
            this.bt_Home.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bt_Home.Image = global::LoginApplication.Properties.Resources.home2;
            this.bt_Home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Home.Location = new System.Drawing.Point(0, 81);
            this.bt_Home.Name = "bt_Home";
            this.bt_Home.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.bt_Home.Size = new System.Drawing.Size(240, 65);
            this.bt_Home.TabIndex = 4;
            this.bt_Home.Text = "   Home";
            this.bt_Home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Home.UseVisualStyleBackColor = true;
            this.bt_Home.Click += new System.EventHandler(this.bt_Home_Click);
            // 
            // panelTimer
            // 
            this.panelTimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelTimer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTimer.Location = new System.Drawing.Point(0, 0);
            this.panelTimer.Name = "panelTimer";
            this.panelTimer.Size = new System.Drawing.Size(240, 81);
            this.panelTimer.TabIndex = 3;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Controls.Add(this.label3);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTop.Location = new System.Drawing.Point(240, 35);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(960, 565);
            this.panelTop.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(622, 520);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Write Program: Wiktor Kwiatkowski";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(31, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(370, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Welcome To Program With Catalogy Chess";
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMainMenu";
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label minimalize;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelTimer;
        private System.Windows.Forms.Button bt_Home;
        private System.Windows.Forms.Button bt_Logout;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button bt_Contact;
        private System.Windows.Forms.Button bt_Classification;
        private System.Windows.Forms.Button bt_Players;
        private System.Windows.Forms.Button bt_Database;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}