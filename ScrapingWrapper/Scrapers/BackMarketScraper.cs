using ScrapySharp.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ScrapingWrapper.Scrapers
{
    class BackMarketScraper:Scraper
    {
        ////https://www.backmarket.com/tested-and-certified-used-iphone-6s-16-gb-rose-gold-unlocked/15035.html#?l=2
        public BackMarketScraper(int id = -1, string surl = null)
        {
            Name = "BackMarket";
            Id = id;
            ScrapUrl = (surl == null) ? @"https://www.backmarket.com/tested-and-certified-used-iphone-6s-16-gb-rose-gold-unlocked/15035.html?l=2" : surl;
            Browser.AllowMetaRedirect = true;
            Browser.AllowAutoRedirect = true;
            Browser.DecompressionMethods = System.Net.DecompressionMethods.GZip;
        }

        public override string doScrap(string pageUrl = null)
        {
            return null;
        }
        public override async Task<string> doScrapAsync(string pageUrl = null)
        {
                try
                {
                    if (pageUrl == null) pageUrl = ScrapUrl;
                    WebPage webPage = await Browser.NavigateToPageAsync(new Uri(pageUrl));
                    string xpath1 = "//*[@id=\"main_container\"]/div/div/div[1]/div[2]/div[2]/ul/li[1]/div[2]/div[1]";
                    string xpath2 = "//*[@id=\"main_container\"]/div/div/div[1]/div[3]/div[2]/ul/li[1]/div[2]/div[1]";
                    var node = webPage.Html.SelectSingleNode(xpath1) == null ? webPage.Html.SelectSingleNode(xpath2) : webPage.Html.SelectSingleNode(xpath1);
                    if (node == null)
                        return null;
                    double val = Utility.FilterDouble(node.InnerHtml);
                    return String.Format("{0}", val);
                }
                catch(Exception ex)
                {
                    return null;
                }
        }

    }
}
