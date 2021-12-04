/* Scott Shaulis
 * 04/11/2021
 * Copying data from txt file into array; sequential search to find a user-input value in an array.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Name_Search
{


    public partial class Form1 : Form
    { 
        
        // create SequentialSearch method.
        private int SequentialSearch(string[] sArray, string value)
        {
            //create sequential search variables
            bool found = false;
            int index = 0;
            int position = -1;

            // search array
            while (!found && index < sArray.Length)
            {
                if (sArray[index] == value)
                {
                    //boolean flag breaks out of the while loop upon finding value
                    found = true;

                    // position switched to a number aside from -1, showing that something was found.
                    position = index;
                }
                index++;
            }

            // return either -1 if not found or the int index of the position where value was found.
            return position;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            try
            {
                popularityResultLabel.Text = "";
                if (nameTextBox.Text == "")
                {
                    popularityResultLabel.Text = ("No input provided.");
                }
                else
                {
                    //declare index variable to iterate trhough file's index
                    int index = 0;
                    string userInput = nameTextBox.Text;

                    //declare String array to accept the names from Names.txt
                    String[] namesArr = new string[400];

                    //declare streamreader object
                    StreamReader inputFile;

                    //open file using File.OpenText and assign the streamreader object 'inputFile' to the value of the open file.
                    inputFile = File.OpenText("Names.txt");

                    //read file's contents into the string using a while loop.
                    while (index < namesArr.Length && !inputFile.EndOfStream)
                    {
                        namesArr[index] = inputFile.ReadLine();
                        popularityResultLabel.Text = namesArr[index];
                        index++;
                    }

                    //close the file
                    inputFile.Close();

                    // sequential search of array to see if input matches any element
                    if(SequentialSearch(namesArr, userInput) != -1)
                    {
                        popularityResultLabel.Text = "This IS a popular name!";
                    }
                    else
                    {
                        popularityResultLabel.Text = "Sorry, this IS NOT a popular name!";
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
