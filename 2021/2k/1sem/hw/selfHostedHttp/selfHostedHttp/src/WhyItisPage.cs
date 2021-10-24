using System;
using System.IO;
using System.Net;

namespace selfHostedHttp
{
    public class WhyItisPage
    {
        public byte[] CreateWhyItisPage( HttpListenerContext context, string url)
        {
            HttpListenerRequest request = context.Request;
            HttpListenerResponse response = context.Response;
            if (!request.RawUrl.Equals("/whyitis"))
            {
                if (request.RawUrl.Contains(".") && !request.RawUrl.Contains("css") && !request.RawUrl.Contains("js") && !request.RawUrl.Contains("png") && !request.RawUrl.Contains("jpeg"))
                {
                    return File.ReadAllBytes("../../../" +
                                             context.Request.RawUrl.Substring(request.RawUrl.IndexOf(".") + 1) +
                                             context.Request.RawUrl.Replace("%20", " "));
                }
                else
                {
                    Console.WriteLine(request.RawUrl.Substring(request.RawUrl.IndexOf(".") + 1).Contains("png"));
                    if (request.RawUrl.Substring(request.RawUrl.IndexOf(".") + 1).Contains("png"))
                    {
                        Console.WriteLine("IMAGE");
                        context.Response.ContentType = "image/png";
                        return File.ReadAllBytes("../../../img/" +
                                                 context.Request.RawUrl.Replace("%20", " "));
                    } else {
                        return File.ReadAllBytes("../../../" +
                                                 context.Request.RawUrl.Substring(request.RawUrl.IndexOf(".") + 1) +
                                                 context.Request.RawUrl.Replace("%20", " "));
                    }
                }
            }
            else
            {
                response.Redirect(url + "whyitis.html");
                return Array.Empty<byte>();
            }
        }
    }
}