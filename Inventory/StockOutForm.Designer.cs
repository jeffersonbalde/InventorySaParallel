namespace Inventory
{
    partial class StockOutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockOutForm));
            this.labelSearch = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPlateNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtReqBy = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDriver = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOutQty = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtRcvdBy = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.select = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnInRpt = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
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
            this.labelSearch.Size = new System.Drawing.Size(152, 41);
            this.labelSearch.TabIndex = 10;
            this.labelSearch.Text = "Stock Out";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(171)))), ((int)(((byte)(227)))));
            this.panel2.Controls.Add(this.txtTotal);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txtQuantity);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtFrom);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtOutQty);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtUnit);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.date);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtTo);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtItem);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(18, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(632, 276);
            this.panel2.TabIndex = 13;
            // 
            // txtUnit
            // 
            this.txtUnit.Enabled = false;
            this.txtUnit.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnit.Location = new System.Drawing.Point(129, 171);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(165, 38);
            this.txtUnit.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 32);
            this.label1.TabIndex = 50;
            this.label1.Text = "Unit";
            // 
            // date
            // 
            this.date.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(46)))), ((int)(((byte)(68)))));
            this.date.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date.Location = new System.Drawing.Point(129, 21);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(165, 38);
            this.date.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(21, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 32);
            this.label4.TabIndex = 47;
            this.label4.Text = "Date";
            // 
            // txtTo
            // 
            this.txtTo.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTo.Location = new System.Drawing.Point(129, 74);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(467, 38);
            this.txtTo.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(21, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 32);
            this.label7.TabIndex = 46;
            this.label7.Text = "To";
            // 
            // txtItem
            // 
            this.txtItem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItem.Location = new System.Drawing.Point(129, 122);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(467, 38);
            this.txtItem.TabIndex = 44;
            this.txtItem.TextChanged += new System.EventHandler(this.txtItem_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 32);
            this.label3.TabIndex = 45;
            this.label3.Text = "Item";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(171)))), ((int)(((byte)(227)))));
            this.panel1.Controls.Add(this.txtTime);
            this.panel1.Controls.Add(this.txtPlateNo);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtReqBy);
            this.panel1.Controls.Add(this.txtRcvdBy);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtDriver);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(670, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 276);
            this.panel1.TabIndex = 14;
            // 
            // txtPlateNo
            // 
            this.txtPlateNo.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlateNo.Location = new System.Drawing.Point(163, 118);
            this.txtPlateNo.Name = "txtPlateNo";
            this.txtPlateNo.Size = new System.Drawing.Size(443, 38);
            this.txtPlateNo.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 32);
            this.label2.TabIndex = 56;
            this.label2.Text = "Plate No.";
            // 
            // txtReqBy
            // 
            this.txtReqBy.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReqBy.Location = new System.Drawing.Point(163, 20);
            this.txtReqBy.Name = "txtReqBy";
            this.txtReqBy.Size = new System.Drawing.Size(443, 38);
            this.txtReqBy.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(26, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 32);
            this.label5.TabIndex = 54;
            this.label5.Text = "Req. By";
            // 
            // txtDriver
            // 
            this.txtDriver.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDriver.Location = new System.Drawing.Point(163, 68);
            this.txtDriver.Name = "txtDriver";
            this.txtDriver.Size = new System.Drawing.Size(443, 38);
            this.txtDriver.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(26, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 32);
            this.label6.TabIndex = 53;
            this.label6.Text = "Driver";
            // 
            // txtOutQty
            // 
            this.txtOutQty.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutQty.Location = new System.Drawing.Point(129, 222);
            this.txtOutQty.Name = "txtOutQty";
            this.txtOutQty.Size = new System.Drawing.Size(165, 38);
            this.txtOutQty.TabIndex = 51;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(21, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 32);
            this.label8.TabIndex = 52;
            this.label8.Text = "Out Qty";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Snow;
            this.label9.Location = new System.Drawing.Point(328, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 32);
            this.label9.TabIndex = 53;
            this.label9.Text = "From";
            // 
            // txtFrom
            // 
            this.txtFrom.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFrom.Location = new System.Drawing.Point(414, 21);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(182, 38);
            this.txtFrom.TabIndex = 54;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Enabled = false;
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(414, 171);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(182, 38);
            this.txtQuantity.TabIndex = 56;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Snow;
            this.label10.Location = new System.Drawing.Point(300, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 32);
            this.label10.TabIndex = 55;
            this.label10.Text = "Quantity";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(414, 221);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(182, 38);
            this.txtTotal.TabIndex = 58;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Snow;
            this.label11.Location = new System.Drawing.Point(300, 221);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 32);
            this.label11.TabIndex = 57;
            this.label11.Text = "Total";
            // 
            // txtTime
            // 
            this.txtTime.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.Location = new System.Drawing.Point(163, 216);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(443, 38);
            this.txtTime.TabIndex = 59;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(26, 218);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 32);
            this.label12.TabIndex = 60;
            this.label12.Text = "Time";
            // 
            // txtRcvdBy
            // 
            this.txtRcvdBy.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRcvdBy.Location = new System.Drawing.Point(163, 166);
            this.txtRcvdBy.Name = "txtRcvdBy";
            this.txtRcvdBy.Size = new System.Drawing.Size(443, 38);
            this.txtRcvdBy.TabIndex = 57;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(26, 168);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 32);
            this.label13.TabIndex = 58;
            this.label13.Text = "Rcvd By";
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
            this.Column2,
            this.Column8,
            this.Column4,
            this.Column3,
            this.Column5,
            this.Column6,
            this.Column7,
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
            this.dataGridView1.Location = new System.Drawing.Point(19, 329);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1283, 233);
            this.dataGridView1.TabIndex = 22;
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
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Item";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
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
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column4.HeaderText = "Quantity";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 123;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "Added Quantity";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 194;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.HeaderText = "Total";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 87;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column6.HeaderText = "Care Of";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 116;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "ID";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Visible = false;
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
            // btnInRpt
            // 
            this.btnInRpt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.btnInRpt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInRpt.FlatAppearance.BorderSize = 0;
            this.btnInRpt.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInRpt.ForeColor = System.Drawing.Color.White;
            this.btnInRpt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInRpt.Location = new System.Drawing.Point(431, 568);
            this.btnInRpt.Name = "btnInRpt";
            this.btnInRpt.Size = new System.Drawing.Size(131, 50);
            this.btnInRpt.TabIndex = 29;
            this.btnInRpt.Text = "In Rpt";
            this.btnInRpt.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(294, 568);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(131, 50);
            this.btnClear.TabIndex = 28;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(157, 568);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(131, 50);
            this.btnUpdate.TabIndex = 27;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(20, 568);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(131, 50);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(235, 24);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(182, 38);
            this.txtID.TabIndex = 59;
            this.txtID.Visible = false;
            // 
            // StockOutForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1302, 613);
            this.ControlBox = false;
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnInRpt);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelSearch);
            this.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "StockOutForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox txtPlateNo;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtReqBy;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtDriver;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtOutQty;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox txtRcvdBy;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewImageColumn select;
        public System.Windows.Forms.Button btnInRpt;
        public System.Windows.Forms.Button btnClear;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.TextBox txtID;
    }
}