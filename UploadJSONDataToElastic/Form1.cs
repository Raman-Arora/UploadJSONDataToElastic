using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UploadJSONDataToElastic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string serverIP = txtServerIP.Text;
            string password = txtServerPwd.Text;
            string dbName = txtDatabaseName.Text;

            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = "Server=" + serverIP + ";Database=" + dbName + ";Trusted_Connection=true";
                // using the code here...
            }

        }

     
       
    }
}
