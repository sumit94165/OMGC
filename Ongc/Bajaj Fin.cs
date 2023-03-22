using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ongc
{
    internal class Bajaj_Fin : BaseClass2
    {
        static void Main(string[] args)
        {
            string url = "https://hexaware.com/blogs/";
            string data = GetURLData(url);
            NewsExtract(data, "//div[@class='media-body']");
            // NewsExtract(data, "//li");
            Console.ReadLine();
        }
    }
}
