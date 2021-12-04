/* Scott Shaulis
 * 04/12/2021
 * Lesson 8: validating user input using a method; creating copies of strings until output becomes pig latin.
 */

namespace PigLatin
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputLabel = new System.Windows.Forms.Label();
            this.englishWordTextBox = new System.Windows.Forms.TextBox();
            this.middleLabel = new System.Windows.Forms.Label();
            this.pigLatinWordLabel = new System.Windows.Forms.Label();
            this.endLabel = new System.Windows.Forms.Label();
            this.convertButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Location = new System.Drawing.Point(14, 22);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(52, 13);
            this.inputLabel.TabIndex = 0;
            this.inputLabel.Text = "The word";
            // 
            // englishWordTextBox
            // 
            this.englishWordTextBox.Location = new System.Drawing.Point(77, 20);
            this.englishWordTextBox.Name = "englishWordTextBox";
            this.englishWordTextBox.Size = new System.Drawing.Size(95, 20);
            this.englishWordTextBox.TabIndex = 1;
            // 
            // middleLabel
            // 
            this.middleLabel.AutoSize = true;
            this.middleLabel.Location = new System.Drawing.Point(178, 23);
            this.middleLabel.Name = "middleLabel";
            this.middleLabel.Size = new System.Drawing.Size(62, 13);
            this.middleLabel.TabIndex = 2;
            this.middleLabel.Text = "in English is";
            // 
            // pigLatinWordLabel
            // 
            this.pigLatinWordLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pigLatinWordLabel.Location = new System.Drawing.Point(296, 20);
            this.pigLatinWordLabel.Name = "pigLatinWordLabel";
            this.pigLatinWordLabel.Size = new System.Drawing.Size(91, 20);
            this.pigLatinWordLabel.TabIndex = 3;
            this.pigLatinWordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Location = new System.Drawing.Point(393, 23);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(59, 13);
            this.endLabel.TabIndex = 4;
            this.endLabel.Text = "in Pig Latin";
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(246, 13);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(31, 32);
            this.convertButton.TabIndex = 5;
            this.convertButton.Text = "->";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 61);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.endLabel);
            this.Controls.Add(this.pigLatinWordLabel);
            this.Controls.Add(this.middleLabel);
            this.Controls.Add(this.englishWordTextBox);
            this.Controls.Add(this.inputLabel);
            this.Name = "Form1";
            this.Text = "Pig Latin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.TextBox englishWordTextBox;
        private System.Windows.Forms.Label middleLabel;
        private System.Windows.Forms.Label pigLatinWordLabel;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.Button convertButton;
    }
}

