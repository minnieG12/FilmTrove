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
    public partial class Form3: Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void proceed_Click(object sender, EventArgs e)
        {
            Form1 login_page = new Form1();
            //login_page.Show();
            this.Hide();
            login_page.ShowDialog();
            this.Close();
        }
    }
}
