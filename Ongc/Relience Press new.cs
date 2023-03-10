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
    internal class Relience_Press_new
    {

        static void Main(string[] args)
        {
            string url = " https://www.ril.com/MediaReleases.aspx?aliaspath=%2fMediaReleases";

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
            HtmlNodeCollection nodesMatchingXPath = doc.DocumentNode.SelectNodes("//div[@class='well well-sm bg-grey-light news-mB10']");

            foreach (var htmlnote in nodesMatchingXPath)
            {
                var sttr = htmlnote.Attributes;
                var link = htmlnote.Descendants("a");
                var link1 = link.FirstOrDefault().GetAttributeValue("href", String.Empty);
                Console.WriteLine(link1);
                //var link2 = Web + link1;
                //Console.WriteLine(link2);
                //var Date = htmlnote.Descendants("p");

                //string Date1 = HtmlUtilities.ConvertToPlainText(HtmlEntity.DeEntitize(Date.FirstOrDefault().InnerHtml));
                //Date1 = Date1.Replace("\n", "");

                //while (Date1.Contains("  "))
                //    Date1 = Date1.Replace("   ", "");
                //Console.WriteLine(Date1);
                //var Title = htmlnote.Descendants("span");
                //Console.WriteLine(Title.FirstOrDefault().InnerHtml);





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
