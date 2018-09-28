using AutoMapper;
using Report_Generation.ViewModels;
using Shodan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Report_Generation.Mappers
{
    public class SshMapper : ITypeConverter<OpenSsh, ResultViewModel>
    {
        public ResultViewModel Convert(OpenSsh source, ResultViewModel destination, ResolutionContext context)
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

            if(source.Opts.SSH != null)
            {
                destination.DisplayItems = new List<DisplaySection>()
                {
                    new DisplaySection()
                    {
                        Title = "SSH",
                        DisplayItems = new List<DisplayItem>()
                    }
                };

                destination.DisplayItems.First().DisplayItems.Add(new DisplayItem() { Title = "Fingerprint:", Value = source.Opts.SSH.FingerPrint });
                destination.DisplayItems.First().DisplayItems.Add(new DisplayItem() { Title = "MAC:", Value = source.Opts.SSH.MAC });
                destination.DisplayItems.First().DisplayItems.Add(new DisplayItem() { Title = "Cipher:", Value = source.Opts.SSH.Cipher });
                if (source.Opts.SSH.Kex.KexAlgoithms != null)
                    destination.DisplayItems.First().DisplayItems.Add(new DisplayItem() { Title = "Kex Algorithms:", Value = string.Join(", ", source.Opts.SSH.Kex.KexAlgoithms) });
                if (source.Opts.SSH.Kex.EncryptionAlgorithms != null)
                    destination.DisplayItems.First().DisplayItems.Add(new DisplayItem() { Title = "Encryption Algorithms:", Value = string.Join(", ", source.Opts.SSH.Kex.EncryptionAlgorithms) });
                if (source.Opts.SSH.Kex.MACAlgorithms != null)
                    destination.DisplayItems.First().DisplayItems.Add(new DisplayItem() { Title = "MAC Algorithms:", Value = string.Join(", ", source.Opts.SSH.Kex.MACAlgorithms) });
                if (source.Opts.SSH.Kex.CompressionAlgorithms != null)
                    destination.DisplayItems.First().DisplayItems.Add(new DisplayItem() { Title = "Compression Algorithms:", Value = string.Join(", ", source.Opts.SSH.Kex.CompressionAlgorithms) });

            }

            return destination;
        }
    }
}
