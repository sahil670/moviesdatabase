namespace moviesdatabase
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvMovies = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.dgvRentedMovies = new System.Windows.Forms.DataGridView();
            this.btnDeleteMovie = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtRentalCost = new System.Windows.Forms.TextBox();
            this.btnIssueMovie = new System.Windows.Forms.Button();
            this.btnReturnMovie = new System.Windows.Forms.Button();
            this.txtMovieID = new System.Windows.Forms.TextBox();
            this.rbAllRented = new System.Windows.Forms.RadioButton();
            this.rbOutRented = new System.Windows.Forms.RadioButton();
            this.btnUpdateMovie = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Movies = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Customers = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Rentals = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtRentedMovies = new System.Windows.Forms.TextBox();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCustID = new System.Windows.Forms.TextBox();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtDateRented = new System.Windows.Forms.TextBox();
            this.txtDateReturned = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtCopies = new System.Windows.Forms.TextBox();
            this.txtPlot = new System.Windows.Forms.TextBox();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.txtRMID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentedMovies)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.Movies.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Customers.SuspendLayout();
            this.panel2.SuspendLayout();
            this.Rentals.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMovies
            // 
            this.dgvMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovies.Location = new System.Drawing.Point(3, 3);
            this.dgvMovies.Name = "dgvMovies";
            this.dgvMovies.RowHeadersWidth = 51;
            this.dgvMovies.Size = new System.Drawing.Size(1322, 353);
            this.dgvMovies.TabIndex = 0;
            this.dgvMovies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMovies_CellContentClick);
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(-4, -10);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.RowHeadersWidth = 51;
            this.dgvCustomers.Size = new System.Drawing.Size(1319, 362);
            this.dgvCustomers.TabIndex = 1;
            this.dgvCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomers_CellContentClick);
            // 
            // dgvRentedMovies
            // 
            this.dgvRentedMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRentedMovies.Location = new System.Drawing.Point(3, 3);
            this.dgvRentedMovies.Name = "dgvRentedMovies";
            this.dgvRentedMovies.RowHeadersWidth = 51;
            this.dgvRentedMovies.RowTemplate.Height = 24;
            this.dgvRentedMovies.Size = new System.Drawing.Size(1322, 371);
            this.dgvRentedMovies.TabIndex = 2;
            this.dgvRentedMovies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRentedMovies_CellContentClick);
            // 
            // btnDeleteMovie
            // 
            this.btnDeleteMovie.Location = new System.Drawing.Point(46, 588);
            this.btnDeleteMovie.Name = "btnDeleteMovie";
            this.btnDeleteMovie.Size = new System.Drawing.Size(128, 31);
            this.btnDeleteMovie.TabIndex = 5;
            this.btnDeleteMovie.Text = "Delete Movie";
            this.btnDeleteMovie.UseVisualStyleBackColor = true;
            this.btnDeleteMovie.Click += new System.EventHandler(this.btnDeleteMovie_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(248, 533);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(119, 22);
            this.txtTitle.TabIndex = 9;
            this.txtTitle.Text = "Title";
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(373, 533);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(167, 22);
            this.txtGenre.TabIndex = 10;
            this.txtGenre.Text = "Genre";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(666, 536);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(106, 22);
            this.txtYear.TabIndex = 12;
            this.txtYear.Text = "Year";
            // 
            // txtRentalCost
            // 
            this.txtRentalCost.Location = new System.Drawing.Point(560, 533);
            this.txtRentalCost.Name = "txtRentalCost";
            this.txtRentalCost.Size = new System.Drawing.Size(100, 22);
            this.txtRentalCost.TabIndex = 13;
            this.txtRentalCost.Text = "Rental Cost";
            this.txtRentalCost.TextChanged += new System.EventHandler(this.txtRentalCost_TextChanged);
            // 
            // btnIssueMovie
            // 
            this.btnIssueMovie.ForeColor = System.Drawing.Color.Red;
            this.btnIssueMovie.Location = new System.Drawing.Point(923, 459);
            this.btnIssueMovie.Name = "btnIssueMovie";
            this.btnIssueMovie.Size = new System.Drawing.Size(79, 71);
            this.btnIssueMovie.TabIndex = 16;
            this.btnIssueMovie.Text = "Issue Movie";
            this.btnIssueMovie.UseVisualStyleBackColor = true;
            this.btnIssueMovie.Click += new System.EventHandler(this.btnIssueMovie_Click);
            // 
            // btnReturnMovie
            // 
            this.btnReturnMovie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnReturnMovie.Location = new System.Drawing.Point(852, 459);
            this.btnReturnMovie.Name = "btnReturnMovie";
            this.btnReturnMovie.Size = new System.Drawing.Size(65, 71);
            this.btnReturnMovie.TabIndex = 17;
            this.btnReturnMovie.Text = "Return Movie";
            this.btnReturnMovie.UseVisualStyleBackColor = true;
            this.btnReturnMovie.Click += new System.EventHandler(this.btnReturnMovie_Click);
            // 
            // txtMovieID
            // 
            this.txtMovieID.Location = new System.Drawing.Point(206, 533);
            this.txtMovieID.Name = "txtMovieID";
            this.txtMovieID.Size = new System.Drawing.Size(36, 22);
            this.txtMovieID.TabIndex = 18;
            // 
            // rbAllRented
            // 
            this.rbAllRented.AutoSize = true;
            this.rbAllRented.BackColor = System.Drawing.Color.DodgerBlue;
            this.rbAllRented.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbAllRented.Location = new System.Drawing.Point(13, 27);
            this.rbAllRented.Name = "rbAllRented";
            this.rbAllRented.Size = new System.Drawing.Size(94, 21);
            this.rbAllRented.TabIndex = 19;
            this.rbAllRented.TabStop = true;
            this.rbAllRented.Text = "All Rented";
            this.rbAllRented.UseVisualStyleBackColor = false;
            this.rbAllRented.CheckedChanged += new System.EventHandler(this.rbAllRented_CheckedChanged);
            // 
            // rbOutRented
            // 
            this.rbOutRented.AutoSize = true;
            this.rbOutRented.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbOutRented.Location = new System.Drawing.Point(113, 27);
            this.rbOutRented.Name = "rbOutRented";
            this.rbOutRented.Size = new System.Drawing.Size(102, 21);
            this.rbOutRented.TabIndex = 20;
            this.rbOutRented.TabStop = true;
            this.rbOutRented.Text = "Out Rented";
            this.rbOutRented.UseVisualStyleBackColor = true;
            this.rbOutRented.CheckedChanged += new System.EventHandler(this.rbOutRented_CheckedChanged);
            // 
            // btnUpdateMovie
            // 
            this.btnUpdateMovie.Location = new System.Drawing.Point(196, 588);
            this.btnUpdateMovie.Name = "btnUpdateMovie";
            this.btnUpdateMovie.Size = new System.Drawing.Size(128, 31);
            this.btnUpdateMovie.TabIndex = 21;
            this.btnUpdateMovie.Text = "Update Movie";
            this.btnUpdateMovie.UseVisualStyleBackColor = true;
            this.btnUpdateMovie.Click += new System.EventHandler(this.btnUpdateMovie_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Movies);
            this.tabControl1.Controls.Add(this.Customers);
            this.tabControl1.Controls.Add(this.Rentals);
            this.tabControl1.Location = new System.Drawing.Point(2, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1342, 409);
            this.tabControl1.TabIndex = 22;
            // 
            // Movies
            // 
            this.Movies.Controls.Add(this.panel1);
            this.Movies.Location = new System.Drawing.Point(4, 25);
            this.Movies.Name = "Movies";
            this.Movies.Padding = new System.Windows.Forms.Padding(3);
            this.Movies.Size = new System.Drawing.Size(1334, 380);
            this.Movies.TabIndex = 0;
            this.Movies.Text = "Movies";
            this.Movies.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvMovies);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1328, 374);
            this.panel1.TabIndex = 0;
            // 
            // Customers
            // 
            this.Customers.Controls.Add(this.panel2);
            this.Customers.Location = new System.Drawing.Point(4, 25);
            this.Customers.Name = "Customers";
            this.Customers.Padding = new System.Windows.Forms.Padding(3);
            this.Customers.Size = new System.Drawing.Size(1334, 380);
            this.Customers.TabIndex = 1;
            this.Customers.Text = "Customers";
            this.Customers.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvCustomers);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1328, 377);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Rentals
            // 
            this.Rentals.Controls.Add(this.panel3);
            this.Rentals.Location = new System.Drawing.Point(4, 25);
            this.Rentals.Name = "Rentals";
            this.Rentals.Size = new System.Drawing.Size(1334, 380);
            this.Rentals.TabIndex = 2;
            this.Rentals.Text = "Rentals";
            this.Rentals.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvRentedMovies);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1328, 377);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel4.Controls.Add(this.txtRentedMovies);
            this.panel4.Controls.Add(this.rbAllRented);
            this.panel4.Controls.Add(this.rbOutRented);
            this.panel4.ForeColor = System.Drawing.SystemColors.Control;
            this.panel4.Location = new System.Drawing.Point(592, 564);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(248, 62);
            this.panel4.TabIndex = 23;
            this.panel4.Tag = "";
            // 
            // txtRentedMovies
            // 
            this.txtRentedMovies.BackColor = System.Drawing.Color.DodgerBlue;
            this.txtRentedMovies.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRentedMovies.Location = new System.Drawing.Point(13, 6);
            this.txtRentedMovies.Name = "txtRentedMovies";
            this.txtRentedMovies.Size = new System.Drawing.Size(100, 15);
            this.txtRentedMovies.TabIndex = 24;
            this.txtRentedMovies.Text = "Rented Movies";
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Location = new System.Drawing.Point(426, 439);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(126, 27);
            this.btnDeleteCustomer.TabIndex = 7;
            this.btnDeleteCustomer.Text = "Delete Customer";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Location = new System.Drawing.Point(271, 439);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(149, 27);
            this.btnUpdateCustomer.TabIndex = 6;
            this.btnUpdateCustomer.Text = "Update Customer";
            this.btnUpdateCustomer.UseVisualStyleBackColor = true;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(206, 483);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(108, 22);
            this.txtFirstName.TabIndex = 8;
            this.txtFirstName.Text = "First Name";
            this.txtFirstName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(332, 483);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(119, 22);
            this.txtLastName.TabIndex = 11;
            this.txtLastName.Text = "Last Name";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(457, 483);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(138, 22);
            this.txtAddress.TabIndex = 14;
            this.txtAddress.Text = "Address";
            // 
            // txtCustID
            // 
            this.txtCustID.Location = new System.Drawing.Point(206, 444);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.Size = new System.Drawing.Size(46, 22);
            this.txtCustID.TabIndex = 15;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(46, 444);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(128, 61);
            this.btnAddCustomer.TabIndex = 4;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click_1);
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.Location = new System.Drawing.Point(46, 522);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(128, 33);
            this.btnAddMovie.TabIndex = 24;
            this.btnAddMovie.Text = "Add Movie";
            this.btnAddMovie.UseVisualStyleBackColor = true;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(605, 483);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(110, 22);
            this.txtPhone.TabIndex = 25;
            this.txtPhone.Text = "Phone";
            // 
            // txtDateRented
            // 
            this.txtDateRented.Location = new System.Drawing.Point(721, 483);
            this.txtDateRented.Name = "txtDateRented";
            this.txtDateRented.Size = new System.Drawing.Size(100, 22);
            this.txtDateRented.TabIndex = 26;
            // 
            // txtDateReturned
            // 
            this.txtDateReturned.Location = new System.Drawing.Point(721, 511);
            this.txtDateReturned.Name = "txtDateReturned";
            this.txtDateReturned.Size = new System.Drawing.Size(100, 22);
            this.txtDateReturned.TabIndex = 27;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(721, 455);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(100, 22);
            this.txtDate.TabIndex = 28;
            this.txtDate.Text = "Date";
            // 
            // txtCopies
            // 
            this.txtCopies.Location = new System.Drawing.Point(778, 536);
            this.txtCopies.Name = "txtCopies";
            this.txtCopies.Size = new System.Drawing.Size(73, 22);
            this.txtCopies.TabIndex = 29;
            this.txtCopies.Text = "Copies";
            // 
            // txtPlot
            // 
            this.txtPlot.Location = new System.Drawing.Point(373, 570);
            this.txtPlot.Name = "txtPlot";
            this.txtPlot.Size = new System.Drawing.Size(167, 22);
            this.txtPlot.TabIndex = 30;
            this.txtPlot.Text = "Plot";
            // 
            // txtRating
            // 
            this.txtRating.Location = new System.Drawing.Point(373, 610);
            this.txtRating.Name = "txtRating";
            this.txtRating.Size = new System.Drawing.Size(106, 22);
            this.txtRating.TabIndex = 31;
            this.txtRating.Text = "Rating";
            // 
            // txtRMID
            // 
            this.txtRMID.Location = new System.Drawing.Point(583, 441);
            this.txtRMID.Name = "txtRMID";
            this.txtRMID.Size = new System.Drawing.Size(60, 22);
            this.txtRMID.TabIndex = 32;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1506, 644);
            this.Controls.Add(this.txtRMID);
            this.Controls.Add(this.txtRating);
            this.Controls.Add(this.txtPlot);
            this.Controls.Add(this.txtCopies);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtDateReturned);
            this.Controls.Add(this.txtDateRented);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.btnAddMovie);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtRentalCost);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.txtCustID);
            this.Controls.Add(this.btnDeleteCustomer);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.btnUpdateCustomer);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.btnUpdateMovie);
            this.Controls.Add(this.btnIssueMovie);
            this.Controls.Add(this.btnDeleteMovie);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtMovieID);
            this.Controls.Add(this.btnReturnMovie);
            this.Controls.Add(this.txtGenre);
            this.Name = "Form1";
            this.Text = "Movie Database";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentedMovies)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.Movies.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.Customers.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.Rentals.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMovies;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.DataGridView dgvRentedMovies;
        private System.Windows.Forms.Button btnDeleteMovie;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtRentalCost;
        private System.Windows.Forms.Button btnIssueMovie;
        private System.Windows.Forms.Button btnReturnMovie;
        private System.Windows.Forms.TextBox txtMovieID;
        private System.Windows.Forms.RadioButton rbAllRented;
        private System.Windows.Forms.RadioButton rbOutRented;
        private System.Windows.Forms.Button btnUpdateMovie;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Movies;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage Customers;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabPage Rentals;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtRentedMovies;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCustID;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtDateRented;
        private System.Windows.Forms.TextBox txtDateReturned;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtCopies;
        private System.Windows.Forms.TextBox txtPlot;
        private System.Windows.Forms.TextBox txtRating;
        private System.Windows.Forms.TextBox txtRMID;
    }
}

