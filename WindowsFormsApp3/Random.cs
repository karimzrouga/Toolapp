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
    public partial class Random : Form
    {
        
        public Random()
        {
            InitializeComponent();
            this.Text = "Random";
            label1.MaximumSize = new Size(500, 400);
            label1.AutoSize = true;
            this.MaximizeBox = false;
        }
        private async void generate(String ch)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("http://numbersapi.com"+ch),
 
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                Console.WriteLine(body);
                label1.Text = body;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            generate("/random/trivia");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            generate("/random/year");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            generate("/random/math");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            generate("/random/date");

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
