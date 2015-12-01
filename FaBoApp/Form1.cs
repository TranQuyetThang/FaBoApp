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
using Newtonsoft;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace FaBoApp
{
	public partial class Form1 : Form
	{

		public Form1()
		{
			string email = FBUtils.LoginAndGetUserEmail();
			if (String.IsNullOrWhiteSpace(email) || !IsAuthenticatedEmail(email)) {
				MessageBox.Show("Email không hợp lệ. Ra chỗ khác chơi!!!");
				Environment.Exit(0);
			}
			InitializeComponent();
		}

		private void btnStartFanpage_Click(object sender, EventArgs args)
		{
			string input = txtFanpage.Text.Trim();
			if (String.IsNullOrWhiteSpace(input)) {
				MessageBox.Show("Hãy nhập id hoặc tên của fanpage");
				return;
			}
			btnStartFanpage.Text = "Running...";
			btnStartFanpage.Enabled = false;
			txtFanpage.Enabled = false;
			var thread = new Thread(() => {
				List<string> postIds = new List<string>();
				List<string> comments = new List<string>();
				List<string> emails = new List<string>();
				int year_num = 2012;

				while (year_num < 2017) {
					string start_year = year_num.ToString() + "-01-01";
					string end_year = (year_num + 1).ToString() + "-01-01";

					List<string> tmpList = new List<string>();
					List<string> tmpList2 = new List<string>();
					int offset = 0;
					do {
						Console.WriteLine("GetFanpageFeed: from = " + year_num + "; to = " + (year_num + 1) + "; offset = " + offset);
						FBUtils.GetAllFanpage(ref tmpList, ref tmpList2, input, start_year, end_year, offset);
						//tmpList = FBUtils.GetFanpageFeed(input, start_year, end_year, offset);
						if (offset == 0 && (tmpList == null || tmpList.All(x => string.IsNullOrWhiteSpace(x)))) {
							break;
						}
						postIds.AddRange(tmpList);
						if (tmpList.Count != 0) {
							var items = new ListViewItem[tmpList.Count];
							for (int i = 0; i < tmpList.Count; ++i) {
								items[i] = new ListViewItem(tmpList[i]);
							}
							foreach (var message1 in tmpList2) {
								List<string> emailExtract1 = new List<string>();
								if (message1 != null)
									emailExtract1 = ContentUtils.ExtractEmails(message1);
								var items1 = new ListViewItem[emailExtract1.Count];
								for (int j = 0; j < emailExtract1.Count; ++j) {
									emails.Add(emailExtract1[j]);
									items1[j] = new ListViewItem(emailExtract1[j]);
								}
								this.Invoke(new Action(() => listViewEmails.Items.AddRange(items1)));
								this.Invoke(new Action(() => lblCountEmails.Text = "Count: " + listViewEmails.Items.Count + " emails / " + comments.Count + " comments extracted"));

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
				if (btnStartFanpage.InvokeRequired) {
					btnStartFanpage.Invoke(new MethodInvoker(delegate {
						btnStartFanpage.Enabled = true;
						btnStartFanpage.Text = "Start";
						txtFanpage.Enabled = true;
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

		private void listView_KeyDown(object sender, KeyEventArgs e)
		{
			ListView listView = sender as ListView;
			if (listView != null) {
				switch (e.KeyData) {
					case (Keys.A | Keys.Control):
						listView.MultiSelect = true;
						foreach (ListViewItem item in listView.Items) {
							item.Selected = true;
						}
						break;
					case (Keys.C | Keys.Control):
						string clipboard = "";
						foreach (ListViewItem item in listView.Items) {
							if (item.Selected) {
								clipboard += item.Text + "\n";
							}
						}
						if (!String.IsNullOrWhiteSpace(clipboard)) {
							System.Windows.Forms.Clipboard.SetText(clipboard);
						}
						break;
				}
			}
		}

		private void btnStartPost_Click(object sender, EventArgs e)
		{
			string inputPost = txtPost.Text.Trim();
			if (String.IsNullOrWhiteSpace(inputPost)) {
				MessageBox.Show("Hãy nhập id hoặc tên của fanpage");
				return;
			}
			btnStartPost.Text = "Running...";
			btnStartPost.Enabled = false;
			txtPost.Enabled = false;
			webBrowser.Url = FBUtils.GetUriForPostId(inputPost);

			var threadPost = new Thread(() => {
				List<string> commentsPost = new List<string>();
				List<string> emailsPost = new List<string>();

				int offset = 0;
				List<string> tmpList;
				do {
					tmpList = FBUtils.GetPostCommens(inputPost, offset);
					commentsPost.AddRange(tmpList);
					foreach (var message in tmpList) {
						List<string> emailExtract = ContentUtils.ExtractEmails(message);
						var items = new ListViewItem[emailExtract.Count];
						for (int j = 0; j < emailExtract.Count; ++j) {
							emailsPost.Add(emailExtract[j]);
							items[j] = new ListViewItem(emailExtract[j]);
						}
						this.Invoke(new Action(() => listViewPostEmails.Items.AddRange(items)));
						this.Invoke(new Action(() => lblCountEmails2.Text = "Count: " + listViewPostEmails.Items.Count + " emails / " + commentsPost.Count + " comments extracted"));
					}
					offset += 1000;
					Thread.Sleep(1010);
				} while (tmpList.Count() == 1000);

				if (btnStartPost.InvokeRequired) {
					btnStartPost.Invoke(new MethodInvoker(delegate {
						btnStartPost.Enabled = true;
						btnStartPost.Text = "Start";
						txtPost.Enabled = true;
					}));
				}
			});
			threadPost.Start();
		}

		private bool IsAuthenticatedEmail(string email)
		{
			string url = "https://spreadsheets.google.com/tq?&tq=SELECT%20A%20WHERE%20A%20=%20%27" + email + "%27&key=1TY3rwdhQ6yVRJKTPjBis7VtSgKGeWYeCtKs6ZXqJpbo&tqx=out:json";
			string m = NetUtils.Get(url);

			Regex regex = new Regex("google.visualization.Query.setResponse\\((.*)\\);");
			var matches = regex.Match(m);
			string s = matches.Groups[1].ToString();
			var json = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(s);
			List<string> emails = new List<string>();
			try {
				foreach (var r in json["table"]["rows"]) {
					foreach (var c in r["c"]) {
						emails.Add((string)c["v"]);
					}
				}
			} catch { }

			return emails.Contains(email);
		}

		private void tabControl_TabIndexChanged(object sender, EventArgs e)
		{
			switch (tabControl.SelectedIndex) {
				case 0:
					AcceptButton = btnStartFanpage;
					break;
				case 1:
					AcceptButton = btnStartPost;
					break;
			}
		}

        private void txtAbout_TextChanged(object sender, EventArgs e)
        {

        }

	}
}
