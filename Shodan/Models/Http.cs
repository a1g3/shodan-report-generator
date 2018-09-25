using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shodan.Models
{
    public class Http : ShodanBase
    {
        [JsonProperty("http")]
        public HttpData HttpData { get; set; }
    }

    public class HttpData
    {
        [JsonProperty("robots_hash")]
        public string RobotsTxtHash { get; set; }
        [JsonProperty("redirects")]
        public List<Redirect> Redirects { get; set; }
        [JsonProperty("securitytxt")]
        public string SecurityTxt { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("sitemap_hash")]
        public string SitemapHash { get; set; }
        [JsonProperty("robots")]
        public string Robots { get; set; }
        [JsonProperty("server")]
        public string Server { get; set; }
        [JsonProperty("host")]
        public string Host { get; set; }
        [JsonProperty("html")]
        public string Html { get; set; }
        [JsonProperty("location")]
        public string Loaction { get; set; }
        [JsonProperty("html_hash")]
        public string HtmlHash { get; set; }
        [JsonProperty("sitemap")]
        public string Sitemap { get; set; }
        [JsonProperty("securitytxt_hash")]
        public string SecurityTxtHash { get; set; }
        //[JsonProperty("components")]
        //public List<string> Components { get; set; }
        [JsonProperty("favicon")]
        public HttpFavicon Favicon { get; set; }
    }

    public class Redirect
    {
        [JsonProperty("host")]
        public string Host { get; set; }
        [JsonProperty("data")]
        public string Data { get; set; }
        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public class HttpFavicon
    {
        [JsonProperty("hash")]
        public string Hash { get; set; }
        [JsonProperty("data")]
        public string Data { get; set; }
        [JsonProperty("location")]
        public string Location { get; set; }
    }
}
