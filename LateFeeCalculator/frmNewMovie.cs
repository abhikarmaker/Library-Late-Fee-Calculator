using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LateFeeCalculator
{
    public partial class frmNewMovie : Form
    {
        public frmNewMovie()
        {
            InitializeComponent();
        }

        //Class Variable declared as null
        private RentalItem rentalItem = null;

        //
        public RentalItem GetNewRentalItem() {
            this.ShowDialog();
            return rentalItem;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isValidData()) {
                //assigning the value from textbox to the object of the class RentalItem
                rentalItem = new RentalItem(Convert.ToInt32(txtMovieNo.Text),txtDescription.Text,txtRating.Text);
                this.Close();
            }
        }

        private bool isValidData() {
            //Calling of the method IsPresent and IsInt32 from class validator
            return Validator.IsPresent(txtMovieNo) &&
                Validator.IsInt32(txtMovieNo) &&
                Validator.IsPresent(txtDescription) &&
                Validator.IsPresent(txtRating);
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
