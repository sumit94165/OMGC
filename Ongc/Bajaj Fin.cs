﻿using System;
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
            string url = "https://www.mmtclimited.com/pages/show/256-annual-report-(english)-";
            string data = GetURLData(url);
            // NewsExtract(data, "//div[@class='action-box']");
            NewsExtract(data, "//li");
            Console.ReadLine();
        }
    }
}
