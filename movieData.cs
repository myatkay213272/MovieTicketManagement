using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MovieTicketBookingSystem
{
    internal class movieData
    {
        string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Documents\movie.mdf;Integrated Security = True; Connect Timeout = 30";

        public int ID{ set; get;} //0

        public string MovieID { set; get; } //1

        public string MovieName { set; get; } //2

        public string Genre { set; get; } //3

        public string Price { set; get; } //4

        public string Capacity { set; get; } //5

        public string Status { set; get; } //6

        public string Image { set; get; } //7

        public string Date { set; get; } //8

        public List<movieData> movieListData()
        {
            List<movieData> listData = new List<movieData>();

            using (SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();

                string selectData = "SELECT * FROM movies WHERE  delete_date IS NULL";
                 
                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        movieData mData = new movieData();

                        mData.ID = Convert.ToInt32(reader["id"]);
                        mData.MovieID = reader["movie_id"].ToString();
                        mData.MovieName = reader["movie_name"].ToString();
                        mData.Genre = reader["genre"].ToString();
                        mData.Price = reader["price"].ToString();
                        mData.Capacity = reader["capacity"].ToString();
                        mData.Status = reader["status"].ToString();
                        mData.Image = reader["movie_image"].ToString();
                        mData.Date = reader["created_at"].ToString();


                        listData.Add(mData);

                    }

                }
            }

            return listData;

        }

        public List<movieData> movieAvailableListData()
        {
            List<movieData> listData = new List<movieData>();

            using (SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();

                string selectData = "SELECT * FROM movies WHERE status = 'Available' AND delete_date IS NULL";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        movieData mData = new movieData();

                        mData.ID = Convert.ToInt32(reader["id"]);
                        mData.MovieID = reader["movie_id"].ToString();
                        mData.MovieName = reader["movie_name"].ToString();
                        mData.Genre = reader["genre"].ToString();
                        mData.Price = reader["price"].ToString();
                        mData.Capacity = reader["capacity"].ToString();
                        mData.Status = reader["status"].ToString();
                        mData.Image = reader["movie_image"].ToString();

                        listData.Add(mData);

                    }

                }
            }

            return listData;

        }

    }
}


    

