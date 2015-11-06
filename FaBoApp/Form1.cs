using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Text;
using Newtonsoft;
using Newtonsoft.Json;
namespace FaBoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs args)
        {
            string name_fanpage = textBox1.Text;

            StreamReader reader = null;
            Stream dataStream = null;
            WebResponse response = null;
            Newtonsoft.Json.JsonReader ns = null;
            try
            {
                string url = "https://graph.facebook.com/" + name_fanpage + "?access_token=851310914988555|7ae8be1bd8f67826a3e654c6de3809a5";
                WebRequest request = WebRequest.Create(url);
                request.Method = "GET";

                response = request.GetResponse();
                // Display the status.
                Console.WriteLine(((HttpWebResponse)response).StatusDescription);
                // Get the stream containing content returned by the server.
                dataStream = response.GetResponseStream();
                // Open the stream using a StreamReader for easy access.
                reader = new StreamReader(dataStream);
                // Read the content.
                string responseFromServer = reader.ReadToEnd();
                // Display the content.
                dynamic stuff = JsonConvert.DeserializeObject(responseFromServer);
                Console.WriteLine(stuff["name"]);
                label2.Text = stuff["id"];
                // Clean up the streams.
                reader.Close();
                dataStream.Close();
                response.Close();
            }
            catch (Exception e)
            {
                System.Console.Write(e.Message);
            }
            finally {
                if (reader != null) {
                    reader.Close();
                }
                if (dataStream != null) {
                    dataStream.Close();
                }
                if (response != null) {
                    response.Close();
                }
                
            }
        }
    }
}
