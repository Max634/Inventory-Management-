
namespace Maksim_Botukh_CPT_185_Final_Project
{
    partial class frmInventory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label item_IDLabel;
            System.Windows.Forms.Label item_NameLabel;
            System.Windows.Forms.Label item_DescriptionLabel;
            System.Windows.Forms.Label qTYLabel;
            System.Windows.Forms.Label item_URLLabel;
            System.Windows.Forms.Label imageLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventory));
            this.tbl_inventoryBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.tbl_inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finalProjectDatabaseDataSet = new Maksim_Botukh_CPT_185_Final_Project.FinalProjectDatabaseDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbl_inventoryBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.item_IDTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.item_NameTextBox = new System.Windows.Forms.TextBox();
            this.item_DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.qTYTextBox = new System.Windows.Forms.TextBox();
            this.item_URLTextBox = new System.Windows.Forms.TextBox();
            this.tbl_inventoryDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.lbltotal = new System.Windows.Forms.Label();
            this.tbl_inventoryTableAdapter = new Maksim_Botukh_CPT_185_Final_Project.FinalProjectDatabaseDataSetTableAdapters.tbl_inventoryTableAdapter();
            this.tableAdapterManager = new Maksim_Botukh_CPT_185_Final_Project.FinalProjectDatabaseDataSetTableAdapters.TableAdapterManager();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnadd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnsurprise = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnprevious = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnImageClear = new System.Windows.Forms.Button();
            this.btnchooseimage = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imagePictureBox = new System.Windows.Forms.PictureBox();
            item_IDLabel = new System.Windows.Forms.Label();
            item_NameLabel = new System.Windows.Forms.Label();
            item_DescriptionLabel = new System.Windows.Forms.Label();
            qTYLabel = new System.Windows.Forms.Label();
            item_URLLabel = new System.Windows.Forms.Label();
            imageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_inventoryBindingNavigator)).BeginInit();
            this.tbl_inventoryBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_inventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalProjectDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_inventoryDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // item_IDLabel
            // 
            item_IDLabel.AutoSize = true;
            item_IDLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            item_IDLabel.ForeColor = System.Drawing.Color.White;
            item_IDLabel.Location = new System.Drawing.Point(69, 148);
            item_IDLabel.Name = "item_IDLabel";
            item_IDLabel.Size = new System.Drawing.Size(56, 16);
            item_IDLabel.TabIndex = 1;
            item_IDLabel.Text = "Item ID:";
            // 
            // item_NameLabel
            // 
            item_NameLabel.AutoSize = true;
            item_NameLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            item_NameLabel.ForeColor = System.Drawing.Color.White;
            item_NameLabel.Location = new System.Drawing.Point(69, 188);
            item_NameLabel.Name = "item_NameLabel";
            item_NameLabel.Size = new System.Drawing.Size(82, 16);
            item_NameLabel.TabIndex = 4;
            item_NameLabel.Text = "Item Name:";
            // 
            // item_DescriptionLabel
            // 
            item_DescriptionLabel.AutoSize = true;
            item_DescriptionLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            item_DescriptionLabel.ForeColor = System.Drawing.Color.White;
            item_DescriptionLabel.Location = new System.Drawing.Point(298, 145);
            item_DescriptionLabel.Name = "item_DescriptionLabel";
            item_DescriptionLabel.Size = new System.Drawing.Size(116, 16);
            item_DescriptionLabel.TabIndex = 6;
            item_DescriptionLabel.Text = "Item Description:";
            // 
            // qTYLabel
            // 
            qTYLabel.AutoSize = true;
            qTYLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            qTYLabel.ForeColor = System.Drawing.Color.White;
            qTYLabel.Location = new System.Drawing.Point(316, 187);
            qTYLabel.Name = "qTYLabel";
            qTYLabel.Size = new System.Drawing.Size(36, 16);
            qTYLabel.TabIndex = 8;
            qTYLabel.Text = "QTY:";
            // 
            // item_URLLabel
            // 
            item_URLLabel.AutoSize = true;
            item_URLLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            item_URLLabel.ForeColor = System.Drawing.Color.White;
            item_URLLabel.Location = new System.Drawing.Point(604, 142);
            item_URLLabel.Name = "item_URLLabel";
            item_URLLabel.Size = new System.Drawing.Size(65, 16);
            item_URLLabel.TabIndex = 10;
            item_URLLabel.Text = "Item URL:";
            // 
            // imageLabel
            // 
            imageLabel.AutoSize = true;
            imageLabel.Location = new System.Drawing.Point(641, 69);
            imageLabel.Name = "imageLabel";
            imageLabel.Size = new System.Drawing.Size(0, 16);
            imageLabel.TabIndex = 12;
            // 
            // tbl_inventoryBindingNavigator
            // 
            this.tbl_inventoryBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tbl_inventoryBindingNavigator.BindingSource = this.tbl_inventoryBindingSource;
            this.tbl_inventoryBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tbl_inventoryBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tbl_inventoryBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tbl_inventoryBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tbl_inventoryBindingNavigatorSaveItem});
            this.tbl_inventoryBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tbl_inventoryBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tbl_inventoryBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tbl_inventoryBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tbl_inventoryBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tbl_inventoryBindingNavigator.Name = "tbl_inventoryBindingNavigator";
            this.tbl_inventoryBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tbl_inventoryBindingNavigator.Size = new System.Drawing.Size(1069, 27);
            this.tbl_inventoryBindingNavigator.TabIndex = 0;
            this.tbl_inventoryBindingNavigator.Text = "bindingNavigator1";
            this.tbl_inventoryBindingNavigator.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // tbl_inventoryBindingSource
            // 
            this.tbl_inventoryBindingSource.DataMember = "tbl_inventory";
            this.tbl_inventoryBindingSource.DataSource = this.finalProjectDatabaseDataSet;
            // 
            // finalProjectDatabaseDataSet
            // 
            this.finalProjectDatabaseDataSet.DataSetName = "FinalProjectDatabaseDataSet";
            this.finalProjectDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // tbl_inventoryBindingNavigatorSaveItem
            // 
            this.tbl_inventoryBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbl_inventoryBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tbl_inventoryBindingNavigatorSaveItem.Image")));
            this.tbl_inventoryBindingNavigatorSaveItem.Name = "tbl_inventoryBindingNavigatorSaveItem";
            this.tbl_inventoryBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.tbl_inventoryBindingNavigatorSaveItem.Text = "Save Data";
            this.tbl_inventoryBindingNavigatorSaveItem.Click += new System.EventHandler(this.tbl_inventoryBindingNavigatorSaveItem_Click);
            // 
            // item_IDTextBox
            // 
            this.item_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_inventoryBindingSource, "Item ID", true));
            this.item_IDTextBox.Location = new System.Drawing.Point(134, 145);
            this.item_IDTextBox.Multiline = true;
            this.item_IDTextBox.Name = "item_IDTextBox";
            this.item_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.item_IDTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(276, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Inventory Management System";
            // 
            // item_NameTextBox
            // 
            this.item_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_inventoryBindingSource, "Item Name", true));
            this.item_NameTextBox.Location = new System.Drawing.Point(160, 185);
            this.item_NameTextBox.Multiline = true;
            this.item_NameTextBox.Name = "item_NameTextBox";
            this.item_NameTextBox.Size = new System.Drawing.Size(136, 20);
            this.item_NameTextBox.TabIndex = 5;
            // 
            // item_DescriptionTextBox
            // 
            this.item_DescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_inventoryBindingSource, "Item Description", true));
            this.item_DescriptionTextBox.Location = new System.Drawing.Point(427, 142);
            this.item_DescriptionTextBox.Multiline = true;
            this.item_DescriptionTextBox.Name = "item_DescriptionTextBox";
            this.item_DescriptionTextBox.Size = new System.Drawing.Size(151, 20);
            this.item_DescriptionTextBox.TabIndex = 7;
            // 
            // qTYTextBox
            // 
            this.qTYTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_inventoryBindingSource, "QTY", true));
            this.qTYTextBox.Location = new System.Drawing.Point(364, 184);
            this.qTYTextBox.Multiline = true;
            this.qTYTextBox.Name = "qTYTextBox";
            this.qTYTextBox.Size = new System.Drawing.Size(100, 20);
            this.qTYTextBox.TabIndex = 9;
            // 
            // item_URLTextBox
            // 
            this.item_URLTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_inventoryBindingSource, "Item URL", true));
            this.item_URLTextBox.Location = new System.Drawing.Point(695, 139);
            this.item_URLTextBox.Multiline = true;
            this.item_URLTextBox.Name = "item_URLTextBox";
            this.item_URLTextBox.Size = new System.Drawing.Size(200, 20);
            this.item_URLTextBox.TabIndex = 11;
            // 
            // tbl_inventoryDataGridView
            // 
            this.tbl_inventoryDataGridView.AllowUserToAddRows = false;
            this.tbl_inventoryDataGridView.AllowUserToDeleteRows = false;
            this.tbl_inventoryDataGridView.AutoGenerateColumns = false;
            this.tbl_inventoryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tbl_inventoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_inventoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.tbl_inventoryDataGridView.DataSource = this.tbl_inventoryBindingSource;
            this.tbl_inventoryDataGridView.Location = new System.Drawing.Point(0, 354);
            this.tbl_inventoryDataGridView.Name = "tbl_inventoryDataGridView";
            this.tbl_inventoryDataGridView.ReadOnly = true;
            this.tbl_inventoryDataGridView.Size = new System.Drawing.Size(1189, 278);
            this.tbl_inventoryDataGridView.TabIndex = 42;
            this.tbl_inventoryDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbl_inventoryDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Item ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Item ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Item Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Item Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Item Description";
            this.dataGridViewTextBoxColumn3.HeaderText = "Item Description";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "QTY";
            this.dataGridViewTextBoxColumn4.HeaderText = "QTY";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Item URL";
            this.dataGridViewTextBoxColumn5.HeaderText = "Item URL";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // lbltotal
            // 
            this.lbltotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.ForeColor = System.Drawing.Color.White;
            this.lbltotal.Location = new System.Drawing.Point(506, 183);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(138, 20);
            this.lbltotal.TabIndex = 44;
            // 
            // tbl_inventoryTableAdapter
            // 
            this.tbl_inventoryTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbl_inventoryTableAdapter = this.tbl_inventoryTableAdapter;
            this.tableAdapterManager.tbl_signupTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Maksim_Botukh_CPT_185_Final_Project.FinalProjectDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnadd.Image = global::Maksim_Botukh_CPT_185_Final_Project.Properties.Resources.sign_add_icon;
            this.btnadd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnadd.Location = new System.Drawing.Point(3, 289);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(119, 37);
            this.btnadd.TabIndex = 40;
            this.btnadd.Text = "Add";
            this.toolTip1.SetToolTip(this.btnadd, "Click here to add an record");
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnClose.Image = global::Maksim_Botukh_CPT_185_Final_Project.Properties.Resources.close;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(858, 287);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(119, 37);
            this.btnClose.TabIndex = 42;
            this.btnClose.Text = "C&lose";
            this.toolTip1.SetToolTip(this.btnClose, "Click here to close an application");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnsurprise
            // 
            this.btnsurprise.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsurprise.Image = global::Maksim_Botukh_CPT_185_Final_Project.Properties.Resources.clickhere1;
            this.btnsurprise.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsurprise.Location = new System.Drawing.Point(983, 287);
            this.btnsurprise.Name = "btnsurprise";
            this.btnsurprise.Size = new System.Drawing.Size(206, 37);
            this.btnsurprise.TabIndex = 45;
            this.btnsurprise.Text = "Click &here for surprise";
            this.toolTip1.SetToolTip(this.btnsurprise, "Click here for surprise");
            this.btnsurprise.UseVisualStyleBackColor = true;
            this.btnsurprise.Click += new System.EventHandler(this.btnsurprise_Click);
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnsave.Image = global::Maksim_Botukh_CPT_185_Final_Project.Properties.Resources._174314;
            this.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsave.Location = new System.Drawing.Point(295, 289);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(119, 37);
            this.btnsave.TabIndex = 41;
            this.btnsave.Text = "    Save";
            this.toolTip1.SetToolTip(this.btnsave, "Click here to save changes");
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnprevious
            // 
            this.btnprevious.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnprevious.Image = global::Maksim_Botukh_CPT_185_Final_Project.Properties.Resources.images__1_;
            this.btnprevious.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnprevious.Location = new System.Drawing.Point(733, 287);
            this.btnprevious.Name = "btnprevious";
            this.btnprevious.Size = new System.Drawing.Size(119, 37);
            this.btnprevious.TabIndex = 39;
            this.btnprevious.Text = "Previous";
            this.toolTip1.SetToolTip(this.btnprevious, "Go to the previous record");
            this.btnprevious.UseVisualStyleBackColor = true;
            this.btnprevious.Click += new System.EventHandler(this.btnprevious_Click);
            // 
            // btnnext
            // 
            this.btnnext.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnnext.Image = global::Maksim_Botukh_CPT_185_Final_Project.Properties.Resources.next;
            this.btnnext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnnext.Location = new System.Drawing.Point(587, 287);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(119, 37);
            this.btnnext.TabIndex = 38;
            this.btnnext.Text = "Next";
            this.toolTip1.SetToolTip(this.btnnext, "Go to the next record");
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnupdate.Image = global::Maksim_Botukh_CPT_185_Final_Project.Properties.Resources.update;
            this.btnupdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnupdate.Location = new System.Drawing.Point(149, 288);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(119, 37);
            this.btnupdate.TabIndex = 37;
            this.btnupdate.Text = "Update";
            this.toolTip1.SetToolTip(this.btnupdate, "Click here to update a record");
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btndelete.Image = global::Maksim_Botukh_CPT_185_Final_Project.Properties.Resources.delete;
            this.btndelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndelete.Location = new System.Drawing.Point(441, 289);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(119, 37);
            this.btndelete.TabIndex = 36;
            this.btndelete.Text = "Delete";
            this.toolTip1.SetToolTip(this.btndelete, "Delete the record ");
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnImageClear
            // 
            this.btnImageClear.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImageClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnImageClear.Image = global::Maksim_Botukh_CPT_185_Final_Project.Properties.Resources.ima;
            this.btnImageClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImageClear.Location = new System.Drawing.Point(1010, 243);
            this.btnImageClear.Name = "btnImageClear";
            this.btnImageClear.Size = new System.Drawing.Size(179, 37);
            this.btnImageClear.TabIndex = 35;
            this.btnImageClear.Text = "Clear an Image";
            this.toolTip1.SetToolTip(this.btnImageClear, "Click to clear an image of the record");
            this.btnImageClear.UseVisualStyleBackColor = true;
            this.btnImageClear.Click += new System.EventHandler(this.btnImageClear_Click);
            // 
            // btnchooseimage
            // 
            this.btnchooseimage.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchooseimage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnchooseimage.Image = global::Maksim_Botukh_CPT_185_Final_Project.Properties.Resources.ima;
            this.btnchooseimage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnchooseimage.Location = new System.Drawing.Point(1010, 200);
            this.btnchooseimage.Name = "btnchooseimage";
            this.btnchooseimage.Size = new System.Drawing.Size(179, 37);
            this.btnchooseimage.TabIndex = 34;
            this.btnchooseimage.Text = "Choose an Image";
            this.toolTip1.SetToolTip(this.btnchooseimage, "Click to choose an image");
            this.btnchooseimage.UseVisualStyleBackColor = true;
            this.btnchooseimage.Click += new System.EventHandler(this.btnchooseimage_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1189, 24);
            this.menuStrip1.TabIndex = 46;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.toolStripMenuItem1.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Maksim_Botukh_CPT_185_Final_Project.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(3, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // imagePictureBox
            // 
            this.imagePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.tbl_inventoryBindingSource, "Image", true));
            this.imagePictureBox.Location = new System.Drawing.Point(972, 25);
            this.imagePictureBox.Name = "imagePictureBox";
            this.imagePictureBox.Size = new System.Drawing.Size(217, 169);
            this.imagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagePictureBox.TabIndex = 13;
            this.imagePictureBox.TabStop = false;
            // 
            // frmInventory
            // 
            this.AcceptButton = this.btnadd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1189, 629);
            this.Controls.Add(this.btnsurprise);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbl_inventoryDataGridView);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnprevious);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnImageClear);
            this.Controls.Add(this.btnchooseimage);
            this.Controls.Add(imageLabel);
            this.Controls.Add(this.imagePictureBox);
            this.Controls.Add(item_URLLabel);
            this.Controls.Add(this.item_URLTextBox);
            this.Controls.Add(qTYLabel);
            this.Controls.Add(this.qTYTextBox);
            this.Controls.Add(item_DescriptionLabel);
            this.Controls.Add(this.item_DescriptionTextBox);
            this.Controls.Add(item_NameLabel);
            this.Controls.Add(this.item_NameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(item_IDLabel);
            this.Controls.Add(this.item_IDTextBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tbl_inventoryBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maksim Botukh Inventory Management Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_inventoryBindingNavigator)).EndInit();
            this.tbl_inventoryBindingNavigator.ResumeLayout(false);
            this.tbl_inventoryBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_inventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalProjectDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_inventoryDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FinalProjectDatabaseDataSet finalProjectDatabaseDataSet;
        private System.Windows.Forms.BindingSource tbl_inventoryBindingSource;
        private FinalProjectDatabaseDataSetTableAdapters.tbl_inventoryTableAdapter tbl_inventoryTableAdapter;
        private FinalProjectDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tbl_inventoryBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tbl_inventoryBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox item_IDTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox item_NameTextBox;
        private System.Windows.Forms.TextBox item_DescriptionTextBox;
        private System.Windows.Forms.TextBox qTYTextBox;
        private System.Windows.Forms.TextBox item_URLTextBox;
        private System.Windows.Forms.PictureBox imagePictureBox;
        private System.Windows.Forms.Button btnImageClear;
        private System.Windows.Forms.Button btnchooseimage;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnprevious;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.DataGridView tbl_inventoryDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewLinkColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnsurprise;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

