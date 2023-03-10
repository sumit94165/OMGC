using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ongc
{
    internal class IndusInd_Bank : BaseClass
    {


        static void Main29(string[] args)
        {
            string url = "  https://www.indusind.com/in/en/about-us/mediabrand/press-release-archive.html";
            string data = GetURLData(url);
            NewsExtract(data, "//div[@class='pdfright d-flex']");
            Console.ReadLine();

        }
    }
}
