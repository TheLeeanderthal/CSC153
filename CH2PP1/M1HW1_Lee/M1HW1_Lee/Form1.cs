/**
* 25 Jan 18
* CSC 153
* Christopher Lee
* Latin Translator
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

namespace M1HW1_Lee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sinisterButton_Click(object sender, EventArgs e)
        {
            translationLabel.Text = "left";
        }

        private void dexterButton_Click(object sender, EventArgs e)
        {
            translationLabel.Text = "right";
        }

        private void mediumButton_Click(object sender, EventArgs e)
        {
            translationLabel.Text = "center";
        }
    }
}
