using AutoMapper;
using Report_Generation.ViewModels;
using Shodan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Report_Generation.Mappers
{
    public static class AutoMapperConfig
    {
        public static void Init()
        {
            Mapper.Initialize(cfg => {
                cfg.CreateMap<OpenSsh, ResultViewModel>().ConvertUsing<SshMapper>();
                cfg.CreateMap<Ftp, ResultViewModel>().ConvertUsing<FtpMapper>();
                cfg.CreateMap<Https, ResultViewModel>().ConvertUsing<HttpsMapper>();
                cfg.CreateMap<ShodanBase, ResultViewModel>().ConvertUsing<BaseMapper>();
            });
        }
    }
}
