using System;
using System.IO;

namespace selfHostedHttp
{
    public class WelcomePage
    {
        public String CreatePage()
        {
            String html = File.ReadAllText("/Users/gadelshinrr/Desktop/2kGit/2k/2021/2k/1sem/hw/selfHostedHttp/selfHostedHttp/html/hi.html");
            return html;
        }
        
        

    }
}