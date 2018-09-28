using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shodan.Models;
using Report_Generation.ViewModels;

namespace Report_Generation.Mappers
{
    public class FtpMapper : ITypeConverter<Ftp, ResultViewModel>
    {
        public ResultViewModel Convert(Ftp source, ResultViewModel destination, ResolutionContext context)
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
                    Title = "FTP",
                    DisplayItems = new List<DisplayItem>()
                }
            };

            destination.DisplayItems.First().DisplayItems.Add(new DisplayItem() { Title = "Allows Anonomous Auth:", Value = source.FtpData.Anonymous.ToString() });

            return destination;
        }
    }
}
