using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ongc
{
    internal class Hind : BaseClass
    {
        static void Main20(string[] args)
        {
            string url = "https://www.hzlindia.com/media/press-releases/";
            string data = GetURLData(url);
            NewsExtract(data, "//div[@class='zinc-releases-cont']");
            Console.ReadLine();
        }
    }
}
