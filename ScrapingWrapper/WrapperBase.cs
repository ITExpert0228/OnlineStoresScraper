using System;
using System.Timers;
using System.Threading.Tasks;
using System.Collections.Generic;
using ScrapingWrapper.Scrapers;

namespace ScrapingWrapper
{
    public class WrapperBase
    {
        //public const string DefaultBaseAddress = "https://ticketmaster.com/";
        private static Timer timer;
        public WrapperBase() {
            timer = new Timer(1000);
            timer.Elapsed += async (sender, e) => await TimeHandler();
            timer.AutoReset = false;
        }
        public WrapperBase(int interval)
        {
            if (interval < 1000) interval = 1000;
            timer = new Timer(interval);
            timer.Elapsed += async (sender, e) => await TimeHandler();
            timer.AutoReset = true;

        }
        public static List<IScraper> InitScrapers(List<string> urlList)
        {
            List<IScraper>  scraperList = new List<IScraper>();
            foreach (string strUrl in urlList)
            {
                IScraper scraper = null;
                if(Utility.findString(strUrl, "amazon"))
                {
                    scraper = new AmazonScraper();
                }
                else if(Utility.findString(strUrl, "backmarket"))
                {
                    scraper = new BackMarketScraper();
                }

                if (scraper != null)
                    scraperList.Add(scraper);
            }
            return scraperList;
        }
        protected static List<IScraper> InitScrapers(Dictionary<int, string> urlDic)
        {
            List<IScraper> scraperList = new List<IScraper>();
            foreach (KeyValuePair<int, string> item in urlDic)
            {
                IScraper scraper = null;
                if (Utility.findString(item.Value, "amazon"))
                {
                    scraper = new AmazonScraper(item.Key, item.Value);
                }
                else if (Utility.findString(item.Value, "backmarket"))
                {
                    scraper = new BackMarketScraper(item.Key, item.Value);
                }

                if (scraper != null)
                    scraperList.Add(scraper);
            }
            if (scraperList.Count == 0) throw new System.InvalidOperationException("There is no scraper recognized in the list!");
            return scraperList;
        }
        public static List<IScraper> InitScrapers()
        {
            Dictionary<int, string> links =  Utility.GetAllProductLinks();
            List<IScraper> scraperList =  InitScrapers(links);
            if(scraperList.Count == 0) throw new System.InvalidOperationException("There is no scraper recognized in the list!");
            return scraperList;
        }
        public void Start()
        {
                timer.Start();
        }
        public void Stop()
        {
            timer.Stop();
            timer.Dispose();
        }
        static int i = 0;
        private static async Task TimeHandler() {

            List<IScraper> scraperList =  InitScrapers();
            string fetchTime = Utility.GetServerTimeStamp();
            foreach (IScraper one in scraperList)
            {
                int id = one.getId();
                string price = await one.doScrapAsync();
                Console.WriteLine("Handler is working...." + one.Name + (id) +" & " + price );
                //Saving price into database
                if (price != null) {
                    bool rs = Utility.UpdateProductPriceByID(id.ToString(), price, fetchTime);
                    if (!rs) Console.WriteLine("HTTP not OK ->" + one.Name + (id) + " & " + price );
                }
                int nDelay = (int)timer.Interval / (scraperList.Count + 1) /2;
                int minDelay = 5000;
                nDelay = nDelay > minDelay ? nDelay : minDelay;
                await Task.Delay(nDelay);
                //System.Threading.Thread.Sleep(5000);
            }
            
        }
    }
}
