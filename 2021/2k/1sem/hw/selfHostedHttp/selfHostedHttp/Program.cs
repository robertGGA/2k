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
			HttpListener server = new HttpListener(); 
			server.Prefixes.Add("http://localhost:8080/");

			server.Start();

			Console.WriteLine("Server started...");

			while (true)
			{
				HttpListenerContext context = server.GetContext();
				HttpListenerResponse response = context.Response;
				HttpListenerRequest request = context.Request;

				byte[] buffer = Array.Empty<byte>();

			

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
				

				response.ContentLength64 = buffer.Length;
				Stream st = response.OutputStream;
				st.Write(buffer, 0, buffer.Length);

				context.Response.Close();
			}
			
			
		}
	}
}

		

