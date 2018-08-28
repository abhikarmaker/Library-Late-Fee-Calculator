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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            txtCurrent.Text = DateTime.Now.ToString(@"MM-dd-yyyy");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        frmNewRelease frm1 = new frmNewRelease();
        private void button1_Click(object sender, EventArgs e)
        {
            frm1.ShowDialog();
        }

        frmKidsMovie frm2 = new frmKidsMovie();

        private void button3_Click(object sender, EventArgs e)
        {
            frm2.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        frmLibraryMovie frm3 = new frmLibraryMovie();
        private void btnLibraryMovie_Click(object sender, EventArgs e)
        {
            frm3.ShowDialog();
        }
        frmRentalMaintenance frm4 = new frmRentalMaintenance();
        private void btnAddRemoveMovies_Click(object sender, EventArgs e)
        {
            frm4.ShowDialog();
        }

    }
}
