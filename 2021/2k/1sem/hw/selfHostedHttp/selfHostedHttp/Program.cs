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
				switch (request.RawUrl.ToString()) 
				{
					case "/hi.html":
						responseString = new WelcomePage().CreatePage();
						Console.WriteLine("HiPage");
						break;
					case "/about.html":
						responseString = new AboutPage().CreateAboutPage();
						Console.WriteLine("AboutPage");
						break;
					case "/photos.html":
						responseString = new PhotosPage().CreatePhotosPage();
						break;
					case "/contacts.html":
						responseString = new ContactsPage().CreateContactsPage();
						break;
					case "/whyitis.html":
						responseString = new WhyItisPage().CreateWhyItisPage();
						break;
					default:
						responseString = "<html><head><meta charset='utf8'></head><body>Страница не найдена</body></html>";
						break;
				}
				Console.WriteLine("connected");

				Console.WriteLine(request.RawUrl);
				
				byte[] buffer = System.Text.Encoding.UTF8.GetBytes(responseString);
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
