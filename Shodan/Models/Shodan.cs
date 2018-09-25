using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shodan.Models
{
    public class ShodanBase
    {
        [JsonProperty("_shodan")]
        public ShodanData Metadata { get; set; }
        [JsonProperty("info")]
        public string Information { get; set; }
        [JsonProperty("product")]
        public string Product { get; set; }
        [JsonProperty("version")]
        public string Version { get; set; }
        [JsonProperty("os")]
        public string OperatingSystem { get; set; }
        [JsonProperty("port")]
        public int Port { get; set; }
        [JsonProperty("hostnames")]
        public List<string> Hostnames { get; set; }
        [JsonProperty("timestamp")]
        public string TimeStamp { get; set; }
        [JsonProperty("domains")]
        public List<string> Domains { get; set; }
        [JsonProperty("asn")]
        public string ASN { get; set; }
        [JsonProperty("ip_str")]
        public string IP { get; set; }
        [JsonProperty("data")]
        public string Data { get; set; }
        [JsonProperty("tags")]
        public List<string> Tags { get; set; }
        [JsonProperty("vulns")]
        public Dictionary<string, Vulnerability> Vulnerabilities { get; set; }
    }

    public class Vulnerability
    {
        [JsonProperty("references")]
        public List<string> References { get; set; }
        [JsonProperty("verified")]
        public bool Verified { get; set; }
        [JsonProperty("cvss")]
        public string CVSS { get; set; }
        [JsonProperty("summary")]
        public string Summary { get; set; }
    }

    public class ShodanData
    {
        [JsonProperty("id")]
        public string ID { get; set; }
        [JsonProperty("module")]
        public string Module { get; set; }
    }

    public class ShodanSslBase : ShodanBase
    {
        [JsonProperty("opts")]
        public ImapSsl Options { get; set; }
        [JsonProperty("ssl")]
        public ShodanSslModel Ssl { get; set; }
    }

    public class ShodanSslModel
    {
        [JsonProperty("dhparams")]
        public DhParam DhParams { get; set; }
        [JsonProperty("tlsext")]
        public List<IdNamePair> TlsExtensions { get; set; }
        [JsonProperty("versions")]
        public List<string> Versions { get; set; }
        [JsonProperty("cert")]
        public Certificate Certficiate { get; set; }
        [JsonProperty("cipher")]
        public SslCipher Cipher { get; set; }
        [JsonProperty("chain")]
        public List<string> Chain { get; set; }
        [JsonProperty("alpn")]
        public List<string> Alpn { get; set; }
    }

    public class DhParam
    {
        [JsonProperty("prime")]
        public string Prime { get; set; }
        [JsonProperty("public_key")]
        public string PublicKey { get; set; }
        [JsonProperty("bits")]
        public int Bits { get; set; }
        [JsonProperty("generator")]
        public string Generator { get; set; }
        [JsonProperty("fingerprint")]
        public string Fingerprint { get; set; }
    }

    public class SslCipher
    {
        [JsonProperty("version")]
        public string Version { get; set; }
        [JsonProperty("bits")]
        public int Length { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class Certificate
    {
        [JsonProperty("sig_alg")]
        public string SignatureAlgorithm { get; set; }
        [JsonProperty("issued")]
        public string Issued { get; set; }
        [JsonProperty("expires")]
        public string Expires { get; set; }
        [JsonProperty("expired")]
        public bool IsExpired { get; set; }
        [JsonProperty("version")]
        public int Version { get; set; }
        [JsonProperty("extensions")]
        public List<CertificateExtensions> CertificateExtensions { get; set; }
        [JsonProperty("fingerprint")]
        public CertificateFingerprint Fingerprint { get; set; }
        [JsonProperty("serial")]
        public string Serial { get; set; }
        [JsonProperty("subject")]
        public CertificateInformation Subject { get; set; }
        [JsonProperty("pubkey")]
        public CertificateKey Key { get; set; }
        [JsonProperty("issuer")]
        public CertificateInformation Issuer { get; set; }
    }

    public class CertificateKey
    {
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("bits")]
        public int Length { get; set; }
    }

    public class CertificateInformation
    {
        [JsonProperty("C")]
        public string Country { get; set; }
        [JsonProperty("CN")]
        public string CommonName { get; set; }
        [JsonProperty("L")]
        public string Location { get; set; }
        [JsonProperty("O")]
        public string Organization { get; set; }
        [JsonProperty("ST")]
        public string State { get; set; }
        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }
        [JsonProperty("OU")]
        public string OrganizationUnit { get; set; }
    }

    public class CertificateFingerprint
    {
        [JsonProperty("sha256")]
        public string Sha256 { get; set; }
        [JsonProperty("sha1")]
        public string Sha1 { get; set; }
    }

    public class CertificateExtensions
    {
        [JsonProperty("data")]
        public string Data { get; set; }
        [JsonProperty]
        public string Name { get; set; }
    }

    public class IdNamePair
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ShodanTestBase
    {
        [JsonProperty("_shodan")]
        public ShodanData Metadata { get; set; }
    }
}
