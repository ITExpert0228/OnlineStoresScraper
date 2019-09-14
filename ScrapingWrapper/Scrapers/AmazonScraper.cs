using ScrapySharp.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrapingWrapper.Scrapers
{
    class AmazonScraper: Scraper
    {
        //// www.amazon.com/dp/B01CR2IA6Y/ref=cm_sw_r_cp_api_i_SZaDDb79BSXXJ
        public AmazonScraper(int id = -1, string surl = null) {

            Name = "Amazon";
            Id = id;

            ScrapUrl = (surl == null) ? @"https://www.amazon.com/dp/B01NC0AXHT/ref=cm_sw_r_cp_api_i_j0aDDb0EHMGXX" : surl;

            Browser.AllowMetaRedirect = true;
            Browser.AllowAutoRedirect = true;
            Browser.DecompressionMethods = System.Net.DecompressionMethods.GZip;

        }

        public override string doScrap(string pageUrl = null) {
            return null;
        }
        /*
         *  WebPage PageResult = Browser.NavigateToPage(new Uri(BaseURL + request));
            return await Task.Factory.StartNew(() => JsonConvert.DeserializeObject<T>(PageResult.Content));
         */
        public override async Task<string> doScrapAsync(string pageUrl = null)
        {
            if (pageUrl == null) pageUrl = ScrapUrl;
            //string aaa = Browser.DownloadString(new Uri(pageUrl));
            WebPage webPage = null;
            await Task.Factory.StartNew(() => webPage = Browser.NavigateToPage(new Uri(pageUrl)));

            var node = webPage.Html.SelectSingleNode("//*[@id=\"comparison_price_row\"]/td[1]/span/span[2]/span[2]/text()");
            if (node == null) return null;
            string res = node.InnerHtml;
            return res;
        }
    }
}
