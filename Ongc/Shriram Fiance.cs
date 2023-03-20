using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Ongc
{
    internal class Shriram_Fiance : BaseClass
    {
        static void Main141(string[] args)
        {
            //  string url = "https://corporate.whirlpoolindia.com/press-release/";
            //  string url = "https://www.quesscorp.com/wp-content/themes/melos/media/press-release/pr-2022.php?_=1678725206223";
            string url = "";


            string data = GetURLData(url);
            // whirlpool pressdata  NewsExtract(data, "//div[@class='post-title']");
            //Console.WriteLine(data);
            //   NewsExtract(data, "//li[@class='yr15-16']");
            //   NewsExtract(data, "//div[@class='col-12 col-xl-3 col-sm-6 d-xl-block d-block']");
            //NewsExtract(data, "//div[@class='infotabitem']\r\n");
            //NewsExtract(data, "//p[@class='mainpara_media']");
            NewsExtract(data, "//td");

            Console.ReadLine();
        }

    }
}
