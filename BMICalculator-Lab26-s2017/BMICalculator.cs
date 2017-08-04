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
 * Version: 0.2- BMI Calculator Interface Modifies
 * Implemented Imperial or Matric Units Check Method() that checks one of the two units to input Height and weight
 */
namespace BMICalculator_Lab26_s2017
{
    public partial class BMICalculator : Form
    {
        public BMICalculator()
        {
            InitializeComponent();
        }

        private void MetricRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (MetricRadioButton.Checked)
            {
                HeightInInchLabel.Text = "Height in Meters";
                WeightInPounds.Text = "Weight in Kg";
            }
            else
            {
                HeightInInchLabel.Text = "Height in Inches";
                WeightInPounds.Text = "Weight in Pounds";
            }
        }
    }
}
