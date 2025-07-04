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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace dbs_project
{
    public partial class Form7: Form
    {

        OracleConnection conn;
        private string loggedInUserEmail; // Store the logged-in user's email
        private string loggedInUserID; // Store the logged-in user's ID
        string guest_email = "guest@email.com"; string guest_id = "G101";
        string query;
        OracleCommand cmd;
        OracleDataReader reader;
        public Form7(string userID, string userEmail)
        {
            InitializeComponent();
            loggedInUserID = userID;
            loggedInUserEmail = userEmail;
            connect1();
            //MessageBox.Show(userID);
            ShowRecommendations();
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
        private void ShowRecommendations()
        {
            if (loggedInUserEmail!=guest_email && loggedInUserID!=guest_id)
            {
            connect1();
            OracleCommand cmd = new OracleCommand("Get_Recommendations", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("p_user_id", OracleDbType.Varchar2).Value = loggedInUserID;
            OracleParameter refCursorParam = new OracleParameter("p_result", OracleDbType.RefCursor);
            refCursorParam.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(refCursorParam);
            OracleDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            // Set the DataSource of the DataGridView to display the results
            rec_table.DataSource = dt;
            conn.Close();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            connect1();
            query = "SELECT DISTINCT GENRE_NAME FROM DBS_MOVIE_GENRE ORDER BY GENRE_NAME ASC";
            cmd = new OracleCommand(query, conn);
            reader = cmd.ExecuteReader();
            genre.Items.Clear();

            // Step 5: Loop through results and add to ComboBox
            while (reader.Read())
            {
                genre.Items.Add(reader["GENRE_NAME"].ToString());
            }
            query = "SELECT DISTINCT LANG_NAME FROM DBS_LANGUAGE ORDER BY LANG_NAME ASC";
            cmd = new OracleCommand(query, conn);
            reader = cmd.ExecuteReader();
            language.Items.Clear();

            // Step 5: Loop through results and add to ComboBox
            while (reader.Read())
            {
                language.Items.Add(reader["LANG_NAME"].ToString());
            }
            
            conn.Close();
        }

        private void search_Click(object sender, EventArgs e)
        {
            connect1();
            // Validate inputs
            if (string.IsNullOrWhiteSpace(genre.Text) ||
                string.IsNullOrWhiteSpace(language.Text) ||
                string.IsNullOrWhiteSpace(dur_max.Text) ||
                string.IsNullOrWhiteSpace(rating_min.Text))
            {
                MessageBox.Show("Please fill in all the filter fields.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Try parsing numerical inputs
            if (!int.TryParse(dur_max.Text, out int maxDuration) ||
                !decimal.TryParse(rating_min.Text, out decimal minRating))
            {
                MessageBox.Show("Please enter valid numbers for Duration and Rating.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            cmd = new OracleCommand("Get_Default_Recommendations", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("p_genre_name", OracleDbType.Varchar2).Value = genre.Text;
            cmd.Parameters.Add("p_lang_name", OracleDbType.Varchar2).Value = language.Text;
            //cmd.Parameters.Add("p_streaming_platform", OracleDbType.Varchar2).Value = stream.Text;
            cmd.Parameters.Add("p_max_duration", OracleDbType.Int32).Value = maxDuration;
            cmd.Parameters.Add("p_min_rating", OracleDbType.Decimal).Value = minRating;
            cmd.Parameters.Add("p_result", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            defrec_table.DataSource = dt;

            conn.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form4 dashboard = new Form4(loggedInUserEmail);
            this.Hide();
            dashboard.ShowDialog();
            this.Close();
        }
    }
}
