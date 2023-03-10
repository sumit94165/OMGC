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
    internal class Relience_corporateAllowancement
    {

        static string ad = "https://www.ril.com";
        static void Main6(string[] args)
        {
            string url = "https://www.ril.com/InvestorRelations/Corporate-Announcements.aspx";
            string data = GetURLData(url);
            // Console.WriteLine(data);
            NewsExtract(data);
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


                var sttr1 = nodesMatchingXPath1[0].InnerHtml;
                var date = sttr1.Replace("\r\n\t\t\t\t", "");
                var strr = nodesMatchingXPath1[1].Descendants("a").FirstOrDefault();
                if (strr != null)
                {
                    var web1 = (strr.GetAttributeValue("href", String.Empty));
                    var link = (ad + web1);
                    Console.WriteLine(link);
                }
                var Title = nodesMatchingXPath1[1].Descendants("a").FirstOrDefault().InnerHtml;

                Console.WriteLine(date);
                Console.WriteLine(Title);

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
