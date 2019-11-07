using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZaporArrow.Profiles
{
    public class ArrowsProfile : Profile
    {
        public ArrowsProfile()
        {
            CreateMap<Entities.Arrow, Models.ArrowDto>()
                .ForMember(
                dest => dest.ProfilPicture,
                opt => opt.MapFrom(src => src.Images.First().ImageSource));
        }
    }
}
