namespace Name_Search
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
            this.nameDescriptionLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.checkButton = new System.Windows.Forms.Button();
            this.popularityResultLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameDescriptionLabel
            // 
            this.nameDescriptionLabel.AutoSize = true;
            this.nameDescriptionLabel.Location = new System.Drawing.Point(36, 29);
            this.nameDescriptionLabel.Name = "nameDescriptionLabel";
            this.nameDescriptionLabel.Size = new System.Drawing.Size(73, 13);
            this.nameDescriptionLabel.TabIndex = 0;
            this.nameDescriptionLabel.Text = "Enter a name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(115, 26);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(79, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(218, 18);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(153, 35);
            this.checkButton.TabIndex = 2;
            this.checkButton.Text = "Check Popularity";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // popularityResultLabel
            // 
            this.popularityResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.popularityResultLabel.Location = new System.Drawing.Point(393, 25);
            this.popularityResultLabel.Name = "popularityResultLabel";
            this.popularityResultLabel.Size = new System.Drawing.Size(260, 21);
            this.popularityResultLabel.TabIndex = 3;
            this.popularityResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(673, 18);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(66, 35);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 73);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.popularityResultLabel);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameDescriptionLabel);
            this.Name = "Form1";
            this.Text = "Name Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameDescriptionLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Label popularityResultLabel;
        private System.Windows.Forms.Button exitButton;
    }
}

