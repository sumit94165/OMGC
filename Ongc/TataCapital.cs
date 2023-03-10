using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Ongc
{
    internal class TataCapital
    {
        static string ad = "https://www.tatacapital.com";
        static void Main(string[] args)
        {
            string url = "https://www.tatacapital.com/media-center/press-releases.html";
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
            HtmlNodeCollection nodesMatchingXPath = doc.DocumentNode.SelectNodes("//div[@class='pdf-details']");

            foreach (var htmlnote in nodesMatchingXPath)
            {
                var strr = htmlnote.Attributes;
                var link = htmlnote.Descendants("a");
                var link1 = link.FirstOrDefault().GetAttributeValue("href", String.Empty);
                var link2 = ad + link1;
                Console.WriteLine(link2);
                //var tittle = htmlnote.Descendants("p");
                //if (tittle == null)
                //    continue;
                //Console.WriteLine(tittle.FirstOrDefault().InnerHtml);

                var doc2 = new HtmlDocument();
                doc2.LoadHtml(htmlnote.InnerHtml);
                var date = doc2.DocumentNode.SelectNodes("//div[@class='pdf-location']").FirstOrDefault();
                if (data == null)
                    continue;
                var date1 = HtmlUtilities.ConvertToPlainText(date.InnerHtml);
                date1 = date1.Replace("/n", "");
                Console.WriteLine(date1);

                var title = doc2.DocumentNode.SelectNodes("//div[@class='about-pdf']").FirstOrDefault();
                if (title == null)
                    continue;
                var title1 = HtmlUtilities.ConvertToPlainText(title.InnerHtml);
                title1 = title1.Replace("/n", "");
                while (title1.Contains("  "))
                    title1 = title1.Replace("  ", "");
                Console.WriteLine(title1);





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
