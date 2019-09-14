using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ScrapingWrapper.Data
{
        public class ProductLink
        {
            [JsonProperty(PropertyName = "id")]
            public decimal Id;
            [JsonProperty(PropertyName = "url")]
            public string Url;
        }
}
