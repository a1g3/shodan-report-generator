using Newtonsoft.Json;

namespace Shodan.Models
{
    public class Ntp : ShodanBase
    {
        [JsonProperty("opts")]
        public NtpData Options { get; set; }
    }

    public class NtpData
    {
        [JsonProperty("raw")]
        public string Raw { get; set; }
    }
}