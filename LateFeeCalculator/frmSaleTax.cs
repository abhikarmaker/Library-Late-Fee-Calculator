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
    public partial class frmSaleTax : Form
    {
        public frmSaleTax()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                SaveData();
                frmSaleTax.ActiveForm.Hide();
            }
        }

        private bool IsValidData()
        {
            return
                IsPresent(txtTaxPct, "This") &&
                IsDecimal(txtTaxPct, "This") &&
                IsWithinRange(txtTaxPct, "Value", 0, 21);
        }

        private void SaveData()
        {
            //get the value from Sales Text box and store it into tax as a tag value to pass
            String tax;
            tax = txtTaxPct.Text;
            this.Tag = tax;
        }

        private bool IsWithinRange(TextBox textBox, string name, decimal min, decimal max)
        {
            decimal number = Convert.ToDecimal(textBox.Text);
            if (number < min || number > max)
            {
                MessageBox.Show(name + " must be between" + min + " and " + max + ".", "Entry Error");
                textBox.Focus();
                String tax = "13";
                this.Tag = tax;
                return false;
            }
            return true;
        }

        private bool IsPresent(TextBox textBox, string name)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(name + " is a required field.", "Entry Error");
                textBox.Focus();
                String tax = "13";
                this.Tag = tax;
                return false;
            }
            return true;
        }

        private bool IsDecimal(TextBox textBox, string name)
        {
            decimal number = 0m;
            if (Decimal.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(name + " must be a decimal value.", "Entry Error");
                textBox.Focus();
                String tax = "13";
                this.Tag = tax;
                return false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            String tax = "13";
            this.Tag = tax;
        }
    }
}
