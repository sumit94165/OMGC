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
    internal class ICICPressNews
    {
        static void Main23(string[] args)
        {
            var year = DateTime.Now.Month.ToString();

            //string url = "https://www.icicibank.com/about-us/news";
            string url = "https://www.icicibank.com/content/icicibank/in/en/about-us/news.dropdown.json?key=2023";
            string data = GetURLData(url);
            NewsExtract(data);
            //div[@id='pltexts']/div[@class='plext']/text()

            //Console.WriteLine(data);
            Console.ReadLine();

        }

        private static List<TataCaptial> NewsExtract(string data)
        {
            List<TataCaptial> liNews = new List<TataCaptial>();
            var doc = new HtmlDocument();
            doc.LoadHtml(data);
            HtmlNodeCollection nodesMatchingXPath = doc.DocumentNode.SelectNodes("//p");

            foreach (var htmlnote in nodesMatchingXPath)
            {
                var strr = htmlnote.Attributes;
                var Title = htmlnote.Descendants("a").FirstOrDefault();
                if (Title != null)
                {
                    Console.WriteLine(HtmlUtilities.ConvertToPlainText(Title.InnerHtml));
                    Console.WriteLine(Title.GetAttributeValue("href", String.Empty));
                }
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
