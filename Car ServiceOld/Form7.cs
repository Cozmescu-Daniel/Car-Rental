using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Speech.Synthesis;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Service
{
    public partial class Form7 : Form
    {
        public static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);


        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            
        }
        
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                Assistant s = new Assistant();
                richTextBox2.Text = "";
                s.getQ(richTextBox1.Text);
                richTextBox1.Text = "";
                richTextBox2.Text = s.GetR();
                SpeechSynthesizer synth = new SpeechSynthesizer();
                synth.SetOutputToDefaultAudioDevice();
                synth.SelectVoiceByHints(VoiceGender.Male);
                synth.SpeakAsync(richTextBox2.Text);
            }
            catch(Exception ex)
            {
                log.Fatal("Synth Object or Assistant object may not work. ERROR RUNTIME SYNTHESIZER");
                MessageBox.Show("Error, for the moment the assistant won't respond. We will take care of this problem", "Error");
            }
            
        }
    }
    }
    public class Assistant
    {
        String q;
        String r;
        public void getQ(String q2)
        {
            q = q2.ToLower();
        }
        public String GetR()
        {
        if (q.Equals("commands"))
            r = "Here is a list of my commands: my ip, my host, shutdown, hibernate, sleep, open google, search, ipconfig, my pc, tell me the time, strada, cpu usage, internet speed, battery status, wifi status";
        else if (q.Equals("hello"))
            r = "Hi there. I'm your virtual assistant. How can I help you with?";
        else if (q.Contains("booking"))
            r = "If you wish to rent a car, select a period of time from CARS TO RENT tab, and then choose one car, click on Book button, and then insert your data.";
        else if (q.Contains("see") && q.Contains("book"))
            r = "Your bookings are available at My Bookings section, just click Show Bookings button.";
        else if (q.Equals("my ip"))
        {
            string hostName = Dns.GetHostName();
            string myIP = Dns.GetHostByName(hostName).AddressList[0].ToString();
            r = "Your IP Address is :" + myIP;
        }
        else if (q.Equals("my host"))
        {
            string hostName = Dns.GetHostName();
            r = "Your host name is " + hostName;
        }
        else if (q.Equals("shutdown"))
        {
            Process.Start("shutdown", "/s /t 0");
            r = "Goodbye sir";
        }
        else if (q.Equals("hibernate"))
        {
            Application.SetSuspendState(PowerState.Hibernate, true, true);
            r = "Hibernate. Got it.";
        }
        else if (q.Equals("sleep"))
        {
            Application.SetSuspendState(PowerState.Suspend, true, true);
            r = "Sleep. Got it.";
        }
        else if (q == "open google")
        {
            r = "Sure. Opening Google Engine";
            Process.Start("chrome.exe", "http://www.google.com");

        }
        else if (q == "play mozart")
        {
            r = "Sure. Playing Mozart on Youtube";
            Process.Start("microsoft-edge:https://www.youtube.com/watch?v=Rb0UmrCXxVA&t=357s");

        }
        else if (q.Contains("search"))
        {
            String aux;
            aux = q.Replace("search", " ");
            r = "Sure, searching" + aux + " on Google";
            System.Diagnostics.Process.Start("http://www.google.com.au/search?q=" + aux);
        }
        else if (q.Contains("ipconfig") || q.Contains("tree") || q.Contains("cmd"))
        {
            System.Diagnostics.Process.Start("CMD.exe", q);
            r = "Sure. Opening Terminal";
        }
        else if (q.Equals("my pc"))
        {
            r = "Sure. Opening your pc";
            Process.Start("::{20d04fe0-3aea-1069-a2d8-08002b30309d}");
        }
        else if (q.Equals("i wanna code"))
        {

            Process.Start("chrome.exe", "https://stackoverflow.com");
            Process.Start("chrome.exe", "https://github.com/");
            Process.Start("chrome.exe", "https://java.com");
            r = "Sure. Opening your favourite 3 tabs from Google.";
        }
        else if (q.Equals("tell me the time") || q.Equals("tell me the date"))
        {
            DateTime now = DateTime.Now;
            r = now.ToString("F");

        }
        else if (q.Contains("strada"))
        {
            r = "Sure. Opening your location.";

            Process.Start("chrome.exe", "https://www.google.ro/maps/place/" + q);
        }
        else if (q.Equals("cpu usage"))
        {
            var cpuUsage = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            Thread.Sleep(1000);
            var firstCall = cpuUsage.NextValue();

            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(1000);
                r = "Your cpu usage is " + cpuUsage.NextValue() + "%";
            }

        }
        else if (q.Equals("internet speed"))
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Reset();
            stopwatch.Start();

            WebClient webClient = new WebClient();
            byte[] bytes = webClient.DownloadData("http://www.google.com");

            stopwatch.Stop();

            double seconds = stopwatch.Elapsed.TotalSeconds;

            double speed = bytes.Count() / seconds;
            speed = speed;

            r = "Your speed is " + speed + " bytes per second.";
        }
        else if (q.Equals("battery status"))
        {

            PowerLineStatus status = SystemInformation.PowerStatus.PowerLineStatus;
            if (status == PowerLineStatus.Offline)
                r = "Running on Battery";
            else
                r = "Running on Power";

        }
        else if (q.Equals("wifi status"))
        {
            Ping myPing = new Ping();
            String host = "google.com";
            byte[] buffer = new byte[32];
            int timeout = 1000;
            PingOptions pingOptions = new PingOptions();
            PingReply reply = myPing.Send(host, timeout, buffer, pingOptions);
            if (reply.Status == IPStatus.Success)
            {
                r = "You are online";
            }
            else r = "You are offline";
        }
        else r = "I am not sure I understand.";

            return r;

        }
        
    }



