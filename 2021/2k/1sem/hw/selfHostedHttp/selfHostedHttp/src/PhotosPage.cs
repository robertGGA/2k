using System;
using System.IO;

namespace selfHostedHttp
{
    public class PhotosPage
    {
        public string CreatePhotosPage()
        {
            String html = File.ReadAllText("/Users/gadelshinrr/Desktop/2kGit/2k/2021/2k/1sem/hw/selfHostedHttp/selfHostedHttp/html/photos.html");
            return html;
        }
    }
}