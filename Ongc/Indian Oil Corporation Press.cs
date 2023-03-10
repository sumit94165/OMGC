using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Ongc
{
    internal class Indian_Oil_Corporation_Press
    {
        static string Web = "https://iocl.com";
        static void Main11(string[] args)
        {
            string url = "https://iocl.com/News-Release-Archives";
            string data = GetURLData(url);
            //Console.WriteLine(data);
            NewsExtract(data);

            Console.ReadLine();

        }
        private static List<TataCapital> NewsExtract(string data)
        {
            List<TataCapital> liNews = new List<TataCapital>();
            var doc = new HtmlDocument();
            doc.LoadHtml(data);
            HtmlNodeCollection nodesMatchingXPath = doc.DocumentNode.SelectNodes("//ul[@class='job-list']");

            foreach (var htmlnote in nodesMatchingXPath)
            {
                var strr = htmlnote.Attributes;
                var link = htmlnote.Descendants("a");
                if (link == null)
                    continue;
                var link1 = link.FirstOrDefault().GetAttributeValue("href", String.Empty);
                Console.WriteLine(link1);

                //var anode = HtmlUtilities.ConvertToPlainText(htmlnote.InnerHtml);



                //Console.WriteLine(anode);
            }
            return liNews;
        }




        private static string GetURLData(string url)
        {
            Console.WriteLine(url);
            WebClient client = new WebClient();
            client.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/103.0.0.0 Safari/537.36)");
            Stream data = client.OpenRead(url);
            StreamReader reader = new StreamReader(data);
            var s = reader.ReadToEnd();
            data.Close();
            reader.Close();
            return s;
        }

    }
}
