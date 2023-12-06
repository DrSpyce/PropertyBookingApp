using AutoMapper;
using Domain.Entities;

namespace WebUserInterface.Models
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<PropertyDetailsModel, Property>().ReverseMap();
            CreateMap<BookedDateModel, BookedDate>().ReverseMap();
        }
    }
}
