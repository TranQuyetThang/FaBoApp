using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaBoApp
{
	class FBUtils
	{
		private const string APP_ID = "851310914988555";
		private const string APP_SECRET = "7ae8be1bd8f67826a3e654c6de3809a5";
		private static string APP_TOKEN;

		private static string GetAppAcessToken(string appId, string appSecret)
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
			string token = GetAppAcessToken(APP_ID, APP_SECRET);
			string url = "https://graph.facebook.com/" + fanpageName + "?" + token;
			return NetUtils.Get(url);
		}

		public static List<string> GetFanpageFeed(string fanpageName) {
			string token = GetAppAcessToken(APP_ID, APP_SECRET);
			string url = "https://graph.facebook.com/" + fanpageName + "/feed?" + token;
			string result = NetUtils.Get(url);
			dynamic jsonFeed = JsonConvert.DeserializeObject(result);
			// TODO
			return null;
		}

	}
}
