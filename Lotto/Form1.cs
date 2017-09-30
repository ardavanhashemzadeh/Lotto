using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lotto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/ardavan-hashemzadeh-20031065");
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            labelOneDollar.Text = "$" + numericUpDown1.Value;
            labelTwoDollars.Text = "$" + 2 * numericUpDown2.Value;
            labelThreeDollars.Text = "$" + 3 * numericUpDown3.Value;
            labelFiveDollars.Text = "$" + 5 * numericUpDown4.Value;
            labelTenDollars.Text = "$" + 10 * numericUpDown5.Value;
            labelTwentyDollars.Text = "$" + 20 * numericUpDown6.Value;
            labelTwentyFiveDollars.Text = "$" + 25 * numericUpDown7.Value;
            labelThirtyDollars.Text = "$" + 30 * numericUpDown8.Value;
            labelCount.Text = (
                numericUpDown1.Value +
                numericUpDown2.Value +
                numericUpDown3.Value +
                numericUpDown4.Value +
                numericUpDown5.Value +
                numericUpDown6.Value +
                numericUpDown7.Value +
                numericUpDown8.Value).ToString();
            labelSum.Text = "$" + (
                numericUpDown1.Value
                + 2 * numericUpDown2.Value
                + 3 * numericUpDown3.Value
                + 5 * numericUpDown4.Value
                + 10 * numericUpDown5.Value
                + 20 * numericUpDown6.Value
                + 25 * numericUpDown7.Value
                + 30 * numericUpDown8.Value).ToString();
        }

        private void num_Enter(object sender, EventArgs e)
        {
            NumericUpDown box = sender as NumericUpDown;
            box.Select();
            box.Select(0, box.Value.ToString().Length);
        }
    }
}
