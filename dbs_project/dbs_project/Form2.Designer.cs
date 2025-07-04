namespace dbs_project
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.user_name = new System.Windows.Forms.TextBox();
            this.user_email = new System.Windows.Forms.TextBox();
            this.dobpicker = new System.Windows.Forms.DateTimePicker();
            this.password = new System.Windows.Forms.TextBox();
            this.verify_email = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.LinkLabel();
            this.confirm_p = new System.Windows.Forms.TextBox();
            this.security_ans = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // user_name
            // 
            this.user_name.Location = new System.Drawing.Point(369, 293);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(232, 20);
            this.user_name.TabIndex = 5;
            // 
            // user_email
            // 
            this.user_email.Location = new System.Drawing.Point(789, 293);
            this.user_email.Name = "user_email";
            this.user_email.Size = new System.Drawing.Size(298, 20);
            this.user_email.TabIndex = 6;
            // 
            // dobpicker
            // 
            this.dobpicker.Location = new System.Drawing.Point(519, 484);
            this.dobpicker.Name = "dobpicker";
            this.dobpicker.Size = new System.Drawing.Size(136, 20);
            this.dobpicker.TabIndex = 7;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(454, 371);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(298, 20);
            this.password.TabIndex = 8;
            // 
            // verify_email
            // 
            this.verify_email.Font = new System.Drawing.Font("MS PGothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verify_email.ForeColor = System.Drawing.Color.DeepPink;
            this.verify_email.Location = new System.Drawing.Point(664, 658);
            this.verify_email.Name = "verify_email";
            this.verify_email.Size = new System.Drawing.Size(113, 24);
            this.verify_email.TabIndex = 9;
            this.verify_email.Text = "Submit";
            this.verify_email.UseVisualStyleBackColor = true;
            this.verify_email.Click += new System.EventHandler(this.verify_email_Click);
            // 
            // back
            // 
            this.back.AutoSize = true;
            this.back.BackColor = System.Drawing.Color.LavenderBlush;
            this.back.Location = new System.Drawing.Point(1195, 160);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(32, 13);
            this.back.TabIndex = 10;
            this.back.TabStop = true;
            this.back.Text = "Back";
            this.back.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.back_LinkClicked);
            // 
            // confirm_p
            // 
            this.confirm_p.Location = new System.Drawing.Point(619, 427);
            this.confirm_p.Name = "confirm_p";
            this.confirm_p.Size = new System.Drawing.Size(298, 20);
            this.confirm_p.TabIndex = 11;
            // 
            // security_ans
            // 
            this.security_ans.Location = new System.Drawing.Point(423, 633);
            this.security_ans.Name = "security_ans";
            this.security_ans.Size = new System.Drawing.Size(232, 20);
            this.security_ans.TabIndex = 12;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.security_ans);
            this.Controls.Add(this.confirm_p);
            this.Controls.Add(this.back);
            this.Controls.Add(this.verify_email);
            this.Controls.Add(this.password);
            this.Controls.Add(this.dobpicker);
            this.Controls.Add(this.user_email);
            this.Controls.Add(this.user_name);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign Up";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox user_name;
        private System.Windows.Forms.TextBox user_email;
        private System.Windows.Forms.DateTimePicker dobpicker;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button verify_email;
        private System.Windows.Forms.LinkLabel back;
        private System.Windows.Forms.TextBox confirm_p;
        private System.Windows.Forms.TextBox security_ans;
    }
}