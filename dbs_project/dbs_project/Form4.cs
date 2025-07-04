using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbs_project
{

    public partial class Form4: Form
    {
        OracleConnection conn;
        string guest_email = "guest@email.com"; string guest_id = "G101";
        private string loggedInUserEmail; // Store the logged-in user's email
        private string loggedInUserID; // Store the logged-in user's ID
        public Form4(string userEmail)
        {
            InitializeComponent();
            loggedInUserEmail = userEmail;
            connect1();
            LoadUserDetails();
        }
        public void connect1()
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
        private void LoadUserDetails()
        {
            if (loggedInUserEmail != guest_email)
            {
                try
                {
                    string query = "SELECT name, user_id, dob FROM dbs_user WHERE email = :email";

                    using (OracleCommand command = new OracleCommand(query, conn))
                    {
                        command.Parameters.Add(new OracleParameter("email", loggedInUserEmail));

                        using (OracleDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())  // If user data is found
                            {
                                email.Text = loggedInUserEmail;
                                name.Text = reader["name"].ToString();
                                //user_id.Text = reader["user_id"].ToString();
                                dob.Text = Convert.ToDateTime(reader["dob"]).ToString("yyyy-MM-dd");
                            }
                            else
                            {
                                MessageBox.Show("❌ User details not found.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("🚨 Error loading user details: " + ex.Message);
                }
            }
            else
            {
                name.Text = "Guest User";
                email.Text = "N/A"; dob.Text = "N/A";
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
        }

        private void view_recently_watched_Click(object sender, EventArgs e)
        {
            if (loggedInUserEmail != guest_email)
            {
                Form6 watch_history = new Form6(loggedInUserEmail);
            this.Hide();
            watch_history.ShowDialog();
            this.Close();
            }
            else
            {
                MessageBox.Show("Login to access all features 🤡");
                return;
            }
        }

        private void recommend_Click(object sender, EventArgs e)
        {
            if (loggedInUserEmail != guest_email)
            {
                string query = "SELECT user_id FROM dbs_user WHERE email = :email";
                OracleCommand command = new OracleCommand(query, conn);
                command.Parameters.Add(new OracleParameter("email", loggedInUserEmail));
                OracleDataReader reader = command.ExecuteReader();
                reader.Read();
                loggedInUserID = reader["user_id"].ToString();
                Form7 rec_page = new Form7(loggedInUserID, loggedInUserEmail);
                this.Hide();
                rec_page.ShowDialog();
                this.Close();
            }
            else
            {
                Form7 rec_page = new Form7(guest_id, guest_email);
                this.Hide();
                rec_page.ShowDialog();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (loggedInUserEmail != guest_email)
            {
                Form5 reset_page = new Form5();
                this.Hide();
                reset_page.ShowDialog();
                this.Close();
            }
            else { MessageBox.Show("Login to access all features 🤡"); return; }
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
