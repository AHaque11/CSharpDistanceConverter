using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/* ***************************************************************************************************************************************************
    A C# program that converts distances between inches, feet and yards. The user enters a value and selects the conversion units from two list boxes.
                                             (A programming problem from my Intro to C# course.)
   **************************************************************************************************************************************************** */



namespace _4._5_Distance_Converter
{
    public partial class Form1 : Form
    {

        private void convertButton_Click(object sender, EventArgs e)
        {
           

                // Declare variables
                double inputDistance;
                double outputDistance;


                if (double.TryParse(inputTextBox.Text, out inputDistance))  // If a double is entered in the texbox, continue

                {
                    if (listBox1.SelectedIndex != -1 && listBox2.SelectedIndex != -1)  // If items from both list boxes are selected, continue
                    {
                        if (listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 1) // If inches --> feet is selected
                        {
                            outputDistance = inputDistance / 12;
                            outputDisplayLabel.Text = outputDistance.ToString("n2");
                        }

                        else if (listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 2) // If inches --> yards is selected
                        {
                            outputDistance = inputDistance / 36;
                            outputDisplayLabel.Text = outputDistance.ToString("n2");
                        }

                        else if (listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 0) // If inches --> inches is selected
                        {
                            outputDisplayLabel.Text = inputDistance.ToString("n2");
                        }

                        else if (listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 0) // If feet --> inches is selected
                        {
                            outputDistance = inputDistance * 12;
                            outputDisplayLabel.Text = outputDistance.ToString("n2");
                        }

                        else if (listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 1) // If ft --> ft is selected
                        {
                            outputDisplayLabel.Text = inputDistance.ToString("n2");
                        }

                        else if (listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 2) // If ft --> yd is selected
                        {
                            outputDistance = inputDistance * 3;
                            outputDisplayLabel.Text = outputDistance.ToString("n2");
                        }

                        else if (listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 0) // If yd --> in. is selected
                        {
                            outputDistance = inputDistance * 36;
                            outputDisplayLabel.Text = outputDistance.ToString("n2");
                        }

                        else if (listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 1) // If yd --> ft is selected
                        {
                            outputDistance = inputDistance * 3;
                            outputDisplayLabel.Text = outputDistance.ToString("n2");
                        }

                        else if (listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 2) // If yd --> yd is selected
                        {
                            outputDisplayLabel.Text = inputDistance.ToString("n2");
                        }
                    }

                    else // If items were not selected from both list boxes,
                    {
                        MessageBox.Show("Select a unit from each list");
                    }
                }

                else // If invalid entry in textbox,
                {
                    MessageBox.Show("Enter a valid distance");
                }

            

            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
