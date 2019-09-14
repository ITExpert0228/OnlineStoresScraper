using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using ScrapySharp.Core;
using ScrapySharp.Html.Parsing;
using ScrapySharp.Network;
using HtmlAgilityPack;
using ScrapySharp.Extensions;
using ScrapySharp.Html.Forms;
using System.Net;
using Newtonsoft.Json;

namespace ScrapingWrapper.Scrapers
{
    public abstract class Scraper : IScraper
    {
        #region Properties
        public SecureString PublicApiKey { get; set; }
        public SecureString PrivateApiKey { get; set; }
        public SecureString Passphrase { get; set; }
        public int getId() { return Id; }
        public string Name { get; set; }
        protected int Id { get; set; }
        protected string ScrapUrl { get; set; }

        protected ScrapingBrowser Browser = new ScrapingBrowser();

        #endregion Properties

        #region Methods
        public virtual string doScrap(string pageUrl = null) => throw new NotImplementedException();
        public virtual  Task<string> doScrapAsync(string pageUrl = null)
        {
            throw new NotImplementedException();
        }
        #endregion Methods

    }

    public interface IScraper : INamed
    {
        #region Properties

        SecureString PublicApiKey { get; set; }
        SecureString PrivateApiKey { get; set; }
        SecureString Passphrase { get; set; }
        #endregion Properties

        #region Methods
        string doScrap(string pageUrl = null);
        Task<string> doScrapAsync(string pageUrl = null);
        #endregion Methods
        
    }
    public interface INamed
    {
        /// <summary>
        /// The name of the service, exchange, etc.
        /// </summary>
        string Name { get; }
        int getId();
    }
}
