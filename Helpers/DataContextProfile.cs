using AutoMapper;
using DesafioMutant.API.Models;

namespace DesafioMutant.API.Helpers
{
    public class DataContextProfile : Profile
    {
        public DataContextProfile()
        {
            CreateMap<UserDTO, User>();

            CreateMap<UserDTO, Address>()
                .ForMember(dest => dest.Street  , opt => opt.MapFrom(src => src.address.street))
                .ForMember(dest => dest.Suite   , opt => opt.MapFrom(src => src.address.suite))
                .ForMember(dest => dest.City    , opt => opt.MapFrom(src => src.address.city))
                .ForMember(dest => dest.Zipcode , opt => opt.MapFrom(src => src.address.zipcode))
                .ForMember(dest => dest.Lat     , opt => opt.MapFrom(src => src.address.geo.lat))
                .ForMember(dest => dest.Lng     , opt => opt.MapFrom(src => src.address.geo.lng))
                .ForMember(dest => dest.UserId  , opt => opt.MapFrom(src => src.id));

            CreateMap<UserDTO, Contact>()
                .ForMember(dest => dest.Phone   , opt => opt.MapFrom(src => src.phone))
                .ForMember(dest => dest.Website , opt => opt.MapFrom(src => src.website))
                .ForMember(dest => dest.UserId  , opt => opt.MapFrom(src => src.id));
        }
    }
}
