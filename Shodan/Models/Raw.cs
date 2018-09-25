using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shodan.Models
{
    public class Raw : ShodanBase
    {
        [JsonProperty("opts")]
        public Data Options { get; set; }
    }

    public class Data
    {
        [JsonProperty("raw")]
        public string Raw { get; set; }
    }
}
