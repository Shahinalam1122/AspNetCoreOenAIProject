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

namespace ReportsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connString = "Data Source=DESKTOP-36RFDVG\\SQLEXPRESS;Initial Catalog=OpenAIDb;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd= new SqlCommand();
            SqlDataAdapter adapter=new SqlDataAdapter();
           
            string stringQuery = "SELECT * FROM OpenAIDb.dbo.TextGenerates";

            DataTable dt = new DataTable();
            cmd.Connection = conn;
            cmd.CommandText = stringQuery;
            conn.Open();
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}