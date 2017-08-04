using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Name: Bishnu Khanal
 * Student No: 300924228
 * Date: August 2, 2017
 * Description: This is the BMI Calculator wondow form for the prospective lab 26 of COMP123-s2017
 * This calculator prompts users to input information like gender, age height and weight and returns a standard result
 * Version: 0.3- BMI Calculator Interface Revised and Modified
 * Implemented Imperial or Matric Units Check Method() that checks one of the two units to input Height and weight
 * Added decimal precision to the Height in meter and Weight in Kilograms property 
 */
namespace BMICalculator_Lab26_s2017
{
    public partial class BMICalculator : Form
    {
        public BMICalculator()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This method checks if the user check Matric Units
        /// It also prompts users the text boxes to input Height and weight in specified units
        /// Implements decimal precision to 2 position in Meter and Weight property if they are in Metric Units
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MetricRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (MetricRadioButton.Checked)
            {
                HeightInInchLabel.Text = "Height in Meters";
                WeightInPounds.Text = "Weight in Kg";
                HeightNumericUpDown.DecimalPlaces = 2;
                WeightNumericUpDown.DecimalPlaces = 2;              
            }
        }
        /// <summary>
        /// This method checks if the user checks Imperial Units
        /// It also prompts users the text boxes to input Height and weight in specified units
        /// Removes the decimal precision and sets 0 in Inches and pound property if user checks Imperial Units
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImperialRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            HeightInInchLabel.Text = "Height in Inches";
            WeightInPounds.Text = "Weight in Pounds";
            HeightNumericUpDown.DecimalPlaces = 0;
            WeightNumericUpDown.DecimalPlaces = 0;
        }
    }
}
