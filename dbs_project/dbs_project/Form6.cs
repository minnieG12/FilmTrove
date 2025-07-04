using Oracle.ManagedDataAccess.Client;
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

namespace dbs_project
{
    
    public partial class Form6: Form
    {
        OracleConnection conn;
        OracleCommand comm;
        DataSet ds;
        OracleDataAdapter da;
        DataTable dt;
        DataRow dr; string query; OracleDataReader reader;
        int i;
        private string loggedInUserEmail; // Store the logged-in user's email
        private string loggedInUserID; // Store the logged-in user's ID
        public Form6(string userEmail)
        {
            InitializeComponent();
            loggedInUserEmail = userEmail;
            connect1();
            LoadWatchHistory();
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
        private void LoadWatchHistory()
        {
            connect1();
            string query = @"select title, watch_date, duration_watched, review, rating from dbs_user natural join dbs_recently_watched natural join dbs_rating natural join dbs_movies where email = :email";
            comm = new OracleCommand(query,conn);
            comm.Parameters.Add(new OracleParameter("email", loggedInUserEmail));
            //comm.CommandText = "select title, watch_date, duration_watched, review, rating from dbs_user natural join dbs_recently_watched natural join dbs_rating natural join dbs_movies where email = :email";
            //comm.CommandType = CommandType.Text;
            //ds = new DataSet();
            da = new OracleDataAdapter(comm);
            dt = new DataTable();
            da.Fill(dt);
            //dt = ds.Tables["Result"];
            
            //dr = dt.Rows[i];
            history_table.DataSource = dt;
            //history_table.DataMember = "Result";
            conn.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form4 dashboard = new Form4(loggedInUserEmail);
            this.Hide();
            dashboard.ShowDialog();
            this.Close();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            connect1();
            query = "SELECT TITLE FROM DBS_MOVIES ORDER BY TITLE ASC";
            comm = new OracleCommand(query, conn);
            reader = comm.ExecuteReader();
            movies.Items.Clear();

            // Step 5: Loop through results and add to ComboBox
            while (reader.Read())
            {
                movies.Items.Add(reader["TITLE"].ToString());
            }
            conn.Close();
        }

        private void Add_wh_Click(object sender, EventArgs e)
        {
            connect1();
            string selectedMovie = movies.Text;
            string review = review_txt.Text.Trim();
            string ratingStr = rating_txt.Text.Trim();

            // Validate empty fields
            if (string.IsNullOrEmpty(selectedMovie) || string.IsNullOrEmpty(ratingStr) || string.IsNullOrEmpty(review))
            {
                MessageBox.Show("❗ All fields are required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate rating range and precision
            if (!decimal.TryParse(ratingStr, out decimal rating) || rating < 1 || rating > 10)
            {
                MessageBox.Show("⭐ Please enter a valid rating between 1 and 10.", "Invalid Rating", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Decimal.Round(rating, 1) != rating)
            {
                MessageBox.Show("⚠ Only one decimal place is allowed (e.g., 7.5, 9.3)", "Invalid Precision", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (review.Length > 254)
            {
                MessageBox.Show("📝 Review should be 255 characters or fewer.", "Limit Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string query = "SELECT user_id FROM dbs_user WHERE email = :email";
            OracleCommand command = new OracleCommand(query, conn);
            command.Parameters.Add(new OracleParameter("email", loggedInUserEmail));
            OracleDataReader reader = command.ExecuteReader();
            reader.Read();
            loggedInUserID = reader["user_id"].ToString();
            string getMovieId = "SELECT movie_id FROM dbs_movies WHERE title = :title";
            OracleCommand cmdMovie = new OracleCommand(getMovieId, conn);
            cmdMovie.Parameters.Add("title", selectedMovie);
            string movieId = cmdMovie.ExecuteScalar()?.ToString();
            // Validate if both user and movie exist
            if (string.IsNullOrEmpty(loggedInUserID) || string.IsNullOrEmpty(movieId))
            {
                MessageBox.Show("❌ Could not find movie or user. Please check selection.");
                return;
            }
            
                string insertWatch = @"
                INSERT INTO dbs_Recently_Watched (user_id, movie_id, watch_date, duration_watched)
                VALUES (:user_id, :movie_id, :watch_date, 
                        (SELECT duration FROM dbs_movies WHERE movie_id = :movie_id))";
                OracleCommand cmdWatch = new OracleCommand(insertWatch, conn);
                cmdWatch.Parameters.Add("user_id", loggedInUserID);
                cmdWatch.Parameters.Add("movie_id", movieId);
                cmdWatch.Parameters.Add("watch_date", watch_date.Text);
                cmdWatch.ExecuteNonQuery();
            

            string upsert = @"
            MERGE INTO dbs_rating r
            USING DUAL
            ON (r.user_id = :user_id AND r.movie_id = :movie_id)
            WHEN MATCHED THEN
                UPDATE SET r.rating = :rating, r.review = :review
            WHEN NOT MATCHED THEN
                INSERT (user_id, movie_id, rating, review)
                VALUES (:user_id, :movie_id, :rating, :review)";

            OracleCommand cmd = new OracleCommand(upsert, conn);
            cmd.Parameters.Add("user_id", loggedInUserID);
            cmd.Parameters.Add("movie_id", movieId);
            cmd.Parameters.Add("rating", rating);
            cmd.Parameters.Add("review", review);

            cmd.ExecuteNonQuery();

            MessageBox.Show("✅ Review submitted successfully!");
            LoadWatchHistory(); // Refresh the table
            conn.Close();
        }
    }

}
