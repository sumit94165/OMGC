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
    internal class InfosysPressNews : BaseClass
    {
        static void Main24(string[] args)
        {
            string url = "https://www.infosys.com/newsroom/press-releases.html";
            string data = GetURLData(url);
            NewsExtract(data, "//div[@class='relative']");
            Console.ReadLine();
        }
    }
}
