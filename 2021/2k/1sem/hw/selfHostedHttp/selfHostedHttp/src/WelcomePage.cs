using System;
using System.IO;

namespace selfHostedHttp
{
    public class WelcomePage
    {
        public byte[] CreatePage()
        { byte[] html = File.ReadAllBytes("/Users/gadelshinrr/Desktop/2kGit/2k/2021/2k/1sem/hw/selfHostedHttp/selfHostedHttp/html/hi.html");
            return html;
        }
        
        

    }
}