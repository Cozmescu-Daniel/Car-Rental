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
    public partial class Form4 : Form
    {
        public static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Form4()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                String query = "DELETE FROM RENT WHERE ID=" + richTextBox1.Text;
                using (SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True"))
                {
                    Con.Open();
                    SqlDataAdapter adapt = new SqlDataAdapter(query, Con);
                    DataTable dt = new DataTable();
                    adapt.Fill(dt);
                    Con.Close();
                    this.Hide();

                }
            }
            catch(SqlException ex)
            {
                log.Error("Can't delete booking. Error 401. Unable to delete Person's reservation. Message: " + ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
