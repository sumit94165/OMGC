using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ongc
{
    internal class Shriram_Fiance : BaseClass
    {
        static void Main(string[] args)
        {
            // string url = "https://www.shriramfinance.in/press-release";
            string url = "https://www.dalmiacement.com/investor/dalmia-bharat-limited/";


            string data = GetURLData(url);
            //Console.WriteLine(data);
            // NewsExtract(data, "//li[@class='animatedParent']");
          NewsExtract(data, "//div[@class='ed-element ed-html']");
          //  NewsExtract(data, "//p");

            Console.ReadLine();
        }

    }
}
