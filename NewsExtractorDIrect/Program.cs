using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsExtractorDIrect
{
    internal class Program : BaseClass
    {
        List<TataCaptial> totalNews = new List<TataCaptial>();

        static void Main(string[] args)
        {
            Sample2Entities ne = new Sample2Entities();

            var sitesData = ne.WebsideDatas.Where(p => p.IsActive == true).ToList();
            foreach (var item in sitesData)
            {
                Task t = new Task(delegate { Execution(item); });
                t.Start();
            }
            Console.ReadLine();
        }

        private static void Execution(WebsideData item)
        {
            try
            {
                Sample2Entities ne = new Sample2Entities();
                Console.WriteLine(item.ID + "--" + item.companyWebSite);
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
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
