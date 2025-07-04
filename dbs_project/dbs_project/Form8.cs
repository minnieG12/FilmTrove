using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbs_project
{
    public partial class Form8: Form
    {
        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt; DataRow dr;
        int i = 0;
        string query; OracleDataReader reader;
        public Form8()
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        public string GenerateNextMovieID()
        {
            query = @"
        SELECT movie_id FROM (
            SELECT movie_id FROM dbs_movies ORDER BY movie_id DESC
        ) WHERE ROWNUM = 1";

            connectdb();
            comm = new OracleCommand(query);
            comm.Connection = conn;
            object result = comm.ExecuteScalar();

            if (result != null)
            {
                string lastId = result.ToString(); // e.g., "M107"
                int number = int.Parse(lastId.Substring(1)); // remove 'M' and parse number
                number++;
                return "M" + number.ToString("D3"); // format to M108
            }
            else
            {
                return "M101"; // first user
            }
        }

        private void insert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mov_tit.Text) || string.IsNullOrEmpty(dir_name.Text) || string.IsNullOrEmpty(genre.Text) || string.IsNullOrEmpty(language.Text) || string.IsNullOrEmpty(strm_plat.Text) || string.IsNullOrEmpty(rl_yr.Text) || string.IsNullOrEmpty(duration.Text) || string.IsNullOrEmpty(im_score.Text))
            {
                MessageBox.Show("Please fill in all the filter fields.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            connectdb();
            comm = new OracleCommand();
            comm.Connection = conn;
            string newMovieId = GenerateNextMovieID();
            string newMovieTitle = mov_tit.Text;
            string newDirName = dir_name.Text;
            if (!Regex.IsMatch(dir_name.Text, @"^[A-Za-z\s]+$"))
            {
                MessageBox.Show("Name must contain only letters.");
                return;
            }
            // Try parsing numerical inputs
            if (!int.TryParse(duration.Text, out int intDuration) ||
                !decimal.TryParse(im_score.Text, out decimal imdbscore) || !int.TryParse(rl_yr.Text, out int rlYear))
            {
                MessageBox.Show("Please enter valid numbers for Duration, Release Year and Rating.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (imdbscore < 1 || imdbscore > 10)
            {
                MessageBox.Show("⭐ Please enter a valid rating between 1 and 10.", "Invalid Rating", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (newMovieTitle.Length > 254 || newDirName.Length > 254)
            {
                MessageBox.Show("📝 Title and Director Name should be 255 characters or fewer.", "Limit Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            query = @"INSERT INTO dbs_Movies (movie_id, title, release_year, duration, imdb_score, director_name)
    VALUES (:id, :title, :year, :duration, :score, :director)";
            OracleCommand movieCmd = new OracleCommand(query, conn);
            movieCmd.Parameters.Add(":id", newMovieId);
            movieCmd.Parameters.Add(":title", newMovieTitle);
            movieCmd.Parameters.Add(":year", rlYear);
            movieCmd.Parameters.Add(":duration", intDuration);
            movieCmd.Parameters.Add(":score", imdbscore);
            movieCmd.Parameters.Add(":director", newDirName);
            movieCmd.ExecuteNonQuery();

            query = @"INSERT INTO dbs_Movie_Genre (movie_id, genre_name) VALUES (:id, :genre)";
            OracleCommand genreCmd = new OracleCommand(query, conn);
            genreCmd.Parameters.Add(":id", newMovieId);
            genreCmd.Parameters.Add(":genre", genre.SelectedItem.ToString());
            genreCmd.ExecuteNonQuery();

            query = @"INSERT INTO dbs_Movie_Language (movie_id, lang_id, dubbed_audio, subtitles)
    VALUES (:id, :lang, :dubbed, :subs)";
            OracleCommand langCmd = new OracleCommand(query, conn);
            langCmd.Parameters.Add(":id", newMovieId);
            langCmd.Parameters.Add(":lang", language.SelectedItem.ToString()); // e.g., "L2"
            langCmd.Parameters.Add(":dubbed", dubs.SelectedItem.ToString());
            langCmd.Parameters.Add(":subs", subs.SelectedItem.ToString());
            langCmd.ExecuteNonQuery();

            query = "SELECT str_id FROM dbs_streaming WHERE str_name = :strname";
            OracleCommand command = new OracleCommand(query, conn);
            command.Parameters.Add(new OracleParameter("strname", strm_plat.SelectedItem.ToString()));
            OracleDataReader reader = command.ExecuteReader();
            reader.Read();
            string str_ID = reader["str_id"].ToString();
            query = @"INSERT INTO dbs_Movie_Streaming (movie_id, str_id) VALUES (:id, :stream)";
            OracleCommand streamCmd = new OracleCommand(query, conn);
            streamCmd.Parameters.Add(":id", newMovieId);
            streamCmd.Parameters.Add(":stream", str_ID); // e.g., "S102"
            streamCmd.ExecuteNonQuery();
            MessageBox.Show("Movie successfully added 🎬");
            conn.Close();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            connectdb();
            query = "SELECT DISTINCT GENRE_NAME FROM DBS_MOVIE_GENRE ORDER BY GENRE_NAME ASC";
            comm = new OracleCommand(query, conn);
            reader = comm.ExecuteReader();
            genre.Items.Clear();

            // Step 5: Loop through results and add to ComboBox
            while (reader.Read())
            {
                genre.Items.Add(reader["GENRE_NAME"].ToString());
            }
            query = "SELECT DISTINCT LANG_NAME FROM DBS_LANGUAGE ORDER BY LANG_NAME ASC";
            comm = new OracleCommand(query, conn);
            reader = comm.ExecuteReader();
            language.Items.Clear();

            // Step 5: Loop through results and add to ComboBox
            while (reader.Read())
            {
                language.Items.Add(reader["LANG_NAME"].ToString());
            }
            query = "SELECT DISTINCT STR_NAME FROM DBS_STREAMING ORDER BY STR_NAME ASC";
            comm = new OracleCommand(query, conn);
            reader = comm.ExecuteReader();
            strm_plat.Items.Clear();

            // Step 5: Loop through results and add to ComboBox
            while (reader.Read())
            {
                strm_plat.Items.Add(reader["STR_NAME"].ToString());
            }
            conn.Close();
        }

        private void delet_Click(object sender, EventArgs e)
        {
            connectdb();
            if (string.IsNullOrWhiteSpace(userEmail.Text))
            {
                MessageBox.Show("Please fill in User Email field.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            query = "DELETE FROM dbs_user WHERE email = :email";
            OracleCommand cmd = new OracleCommand(query, conn);
            cmd.Parameters.Add(":email", OracleDbType.Varchar2).Value = userEmail.Text;

            int rowsAffected = cmd.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                MessageBox.Show("User deleted successfully.");
            }
            else
            {
                MessageBox.Show("No user found with the given email.");
            }
            conn.Close();
        }

        private void user_data_Click(object sender, EventArgs e)
        {
            connectdb();
            query = @"select name, email,password_hash, dob, security from dbs_user";
            comm = new OracleCommand(query, conn);
            da = new OracleDataAdapter(comm);
            dt = new DataTable();
            da.Fill(dt);
            user_table.DataSource = dt;
            conn.Close();
        }

        private void mov_list_Click(object sender, EventArgs e)
        {
            Form9 movie_listing = new Form9();
            this.Hide();
            movie_listing.ShowDialog();
            this.Close();
        }
    }
}
