using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ongc
{
    internal class DaburIndia : BaseClass
    {
        static void Main51(string[] args)
        {
            string url = "https://www.dabur.com/press-releases";
            string data = GetURLData(url);
            NewsExtract(data, "//span[@class='field-content']");
            Console.ReadLine();
        }
    }
}
