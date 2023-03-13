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
            //  string url = "https://corporate.whirlpoolindia.com/press-release/";
            string url = "https://investor.cummins.com/news";


            string data = GetURLData(url);
            // whirlpool pressdata  NewsExtract(data, "//div[@class='post-title']");
            //Console.WriteLine(data);
            // NewsExtract(data, "//li[@class='liscreen']");
               NewsExtract(data, "//h2[@class='media-heading']");
            //NewsExtract(data, " //li ");

            Console.ReadLine();
        }

    }
}
