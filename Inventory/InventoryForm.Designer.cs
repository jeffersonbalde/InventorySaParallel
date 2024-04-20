namespace Inventory
{
    partial class InventoryForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryForm));
            this.labelSearch = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboPackaging = new System.Windows.Forms.ComboBox();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cboItemClass = new System.Windows.Forms.ComboBox();
            this.cboClass = new System.Windows.Forms.ComboBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPacks = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCase = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtProdcode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCashRpt = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.select = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtID = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.labelSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(46)))), ((int)(((byte)(68)))));
            this.labelSearch.Location = new System.Drawing.Point(12, 9);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(150, 41);
            this.labelSearch.TabIndex = 9;
            this.labelSearch.Text = "Inventory";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(171)))), ((int)(((byte)(227)))));
            this.panel1.Controls.Add(this.cboPackaging);
            this.panel1.Controls.Add(this.txtUnit);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtTotal);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.cboItemClass);
            this.panel1.Controls.Add(this.cboClass);
            this.panel1.Controls.Add(this.date);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtSize);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtPacks);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtCase);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtProdcode);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtItem);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtDescription);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(18, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 504);
            this.panel1.TabIndex = 10;
            // 
            // cboPackaging
            // 
            this.cboPackaging.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPackaging.FormattingEnabled = true;
            this.cboPackaging.Items.AddRange(new object[] {
            "test"});
            this.cboPackaging.Location = new System.Drawing.Point(483, 234);
            this.cboPackaging.Name = "cboPackaging";
            this.cboPackaging.Size = new System.Drawing.Size(156, 39);
            this.cboPackaging.TabIndex = 52;
            // 
            // txtUnit
            // 
            this.txtUnit.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnit.Location = new System.Drawing.Point(483, 287);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(156, 38);
            this.txtUnit.TabIndex = 46;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(360, 289);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 32);
            this.label10.TabIndex = 51;
            this.label10.Text = "Unit";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(483, 387);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(156, 38);
            this.txtTotal.TabIndex = 48;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(360, 389);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 32);
            this.label11.TabIndex = 50;
            this.label11.Text = "Total";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(483, 335);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(156, 38);
            this.txtPrice.TabIndex = 47;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(360, 337);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 32);
            this.label12.TabIndex = 49;
            this.label12.Text = "Price";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(360, 237);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(126, 32);
            this.label13.TabIndex = 45;
            this.label13.Text = "Packaging";
            // 
            // cboItemClass
            // 
            this.cboItemClass.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboItemClass.FormattingEnabled = true;
            this.cboItemClass.Items.AddRange(new object[] {
            "test"});
            this.cboItemClass.Location = new System.Drawing.Point(151, 437);
            this.cboItemClass.Name = "cboItemClass";
            this.cboItemClass.Size = new System.Drawing.Size(488, 39);
            this.cboItemClass.TabIndex = 44;
            // 
            // cboClass
            // 
            this.cboClass.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboClass.FormattingEnabled = true;
            this.cboClass.Items.AddRange(new object[] {
            "test"});
            this.cboClass.Location = new System.Drawing.Point(151, 232);
            this.cboClass.Name = "cboClass";
            this.cboClass.Size = new System.Drawing.Size(173, 39);
            this.cboClass.TabIndex = 43;
            // 
            // date
            // 
            this.date.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(46)))), ((int)(((byte)(68)))));
            this.date.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date.Location = new System.Drawing.Point(151, 30);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(488, 38);
            this.date.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 437);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 32);
            this.label1.TabIndex = 41;
            this.label1.Text = "Item Class";
            // 
            // txtSize
            // 
            this.txtSize.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSize.Location = new System.Drawing.Point(151, 285);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(173, 38);
            this.txtSize.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 32);
            this.label2.TabIndex = 40;
            this.label2.Text = "Size";
            // 
            // txtPacks
            // 
            this.txtPacks.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPacks.Location = new System.Drawing.Point(151, 385);
            this.txtPacks.Name = "txtPacks";
            this.txtPacks.Size = new System.Drawing.Size(173, 38);
            this.txtPacks.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(14, 387);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 32);
            this.label5.TabIndex = 39;
            this.label5.Text = "Packs";
            // 
            // txtCase
            // 
            this.txtCase.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCase.Location = new System.Drawing.Point(151, 333);
            this.txtCase.Name = "txtCase";
            this.txtCase.Size = new System.Drawing.Size(173, 38);
            this.txtCase.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(14, 335);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 32);
            this.label9.TabIndex = 38;
            this.label9.Text = "Case";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(14, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 32);
            this.label4.TabIndex = 32;
            this.label4.Text = "Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(14, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 32);
            this.label8.TabIndex = 31;
            this.label8.Text = "Class";
            // 
            // txtProdcode
            // 
            this.txtProdcode.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdcode.Location = new System.Drawing.Point(151, 83);
            this.txtProdcode.Name = "txtProdcode";
            this.txtProdcode.Size = new System.Drawing.Size(488, 38);
            this.txtProdcode.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(14, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 32);
            this.label7.TabIndex = 30;
            this.label7.Text = "Prodcode";
            // 
            // txtItem
            // 
            this.txtItem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItem.Location = new System.Drawing.Point(151, 183);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(488, 38);
            this.txtItem.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(14, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 32);
            this.label6.TabIndex = 29;
            this.label6.Text = "Item";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(151, 131);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(488, 38);
            this.txtDescription.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 32);
            this.label3.TabIndex = 28;
            this.label3.Text = "Description";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(14, 559);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(131, 50);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(151, 559);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 50);
            this.button1.TabIndex = 17;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(288, 559);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(131, 50);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Clear";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCashRpt
            // 
            this.btnCashRpt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.btnCashRpt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCashRpt.FlatAppearance.BorderSize = 0;
            this.btnCashRpt.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCashRpt.ForeColor = System.Drawing.Color.White;
            this.btnCashRpt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCashRpt.Location = new System.Drawing.Point(425, 559);
            this.btnCashRpt.Name = "btnCashRpt";
            this.btnCashRpt.Size = new System.Drawing.Size(131, 50);
            this.btnCashRpt.TabIndex = 19;
            this.btnCashRpt.Text = "Cash Rpt";
            this.btnCashRpt.UseVisualStyleBackColor = false;
            this.btnCashRpt.Click += new System.EventHandler(this.btnCashRpt_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 13F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.prodcode,
            this.Column3,
            this.Column2,
            this.Item,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column9,
            this.Column10,
            this.Column8,
            this.Column11,
            this.Column12,
            this.selectt,
            this.Column4,
            this.select});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 13F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(227)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(212)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(694, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(607, 562);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "#";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 54;
            // 
            // prodcode
            // 
            this.prodcode.HeaderText = "Prodcode";
            this.prodcode.Name = "prodcode";
            this.prodcode.ReadOnly = true;
            this.prodcode.Visible = false;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Description";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Item";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Item
            // 
            this.Item.HeaderText = "Class";
            this.Item.Name = "Item";
            this.Item.ReadOnly = true;
            this.Item.Visible = false;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Size";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Case";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Packs";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Visible = false;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "ItemClass";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Visible = false;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Packaging";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Visible = false;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column8.HeaderText = "Unit";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 80;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Price";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Visible = false;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Total";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Visible = false;
            // 
            // selectt
            // 
            this.selectt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.selectt.DefaultCellStyle = dataGridViewCellStyle6;
            this.selectt.HeaderText = "Quantity";
            this.selectt.MinimumWidth = 6;
            this.selectt.Name = "selectt";
            this.selectt.ReadOnly = true;
            this.selectt.Width = 123;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "ID";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // select
            // 
            this.select.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.select.HeaderText = "";
            this.select.Image = ((System.Drawing.Image)(resources.GetObject("select.Image")));
            this.select.Name = "select";
            this.select.ReadOnly = true;
            this.select.Width = 5;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(184, 14);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(113, 38);
            this.txtID.TabIndex = 53;
            this.txtID.Visible = false;
            // 
            // InventoryForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1302, 613);
            this.ControlBox = false;
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCashRpt);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelSearch);
            this.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "InventoryForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Button btnCashRpt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtProdcode;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtPacks;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtCase;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.ComboBox cboItemClass;
        public System.Windows.Forms.ComboBox cboClass;
        public System.Windows.Forms.DateTimePicker date;
        public System.Windows.Forms.ComboBox cboPackaging;
        public System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn selectt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewImageColumn select;
        public System.Windows.Forms.TextBox txtID;
    }
}