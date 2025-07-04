using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace dbs_project
{
    public partial class Form5: Form
    {
        OracleConnection conn;
        public Form5()
        {
            InitializeComponent();
        }

        public void connectdb()
        {
            try
            {
                String oradb = "<connection string>";
                conn = new OracleConnection(oradb);
                conn.Open();
                //MessageBox.Show("Loading...");
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Connection Failed: " + ex.Message);
            }
        }
        private void verify_email_Click(object sender, EventArgs e)
        {
            connectdb();
            string email = userEmail.Text;
            string securityAnswer = security_ans.Text;
            string newPassword = n_pass.Text;
            string confirmPassword = confirm_n_pass.Text;
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(securityAnswer) ||
        string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("All fields are required.");
                return;
            }
            string query = "SELECT COUNT(*) FROM dbs_user WHERE email = :email AND security = :security";
            OracleCommand cmd = new OracleCommand(query, conn);
            cmd.Parameters.Add(":email", OracleDbType.Varchar2).Value = email;
            cmd.Parameters.Add(":security", OracleDbType.Varchar2).Value = securityAnswer;

            int count = Convert.ToInt32(cmd.ExecuteScalar());

            if (count == 1)
            {
                if (newPassword != confirmPassword)
                {
                    MessageBox.Show("Passwords do not match.");
                    return;
                }
                // Step 6: Update password
                string updateQuery = "UPDATE dbs_user SET password_hash = :newPassword WHERE email = :email";
                OracleCommand updateCmd = new OracleCommand(updateQuery, conn);
                updateCmd.Parameters.Add(":newPassword", OracleDbType.Varchar2).Value = newPassword;
                updateCmd.Parameters.Add(":email", OracleDbType.Varchar2).Value = email;

                updateCmd.ExecuteNonQuery();
                MessageBox.Show("Password reset successful!");
            }
            else
            {
                MessageBox.Show("Invalid email or security answer.");
            }
            conn.Close();
        }

        private void back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 login_page = new Form1();
            //login_page.Show();
            this.Hide();
            login_page.ShowDialog();
            this.Close();
        }
    }
}
