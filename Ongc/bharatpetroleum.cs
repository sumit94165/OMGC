using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ongc
{
    internal class bharatpetroleum : BaseClass
    {
        static void Main27(string[] args)
        {
            string url = " https://www.bharatpetroleum.in/about-bpcl/press-release.aspx";
            string data = GetURLData(url);
            NewsExtract(data, "//div[@class='rprt-name']");
            Console.ReadLine();
        }
    }
}
