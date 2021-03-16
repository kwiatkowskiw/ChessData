namespace LoginApplication
{
    partial class frmEditgame
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
            this.identify = new System.Windows.Forms.Label();
            this.exit2 = new System.Windows.Forms.Label();
            this.minimalized = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.score_black = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.score_white = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.debut = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tournament = new System.Windows.Forms.TextBox();
            this.name_black = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.name_white = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.apply = new System.Windows.Forms.Button();
            this.header.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.DarkRed;
            this.header.Controls.Add(this.identify);
            this.header.Controls.Add(this.exit2);
            this.header.Controls.Add(this.minimalized);
            this.header.Controls.Add(this.exit);
            this.header.Controls.Add(this.label1);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(563, 28);
            this.header.TabIndex = 15;
            // 
            // identify
            // 
            this.identify.AutoSize = true;
            this.identify.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.identify.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.identify.Location = new System.Drawing.Point(91, 2);
            this.identify.Name = "identify";
            this.identify.Size = new System.Drawing.Size(0, 21);
            this.identify.TabIndex = 83;
            // 
            // exit2
            // 
            this.exit2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exit2.AutoSize = true;
            this.exit2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exit2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.exit2.Location = new System.Drawing.Point(536, 4);
            this.exit2.Name = "exit2";
            this.exit2.Size = new System.Drawing.Size(20, 20);
            this.exit2.TabIndex = 15;
            this.exit2.Text = "X";
            this.exit2.Click += new System.EventHandler(this.exit2_Click);
            // 
            // minimalized
            // 
            this.minimalized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimalized.AutoSize = true;
            this.minimalized.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimalized.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.minimalized.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.minimalized.Location = new System.Drawing.Point(568, 0);
            this.minimalized.Name = "minimalized";
            this.minimalized.Size = new System.Drawing.Size(19, 25);
            this.minimalized.TabIndex = 14;
            this.minimalized.Text = "-";
            // 
            // exit
            // 
            this.exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exit.AutoSize = true;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.exit.Location = new System.Drawing.Point(592, 4);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(20, 20);
            this.exit.TabIndex = 12;
            this.exit.Text = "X";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Edit Game";
            // 
            // dateTime
            // 
            this.dateTime.CustomFormat = "yyyy-MM-dd";
            this.dateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime.Location = new System.Drawing.Point(198, 329);
            this.dateTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(112, 22);
            this.dateTime.TabIndex = 81;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(41, 332);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 19);
            this.label8.TabIndex = 80;
            this.label8.Text = "Date";
            // 
            // score_black
            // 
            this.score_black.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.score_black.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.score_black.FormattingEnabled = true;
            this.score_black.Items.AddRange(new object[] {
            "1",
            "0"});
            this.score_black.Location = new System.Drawing.Point(500, 124);
            this.score_black.Margin = new System.Windows.Forms.Padding(4);
            this.score_black.Name = "score_black";
            this.score_black.Size = new System.Drawing.Size(47, 24);
            this.score_black.TabIndex = 79;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(438, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 19);
            this.label7.TabIndex = 78;
            this.label7.Text = "Score";
            // 
            // score_white
            // 
            this.score_white.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.score_white.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.score_white.FormattingEnabled = true;
            this.score_white.Items.AddRange(new object[] {
            "1",
            "0"});
            this.score_white.Location = new System.Drawing.Point(500, 56);
            this.score_white.Margin = new System.Windows.Forms.Padding(4);
            this.score_white.Name = "score_white";
            this.score_white.Size = new System.Drawing.Size(47, 24);
            this.score_white.TabIndex = 77;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(438, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 19);
            this.label6.TabIndex = 76;
            this.label6.Text = "Score";
            // 
            // debut
            // 
            this.debut.Enabled = false;
            this.debut.FormattingEnabled = true;
            this.debut.Location = new System.Drawing.Point(200, 256);
            this.debut.Margin = new System.Windows.Forms.Padding(4);
            this.debut.Name = "debut";
            this.debut.Size = new System.Drawing.Size(199, 24);
            this.debut.TabIndex = 75;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(41, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 19);
            this.label5.TabIndex = 74;
            this.label5.Text = "Debut";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(41, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 19);
            this.label4.TabIndex = 73;
            this.label4.Text = "Tournament";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(199, 205);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 1);
            this.panel1.TabIndex = 72;
            // 
            // tournament
            // 
            this.tournament.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tournament.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.tournament.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tournament.Enabled = false;
            this.tournament.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tournament.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tournament.HideSelection = false;
            this.tournament.Location = new System.Drawing.Point(199, 179);
            this.tournament.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tournament.Name = "tournament";
            this.tournament.Size = new System.Drawing.Size(200, 20);
            this.tournament.TabIndex = 71;
            this.tournament.TabStop = false;
            // 
            // name_black
            // 
            this.name_black.Enabled = false;
            this.name_black.FormattingEnabled = true;
            this.name_black.Location = new System.Drawing.Point(200, 124);
            this.name_black.Margin = new System.Windows.Forms.Padding(4);
            this.name_black.Name = "name_black";
            this.name_black.Size = new System.Drawing.Size(199, 24);
            this.name_black.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(41, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 19);
            this.label3.TabIndex = 69;
            this.label3.Text = "Black";
            // 
            // name_white
            // 
            this.name_white.Enabled = false;
            this.name_white.FormattingEnabled = true;
            this.name_white.Location = new System.Drawing.Point(200, 56);
            this.name_white.Margin = new System.Windows.Forms.Padding(4);
            this.name_white.Name = "name_white";
            this.name_white.Size = new System.Drawing.Size(199, 24);
            this.name_white.TabIndex = 68;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(41, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 67;
            this.label2.Text = "White";
            // 
            // apply
            // 
            this.apply.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.apply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.apply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.apply.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.apply.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.apply.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.apply.Location = new System.Drawing.Point(158, 448);
            this.apply.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.apply.Name = "apply";
            this.apply.Size = new System.Drawing.Size(251, 38);
            this.apply.TabIndex = 82;
            this.apply.TabStop = false;
            this.apply.Text = "Apply";
            this.apply.UseVisualStyleBackColor = false;
            this.apply.Click += new System.EventHandler(this.apply_Click);
            // 
            // frmEditgame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(563, 497);
            this.Controls.Add(this.apply);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.score_black);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.score_white);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.debut);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tournament);
            this.Controls.Add(this.name_black);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.name_white);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEditgame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditgame";
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Label exit2;
        private System.Windows.Forms.Label minimalized;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button apply;
        public System.Windows.Forms.DateTimePicker dateTime;
        public System.Windows.Forms.ComboBox score_black;
        public System.Windows.Forms.ComboBox score_white;
        public System.Windows.Forms.ComboBox debut;
        public System.Windows.Forms.ComboBox name_black;
        public System.Windows.Forms.ComboBox name_white;
        public System.Windows.Forms.Label identify;
        public System.Windows.Forms.TextBox tournament;
    }
}