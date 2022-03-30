using AutoMapper;
using ParkyAPI.Models;
using ParkyAPI.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkyAPI.ParkyMapper
{
    public class ParkyMappings : Profile
    {
        public ParkyMappings()
        {
            CreateMap<NationalPark, NationalParkDto>().ReverseMap();

            CreateMap<Trails, TrailsDto>().ReverseMap();

            CreateMap<Trails, TrailsCreateDto>().ReverseMap();

            CreateMap<Trails, TrailsUpdateDto>().ReverseMap();
        }
    }
}
