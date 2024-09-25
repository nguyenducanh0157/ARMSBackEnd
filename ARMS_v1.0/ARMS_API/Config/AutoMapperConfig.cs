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

                config.CreateMap<Banner, BannerDTO>();
                
                config.CreateMap<StudentConsultationDTO, StudentConsultation>();
                config.CreateMap<AlumiStudent, AlumiStudentDTO>()
                .ForMember(dest => dest.CampusName, opt => opt.MapFrom(src => src.Campus.CampusName))
                .ForMember(dest => dest.SpecializeMajorName, opt => opt.MapFrom(src => src.SpecializeMajor.SpecializeMajorName));

                config.CreateMap<BlogCategory, BlogCategoryDTO>();
                config.CreateMap<Blog, BlogDTO>();
                config.CreateMap<BlogDetails, BlogDetailsDTO>();
                config.CreateMap<Comment, CommentDTO>();
                config.CreateMap<CommentDTO, Comment>();

                config.CreateMap<AdmissionPlan, AdmissionPlanDTO>();
                config.CreateMap<AdmissionTime, AdmissionTimeDTO>();

                config.CreateMap<SpecializeMajor, AdmissionSpecializeMajorDTO>()
                .ForMember(dest => dest.MajorID, opt => opt.MapFrom(src => src.Major.MajorID))
                .ForMember(dest => dest.MajorName, opt => opt.MapFrom(src => src.Major.MajorName));
                config.CreateMap<TypeOfDiploma, TypeOfDiplomaDTO>();
                config.CreateMap<TypeAcademicRecord, TypeAcademicRecordDTO>();
                config.CreateMap<TypeAdmissionForMajor, TypeAdmissionForMajorDTO>();
                config.CreateMap<Subject, SubjectDTO>();


                // register admission
                config.CreateMap<StudentProfile, RegisterAdmissionProfileDTO>();
                config.CreateMap<RegisterAdmissionProfileDTO, StudentProfile>();
            });
            return mapperConfig.CreateMapper();
        }
    }
}
