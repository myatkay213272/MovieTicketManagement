using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;
using System.Drawing.Printing;

namespace MovieTicketBookingSystem
{
    public partial class buyTicketForm : UserControl
    {

        string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Documents\movie.mdf;Integrated Security = True; Connect Timeout = 30";

        public buyTicketForm()
        {
            InitializeComponent();

            displayAvailableMovies();
            displayAvailableSeats();
        }


        public void refreshData()
        {

            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(refreshData));
                return;
            }

            displayAvailableMovies();

        }



        string movie_id;

        private void addMovie_addBtn_Click(object sender, EventArgs e)
        {
            //movie_id = buyTicket_movieID.Text.Trim();

            if (!string.IsNullOrEmpty(buyTicket_movieID.Text.Trim()))
            {
                movie_id = buyTicket_movieID.Text.Trim();
                MessageBox.Show("Selected Movie ID: " + movie_id);
            }
            else
            {
                MessageBox.Show("Please select a movie.");
            }
        }



        public void displayAvailableSeats()
        {

            if (string.IsNullOrEmpty(movie_id))
            {
                //MessageBox.Show("Please select a movie first.");
                return;
            }


            string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Documents\movie.mdf;Integrated Security = True; Connect Timeout = 30";

            using (SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();
                string selectAvailableSeat = "SELECT capacity FROM movies WHERE delete_date IS NULL AND status != 'Deleted' AND movie_id = @movie_id\r\n";

                int SetAvailable = 0;


                using (SqlCommand cmdSelectSeat = new SqlCommand(selectAvailableSeat, connect))
                {

                    cmdSelectSeat.Parameters.AddWithValue("@movie_id", movie_id);

                    SqlDataReader reader = cmdSelectSeat.ExecuteReader();

                    if (reader.Read())
                    {
                        SetAvailable = Convert.ToInt32(reader["capacity"]);
                    }

                    reader.Close();

                }

                if (SetAvailable > 0)
                {
                    string selectBookSeats = "SELECT seat_number FROM buy_ticket WHERE movie_id = @movie_id";

                    List<int> bookSeat = new List<int>();

                    using (SqlCommand cmd = new SqlCommand(selectBookSeats, connect))
                    {
                        cmd.Parameters.AddWithValue("@movie_id", movie_id);

                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            bookSeat.Add(Convert.ToInt32(reader["seat_number"]));
                        }
                        reader.Close();

                        List<int> allSeats = Enumerable.Range(1, SetAvailable).ToList();

                        List<int> availableSeats = allSeats.Except(bookSeat).ToList();


                        DataTable table = new DataTable();

                        table.Columns.Add("seat_number", typeof(int));

                        foreach (int seat in availableSeats)
                        {
                            table.Rows.Add(seat);
                        }

                        //if (table.Rows.Count > 0)//
                        if (availableSeats.Any())
                        {
                            buyTicket_availableChairs.DataSource = table;
                            buyTicket_availableChairs.DisplayMember = "seat_number";
                            buyTicket_availableChairs.ValueMember = "seat_number";
                        }
                        else
                        {
                            buyTicket_availableChairs.DataSource = null;
                            MessageBox.Show("No available seats.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }



                    }

                

                else
                {
                    buyTicket_availableChairs.DataSource = null;

                }



            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        public void displayAvailableMovies()
        {
            movieData mData = new movieData();
            List<movieData> listData = mData.movieAvailableListData();
            //Console.WriteLine("Movie Count: " + listData.Count);

            if (listData.Count > 0)
            {
                dataGridView1.DataSource = listData;
            }
            else
            {
                MessageBox.Show("No available movies found.");
                dataGridView1.DataSource = null;
            }

        }

        private int id = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //if (e.RowIndex != -1)
            //{

            //    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            //    id = (int)row.Cells[0].Value;
            //    buyTicket_movieID.Text = row.Cells[1].Value.ToString();
            //    buyTicket_movieName.Text = row.Cells[2].Value.ToString();
            //    buyTicket_genre.Text = row.Cells[3].Value.ToString();
            //    buyTicket_regularPrice.Text = row.Cells[4].Value.ToString();


            //    pictureBox1.ImageLocation = row.Cells[7].Value.ToString() ;

            //}



            //Fix

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                if (row.Cells[1].Value != null)
                {
                    id = Convert.ToInt32(row.Cells[0].Value);
                    buyTicket_movieID.Text = row.Cells[1].Value.ToString();

                    movie_id = buyTicket_movieID.Text.Trim();
                    displayAvailableSeats();

                    buyTicket_movieName.Text = row.Cells[2].Value.ToString();
                    buyTicket_genre.Text = row.Cells[3].Value.ToString();
                    buyTicket_regularPrice.Text = row.Cells[4].Value.ToString();

                    if (row.Cells.Count > 7 && row.Cells[7].Value != null
                        && !string.IsNullOrEmpty(row.Cells[7].Value.ToString()))
                    {
                        pictureBox1.ImageLocation = row.Cells[7].Value.ToString();
                    }
                    else
                    {
                        pictureBox1.Image = null;
                    }
                }
                else
                {
                    MessageBox.Show("Invalid movie selection.");
                }
            }


        }

        double getTotal = 0;
        private void buyTicket_calculateBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();

                string selectPrice = "SELECT price FROM movies WHERE movie_id = @movie_id";


                double getPrice = 0;
                using (SqlCommand cmd = new SqlCommand(selectPrice, connect))
                {

                    cmd.Parameters.AddWithValue("@movie_id", movie_id);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        getPrice = reader["price"] == DBNull.Value ? 0 : Convert.ToDouble(reader["price"]);

                    }

                    reader.Close();

                }

                double getFoodPrice = (buyTicket_foods.SelectedIndex == -1) ? 0 : 100;
                double getDrinkPrice = (buyTicket_drinks.SelectedIndex == -1) ? 0 : 50;

                getTotal = (getPrice + getFoodPrice + getDrinkPrice);

                buyTicket_totalPrice.Text = "$" + getTotal.ToString("0.00");


            }
        }



        public void clearSelected()
        {
            id = 0;
            buyTicket_movieID.Text = "";
            buyTicket_movieName.Text = "";
            buyTicket_genre.Text = "";
            buyTicket_regularPrice.Text = "";

            pictureBox1.Image = null;
        }


        private void buyTicket_clear_Click(object sender, EventArgs e)
        {
            clearSelected();
        }

        private void buyTicket_amount_TextChanged(object sender, EventArgs e)
        {

        }


        private void buyTicket_amount_Enter(object sender, EventArgs e)
        {



        }


        double getChange = 0;
        double getAmount = 0;


        private void buyTicket_amount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {


                if (id == 0 && getTotal == 0)
                {
                    MessageBox.Show("Please select movie and foods first", "Error Message",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    try
                    {
                        if (Convert.ToDouble(buyTicket_amount.Text) >= getTotal)
                        {
                            
                            getChange = Convert.ToDouble(buyTicket_amount.Text) - getTotal;
                            getAmount = Convert.ToDouble(buyTicket_amount.Text);

                        }
                        else
                        {

                            MessageBox.Show("Error : should amount > total", "Error Message"
                                , MessageBoxButtons.OK, MessageBoxIcon.Error);

                            getChange = 0;

                        }

                        buyTicket_changeAmount.Text = "$" + getChange.ToString("0.00");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Please enter numbers only", "Error Message"
                            , MessageBoxButtons.OK, MessageBoxIcon.Error);

                        buyTicket_amount.Text = "";
                        getAmount = 0;


                    }
                }




            }

        }

        private void buyTicket_buyBtn_Click(object sender, EventArgs e)
        {
            if (movie_id == null || getTotal == 0)
            {
                MessageBox.Show("Please select movie first ", "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(conn))
                {
                    connect.Open();

                    string insertData = "INSERT INTO buy_ticket(movie_id, seat_number, price, amount, change_amount, status, created_at) " +
                                        "VALUES(@movieID, @seatNum, @price, @amount, @changeAmount, @status, @date)";




                    using (SqlCommand cmd = new SqlCommand(insertData, connect))
                    {
                        cmd.Parameters.AddWithValue("@movieID", movie_id);
                        cmd.Parameters.AddWithValue("@seatNum", Convert.ToInt32(buyTicket_availableChairs.Text));
                        cmd.Parameters.AddWithValue("@price", getTotal);
                        cmd.Parameters.AddWithValue("@amount", getAmount);
                        cmd.Parameters.AddWithValue("@changeAmount", getChange);
                        cmd.Parameters.AddWithValue("@status", "PAID");


                        DateTime today = DateTime.Now;
                        cmd.Parameters.AddWithValue("@date", today);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show($"Successful occupied {buyTicket_availableChairs.Text} ",
                            "Information Message",MessageBoxButtons.OK, MessageBoxIcon.Information);


                        clearSelected();
                        //clearFileds();

                    }
                }
            }
        }


        public void clearFileds()
        {
            buyTicket_availableChairs.SelectedIndex = -1;
            buyTicket_foods.SelectedIndex = -1;
            buyTicket_drinks.SelectedIndex = -1;
            buyTicket_totalPrice.Text = "$0.00";
            buyTicket_amount.Text = "";
            buyTicket_changeAmount.Text = "$0.00";
        }

        private void buyTicket_clearFields_Click(object sender, EventArgs e)
        {
            clearFileds();

        }




        private int rowIndex = 0;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            e.PageSettings.PaperSize = new PaperSize("Custom", 850, 1100);
            e.PageSettings.Margins = new Margins(10, 10, 10, 10);


            float pageWidth = e.MarginBounds.Width; 
            float pageHeight = e.MarginBounds.Height;


            float y = e.MarginBounds.Top;
            int rowSpacing = 5;


            Font font = new Font("Arial", 16);
            Font bold = new Font("Arial", 16, FontStyle.Bold);
            Font headerFont = new Font("Arial", 22, FontStyle.Bold);
            Font labelFont = new Font("Arial", 18, FontStyle.Bold);


            string headerText = "HappyWeekend Cinema";
            float headerX = e.MarginBounds.Left + (e.MarginBounds.Width / 2) -
                      (e.Graphics.MeasureString(headerText, headerFont).Width / 2);
            e.Graphics.DrawString(headerText, headerFont, Brushes.Black, headerX, y);
            y += headerFont.GetHeight(e.Graphics) + 15;



            string[] headers = { "ID", "MovieID", "MovieName", "Genre", "RegPrice", "Capacity", "Status" };
            int[] colWidths = { 50, 120, 200, 120, 100, 100, 100 };


            float x = e.MarginBounds.Left; 
            for (int i = 0; i < headers.Length; i++)
            {
                e.Graphics.DrawString(headers[i], bold, Brushes.Black, x, y);
                x += colWidths[i] + 10;
            }
            y += bold.GetHeight(e.Graphics) + 10;



            while (rowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[rowIndex];
                x = e.MarginBounds.Left;


                for (int q = 0; q < headers.Length; q++)
                {
                    object cellValue = row.Cells[q].Value;
                    string cell = (cellValue != null) ? cellValue.ToString() : string.Empty;

                    while (e.Graphics.MeasureString(cell, font).Width > colWidths[q])
                    {
                        cell = cell.Substring(0, cell.Length - 1);
                    }

                    e.Graphics.DrawString(cell, font, Brushes.Black, x, y);
                    x += colWidths[q] + 10;
                }

                y += font.GetHeight(e.Graphics) + rowSpacing;
                rowIndex++;

                if (y + font.GetHeight(e.Graphics) > e.MarginBounds.Bottom - 50)
                {
                    e.HasMorePages = true;
                    return;
                }



            }


            float totalY = e.MarginBounds.Bottom - 100;
            float labelX = e.MarginBounds.Left + 500;

            e.Graphics.DrawString("Total Price: $" + getTotal.ToString("0.00") +
                                  "\nAmount: $" + buyTicket_amount.Text +
                                  "\n------------------------" +
                                  "\nChange: $" + buyTicket_changeAmount.Text,
                                  labelFont, Brushes.Black, labelX, totalY);
        }
        



        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            rowIndex = 5;
        }

        private void buyTicket_receiptBtn_Click(object sender, EventArgs e)
        {

            printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(printDocument1_PrintPage);
            printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(printDocument1_BeginPrint);

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();

        }
    }
}
