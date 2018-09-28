using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shodan.Models
{
    public class OpenSsh : Shodan.Models.ShodanBase
    {
        [JsonProperty("opts")]
        public SshOpts Opts { get; set; }
    }

    public class SshOpts
    {
        [JsonProperty("ssh")]
        public Ssh SSH { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class Ssh
    {
        [JsonProperty("fingerprint")]
        public string FingerPrint { get; set; }
        [JsonProperty("mac")]
        public string MAC { get; set; }
        [JsonProperty("cipher")]
        public string Cipher { get; set; }
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("kex")]
        public Kex Kex { get; set; }
    }

    public class Kex
    {
        [JsonProperty("languages")]
        public List<string> Langauges { get; set; }
        [JsonProperty("server_host_key_algorithms")]
        public List<string> ServerHostKeys { get; set; }
        [JsonProperty("encryption_algorithms")]
        public List<string> EncryptionAlgorithms { get; set; }
        [JsonProperty("kex_follows")]
        public bool KexFollows { get; set; }
        [JsonProperty("unused")]
        public int Unused { get; set; }
        [JsonProperty("kex_algorithms")]
        public List<string> KexAlgoithms { get; set; }
        [JsonProperty("compression_algorithms")]
        public List<string> CompressionAlgorithms { get; set; }
        [JsonProperty("mac_algorithms")]
        public List<string> MACAlgorithms { get; set; }
    }
}
