namespace MovieTicketBookingSystem
{
    partial class buyTicketForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(buyTicketForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buyTicket_clear = new System.Windows.Forms.Button();
            this.buyTicket_selectMovie = new System.Windows.Forms.Button();
            this.buyTicket_regularPrice = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buyTicket_genre = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.buyTicket_movieName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buyTicket_movieID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.buyTicket_availableChairs = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.buyTicket_foods = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.buyTicket_drinks = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buyTicket_calculateBtn = new System.Windows.Forms.Button();
            this.buyTicket_clearFields = new System.Windows.Forms.Button();
            this.buyTicket_receiptBtn = new System.Windows.Forms.Button();
            this.buyTicket_buyBtn = new System.Windows.Forms.Button();
            this.buyTicket_changeAmount = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.buyTicket_amount = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.buyTicket_totalPrice = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(21, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 307);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(598, 218);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Available Movies";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.buyTicket_clear);
            this.panel2.Controls.Add(this.buyTicket_selectMovie);
            this.panel2.Controls.Add(this.buyTicket_regularPrice);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.buyTicket_genre);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.buyTicket_movieName);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.buyTicket_movieID);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(21, 353);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(640, 318);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // buyTicket_clear
            // 
            this.buyTicket_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.buyTicket_clear.FlatAppearance.BorderSize = 0;
            this.buyTicket_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buyTicket_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyTicket_clear.ForeColor = System.Drawing.Color.White;
            this.buyTicket_clear.Location = new System.Drawing.Point(434, 250);
            this.buyTicket_clear.Name = "buyTicket_clear";
            this.buyTicket_clear.Size = new System.Drawing.Size(184, 42);
            this.buyTicket_clear.TabIndex = 29;
            this.buyTicket_clear.Text = "CLEAR";
            this.buyTicket_clear.UseVisualStyleBackColor = false;
            this.buyTicket_clear.Click += new System.EventHandler(this.buyTicket_clear_Click);
            // 
            // buyTicket_selectMovie
            // 
            this.buyTicket_selectMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.buyTicket_selectMovie.FlatAppearance.BorderSize = 0;
            this.buyTicket_selectMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buyTicket_selectMovie.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyTicket_selectMovie.ForeColor = System.Drawing.Color.White;
            this.buyTicket_selectMovie.Location = new System.Drawing.Point(225, 251);
            this.buyTicket_selectMovie.Name = "buyTicket_selectMovie";
            this.buyTicket_selectMovie.Size = new System.Drawing.Size(171, 42);
            this.buyTicket_selectMovie.TabIndex = 28;
            this.buyTicket_selectMovie.Text = "SELECT MOVIE";
            this.buyTicket_selectMovie.UseVisualStyleBackColor = false;
            this.buyTicket_selectMovie.Click += new System.EventHandler(this.addMovie_addBtn_Click);
            // 
            // buyTicket_regularPrice
            // 
            this.buyTicket_regularPrice.AutoSize = true;
            this.buyTicket_regularPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyTicket_regularPrice.Location = new System.Drawing.Point(365, 196);
            this.buyTicket_regularPrice.Name = "buyTicket_regularPrice";
            this.buyTicket_regularPrice.Size = new System.Drawing.Size(38, 18);
            this.buyTicket_regularPrice.TabIndex = 15;
            this.buyTicket_regularPrice.Text = "------";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(258, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Regular Price:";
            // 
            // buyTicket_genre
            // 
            this.buyTicket_genre.AutoSize = true;
            this.buyTicket_genre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyTicket_genre.Location = new System.Drawing.Point(365, 151);
            this.buyTicket_genre.Name = "buyTicket_genre";
            this.buyTicket_genre.Size = new System.Drawing.Size(38, 18);
            this.buyTicket_genre.TabIndex = 13;
            this.buyTicket_genre.Text = "------";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(302, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 18);
            this.label9.TabIndex = 12;
            this.label9.Text = "Genre :";
            // 
            // buyTicket_movieName
            // 
            this.buyTicket_movieName.AutoSize = true;
            this.buyTicket_movieName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyTicket_movieName.Location = new System.Drawing.Point(365, 99);
            this.buyTicket_movieName.Name = "buyTicket_movieName";
            this.buyTicket_movieName.Size = new System.Drawing.Size(38, 18);
            this.buyTicket_movieName.TabIndex = 11;
            this.buyTicket_movieName.Text = "------";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(258, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Movie Name:";
            // 
            // buyTicket_movieID
            // 
            this.buyTicket_movieID.AutoSize = true;
            this.buyTicket_movieID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyTicket_movieID.Location = new System.Drawing.Point(365, 55);
            this.buyTicket_movieID.Name = "buyTicket_movieID";
            this.buyTicket_movieID.Size = new System.Drawing.Size(38, 18);
            this.buyTicket_movieID.TabIndex = 9;
            this.buyTicket_movieID.Text = "------";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(285, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Movie ID :";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(28, 44);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(175, 227);
            this.panel4.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 227);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(45, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 18);
            this.label13.TabIndex = 11;
            this.label13.Text = "Available Chair :";
            // 
            // buyTicket_availableChairs
            // 
            this.buyTicket_availableChairs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyTicket_availableChairs.FormattingEnabled = true;
            this.buyTicket_availableChairs.Items.AddRange(new object[] {
            "1st Class Seat",
            "2nd Class Seat",
            "Normal Seat"});
            this.buyTicket_availableChairs.Location = new System.Drawing.Point(179, 39);
            this.buyTicket_availableChairs.Name = "buyTicket_availableChairs";
            this.buyTicket_availableChairs.Size = new System.Drawing.Size(239, 28);
            this.buyTicket_availableChairs.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(34, 95);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(123, 17);
            this.label14.TabIndex = 13;
            this.label14.Text = "Available Foods";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(98, 128);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 18);
            this.label16.TabIndex = 14;
            this.label16.Text = "Foods :";
            // 
            // buyTicket_foods
            // 
            this.buyTicket_foods.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyTicket_foods.FormattingEnabled = true;
            this.buyTicket_foods.Items.AddRange(new object[] {
            "Popcorn",
            "Fries"});
            this.buyTicket_foods.Location = new System.Drawing.Point(179, 124);
            this.buyTicket_foods.Name = "buyTicket_foods";
            this.buyTicket_foods.Size = new System.Drawing.Size(239, 28);
            this.buyTicket_foods.TabIndex = 15;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(98, 182);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 18);
            this.label15.TabIndex = 16;
            this.label15.Text = "Drinks :";
            // 
            // buyTicket_drinks
            // 
            this.buyTicket_drinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyTicket_drinks.FormattingEnabled = true;
            this.buyTicket_drinks.Items.AddRange(new object[] {
            "Orange Juice",
            "Softdrink"});
            this.buyTicket_drinks.Location = new System.Drawing.Point(179, 178);
            this.buyTicket_drinks.Name = "buyTicket_drinks";
            this.buyTicket_drinks.Size = new System.Drawing.Size(238, 28);
            this.buyTicket_drinks.TabIndex = 17;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(34, 303);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(92, 17);
            this.label17.TabIndex = 18;
            this.label17.Text = "Total Price:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.buyTicket_calculateBtn);
            this.panel3.Controls.Add(this.buyTicket_clearFields);
            this.panel3.Controls.Add(this.buyTicket_receiptBtn);
            this.panel3.Controls.Add(this.buyTicket_buyBtn);
            this.panel3.Controls.Add(this.buyTicket_changeAmount);
            this.panel3.Controls.Add(this.label20);
            this.panel3.Controls.Add(this.buyTicket_amount);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.buyTicket_totalPrice);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.buyTicket_drinks);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.buyTicket_foods);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.buyTicket_availableChairs);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Location = new System.Drawing.Point(688, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(451, 647);
            this.panel3.TabIndex = 2;
            // 
            // buyTicket_calculateBtn
            // 
            this.buyTicket_calculateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.buyTicket_calculateBtn.FlatAppearance.BorderSize = 0;
            this.buyTicket_calculateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buyTicket_calculateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyTicket_calculateBtn.ForeColor = System.Drawing.Color.White;
            this.buyTicket_calculateBtn.Location = new System.Drawing.Point(179, 224);
            this.buyTicket_calculateBtn.Name = "buyTicket_calculateBtn";
            this.buyTicket_calculateBtn.Size = new System.Drawing.Size(238, 42);
            this.buyTicket_calculateBtn.TabIndex = 33;
            this.buyTicket_calculateBtn.Text = "CALCULATE";
            this.buyTicket_calculateBtn.UseVisualStyleBackColor = false;
            this.buyTicket_calculateBtn.Click += new System.EventHandler(this.buyTicket_calculateBtn_Click);
            // 
            // buyTicket_clearFields
            // 
            this.buyTicket_clearFields.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.buyTicket_clearFields.FlatAppearance.BorderSize = 0;
            this.buyTicket_clearFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buyTicket_clearFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyTicket_clearFields.ForeColor = System.Drawing.Color.White;
            this.buyTicket_clearFields.Location = new System.Drawing.Point(76, 568);
            this.buyTicket_clearFields.Name = "buyTicket_clearFields";
            this.buyTicket_clearFields.Size = new System.Drawing.Size(316, 42);
            this.buyTicket_clearFields.TabIndex = 32;
            this.buyTicket_clearFields.Text = "CLEAR";
            this.buyTicket_clearFields.UseVisualStyleBackColor = false;
            this.buyTicket_clearFields.Click += new System.EventHandler(this.buyTicket_clearFields_Click);
            // 
            // buyTicket_receiptBtn
            // 
            this.buyTicket_receiptBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.buyTicket_receiptBtn.FlatAppearance.BorderSize = 0;
            this.buyTicket_receiptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buyTicket_receiptBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyTicket_receiptBtn.ForeColor = System.Drawing.Color.White;
            this.buyTicket_receiptBtn.Location = new System.Drawing.Point(73, 503);
            this.buyTicket_receiptBtn.Name = "buyTicket_receiptBtn";
            this.buyTicket_receiptBtn.Size = new System.Drawing.Size(316, 42);
            this.buyTicket_receiptBtn.TabIndex = 31;
            this.buyTicket_receiptBtn.Text = "RECEIPT";
            this.buyTicket_receiptBtn.UseVisualStyleBackColor = false;
            this.buyTicket_receiptBtn.Click += new System.EventHandler(this.buyTicket_receiptBtn_Click);
            // 
            // buyTicket_buyBtn
            // 
            this.buyTicket_buyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.buyTicket_buyBtn.FlatAppearance.BorderSize = 0;
            this.buyTicket_buyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buyTicket_buyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyTicket_buyBtn.ForeColor = System.Drawing.Color.White;
            this.buyTicket_buyBtn.Location = new System.Drawing.Point(73, 439);
            this.buyTicket_buyBtn.Name = "buyTicket_buyBtn";
            this.buyTicket_buyBtn.Size = new System.Drawing.Size(316, 42);
            this.buyTicket_buyBtn.TabIndex = 30;
            this.buyTicket_buyBtn.Text = "BUY";
            this.buyTicket_buyBtn.UseVisualStyleBackColor = false;
            this.buyTicket_buyBtn.Click += new System.EventHandler(this.buyTicket_buyBtn_Click);
            // 
            // buyTicket_changeAmount
            // 
            this.buyTicket_changeAmount.AutoSize = true;
            this.buyTicket_changeAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyTicket_changeAmount.Location = new System.Drawing.Point(173, 397);
            this.buyTicket_changeAmount.Name = "buyTicket_changeAmount";
            this.buyTicket_changeAmount.Size = new System.Drawing.Size(44, 18);
            this.buyTicket_changeAmount.TabIndex = 23;
            this.buyTicket_changeAmount.Text = "$0.00";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(83, 397);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(71, 18);
            this.label20.TabIndex = 22;
            this.label20.Text = "Change : ";
            // 
            // buyTicket_amount
            // 
            this.buyTicket_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyTicket_amount.Location = new System.Drawing.Point(179, 343);
            this.buyTicket_amount.Name = "buyTicket_amount";
            this.buyTicket_amount.Size = new System.Drawing.Size(238, 27);
            this.buyTicket_amount.TabIndex = 21;
            this.buyTicket_amount.TextChanged += new System.EventHandler(this.buyTicket_amount_TextChanged);
            this.buyTicket_amount.Enter += new System.EventHandler(this.buyTicket_amount_Enter);
            this.buyTicket_amount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.buyTicket_amount_KeyDown);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(86, 343);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(71, 18);
            this.label19.TabIndex = 20;
            this.label19.Text = "Amount : ";
            // 
            // buyTicket_totalPrice
            // 
            this.buyTicket_totalPrice.AutoSize = true;
            this.buyTicket_totalPrice.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyTicket_totalPrice.Location = new System.Drawing.Point(132, 303);
            this.buyTicket_totalPrice.Name = "buyTicket_totalPrice";
            this.buyTicket_totalPrice.Size = new System.Drawing.Size(49, 17);
            this.buyTicket_totalPrice.TabIndex = 19;
            this.buyTicket_totalPrice.Text = "$0.00";
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // buyTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "buyTicketForm";
            this.Size = new System.Drawing.Size(1164, 703);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label buyTicket_regularPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label buyTicket_genre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label buyTicket_movieName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label buyTicket_movieID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buyTicket_clear;
        private System.Windows.Forms.Button buyTicket_selectMovie;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox buyTicket_availableChairs;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox buyTicket_foods;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox buyTicket_drinks;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label buyTicket_totalPrice;
        private System.Windows.Forms.Button buyTicket_buyBtn;
        private System.Windows.Forms.Label buyTicket_changeAmount;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox buyTicket_amount;
        private System.Windows.Forms.Button buyTicket_clearFields;
        private System.Windows.Forms.Button buyTicket_receiptBtn;
        private System.Windows.Forms.Button buyTicket_calculateBtn;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}
