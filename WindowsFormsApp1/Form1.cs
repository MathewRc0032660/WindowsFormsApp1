using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // calculates total resistance for 3 resistors in series
            try
            {
                double resistor = double.Parse(textBox1.Text);
                double resistor2 = double.Parse(textBox2.Text);
                double resistor3 = double.Parse(textBox3.Text);
                double answer = resistor + resistor2 + resistor3;
                label2.Text = answer.ToString();
            }

            catch
            {
                MessageBox.Show("check again you idiot");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            // calculates 4 resistors in series
            double resistor = double.Parse(textBox4.Text);
            double resistor2 = double.Parse(textBox5.Text);
            double fraction1 = resistor * resistor2;
            double fraction2 = resistor + resistor2;
            double answer = fraction1 / fraction2;
            label4.Text = answer.ToString();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // calculates 2 resistors in series
            try
            {
                double resistor = double.Parse(textBox6.Text);
                double resistor2 = double.Parse(textBox7.Text);
                double answer = resistor + resistor2;
                label7.Text = answer.ToString();
            }
            catch
            {
                MessageBox.Show("check again you idiot");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // calculates 3 resistors in parralell 
            double resistor = double.Parse(textBox8.Text);
            double resistor2 = double.Parse(textBox9.Text);
            double resistor3 = double.Parse(textBox10.Text);
            double answer = 1.0 / (1.0 / resistor + 1.0 / resistor2 + 1.0 / resistor3);
            label9.Text = answer.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // calculates 4 resistors in series 
            try
            {
                double resistor = double.Parse(textBox11.Text);
                double resistor2 = double.Parse(textBox12.Text);
                double resistor3 = double.Parse(textBox13.Text);
                double resistor4 = double.Parse(textBox14.Text);
                double answer = resistor + resistor2 + resistor3 + resistor4;
                label11.Text = answer.ToString();
            }
            catch
            {

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // calculates 4 resitors in parallel
            double resistor = double.Parse(textBox15.Text);
            double resistor2 = double.Parse(textBox16.Text);
            double resistor3 = double.Parse(textBox17.Text);
            double resistor4 = double.Parse(textBox18.Text);
            double answer = 1.0 / (1.0 / resistor + 1.0 / resistor2 + 1.0 / resistor3 + 1.0 / resistor4);
            label13.Text = answer.ToString();
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        { // calculates 5 resistors in series
            double resistor = double.Parse(textBox19.Text);
            double resistor2 = double.Parse(textBox20.Text);
            double resistor3 = double.Parse(textBox21.Text);
            double resistor4 = double.Parse(textBox22.Text);
            double resistor5 = double.Parse(textBox23.Text);
            double answer = resistor + resistor2 + resistor3 + resistor4 + resistor5;
            label15.Text = answer.ToString();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            // calculates 5 resistors in parallel 
            double resistor = double.Parse(textBox24.Text);
            double resistor2 = double.Parse(textBox25.Text);
            double resistor3 = double.Parse(textBox26.Text);
            double resistor4 = double.Parse(textBox27.Text);
            double resistor5 = double.Parse(textBox28.Text);
            double answer = 1.0 / (1.0 / resistor + 1.0 / resistor2 + 1.0 / resistor3 + 1.0 / resistor4 + 1.0 / resistor5);
            label17.Text = answer.ToString();
        }

        private void tabPage8_Click(object sender, EventArgs e)
        {

        }
    }
}





