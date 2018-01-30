
/**
* 25 Jan 18
* CSC 153
* Christopher Lee
* Card Identifier
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

namespace M1HW2_Lee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cardOnePictureBox_Click(object sender, EventArgs e)
        {
            numberTextLabel.Text = "ONE"; 
        }

        private void cardTwoPictureBox_Click(object sender, EventArgs e)
        {
            numberTextLabel.Text = "TWO";
        }

        private void cardThreePictureBox_Click(object sender, EventArgs e)
        {
            numberTextLabel.Text = "THREE";
        }

        private void cardFourPictureBox_Click(object sender, EventArgs e)
        {
            numberTextLabel.Text = "FOUR";
        }

        private void cardFivePictureBox_Click(object sender, EventArgs e)
        {
            numberTextLabel.Text = "FIVE";
        }
    }
}
