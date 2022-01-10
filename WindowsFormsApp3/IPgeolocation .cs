using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class countryinfo : Form
    {
        public countryinfo()
        {
            InitializeComponent();
            this.Text = "IP Geolocation ";
            label2.MaximumSize = new Size(800, 400);
            label2.AutoSize = true;
            this.MaximizeBox = false;
        }

        public async Task info()
        {
            String url = "https://freegeoip.app/json";
            
                url =url+ "/" + textBox1.Text;
           
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
               var data= body.Split(',');
                String res = "";
                foreach (String element in data)
                {

                    res += element + "\n";


                }

                label2.Text = res;

            }


        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            
            info();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
