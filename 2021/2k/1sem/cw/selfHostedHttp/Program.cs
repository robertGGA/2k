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



				StreamReader reader = new StreamReader(request.InputStream);
				string s2 = reader.ReadToEnd();
				Console.WriteLine("Data received:" + s2);

				byte[] buffer = Create(context);
				response.ContentLength64 = buffer.Length;
				System.IO.Stream output = response.OutputStream;
				output.Write(buffer, 0, buffer.Length);
				output.Close();
			}


		}

		public static byte[] Create(HttpListenerContext context)
        {
			return File.ReadAllBytes("index.html");

		}
	}
}

		

