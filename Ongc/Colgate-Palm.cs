using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ongc
{
    internal class Colgate_Palm : BaseClass
    {
        static void Main100(string[] args)
        {
            string url = "https://investor.colgatepalmolive.com/press-releases";
            string data = GetURLData(url);
            NewsExtract(data, "//div[@class='component-content']");

            Console.ReadLine();
        }
    }
}
