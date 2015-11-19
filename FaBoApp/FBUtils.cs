using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FaBoApp
{
	class FBUtils
	{
		//private const string APP_ID = "851310914988555";
		//private const string APP_SECRET = "7ae8be1bd8f67826a3e654c6de3809a5";
		private const string APP_ID = "1658931291050872";
		private const string APP_SECRET = "394b273408aaa39e9910046faf5610c2";
		private static string USER_TOKEN;
		private static string APP_TOKEN;

		private static string GetUserAccessToken(string appId, string appSecret)
		{
			if (!IsValidUserAccessToken(USER_TOKEN)) {
				FacebookLoginForm form = new FacebookLoginForm(appId);
				form.ShowDialog();
				USER_TOKEN = form.UserAccessToken;
			}

			return USER_TOKEN;
		}

		private static bool IsValidUserAccessToken(string accessToken)
		{
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
				//String url = "https://graph.facebook.com/oauth/access_token?" +
				//			"client_id=" + appId +
				//			"&client_secret=" + appSecret +
				//			"&grant_type=client_credentials";
				//APP_TOKEN = NetUtils.Get(url);
				APP_TOKEN = appId + "|" + appSecret;
			}
			return APP_TOKEN;
		}

		public static string GetFanpageInfo(string fanpageName)
		{
			string token = GetAppAccessToken(APP_ID, APP_SECRET);
			string url = "https://graph.facebook.com/" + fanpageName + "?" + token;
			return NetUtils.Get(url);
		}

		public static List<string> GetFanpageFeed(string fanpageName, string since_year = null, string until_year = null, int offset = 0, int limit = 100)
		{
			List<string> feed = new List<string>();
			string token = GetAppAccessToken(APP_ID, APP_SECRET);
			string url_page = "https://graph.facebook.com/" + fanpageName + "/feed?access_token=" + token;
			// param of api
			if (!String.IsNullOrWhiteSpace(since_year))
				url_page += "&since=" + since_year;
			if (!String.IsNullOrWhiteSpace(until_year))
				url_page += "&until=" + until_year;
			url_page += "&offset=" + offset + "&limit=" + limit;

			string result = NetUtils.Get(url_page);
			if (!string.IsNullOrEmpty(result)) {
				var json = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(result);
				foreach (var post in json["data"]) {
					feed.Add((string)post["id"]);
				}
			}

			return feed;
		}

		public static List<string> GetPostCommens(string postId, int offset = 0, int limit = 1000)
		{
			List<string> comments = new List<string>();
			string token = GetAppAccessToken(APP_ID, APP_SECRET);
			string url_api = "https://graph.facebook.com/" + postId + "/comments?access_token=" + token;
			// param of api
			url_api += "&offset=" + offset + "&limit=" + limit;

			string result = NetUtils.Get(url_api);
			if (!string.IsNullOrEmpty(result)) {
				var json = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(result);
				foreach (var comment in json["data"]) {
					comments.Add((string) comment["message"]);
				}
			}

			return comments;
		}

		//public void abc() {
		//List<string> commentAll = new List<string>();
		//	List<string> comment = new List<string>();
		//	string token = GetUserAccessToken(APP_ID, APP_SECRET);
		//	string template_url = "https://graph.facebook.com/" + postId + "/comments";
		//	// param of api


		//	//string result = NetUtils.Get(url_post);
		//	string result = null;
		//	Comment comment1 = new Comment();
		//	//Comment comment1 = JsonConvert.DeserializeObject<Comment>(result);
		//	do {
		//		string url_post = null;
		//		string after = null;
		//		if (comment1 != null && comment1.pagingObj != null && comment1.pagingObj.cursors != null && comment1.pagingObj.cursors.after != null) {
		//			after = comment1.pagingObj.cursors.after;
		//		}
		//		url_post = template_url + "?limit=" + limit;
		//		if (after != null)
		//			url_post = url_post + "&after=" + after;
		//		url_post = url_post + "&access_token=" + token;
		//		result = NetUtils.Get(url_post);
		//		if (!string.IsNullOrEmpty(result)) {
		//			comment1 = JsonConvert.DeserializeObject<Comment>(result);
		//			foreach (DataObj dataObj in comment1.dataObj) {
		//				comment.Add(dataObj.message);
		//			}
		//		}

		//	}
		//	while (comment1 != null && comment1.pagingObj != null && comment1.pagingObj.cursors != null && comment1.pagingObj.cursors.after != null);
		//	Thread.Sleep(time_sleep);

		//	return comment;
		//}

		public class Comment
		{
			/// <summary>
			/// A User's username. eg: "sergiotapia, mrkibbles, matumbo"
			/// </summary>
			[JsonProperty("data")]
			public List<DataObj> dataObj { get; set; }

			/// <summary>
			/// A User's name. eg: "Sergio Tapia, John Cosack, Lucy McMillan"
			/// </summary>
			[JsonProperty("paging")]
			public PagingObj pagingObj { get; set; }
		}

		public class DataObj
		{
			[JsonProperty("created_time")]
			public DateTime created_time { get; set; }
			[JsonProperty("from")]
			public FromObj fromObj { get; set; }
			[JsonProperty("message")]
			public string message { get; set; }
			[JsonProperty("id")]
			public string id { get; set; }
		}

		public class FromObj
		{
			[JsonProperty("name")]
			public string name { get; set; }
			[JsonProperty("id")]
			public string id { get; set; }
		}

		public class PagingObj
		{
			[JsonProperty("cursors")]
			public CursorsObj cursors { get; set; }
			[JsonProperty("next")]
			public string next { get; set; }
			[JsonProperty("previous")]
			public string previous { get; set; }
		}

		public class CursorsObj
		{
			[JsonProperty("before")]
			public string before { get; set; }
			[JsonProperty("after")]
			public string after { get; set; }
		}


	}
}
