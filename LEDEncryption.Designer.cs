namespace LetterTinkering
{
    partial class frmLEDEncryption
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cboColorMult = new System.Windows.Forms.ComboBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblLetter = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblSolution = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox1.Location = new System.Drawing.Point(55, 6);
            this.textBox1.MaxLength = 1;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(20, 20);
            this.textBox1.TabIndex = 0;
            // 
            // cboColorMult
            // 
            this.cboColorMult.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboColorMult.FormattingEnabled = true;
            this.cboColorMult.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Blue",
            "Yellow",
            "Purple",
            "Orange"});
            this.cboColorMult.Location = new System.Drawing.Point(55, 32);
            this.cboColorMult.Name = "cboColorMult";
            this.cboColorMult.Size = new System.Drawing.Size(73, 21);
            this.cboColorMult.TabIndex = 1;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(115, 85);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(13, 13);
            this.lblOutput.TabIndex = 2;
            this.lblOutput.Text = "?";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(15, 59);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(113, 23);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Calculate";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.checkButton);
            // 
            // lblLetter
            // 
            this.lblLetter.AutoSize = true;
            this.lblLetter.Location = new System.Drawing.Point(12, 9);
            this.lblLetter.Name = "lblLetter";
            this.lblLetter.Size = new System.Drawing.Size(37, 13);
            this.lblLetter.TabIndex = 4;
            this.lblLetter.Text = "Letter:";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(12, 35);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(34, 13);
            this.lblColor.TabIndex = 5;
            this.lblColor.Text = "Color:";
            // 
            // lblSolution
            // 
            this.lblSolution.AutoSize = true;
            this.lblSolution.Location = new System.Drawing.Point(12, 85);
            this.lblSolution.Name = "lblSolution";
            this.lblSolution.Size = new System.Drawing.Size(97, 13);
            this.lblSolution.TabIndex = 6;
            this.lblSolution.Text = "Press if diagonal is:";
            // 
            // frmLEDEncryption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(141, 107);
            this.Controls.Add(this.lblSolution);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblLetter);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.cboColorMult);
            this.Controls.Add(this.textBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLEDEncryption";
            this.Text = "LED Encryption";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cboColorMult;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblLetter;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblSolution;
    }
}

