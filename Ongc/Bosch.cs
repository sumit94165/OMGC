using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ongc
{
    internal class Bosch : BaseClass
    {
        static void Main52(string[] args)
        {
            string url = "https://www.bosch-presse.de/pressportal/de/en/news/";
            string data = GetURLData(url);
            NewsExtract(data, "//div[@class='stage-tile-cta']");
            Console.ReadLine();
        }

    }
}
