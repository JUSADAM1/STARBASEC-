using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace starbase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // When button is click(generate code button) 
            // The curly braces will run
        private void button1_Click(object sender, EventArgs e)
        {
            // lower the random generator can go
            int mini = 0;
            // The highest the random number generator can go
            int maxy = 1000;
            // Gives a random number between the mini and the max
            int randNumberBase10 = RandomNumber(mini, maxy);
            // converts the number to base 2
            string label_base2 = Convert.ToString(value: randNumberBase10, toBase: 2);
            //converts to the base 16
            string label_base16 = Convert.ToString(value: randNumberBase10, toBase: 16);
            // Displays the number/character  in the labels
            // technically where they are going to print
            label_DisplayBase10.Text = randNumberBase10.ToString();
            Label_base_16.Text = label_base16;
            Label_display_base_2.Text = label_base2;

        } 
        public int RandomNumber(int mini, int maxy)
        {
            // Picks the  Random Number
            Random random = new Random();
            // Gives/returns you a random number
            return random.Next(mini, maxy);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
