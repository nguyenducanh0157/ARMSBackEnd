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
                //major
                config.CreateMap<Major, MajorDTO>();
                config.CreateMap<Major_Manage_DTO, Major>();
                config.CreateMap<Major_Admission_DTO, Major>();
                // subject of major
                config.CreateMap<SubjectDTO, Subject>();
                config.CreateMap<Subject, SubjectDTO>();
                // type admission
                config.CreateMap<TypeAdmission, TypeAdmissionDTO>();
                config.CreateMap<TypeAdmissionDTO, TypeAdmission>();
                // slider
                config.CreateMap<Slider, SliderDTO>();

                //blog
                config.CreateMap<BlogCategory, BlogCategoryDTO>();
                config.CreateMap<Blog, BlogDTO>();
                config.CreateMap<Blog_SS_DTO, Blog>();
                // consultation
                config.CreateMap<StudentConsultationDTO, StudentConsultation>();
                config.CreateMap<StudentConsultation, StudentConsultation_AO_DTO>()
                .ForMember(dest => dest.MajorName, opt => opt.MapFrom(src => src.Major.MajorName));
                config.CreateMap<StudentConsultation_AO_DTO, StudentConsultation>();
                //register admission
                config.CreateMap<StudentProfile, RegisterAdmissionProfileDTO>();
                config.CreateMap<RegisterAdmissionProfileDTO, StudentProfile>();
                //admission time
                config.CreateMap<AdmissionTime, AdmissionTime_Admission_DTO>();
                config.CreateMap<AdmissionTime_Admission_DTO, AdmissionTime>();
                config.CreateMap<AdmissionTime, AdmissionTimeDTO>();
                config.CreateMap<AdmissionTime_Add_DTO, AdmissionTime>();
            })
            {


            };
            return mapperConfig.CreateMapper();
        }
    }
}
