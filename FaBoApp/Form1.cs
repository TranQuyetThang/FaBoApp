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
            btnStart.Text = "Running...";
            btnStart.Enabled = false;
            string input = textBox1.Text;
            if(input.Trim().CompareTo("") == 0){
                MessageBox.Show("Hãy nhập id hoặc tên của fanpage");
                textBox1.Focus();
                btnStart.Text = "Start";
                btnStart.Enabled = true;
                return;
            }
            //var thread = new Thread(() => {
            //    List<string> postIds = new List<string>();
            //    int year_num = 2012;

            //    while (year_num < 2017)
            //    {
            //        string start_year = year_num.ToString() + "-01-01";
            //        string end_year = (year_num + 1).ToString() + "-01-01";

            //        List<string> tmpList;
            //        int offset_current = 0;
            //        do {
            //            tmpList = FBUtils.GetFanpageFeed(input, start_year, end_year, 100, offset_current);
            //            if (offset_current == 0 && (tmpList == null || tmpList.All(x => string.IsNullOrWhiteSpace(x))))
            //            {
            //                break;
            //            }
            //            postIds.AddRange(tmpList);
            //            offset_current = offset_current + 100;
            //            Thread.Sleep(1000);
            //        } while (tmpList.Count() != 0);

            //        year_num = year_num + 1;

            //    }
            //    foreach (var postId in postIds)
            //    {
            //        this.Invoke(new Action<string>((value) => listViewPosts.Items.Add(value)), postId);
            //    }
            //    this.Invoke(new Action<string>((value) => listViewPosts.Items.Add(value)), postIds.Count.ToString());

            //    /*GetAccessTokenFromCode("851310914988555", "7ae8be1bd8f67826a3e654c6de3809a5", "https%3A%2F%2Fwww.smobgame.com");
            //    string name_fanpage = textBox1.Text;
            //    string info = FBUtils.GetFanpageInfo(name_fanpage);
            //    dynamic jsonInfo = JsonConvert.DeserializeObject(info);
            //    Console.WriteLine("jsonInfo = " + info);*/
            //    if (btnStart.InvokeRequired)
            //    {
            //        btnStart.Invoke(new MethodInvoker(delegate {
            //            btnStart.Enabled = true;
            //            btnStart.Text = "Start";
            //        }));
            //    }
            //});
            //thread.Start();

            var thread = new Thread(() =>
            {
                List<string> commentPost = new List<string>();
                commentPost = FBUtils.GetCommentPost(input);
                foreach (var message in commentPost)
                {
                    this.Invoke(new Action<string>((value) => listViewPosts.Items.Add(value)), message);
                    List<string> emailExtract = ContentUtils.ExtractEmails(message);
                    foreach (var email in emailExtract)
                    {
                        this.Invoke(new Action<string>((value) => listViewPosts.Items.Add(value)), "là:"+email);
                    }
                }
                this.Invoke(new Action<string>((value) => listViewPosts.Items.Add(value)), commentPost.Count.ToString());

                /*GetAccessTokenFromCode("851310914988555", "7ae8be1bd8f67826a3e654c6de3809a5", "https%3A%2F%2Fwww.smobgame.com");
                string name_fanpage = textBox1.Text;
                string info = FBUtils.GetFanpageInfo(name_fanpage);
                dynamic jsonInfo = JsonConvert.DeserializeObject(info);
                Console.WriteLine("jsonInfo = " + info);*/
                if (btnStart.InvokeRequired)
                {
                    btnStart.Invoke(new MethodInvoker(delegate
                    {
                        btnStart.Enabled = true;
                        btnStart.Text = "Start";
                    }));
                }
            });
            thread.Start();
            //268192336643737

		}

		private void listViewPosts_Resize(object sender, EventArgs e)
		{
			listViewPosts.Columns[0].Width = listViewPosts.Width;
		}

	}
}
