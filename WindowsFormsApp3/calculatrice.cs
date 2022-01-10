using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class calculatrice : Form
    {
        double FirstNumber;
        string Operation;
        public calculatrice()
        {
            InitializeComponent();
            this.Text = "Calculatrice";
            textBox1.ReadOnly=true;
            this.MaximizeBox = false;


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void calculatrice_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" && textBox1.Text != null)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void buttonplus_Click(object sender, EventArgs e)
        {
            try
            {
                FirstNumber = double.Parse(textBox1.Text);
                textBox1.Text = "0";
                Operation = "+";
            }
            catch(Exception)
            {

            }
           
        }

        private void buttonmoins_Click(object sender, EventArgs e)
        {
            try
            {
                FirstNumber = double.Parse(textBox1.Text);
                textBox1.Text = "0";
                Operation = "-";
            }
            catch (Exception)
            {

            }
          
        
        }

        private void buttonmulti_Click(object sender, EventArgs e)
        {
            try
            {
                FirstNumber = double.Parse(textBox1.Text);
                textBox1.Text = "0";
                Operation = "*";


            }
            catch (Exception)
            {

            }
           
        }
        private void reset(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
        }
        private void buttonbdiv_Click(object sender, EventArgs e)
        {
             FirstNumber = double.Parse(textBox1.Text);
            textBox1.Text = "0";
            Operation = "/";
        }

        private void buttonp_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox1.Text != null)
            {
                textBox1.Text = ".";
            }
            else
            {
                textBox1.Text = textBox1.Text + ".";
            }
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
           if(textBox1.Text.Length!=0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }
       
        private void buttonequal_Click(object sender, EventArgs e)
        {
            try
            {
                resulta();
            }
            catch(Exception)
            {

            }
            
        }


        private void resulta()
        {

            double SecondNumber;
            double Result;

            SecondNumber = Convert.ToDouble(textBox1.Text);

            if (Operation == "+")
            {
                Result = (FirstNumber + SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "-")
            {
                Result = (FirstNumber - SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "*")
            {
                Result = (FirstNumber * SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "/")
            {
                if (SecondNumber == 0)
                {
                    textBox1.Text = "Cannot divide by zero";

                }
                else
                {
                    Result = (FirstNumber / SecondNumber);
                    textBox1.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}


    