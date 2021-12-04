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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void addSubtractButton_Click(object sender, EventArgs e)
        {

            //Creating form object.
            FrmAddSubtract addSubtract = new FrmAddSubtract();

            //instantiating class FrmAddSubtract.
            addSubtract.Show();

            //hiding form for user friendliness.
            this.Hide();
        }

        private void multiplyDivideButton_Click(object sender, EventArgs e)
        {
            //Creating new form object.
            FrmMultDivide multDivide = new FrmMultDivide();

            //instantiating class FrmMultDivide to show the form.
            multDivide.Show();

            //hiding form for user friendliness.
            this.Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close the form
            this.Close();
        }
    }
}
