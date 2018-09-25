using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shodan.Models
{
    public class NetBios : ShodanBase
    {
        [JsonProperty("netbios")]
        public NetBiosData Netbios { get; set; }
    }

    public class NetBiosData
    {
        [JsonProperty("username")]
        public string UserName { get; set; }
        [JsonProperty("servername")]
        public string ServerName { get; set; }
        [JsonProperty("raw")]
        public List<string> Raw { get; set; }
        [JsonProperty("mac")]
        public string Mac { get; set; }
        [JsonProperty("name")]
        public List<NetBiosName> Names { get; set; }
        [JsonProperty("networks")]
        public List<string> Networks { get; set; }
    }

    public class NetBiosName
    {
        [JsonProperty("flags")]
        public int Flags { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("suffix")]
        public int Suffix { get; set; }
    }
}
