using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace LateFeeCalculator
{
    public partial class frmKidsMovie : Form
    {
        //Variable Declaration
        double number_of_days;
        double number_of_movies;
        double late_fee;

        public frmKidsMovie()
        {
            InitializeComponent();
            dtDueDate.MaxDate = DateTime.Today.AddDays(-1);
        }

        //It is used to remove the data when we click on back button
        private void btnBack_Click(object sender, EventArgs e)
        {
            txtCurrentDate.Text = "";
            txtNumberofMovies.Text = "";
            txtLateFee.Text = "";
            txtNoOfDaysLate.Text = "";
            txtMovieTitle.Text = "";
            txtTax.Text = "";
            txtTotal.Text = "";
            number_of_days = 0;
            number_of_movies = 0;
            late_fee = 0;
            count = 0;
            list.Clear();
            taxVal = 13;
            lblTax.Text = "Tax(13%)";
            this.Hide(); // Hide this form to reveal the MainForm
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (isValidData())
                {
                    //Generate the current Date
                    DateTime currentDate = DateTime.Now;
                    // Generate the due date based on user entry in datapicker dtDueDate
                    String duedate = dtDueDate.Text;
                    DateTime dateInput = DateTime.Parse(duedate);
                    //Display the current in txtCurrentDate
                    txtCurrentDate.Text = currentDate.ToString(@"MM-dd-yyyy");

                    TimeSpan days = (currentDate.Date - dateInput);

                    number_of_days = days.TotalDays;
                    //Display the number of days late in textbox txtNoOfDaysLate
                    txtNoOfDaysLate.Text = number_of_days.ToString();

                    //Call the CalculateLateFee method of different class and store that method in late_fee variable
                    late_fee = this.CalculateLateFee(number_of_days);
                    //Display the late fee in textbox txtLateFee
                    txtLateFee.Text = late_fee.ToString("c");

                    //Calculating taxAmount
                    double taxAmount = late_fee * taxVal / 100;
                    //Displaying taxAmount in textTax textbox
                    txtTax.Text = taxAmount.ToString("c");

                    //Calculating total amount
                    double total = late_fee + taxAmount;
                    //Displaying totalAmount in textTotal textbox
                    txtTotal.Text = total.ToString("c");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("FormateException Error", "Format Error"); // a specific exception
            }
            catch (OverflowException)
            {
                MessageBox.Show("OverflowException Error", "Overflow Error");// a specific exception
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.GetType().ToString() + "\n" +
                    ex.StackTrace, "Exception");//all other exception
                txtCurrentDate.Text = "";
                txtNoOfDaysLate.Text = "";
            }
        }

        //Create the method for calculating the late fees and return the value
        private double CalculateLateFee(double number_of_days)
        {

            number_of_movies = Convert.ToDouble(txtNumberofMovies.Text);
            late_fee = number_of_days * number_of_movies * 0.57;
            txtLateFee.Text = late_fee.ToString("c");
            return late_fee;
        }

        // It used to empty the date of all fields
        private void ClearLateFee(object sender, EventArgs e)
        {
            txtLateFee.Text = "";
            txtCurrentDate.Text = "";
            txtNoOfDaysLate.Text = "";
            txtTax.Text = "";
            txtTotal.Text = "";
        }

        //Checking validation for all methods 
        private bool isValidData()
        {
            return
                IsPositive(txtNumberofMovies, "Value");
        }

        //this method helps to check the value is positive or not
        public bool IsPositive(TextBox textbox, String name)
        {
            int number_of_movies = Convert.ToInt32(txtNumberofMovies.Text);
            if (number_of_movies < 0)
            {
                MessageBox.Show(name + " must be a positive number.", "Positive Number Error");
                textbox.Focus();
                return false;
            }
            return true;
        }

        //Creating a list of string
        List<String> list = new List<String>();
        int count = 0;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMovieTitle.Text == "")
                {
                    MessageBox.Show("Movie Title Name cannot be empty.");
                }
                else {
                    // adding data from txtMovieTitle into list
                    list.Add(txtMovieTitle.Text);
                    count++;
                    //increamenting the count in each adding of movieTitle
                    txtNumberofMovies.Text = count.ToString();
                    txtMovieTitle.Text = "";
                    txtMovieTitle.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.GetType().ToString() + "\n" +
                                    ex.StackTrace, "Exception");
            }

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            //Sorting the added data from txtMovieTitle
            list.Sort();
            String movieTitleString = "";
            foreach (string i in list)
            {
                movieTitleString += i + "\n";
            }
            //Displaying all the movie title list in Message Box alphabetically 
            MessageBox.Show(movieTitleString, "Sorted String");
            txtMovieTitle.Focus();
        }

        double taxVal = 13.00;
        private void btnTax_Click(object sender, EventArgs e)
        {
            try
            {
                //Getting the tax value from Sales form
                frmSaleTax frm = new frmSaleTax();
                DialogResult selectedButton = frm.ShowDialog();
                String tax = (String)frm.Tag;

                if (tax != "")
                {
                    taxVal = Convert.ToDouble(tax);
                }
                else
                {
                    taxVal = 13.00;
                }
                //Changing the label value from 13% to taxVal entered by the user in Sale Form
                lblTax.Text = "Tax (" + taxVal.ToString() + "%)";
                txtCurrentDate.Text = "";
                txtNoOfDaysLate.Text = "";
                txtLateFee.Text = "";
                txtTax.Text = "";
                txtTotal.Text = "";
                btnCalculate.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.GetType().ToString() + "\n" +
                    ex.StackTrace, "Exception");//all other exception
            }
        }
    }
}
