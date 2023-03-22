using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;


namespace Ongc
{
    internal class AsianPaints : BaseClass
    {
        List<TataCaptial> totalNews = new List<TataCaptial>();

        static void Main1111(string[] args)
        {
            Sample2Entities6 ne = new Sample2Entities6();

            var sitesData = ne.WebsideDatas.Select(x => x).ToList();
            foreach (var item in sitesData)
            {
                string url = item.Webside__Web_side__website___;
                string companyside = item.companyWebSite;
                string data = GetURLData(url);
                List<TataCaptial> totalNews = new List<TataCaptial>();
                var allDataList = ne.TataCaptials.Select(x => x).ToList();
                var totalnews = NewsExtract(data, item.Document_Node);
                totalnews.ForEach(x => x.Link = item.companyWebSite + x.Link);

                var list = totalnews.Where(x => !allDataList.Any(y => y.Link == x.Link)).ToList();
                if (list.Count > 0)
                {
                    ne.TataCaptials.AddRange(list);
                    ne.SaveChanges();
                }
                totalNews = new List<TataCaptial>();


            }
            Console.ReadLine();
        }
    }

}
