﻿using System;
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
    public partial class frmRentalMaintenance : Form
    {
        public frmRentalMaintenance()
        {
            InitializeComponent();
        }

        //Creating a List for Class RentalItem and assigning null to the object variable
        private List<RentalItem> rentalItems = null;

        private void frmRentalMaintenance_Load(object sender, EventArgs e)
        {
            
            rentalItems = RentalItemDB.GetRentalItems();
            //Calling the method to load all datas when form is loaded
            FillRentalItemListBox();
        }

        private void FillRentalItemListBox() {
            //Getting all the rows from the databse into listbox
            lstRents.Items.Clear();
            foreach (RentalItem r in rentalItems) {
                lstRents.Items.Add(r.GetDisplayText());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmNewMovie addRentalItemForm = new frmNewMovie();
            RentalItem rentalItem = addRentalItemForm.GetNewRentalItem();
            if (rentalItem != null)
            {
                //Adding data into database after getting it from NewMovie form
                rentalItems.Add(rentalItem);
                RentalItemDB.SaveRentalItems(rentalItems);
                FillRentalItemListBox();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Deleting one selected row in listBox from database
            int i = lstRents.SelectedIndex;
            if (i != -1)
            {
                RentalItem rentalItem = rentalItems[i];
                string message = "Are you sure you want to delete "
                    + rentalItem.MovieNo + " " + rentalItem.Description + "?";
                DialogResult button = MessageBox.Show(message, "Confirm Delete",
                    MessageBoxButtons.YesNo);
                if (button == DialogResult.Yes)
                {
                    rentalItems.Remove(rentalItem);
                    RentalItemDB.SaveRentalItems(rentalItems);
                    FillRentalItemListBox();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
