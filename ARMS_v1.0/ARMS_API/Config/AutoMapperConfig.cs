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

                config.CreateMap<Campus, CampusDTO>();
                config.CreateMap<Major, MajorForGuestDTO>();
                config.CreateMap<TypeAdmission, TypeAdmissionDTO>();
                config.CreateMap<Subject, SubjectDTO>();
                config.CreateMap<Slider, SliderDTO>();

                //blog
                config.CreateMap<BlogCategory, BlogCategoryDTO>();
                config.CreateMap<Blog, BlogDTO>();
                // consultation
                config.CreateMap<StudentConsultationDTO, StudentConsultation>();
                config.CreateMap<StudentConsultation, StudentConsultation_AO_DTO>()
                .ForMember(dest => dest.MajorName, opt => opt.MapFrom(src => src.Major.MajorName));
                config.CreateMap<StudentConsultation_AO_DTO, StudentConsultation>();
                //register admission
                config.CreateMap<StudentProfile, RegisterAdmissionProfileDTO>();
                config.CreateMap<RegisterAdmissionProfileDTO, StudentProfile>();


                //config.CreateMap<AdmissionPlan, AdmissionPlanDTO>();
                //config.CreateMap<AdmissionTime, AdmissionTimeDTO>();



            })
            {


            };
            return mapperConfig.CreateMapper();
        }
    }
}
