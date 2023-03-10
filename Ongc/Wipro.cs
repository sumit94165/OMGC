using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ongc
{
    internal class Wipro : BaseClass
    {
        static void Main21(string[] args)
        {
            string url = "https://www.wipro.com/content/nexus.dropdownyearservlet.json?year=2023&month=undefined&pgPath=/content/nexus/en/newsroom/press-releases/2023,/content/nexus/en/newsroom/press-releases/2022/wipro-and-hfcl-announce-5g-product-development-partnership,/content/nexus/en/newsroom/press-releases/2022/vmware-and-wipro-expand-partnership-to-power-customers-digital-transformation,/content/nexus/en/newsroom/press-releases/2020/wipro-press-conference-q3-fy-2020-21,/content/dam/nexus/en/newsroom/press-releases/2020/pdf/press-release-q2-fy21.pdf,/content/nexus/en/newsroom/press-releases/2020,/content/nexus/en/newsroom/press-releases/2019,/content/nexus/en/newsroom/press-releases/2018,/content/nexus/en/newsroom/press-releases/2017,/content/nexus/en/newsroom/press-releases/2016,/content/nexus/en/newsroom/press-releases/2015,/content/nexus/en/newsroom/press-releases/2014,/content/nexus/en/newsroom/press-releases/2013,/content/nexus/en/newsroom/press-releases/2012,/content/nexus/en/newsroom/press-releases/2011,/content/nexus/en/newsroom/press-releases/2010,/content/nexus/en/newsroom/press-releases/2009,/content/nexus/en/newsroom/press-releases/2008,/content/dam/nexus/en/newsroom/press-releases/2017/pdfs,/content/dam/nexus/en/newsroom/press-releases/2018,/content/dam/nexus/en/newsroom/press-releases/2019/pdf,/content/dam/nexus/en/newsroom/press-releases/2020/pdf,/content/dam/nexus/en/newsroom/press-releases/2021/pdf,/content/nexus/en/newsroom/press-releases/2021,/content/nexus/en/newsroom/press-releases/2022,/content/dam/nexus/en/newsroom/press-releases/2022/pdf&ddCount=singledd&secondDdType=&yFormat=singleyear&archiveYear=0\r\n";
            string data = GetURLData(url);
            NewsExtract(data, "//div[@class='dropdown-button-content-news press-cus-bor']");
            Console.ReadLine();
        }
    }
}
