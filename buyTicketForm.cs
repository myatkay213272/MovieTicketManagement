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

namespace MovieTicketBookingSystem
{
    public partial class buyTicketForm : UserControl
    {

        string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Documents\movie.mdf;Integrated Security = True; Connect Timeout = 30";

        public buyTicketForm()
        {
            InitializeComponent();
        }

        private void addMovie_addBtn_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        public void displayAvailableMovies()
        {
            movieData mData = new movieData();
            List<movieData> listData = mData.movieAvailableListData();

            dataGridView1.DataSource = listData;

        }
    }
}
