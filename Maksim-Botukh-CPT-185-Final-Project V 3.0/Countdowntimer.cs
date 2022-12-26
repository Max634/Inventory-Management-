using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;


namespace Maksim_Botukh_CPT_185_Final_Project
{
    public partial class Countdowntimer : Form
    {
        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();

        public Countdowntimer()
        {
            InitializeComponent();
            player.URL = "9 to 5.mp3";
            player.controls.stop();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        DateTime endTime = new DateTime(2022, 12, 14, 00, 00, 00); //Retirement date
        //Timer method and Engine of the program
        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan time = endTime.Subtract(DateTime.Now);

            //months.Text = time.Days.ToString();
            days.Text = time.Days.ToString();
            hours.Text = time.Hours.ToString();
            minutes.Text = time.Minutes.ToString();
            seconds.Text = time.Seconds.ToString();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            player.controls.stop();
            frmLogin f1 = new frmLogin();
            f1.Show();
            Visible = false;
        }

        private void btnplay_Click(object sender, EventArgs e)
        {
            player.controls.play();
            picdancing.Show();
            picdance2.Show();
        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            player.controls.stop();
            picdancing.CancelAsync();
            picdance2.CancelAsync();
        }
    }
}
