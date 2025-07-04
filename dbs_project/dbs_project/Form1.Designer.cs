namespace dbs_project
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.user_id = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.forgot_pswd = new System.Windows.Forms.LinkLabel();
            this.Sign_in = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.guest_login = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // user_id
            // 
            this.user_id.Font = new System.Drawing.Font("MS PGothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_id.Location = new System.Drawing.Point(534, 365);
            this.user_id.Name = "user_id";
            this.user_id.Size = new System.Drawing.Size(362, 20);
            this.user_id.TabIndex = 1;
            this.user_id.Text = "enter email";
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("MS PGothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(534, 453);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(362, 20);
            this.password.TabIndex = 3;
            // 
            // forgot_pswd
            // 
            this.forgot_pswd.AutoSize = true;
            this.forgot_pswd.BackColor = System.Drawing.Color.LavenderBlush;
            this.forgot_pswd.Font = new System.Drawing.Font("MingLiU-ExtB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgot_pswd.LinkArea = new System.Windows.Forms.LinkArea(0, 16);
            this.forgot_pswd.Location = new System.Drawing.Point(795, 476);
            this.forgot_pswd.Name = "forgot_pswd";
            this.forgot_pswd.Size = new System.Drawing.Size(101, 12);
            this.forgot_pswd.TabIndex = 4;
            this.forgot_pswd.TabStop = true;
            this.forgot_pswd.Text = "Forgot Password?";
            this.forgot_pswd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forgot_pswd_LinkClicked);
            // 
            // Sign_in
            // 
            this.Sign_in.Font = new System.Drawing.Font("MS PGothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sign_in.ForeColor = System.Drawing.Color.DeepPink;
            this.Sign_in.Location = new System.Drawing.Point(670, 640);
            this.Sign_in.Name = "Sign_in";
            this.Sign_in.Size = new System.Drawing.Size(91, 27);
            this.Sign_in.TabIndex = 5;
            this.Sign_in.Text = "Sign in";
            this.Sign_in.UseVisualStyleBackColor = true;
            this.Sign_in.Click += new System.EventHandler(this.Sign_in_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.LavenderBlush;
            this.linkLabel1.Font = new System.Drawing.Font("MingLiU-ExtB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkArea = new System.Windows.Forms.LinkArea(0, 20);
            this.linkLabel1.Location = new System.Drawing.Point(771, 388);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(125, 12);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Not a user? Sign up!";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // guest_login
            // 
            this.guest_login.AutoSize = true;
            this.guest_login.BackColor = System.Drawing.Color.LavenderBlush;
            this.guest_login.Font = new System.Drawing.Font("MingLiU-ExtB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guest_login.LinkArea = new System.Windows.Forms.LinkArea(0, 40);
            this.guest_login.Location = new System.Drawing.Point(607, 670);
            this.guest_login.Name = "guest_login";
            this.guest_login.Size = new System.Drawing.Size(215, 19);
            this.guest_login.TabIndex = 7;
            this.guest_login.TabStop = true;
            this.guest_login.Text = "or click here to sign in as guest!";
            this.guest_login.UseCompatibleTextRendering = true;
            this.guest_login.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.guest_login_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.guest_login);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Sign_in);
            this.Controls.Add(this.forgot_pswd);
            this.Controls.Add(this.password);
            this.Controls.Add(this.user_id);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Sign in";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox user_id;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.LinkLabel forgot_pswd;
        private System.Windows.Forms.Button Sign_in;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel guest_login;
    }
}

