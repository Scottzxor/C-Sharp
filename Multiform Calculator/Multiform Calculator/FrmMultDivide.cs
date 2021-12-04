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
    public partial class FrmMultDivide : Form
    {
        public FrmMultDivide()
        {
            InitializeComponent();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            try
            {
                double firstNum = 0;
                double secondNum = 0;

                double.TryParse(txtBxFirstNum.Text, out firstNum);
                double.TryParse(txtBxSecondNum.Text, out secondNum);
                double result = firstNum * secondNum;
                txtBxResult.Text = result.ToString();

            }
            catch (Exception invalidData)
            {
                Console.WriteLine("Invalid data: {0}", invalidData.Source);
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            try
            {
                double firstNum = 0;
                double secondNum = 0;

                double.TryParse(txtBxFirstNum.Text, out firstNum);
                double.TryParse(txtBxSecondNum.Text, out secondNum);
                double result = firstNum / secondNum;
                txtBxResult.Text = result.ToString();

            }
            catch (Exception invalidData)
            {
                Console.WriteLine("Invalid data: {0}", invalidData.Source);
            }
        }
    }
}
