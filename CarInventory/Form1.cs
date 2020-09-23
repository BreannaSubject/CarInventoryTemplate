using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CarInventory
{
    public partial class Form1 : Form
    {
        List<Car> carsDB = new List<Car>();
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int year = Convert.ToInt16(yearInput.Text);
            string make = makeInput.Text;
            string colour = colourInput.Text;
            int mileage = Convert.ToInt32(mileageInput.Text);

            Car newCar = new Car(year, make, colour, mileage);

          

            carsDB.Add(newCar);
            outputLabel.Text = " ";

            foreach (Car c in carsDB)
            {
                outputLabel.Text += c.year + ", " + c.make + ", " + c.colour + ", " + c.mileage + "\n";
            }
        }
    }
}
