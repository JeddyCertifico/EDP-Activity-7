namespace eCommerce.Forms
{
    partial class Product
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnOutStock = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.productGridView = new System.Windows.Forms.DataGridView();
            this.columnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblInStock = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lblOutStock = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnCustomerSearch = new FontAwesome.Sharp.IconButton();
            this.customerSearchBar = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnExport = new System.Windows.Forms.Button();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInventory
            // 
            this.btnInventory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.ForeColor = System.Drawing.Color.White;
            this.btnInventory.Location = new System.Drawing.Point(3, 7);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(102, 40);
            this.btnInventory.TabIndex = 12;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.UseVisualStyleBackColor = false;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnStock
            // 
            this.btnStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock.ForeColor = System.Drawing.Color.White;
            this.btnStock.Location = new System.Drawing.Point(111, 7);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(115, 40);
            this.btnStock.TabIndex = 11;
            this.btnStock.Text = "In Stock";
            this.btnStock.UseVisualStyleBackColor = false;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.btnInventory, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnOutStock, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnStock, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(596, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(360, 54);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnOutStock
            // 
            this.btnOutStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOutStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnOutStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOutStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOutStock.ForeColor = System.Drawing.Color.White;
            this.btnOutStock.Location = new System.Drawing.Point(233, 7);
            this.btnOutStock.Name = "btnOutStock";
            this.btnOutStock.Size = new System.Drawing.Size(122, 40);
            this.btnOutStock.TabIndex = 10;
            this.btnOutStock.Text = "Out of Stack";
            this.btnOutStock.UseVisualStyleBackColor = false;
            this.btnOutStock.Click += new System.EventHandler(this.btnOutStock_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.tableLayoutPanel2);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(956, 54);
            this.panel7.TabIndex = 11;
            // 
            // productGridView
            // 
            this.productGridView.AllowUserToAddRows = false;
            this.productGridView.AllowUserToDeleteRows = false;
            this.productGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.productGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.productGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.productGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.productGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.productGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.productGridView.ColumnHeadersHeight = 40;
            this.productGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.productGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnId,
            this.columnName,
            this.columnDescription,
            this.columPrice,
            this.columnStock,
            this.columnCategory});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.productGridView.DefaultCellStyle = dataGridViewCellStyle10;
            this.productGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productGridView.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.productGridView.Location = new System.Drawing.Point(0, 54);
            this.productGridView.MultiSelect = false;
            this.productGridView.Name = "productGridView";
            this.productGridView.ReadOnly = true;
            this.productGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.productGridView.RowHeadersVisible = false;
            this.productGridView.RowHeadersWidth = 62;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            this.productGridView.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.productGridView.RowTemplate.Height = 40;
            this.productGridView.RowTemplate.ReadOnly = true;
            this.productGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productGridView.Size = new System.Drawing.Size(956, 510);
            this.productGridView.TabIndex = 0;
            // 
            // columnId
            // 
            this.columnId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.columnId.DefaultCellStyle = dataGridViewCellStyle9;
            this.columnId.FillWeight = 25F;
            this.columnId.HeaderText = "ID";
            this.columnId.MinimumWidth = 8;
            this.columnId.Name = "columnId";
            this.columnId.ReadOnly = true;
            // 
            // columnName
            // 
            this.columnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnName.FillWeight = 150F;
            this.columnName.HeaderText = "Name";
            this.columnName.MinimumWidth = 8;
            this.columnName.Name = "columnName";
            this.columnName.ReadOnly = true;
            // 
            // columnDescription
            // 
            this.columnDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnDescription.FillWeight = 200F;
            this.columnDescription.HeaderText = "Description";
            this.columnDescription.MinimumWidth = 8;
            this.columnDescription.Name = "columnDescription";
            this.columnDescription.ReadOnly = true;
            // 
            // columPrice
            // 
            this.columPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columPrice.HeaderText = "Price";
            this.columPrice.MinimumWidth = 8;
            this.columPrice.Name = "columPrice";
            this.columPrice.ReadOnly = true;
            // 
            // columnStock
            // 
            this.columnStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnStock.FillWeight = 50F;
            this.columnStock.HeaderText = "Stock";
            this.columnStock.MinimumWidth = 8;
            this.columnStock.Name = "columnStock";
            this.columnStock.ReadOnly = true;
            this.columnStock.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // columnCategory
            // 
            this.columnCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnCategory.FillWeight = 200F;
            this.columnCategory.HeaderText = "Category";
            this.columnCategory.MinimumWidth = 8;
            this.columnCategory.Name = "columnCategory";
            this.columnCategory.ReadOnly = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.productGridView);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 224);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(956, 564);
            this.panel6.TabIndex = 7;
            // 
            // lblInStock
            // 
            this.lblInStock.AutoSize = true;
            this.lblInStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInStock.Location = new System.Drawing.Point(12, 116);
            this.lblInStock.Name = "lblInStock";
            this.lblInStock.Size = new System.Drawing.Size(48, 32);
            this.lblInStock.TabIndex = 2;
            this.lblInStock.Text = "21";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(13, 75);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(83, 25);
            this.lbl4.TabIndex = 1;
            this.lbl4.Text = "In Stock";
            // 
            // lblOutStock
            // 
            this.lblOutStock.AutoSize = true;
            this.lblOutStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutStock.Location = new System.Drawing.Point(12, 116);
            this.lblOutStock.Name = "lblOutStock";
            this.lblOutStock.Size = new System.Drawing.Size(31, 32);
            this.lblOutStock.TabIndex = 2;
            this.lblOutStock.Text = "5";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.Location = new System.Drawing.Point(13, 75);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(120, 25);
            this.lbl5.TabIndex = 1;
            this.lbl5.Text = "Out of Stack";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.lblOutStock);
            this.panel5.Controls.Add(this.lbl5);
            this.panel5.Controls.Add(this.iconPictureBox3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(639, 3);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(317, 164);
            this.panel5.TabIndex = 3;
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.Color.White;
            this.iconPictureBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.BoxOpen;
            this.iconPictureBox3.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox3.IconSize = 44;
            this.iconPictureBox3.Location = new System.Drawing.Point(18, 19);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(49, 44);
            this.iconPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBox3.TabIndex = 0;
            this.iconPictureBox3.TabStop = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(12, 116);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(65, 32);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "321";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Total";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lblTotal);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.iconPictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 3);
            this.panel3.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(315, 164);
            this.panel3.TabIndex = 0;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 44;
            this.iconPictureBox1.Location = new System.Drawing.Point(18, 19);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(49, 44);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 54);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(956, 170);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.lblInStock);
            this.panel4.Controls.Add(this.lbl4);
            this.panel4.Controls.Add(this.iconPictureBox2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(321, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(312, 164);
            this.panel4.TabIndex = 1;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.White;
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Box;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 44;
            this.iconPictureBox2.Location = new System.Drawing.Point(18, 19);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(49, 44);
            this.iconPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBox2.TabIndex = 0;
            this.iconPictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.BtnCustomerSearch);
            this.panel2.Controls.Add(this.customerSearchBar);
            this.panel2.Location = new System.Drawing.Point(0, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(430, 41);
            this.panel2.TabIndex = 1;
            // 
            // BtnCustomerSearch
            // 
            this.BtnCustomerSearch.FlatAppearance.BorderSize = 0;
            this.BtnCustomerSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCustomerSearch.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.BtnCustomerSearch.IconColor = System.Drawing.Color.Black;
            this.BtnCustomerSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCustomerSearch.IconSize = 35;
            this.BtnCustomerSearch.Location = new System.Drawing.Point(380, 1);
            this.BtnCustomerSearch.Name = "BtnCustomerSearch";
            this.BtnCustomerSearch.Size = new System.Drawing.Size(50, 39);
            this.BtnCustomerSearch.TabIndex = 1;
            this.BtnCustomerSearch.UseVisualStyleBackColor = true;
            this.BtnCustomerSearch.Click += new System.EventHandler(this.BtnCustomerSearch_Click);
            // 
            // customerSearchBar
            // 
            this.customerSearchBar.BackColor = System.Drawing.Color.White;
            this.customerSearchBar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customerSearchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerSearchBar.ForeColor = System.Drawing.SystemColors.GrayText;
            this.customerSearchBar.Location = new System.Drawing.Point(11, 8);
            this.customerSearchBar.Name = "customerSearchBar";
            this.customerSearchBar.Size = new System.Drawing.Size(361, 23);
            this.customerSearchBar.TabIndex = 0;
            this.customerSearchBar.TabStop = false;
            this.customerSearchBar.Text = "Search";
            this.customerSearchBar.Enter += new System.EventHandler(this.customerSearchBar_Enter);
            this.customerSearchBar.Leave += new System.EventHandler(this.customerSearchBar_Leave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(956, 54);
            this.panel1.TabIndex = 5;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btnExport);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel9.Location = new System.Drawing.Point(871, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(85, 54);
            this.panel9.TabIndex = 14;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnExport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(0, 0);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(85, 54);
            this.btnExport.TabIndex = 12;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(956, 788);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Product";
            this.Text = "Product";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnOutStock;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView productGridView;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblInStock;
        private System.Windows.Forms.Label lbl4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Label lblOutStock;
        private System.Windows.Forms.Label lbl5;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton BtnCustomerSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox customerSearchBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn columPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCategory;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnExport;
    }
}