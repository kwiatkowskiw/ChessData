namespace LoginApplication
{
    partial class frmContact
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
            this.label1 = new System.Windows.Forms.Label();
            this.adminTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.subjectTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.messageTxt = new System.Windows.Forms.TextBox();
            this.bt_sendmail = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.userTxt = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(43, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "If you want to contact with us please send email: ";
            // 
            // adminTxt
            // 
            this.adminTxt.Enabled = false;
            this.adminTxt.Location = new System.Drawing.Point(169, 49);
            this.adminTxt.Name = "adminTxt";
            this.adminTxt.Size = new System.Drawing.Size(751, 22);
            this.adminTxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(43, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Admin Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(43, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Your Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F);
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(43, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Subject:";
            // 
            // subjectTxt
            // 
            this.subjectTxt.Location = new System.Drawing.Point(169, 183);
            this.subjectTxt.Name = "subjectTxt";
            this.subjectTxt.Size = new System.Drawing.Size(751, 22);
            this.subjectTxt.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F);
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(43, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Message:";
            // 
            // messageTxt
            // 
            this.messageTxt.Location = new System.Drawing.Point(169, 231);
            this.messageTxt.Multiline = true;
            this.messageTxt.Name = "messageTxt";
            this.messageTxt.Size = new System.Drawing.Size(751, 186);
            this.messageTxt.TabIndex = 8;
            // 
            // bt_sendmail
            // 
            this.bt_sendmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(0)))));
            this.bt_sendmail.FlatAppearance.BorderSize = 0;
            this.bt_sendmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_sendmail.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.bt_sendmail.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bt_sendmail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_sendmail.Location = new System.Drawing.Point(441, 516);
            this.bt_sendmail.Name = "bt_sendmail";
            this.bt_sendmail.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.bt_sendmail.Size = new System.Drawing.Size(119, 37);
            this.bt_sendmail.TabIndex = 12;
            this.bt_sendmail.Text = " Send Email";
            this.bt_sendmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_sendmail.UseVisualStyleBackColor = false;
            this.bt_sendmail.Click += new System.EventHandler(this.bt_sendmail_Click);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F);
            this.status.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.status.Location = new System.Drawing.Point(43, 497);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 25);
            this.status.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F);
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(43, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Password:";
            // 
            // userTxt
            // 
            this.userTxt.Location = new System.Drawing.Point(169, 91);
            this.userTxt.Name = "userTxt";
            this.userTxt.Size = new System.Drawing.Size(751, 22);
            this.userTxt.TabIndex = 3;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(169, 135);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(258, 22);
            this.password.TabIndex = 15;
            // 
            // frmContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(960, 565);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.status);
            this.Controls.Add(this.bt_sendmail);
            this.Controls.Add(this.messageTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.subjectTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.userTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.adminTxt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmContact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmContact";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox adminTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox subjectTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox messageTxt;
        private System.Windows.Forms.Button bt_sendmail;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox userTxt;
        private System.Windows.Forms.TextBox password;
    }
}