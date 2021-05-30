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
        public static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

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
            int ok = 1;
            
            
                try
                {
                    if (isValid())
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
                                ok = 0;
                                user.Clear();
                                password.Clear();
                                user.Focus();
                                MessageBox.Show("Invalid username or password", "Error");
                            }

                        }
                    }
                }
                catch (SqlException sqlE)
                {
                    log.Debug("Failed Connection to database. Message info:" + sqlE.ToString());
                }
            if (ok == 1)
                log.Info("SUCCESSFUL CONNECTED TO DATABASE>>CHECK LOGIN SUCCESFULL");
        }
        private bool isValid()
        {
            int ok = 1;
            if(user.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Enter a valid username", "Error");
                log.Error("A person tries to log in, username " + user.Text + " not valid. Error Form1 Database_Login_Authentification");
                ok = 0;
                if (ok == 0)
                    log.Info("LOG IN NOT OKAY");
                return false;
            }
            else if (password.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Enter a valid password ", "Error");
                log.Warn("User " + user.Text + " Password_ERR_FAILED TO CONNECT. RETURN CODE: -404");
                ok = 0;
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

        private void label4_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
            this.Hide();
        }
    }

    }

