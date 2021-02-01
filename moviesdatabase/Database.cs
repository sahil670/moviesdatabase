using System;
using System.Data;
using System.Data.SqlClient;

namespace moviesdatabase
{
    public class Database
    {
        public string connectionString;
        //Create Connection and Command,and an Adapter.
        private SqlConnection Connection = new SqlConnection();
        private SqlCommand Command = new SqlCommand();
        private SqlDataAdapter da = new SqlDataAdapter();

        public Database()
        {
            connectionString =
               @"Data Source=SYSTEM\SQLEXPRESS;Initial Catalog=VBMoviesFullData;Integrated Security=True;Connect Timeout=30";

            Connection.ConnectionString = connectionString;
            Command.Connection = Connection;

        }

        public DataTable FilldgvMovies()
        {
            //create a datatable as we only have one table, the Owner
            DataTable dt = new DataTable();
            using (da = new SqlDataAdapter("select * from Movies", Connection))
            {
                //connect in to the DB and get the SQL
                Connection.Open();
                //open a connection to the DB
                da.Fill(dt);
                //fill the datatable from the SQL
                Connection.Close(); //close the connection
            }
            return dt; //pass the datatable data to the DataGridView
        }

        public DataTable FilldgvCustomers()
        {
            //create a datatable as we only have one table, the Owner
            DataTable dt = new DataTable();
            using (da = new SqlDataAdapter("select * from Customer", Connection))
            {
                //connect in to the DB and get the SQL
                Connection.Open();
                //open a connection to the DB
                da.Fill(dt);
                //fill the datatable from the SQL
                Connection.Close(); //close the connection
            }
            return dt; //pass the datatable data to the DataGridView
        }

        public DataTable FilldgvRentedMovies()
        {
            //create a datatable as we only have one table, the Owner
            DataTable dt = new DataTable();
            using (da = new SqlDataAdapter("select * from CustomerAndMoviesRented", Connection))
            {
                //connect in to the DB and get the SQL
                Connection.Open();
                //open a connection to the DB
                da.Fill(dt);
                //fill the datatable from the SQL
                Connection.Close(); //close the connection
            }
            return dt; //pass the datatable data to the DataGridView
        }

        public DataTable FilldgvRentedMoviesOut()
        {
            //create a datatable as we only have one table, the Owner
            DataTable dt = new DataTable();
            using (da = new SqlDataAdapter("select * from MoviesOut", Connection))
            {
                //connect in to the DB and get the SQL
                Connection.Open();
                //open a connection to the DB
                da.Fill(dt);
                //fill the datatable from the SQL
                Connection.Close(); //close the connection
            }
            return dt; //pass the datatable data to the DataGridView
        }


        public string InsertOrUpdateCustomersstring(string FirstName, string LastName, string CustID, string Address, string Phone, string Date, string AddOrUpdate)
        {
            try
            {
                //add gets passed through the parameter
                if (AddOrUpdate == "Add")
                {
                    //Create a Command object // Create a Query. Create and open a connection to SQL Server
                    string query = "Insert Into Customer (FirstName, LastName,  Address, Phone, Date) " +
                                   "Values(@FirstName, @LastName, @Address, @Phone, @Date)";
                    var myCommand = new SqlCommand(query, Connection);
                    //create parameters
                    myCommand.Parameters.AddWithValue("FirstName", FirstName);
                    myCommand.Parameters.AddWithValue("LastName", LastName);
                    myCommand.Parameters.AddWithValue("CustID", CustID);
                    myCommand.Parameters.AddWithValue("Address", Address);
                    myCommand.Parameters.AddWithValue("Phone", Phone);
                    myCommand.Parameters.AddWithValue("Date", Date);
                    Connection.Open();
                    //open connection add in the SQL
                    myCommand.ExecuteNonQuery();
                    Connection.Close();
                }
                //Update gets passed through the parameter
                else if (AddOrUpdate == "Update")
                {
                    var myCommand =
                        new SqlCommand("Update Customer set FirstName = @FirstName, LastName = @LastName, Address = @Address, Phone = @Phone, Date = @Date where CustID = @CustID ",
                            Connection);
                    //use parameters to prevent SQL injections
                    myCommand.Parameters.AddWithValue("Firstname", FirstName);
                    myCommand.Parameters.AddWithValue("Lastname", LastName);
                    myCommand.Parameters.AddWithValue("CustID", CustID);
                    myCommand.Parameters.AddWithValue("Address", Address);
                    myCommand.Parameters.AddWithValue("Phone", Phone);
                    myCommand.Parameters.AddWithValue("Date", Date);
                    Connection.Open();
                    // open connection add in the SQL
                    myCommand.ExecuteNonQuery();
                    Connection.Close();
                }

                return " is Successful";
            }
            catch (Exception e)
            {
                //Need to get it to close a second time as it jumps the first connection.close if ExecuteNonQuery fails.
                Connection.Close();
                return " has Failed with " + e;
            }
        }

        public string DeleteCustomersMoviesRentals(string ID, string Table)
        {
            //only run if there is something in the textbox
            if (!object.ReferenceEquals(ID, string.Empty))
            {
                var myCommand = new SqlCommand();
                switch (Table)
                {
                    case "Customer":
                        myCommand = new SqlCommand("DELETE FROM Customer WHERE CustID = @ID", Connection);
                        break;
                    case "Movies":
                        myCommand = new SqlCommand("DELETE FROM Movies WHERE MovieID = @ID", Connection);
                        break;
                    case "Rentals":
                        myCommand = new SqlCommand("DELETE FROM RentedMovies WHERE RMID = @RMID", Connection);
                        break;
                }

                myCommand.Parameters.AddWithValue("ID", ID);
                //use parameters to prevent SQL injections
                Connection.Open();
                //open connection add in the SQL
                myCommand.ExecuteNonQuery();
                Connection.Close();
                return "Success";
            }
            else
            {
                Connection.Close();
                return "Failed";
            }
        }

        public string InsertOrUpdateMoviesstring(string Title, string Genre, string MovieID, string Rental_Cost, string Copies, string Plot, string Year, string Rating, string AddOrUpdate)
        {
            try
            {
                //add gets passed through the parameter
                if (AddOrUpdate == "Add")
                {
                    //Create a Command object // Create a Query. Create and open a connection to SQL Server
                    string query = "Insert Into Movies (Title, Genre,  Rental_Cost, Copies, Plot, Rating, Year) " +
                                   "Values(@Title, @Genre, @Rental_Cost, @Copies, @Plot, @Rating,  @Year)";
                    var myCommand = new SqlCommand(query, Connection);
                    //create parameters
                    myCommand.Parameters.AddWithValue("Title", Title);
                    myCommand.Parameters.AddWithValue("Genre", Genre);

                    myCommand.Parameters.AddWithValue("Rental_Cost", Rental_Cost);
                    myCommand.Parameters.AddWithValue("Copies", Copies);
                    myCommand.Parameters.AddWithValue("Plot", Plot);
                    myCommand.Parameters.AddWithValue("Rating", Rating);
                    myCommand.Parameters.AddWithValue("Year", Year);
                    Connection.Open();
                    //open connection add in the SQL
                    myCommand.ExecuteNonQuery();
                    Connection.Close();
                }
                //Update gets passed through the parameter
                else if (AddOrUpdate == "Update")
                {
                    var myCommand =
                        new SqlCommand("Update Movies set Title = @Title, Genre = @Genre, Rental_Cost = @Rental_Cost, Copies = @Copies, Rating = @Rating, Plot = @Plot, Year = @Year where MovieID = @MovieID",
                            Connection);
                    //use parameters to prevent SQL injections
                    myCommand.Parameters.AddWithValue("Title", Title);
                    myCommand.Parameters.AddWithValue("Genre", Genre);
                    myCommand.Parameters.AddWithValue("MovieID", MovieID);
                    myCommand.Parameters.AddWithValue("Rental_Cost", Rental_Cost);
                    myCommand.Parameters.AddWithValue("Copies", Copies);
                    myCommand.Parameters.AddWithValue("Plot", Plot);
                    myCommand.Parameters.AddWithValue("Rating", Rating);
                    myCommand.Parameters.AddWithValue("Year", Year);
                    Connection.Open();
                    // open connection add in the SQL
                    myCommand.ExecuteNonQuery();
                    Connection.Close();
                }

                return " is Successful";
            }
            catch (Exception e)
            {
                //Need to get it to close a second time as it jumps the first connection.close if ExecuteNonQuery fails.
                Connection.Close();
                return " has Failed with " + e;
            }
        }

        public string IssueMovie(string MovieID, string CustID, string RMID, string AddOrUpdate)
        {
            //only run if there is something in the textbox

            {
                try
                {
                    //add gets passed through the parameter
                    if (AddOrUpdate == "Add")
                    {
                        //Create a Command object // Create a Query. Create and open a connection to SQL Server
                        string query = "Insert Into RentedMovies (MovieIDFK, CustIDFK, DateRented)" +
                                       "Values(@MovieIDFK, @CustIDFK, @dt)";

                        var myCommand = new SqlCommand(query, Connection);
                        //create parameters
                        myCommand.Parameters.AddWithValue("MovieIDFK", MovieID);
                        myCommand.Parameters.AddWithValue("dt", DateTime.Now);
                        myCommand.Parameters.AddWithValue("CustIDFK", CustID);
                        Connection.Open();
                        //open connection add in the SQL
                        myCommand.ExecuteNonQuery();
                        Connection.Close();
                    }
                }
                catch (Exception e)
                {
                    //Need to get it to close a second time as it jumps the first connection.close if ExecuteNonQuery fails.
                    Connection.Close();
                    return " has Failed with " + e;
                }

                return null;
            }



        }

        public string ReturnMovie(string RMID, string AddOrUpdate)
        {
            //only run if there is something in the textbox

            {
                try
                {
                    //add gets passed through the parameter
                    if (AddOrUpdate == "Update")
                    {
                        //Create a Command object // Create a Query. Create and open a connection to SQL Server
                        var myCommand =
                        new SqlCommand("Update RentedMovies set DateReturned = @dt where RMID = @RMID", Connection);

                        myCommand.Parameters.AddWithValue("RMID", RMID);
                        myCommand.Parameters.AddWithValue("dt", DateTime.Now);
                        Connection.Open();
                        //open connection add in the SQL
                        myCommand.ExecuteNonQuery();
                        Connection.Close();
                    }
                }
                catch (Exception e)
                {
                    //Need to get it to close a second time as it jumps the first connection.close if ExecuteNonQuery fails.
                    Connection.Close();
                    return " has Failed with " + e;
                }

                return null;
            }



        }


    }

}
