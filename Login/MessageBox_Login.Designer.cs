namespace LoginApplication
{
    partial class MessageBox_Login
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
            this.txtalert = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Panel();
            this.picalert = new System.Windows.Forms.PictureBox();
            this.apply = new System.Windows.Forms.Button();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picalert)).BeginInit();
            this.SuspendLayout();
            // 
            // txtalert
            // 
            this.txtalert.AutoSize = true;
            this.txtalert.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtalert.Location = new System.Drawing.Point(190, 86);
            this.txtalert.Name = "txtalert";
            this.txtalert.Size = new System.Drawing.Size(154, 34);
            this.txtalert.TabIndex = 0;
            this.txtalert.Text = "Check Your Username \r\nor Login";
            this.txtalert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Alert";
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.DarkRed;
            this.header.Controls.Add(this.label2);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(492, 28);
            this.header.TabIndex = 12;
            // 
            // picalert
            // 
            this.picalert.Image = global::LoginApplication.Properties.Resources.alert;
            this.picalert.Location = new System.Drawing.Point(140, 86);
            this.picalert.Name = "picalert";
            this.picalert.Size = new System.Drawing.Size(34, 34);
            this.picalert.TabIndex = 13;
            this.picalert.TabStop = false;
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
            this.apply.Location = new System.Drawing.Point(193, 211);
            this.apply.Name = "apply";
            this.apply.Size = new System.Drawing.Size(99, 38);
            this.apply.TabIndex = 14;
            this.apply.TabStop = false;
            this.apply.Text = "Ok";
            this.apply.UseVisualStyleBackColor = false;
            this.apply.Click += new System.EventHandler(this.apply_Click);
            // 
            // MessageBox_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(492, 310);
            this.Controls.Add(this.apply);
            this.Controls.Add(this.picalert);
            this.Controls.Add(this.header);
            this.Controls.Add(this.txtalert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessageBox_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MessageBox_Login";
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picalert)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtalert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.PictureBox picalert;
        private System.Windows.Forms.Button apply;
    }
}