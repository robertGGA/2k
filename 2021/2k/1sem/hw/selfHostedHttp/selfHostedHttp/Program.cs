using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace selfHostedHttp
{
	class Program

	{
		
		static void Main(string[] args)
		{
			string url = "http://localhost:8080/";
			HttpListener server = new HttpListener();  // this is the http server
			//server.Prefixes.Add("http://127.0.0.1/");  //we set a listening address here (localhost)
			server.Prefixes.Add("http://localhost:8080/");

			server.Start();   // and start the server

			Console.WriteLine("Server started...");

			while (true)
			{
				HttpListenerContext context = server.GetContext();
				HttpListenerResponse response = context.Response;
				HttpListenerRequest request = context.Request;

				byte[] buffer = Array.Empty<byte>();

				// Console.WriteLine(".." + context.Request.RawUrl.Replace("%20", " "));

				// switch (request.RawUrl)
				// 				{
				// 					case "/hi":
				// 						buffer = new WelcomePage().CreatePage();
				// 						Console.WriteLine("HiPage");
				// 						break;
				// 					case "/about":
				// 						buffer = new AboutPage().CreateAboutPage();
				// 						Console.WriteLine(context.Response.ContentType);
				// 						break;
				// 					case "/photos":
				// 						buffer = new PhotosPage().CreatePhotosPage();
				// 						break;
				// 					case "/contacts":
				// 						buffer = new ContactsPage().CreateContactsPage();
				// 						break;
				// 					case "/whyitis":
				// 						buffer = new WhyItisPage().CreateWhyItisPage();
				// 						break;
				// 				}

				// if (request.RawUrl.Contains("/about"))
				// {
				// 	if (!request.RawUrl.Equals("/about"))
				// 	{
				// 		if (request.Url.ToString().Contains(".css"))
				// 		{
				// 			Console.WriteLine(request.RawUrl.Contains("css") + " contains");
				//
				// 			buffer = new AboutPage().CreateExtraFiles(context);
				// 		}
				// 		else
				// 		{
				// 			Console.WriteLine(request.Url);
				// 			buffer = new AboutPage().CreateAboutPage(context);
				// 		}
				// 	}
				// 	else
				// 	{
				// 		response.ContentType = "text/css";
				// 		response.Redirect(url + "about.html");
				// 	}
				// }

				if (request.RawUrl.Contains("about"))
				{
					buffer = new AboutPage().CreateAboutPage(context, url);
				} else if (request.RawUrl.Contains("contacts"))
				{
					buffer = new ContactsPage().CreateContactsPage(context, url);
				} else if (request.RawUrl.Contains("photos"))
				{
					buffer = new PhotosPage().CreatePhotosPage(context, url);
				} else if (request.RawUrl.Contains("welcome"))
				{
					buffer = new WelcomePage().CreateWelcomePage(context, url);
				} else if (request.RawUrl.Contains("whyitis"))
				{
					buffer = new WhyItisPage().CreateWhyItisPage(context, url);
				}
				
				


			// Console.WriteLine("URL: {0}", context.Request.Url.OriginalString);
			// 	Console.WriteLine("Raw URL: {0}", context.Request.RawUrl);

				response.ContentLength64 = buffer.Length;
				Stream st = response.OutputStream;
				st.Write(buffer, 0, buffer.Length);

				context.Response.Close();
			}
			
			
		}

		// 	private static string url = "http://localhost:8080/";
		//
		// 	public static HttpListener listener;
		// 	private static bool isRun = true;
		//
		// 	static void Main() => Listen().Wait();
		//
		// 	private static async Task Listen()
		// 	{
		// 		listener = new HttpListener();
		// 		listener.Prefixes.Add(url);
		//
		// 		listener.Start();
		// 		Console.WriteLine("Ожидание подключений...");
		//
		// 		while (isRun)
		// 		{
		// 			HttpListenerContext context = await listener.GetContextAsync();
		// 			HttpListenerRequest request = context.Request;
		// 			HttpListenerResponse response = context.Response;
		// 			
		// 			Redirecting(context);
		//
		// 			Console.WriteLine("connected");
		//
		// 			Console.WriteLine(request.Url);
		//
		// 			// byte[] buffer = System.Text.Encoding.UTF8.GetBytes(responseString);
		// 			//byte[] buffer = File.ReadAllBytes("." + context.Request.RawUrl.Replace("%20", " "));
		// 			//byte[] buffer = new WelcomePage().CreatePage();
		// 			
		// 		}
		// 	}
		//
		// 	private static void Redirecting(HttpListenerContext context)
		// 	{
		//
		// 		HttpListenerRequest request = context.Request;
		// 		HttpListenerResponse response = context.Response;
		// 		context.Response.ContentType = "text/html";
		// 		String mime = "";
		// 		String responseString = "";
		// 		byte[] buffer = Array.Empty<byte>();
		// 		
		// 		if (request.RawUrl.Contains("/"))
		// 		{
		// 			if (request.RawUrl.ToLower().Contains("."))
		// 			{
		// 				switch (request.RawUrl.ToLower().Substring(request.RawUrl.ToString().IndexOf(".")))
		// 				{
		// 					case ".css":
		// 						mime = "text/css";
		// 						break;
		// 					case ".js":
		// 						mime = "text/javascript";
		// 						break;
		// 					case ".png":
		// 						mime = "image/png";
		// 						break;
		// 					case ".jpg":
		// 						mime = "text/jpeg";
		// 						break;
		// 					case ".gif":
		// 						mime = "image/gif";
		// 						break;
		// 				}
		// 				response.AddHeader("content", mime);
		// 				response.ContentType = mime;
		// 			}
		// 			else
		// 			{
		// 				switch (request.RawUrl)
		// 				{
		// 					case "/hi":
		// 						buffer = new WelcomePage().CreatePage();
		// 						Console.WriteLine("HiPage");
		// 						break;
		// 					case "/about":
		// 						buffer = new AboutPage().CreateAboutPage();
		// 						Console.WriteLine(context.Response.ContentType);
		// 						break;
		// 					case "/photos":
		// 						buffer = new PhotosPage().CreatePhotosPage();
		// 						break;
		// 					case "/contacts":
		// 						buffer = new ContactsPage().CreateContactsPage();
		// 						break;
		// 					case "/whyitis":
		// 						buffer = new WhyItisPage().CreateWhyItisPage();
		// 						break;
		// 				}
		// 			}
		// 		}
		// 		
		// 		 //byte[] buffer = System.Text.Encoding.UTF8.GetBytes(responseString);
		// 		Console.WriteLine("URL: {0}", context.Request.Url.OriginalString);
		// 		Console.WriteLine("Raw URL: {0}", context.Request.RawUrl);
		// 		//byte[] buffer = File.ReadAllBytes("." + context.Request.RawUrl.Replace("%20", " "));
		// 		//byte[] buffer = new WelcomePage().CreatePage();
		//
		// 		response.ContentLength64 = buffer.Length;
		// 		Stream output = response.OutputStream;
		// 		output.Write(buffer, 0, buffer.Length);
		// 		output.Close();
		// 	}
		// }
	}
}

		

