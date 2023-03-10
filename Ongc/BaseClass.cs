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
    internal class BaseClass
    {
        public static string GetURLData(string url)
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

        public static List<TataCapital> NewsExtract(string data, string nodes)
        {
            List<TataCapital> liNews = new List<TataCapital>();
            var doc = new HtmlDocument();
            doc.LoadHtml(data);
            HtmlNodeCollection nodesMatchingXPath = doc.DocumentNode.SelectNodes(nodes);

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


    }
}
