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
    public partial class Jokes : Form
    {
      
        public Jokes()
        {
            InitializeComponent();
            this.Text = "Jokes";
            label3.MaximumSize = new Size(700, 200);
            label3.AutoSize = true;
            getcategories();
            this.MaximizeBox = false;
        }

        private async void getcategories()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://api.chucknorris.io/jokes/categories")

            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                body=  body.Replace("\"", "");
                body = body.Replace("]", "");
                body = body.Replace("[", "");
                var categories = body.ToString().Split(',');
               
                DomainUpDown.DomainUpDownItemCollection items = this.domainUpDown1.Items;
                foreach (String element in categories)
                {
                   
                    items.Add(element);
                    
                    
                }
                domainUpDown1.Items.Add(items);


            }

        }
        private async void generateJokes(String categ)
        {
            if (categ!="")
            {

           
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://api.chucknorris.io/jokes/random?category="+categ)

            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();

                int index = body.ToString().IndexOf("value");
                body = body.Replace("}", "");
                label3.Text =  body.Substring(index + 7);
            }
            }
            else
            {
                label3.Text = "Choose Categorie";
            }

        }
        private async void RandomgenerateJokes()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://api.chucknorris.io/jokes/random")
   
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
              
              int index = body.ToString().IndexOf("value");

                body = body.Replace("}", "");
                label3.Text = body.Substring(index+7);
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void button1_Click(object sender, EventArgs e)
        {

            RandomgenerateJokes();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Covid_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            generateJokes(domainUpDown1.Text);
        }
    }
}
