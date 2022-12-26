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
    //This screen allow the users to register an account in Inventory Management System
    //The connection is set with access database, that get an information based on the info that is entered by an end user
    //Once account is registered, the record will get added to the database.
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }
        //Signup screen that uses OleDB connection to the database.
        //It contains insert method that insert username and password into the database
        OleDbConnection con = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0;Data Source = FinalProjectDatabase.mdb"); //Connection to db, as well as database name
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        //Register button method
        private void btnregister_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open(); //open connection
                //If condition to throw an error message if no entry is entered
                if (txtusername.Text == "" && txtpassword.Text == "" && txtcompassword.Text == "")
                {
                    MessageBox.Show("Username and Passoword fields must are empty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                //If info was entered continue.
                //This method still has an open connection with databse, and inserts the records based on the user entry
                //In addition, the method will check whether an account already exist or no
                else if (txtpassword.Text == txtcompassword.Text)
                {
                    string register = "INSERT INTO tbl_signup VALUES ('" + txtusername.Text + "','" + txtpassword.Text + "')"; //Insert method
                    cmd = new OleDbCommand(register, con);
                    cmd.ExecuteNonQuery();
                    //Clear textboxes once the account is registered
                    txtusername.Text = "";
                    txtpassword.Text = "";
                    txtcompassword.Text = "";
                    //Prompt message box
                    MessageBox.Show("Your Account has been Successfully Created", "Registration Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    new frmLogin().Show();
                    this.Hide();
                }
                else
                {
                    //Else method that will throw an error message if password does not match
                    MessageBox.Show("Password does not match, Please Re-Enter", "Registration  Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtpassword.Text = "";
                    txtcompassword.Text = "";
                    txtcompassword.Focus();
                }
            }
            catch
            {
                //Message box to show that account is already exist
                MessageBox.Show("Account already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtusername.Text = "";
            }
            finally
            {
                con.Close();
            }
        }
        //Method to show and hide entered password
        //This method allows to see a password that is entered by the user
        private void checkbxshowpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxshowpassword.Checked)
            {
                txtpassword.PasswordChar = '\0';
                txtcompassword.PasswordChar = '\0';
            }
            else
            {
                txtpassword.PasswordChar = '*';
                txtcompassword.PasswordChar = '*';
            }
        }
        //Clear method
        private void btnclear_Click(object sender, EventArgs e)
        {
            txtusername.Clear();
            txtpassword.Clear();
            txtcompassword.Clear();
            txtusername.Focus();
        }
        //Open Login form
        private void lblalreadyhaveanaccount_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Hide();
        }
        //Open Login form
        private void lblbacktologin_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Hide();
        }
        //Close application
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Open AboutBox in the window
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutBox().ShowDialog();
        }
    }
}
