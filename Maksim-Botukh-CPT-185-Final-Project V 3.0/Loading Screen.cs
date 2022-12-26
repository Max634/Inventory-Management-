using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maksim_Botukh_CPT_185_Final_Project
{
    //Loading screen that uses timer as an engine, and as soon as program starts the loading screen will appear
    public partial class Loading_Screen : Form
    {
        public Loading_Screen()
        {
            InitializeComponent();
        }

        private void Loading_Screen_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {   //If condition to keep adding +1 to the bar untill it reaches 100.
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 1;

                label2.Text = progressBar1.Value.ToString() + "%"; //label text that follows the progress bar in the if condition
            }
            else
            {
                //Once the progress bar reaches 100, the pop out message will appear and loading screen will close
                timer1.Stop();
                MessageBox.Show("Application was loaded sucessfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                frmLogin F2 = new frmLogin();
                F2.Show();
            }
        }
    }
}
