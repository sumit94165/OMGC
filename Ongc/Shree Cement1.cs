using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ongc
{
    internal class Shree_Cement1 : BaseClass
    {
        static void Main(string[] args)
        {
            string url = "https://www.shreecement.com/newsroom/media-mentions";
            string data = GetURLData(url);
            NewsExtract(data, "//div[@class='press-releases-desc']");
            Console.ReadLine();
        }

    }
}
