using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ongc
{
    internal class Bajaj_Fin : BaseClass
    {
        static void Main30(string[] args)
        {
            string url = " https://www.bajajfinserv.in/call-to-service&PageName=annualreports&AnnualYearParentId=1501195071407\r\n";
            string data = GetURLData(url);
            NewsExtract(data, "//h4");
            Console.ReadLine();
        }
    }
}
