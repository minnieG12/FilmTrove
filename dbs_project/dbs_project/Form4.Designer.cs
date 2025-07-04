namespace dbs_project
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.name = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.dob = new System.Windows.Forms.Label();
            this.view_recently_watched = new System.Windows.Forms.Button();
            this.recommend = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.LavenderBlush;
            this.name.Font = new System.Drawing.Font("MS PGothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(400, 217);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(45, 15);
            this.name.TabIndex = 0;
            this.name.Text = "name";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.BackColor = System.Drawing.Color.LavenderBlush;
            this.email.Font = new System.Drawing.Font("MS PGothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(400, 267);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(44, 15);
            this.email.TabIndex = 2;
            this.email.Text = "email";
            // 
            // dob
            // 
            this.dob.AutoSize = true;
            this.dob.BackColor = System.Drawing.Color.LavenderBlush;
            this.dob.Font = new System.Drawing.Font("MS PGothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dob.Location = new System.Drawing.Point(512, 326);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(32, 15);
            this.dob.TabIndex = 3;
            this.dob.Text = "dob";
            // 
            // view_recently_watched
            // 
            this.view_recently_watched.Font = new System.Drawing.Font("MS PGothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_recently_watched.ForeColor = System.Drawing.Color.DeepPink;
            this.view_recently_watched.Location = new System.Drawing.Point(595, 443);
            this.view_recently_watched.Name = "view_recently_watched";
            this.view_recently_watched.Size = new System.Drawing.Size(98, 22);
            this.view_recently_watched.TabIndex = 4;
            this.view_recently_watched.Text = "View";
            this.view_recently_watched.UseVisualStyleBackColor = true;
            this.view_recently_watched.Click += new System.EventHandler(this.view_recently_watched_Click);
            // 
            // recommend
            // 
            this.recommend.Font = new System.Drawing.Font("MS PGothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recommend.ForeColor = System.Drawing.Color.DeepPink;
            this.recommend.Location = new System.Drawing.Point(739, 561);
            this.recommend.Name = "recommend";
            this.recommend.Size = new System.Drawing.Size(123, 30);
            this.recommend.TabIndex = 5;
            this.recommend.Text = "Recommend";
            this.recommend.UseVisualStyleBackColor = true;
            this.recommend.Click += new System.EventHandler(this.recommend_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MS PGothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DeepPink;
            this.button1.Location = new System.Drawing.Point(851, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "Change Password";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // back
            // 
            this.back.AutoSize = true;
            this.back.BackColor = System.Drawing.Color.LavenderBlush;
            this.back.Location = new System.Drawing.Point(1169, 58);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(32, 13);
            this.back.TabIndex = 18;
            this.back.TabStop = true;
            this.back.Text = "Back";
            this.back.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.back_LinkClicked);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.back);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.recommend);
            this.Controls.Add(this.view_recently_watched);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.email);
            this.Controls.Add(this.name);
            this.DoubleBuffered = true;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label dob;
        private System.Windows.Forms.Button view_recently_watched;
        private System.Windows.Forms.Button recommend;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel back;
    }
}