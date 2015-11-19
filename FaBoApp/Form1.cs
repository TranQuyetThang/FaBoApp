﻿using System;
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
using System.Runtime.InteropServices;

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
			string input = textBox1.Text.Trim();
			if (String.IsNullOrWhiteSpace(input)) {
				MessageBox.Show("Hãy nhập id hoặc tên của fanpage");
				return;
			}
			btnStart.Text = "Running...";
			btnStart.Enabled = false;
			var thread = new Thread(() => {
				List<string> postIds = new List<string>();
				List<string> comments = new List<string>();
				List<string> emails = new List<string>();
				int year_num = 2012;

				while (year_num < 2017) {
					string start_year = year_num.ToString() + "-01-01";
					string end_year = (year_num + 1).ToString() + "-01-01";

					List<string> tmpList;
					int offset = 0;
					do {
						Console.WriteLine("GetFanpageFeed: from = " + year_num + "; to = " + (year_num + 1) + "; offset = " + offset);
						tmpList = FBUtils.GetFanpageFeed(input, start_year, end_year, offset);
						if (offset == 0 && (tmpList == null || tmpList.All(x => string.IsNullOrWhiteSpace(x)))) {
							break;
						}
						postIds.AddRange(tmpList);
						if (tmpList.Count != 0) {
							var items = new ListViewItem[tmpList.Count];
							for (int i = 0; i < tmpList.Count; ++i) {
								items[i] = new ListViewItem(tmpList[i]);
							}
							this.Invoke(new Action(() => listViewPosts.Items.AddRange(items)));
							this.Invoke(new Action(() => lblCountPosts.Text = "Count: " + listViewPosts.Items.Count + " posts"));
						}
						offset += 100;
						Thread.Sleep(1010);
					} while (tmpList.Count() == 100);

					year_num = year_num + 1;
				}

				for (var i = 0; i < postIds.Count; i++) {
					var postId = postIds[i];
					//this.Invoke(new Action<string>((value) => listViewPosts.Items.Add(value)), postId);
					int offset = 0;
					List<string> tmpList;
					do {
						Console.WriteLine("GetPostCommens: postId = " + postId + "; offset = " + offset + " (" + i + "/" + postIds.Count + ")");
						tmpList = FBUtils.GetPostCommens(postId, offset);
						comments.AddRange(tmpList);
						foreach (var message in tmpList) {
							List<string> emailExtract = ContentUtils.ExtractEmails(message);
							var items = new ListViewItem[emailExtract.Count];
							for (int j = 0; j < emailExtract.Count; ++j) {
								emails.Add(emailExtract[j]);
								items[j] = new ListViewItem(emailExtract[j]);
							}
							this.Invoke(new Action(() => listViewEmails.Items.AddRange(items)));
							this.Invoke(new Action(() => lblCountEmails.Text = "Count: " + listViewEmails.Items.Count + " emails / " + comments.Count + " comments extracted"));
						}
						offset += 1000;
						Thread.Sleep(1010);
					} while (tmpList.Count() == 1000);
				}
				/*GetAccessTokenFromCode("851310914988555", "7ae8be1bd8f67826a3e654c6de3809a5", "https%3A%2F%2Fwww.smobgame.com");
				string name_fanpage = textBox1.Text;
				string info = FBUtils.GetFanpageInfo(name_fanpage);
				dynamic jsonInfo = JsonConvert.DeserializeObject(info);
				Console.WriteLine("jsonInfo = " + info);*/
				if (btnStart.InvokeRequired) {
					btnStart.Invoke(new MethodInvoker(delegate {
						btnStart.Enabled = true;
						btnStart.Text = "Start";
					}));
				}
			});
			thread.Start();

			//var thread = new Thread(() =>
			//{
			//    List<string> commentPost = new List<string>();
			//    commentPost = FBUtils.GetCommentPost(input);
			//    foreach (var message in commentPost)
			//    {
			//        this.Invoke(new Action<string>((value) => listViewPosts.Items.Add(value)), message);
			//        List<string> emailExtract = ContentUtils.ExtractEmails(message);
			//        foreach (var email in emailExtract)
			//        {
			//            this.Invoke(new Action<string>((value) => listViewPosts.Items.Add(value)), "là:"+email);
			//        }
			//    }
			//    this.Invoke(new Action<string>((value) => listViewPosts.Items.Add(value)), commentPost.Count.ToString());

			//    /*GetAccessTokenFromCode("851310914988555", "7ae8be1bd8f67826a3e654c6de3809a5", "https%3A%2F%2Fwww.smobgame.com");
			//    string name_fanpage = textBox1.Text;
			//    string info = FBUtils.GetFanpageInfo(name_fanpage);
			//    dynamic jsonInfo = JsonConvert.DeserializeObject(info);
			//    Console.WriteLine("jsonInfo = " + info);*/
			//    if (btnStart.InvokeRequired)
			//    {
			//        btnStart.Invoke(new MethodInvoker(delegate
			//        {
			//            btnStart.Enabled = true;
			//            btnStart.Text = "Start";
			//        }));
			//    }
			//});
			//thread.Start();
			//268192336643737

		}

		private void listViewPosts_Resize(object sender, EventArgs e)
		{
			listViewPosts.Columns[0].Width = listViewPosts.Width;
		}

	}
}
