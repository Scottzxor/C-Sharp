
namespace Multiform_Calculator
{
    partial class FrmAddSubtract
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
            this.txtBxFirstNum = new System.Windows.Forms.TextBox();
            this.txtBxSecondNum = new System.Windows.Forms.TextBox();
            this.txtBxResult = new System.Windows.Forms.TextBox();
            this.LblFirstNum = new System.Windows.Forms.Label();
            this.LblSecondNum = new System.Windows.Forms.Label();
            this.LblResult = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnSubtract = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBxFirstNum
            // 
            this.txtBxFirstNum.Location = new System.Drawing.Point(77, 76);
            this.txtBxFirstNum.Name = "txtBxFirstNum";
            this.txtBxFirstNum.Size = new System.Drawing.Size(100, 20);
            this.txtBxFirstNum.TabIndex = 0;
            // 
            // txtBxSecondNum
            // 
            this.txtBxSecondNum.Location = new System.Drawing.Point(305, 76);
            this.txtBxSecondNum.Name = "txtBxSecondNum";
            this.txtBxSecondNum.Size = new System.Drawing.Size(100, 20);
            this.txtBxSecondNum.TabIndex = 1;
            // 
            // txtBxResult
            // 
            this.txtBxResult.Location = new System.Drawing.Point(481, 76);
            this.txtBxResult.Name = "txtBxResult";
            this.txtBxResult.Size = new System.Drawing.Size(100, 20);
            this.txtBxResult.TabIndex = 2;
            // 
            // LblFirstNum
            // 
            this.LblFirstNum.AutoSize = true;
            this.LblFirstNum.Location = new System.Drawing.Point(74, 60);
            this.LblFirstNum.Name = "LblFirstNum";
            this.LblFirstNum.Size = new System.Drawing.Size(66, 13);
            this.LblFirstNum.TabIndex = 3;
            this.LblFirstNum.Text = "First Number";
            // 
            // LblSecondNum
            // 
            this.LblSecondNum.AutoSize = true;
            this.LblSecondNum.Location = new System.Drawing.Point(302, 60);
            this.LblSecondNum.Name = "LblSecondNum";
            this.LblSecondNum.Size = new System.Drawing.Size(84, 13);
            this.LblSecondNum.TabIndex = 4;
            this.LblSecondNum.Text = "Second Number";
            // 
            // LblResult
            // 
            this.LblResult.AutoSize = true;
            this.LblResult.Location = new System.Drawing.Point(478, 60);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(37, 13);
            this.LblResult.TabIndex = 5;
            this.LblResult.Text = "Result";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(218, 33);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(40, 40);
            this.BtnAdd.TabIndex = 6;
            this.BtnAdd.Text = "+";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnSubtract
            // 
            this.BtnSubtract.Location = new System.Drawing.Point(218, 80);
            this.BtnSubtract.Name = "BtnSubtract";
            this.BtnSubtract.Size = new System.Drawing.Size(40, 40);
            this.BtnSubtract.TabIndex = 7;
            this.BtnSubtract.Text = "-";
            this.BtnSubtract.UseVisualStyleBackColor = true;
            this.BtnSubtract.Click += new System.EventHandler(this.BtnSubtract_Click);
            // 
            // FrmAddSubtract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 172);
            this.Controls.Add(this.BtnSubtract);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.LblResult);
            this.Controls.Add(this.LblSecondNum);
            this.Controls.Add(this.LblFirstNum);
            this.Controls.Add(this.txtBxResult);
            this.Controls.Add(this.txtBxSecondNum);
            this.Controls.Add(this.txtBxFirstNum);
            this.Name = "FrmAddSubtract";
            this.Text = "Adding and Subtracting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBxFirstNum;
        private System.Windows.Forms.TextBox txtBxSecondNum;
        private System.Windows.Forms.TextBox txtBxResult;
        private System.Windows.Forms.Label LblFirstNum;
        private System.Windows.Forms.Label LblSecondNum;
        private System.Windows.Forms.Label LblResult;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnSubtract;
    }
}