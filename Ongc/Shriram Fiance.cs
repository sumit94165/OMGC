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
        static void Main(string[] args)
        {
            //  string url = "https://corporate.whirlpoolindia.com/press-release/";
            //  string url = "https://www.quesscorp.com/wp-content/themes/melos/media/press-release/pr-2022.php?_=1678725206223";
            string url = "www.timetechnoplast.com/investor-center/financials-results/";


            string data = GetURLData(url);
            // whirlpool pressdata  NewsExtract(data, "//div[@class='post-title']");
            //Console.WriteLine(data);
            //   NewsExtract(data, "//li[@class='col-md-6']");
            //   NewsExtract(data, "//div[@class='Sdownload-link-box ele-animate-box bottom-to-top']");
            //   NewsExtract(data, "//p[@class='result_box']");
            NewsExtract(data, "//td ");

            Console.ReadLine();
        }

    }
}
