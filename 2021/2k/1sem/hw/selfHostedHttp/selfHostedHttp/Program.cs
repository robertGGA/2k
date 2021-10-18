using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace selfHostedHttp
{
	class Program
	{

		public static HttpListener listener;
		private static bool isRun = true;
		private static string url = "http://localhost:8080/";
		
		static void Main()=>Listen().Wait();

		private static async Task Listen()
		{
			listener = new HttpListener();
			listener.Prefixes.Add(url);
			
			listener.Start();
			Console.WriteLine("Ожидание подключений...");
             
			while(isRun)
			{
				HttpListenerContext context = await listener.GetContextAsync();
				HttpListenerRequest request = context.Request;
				HttpListenerResponse response = context.Response;
				String responseString = "";
				byte[] buffer = Array.Empty<byte>();
				String mime = "";

				switch (request.RawUrl)
				{
					case "/hi":
						buffer = new WelcomePage().CreatePage();
						context.Response.ContentType = "text/html";
						response.ContentType = "text/HTML";
						Console.WriteLine("HiPage");
						break;
					case "/about":
						buffer = new AboutPage().CreateAboutPage();
						Console.WriteLine(context.Response.ContentType);
						response.ContentType = "text/HTML";
						break;
					case "/photos":
						buffer = new PhotosPage().CreatePhotosPage();
						context.Response.ContentType = "text/html";
						break;
					case "/contacts":
						buffer = new ContactsPage().CreateContactsPage();
						context.Response.ContentType = "text/html";
						break;
					case "/whyitis":
						buffer = new WhyItisPage().CreateWhyItisPage();
						context.Response.ContentType = "text/html";
						break;
					default:
						if (request.RawUrl.ToLower().Contains(".css")) {
							Console.WriteLine("css");
							context.Response.ContentType = "text/html";
						}
						break;
				}

				Console.WriteLine("connected");

				Console.WriteLine(request.Url);
				
				// byte[] buffer = System.Text.Encoding.UTF8.GetBytes(responseString);
				Console.WriteLine("URL: {0}", context.Request.Url.OriginalString);
				Console.WriteLine("Raw URL: {0}", context.Request.RawUrl);
				//byte[] buffer = File.ReadAllBytes("." + context.Request.RawUrl.Replace("%20", " "));
				//byte[] buffer = new WelcomePage().CreatePage();
				
				response.ContentLength64 = buffer.Length;
				Stream output = response.OutputStream;
				output.Write(buffer, 0, buffer.Length);
				output.Close();
			}
		}

		public static string UrlCreator(string url, string red)
		{
			return url + red;
		}
	}
}
