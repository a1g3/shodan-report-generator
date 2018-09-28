using AutoMapper;
using Report_Generation.ViewModels;
using Shodan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Report_Generation.Mappers
{
    public class HttpsMapper : ITypeConverter<Https, ResultViewModel>
    {
        public ResultViewModel Convert(Https source, ResultViewModel destination, ResolutionContext context)
        {
            destination = new ResultViewModel()
            {
                ASN = source.ASN,
                Data = source.Data,
                Domains = source.Domains,
                Hostnames = source.Hostnames,
                Information = source.Information,
                IP = source.IP,
                OperatingSystem = source.OperatingSystem,
                TimeStamp = source.TimeStamp,
                Port = source.Port,
                Product = source.Product,
                Tags = source.Tags,
                Version = source.Version,
                Vulnerabilities = Mapper.Map<Dictionary<string, VulnerabilityViewModel>>(source.Vulnerabilities)
            };

            destination.DisplayItems = new List<DisplaySection>()
            {
                new DisplaySection()
                {
                    Title = "HTTP",
                },
                new DisplaySection()
                {
                    Title = "TLS"
                }
            };

            if(source.HttpData != null)
            {
                destination.DisplayItems.First().DisplayItems = new List<DisplayItem>()
                {
                    new DisplayItem(){ Title = "Server", Value = source.HttpData.Server },
                    new DisplayItem(){ Title = "Host", Value = source.HttpData.Host },
                    new DisplayItem(){ Title = "Location", Value = source.HttpData.Loaction },
                    new DisplayItem(){ Title = "Redirects", Value = string.Join(", ", source.HttpData.Redirects.Select(x => x.Location)) },
                    new DisplayItem(){ Title = "Title", Value = source.HttpData.Title },
                };

                destination.DisplayItems[1].DisplayItems = new List<DisplayItem>()
                {
                    new DisplayItem(){ Title = "Supported Versions", Value = string.Join(", ", source.Ssl.Versions) },
                    new DisplayItem(){ Title = "Cipher Name", Value = source.Ssl.Cipher.Name },
                    new DisplayItem(){ Title = "Cipher TLS Version", Value = source.Ssl.Cipher.Version },
                    new DisplayItem(){ Title = "Certificate Issuer", Value = source.Ssl.Certficiate.Issuer.CommonName },
                    new DisplayItem(){ Title = "Certificate Subject", Value = source.Ssl.Certficiate.Subject.CommonName },
                    new DisplayItem(){ Title = "Certificate Expires", Value = source.Ssl.Certficiate.Expires },
                    new DisplayItem(){ Title = "Certificate SHA256 Fingerprint", Value = source.Ssl.Certficiate.Fingerprint.Sha256 },
                };
            }
            else
            {
                destination.DisplayItems.Remove(destination.DisplayItems.First());
                destination.DisplayItems.Remove(destination.DisplayItems.First());
            }

            return destination;
        }
    }
}
