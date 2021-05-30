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

namespace Car_Service
{
    public partial class Form3 : Form
    {
        public static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Form3()
        {
            InitializeComponent();
        }

       

        public void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                String query = "SELECT * FROM Rent";
                using (SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True"))
                {
                    Con.Open();
                    SqlDataAdapter adapt = new SqlDataAdapter(query, Con);
                    DataTable dt = new DataTable();
                    adapt.Fill(dt);
                    dataGridView1.DataSource = dt;
                    Con.Close();
                }
            }
            catch(SqlException sqlE)
            {
                log.Error(sqlE.ToString() + "Connection failed");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            
        }
        

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
        }
    }
}
