using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Ongc
{
    internal class lic
    {
        static string web = "http://test.licindia.in";
        static void Main3(string[] args)
        {
            string url = "https://licindia.in/Bottom-Links/Press-Release-(1)";
            string data = GetURLData(url);
            NewsExtract(data);

            //Console.WriteLine(data);
            Console.ReadLine();

        }
        private static List<TataCaptial> NewsExtract(string data)
        {
            List<TataCaptial> liNews = new List<TataCaptial>();
            var doc = new HtmlDocument();
            doc.LoadHtml(data);
            HtmlNodeCollection nodesMatchingXPath = doc.DocumentNode.SelectNodes("//tbody/tr");

            foreach (var htmlnote in nodesMatchingXPath)
            {

                var doc2 = new HtmlDocument();

                doc2.LoadHtml(htmlnote.InnerHtml);
                HtmlNodeCollection nodesMatchingXPath1 = doc2.DocumentNode.SelectNodes("//td");


                var sttr1 = nodesMatchingXPath1[1].InnerHtml;
                var sttr2 = nodesMatchingXPath1[2].InnerHtml;
                sttr2 = sttr2.Replace("&quot;", "");
                var strr = nodesMatchingXPath1[3].Descendants("a").FirstOrDefault();
                if (strr != null)
                {
                    var web1=(strr.GetAttributeValue("href", String.Empty));
                    Console.WriteLine(web + web1);
                }


                Console.WriteLine(sttr1);
                Console.WriteLine(sttr2);

                var link = htmlnote.Descendants("a");
                if (link != null)
                    continue;
                var link1 = link.FirstOrDefault().GetAttributeValue("href", String.Empty);

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
