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


                //config.CreateMap<AdmissionPlan, AdmissionPlanDTO>();
                //config.CreateMap<AdmissionTime, AdmissionTimeDTO>();

                //config.CreateMap<TypeOfDiploma, TypeOfDiplomaDTO>();
                //config.CreateMap<TypeAcademicRecord, TypeAcademicRecordDTO>();
                //config.CreateMap<TypeAdmissionForMajor, TypeAdmissionForMajorDTO>();


                //register admission
                //config.CreateMap<StudentProfile, RegisterAdmissionProfileDTO>();
                //config.CreateMap<RegisterAdmissionProfileDTO, StudentProfile>();
            })
            {


            };
            return mapperConfig.CreateMapper();
        }
    }
}
