using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shodan.Models
{
    public class Ftp : ShodanBase
    {
        [JsonProperty("ftp")]
        public FtpData FtpData { get; set; }
    }

    public class FtpData
    {
        [JsonProperty("anonymous")]
        public bool Anonymous { get; set; }
        [JsonProperty("features_hash")]
        public int FeaturesHash { get; set; }
        [JsonProperty("features")]
        public FtpFeatures Features { get; set; }
    }

    public class FtpFeatures
    {
        [JsonProperty("UTF8")]
        public FtpParameter Utf8 { get; set; }
        [JsonProperty("REST")]
        public FtpParameter Rest { get; set; }
        [JsonProperty("PASV")]
        public FtpParameter Pasv { get; set; }
        [JsonProperty("EPSV")]
        public FtpParameter Epsv { get; set; }
        [JsonProperty("TVFS")]
        public FtpParameter Tvfs { get; set; }
        [JsonProperty("EPRT")]
        public FtpParameter Eprt { get; set; }
        [JsonProperty("MDTM")]
        public FtpParameter Mdtm { get; set; }
        [JsonProperty("SIZE")]
        public FtpParameter Size { get; set; }
    }

    public class FtpParameter
    {
        [JsonProperty("parameters")]
        public List<string> Parameters { get; set; }
    }
}
