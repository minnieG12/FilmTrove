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
    public partial class Form9: Form
    {
        OracleConnection conn; OracleCommand comm;
        public Form9()
        {
            InitializeComponent();
            connectdb();
            LoadMovieList();
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

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void LoadMovieList()
        {
            connectdb();
            string query = @"
SELECT 
    m.title, 
    m.release_year, 
    m.duration, 
    m.imdb_score, 
    m.director_name
FROM dbs_movies m";
            comm = new OracleCommand(query, conn);
            OracleDataAdapter da = new OracleDataAdapter(comm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            mov_list.DataSource = dt;
            conn.Close();
        }

        private void back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form8 admin_page = new Form8();
            this.Hide();
            admin_page.ShowDialog();
            this.Close();
        }
    }
}
