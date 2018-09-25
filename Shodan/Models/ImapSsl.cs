using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shodan.Models
{
    public class ImapSsl : ShodanSslBase
    {
        [JsonProperty("vulns")]
        public List<string> Vulnerabilities { get; set; }
        [JsonProperty("heartbleed")]
        public string HeartBleed { get; set; }
    }
}
