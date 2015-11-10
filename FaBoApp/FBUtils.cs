using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaBoApp
{
	class FBUtils
	{
		private const string APP_ID = "851310914988555";
		private const string APP_SECRET = "7ae8be1bd8f67826a3e654c6de3809a5";
		private static string USER_TOKEN;
		private static string APP_TOKEN;

		private static string GetUserAccessToken(string appId, string appSecret)
		{
            //if (!IsValidUserAccessToken(USER_TOKEN))
            //{
            //    FacebookLoginForm form = new FacebookLoginForm(appId);
            //    form.ShowDialog();
            //    USER_TOKEN = form.UserAccessToken;
            //}

            return USER_TOKEN = appId+"|"+appSecret;
		}

		private static bool IsValidUserAccessToken(string accessToken) {
			if (accessToken == null) return false;
			try {
				string result = NetUtils.Get("https://graph.facebook.com/me?access_token=" + accessToken);
				dynamic json = JsonConvert.DeserializeObject(result);
				return json["id"] != null;
			} catch {
				return false;
			}
			//string error = json["id"];
			//return true;
		}

		private static string GetAppAccessToken(string appId, string appSecret)
		{
			if (APP_TOKEN == null) {
				String url = "https://graph.facebook.com/oauth/access_token?" +
							"client_id=" + appId +
							"&client_secret=" + appSecret +
							"&grant_type=client_credentials";
				APP_TOKEN = NetUtils.Get(url);
			}
			return APP_TOKEN;
		}

		public static string GetFanpageInfo(string fanpageName)
		{
			string token = GetAppAccessToken(APP_ID, APP_SECRET);
			string url = "https://graph.facebook.com/" + fanpageName + "?" + token;
			return NetUtils.Get(url);
		}

        public static List<string> GetFanpageFeed(string fanpageName, string since_year = null, string until_year = null,int limit_num =100, int offset_num = 0)
		{
            List<string> feed = new List<string>();
			string token = GetUserAccessToken(APP_ID, APP_SECRET);
            string url_page = "https://graph.facebook.com/" + fanpageName + "/feed";
            // param of api
            if (since_year != null)
                url_page = url_page + "?since=" + since_year;
            if (until_year != null)
                url_page = url_page + "&until=" + until_year;
            if (since_year == null && until_year == null)
                url_page = url_page + "?limit=" + limit_num + "&offset=" + offset_num + "&access_token=" + token;
            else
                url_page = url_page + "&limit=" + limit_num + "&offset=" + offset_num + "&access_token=" + token;

            string result = NetUtils.Get(url_page);

            var json = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(result);
            foreach (var post in json["data"])
            {
                feed.Add((string)post["id"]);
			}
			return feed;
		}

	}
}
