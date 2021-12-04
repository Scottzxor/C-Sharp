/* Scott Shaulis
 * 04/19/21
 * Assignment 10: Lazy Parent and Child forms
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiform_Calculator
{
    public partial class FrmAddSubtract : Form
    {
        public FrmAddSubtract()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                double firstNum = 0;
                double secondNum = 0;

                double.TryParse(txtBxFirstNum.Text, out firstNum);
                double.TryParse(txtBxSecondNum.Text, out secondNum);
                double result = firstNum + secondNum;
                txtBxResult.Text = result.ToString();

            }
            catch (Exception invalidData)
            {
                Console.WriteLine("Invalid data: {0}", invalidData.Source);
            }
        }

        private void BtnSubtract_Click(object sender, EventArgs e)
        {
            try
            {
                double firstNum = 0;
                double secondNum = 0;

                double.TryParse(txtBxFirstNum.Text, out firstNum);
                double.TryParse(txtBxSecondNum.Text, out secondNum);
                double result = firstNum - secondNum;
                txtBxResult.Text = result.ToString();

            }
            catch (Exception invalidData)
            {
                Console.WriteLine("Invalid data: {0}", invalidData.Source);
            }
        }

    }


    /*
    double presentValue, futureValue, years, annualInterestRate = 0.0;

    try
    {
        //Check all the inputs
        if (double.TryParse(futureValueTextBox.Text, out futureValue) &&
            double.TryParse(yearsTextBox.Text, out years) &&
            double.TryParse(annualInterestRateTextBox.Text, out annualInterestRate))
        {

            // First data validation checkmark, verifying futre value is greater than 1,000.
            if (futureValue < 1000)
            {
                MessageBox.Show("Invalid Future Value");
                futureValueTextBox.Text = "";
            }

            // Second data validation checkmark, verifying years are within the designated range.
            if (years < 0 || years > 30)
            {
                MessageBox.Show("Invalid Number of Years");
                yearsTextBox.Text = "";
            }

            // Third data validation checkmark, verifying annual interest rate is within the designated range.
            if (annualInterestRate < 0.01 || annualInterestRate > 0.24)
            {
                MessageBox.Show("Invalid Interest Rate");
                annualInterestRateTextBox.Text = "";
            }

            // If all data is valid, the PresentValue method will run, accepting 3 double args.
            else
            {

                {
                    //All good, so calculate
                    presentValue = Present_Value(futureValue, years, annualInterestRate);

                    //Display result
                    presentValueLabel.Text = presentValue.ToString("c");
                }
            }
        }
        else
        {
            //Must have been an input error
            MessageBox.Show("Invalid Data Entered!");
        }
        //Catches all Exceptions. I'm not sure which ones might get tripped, since there's no user input aside from the ones that are already checked with TryParse. So, if anything bad happens, this will catch it.
    }
    catch (Exception invalidData)
    {
        Console.WriteLine("Invalid data: {0}", invalidData.Source);
    }
    */
}