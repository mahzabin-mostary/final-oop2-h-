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



namespace formm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void addcourse(object sender, EventArgs e)
        {
            string c_code = tbccode.Text;
            string c_name = tbcname.Text;
            string connString = @"Server=DESKTOP-2JKGA1B\SQLEXPRESS;Database=database1;Integrated Security=true";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            string query = String.Format("INSERT INTO Courses VALUES ('{0}','{1}')", c_code, c_name);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            if (r > 0)
            {
                Console.WriteLine("add value");
            }
            else
            {
                Console.WriteLine("value not added");
            }
            conn.Close();
        }


    }
    }
}

