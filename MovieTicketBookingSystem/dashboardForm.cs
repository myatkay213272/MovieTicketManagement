using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieTicketBookingSystem
{
    public partial class dashboardForm : UserControl
    {

        string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Documents\movie.mdf;Integrated Security = True; Connect Timeout = 30";

        public dashboardForm()
        {
            InitializeComponent();

            displayAvailableMovies();
            displaytotalStaff();
            displaytotalBuys();
            displaytotalIncome();
            displayAMTable();
        }

        
        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(refreshData));
                return;
            }

            displayAvailableMovies();
            displaytotalStaff();
            displaytotalBuys();
            displaytotalIncome();
            displayAMTable();
        }



        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }



        public void displayAMTable()
        {

            movieData mData = new movieData();

            List<movieData> listData = mData.movieAvailableListData();
            dataGridView1.DataSource = listData;


        }





        public void displayAvailableMovies()
        {

            using (SqlConnection connect = new SqlConnection(conn))
            {

                connect.Open();

                string selectData = "SELECT COUNT(id) as avMovie FROM movies WHERE status = 'Available'";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        if (reader["avMovie"] != DBNull.Value)
                        {
                            decimal totalAVMovie = Convert.ToDecimal(reader["avMovie"]);

                            dashboard_AM.Text = totalAVMovie.ToString();    

                        }
                    }
                }


            }



        }



        public void displaytotalStaff()
        {

            using (SqlConnection connect = new SqlConnection(conn))
            {

                connect.Open();

                string selectData = "SELECT COUNT(id) as totalStaff FROM users WHERE role= 'Staff' AND status = 'Active'";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        if (reader["totalStaff"] != DBNull.Value)
                        {
                            decimal totalStaff = Convert.ToDecimal(reader["totalStaff"]);

                            dashboard_TS.Text = totalStaff.ToString();

                        }
                    }
                }


            }



        }


        public void displaytotalBuys()
        {

            using (SqlConnection connect = new SqlConnection(conn))
            {

                connect.Open();

                string selectData = "SELECT COUNT(id) as totalBuys FROM buy_ticket WHERE status = 'PAID'";
                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        if (reader["totalBuys"] != DBNull.Value)
                        {
                            decimal totalBuys = Convert.ToDecimal(reader["totalBuys"]);

                            dashboard_TB.Text = totalBuys.ToString();

                        }
                    }
                }


            }
        }



        public void displaytotalIncome()
        {

            using (SqlConnection connect = new SqlConnection(conn))
            {

                connect.Open();

                string selectData = "SELECT SUM(id) as totalIncome FROM buy_ticket WHERE status = 'PAID'";
                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        if (reader["totalIncome"] != DBNull.Value)
                        {
                            decimal totalIncome = Convert.ToDecimal(reader["totalIncome"]);

                            dashboard_TI.Text = "$" + totalIncome.ToString("0.00");

                        }
                    }
                }


            }
        }







    }
}
