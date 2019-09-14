using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrapingWrapper.Scrapers
{
    public static class Utility
    {
        public static string apiBaseUrl = @"http://mobility.returnmoneyonline.com";
        public static string getBetween(string strSource, string strStart, string strEnd)
        {
            int Start, End;
            if (strSource.Contains(strStart) && strSource.Contains(strEnd))
            {
                Start = strSource.IndexOf(strStart, 0) + strStart.Length;
                End = strSource.IndexOf(strEnd, Start);
                return strSource.Substring(Start, End - Start);
            }
            else
            {
                return "";
            }
        }
        public static bool findString(string strSource, string subStr)
        {
            if (strSource.IndexOf(subStr) != -1) return true;
            return false;
        }
        public static double FilterDouble(string str)
        {
            str = new string((from c in str
                              where char.IsPunctuation(c) || char.IsLetterOrDigit(c)
                              select c
                   ).ToArray());
            if (String.IsNullOrEmpty(str)) return 0;
            return Double.Parse(str);

        }
        public static Dictionary<int, string> GetAllProductLinks() {
            Dictionary<int, string> links = new Dictionary<int, string>();
            var client = new RestClient(apiBaseUrl);
            var request = new RestRequest("api/getlinks", Method.GET);
            IRestResponse response = client.Execute(request);
            List<Dictionary<string, string>>  res = JsonConvert.DeserializeObject<List<Dictionary<string, string>>>(response.Content);
            foreach(var one in res)
            {
                int id = int.Parse( one[one.Keys.ElementAt(0)]);
                string url = one[one.Keys.ElementAt(1)];
                links.Add(id, url);
            }
            return links;
        }
        public static bool UpdateProductPriceByID(string sid, string sprice, string timestamp = null)
        {
            ///
            ////http://mobility.returnmoneyonline.com/api/setprice?id=1&price=123&tm=1568404143
            ///

            var client = new RestClient(apiBaseUrl);
            var request = new RestRequest("api/setprice", Method.GET);
            request.AddParameter("id", sid);
            request.AddParameter("price", sprice);
            request.AddParameter("tm", timestamp);
            IRestResponse response = client.Execute(request);
            return response.StatusCode == System.Net.HttpStatusCode.OK;
        }
        public static string GetServerTimeStamp()
        {
            ////
            ///http://mobility.returnmoneyonline.com/api/servertime
            ////
            var client = new RestClient(apiBaseUrl);
            var request = new RestRequest("api/servertime", Method.GET);
            IRestResponse response = client.Execute(request);
            return response.Content;
        }
    }
}
