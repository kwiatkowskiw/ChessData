namespace LoginApplication
{
    partial class frmAlert_Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlert_Register));
            this.title = new System.Windows.Forms.Label();
            this.apply = new System.Windows.Forms.Button();
            this.header = new System.Windows.Forms.Panel();
            this.minimalized = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.correct_icon = new System.Windows.Forms.PictureBox();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.correct_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.title.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.title.Location = new System.Drawing.Point(90, 57);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(186, 23);
            this.title.TabIndex = 0;
            this.title.Text = "You are Registered!";
            // 
            // apply
            // 
            this.apply.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.apply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.apply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.apply.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.apply.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.apply.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.apply.Location = new System.Drawing.Point(80, 119);
            this.apply.Name = "apply";
            this.apply.Size = new System.Drawing.Size(130, 38);
            this.apply.TabIndex = 26;
            this.apply.TabStop = false;
            this.apply.Text = "Apply";
            this.apply.UseVisualStyleBackColor = false;
            this.apply.Click += new System.EventHandler(this.apply_Click);
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.DarkRed;
            this.header.Controls.Add(this.minimalized);
            this.header.Controls.Add(this.exit);
            this.header.Controls.Add(this.label1);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(296, 28);
            this.header.TabIndex = 28;
            // 
            // minimalized
            // 
            this.minimalized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimalized.AutoSize = true;
            this.minimalized.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimalized.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.minimalized.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.minimalized.Location = new System.Drawing.Point(302, 0);
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
            this.exit.Location = new System.Drawing.Point(327, 4);
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
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Register";
            // 
            // correct_icon
            // 
            this.correct_icon.ErrorImage = null;
            this.correct_icon.Image = ((System.Drawing.Image)(resources.GetObject("correct_icon.Image")));
            this.correct_icon.InitialImage = null;
            this.correct_icon.Location = new System.Drawing.Point(34, 53);
            this.correct_icon.Name = "correct_icon";
            this.correct_icon.Size = new System.Drawing.Size(40, 33);
            this.correct_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.correct_icon.TabIndex = 27;
            this.correct_icon.TabStop = false;
            // 
            // frmAlert_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(296, 192);
            this.Controls.Add(this.header);
            this.Controls.Add(this.correct_icon);
            this.Controls.Add(this.apply);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAlert_Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAlert_Register";
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.correct_icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button apply;
        private System.Windows.Forms.PictureBox correct_icon;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Label minimalized;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Label label1;
    }
}