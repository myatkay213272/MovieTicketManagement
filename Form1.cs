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
using System.Data.SqlClient;


namespace MovieTicketBookingSystem
{
    public partial class Form1 : Form
    {

        string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Documents\movie.mdf;Integrated Security = True; Connect Timeout = 30";

        public Form1()
        {
            InitializeComponent();
            login_btn.Enabled = true;
            login_password.PasswordChar = '*';
        }

        private void login_btn_Click(object sender, EventArgs e)
        {

            if (login_username.Text == "" || login_password.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection con = new SqlConnection(conn))
                {
                    con.Open();

                    string selectData = "SELECT * FROM users WHERE username = @usern AND password=@pass";

                    using (SqlCommand cmd = new SqlCommand(selectData, con))
                    {
                        cmd.Parameters.AddWithValue("@usern", login_username.Text.Trim());
                        cmd.Parameters.AddWithValue("@pass", login_password.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();


                        adapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {

                            string role = table.Rows[0]["role"].ToString();


                            MessageBox.Show("Login successful", "Information Message",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);


                            if(role == "Admin")
                            {
                                AdminForm aForm = new AdminForm();
                                aForm.Show();
                            }
                            else if(role == "Staff")
                            {
                                staffForm sForm = new staffForm();
                                sForm.Show();
                            }



                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Incorrect username/password", "Error Message",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

            }
        }

        private void login_showPass_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_showPass.Checked ? '\0' : '*';

        }

        private void clear_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void login_signupBtn_Click(object sender, EventArgs e)
        {
            

        }
    }
}
