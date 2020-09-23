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

        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Car newCar = new Car();

            newCar.year = Convert.ToInt16(yearInput.Text);
            newCar.make = makeInput.Text;
            newCar.colour = colourInput.Text;
            newCar.mileage = Convert.ToInt32(mileageInput.Text);

            outputLabel.Text = Convert.ToString(newCar.year) + "\n";
            outputLabel.Text += newCar.make + "\n";
            outputLabel.Text += newCar.colour + "\n";
            outputLabel.Text += newCar.mileage + "\n";

        }
    }
}
