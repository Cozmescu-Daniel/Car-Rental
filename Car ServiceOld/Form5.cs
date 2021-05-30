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
    public partial class Form5 : Form
    {
        public static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Form5()
        {
            InitializeComponent();

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                linkLabel1.LinkVisited = true;
                System.Diagnostics.Process.Start("https://www.google.com/maps/place/bloc+223,+Strada+Cocorului+7,+Bra%C8%99ov+500419/@45.6343001,25.630021,17z/data=!4m13!1m7!3m6!1s0x40b35d4ba0c2d935:0x397725c533aed858!2sbloc+223,+Strada+Cocorului+7,+Bra%C8%99ov+500419!3b1!8m2!3d45.6343001!4d25.6322097!3m4!1s0x40b35d4ba0c2d935:0x397725c533aed858!8m2!3d45.6343001!4d25.6322097");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked.");
                log.Error("Can't open home link. Access to internet may be gone.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
