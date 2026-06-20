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

namespace Db_Connection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "DESKTOP-8STB8V4\\hp"; 
            builder.UserID = "root"; 
            builder.Password = "kumar44@12"; 
            builder.InitialCatalog = "student_manage";

            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                connection.Open();

                // Execute a query
                using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM mytable", connection))
                {
                    int count = (int)command.ExecuteScalar();
                    Console.WriteLine("Count: {0}", count);
                }
            }
        }
    }
}
