using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace WindowsFormsApp3
{
   
    public partial class Myip : Form
    {
        private string ip = "";
        public Myip()
        {
            InitializeComponent();
            this.Text = "My IP";
            this.MaximizeBox = false;
            _ = findipAsync();
        }
      
        public async Task findipAsync()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://api.ipify.org?format=json"),
     
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
               ip = label1.Text+ body.ToString();
              
                label1.Text = ip.Replace("{\"ip\":\"", "").Replace("\"}", "");
              
            }



        }
        private void GeoLocation_Load(object sender, EventArgs e)
        {
            if (ip!="")
            {
                _ = this.findipAsync();
            }
        }
           

       
      
        private void button1_Click(object sender, EventArgs e)
        {
            
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
