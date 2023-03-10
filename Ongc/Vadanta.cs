using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ongc
{
    internal class Vadanta : BaseClass
    {
        static void Main12(string[] args)
        {
            string url = "https://www.vedantalimited.com/eng/media-press-releases.php";
            string data = GetURLData(url);
            NewsExtract(data, "//div[@class='blog']");
            Console.ReadLine();
        }
    }
}
