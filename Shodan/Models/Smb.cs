using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shodan.Models
{
    public class Smb : ShodanBase
    {
        [JsonProperty("smb")]
        public SmbModel ServerMessageBlock { get; set; }
    }

    public class SmbModel
    {
        [JsonProperty("smb_version")]
        public int Version { get; set; }
        [JsonProperty("raw")]
        public List<string> RawData { get; set; }
        [JsonProperty("os")]
        public string OperatingSystem { get; set; }
        [JsonProperty("capabilities")]
        public List<string> Capabilities { get; set; }
        [JsonProperty("software")]
        public string Software { get; set; }
    }
}
