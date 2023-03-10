using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ongc
{
    internal class PowerGrid : BaseClass
    {
        static void Main27(string[] args)
        {
            string url = "https://www.powergrid.in/press-release";
            string data = GetURLData(url);
            NewsExtract(data, "//div[@class='iconWrap']");
            Console.ReadLine();
        }
    }
}
