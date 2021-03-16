namespace LoginApplication
{
    partial class frmAddplayer
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
            this.exit2 = new System.Windows.Forms.Label();
            this.minimalized = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.apply = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.salary = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.radio_female = new System.Windows.Forms.RadioButton();
            this.radio_male = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lastname = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.firstname = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ranking = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.birthday = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.date_Time = new System.Windows.Forms.DateTimePicker();
            this.header.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.DarkRed;
            this.header.Controls.Add(this.exit2);
            this.header.Controls.Add(this.minimalized);
            this.header.Controls.Add(this.exit);
            this.header.Controls.Add(this.label1);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(823, 28);
            this.header.TabIndex = 13;
            // 
            // exit2
            // 
            this.exit2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exit2.AutoSize = true;
            this.exit2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exit2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.exit2.Location = new System.Drawing.Point(797, 4);
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
            this.minimalized.Location = new System.Drawing.Point(829, 0);
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
            this.exit.Location = new System.Drawing.Point(853, 4);
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
            this.label1.Size = new System.Drawing.Size(120, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Add New Player";
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
            this.apply.Location = new System.Drawing.Point(280, 379);
            this.apply.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.apply.Name = "apply";
            this.apply.Size = new System.Drawing.Size(251, 38);
            this.apply.TabIndex = 38;
            this.apply.TabStop = false;
            this.apply.Text = "Apply";
            this.apply.UseVisualStyleBackColor = false;
            this.apply.Click += new System.EventHandler(this.apply_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Location = new System.Drawing.Point(203, 281);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 1);
            this.panel3.TabIndex = 37;
            // 
            // salary
            // 
            this.salary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.salary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.salary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.salary.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.salary.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.salary.HideSelection = false;
            this.salary.Location = new System.Drawing.Point(203, 255);
            this.salary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(200, 20);
            this.salary.TabIndex = 36;
            this.salary.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(45, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 19);
            this.label5.TabIndex = 35;
            this.label5.Text = "Salary";
            // 
            // radio_female
            // 
            this.radio_female.AutoSize = true;
            this.radio_female.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.radio_female.Location = new System.Drawing.Point(315, 192);
            this.radio_female.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radio_female.Name = "radio_female";
            this.radio_female.Size = new System.Drawing.Size(71, 21);
            this.radio_female.TabIndex = 34;
            this.radio_female.TabStop = true;
            this.radio_female.Text = "female";
            this.radio_female.UseVisualStyleBackColor = true;
            // 
            // radio_male
            // 
            this.radio_male.AutoSize = true;
            this.radio_male.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.radio_male.Location = new System.Drawing.Point(203, 192);
            this.radio_male.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radio_male.Name = "radio_male";
            this.radio_male.Size = new System.Drawing.Size(59, 21);
            this.radio_male.TabIndex = 33;
            this.radio_male.TabStop = true;
            this.radio_male.Text = "male";
            this.radio_male.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(45, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 19);
            this.label4.TabIndex = 32;
            this.label4.Text = "Sex";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(45, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 19);
            this.label3.TabIndex = 31;
            this.label3.Text = "LastName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(45, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 19);
            this.label2.TabIndex = 30;
            this.label2.Text = "Firstname";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Location = new System.Drawing.Point(203, 145);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 1);
            this.panel2.TabIndex = 29;
            // 
            // lastname
            // 
            this.lastname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lastname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.lastname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lastname.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lastname.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lastname.HideSelection = false;
            this.lastname.Location = new System.Drawing.Point(203, 119);
            this.lastname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(200, 20);
            this.lastname.TabIndex = 28;
            this.lastname.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(203, 78);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 1);
            this.panel1.TabIndex = 27;
            // 
            // firstname
            // 
            this.firstname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.firstname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.firstname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstname.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.firstname.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.firstname.HideSelection = false;
            this.firstname.Location = new System.Drawing.Point(203, 52);
            this.firstname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(200, 20);
            this.firstname.TabIndex = 26;
            this.firstname.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Location = new System.Drawing.Point(584, 78);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 1);
            this.panel4.TabIndex = 41;
            // 
            // ranking
            // 
            this.ranking.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ranking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.ranking.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ranking.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ranking.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ranking.HideSelection = false;
            this.ranking.Location = new System.Drawing.Point(584, 52);
            this.ranking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ranking.Name = "ranking";
            this.ranking.Size = new System.Drawing.Size(200, 20);
            this.ranking.TabIndex = 40;
            this.ranking.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(468, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 19);
            this.label6.TabIndex = 39;
            this.label6.Text = "Ranking";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(468, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 19);
            this.label7.TabIndex = 42;
            this.label7.Text = "Team";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(469, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 19);
            this.label8.TabIndex = 45;
            this.label8.Text = "Continent";
            // 
            // birthday
            // 
            this.birthday.AutoSize = true;
            this.birthday.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.birthday.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.birthday.Location = new System.Drawing.Point(469, 262);
            this.birthday.Name = "birthday";
            this.birthday.Size = new System.Drawing.Size(76, 19);
            this.birthday.TabIndex = 48;
            this.birthday.Text = "Birthday";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(584, 119);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(199, 24);
            this.comboBox1.TabIndex = 51;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Africa",
            "Asia",
            "Australia",
            "Europe",
            "North America",
            "South America"});
            this.comboBox2.Location = new System.Drawing.Point(584, 188);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(199, 24);
            this.comboBox2.TabIndex = 52;
            // 
            // date_Time
            // 
            this.date_Time.CustomFormat = "yyyy-MM-dd";
            this.date_Time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_Time.Location = new System.Drawing.Point(584, 259);
            this.date_Time.Name = "date_Time";
            this.date_Time.Size = new System.Drawing.Size(112, 22);
            this.date_Time.TabIndex = 67;
            this.date_Time.Value = new System.DateTime(1990, 1, 1, 23, 59, 0, 0);
            // 
            // frmAddplayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(823, 497);
            this.Controls.Add(this.date_Time);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.birthday);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.ranking);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.apply);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.salary);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.radio_female);
            this.Controls.Add(this.radio_male);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.firstname);
            this.Controls.Add(this.header);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAddplayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_addplayer";
            this.Load += new System.EventHandler(this.frm_addplayer_Load);
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
        private System.Windows.Forms.Button apply;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox salary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radio_female;
        private System.Windows.Forms.RadioButton radio_male;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox firstname;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox ranking;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label birthday;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DateTimePicker date_Time;
    }
}