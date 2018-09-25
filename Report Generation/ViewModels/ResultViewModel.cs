using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Report_Generation.ViewModels
{
    public class ResultViewModel
    {
        //public List<DisplaySection> DisplayItems { get; set; }
        public string Information { get; set; }
        public string Product { get; set; }
        public string Version { get; set; }
        public string OperatingSystem { get; set; }
        public int Port { get; set; }
        public List<string> Hostnames { get; set; }
        public string TimeStamp { get; set; }
        public List<string> Domains { get; set; }
        public string ASN { get; set; }
        public string IP { get; set; }
        public string Data { get; set; }
        public List<string> Tags { get; set; }
        public Dictionary<string, VulnerabilityViewModel> Vulnerabilities { get; set; }
    }

    public class VulnerabilityViewModel
    {
        public List<string> References { get; set; }
        public bool Verified { get; set; }
        public string CVSS { get; set; }
        public string Summary { get; set; }
    }
}
