using System;
using System.Windows.Forms;

namespace moviesdatabase
{
    public partial class Form1 : Form
    {
        private readonly Database myDatabase = new Database();

        public Form1()
        {
            InitializeComponent();

            dgvMovies.DataSource = myDatabase.FilldgvMovies();
            dgvCustomers.DataSource = myDatabase.FilldgvCustomers();
            dgvRentedMovies.DataSource = myDatabase.FilldgvRentedMovies();


        }

        private void textBox1_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void dgvMovies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int MovieID = 0;
            //these are the cell clicks for the values in the row that you click on 
            try
            {
                MovieID = (int)dgvMovies.Rows[e.RowIndex].Cells[0].Value;
                txtRating.Text = dgvMovies.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtTitle.Text = dgvMovies.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtYear.Text = dgvMovies.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtRentalCost.Text = dgvMovies.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtCopies.Text = dgvMovies.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtPlot.Text = dgvMovies.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtGenre.Text = dgvMovies.Rows[e.RowIndex].Cells[7].Value.ToString();






                //if you are clicking on a row and not outside it
                if (e.RowIndex >= 0)
                {
                    //Fill the next Movie DGV with the MovieID
                    txtMovieID.Text = MovieID.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtRentalCost_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int CustID = 0;
            //these are the cell clicks for the values in the row that you click on 
            try
            {
                CustID = (int)dgvCustomers.Rows[e.RowIndex].Cells[0].Value;
                txtFirstName.Text = dgvCustomers.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtLastName.Text = dgvCustomers.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtAddress.Text = dgvCustomers.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtPhone.Text = dgvCustomers.Rows[e.RowIndex].Cells[4].Value.ToString();
                //if you are clicking on a row and not outside it
                if (e.RowIndex >= 0)
                {
                    //Fill the next Customer DGV with the CustID
                    txtCustID.Text = CustID.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvRentedMovies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int RMID = 0;
            //these are the cell clicks for the values in the row that you click on 
            try
            {
                RMID = (int)dgvRentedMovies.Rows[e.RowIndex].Cells[0].Value;
                txtFirstName.Text = dgvRentedMovies.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtLastName.Text = dgvRentedMovies.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtAddress.Text = dgvRentedMovies.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtTitle.Text = dgvRentedMovies.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtRentalCost.Text = dgvRentedMovies.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtDateRented.Text = dgvRentedMovies.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtDateReturned.Text = dgvRentedMovies.Rows[e.RowIndex].Cells[7].Value.ToString();



                //if you are clicking on a row and not outside it
                if (e.RowIndex >= 0)
                {
                    //Fill the next Customer DGV with the CustID
                    txtRMID.Text = RMID.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddCustomer_Click_1(object sender, EventArgs e)
        {
            string result = null;
            //hold the success or failure result
            //only run if there is something in the textboxes
            if ((txtFirstName.Text != string.Empty) && (txtLastName.Text != string.Empty))
            {
                try
                {


                    result = myDatabase.InsertOrUpdateCustomersstring(txtFirstName.Text, txtLastName.Text, txtCustID.Text, txtAddress.Text, txtPhone.Text, txtDate.Text, "Add");
                    MessageBox.Show(txtFirstName.Text + " " + txtLastName.Text + " Add " + result);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                //update the datagrid view to see new entries
                dgvCustomers.DataSource = myDatabase.FilldgvCustomers();
                txtFirstName.Text = "";
                txtLastName.Text = "";
                txtAddress.Text = "";
                txtPhone.Text = "";
                txtDate.Text = "";

            }
            else
            {
                MessageBox.Show("Fill First Name and Surname fields");
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            string result = null;
            if ((txtFirstName.Text != string.Empty) && (txtLastName.Text != string.Empty))
            {
                try
                {
                    result = myDatabase.DeleteCustomersMoviesRentals(txtCustID.Text, "Customer");
                    MessageBox.Show(txtCustID.Text + " Delete " + result);
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                dgvCustomers.DataSource = myDatabase.FilldgvCustomers();
                txtFirstName.Text = "";
                txtLastName.Text = "";
                txtAddress.Text = "";
                txtPhone.Text = "";
                txtDate.Text = "";
            }
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            string result = null;
            if ((txtFirstName.Text != string.Empty) && (txtLastName.Text != string.Empty))
            {
                try
                {


                    result = myDatabase.InsertOrUpdateCustomersstring(txtFirstName.Text, txtLastName.Text, txtCustID.Text, txtAddress.Text, txtPhone.Text, txtDate.Text, "Update");
                    MessageBox.Show(txtFirstName.Text + " " + txtLastName.Text + " Update " + result);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                //update the datagrid view to see new entries
                dgvCustomers.DataSource = myDatabase.FilldgvCustomers();
                txtFirstName.Text = "";
                txtLastName.Text = "";
                txtAddress.Text = "";
                txtPhone.Text = "";
                txtDate.Text = "";

            }
            else
            {
                MessageBox.Show("Fill First Name and Surname fields");
            }
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            string result = null;
            //hold the success or failure result
            //only run if there is something in the textboxes
            if ((txtTitle.Text != string.Empty))
            {
                try
                {


                    result = myDatabase.InsertOrUpdateMoviesstring(txtTitle.Text, txtGenre.Text, txtMovieID.Text, txtRentalCost.Text, txtCopies.Text, txtPlot.Text, txtRating.Text, txtYear.Text, "Add");
                    MessageBox.Show(txtTitle.Text + " Add " + result);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                //update the datagrid view to see new entries
                dgvMovies.DataSource = myDatabase.FilldgvMovies();
                txtTitle.Text = "";
                txtGenre.Text = "";
                txtRentalCost.Text = "";
                txtCopies.Text = "";
                txtPlot.Text = "";
                txtRating.Text = "";
                txtYear.Text = "";
            }
            else
            {
                MessageBox.Show("Fill First Name and Surname fields");
            }
        }

        private void btnUpdateMovie_Click(object sender, EventArgs e)
        {
            string result = null;
            if ((txtTitle.Text != string.Empty))
            {
                try
                {


                    result = myDatabase.InsertOrUpdateMoviesstring(txtTitle.Text, txtGenre.Text, txtMovieID.Text, txtRentalCost.Text, txtCopies.Text, txtPlot.Text, txtYear.Text, txtRating.Text, "Update");
                    MessageBox.Show(txtTitle.Text + " Update " + result);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                //update the datagrid view to see new entries
                dgvMovies.DataSource = myDatabase.FilldgvMovies();
                txtTitle.Text = "";
                txtGenre.Text = "";
                txtRentalCost.Text = "";
                txtCopies.Text = "";
                txtPlot.Text = "";
                txtYear.Text = "";
                txtRating.Text = "";

            }
            else
            {
                MessageBox.Show("Fill First Name and Surname fields");
            }
        }

        private void btnDeleteMovie_Click(object sender, EventArgs e)
        {
            string result = null;
            if ((txtTitle.Text != string.Empty))
            {
                try
                {
                    result = myDatabase.DeleteCustomersMoviesRentals(txtMovieID.Text, "Movies");
                    MessageBox.Show(txtMovieID.Text + " Delete " + result);
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                dgvMovies.DataSource = myDatabase.FilldgvMovies();
                txtTitle.Text = "";
                txtGenre.Text = "";
                txtRentalCost.Text = "";
                txtCopies.Text = "";
                txtPlot.Text = "";
                txtDate.Text = "";
            }
        }

        private void btnIssueMovie_Click(object sender, EventArgs e)
        {
            string result = null;
            if ((txtMovieID.Text != string.Empty) && (txtCustID.Text != string.Empty))
            {
                try
                {
                    // txtDateRented = DateTime.Now.ToString();

                    result = myDatabase.IssueMovie(txtMovieID.Text, txtCustID.Text, txtRMID.Text, "Add");
                    MessageBox.Show(txtTitle.Text + " Was Rented by " + txtFirstName.Text + txtLastName.Text + result);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                //update the datagrid view to see new entries
                dgvRentedMovies.DataSource = myDatabase.FilldgvRentedMovies();
                txtFirstName.Text = "";
                txtLastName.Text = "";
                txtAddress.Text = "";
                txtTitle.Text = "";
                txtRentalCost.Text = "";
                txtDateRented.Text = "";



            }
            else
            {
                MessageBox.Show("Fill First Name and Surname fields");
            }
        }

        private void btnReturnMovie_Click(object sender, EventArgs e)
        {
            string result = null;
            if ((txtRMID.Text != string.Empty))
            {
                try
                {
                    // txtDateRented = DateTime.Now.ToString();

                    result = myDatabase.ReturnMovie(txtRMID.Text, "Update");
                    MessageBox.Show(txtTitle.Text + " Rented by " + txtFirstName.Text + txtLastName.Text + "Has been  returned" + result);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                //update the datagrid view to see new entries
                dgvRentedMovies.DataSource = myDatabase.FilldgvRentedMovies();
                txtFirstName.Text = "";
                txtLastName.Text = "";
                txtAddress.Text = "";
                txtTitle.Text = "";
                txtRentalCost.Text = "";
                txtDateRented.Text = "";



            }
            else
            {
                MessageBox.Show("Fill First Name and Surname fields");
            }
        }

        private void rbOutRented_CheckedChanged(object sender, EventArgs e)
        {
            dgvRentedMovies.DataSource = myDatabase.FilldgvRentedMoviesOut();

        }

        private void rbAllRented_CheckedChanged(object sender, EventArgs e)
        {
            dgvRentedMovies.DataSource = myDatabase.FilldgvRentedMovies();

        }
    }
}
