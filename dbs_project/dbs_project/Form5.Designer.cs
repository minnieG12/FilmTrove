namespace dbs_project
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.security_ans = new System.Windows.Forms.TextBox();
            this.n_pass = new System.Windows.Forms.TextBox();
            this.confirm_n_pass = new System.Windows.Forms.TextBox();
            this.verify_email = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.LinkLabel();
            this.userEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // security_ans
            // 
            this.security_ans.Location = new System.Drawing.Point(241, 405);
            this.security_ans.Name = "security_ans";
            this.security_ans.Size = new System.Drawing.Size(232, 20);
            this.security_ans.TabIndex = 13;
            // 
            // n_pass
            // 
            this.n_pass.Location = new System.Drawing.Point(585, 521);
            this.n_pass.Name = "n_pass";
            this.n_pass.Size = new System.Drawing.Size(298, 20);
            this.n_pass.TabIndex = 14;
            // 
            // confirm_n_pass
            // 
            this.confirm_n_pass.Location = new System.Drawing.Point(665, 585);
            this.confirm_n_pass.Name = "confirm_n_pass";
            this.confirm_n_pass.Size = new System.Drawing.Size(298, 20);
            this.confirm_n_pass.TabIndex = 15;
            // 
            // verify_email
            // 
            this.verify_email.Font = new System.Drawing.Font("MS PGothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verify_email.ForeColor = System.Drawing.Color.DeepPink;
            this.verify_email.Location = new System.Drawing.Point(668, 657);
            this.verify_email.Name = "verify_email";
            this.verify_email.Size = new System.Drawing.Size(113, 24);
            this.verify_email.TabIndex = 16;
            this.verify_email.Text = "Submit";
            this.verify_email.UseVisualStyleBackColor = true;
            this.verify_email.Click += new System.EventHandler(this.verify_email_Click);
            // 
            // back
            // 
            this.back.AutoSize = true;
            this.back.BackColor = System.Drawing.Color.LavenderBlush;
            this.back.Location = new System.Drawing.Point(1198, 162);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(32, 13);
            this.back.TabIndex = 17;
            this.back.TabStop = true;
            this.back.Text = "Back";
            this.back.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.back_LinkClicked);
            // 
            // userEmail
            // 
            this.userEmail.Location = new System.Drawing.Point(408, 453);
            this.userEmail.Name = "userEmail";
            this.userEmail.Size = new System.Drawing.Size(232, 20);
            this.userEmail.TabIndex = 18;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.userEmail);
            this.Controls.Add(this.back);
            this.Controls.Add(this.verify_email);
            this.Controls.Add(this.confirm_n_pass);
            this.Controls.Add(this.n_pass);
            this.Controls.Add(this.security_ans);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reset Password";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox security_ans;
        private System.Windows.Forms.TextBox n_pass;
        private System.Windows.Forms.TextBox confirm_n_pass;
        private System.Windows.Forms.Button verify_email;
        private System.Windows.Forms.LinkLabel back;
        private System.Windows.Forms.TextBox userEmail;
    }
}