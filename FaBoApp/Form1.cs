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
using Facebook;
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
			List<string> postIds = FBUtils.GetFanpageFeed("haitacmobi");
			foreach (var postId in postIds) {
				listViewPosts.Items.Add(postId);
			}
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
