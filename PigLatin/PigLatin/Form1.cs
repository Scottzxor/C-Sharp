/* Scott Shaulis
 * 04/12/2021
 * Lesson 8: validating user input using a method; creating copies of strings until output becomes pig latin.
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

namespace PigLatin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            //changing text input to String variable for ease of use and legibility.
            String userInput = englishWordTextBox.Text.Trim();

            // declare variables
            bool err = false;
            char letter;

            //checking 2 of the 3 conditions
            if (userInput == "" || userInput.Length > 12)
            {
                err = true;
                //clearing text and labels if error.
                englishWordTextBox.Text = "";
                pigLatinWordLabel.Text = "";
            }

            else { 

                //creating loop to iterate through user's input.
                for (int index = 0; index < userInput.Length; index++)
                {
                        //declaring variable at current indexed position in the loop for ease of use and legibility.
                        letter = userInput[index];

                        //declaring variable for sub-zero to convert to string so it can be added to end with Insert method. 
                        char subZero = userInput[0];

                        //converting char to string so it can be attached to end.
                        string firstLetter = subZero.ToString();

                        //My goodness, this feels very roundabout, and it feels like I'm doing something wrong.

                        //declaring variable for user input's length for ease of use and readability.
                        int userLength = userInput.Length;

                        //checking third condition
                        if (!Char.IsLetter(letter))
                        {
                            err = true;

                        //clearing values 
                        englishWordTextBox.Text = "";
                        pigLatinWordLabel.Text = "";

                        //adding break. Even if a non-char is found, the loop continues to iterate until the final value. If the final value is a char, the loop continues to the else statement and leaves the text and label boxes full.
                        //Could probably be better with a while loop, but this is not in assignment directions, and this fixes it.
                        break;

                    }
                        else
                        {
                        // Ironically, the inverse off-by-one error was possible here, without caution.
                        // The length being variable causes problems indexing. Without removing the initial character first,
                        // the quasi-StringArray is increased by 1, thereby changing the last position from, say, index[2] to index[3]. This means we cannot subtract 1 in order to compensate from starting from 0.

                        string newString = userInput.Insert(userLength, firstLetter);

                            string removedNewString = newString.Remove(0, 1);

                            //length of the string has changed by -1, so no longer have to subtract 1 from userLength.
                            string pigLatin = removedNewString.Insert(userLength, "ay");

                            //print out the 2nd copy of the original string, after removal of first letter, inserting first letter in string form to the end, then inserting 'ay' onto the end of the string. *whew*: tough one for me.
                            pigLatinWordLabel.Text = pigLatin;
                        }
                    }
                }

                //if the flag was tripped, show message box with general error message.
                if (err == true)
            {
                MessageBox.Show("Invalid Input.");
            }

                //assignment really helped drill in that strings are immutable. Tough, but enjoyable, and hopefully sufficient and not the most inefficient.

        }
    }
}
