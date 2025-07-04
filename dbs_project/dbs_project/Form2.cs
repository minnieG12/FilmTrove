using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using Oracle.ManagedDataAccess.Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace dbs_project
{
    public partial class Form2: Form
    {
        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt; DataRow dr;
        int i = 0;
        public Form2()
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

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                // Check format and disallow @email.com domain
                return addr.Address == email && !email.ToLower().EndsWith("@email.com");
            }
            catch
            {
                return false;
            }
        }

        public string GenerateNextUserId()
        {
            string query = @"
        SELECT user_id FROM (
            SELECT user_id FROM dbs_user ORDER BY user_id DESC
        ) WHERE ROWNUM = 1";

            connectdb();
            comm = new OracleCommand(query);
            comm.Connection = conn;
                object result = comm.ExecuteScalar();

                if (result != null)
                {
                    string lastId = result.ToString(); // e.g., "U007"
                    int number = int.Parse(lastId.Substring(1)); // remove 'U' and parse number
                    number++;
                    return "U" + number.ToString("D3"); // format to U008
                }
                else
                {
                    return "U001"; // first user
                }
            
        }

        private void verify_email_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(user_name.Text) || string.IsNullOrEmpty(user_email.Text) || string.IsNullOrEmpty(password.Text) || string.IsNullOrEmpty(confirm_p.Text) || string.IsNullOrEmpty(security_ans.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            connectdb();
            comm = new OracleCommand();
            comm.Connection = conn;
            string newUserId = GenerateNextUserId();
            string toEmail = user_email.Text;
            
            if (!Regex.IsMatch(user_name.Text, @"^[A-Za-z\s]+$"))
            {
                MessageBox.Show("Name must contain only letters.");
                return;
            }

            if (!IsValidEmail(toEmail))
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }
            
            if (password.Text.Length < 7 || password.Text.Length > 77)
            {
                MessageBox.Show("Password must be between 7 to 77 characters long.");
                return;
            }
            
            DateTime dob = dobpicker.Value;
            int age = DateTime.Now.Year - dob.Year;
            if(dob.Year>DateTime.Now.Year)
            {
                MessageBox.Show("Enter a valid birth date -_-");
            }
            // Adjust if the birthday hasn't occurred yet this year
            if (dob > DateTime.Now.AddYears(-age)) age--;

            if (age < 18)
            {
                MessageBox.Show("You must be at least 18 years old to register 🤨");
                return;
            }
            if (password.Text!=confirm_p.Text)
            {
                MessageBox.Show("Confirm password is incorrect.");
                return;
            }

            comm.CommandText = "insert into DBS_USER values('" + newUserId + "', '" + user_name.Text + "', '" + user_email.Text + "', '" + password.Text + "', '" + dobpicker.Text + "', '" + security_ans.Text + "' )";
            comm.CommandType = CommandType.Text;
            comm.ExecuteNonQuery(); MessageBox.Show("You can log in now ❗❗");
            //comm.Dispose();
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
