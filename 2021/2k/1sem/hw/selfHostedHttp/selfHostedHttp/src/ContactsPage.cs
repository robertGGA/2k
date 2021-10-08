using System;
using System.IO;

namespace selfHostedHttp
{
    public class ContactsPage
    {
        public String CreateContactsPage()
        {
            String html = File.ReadAllText("/Users/gadelshinrr/Desktop/2kGit/2k/2021/2k/1sem/hw/selfHostedHttp/selfHostedHttp/html/contacts.html");
            return html;
        }
     }
}