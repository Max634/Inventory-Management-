using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maksim_Botukh_CPT_185_Final_Project
{
    public partial class frmLogin : Form
    {   
        //Login screen that uses OleDB connection to the database.
        //It contains the select statement that searches for the username and password entered by the end user
        public frmLogin()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0;Data Source = FinalProjectDatabase.mdb");//connection to database + database name
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void btnregister_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open(); //database open connection
                string login = "SELECT * FROM tbl_signup WHERE Username = '" + txtusername.Text + "' and Password = '" + txtpassword.Text + "'"; //select statement (query) to search for the credential based on the user entry
                cmd = new OleDbCommand(login, con); 
                OleDbDataReader dr = cmd.ExecuteReader();

                bool accountCorrect = dr.Read(); // boolean method
                con.Close(); //closing connection
                //boolean method that will go unstop untill the correct credentials are entered
                if (accountCorrect)
                {
                    this.Hide();
                    frmInventory F1 = new frmInventory();
                    F1.Show();
                }
                else
                {
                    //Invalid pop-out messages
                    MessageBox.Show("Invalid Username or Password, Please try Again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtusername.Text = "";
                    txtpassword.Text = "";
                    txtusername.Focus();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtusername.Clear();
            txtpassword.Clear();
            txtusername.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            new Signup().Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new Signup().Show();
            this.Hide();
        }
        //Method to show and hide entered password
        //This method allows to see a password that is entered by the user
        private void checkbxshowpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxshowpassword.Checked)
            {
                txtpassword.PasswordChar = '\0';
            }
            else
            {
                txtpassword.PasswordChar = '*';
            }
        }
        //Open AboutBox in the window
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutBox().ShowDialog();
        }
    }
}
