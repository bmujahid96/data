namespace evoh.yard.Forms
{
    partial class Patti
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtvno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvpatti = new System.Windows.Forms.DataGridView();
            this.Srln = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.txttotalamt = new System.Windows.Forms.TextBox();
            this.txttotalkg = new System.Windows.Forms.TextBox();
            this.txttotalbags = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dgvcustomerdata = new System.Windows.Forms.DataGridView();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnItem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpatti)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcustomerdata)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtCustomerName);
            this.groupBox1.Controls.Add(this.txtvno);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(727, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATA";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(324, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(36, 57);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(283, 27);
            this.txtCustomerName.TabIndex = 2;
            this.txtCustomerName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtCustomerName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCustomerName_KeyDown);
            // 
            // txtvno
            // 
            this.txtvno.Location = new System.Drawing.Point(449, 57);
            this.txtvno.Name = "txtvno";
            this.txtvno.Size = new System.Drawing.Size(251, 27);
            this.txtvno.TabIndex = 2;
            this.txtvno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtvno_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(445, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "V No :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Name :";
            // 
            // dgvpatti
            // 
            this.dgvpatti.AllowUserToAddRows = false;
            this.dgvpatti.AllowUserToResizeColumns = false;
            this.dgvpatti.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvpatti.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvpatti.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvpatti.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvpatti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpatti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Srln,
            this.ItemCode,
            this.Item,
            this.Bag,
            this.Kg,
            this.Price,
            this.Total,
            this.ItemId,
            this.Id});
            this.dgvpatti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvpatti.GridColor = System.Drawing.SystemColors.Control;
            this.dgvpatti.Location = new System.Drawing.Point(0, 0);
            this.dgvpatti.MultiSelect = false;
            this.dgvpatti.Name = "dgvpatti";
            this.dgvpatti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvpatti.Size = new System.Drawing.Size(727, 238);
            this.dgvpatti.TabIndex = 1;
            this.dgvpatti.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvpatti_CellContentClick);
            this.dgvpatti.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvpatti_CellEnter);
            this.dgvpatti.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvpatti_CellLeave);
            this.dgvpatti.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvpatti_EditingControlShowing);
            this.dgvpatti.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvpatti_RowPostPaint);
            // 
            // Srln
            // 
            this.Srln.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Srln.HeaderText = "Srln";
            this.Srln.Name = "Srln";
            this.Srln.ReadOnly = true;
            this.Srln.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Srln.Width = 40;
            // 
            // ItemCode
            // 
            this.ItemCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ItemCode.DataPropertyName = "Code";
            this.ItemCode.HeaderText = "ItemCode";
            this.ItemCode.Name = "ItemCode";
            // 
            // Item
            // 
            this.Item.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Item.DataPropertyName = "item";
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            this.Item.ReadOnly = true;
            this.Item.Width = 200;
            // 
            // Bag
            // 
            this.Bag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Bag.DataPropertyName = "bag";
            this.Bag.HeaderText = "Bag";
            this.Bag.Name = "Bag";
            this.Bag.Width = 80;
            // 
            // Kg
            // 
            this.Kg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Kg.DataPropertyName = "kg";
            this.Kg.HeaderText = "Kg";
            this.Kg.Name = "Kg";
            this.Kg.Width = 80;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Price.DataPropertyName = "price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.Width = 80;
            // 
            // Total
            // 
            this.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Total.DataPropertyName = "totalprice";
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // ItemId
            // 
            this.ItemId.DataPropertyName = "itemid";
            this.ItemId.HeaderText = "ItemID";
            this.ItemId.Name = "ItemId";
            this.ItemId.Visible = false;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lbl);
            this.groupBox2.Controls.Add(this.txttotalamt);
            this.groupBox2.Controls.Add(this.txttotalkg);
            this.groupBox2.Controls.Add(this.txttotalbags);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(17, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(703, 79);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(381, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Total Bag\'s :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(490, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Total Kg :";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(598, 23);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(85, 20);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "Total AMT :";
            // 
            // txttotalamt
            // 
            this.txttotalamt.BackColor = System.Drawing.SystemColors.Info;
            this.txttotalamt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttotalamt.Location = new System.Drawing.Point(597, 46);
            this.txttotalamt.Name = "txttotalamt";
            this.txttotalamt.Size = new System.Drawing.Size(100, 27);
            this.txttotalamt.TabIndex = 0;
            // 
            // txttotalkg
            // 
            this.txttotalkg.BackColor = System.Drawing.SystemColors.Info;
            this.txttotalkg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttotalkg.Location = new System.Drawing.Point(489, 46);
            this.txttotalkg.Name = "txttotalkg";
            this.txttotalkg.Size = new System.Drawing.Size(100, 27);
            this.txttotalkg.TabIndex = 0;
            // 
            // txttotalbags
            // 
            this.txttotalbags.BackColor = System.Drawing.SystemColors.Info;
            this.txttotalbags.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttotalbags.Location = new System.Drawing.Point(381, 46);
            this.txttotalbags.Name = "txttotalbags";
            this.txttotalbags.Size = new System.Drawing.Size(100, 27);
            this.txttotalbags.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(63, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(727, 500);
            this.panel2.TabIndex = 4;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dgvcustomerdata);
            this.panel7.Controls.Add(this.dgvpatti);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 100);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(727, 238);
            this.panel7.TabIndex = 4;
            // 
            // dgvcustomerdata
            // 
            this.dgvcustomerdata.AllowUserToAddRows = false;
            this.dgvcustomerdata.AllowUserToDeleteRows = false;
            this.dgvcustomerdata.AllowUserToResizeColumns = false;
            this.dgvcustomerdata.AllowUserToResizeRows = false;
            this.dgvcustomerdata.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dgvcustomerdata.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvcustomerdata.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvcustomerdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcustomerdata.ColumnHeadersVisible = false;
            this.dgvcustomerdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerName,
            this.CustomerId});
            this.dgvcustomerdata.Location = new System.Drawing.Point(36, 1);
            this.dgvcustomerdata.Name = "dgvcustomerdata";
            this.dgvcustomerdata.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcustomerdata.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvcustomerdata.RowHeadersVisible = false;
            this.dgvcustomerdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvcustomerdata.Size = new System.Drawing.Size(283, 150);
            this.dgvcustomerdata.TabIndex = 2;
            this.dgvcustomerdata.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvcustomerdata_KeyDown);
            // 
            // CustomerName
            // 
            this.CustomerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CustomerName.DataPropertyName = "Name";
            this.CustomerName.HeaderText = "CustomerName";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            // 
            // CustomerId
            // 
            this.CustomerId.DataPropertyName = "Id";
            this.CustomerId.HeaderText = "CustomerId";
            this.CustomerId.Name = "CustomerId";
            this.CustomerId.ReadOnly = true;
            this.CustomerId.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(727, 100);
            this.panel1.TabIndex = 3;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.groupBox3);
            this.panel8.Controls.Add(this.groupBox2);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(0, 338);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(727, 162);
            this.panel8.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnadd);
            this.groupBox3.Controls.Add(this.btnexit);
            this.groupBox3.Controls.Add(this.btnreset);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(15, 87);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(705, 62);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Action";
            // 
            // btnadd
            // 
            this.btnadd.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnadd.Location = new System.Drawing.Point(224, 24);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(80, 30);
            this.btnadd.TabIndex = 1;
            this.btnadd.Text = "&Save";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnexit
            // 
            this.btnexit.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnexit.Location = new System.Drawing.Point(400, 24);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(80, 30);
            this.btnexit.TabIndex = 2;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnreset
            // 
            this.btnreset.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnreset.Location = new System.Drawing.Point(312, 24);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(80, 30);
            this.btnreset.TabIndex = 3;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.panel9);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(858, 36);
            this.panel4.TabIndex = 4;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btnItem);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel9.Location = new System.Drawing.Point(790, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(68, 36);
            this.panel9.TabIndex = 1;
            // 
            // btnItem
            // 
            this.btnItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnItem.Location = new System.Drawing.Point(0, 0);
            this.btnItem.Name = "btnItem";
            this.btnItem.Size = new System.Drawing.Size(68, 36);
            this.btnItem.TabIndex = 0;
            this.btnItem.UseVisualStyleBackColor = true;
            this.btnItem.Click += new System.EventHandler(this.btnItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "CREATE PATTI";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 36);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(63, 500);
            this.panel5.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 536);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(858, 14);
            this.panel6.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(790, 36);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(68, 500);
            this.panel3.TabIndex = 5;
            // 
            // Patti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(858, 550);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Patti";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Patti_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpatti)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcustomerdata)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvpatti;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtvno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txttotalamt;
        private System.Windows.Forms.TextBox txttotalkg;
        private System.Windows.Forms.TextBox txttotalbags;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.DataGridViewTextBoxColumn Srln;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.DataGridView dgvcustomerdata;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerId;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnItem;
    }
}