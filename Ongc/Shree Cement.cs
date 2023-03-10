using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ongc
{
    internal class Shree_Cement : BaseClass
    {
        static void Main53(string[] args)
        {
            string url = "https://www.shreecement.com/newsroom/press-release";
            string data = GetURLData(url);
            NewsExtract(data, "//div[@class='press-releases-row']");
            Console.ReadLine();
        }

    }
}
