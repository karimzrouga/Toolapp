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
    public partial class jokesv2 : Form
    {
        public jokesv2()
        {
            InitializeComponent();
            this.Text = "Jokes v2";
            label1.MaximumSize = new Size(500, 400);
            label1.AutoSize = true;
            this.MaximizeBox = false;
        }
        private async void generateJokes( string fn , string ln)
        {
            if (fn.Length >0 && ln.Length>0)
            {

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("http://api.icndb.com/jokes/random?firstName=" + fn + "&lastName=" + ln)

            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                body = body.Substring(body.IndexOf("joke"));
                body = body.Replace("}", "");
                body = body.Replace("{", "");
                body = body.Replace("\"", "");
                body =body.Remove(body.IndexOf("categories:"), body.Substring(body.IndexOf("categories:")).Length);
                label1.Text =body ;
            }

            }else
            {
                label1.Text = "saisir your first and last name";
            }

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String firstname = textBox1.Text;
            String lastname = textBox2.Text;
            generateJokes(firstname, lastname);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
