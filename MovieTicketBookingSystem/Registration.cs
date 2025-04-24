using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MovieTicketBookingSystem
{
    public partial class Registration : Form
    {

        string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|movie.mdf;Integrated Security = True; Connect Timeout = 30";
        public Registration()
        {
            InitializeComponent();
            reg_password.PasswordChar = '*';
            reg_cPassword.PasswordChar = '*';
        }

        private void reg_showPass_CheckedChanged(object sender, EventArgs e)
        {


            reg_password.PasswordChar = reg_showPass.Checked ? '\0' : '*';
            reg_cPassword.PasswordChar = reg_showPass.Checked ? '\0' : '*';
        }

        private void clear_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void reg_btn_Click(object sender, EventArgs e)
        {
            if(reg_username.Text == "" || reg_password.Text == "" ||
                reg_cPassword.Text == "")
            {
                MessageBox.Show("Please fill all blank fields" , "Error Message",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if(reg_password.Text != reg_cPassword.Text)
            {
                MessageBox.Show("Password does not match", "Error Message",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if(reg_password.Text.Length < 8)
            {
                MessageBox.Show("Invalid Password", "Error Message",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using(SqlConnection con =  new SqlConnection(conn))
                {
                    con.Open();
                    string checkUsername = "SELECT * FROM users WHERE username = @usern ";

                    using(SqlCommand checkUsern = new SqlCommand(checkUsername,con))
                    {
                        checkUsern.Parameters.AddWithValue("@usern",reg_username.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(checkUsern);
                        DataTable table = new DataTable();

                        adapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            MessageBox.Show(reg_username.Text.Substring(0, 1).ToUpper() +
                           reg_username.Text.Substring(1) + " is taken already",
                           "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        else
                        {
                            string insertData = "INSERT INTO users(username,password,role,status,date_reg) VALUES(@usern,@pass,@role,@status,@date)";


                            DateTime today = DateTime.Now;

                            using (SqlCommand cmd = new SqlCommand(insertData, con))
                            {
                                cmd.Parameters.AddWithValue("@usern", reg_username.Text.Trim());
                                cmd.Parameters.AddWithValue("@pass", reg_password.Text.Trim());

                                //string hashedPassword = Bcrypt.Net.BCrypt.HashPassword(reg_password.Text.Trim());
                                //cmd.Parameters.AddWithValue("@pass", hashedPassword);


                                cmd.Parameters.AddWithValue("@role", "staff");
                                cmd.Parameters.AddWithValue("@status", "Active");
                                cmd.Parameters.AddWithValue("@date", today);

                                
                                Console.WriteLine("SQL Query: " + insertData);
                                foreach (SqlParameter param in cmd.Parameters)
                                {
                                    Console.WriteLine($"{param.ParameterName}: {param.Value}");
                                }

                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Registered successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                        }
                    }

                }
            }
                
        }

        private void reg_signInbtn_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();

            this.Hide();

            //Registration registration = new Registration();
            //registration.Show();

            //this.Hide();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            //this.Show();
        }
    }
}
