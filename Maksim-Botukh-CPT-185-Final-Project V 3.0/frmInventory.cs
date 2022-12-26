using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maksim_Botukh_CPT_185_Final_Project
{
    //This form will allow user to store a product into the database, with qty, url and image of the product
    //User will not have an access untill he/she login or register an account.
    //The program is capable of handling any type of images as well as url's
    public partial class frmInventory : Form
    {
        public frmInventory()
        {
            InitializeComponent();
            int sum = 0;
            //Method to calculate the total amount of records
            for (int i = 0; i < tbl_inventoryDataGridView.Rows.Count; i++)
            {
                sum += Convert.ToInt32(tbl_inventoryDataGridView.Rows[i].Cells[1].Value);
            }
            lbltotal.Text = sum.ToString();
        }

        private void tbl_inventoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_inventoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.finalProjectDatabaseDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finalProjectDatabaseDataSet.tbl_inventory' table. You can move, or remove it, as needed.
            this.tbl_inventoryTableAdapter.Fill(this.finalProjectDatabaseDataSet.tbl_inventory);
        }
        //Method to clear textboxes and allow to enter the items
        private void btnadd_Click(object sender, EventArgs e)
        {
            tbl_inventoryBindingSource.AddNew();
            lbltotal.Text = "Total records: " + tbl_inventoryDataGridView.Rows.Count.ToString();
        }
        //Method to update any items in the database
        //You will have to select an item and make any changes to it. Once the changes are made, it will update in database and datagrid.
        private void btnupdate_Click(object sender, EventArgs e)
        {
            tbl_inventoryBindingSource.EndEdit();
            lbltotal.Text = "Total records: " + tbl_inventoryDataGridView.Rows.Count.ToString();
        }
        //Method to save any changes to the database
        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.tbl_inventoryBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.finalProjectDatabaseDataSet);
                lbltotal.Text = "Total records: " + tbl_inventoryDataGridView.Rows.Count.ToString();//Show the total amounts of records in the database. Updates on each added or deleted item
                MessageBox.Show("Record was saved/added/changes were saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Item already exist/No duplicate items are allowed","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Method to delete the record from the database.
        //Method deletes the item from the database, and let the user know with the pop-out message
        private void btndelete_Click(object sender, EventArgs e)
        {
            tbl_inventoryBindingSource.RemoveCurrent();
            MessageBox.Show("Record was deleted");
            lbltotal.Text = "Total records: " + tbl_inventoryDataGridView.Rows.Count.ToString();
        }
        //Method to move to the next item
        private void btnnext_Click(object sender, EventArgs e)
        {
            tbl_inventoryBindingSource.MoveNext();
            lbltotal.Text = "Total records: " + tbl_inventoryDataGridView.Rows.Count.ToString();
        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            tbl_inventoryBindingSource.MovePrevious();
            lbltotal.Text = "Total records: " + tbl_inventoryDataGridView.Rows.Count.ToString();
        }
        //Close out the application
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Method to allow hyperlinks in datagrid
        private void tbl_inventoryDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Method to hande the hyperlink method.To make sure that the certain grid is selected (hyperlink grid)
                if (e.RowIndex >= 0)
                {
                    string sUrl = tbl_inventoryDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                    ProcessStartInfo sInfo = new ProcessStartInfo(sUrl);
                    Process.Start(sInfo);
                }
            }
            catch
            {
                MessageBox.Show("Item URL cannot be opened/Invalid URL", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Method to clear image from the box
        private void btnImageClear_Click(object sender, EventArgs e)
        {
            try
            {
                this.imagePictureBox.Image = null;//Set the image to null

            }
            catch
            {
                MessageBox.Show("The picture was cleared", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);//Informative messagebox
            }
        }
        //Method to choose an image using the formats below.
        //This method allows to pick any images with all extentions.
        private void btnchooseimage_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                string myPictures = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                ofd.Filter = "Jpg, Jpeg Image |*.jpg;*.jpeg|PNG Images|*.png|BMP Image|*.bmp|" + "All files (*.*)|*.*";
                ofd.Title = "Choose an image...";
                ofd.AddExtension = true;
                ofd.FilterIndex = 0;
                ofd.Multiselect = false;
                ofd.ValidateNames = true;
                ofd.InitialDirectory = myPictures;
                ofd.RestoreDirectory = true;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    this.imagePictureBox.Image = Image.FromFile(ofd.FileName);
                }
                else
                {
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Error: Something went wrong.", "Choose image", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Void method to go to the surprise form
        private void btnsurprise_Click(object sender, EventArgs e)
        {
            Countdowntimer f1 = new Countdowntimer();
            f1.Show();
            Visible = false;
        }
        //Void method to open about form
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutBox().ShowDialog();
        }
    }
}
