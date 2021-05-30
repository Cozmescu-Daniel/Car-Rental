using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Car_Service
{
    public partial class Form6 : Form
    {
        public static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
       

        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox3.Focus();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show(" Please fill all the information required in order to sign up", "Data Missing");
                log.Warn("User didn't filled all textboxes. Info missing can't sign up");
            }
            else if(textBox1.Text.Equals(textBox2.Text) ==false)
            {
                MessageBox.Show(" Passwords don't match. Please retype them carefully", "Data Missing");
                log.Warn("User didn't matched passwords at sign up. Info not the same at PASSWORD, can't sign up WARNING");
            }
            else
            {
                try
                {
                    // create sql connection object.  Be sure to put a valid connection string
                    SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
                    // create command object with SQL query and link to connection object
                    SqlCommand Cmd = new SqlCommand("INSERT INTO Login " + "(Username,Password) " + "VALUES(@Username,@Password)", Con);


                    // create your parameters
                    Cmd.Parameters.Add("@Username", System.Data.SqlDbType.VarChar);
                    Cmd.Parameters.Add("@Password", System.Data.SqlDbType.VarChar);




                    // set values to parameters from textboxes
                    Cmd.Parameters["@Username"].Value = textBox3.Text;
                    Cmd.Parameters["@Password"].Value = textBox2.Text;



                    Con.Open();
                    int rowsAdded = Cmd.ExecuteNonQuery();
                    if (rowsAdded > 0)
                        MessageBox.Show("SIGNED UP SUCCESFULLY");
                    else
                    {
                        MessageBox.Show("SIGN UP NOT REGISTERED >>> FAILED INSERTION >>> TRY AGAIN IN A MOMENT");
                        log.Error("SIGN_UP not inserted to database. Operation of INSERT failed >>> ERROR SINGING UP");
                    }
                    Con.Close();

                }
                catch (SqlException ex)
                {
                    log.Error(ex.ToString() + " FAILED TO SIGN UP");
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }
    }
        
}
