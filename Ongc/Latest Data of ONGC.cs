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
    internal class Latest_Data_of_ONGC
    {
        static string Web = "https://ongcindia.com";
        static void Main1(string[] args)
        {
            string url = "https://ongcindia.com/web/eng/media/press-release";
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
            HtmlNodeCollection nodesMatchingXPath = doc.DocumentNode.SelectNodes("//li[@class='list-group-item']");

            foreach (var htmlnote in nodesMatchingXPath)
            {
                var sttr = htmlnote.Attributes;
                var Title = htmlnote.Descendants("a");
                var Title1 = Title.FirstOrDefault().GetAttributeValue("title", String.Empty);
                if (Title1 != "Text")
                    continue;
                var link = htmlnote.Descendants("a");
                var link1 = link.FirstOrDefault().GetAttributeValue("href", String.Empty);
                var link2 = Web + link1;
                Console.WriteLine(link2);
                Title = htmlnote.Descendants("p");
                Title1 = HtmlUtilities.ConvertToPlainText(HtmlEntity.DeEntitize(Title.FirstOrDefault().InnerHtml));
                Title1 = Title1.Replace("\n", "");

                while (Title1.Contains("  "))
                    Title1 = Title1.Replace("   ", "");
                Console.WriteLine(Title1);

                var doc2 = new HtmlDocument();

                doc2.LoadHtml(data);
                var date = doc2.DocumentNode.SelectNodes("//p[@class='list-group-subtitle text-muted']").FirstOrDefault().InnerHtml;
                Console.WriteLine(date);
                //foreach (var html1 in nodesMatchingXPath1)
                //{
                //    var sttr1 = html1.Attributes;
                //    var date = html1.InnerHtml;
                //    Console.WriteLine(date);
                //}









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
