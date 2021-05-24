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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            if(isValid())
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True"))
                {
                    string query = "SELECT * FROM Login WHERE Username= '" + user.Text.Trim() + "' AND Password = '" + password.Text.Trim() + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                    DataTable dta = new DataTable();
                    sda.Fill(dta);
                    if (dta.Rows.Count == 1)
                    {
                        Form2 form2 = new Form2();
                        this.Hide();
                        form2.Show();

                    }
                    else
                    {
                        user.Clear();
                        password.Clear();
                        user.Focus();
                        MessageBox.Show("Invalid username or password", "Error");
                    }

                }
            }
           
        }
        private bool isValid()
        {
            if(user.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Enter a valid username", "Error");
                return false;
            }
            else if (password.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Enter a valid password ", "Error");
                return false;
            }
            return true;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            user.Clear();
            password.Clear();
            user.Focus();
            
        }

     

       
    }

    }

