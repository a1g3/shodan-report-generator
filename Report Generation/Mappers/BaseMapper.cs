using AutoMapper;
using Report_Generation.ViewModels;
using Shodan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Report_Generation.Mappers
{
    public class BaseMapper : ITypeConverter<ShodanBase, ResultViewModel>
    {
        public ResultViewModel Convert(ShodanBase source, ResultViewModel destination, ResolutionContext context)
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

            return destination;
        }
    }
}
