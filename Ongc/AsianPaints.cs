using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ongc
{
    internal class AsianPaints : BaseClass
    {
        static void Main26(string[] args)
        {
            string url = "https://www.asianpaints.com/more/media.html";
            string data = GetURLData(url);
            NewsExtract(data, "//div[@class='left-offset col-md-11 col-sm-10 col-xs-8']");
            Console.ReadLine();
        }
    }
}
