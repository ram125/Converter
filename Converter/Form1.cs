using System;

namespace Converter
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
                int value = Int32.Parse(textBox1.Text);
                Calculator firstconverter = new Calculator(0.51);
                textBox2.Text = ($"You have {Math.Round(firstconverter.convertEUR(value), 2).ToString()} BGN");
            }
            catch (Exception)
            {
                MessageBox.Show("please enter valid value (number)");
            }
        }
    }
    class Calculator
    {
        private double rateBGNtoEUR; //1 bgn = 0.51 eur
        public Calculator(double rate)
        {
            this.rateBGNtoEUR = rate;
        }
        public double convertBGN(double insertcurrency)
        {
            return insertcurrency * rateBGNtoEUR;
        }
        public double convertEUR(double insertcurrency)
        {
            return insertcurrency / rateBGNtoEUR;
        }
    }
}