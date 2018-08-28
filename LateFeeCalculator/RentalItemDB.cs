using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LateFeeCalculator
{
    public static class RentalItemDB
    {
        private const string dir = @"C:\C# 2015\Files\";
        private const string path = dir + "RentalItem.txt";

        public static void SaveRentalItems(List<RentalItem> rentalItems)
        {
            StreamWriter textOut =
                new StreamWriter(
                new FileStream(path, FileMode.Create, FileAccess.Write));

            // write each customer
            foreach (RentalItem rentalItem in rentalItems)
            {
                textOut.Write(rentalItem.MovieNo + "|");
                textOut.Write(rentalItem.Description + "|");
                textOut.WriteLine(rentalItem.Rating);
            }

            // write the end of the document
            textOut.Close();
        }

        public static List<RentalItem> GetRentalItems()
        {
            // if the directory doesn't exist, create it
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            // create the object for the input stream for a text file
            StreamReader textIn =
                new StreamReader(
                    new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read));

            // create the array list for customers
            List<RentalItem> rentalItems = new List<RentalItem>();

            // read the data from the file and store it in the ArrayList
            while (textIn.Peek() != -1)
            {
                string row = textIn.ReadLine();
                string[] columns = row.Split('|');
                RentalItem rentalItem = new RentalItem();
                rentalItem.MovieNo = Convert.ToInt32(columns[0]);
                rentalItem.Description = columns[1];
                rentalItem.Rating = columns[2];
                rentalItems.Add(rentalItem);
            }

            textIn.Close();

            return rentalItems;
        }
    }
}
