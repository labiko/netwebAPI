using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataModels = netwebAPI.DataModels;

namespace netwebAPI.Profils
{
    public class AutoMapperProfils : Profile
    {
        public AutoMapperProfils()
        {
            CreateMap<DataModels.Student, DomainModels.Student>()
                .ReverseMap();

            CreateMap<DataModels.Gender, DomainModels.Gender>()
                .ReverseMap();

            CreateMap<DataModels.Address, DomainModels.Address>()
                .ReverseMap();
        }

    }
}
