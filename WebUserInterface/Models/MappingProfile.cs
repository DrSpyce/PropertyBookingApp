using AutoMapper;
using Domain.Entities;

namespace WebUserInterface.Models
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<PropertyModel, Property>().ReverseMap();
            CreateMap<BookingModel, Booking>().ReverseMap();
            CreateMap<AmenityModel, Amenity>().ReverseMap();
        }
    }
}
