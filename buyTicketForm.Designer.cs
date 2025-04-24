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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.buyTicket_availableSeat = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.buyTicket_seatType = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.buyTicket_availableChairs = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.buyTicket_foods = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.buyTicket_drinks = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buyTicket_totalPrice = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.buyTicket_amount = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.buyTicket_change = new System.Windows.Forms.Label();
            this.buyTicket_buyBtn = new System.Windows.Forms.Button();
            this.buyTicket_receiptBtn = new System.Windows.Forms.Button();
            this.buyTicket_clearFields = new System.Windows.Forms.Button();
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
            this.panel1.Size = new System.Drawing.Size(512, 307);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(468, 218);
            this.dataGridView1.TabIndex = 3;
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
            this.panel2.Controls.Add(this.buyTicket_availableSeat);
            this.panel2.Controls.Add(this.label12);
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
            this.panel2.Size = new System.Drawing.Size(512, 318);
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
            this.buyTicket_clear.Location = new System.Drawing.Point(364, 251);
            this.buyTicket_clear.Name = "buyTicket_clear";
            this.buyTicket_clear.Size = new System.Drawing.Size(99, 42);
            this.buyTicket_clear.TabIndex = 29;
            this.buyTicket_clear.Text = "CLEAR";
            this.buyTicket_clear.UseVisualStyleBackColor = false;
            // 
            // buyTicket_selectMovie
            // 
            this.buyTicket_selectMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.buyTicket_selectMovie.FlatAppearance.BorderSize = 0;
            this.buyTicket_selectMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buyTicket_selectMovie.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyTicket_selectMovie.ForeColor = System.Drawing.Color.White;
            this.buyTicket_selectMovie.Location = new System.Drawing.Point(225, 251);
            this.buyTicket_selectMovie.Name = "buyTicket_selectMovie";
            this.buyTicket_selectMovie.Size = new System.Drawing.Size(122, 42);
            this.buyTicket_selectMovie.TabIndex = 28;
            this.buyTicket_selectMovie.Text = "SELECT MOVIE";
            this.buyTicket_selectMovie.UseVisualStyleBackColor = false;
            this.buyTicket_selectMovie.Click += new System.EventHandler(this.addMovie_addBtn_Click);
            // 
            // buyTicket_regularPrice
            // 
            this.buyTicket_regularPrice.AutoSize = true;
            this.buyTicket_regularPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyTicket_regularPrice.Location = new System.Drawing.Point(329, 161);
            this.buyTicket_regularPrice.Name = "buyTicket_regularPrice";
            this.buyTicket_regularPrice.Size = new System.Drawing.Size(38, 18);
            this.buyTicket_regularPrice.TabIndex = 15;
            this.buyTicket_regularPrice.Text = "------";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(222, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Regular Price:";
            // 
            // buyTicket_genre
            // 
            this.buyTicket_genre.AutoSize = true;
            this.buyTicket_genre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyTicket_genre.Location = new System.Drawing.Point(324, 125);
            this.buyTicket_genre.Name = "buyTicket_genre";
            this.buyTicket_genre.Size = new System.Drawing.Size(38, 18);
            this.buyTicket_genre.TabIndex = 13;
            this.buyTicket_genre.Text = "------";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(261, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 18);
            this.label9.TabIndex = 12;
            this.label9.Text = "Genre :";
            // 
            // buyTicket_movieName
            // 
            this.buyTicket_movieName.AutoSize = true;
            this.buyTicket_movieName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyTicket_movieName.Location = new System.Drawing.Point(324, 88);
            this.buyTicket_movieName.Name = "buyTicket_movieName";
            this.buyTicket_movieName.Size = new System.Drawing.Size(38, 18);
            this.buyTicket_movieName.TabIndex = 11;
            this.buyTicket_movieName.Text = "------";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(222, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Movie Name:";
            // 
            // buyTicket_movieID
            // 
            this.buyTicket_movieID.AutoSize = true;
            this.buyTicket_movieID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyTicket_movieID.Location = new System.Drawing.Point(324, 44);
            this.buyTicket_movieID.Name = "buyTicket_movieID";
            this.buyTicket_movieID.Size = new System.Drawing.Size(38, 18);
            this.buyTicket_movieID.TabIndex = 9;
            this.buyTicket_movieID.Text = "------";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(244, 44);
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
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buyTicket_availableSeat
            // 
            this.buyTicket_availableSeat.AutoSize = true;
            this.buyTicket_availableSeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyTicket_availableSeat.Location = new System.Drawing.Point(324, 207);
            this.buyTicket_availableSeat.Name = "buyTicket_availableSeat";
            this.buyTicket_availableSeat.Size = new System.Drawing.Size(38, 18);
            this.buyTicket_availableSeat.TabIndex = 31;
            this.buyTicket_availableSeat.Text = "------";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(217, 207);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 18);
            this.label12.TabIndex = 30;
            this.label12.Text = "Available Seat:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(41, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 18);
            this.label10.TabIndex = 9;
            this.label10.Text = "Seat Tpye :";
            // 
            // buyTicket_seatType
            // 
            this.buyTicket_seatType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyTicket_seatType.FormattingEnabled = true;
            this.buyTicket_seatType.Items.AddRange(new object[] {
            "1st Class Seat",
            "2nd Class Seat",
            "Normal Seat"});
            this.buyTicket_seatType.Location = new System.Drawing.Point(134, 16);
            this.buyTicket_seatType.Name = "buyTicket_seatType";
            this.buyTicket_seatType.Size = new System.Drawing.Size(136, 28);
            this.buyTicket_seatType.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(11, 82);
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
            this.buyTicket_availableChairs.Location = new System.Drawing.Point(134, 78);
            this.buyTicket_availableChairs.Name = "buyTicket_availableChairs";
            this.buyTicket_availableChairs.Size = new System.Drawing.Size(136, 28);
            this.buyTicket_availableChairs.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(11, 135);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(123, 17);
            this.label14.TabIndex = 13;
            this.label14.Text = "Available Foods";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(40, 183);
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
            this.buyTicket_foods.Location = new System.Drawing.Point(125, 179);
            this.buyTicket_foods.Name = "buyTicket_foods";
            this.buyTicket_foods.Size = new System.Drawing.Size(136, 28);
            this.buyTicket_foods.TabIndex = 15;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(43, 237);
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
            this.buyTicket_drinks.Location = new System.Drawing.Point(124, 233);
            this.buyTicket_drinks.Name = "buyTicket_drinks";
            this.buyTicket_drinks.Size = new System.Drawing.Size(136, 28);
            this.buyTicket_drinks.TabIndex = 17;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(11, 313);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(92, 17);
            this.label17.TabIndex = 18;
            this.label17.Text = "Total Price:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.buyTicket_clearFields);
            this.panel3.Controls.Add(this.buyTicket_receiptBtn);
            this.panel3.Controls.Add(this.buyTicket_buyBtn);
            this.panel3.Controls.Add(this.buyTicket_change);
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
            this.panel3.Controls.Add(this.buyTicket_seatType);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(555, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(289, 647);
            this.panel3.TabIndex = 2;
            // 
            // buyTicket_totalPrice
            // 
            this.buyTicket_totalPrice.AutoSize = true;
            this.buyTicket_totalPrice.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyTicket_totalPrice.Location = new System.Drawing.Point(109, 313);
            this.buyTicket_totalPrice.Name = "buyTicket_totalPrice";
            this.buyTicket_totalPrice.Size = new System.Drawing.Size(49, 17);
            this.buyTicket_totalPrice.TabIndex = 19;
            this.buyTicket_totalPrice.Text = "$0.00";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(44, 353);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(71, 18);
            this.label19.TabIndex = 20;
            this.label19.Text = "Amount : ";
            // 
            // buyTicket_amount
            // 
            this.buyTicket_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyTicket_amount.Location = new System.Drawing.Point(125, 353);
            this.buyTicket_amount.Name = "buyTicket_amount";
            this.buyTicket_amount.Size = new System.Drawing.Size(136, 27);
            this.buyTicket_amount.TabIndex = 21;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(44, 406);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(71, 18);
            this.label20.TabIndex = 22;
            this.label20.Text = "Change : ";
            // 
            // buyTicket_change
            // 
            this.buyTicket_change.AutoSize = true;
            this.buyTicket_change.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyTicket_change.Location = new System.Drawing.Point(121, 406);
            this.buyTicket_change.Name = "buyTicket_change";
            this.buyTicket_change.Size = new System.Drawing.Size(44, 18);
            this.buyTicket_change.TabIndex = 23;
            this.buyTicket_change.Text = "$0.00";
            // 
            // buyTicket_buyBtn
            // 
            this.buyTicket_buyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.buyTicket_buyBtn.FlatAppearance.BorderSize = 0;
            this.buyTicket_buyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buyTicket_buyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyTicket_buyBtn.ForeColor = System.Drawing.Color.White;
            this.buyTicket_buyBtn.Location = new System.Drawing.Point(29, 454);
            this.buyTicket_buyBtn.Name = "buyTicket_buyBtn";
            this.buyTicket_buyBtn.Size = new System.Drawing.Size(240, 42);
            this.buyTicket_buyBtn.TabIndex = 30;
            this.buyTicket_buyBtn.Text = "BUY";
            this.buyTicket_buyBtn.UseVisualStyleBackColor = false;
            // 
            // buyTicket_receiptBtn
            // 
            this.buyTicket_receiptBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.buyTicket_receiptBtn.FlatAppearance.BorderSize = 0;
            this.buyTicket_receiptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buyTicket_receiptBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyTicket_receiptBtn.ForeColor = System.Drawing.Color.White;
            this.buyTicket_receiptBtn.Location = new System.Drawing.Point(30, 512);
            this.buyTicket_receiptBtn.Name = "buyTicket_receiptBtn";
            this.buyTicket_receiptBtn.Size = new System.Drawing.Size(240, 42);
            this.buyTicket_receiptBtn.TabIndex = 31;
            this.buyTicket_receiptBtn.Text = "RECEIPT";
            this.buyTicket_receiptBtn.UseVisualStyleBackColor = false;
            // 
            // buyTicket_clearFields
            // 
            this.buyTicket_clearFields.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.buyTicket_clearFields.FlatAppearance.BorderSize = 0;
            this.buyTicket_clearFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buyTicket_clearFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyTicket_clearFields.ForeColor = System.Drawing.Color.White;
            this.buyTicket_clearFields.Location = new System.Drawing.Point(35, 579);
            this.buyTicket_clearFields.Name = "buyTicket_clearFields";
            this.buyTicket_clearFields.Size = new System.Drawing.Size(234, 42);
            this.buyTicket_clearFields.TabIndex = 32;
            this.buyTicket_clearFields.Text = "CLEAR";
            this.buyTicket_clearFields.UseVisualStyleBackColor = false;
            // 
            // buyTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "buyTicketForm";
            this.Size = new System.Drawing.Size(864, 703);
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
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label buyTicket_availableSeat;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox buyTicket_seatType;
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
        private System.Windows.Forms.Label buyTicket_change;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox buyTicket_amount;
        private System.Windows.Forms.Button buyTicket_clearFields;
        private System.Windows.Forms.Button buyTicket_receiptBtn;
    }
}
