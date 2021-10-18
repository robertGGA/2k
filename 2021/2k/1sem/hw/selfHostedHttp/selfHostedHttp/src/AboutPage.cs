using System;
using System.IO;

namespace selfHostedHttp
{
    public class AboutPage
    {
        public byte[] CreateAboutPage()
        {
            byte[] html = File.ReadAllBytes("/Users/gadelshinrr/Desktop/2kGit/2k/2021/2k/1sem/hw/selfHostedHttp/selfHostedHttp/html/about.html");
            return html;
        }
    }
}