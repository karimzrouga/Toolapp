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
    public partial class Form1 : Form
    {
        private ServiceReference1.CalculatorSoapClient cal;
        public Form1()
        {
            InitializeComponent();
            this.Text = "ToolApp";
            this.MaximizeBox = false;
            cal = new ServiceReference1.CalculatorSoapClient();
            button2.FlatStyle = FlatStyle.Flat;
             button2.BackColor = Color.Transparent;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
         
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            calculatrice f2 = new calculatrice();
            f2.ShowDialog(); 
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          Myip f2 = new Myip();
            f2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Jokes jokes = new Jokes ();
            jokes.ShowDialog();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
           countryinfo IPgeolocation = new  countryinfo();
            IPgeolocation.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 country = new Form2();
            country.ShowDialog();
        
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            randompict rnd = new randompict();
            rnd.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            jokesv2 jok = new jokesv2();
            jok.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Random f3 = new Random();
            f3.ShowDialog();
        }
    }
}
