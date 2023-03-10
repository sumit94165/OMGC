using System;

namespace Ongc
{
    internal class larsentoubro : BaseClass
    {
        static void Main123(string[] args)
        {
            string url = "https://www.larsentoubro.com/corporate/media/press-releases/?year=2023";
            //string url = " https://www.bharatpetroleum.in/about-bpcl/press-release.aspx";


            string data = GetURLData(url);
            NewsExtract(data, "//td[@class='column-1']");
            Console.ReadLine();
        }
    }
}
