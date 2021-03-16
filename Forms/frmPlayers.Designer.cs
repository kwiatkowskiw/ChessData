namespace LoginApplication
{
    partial class frmPlayers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.add = new System.Windows.Forms.Button();
            this.data_players = new System.Windows.Forms.DataGridView();
            this.information = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.file = new System.Windows.Forms.PictureBox();
            this.save = new System.Windows.Forms.PictureBox();
            this.refresh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.data_players)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.file)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.save)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refresh)).BeginInit();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.add.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.add.Location = new System.Drawing.Point(152, 516);
            this.add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(185, 38);
            this.add.TabIndex = 8;
            this.add.TabStop = false;
            this.add.Text = "Add Player";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // data_players
            // 
            this.data_players.AllowUserToAddRows = false;
            this.data_players.AllowUserToDeleteRows = false;
            this.data_players.AllowUserToResizeColumns = false;
            this.data_players.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.data_players.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.data_players.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data_players.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_players.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.data_players.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_players.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.data_players.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(60)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(60)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_players.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.data_players.ColumnHeadersHeight = 25;
            this.data_players.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data_players.DefaultCellStyle = dataGridViewCellStyle7;
            this.data_players.EnableHeadersVisualStyles = false;
            this.data_players.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(151)))), ((int)(((byte)(234)))));
            this.data_players.Location = new System.Drawing.Point(12, 12);
            this.data_players.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.data_players.Name = "data_players";
            this.data_players.ReadOnly = true;
            this.data_players.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(151)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_players.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.data_players.RowHeadersVisible = false;
            this.data_players.RowHeadersWidth = 51;
            this.data_players.RowTemplate.Height = 24;
            this.data_players.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_players.Size = new System.Drawing.Size(936, 492);
            this.data_players.TabIndex = 13;
            // 
            // information
            // 
            this.information.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.information.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.information.Cursor = System.Windows.Forms.Cursors.Hand;
            this.information.Enabled = false;
            this.information.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.information.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.information.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.information.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.information.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.information.Location = new System.Drawing.Point(799, 516);
            this.information.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.information.Name = "information";
            this.information.Size = new System.Drawing.Size(138, 38);
            this.information.TabIndex = 12;
            this.information.TabStop = false;
            this.information.Text = "Search";
            this.information.UseVisualStyleBackColor = false;
            // 
            // delete
            // 
            this.delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete.Enabled = false;
            this.delete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.delete.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.delete.Location = new System.Drawing.Point(590, 516);
            this.delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(185, 38);
            this.delete.TabIndex = 11;
            this.delete.TabStop = false;
            this.delete.Text = "Delete Player";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // edit
            // 
            this.edit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edit.Enabled = false;
            this.edit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.edit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.edit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.edit.Location = new System.Drawing.Point(372, 516);
            this.edit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(185, 38);
            this.edit.TabIndex = 10;
            this.edit.TabStop = false;
            this.edit.Text = "Edit Player";
            this.edit.UseVisualStyleBackColor = false;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // file
            // 
            this.file.Cursor = System.Windows.Forms.Cursors.Hand;
            this.file.Image = global::LoginApplication.Properties.Resources.file;
            this.file.Location = new System.Drawing.Point(54, 527);
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(25, 30);
            this.file.TabIndex = 24;
            this.file.TabStop = false;
            this.file.Click += new System.EventHandler(this.file_Click);
            // 
            // save
            // 
            this.save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save.Image = global::LoginApplication.Properties.Resources.save;
            this.save.Location = new System.Drawing.Point(85, 525);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(42, 30);
            this.save.TabIndex = 23;
            this.save.TabStop = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // refresh
            // 
            this.refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refresh.Image = global::LoginApplication.Properties.Resources.refresh;
            this.refresh.Location = new System.Drawing.Point(12, 517);
            this.refresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(36, 37);
            this.refresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.refresh.TabIndex = 22;
            this.refresh.TabStop = false;
            // 
            // frmPlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(960, 565);
            this.Controls.Add(this.file);
            this.Controls.Add(this.save);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.data_players);
            this.Controls.Add(this.information);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPlayers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPlayers";
            ((System.ComponentModel.ISupportInitialize)(this.data_players)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.file)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.save)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refresh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView data_players;
        public System.Windows.Forms.Button add;
        public System.Windows.Forms.Button information;
        public System.Windows.Forms.Button delete;
        public System.Windows.Forms.Button edit;
        private System.Windows.Forms.PictureBox file;
        private System.Windows.Forms.PictureBox save;
        private System.Windows.Forms.PictureBox refresh;
    }
}