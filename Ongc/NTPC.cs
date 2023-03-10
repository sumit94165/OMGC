using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ongc
{
    internal class NTPC : BaseClass
    {
        static void Main18(string[] args)
        {

            string url = "https://www.ntpc.co.in/en/media/press-releases";
            string data = GetURLData(url);
            NewsExtract(data, "//span[@class='col-md-10 col-sm-9 col-xs-12']");
            Console.ReadLine();
        }
    }
}
