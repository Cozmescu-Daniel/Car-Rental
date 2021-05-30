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
    public partial class Form2 : Form
    {
        public static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public bool button2000WasClicked = false;
        public bool button2010WasClicked = false;
        public Form2()
        {
            InitializeComponent();

        }
        private void Form2_Load(object sender, EventArgs e)
        {


        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void rentToolStripMenuItem_Click(object sender, EventArgs e)
        {

            panel2.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
            button2000WasClicked = true;
            button2010WasClicked = false;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            Form7 f7 = new Form7();
            f7.Show();
            



        }


        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }


        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Car c2 = new Car();
            c2.getInfo(modelBox, typeBox, yearBox, engineBox, fuelBox, priceBox);
            c2.setInfo(model3Box, type3Box, year3Box, engine3Box, fuel3Box, price3Box);
            if (button2010WasClicked == true)
                pictureBox3.Image = pictureBox2.Image;
            else if (button2000WasClicked == true)
                pictureBox3.Image = pictureBox1.Image;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            modelBox.Text = "PUMA";
            typeBox.Text = "COUPE";
            yearBox.Text = "2002";
            engineBox.Text = "1.7 125HP";
            fuelBox.Text = "GAS";
            priceBox.Text = "30$";
            pictureBox1.Image = Image.FromFile("C:/Users/danut/Desktop/Project 2021 Car Service/Pictures/puma-0225.jpg");

        }

        private void returnCarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            modelBox.Text = "ECLIPSE";
            typeBox.Text = "COUPE";
            yearBox.Text = "2005";
            engineBox.Text = "2.4 142HP";
            fuelBox.Text = "GAS";
            priceBox.Text = "40$";
            pictureBox1.Image = Image.FromFile("C:/Users/danut/Desktop/Project 2021 Car Service/Pictures/eclipse1.jpg");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            modelBox.Text = "TWINGO";
            typeBox.Text = "HATCHBACK";
            yearBox.Text = "2009";
            engineBox.Text = "1.2 75HP";
            fuelBox.Text = "GAS";
            priceBox.Text = "15$";
            pictureBox1.Image = Image.FromFile("C:/Users/danut/Desktop/Project 2021 Car Service/Pictures/twingo.jpg");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            model2Box.Text = "A3";
            type2Box.Text = "HATCHBACK";
            year2Box.Text = "2012";
            engine2Box.Text = "2.0 140HP";
            fuel2Box.Text = "DIESEL";
            price2Box.Text = "35$";
            pictureBox2.Image = Image.FromFile("C:/Users/danut/Desktop/Project 2021 Car Service/Pictures/a3.jpg");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            model2Box.Text = "M3";
            type2Box.Text = "SEDAN";
            year2Box.Text = "2012";
            engine2Box.Text = "3.0 250HP";
            fuel2Box.Text = "DIESEL";
            price2Box.Text = "60$";
            pictureBox2.Image = Image.FromFile("C:/Users/danut/Desktop/Project 2021 Car Service/Pictures/m3.jpg");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            model2Box.Text = "C63";
            type2Box.Text = "COUPE";
            year2Box.Text = "2013";
            engine2Box.Text = "2.5 270HP";
            fuel2Box.Text = "DIESEL";
            price2Box.Text = "90$";
            pictureBox2.Image = Image.FromFile("C:/Users/danut/Desktop/Project 2021 Car Service/Pictures/c63amg.jpg");
        }

        private void sCarsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel2.Visible = false;
            panel4.Visible = false;
            button2000WasClicked = false;
            button2010WasClicked = true;



        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Car c1 = new Car();
            c1.getInfo(model2Box, type2Box, year2Box, engine2Box, fuel2Box, price2Box);
            c1.setInfo(model3Box, type3Box, year3Box, engine3Box, fuel3Box, price3Box);

            if (button2010WasClicked == true)
                pictureBox3.Image = pictureBox2.Image;
            else if (button2000WasClicked == true)
                pictureBox3.Image = pictureBox1.Image;

            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = true;
        }

        private void toolStripDropDownButton3_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            Car c11 = new Car();
            c11.getDate(monthCalendar1);
            c11.setDate(textBox10, textBox11);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(model3Box.Text) || string.IsNullOrEmpty(type3Box.Text) || string.IsNullOrEmpty(year3Box.Text) || string.IsNullOrEmpty(engine3Box.Text) || string.IsNullOrEmpty(fuel3Box.Text) || string.IsNullOrEmpty(price3Box.Text) ||
                string.IsNullOrEmpty(textBox7.Text) || string.IsNullOrEmpty(textBox8.Text) || string.IsNullOrEmpty(textBox9.Text) || string.IsNullOrEmpty(textBox10.Text) || string.IsNullOrEmpty(textBox11.Text))
            {
                MessageBox.Show(" Please fill all the information required in order to rent a car", "Data Missing");
                log.Warn("User didn't filled all textboxes. Info missing can't rent");
            }
            else if (Int32.Parse(textBox9.Text) < 18)
            {
                MessageBox.Show("We are sorry but we only book cars for persons above 18 years old.", "Age Restrict");
                log.Error("Person under 18 trying to rent a car. Operation Failed");

            }
            else if (cnpBox.Text.Length != 13)
            {
                MessageBox.Show("Not a valid CNP", "Data Validator Failed");
                log.Warn("Wrong Format of CNP, not valid. Data validator Failed");

            }
             

            else
            {
                log.Info("TEXTBOXES INSERTED>>BUTTON WORKED");
                try
                {
                    // create sql connection object.  Be sure to put a valid connection string
                    SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
                    // create command object with SQL query and link to connection object
                    SqlCommand Cmd = new SqlCommand("INSERT INTO Rent " +
                "(Model,Type,Year,Engine,Fuel,Price,Last_Name,First_Name,Age,Book_Start_Date,Book_End_Date,CNP) " +
                        "VALUES(@Model,@Type,@Year,@Engine,@Fuel,@Price,@Last_Name,@First_Name,@Age,@Book_Start_Date,@Book_End_Date,@CNP)", Con);


                    // create your parameters
                    Cmd.Parameters.Add("@Model", System.Data.SqlDbType.VarChar);
                    Cmd.Parameters.Add("@Type", System.Data.SqlDbType.VarChar);
                    Cmd.Parameters.Add("@Year", System.Data.SqlDbType.VarChar);
                    Cmd.Parameters.Add("@Engine", System.Data.SqlDbType.VarChar);
                    Cmd.Parameters.Add("@Fuel", System.Data.SqlDbType.VarChar);
                    Cmd.Parameters.Add("@Price", System.Data.SqlDbType.VarChar);
                    Cmd.Parameters.Add("@Last_Name", System.Data.SqlDbType.VarChar);
                    Cmd.Parameters.Add("@First_Name", System.Data.SqlDbType.VarChar);
                    Cmd.Parameters.Add("@Age", System.Data.SqlDbType.VarChar);
                    Cmd.Parameters.Add("@Book_Start_Date", System.Data.SqlDbType.VarChar);
                    Cmd.Parameters.Add("@Book_End_Date", System.Data.SqlDbType.VarChar);
                    Cmd.Parameters.Add("@CNP", System.Data.SqlDbType.VarChar);



                    // set values to parameters from textboxes
                    Cmd.Parameters["@Model"].Value = model3Box.Text;
                    Cmd.Parameters["@Type"].Value = type3Box.Text;
                    Cmd.Parameters["@Year"].Value = year3Box.Text;
                    Cmd.Parameters["@Engine"].Value = engine3Box.Text;
                    Cmd.Parameters["@Fuel"].Value = fuel3Box.Text;
                    Cmd.Parameters["@Price"].Value = price3Box.Text;
                    Cmd.Parameters["@Last_Name"].Value = textBox7.Text;
                    Cmd.Parameters["@First_Name"].Value = textBox8.Text;
                    Cmd.Parameters["@Age"].Value = textBox9.Text;
                    Cmd.Parameters["@Book_Start_Date"].Value = textBox10.Text;
                    Cmd.Parameters["@Book_End_Date"].Value = textBox11.Text;
                    Cmd.Parameters["@CNP"].Value = cnpBox.Text;


                    Con.Open();
                    int rowsAdded = Cmd.ExecuteNonQuery();
                    if (rowsAdded > 0)
                    {
                        MessageBox.Show("BOOKED");
                        log.Info("BOOKED SUCCESFULLY");
                    }
                    else
                    {
                        MessageBox.Show("ROWS NOT INSERTED");
                        log.Error("Booking not inserted to database. Operation of INSERT failed");
                    }
                    Con.Close();

                }catch(SqlException ex)
                {
                    log.Error(ex.ToString());
                }
               
                

                


            }
        }
    }
    public interface RentAVehicle
    {
        void getInfo(TextBox t1, TextBox t2, TextBox t3, TextBox t4, TextBox t5, TextBox t6);
        void setInfo(TextBox t1, TextBox t2, TextBox t3, TextBox t4, TextBox t5, TextBox t6);
        void createCarForm();
        void getDate(MonthCalendar m);
        void setDate(TextBox t11, TextBox t22);
        
    }
    public class Car : RentAVehicle
    {
        public String model, type, year, engine, price, fuel,date_start,date_end;
        public void createCarForm()
        {
    
        }

        public void getInfo(TextBox t1, TextBox t2, TextBox t3, TextBox t4, TextBox t5, TextBox t6)
        {
            model = t1.Text;
            type = t2.Text;
            year = t3.Text;
            engine = t4.Text;
            fuel = t5.Text;
            price = t6.Text;
            
        }

        public void setInfo(TextBox t1, TextBox t2, TextBox t3, TextBox t4, TextBox t5, TextBox t6)
        {
            t1.Text = model;
            t2.Text = type;
            t3.Text = year;
            t4.Text = engine;
            t5.Text = fuel;
            t6.Text = price;
        }
        public void getDate(MonthCalendar m)
        {
            date_start = m.SelectionRange.Start.ToShortDateString();
            date_end = m.SelectionRange.End.ToShortDateString();
        }
        public void setDate(TextBox t11, TextBox t22)
        {
            t11.Text = date_start;
            t22.Text = date_end;

        }
    }

}
