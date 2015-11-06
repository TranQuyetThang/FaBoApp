using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FaBoApp
{
	class NetUtils
	{
		public static string Get(string url) {
			StreamReader reader = null;
			Stream dataStream = null;
			WebResponse response = null;
			try {
				WebRequest request = WebRequest.Create(url);
				request.Method = "GET";

				response = request.GetResponse();

				dataStream = response.GetResponseStream();
				// Open the stream using a StreamReader for easy access.
				reader = new StreamReader(dataStream);
				// Read the content.
				string responseContent = reader.ReadToEnd();

				return responseContent;
			} catch (Exception e) {
				System.Console.Write(e.Message);
				// TODO handle exception
				return null;
			} finally {
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
