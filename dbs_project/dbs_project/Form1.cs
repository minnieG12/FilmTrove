using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace dbs_project
{
    public partial class Form1: Form
    {
        OracleConnection conn;
        private string admin_email = "filmtroveadmin@gmail.com"; private string admin_id = "A101";
        string guest_email = "guest@email.com"; string guest_id = "G101";
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt; DataRow dr;
        int i = 0;
        public Form1()
        {
            InitializeComponent();
            //MessageBox.Show("🚀 Form1 Initialized!");
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

        private void forgot_pswd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form5 reset_page = new Form5();
            this.Hide();
            reset_page.ShowDialog();
            this.Close();
        }
        
        private void Sign_in_Click(object sender, EventArgs e)
        {
            //connectdb();
            /*try
            {
                connectdb();
                //conn.Open();
                // Get user input
                string userEmail = user_id.Text.Trim();
                string userPassword = password.Text.Trim();
                if (string.IsNullOrEmpty(userEmail) || string.IsNullOrEmpty(userPassword))
                {
                    MessageBox.Show("⚠ Please enter both Email and Password.");
                    return;
                }
                //query time
            */
            //OracleCommand command1 = conn.CreateCommand();
            //command1.CommandText = "select email,password_hash from dbs_user";


            /*string command1 = "SELECT name FROM dbs_user WHERE email = :userEmail AND password_hash = :userPassword";
            using (OracleCommand command = new OracleCommand(command1, conn))
            {
                command.Parameters.Add(new OracleParameter("email", userEmail));
                command.Parameters.Add(new OracleParameter("password_hash", userPassword));

                using (OracleDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string userId = reader["user_id"].ToString();
                        string userName = reader["name"].ToString();

                        MessageBox.Show($"✅ Login Successful! Welcome");

                        // Open the next form (e.g., Dashboard)
                        //Form3 dashboard = new Form3();
                        //this.Hide();
                        //dashboard.Show();
                    }
                    else
                    {
                        MessageBox.Show("❌ Invalid Email or Password. Please try again.");
                    }
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("🚨 Error: " + ex.Message);
        }
        finally
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }*/
            //
            /*command1.CommandType = CommandType.Text;
            string userEmail = user_id.Text.Trim();
            string userPassword = password.Text.Trim();
            OracleDataReader dr = command1.ExecuteReader();
            
            if (dr.Read()) // ✅ Only access fields if there is at least one row
            {
                //user_id.Text = dr["email"].ToString();
                //password.Text = dr["password_hash"].ToString();
                command1.Parameters.Add(new OracleParameter("email", userEmail));
                command1.Parameters.Add(new OracleParameter("password_hash", userPassword));
                using (OracleDataReader reader = command1.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        //string userName = reader["name"].ToString();
                        //string userid = reader["user_id"].ToString();

                        MessageBox.Show($"✅ Login Successful! Welcome");

                        // Open the next form (e.g., Dashboard)
                        Form4 dashboard = new Form4(userEmail);
                        this.Hide();
                        dashboard.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("❌ Invalid Email or Password. Please try again.");
                    }
                }
            }
            else
            {
                MessageBox.Show("No user data found.");
            }

            command1.Dispose();



            conn.Close();*/ 
            connectdb();
            string userPassword = password.Text;
            string userEmail = user_id.Text;
            comm = new OracleCommand();
            if(string.IsNullOrWhiteSpace(user_id.Text)|| string.IsNullOrWhiteSpace(password.Text))
            {
                MessageBox.Show("Please enter both email and password❗❗");
                return;
            }
            comm.CommandText = "select password_hash from DBS_USER where email = :p_e";
            comm.CommandType = CommandType.Text;
            comm.Connection = conn;
            OracleParameter pa1 = new OracleParameter();
            pa1.ParameterName = "p_e";
            pa1.DbType = DbType.String;
            pa1.Value = user_id.Text;
            comm.Parameters.Add(pa1);
            object result = comm.ExecuteScalar();
            if (result != null)
            {
                string storedHash = result.ToString();

                // 🧠 You can compare directly if it's plain text
                if (storedHash == userPassword)
                {
                    MessageBox.Show("Login successful!");
                    if (userEmail == admin_email)
                    {
                        Form8 admin_page = new Form8();
                        this.Hide();
                        admin_page.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        Form4 dashboard = new Form4(userEmail);
                        this.Hide();
                        dashboard.ShowDialog();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("❌ Invalid Email or Password. Please try again.");
                }
            }
            else
            {
                MessageBox.Show("❌ Invalid Email or Password. Please try again.");
            }
            //comm.Dispose();
            conn.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 signup_page = new Form2();
            //login_page.Show();
            this.Hide();
            signup_page.ShowDialog();
            this.Close();
        }

        private void guest_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form4 dashboard = new Form4(guest_email);
            this.Hide();
            dashboard.ShowDialog();
            this.Close();
        }
    }
}
