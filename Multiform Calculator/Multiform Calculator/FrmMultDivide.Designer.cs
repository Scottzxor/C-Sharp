
namespace Multiform_Calculator
{
    partial class FrmMultDivide
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
            this.lblFirstNum = new System.Windows.Forms.Label();
            this.txtBxFirstNum = new System.Windows.Forms.TextBox();
            this.txtBxSecondNum = new System.Windows.Forms.TextBox();
            this.txtBxResult = new System.Windows.Forms.TextBox();
            this.lblSecondNum = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFirstNum
            // 
            this.lblFirstNum.AutoSize = true;
            this.lblFirstNum.Location = new System.Drawing.Point(79, 57);
            this.lblFirstNum.Name = "lblFirstNum";
            this.lblFirstNum.Size = new System.Drawing.Size(66, 13);
            this.lblFirstNum.TabIndex = 0;
            this.lblFirstNum.Text = "First Number";
            // 
            // txtBxFirstNum
            // 
            this.txtBxFirstNum.Location = new System.Drawing.Point(82, 73);
            this.txtBxFirstNum.Name = "txtBxFirstNum";
            this.txtBxFirstNum.Size = new System.Drawing.Size(100, 20);
            this.txtBxFirstNum.TabIndex = 1;
            // 
            // txtBxSecondNum
            // 
            this.txtBxSecondNum.Location = new System.Drawing.Point(302, 73);
            this.txtBxSecondNum.Name = "txtBxSecondNum";
            this.txtBxSecondNum.Size = new System.Drawing.Size(100, 20);
            this.txtBxSecondNum.TabIndex = 2;
            // 
            // txtBxResult
            // 
            this.txtBxResult.Location = new System.Drawing.Point(471, 73);
            this.txtBxResult.Name = "txtBxResult";
            this.txtBxResult.Size = new System.Drawing.Size(100, 20);
            this.txtBxResult.TabIndex = 3;
            // 
            // lblSecondNum
            // 
            this.lblSecondNum.AutoSize = true;
            this.lblSecondNum.Location = new System.Drawing.Point(299, 57);
            this.lblSecondNum.Name = "lblSecondNum";
            this.lblSecondNum.Size = new System.Drawing.Size(84, 13);
            this.lblSecondNum.TabIndex = 4;
            this.lblSecondNum.Text = "Second Number";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(468, 57);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(37, 13);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "Result";
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(212, 29);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(40, 40);
            this.btnMultiply.TabIndex = 6;
            this.btnMultiply.Text = "X";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(212, 84);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(40, 40);
            this.btnDivide.TabIndex = 7;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // FrmMultDivide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 172);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblSecondNum);
            this.Controls.Add(this.txtBxResult);
            this.Controls.Add(this.txtBxSecondNum);
            this.Controls.Add(this.txtBxFirstNum);
            this.Controls.Add(this.lblFirstNum);
            this.Name = "FrmMultDivide";
            this.Text = "Multiplying and Dividing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstNum;
        private System.Windows.Forms.TextBox txtBxFirstNum;
        private System.Windows.Forms.TextBox txtBxSecondNum;
        private System.Windows.Forms.TextBox txtBxResult;
        private System.Windows.Forms.Label lblSecondNum;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDivide;
    }
}