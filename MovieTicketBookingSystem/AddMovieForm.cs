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
using System.Windows.Markup;
using System.IO;
using System.Runtime.Remoting.Contexts;

namespace MovieTicketBookingSystem
{
    public partial class AddMovieForm : UserControl
    {

        string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Documents\movie.mdf;Integrated Security = True; Connect Timeout = 30";

        public AddMovieForm()
        {
            InitializeComponent();

            displayData();
        }


        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(refreshData));
                return;
            }
            displayData();
        }




        public void displayData()
        {
            
            DataTable dt = new DataTable();
            using (SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();
                string query = "SELECT movies.* FROM movies";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connect);
                adapter.Fill(dt);
                connect.Close();
            }

            dataGridView1.DataSource = dt;

        }

        private void addMovie_importBtn_Click(object sender, EventArgs e)
        {

            try
            {

                OpenFileDialog file = new OpenFileDialog();
                string imagePath = "";

                file.Filter = "Image Files(*.jpg;*.png;)|*.jpg;*.png";

                if(file.ShowDialog() == DialogResult.OK)
                {
                    imagePath = file.FileName;
                    pictureBox1.ImageLocation = imagePath;
                }

            }
            catch (Exception ex) 
            { 
                MessageBox.Show($"Error:{ex}","Error Message",MessageBoxButtons.OK,MessageBoxIcon.Error);   
            }



        }

        private void addMovie_addBtn_Click(object sender, EventArgs e)
        {
            try
            {

                using (SqlConnection connect = new SqlConnection(conn))
                { 

                    connect.Open();

                    MessageBox.Show("Connected to database successfully!");

                    string checkID = "SELECT * FROM movies WHERE movie_id = @movieID";

                    using (SqlCommand cID = new SqlCommand(checkID,connect))
                    {
                        cID.Parameters.AddWithValue("@movieID",addMovie_movieID.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(cID);

                        DataTable table = new DataTable();

                        adapter.Fill(table);

                        if(table.Rows.Count > 0)
                        {
                            MessageBox.Show($"Movie ID : "+ addMovie_movieID.Text.Trim()+"is taken already."
                                , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        else
                        {
                            string insertData = "INSERT INTO movies (movie_id,movie_name,genre,price,capacity,movie_image,status,created_at)"+
                                "VALUES (@movieID,@movieName,@genre,@price,@capacity,@movieImage,@status,@date)";


                            string path = Path.Combine(@"C:\Users\ASUS\3D Objects\MovieTicketBooking\MovieTicketBookingSystem\MovieTicketBookingSystem\Movie_Directory\"
                                            + addMovie_movieID.Text.Trim() + ".jpg");

                            string directoryPath = Path.GetDirectoryName(path);

                            if (!Directory.Exists(directoryPath)) 
                            {
                                Directory.CreateDirectory(directoryPath);
                            }

                            //Fix

                            if (!string.IsNullOrEmpty(pictureBox1.ImageLocation) && File.Exists(pictureBox1.ImageLocation))
                            {
                                File.Copy(pictureBox1.ImageLocation, path, true);
                            }
                            else
                            {
                                MessageBox.Show("No image selected or file does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }


                            using (SqlCommand cmd =  new SqlCommand(insertData,connect))
                            {
                                cmd.Parameters.AddWithValue("@movieID", addMovie_movieID.Text.Trim());
                                cmd.Parameters.AddWithValue("@movieName", addMovie_movieName.Text.Trim());
                                cmd.Parameters.AddWithValue("@genre", addMovie_genre.SelectedItem.ToString());
                                cmd.Parameters.AddWithValue("@price", addMovie_price.Text.Trim());
                                cmd.Parameters.AddWithValue("@capacity", addMovie_capacity.Text.Trim());
                                cmd.Parameters.AddWithValue("@status", addMovie_status.SelectedItem.ToString());
                                cmd.Parameters.AddWithValue("@movieImage", path);

                                DateTime today = DateTime.Now;
                                cmd.Parameters.AddWithValue("@date", today);


                                cmd.ExecuteNonQuery();

                                int rowsAffected = cmd.ExecuteNonQuery();
                                MessageBox.Show($"Rows affected: {rowsAffected}");


                                displayData();
                                clearFields();

                                MessageBox.Show("Added successful", "Information Message",MessageBoxButtons.OK, MessageBoxIcon.Information);


                            }
                        }

                        connect.Close();


                    }

                }




            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error:{ex}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        public void clearFields()
        {
            addMovie_movieID.Text = "";
            addMovie_movieName.Text = "";
            addMovie_genre.SelectedIndex = -1;
            addMovie_price.Text = "";
            addMovie_capacity.Text = "";
            pictureBox1.Image = null;
            addMovie_status.SelectedIndex = -1;

        }

        private void addMovie_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }


        private int id = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            

            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                //Fix
                if (row.Cells[0].Value != null)
                {
                    id = Convert.ToInt32(row.Cells[0].Value);
                }

                addMovie_movieID.Text = row.Cells[1].Value.ToString();
                addMovie_movieName.Text = row.Cells[2].Value.ToString();
                addMovie_genre.Text = row.Cells[3].Value.ToString();
                addMovie_price.Text = row.Cells[4].Value.ToString();
                addMovie_capacity.Text = row.Cells[5].Value.ToString();
                addMovie_status.Text = row.Cells[6].Value.ToString();


                pictureBox1.ImageLocation = row.Cells[7].Value.ToString();


            }

        }

        private void addMovie_updateBtn_Click(object sender, EventArgs e)
        {


            try
            {

                if(MessageBox.Show("Are you sure you want to update ID :" + addMovie_movieID.Text
                    + "?" ,"COnfirmation Message",MessageBoxButtons.OK,MessageBoxIcon.Question) == DialogResult.OK)
                {



                    using (SqlConnection connect = new SqlConnection(conn))
                    {



                        connect.Open();

                        string checkID = "SELECT * FROM movies WHERE movies.movie_id = @movieID";

                        //FIX
                        //string checkID = "SELECT COUNT(movies.id) FROM movies WHERE movies.movie_id = @movieID";


                        using (SqlCommand cID = new SqlCommand(checkID, connect))
                        {
                            cID.Parameters.AddWithValue("@movieID", addMovie_movieID.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cID);

                            DataTable table = new DataTable();

                            adapter.Fill(table);

                            if (table.Rows.Count >= 2)
                            {
                                MessageBox.Show($"Movie ID : " + addMovie_movieID.Text.Trim() + "is taken already."
                                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else
                            {
                                string updateData = "UPDATE movies SET movies.movie_id = @movieID, movies.movie_name = @movieName, " +
                                    "movies.genre = @genre, movies.price = @price, movies.capacity = @capacity," +
                                    " movies.status = @status, movies.update_date = @updateDate WHERE movies.id = @id";




                                using (SqlCommand cmd = new SqlCommand(updateData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@movieID", addMovie_movieID.Text.Trim());
                                    cmd.Parameters.AddWithValue("@movieName", addMovie_movieName.Text.Trim());
                                    cmd.Parameters.AddWithValue("@genre", addMovie_genre.SelectedItem.ToString());
                                    cmd.Parameters.AddWithValue("@price", addMovie_price.Text.Trim());
                                    cmd.Parameters.AddWithValue("@capacity", addMovie_capacity.Text.Trim());
                                    cmd.Parameters.AddWithValue("@status", addMovie_status.SelectedItem.ToString());

                                    DateTime today = DateTime.Now;
                                    cmd.Parameters.AddWithValue("@updateDate", today);
                                    cmd.Parameters.AddWithValue("@id", id);



                                    cmd.ExecuteNonQuery();

                                    displayData();
                                    clearFields();

                                    MessageBox.Show("Updated successful", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                }
                            }



                        }

                    }





                }





            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error:{ex}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void addMovie_deleteBtn_Click(object sender, EventArgs e)
        {
            


            try
            {

                if (MessageBox.Show("Are you sure you want to Delete ID :" + addMovie_movieID.Text
                    + "?", "Confirmation Message", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK)
                {

                    using (SqlConnection connect = new SqlConnection(conn))
                    
                    {

                        connect.Open();


                        string updateData = "UPDATE movies SET delete_date = @deleteDate , status = @status WHERE id = @id ";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                             // Add this before cmd.ExecuteNonQuery();


                            DateTime today = DateTime.Now;
                            cmd.Parameters.AddWithValue("@deleteDate", today);
                            cmd.Parameters.AddWithValue("@status", "Deleted");
                            cmd.Parameters.AddWithValue("@id", id);



                            cmd.ExecuteNonQuery();

                            displayData();
                            clearFields();

                            MessageBox.Show("Deleted successful", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }



                }


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error:{ex}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }




    }
    

