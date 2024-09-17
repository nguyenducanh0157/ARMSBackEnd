using AutoMapper;
using Data.DTO;
using Data.Models;

namespace ARMS_API.Config
{
    public class AutoMapperConfig : Profile
    {
        public static IMapper Initialize()
        {
            var mapperConfig = new MapperConfiguration(config =>
            {

                config.CreateMap<Major, MajorForGuestDTO>()
                .ForMember(dest => dest.SpecializeMajorDTOs, opt => opt.MapFrom(src => src.SpecializeMajors));
                config.CreateMap<SpecializeMajor, SpecializeMajorDTO>();

                config.CreateMap<Campus, CampusDTO>();

                config.CreateMap<StudentConsultationDTO, StudentConsultation>();
            });
            return mapperConfig.CreateMapper();
        }
    }
}
