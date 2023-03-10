using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ongc
{
    internal class Sun_Pharma : BaseClass
    {
        static void Main19(string[] args)
        {

            string url = "https://sunpharma.com/media/";

            string data = GetURLData(url);
            NewsExtract(data, "//td[@class='column-1']");
            Console.ReadLine();
        }
    }
}
