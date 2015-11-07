using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FaBoApp
{
	public partial class FacebookLoginForm : Form
	{
		private string REDIRECT_URL = "https://www.smobgame.com";
		public string UserAccessToken { get; set; } 

		public FacebookLoginForm(string appId)
		{
			// https%3A%2F%2Fwww.smobgame.com
			// http%3A%2F%2Fwww.facebook.com%2Fconnect%2Flogin_success.html
			InitializeComponent();
			webBrowser.Navigate("https://www.facebook.com/dialog/oauth?client_id=" + appId + "&redirect_uri=" + REDIRECT_URL + "&type=user_agent&display=popup&grant_type=client_credentials&response_type=token");
		}

		private void webBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
		{
			if (webBrowser.Url.AbsoluteUri.StartsWith(REDIRECT_URL)) {
				string[] x = webBrowser.Url.AbsoluteUri.Split('#');
				string query = x[x.Length - 1];
				Console.WriteLine(query);
				string[] queryParts = query.Split('&');
				foreach (var part in queryParts) {
					Console.WriteLine(part);
					string[] keyValue = part.Split('=');
					if (keyValue[0].Equals("access_token")) {
						UserAccessToken = keyValue[1];
						Hide();
						return;
					}
				}
				Hide();
			}
		}

	}
}
