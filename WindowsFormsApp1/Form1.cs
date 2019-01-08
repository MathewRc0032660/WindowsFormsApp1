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



    }
}





