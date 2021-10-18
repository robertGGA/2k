using System;
using System.IO;

namespace selfHostedHttp
{
    public class WhyItisPage
    {
        public byte[] CreateWhyItisPage()
        {
            byte[] html = File.ReadAllBytes("/Users/gadelshinrr/Desktop/2kGit/2k/2021/2k/1sem/hw/selfHostedHttp/selfHostedHttp/html/whyitis.html");
            return html;
        }
    }
}