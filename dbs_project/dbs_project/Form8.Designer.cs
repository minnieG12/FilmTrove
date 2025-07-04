namespace dbs_project
{
    partial class Form8
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.insert = new System.Windows.Forms.Button();
            this.mov_tit = new System.Windows.Forms.TextBox();
            this.dir_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.language = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.genre = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.im_score = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rl_yr = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.duration = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dubs = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.subs = new System.Windows.Forms.ComboBox();
            this.strm_plat = new System.Windows.Forms.ComboBox();
            this.mov_list = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.userEmail = new System.Windows.Forms.TextBox();
            this.delet = new System.Windows.Forms.Button();
            this.user_table = new System.Windows.Forms.DataGridView();
            this.user_data = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_table)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LavenderBlush;
            this.groupBox1.Controls.Add(this.strm_plat);
            this.groupBox1.Controls.Add(this.subs);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.dubs);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.duration);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.rl_yr);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.im_score);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.mov_tit);
            this.groupBox1.Controls.Add(this.dir_name);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.language);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.genre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DeepPink;
            this.groupBox1.Location = new System.Drawing.Point(203, 217);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(757, 160);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insert";
            // 
            // insert
            // 
            this.insert.Font = new System.Drawing.Font("MS PGothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert.ForeColor = System.Drawing.Color.DeepPink;
            this.insert.Location = new System.Drawing.Point(1037, 262);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(87, 20);
            this.insert.TabIndex = 7;
            this.insert.Text = "Insert";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // mov_tit
            // 
            this.mov_tit.Location = new System.Drawing.Point(85, 12);
            this.mov_tit.Name = "mov_tit";
            this.mov_tit.Size = new System.Drawing.Size(256, 23);
            this.mov_tit.TabIndex = 6;
            // 
            // dir_name
            // 
            this.dir_name.Location = new System.Drawing.Point(479, 12);
            this.dir_name.Name = "dir_name";
            this.dir_name.Size = new System.Drawing.Size(256, 23);
            this.dir_name.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS PGothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "Movie Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS PGothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(381, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "Director Name";
            // 
            // language
            // 
            this.language.FormattingEnabled = true;
            this.language.Location = new System.Drawing.Point(253, 53);
            this.language.Name = "language";
            this.language.Size = new System.Drawing.Size(105, 24);
            this.language.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS PGothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(186, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Language";
            // 
            // genre
            // 
            this.genre.FormattingEnabled = true;
            this.genre.Location = new System.Drawing.Point(52, 53);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(105, 24);
            this.genre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS PGothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "Genre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS PGothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(400, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "IMDB Score";
            // 
            // im_score
            // 
            this.im_score.Location = new System.Drawing.Point(482, 53);
            this.im_score.Name = "im_score";
            this.im_score.Size = new System.Drawing.Size(52, 23);
            this.im_score.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS PGothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(572, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "Release Year";
            // 
            // rl_yr
            // 
            this.rl_yr.Location = new System.Drawing.Point(663, 53);
            this.rl_yr.Name = "rl_yr";
            this.rl_yr.Size = new System.Drawing.Size(72, 23);
            this.rl_yr.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS PGothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "Duration (in minutes)";
            // 
            // duration
            // 
            this.duration.Location = new System.Drawing.Point(146, 95);
            this.duration.Name = "duration";
            this.duration.Size = new System.Drawing.Size(72, 23);
            this.duration.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS PGothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(381, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 12);
            this.label8.TabIndex = 14;
            this.label8.Text = "Streaming Platform";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS PGothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 12);
            this.label9.TabIndex = 16;
            this.label9.Text = "Dubbed Audio Availability";
            // 
            // dubs
            // 
            this.dubs.FormattingEnabled = true;
            this.dubs.Items.AddRange(new object[] {
            "Y",
            "N"});
            this.dubs.Location = new System.Drawing.Point(174, 130);
            this.dubs.Name = "dubs";
            this.dubs.Size = new System.Drawing.Size(60, 24);
            this.dubs.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS PGothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(381, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 12);
            this.label10.TabIndex = 18;
            this.label10.Text = "Subtitles Availability";
            // 
            // subs
            // 
            this.subs.FormattingEnabled = true;
            this.subs.Items.AddRange(new object[] {
            "Y",
            "N"});
            this.subs.Location = new System.Drawing.Point(520, 130);
            this.subs.Name = "subs";
            this.subs.Size = new System.Drawing.Size(60, 24);
            this.subs.TabIndex = 19;
            // 
            // strm_plat
            // 
            this.strm_plat.FormattingEnabled = true;
            this.strm_plat.Location = new System.Drawing.Point(508, 95);
            this.strm_plat.Name = "strm_plat";
            this.strm_plat.Size = new System.Drawing.Size(105, 24);
            this.strm_plat.TabIndex = 20;
            // 
            // mov_list
            // 
            this.mov_list.Font = new System.Drawing.Font("MS PGothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mov_list.ForeColor = System.Drawing.Color.DeepPink;
            this.mov_list.Location = new System.Drawing.Point(1017, 304);
            this.mov_list.Name = "mov_list";
            this.mov_list.Size = new System.Drawing.Size(130, 20);
            this.mov_list.TabIndex = 8;
            this.mov_list.Text = "View Movie Listing";
            this.mov_list.UseVisualStyleBackColor = true;
            this.mov_list.Click += new System.EventHandler(this.mov_list_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MS PGothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DeepPink;
            this.label11.Location = new System.Drawing.Point(253, 459);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 12);
            this.label11.TabIndex = 21;
            this.label11.Text = "User Email";
            // 
            // userEmail
            // 
            this.userEmail.Location = new System.Drawing.Point(349, 455);
            this.userEmail.Name = "userEmail";
            this.userEmail.Size = new System.Drawing.Size(256, 20);
            this.userEmail.TabIndex = 21;
            // 
            // delet
            // 
            this.delet.Font = new System.Drawing.Font("MS PGothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delet.ForeColor = System.Drawing.Color.DeepPink;
            this.delet.Location = new System.Drawing.Point(630, 455);
            this.delet.Name = "delet";
            this.delet.Size = new System.Drawing.Size(87, 20);
            this.delet.TabIndex = 22;
            this.delet.Text = "Delete";
            this.delet.UseVisualStyleBackColor = true;
            this.delet.Click += new System.EventHandler(this.delet_Click);
            // 
            // user_table
            // 
            this.user_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.user_table.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.user_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.user_table.DefaultCellStyle = dataGridViewCellStyle1;
            this.user_table.Location = new System.Drawing.Point(255, 491);
            this.user_table.Name = "user_table";
            this.user_table.RowHeadersVisible = false;
            this.user_table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.user_table.Size = new System.Drawing.Size(876, 198);
            this.user_table.TabIndex = 23;
            // 
            // user_data
            // 
            this.user_data.Font = new System.Drawing.Font("MS PGothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_data.ForeColor = System.Drawing.Color.DeepPink;
            this.user_data.Location = new System.Drawing.Point(1001, 459);
            this.user_data.Name = "user_data";
            this.user_data.Size = new System.Drawing.Size(130, 20);
            this.user_data.TabIndex = 24;
            this.user_data.Text = "View User Data";
            this.user_data.UseVisualStyleBackColor = true;
            this.user_data.Click += new System.EventHandler(this.user_data_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.user_data);
            this.Controls.Add(this.user_table);
            this.Controls.Add(this.delet);
            this.Controls.Add(this.userEmail);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.mov_list);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.insert);
            this.Name = "Form8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form8_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.TextBox mov_tit;
        private System.Windows.Forms.TextBox dir_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox language;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox genre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rl_yr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox im_score;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox duration;
        private System.Windows.Forms.ComboBox subs;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox dubs;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox strm_plat;
        private System.Windows.Forms.Button mov_list;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox userEmail;
        private System.Windows.Forms.Button delet;
        private System.Windows.Forms.DataGridView user_table;
        private System.Windows.Forms.Button user_data;
    }
}