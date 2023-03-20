using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ongc
{
    internal class Bajaj_Fin : BaseClass2
    {
        static void Main3343(string[] args)
        {
            string url = "";
            string data = GetURLData(url);
            //     NewsExtract(data, "//div[@class='data']");
            NewsExtract(data, "//li");
            Console.ReadLine();
        }
    }
}
