using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        public Form2()
        {

            InitializeComponent();
            this.Text = "RestCountriees";
            WindowState = FormWindowState.Maximized;
            textBox2.Height = 650;
            textBox2.Multiline = true;
         
            textBox2.ScrollBars = ScrollBars.Vertical;
          
            textBox2.AcceptsReturn = true;
          
            textBox2.AcceptsTab = true;
           
            textBox2.WordWrap = true;
        }
        public async Task info()
        {
            String url = "https://restcountries.com/v3.1/name";
          
            url += textBox1.Text.Length == 0 ? "/tunisia" : '/' + textBox1.Text;
           
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(url),

            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                body = body.Replace("}", "");
                body = body.Replace("{", "");
                body = body.Replace("\"", "");
                var data = body.Split(',');
                String res = "";
                foreach (String element in data)
                {

                    res += element + "\n";


                }
               webBrowser1.Navigate(data[data.Length - 6].Substring(4));
                textBox2.Text = res;

            }


        }
       

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            info();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
