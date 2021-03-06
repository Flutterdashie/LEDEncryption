﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LetterTinkering
{
    public partial class frmLEDEncryption : Form
    {
        public frmLEDEncryption()
        {
            InitializeComponent();
        }

        private void checkButton(object sender, EventArgs e)
        {
            if ((textBox1.Text == string.Empty))
            {
                lblOutput.Text = "?";
                return;
            }
            if (!Char.IsLetter(textBox1.Text.ToCharArray().First()))
            {
                lblOutput.Text = "?";
                return;
            }

            if (cboColorMult.SelectedIndex == -1)
            {
                cboColorMult.SelectedIndex = 0;
            }
            char inputChar = textBox1.Text.ToCharArray().First();
            int inputValue = (inputChar - 65);
            int multiplier = (cboColorMult.SelectedIndex + 2);
            char outputValue = (char)(((inputValue * multiplier) % 26) + 65);
            lblOutput.Text = outputValue.ToString();
        }

        private void textBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
