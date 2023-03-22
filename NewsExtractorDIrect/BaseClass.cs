﻿using System.Collections.Generic;
using System.IO;
using System.Net;
using System;
using HtmlAgilityPack;
using System.Linq;

namespace NewsExtractorDIrect
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

        public static List<TataCaptial> NewsExtract(string data, string nodes)
        {
            DateTime now = DateTime.Now; ;

            List<TataCaptial> liNews = new List<TataCaptial>();
            var doc = new HtmlDocument();
            doc.LoadHtml(data);
            HtmlNodeCollection nodesMatchingXPath = doc.DocumentNode.SelectNodes(nodes);
            if (nodesMatchingXPath != null)
            {
                foreach (var htmlnote in nodesMatchingXPath)
                {
                    var strr = htmlnote.Attributes;
                    var Title = htmlnote.Descendants("a").FirstOrDefault();
                    if (Title != null)
                    {
                        var Title1 = (HtmlUtilities.ConvertToPlainText(Title.InnerHtml));
                        var link = (Title.GetAttributeValue("href", String.Empty));

                        var tataCapital = new TataCaptial();
                        tataCapital.Title = Title1;
                        tataCapital.Link = "" + link;
                        tataCapital.Date = DateTime.Now.ToString();



                        liNews.Add(tataCapital);


                    }

                }
            }
            return liNews;

        }

        public void getData
           ()
        {
        }
    }
}