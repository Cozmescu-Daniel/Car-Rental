using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Service
{
    public partial class Form2 : Form
    {
       

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
            panel1.Hide();
            panel2.Show();
            panel3.Hide();
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            panel2.Hide();
            panel1.Show();
            panel3.Hide();
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
            panel3.Show();
         


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
            panel4.Show();
        }

        private void toolStripDropDownButton3_Click(object sender, EventArgs e)
        {
            
        }
    }
    public interface RentAVehicle
    {
        void getInfo(TextBox t1, TextBox t2, TextBox t3, TextBox t4, TextBox t5, TextBox t6);
        void setInfo(TextBox t1, TextBox t2, TextBox t3, TextBox t4, TextBox t5, TextBox t6);
        void createCarForm();
        
    }
    public class Car : RentAVehicle
    {
        public String model, type, year, engine, price, fuel;
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
    }

}
