using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieTicketBookingSystem
{
    public partial class Adminform : Form
    {
        public Adminform()
        {
            InitializeComponent();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {

            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to logout?" ,"Confirmation Message",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question))

            {
                Form1 loginForm = new Form1();

                loginForm.Show();

                this.Hide();
            }

        }

        private void clear_Click(object sender, EventArgs e)
        {

            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to exit?", "Confirmation Message",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question))

            {
               Application.Exit();
            }
        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            //dashboardForm1.Show();
            //addStaffForm1.Hide();
            //addMovieForm1.Hide();

            //dashboardForm dForm = dashboardForm1 as dashboardForm;

            //if (dForm != null)
            //{
            //    dForm.refreshData();
            //}

        }

        private void addStaff_btn_Click(object sender, EventArgs e)
        {
   //           dashboardForm1.Hide();
   //          addStaffForm1.Show();
   //          addMovieForm1.Hide();
   //AddStaffForm asForm = addStaffForm1 as AddStaffForm;

   //          if (asForm != null)
   //           {
   //               asForm.refreshData();
   //          }
        }

        private void addMovie_btn_Click(object sender, EventArgs e)
        {
            //dashboardForm1.Hide();
            //addStaffForm1.Hide();
            //addMovieForm1.Show();

            //AddMovieForm amForm = addMovieForm1 as AddMovieForm;

            //if (amForm != null)
            //{
            //    amForm.refreshData();
            //}


        }

        private void addMovieForm1_Load(object sender, EventArgs e)
        {

        }

        private void addMovieForm1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
