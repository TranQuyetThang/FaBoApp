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
using System.Threading.Tasks;
using System.Threading;

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
            List<string> allPost = new List<string>();
            List<string> postIds = new List<string>();
            
            int year_num         = 2012;
            
            while (year_num < 2017)
            {
                string start_year = year_num.ToString() + "-01-01";
                string end_year   = (year_num + 1).ToString() + "-01-01";
                Thread.Sleep(1000);
                postIds = FBUtils.GetFanpageFeed("beatvn.jsc", start_year, end_year);
                
                int offset_current = 0;
                while (postIds.Count() != 0)
                {
                    allPost.AddRange(postIds);
                    offset_current = offset_current + 100;
                    Thread.Sleep(1000);
                    postIds = FBUtils.GetFanpageFeed("beatvn.jsc", start_year, end_year, 100, offset_current);
                }
                
                year_num = year_num + 1;
                
            }

            int counter = 0;
            foreach (var postId in allPost)
            {
                listViewPosts.Items.Add(postId);
                counter++;
            }
            listViewPosts.Items.Add(counter.ToString());

			/*GetAccessTokenFromCode("851310914988555", "7ae8be1bd8f67826a3e654c6de3809a5", "https%3A%2F%2Fwww.smobgame.com");
			string name_fanpage = textBox1.Text;
			string info = FBUtils.GetFanpageInfo(name_fanpage);
			dynamic jsonInfo = JsonConvert.DeserializeObject(info);
			Console.WriteLine("jsonInfo = " + info);*/
		}

		private void listViewPosts_Resize(object sender, EventArgs e)
		{
			listViewPosts.Columns[0].Width = listViewPosts.Width;
		}

	}
}
