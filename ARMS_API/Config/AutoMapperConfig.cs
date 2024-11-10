using AutoMapper;
using Data.DTO;
using Data.Models;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Reflection;

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
                config.CreateMap<Major, Major_Admin_DTO>();
                config.CreateMap<Major, Major_Admission_Council_DTO>();
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

                //admission time
                config.CreateMap<AdmissionTime, AdmissionTime_Admission_DTO>();
                config.CreateMap<AdmissionTime_Admission_DTO, AdmissionTime>();
                config.CreateMap<AdmissionTime, AdmissionTimeDTO>();
                config.CreateMap<AdmissionTime_Add_DTO, AdmissionTime>();
                // admission information 
                config.CreateMap<AdmissionInformation, AdmissionInformationDTO>();
                config.CreateMap<AdmissionInformation_Update_DTO, AdmissionInformation>();
                // request change major
                config.CreateMap<Request, RequestChangeMajorDTO>();
                // Priority
                config.CreateMap<PriorityDetail, PriorityDTO>()
                     .ForMember(dest => dest.TypeOfPriority, opt => opt.MapFrom(src =>
                        src.TypeOfPriority == TypeOfPriority.UT1 ? "Ưu tiên 1" :
                        src.TypeOfPriority == TypeOfPriority.UT2 ? "Ưu tiên 2" : "Không xác định"))
                     .ForMember(dest => dest.BonusPoint, opt => opt.MapFrom(src =>
                        src.TypeOfPriority == TypeOfPriority.UT1 ? 2 :
                        src.TypeOfPriority == TypeOfPriority.UT2 ? 1 : 0));
                //register admission
                config.CreateMap<AcademicTranscript, AcademicTranscriptDTO>();
                config.CreateMap<AcademicTranscriptDTO, AcademicTranscript>();

                config.CreateMap<AcademicTranscript, AcademicTranscript_View_DTO>();
                config.CreateMap<AcademicTranscript_View_DTO, AcademicTranscript>();

                config.CreateMap<PayFeeAdmissionDTO, PayFeeAdmission>();
                config.CreateMap<PayFeeAdmission, PayFeeAdmissionDTO>();

                config.CreateMap<RegisterAdmissionProfileDTO, StudentProfile>()
                .ForMember(dest => dest.AcademicTranscripts, opt => opt.MapFrom(src =>
                    src.AcademicTranscriptsMajor1.Select(x => new AcademicTranscriptDTO
                    {
                        SubjectName = x.SubjectName,
                        SubjectPoint = x.SubjectPoint,
                        TypeOfAcademicTranscript = x.TypeOfAcademicTranscript,
                        isMajor1 = true // Gán IsMajor1 = true
                    })
                    .Concat(
                        src.AcademicTranscriptsMajor2.Select(x => new AcademicTranscriptDTO
                        {
                            SubjectName = x.SubjectName,
                            SubjectPoint = x.SubjectPoint,
                            TypeOfAcademicTranscript = x.TypeOfAcademicTranscript,
                            isMajor1 = false // Gán IsMajor1 = false
                        })
                    )
                ));
                config.CreateMap<StudentProfile, AdmissionProfile_DTO>()
                .ForMember(dest => dest.AcademicTranscriptsMajor1, opt => opt.MapFrom(src =>
                    src.AcademicTranscripts
                        .Where(x => x.isMajor1 == true) // Lọc các phần tử có IsMajor1 = true
                        .Select(x => new AcademicTranscript
                        {
                            SubjectName = x.SubjectName,
                            SubjectPoint = x.SubjectPoint,
                            TypeOfAcademicTranscript = x.TypeOfAcademicTranscript
                        })
                ))
                .ForMember(dest => dest.AcademicTranscriptsMajor2, opt => opt.MapFrom(src =>
                    src.AcademicTranscripts
                        .Where(x => x.isMajor1 == false) // Lọc các phần tử có IsMajor1 = false
                        .Select(x => new AcademicTranscript
                        {
                            SubjectName = x.SubjectName,
                            SubjectPoint = x.SubjectPoint,
                            TypeOfAcademicTranscript = x.TypeOfAcademicTranscript
                        })
                ));

                config.CreateMap<AdmissionProfile_AO_DTO, StudentProfile>();
                config.CreateMap<StudentProfile, AdmissionProfile_AO_DTO>()
               .ForMember(dest => dest.CampusName, opt => opt.MapFrom(src => src.Campus.CampusName));

                config.CreateMap<PriorityDetail, PriorityDetailDTO>();
                config.CreateMap<PriorityDetailDTO, PriorityDetail>();

                // Mapping from AdmissionDetailForMajor to AdmissionDetailForMajorDto
                config.CreateMap<SubjectGroup, SubjectGroupDTO>()
                  .ForMember(dest => dest.SubjectGroup, opt => opt.MapFrom(src => src.ToString()))
                  .ForMember(dest => dest.SubjectGroupName, opt => opt.MapFrom(src => EnumExtensions.GetEnumDescription(src)));

                config.CreateMap<AdmissionDetailForMajor, AdmissionDetailForMajorDto>()
                .ForMember(dest => dest.TotalScore, opt => opt.MapFrom(src => src.StatusScore ? src.TotalScore : (decimal?)null))
                .ForMember(dest => dest.TotalScoreAcademic, opt => opt.MapFrom(src => src.StatusScoreAcademic ? src.TotalScoreAcademic : (decimal?)null))
                   .ForMember(dest => dest.subjectGroupDTOs,
                              opt => opt.MapFrom(src =>
                                  src.SubjectGroups.Select(g => new SubjectGroupDTO
                                  {
                                      SubjectGroup = g.ToString(),
                                      SubjectGroupName = EnumExtensions.GetEnumDescription(g)
                                  }).ToList()));
                // mapping get request change major for school service
                config.CreateMap<RequestChangeMajor_SS_DTO, Request>();
                config.CreateMap<Request, RequestChangeMajor_SS_DTO>();
                config.CreateMap<Major_RequestChange_DTO, Major>();
                config.CreateMap<Major, Major_RequestChange_DTO>();
                config.CreateMap<Account_RequestChangeMajor_DTO, Account>();
                config.CreateMap<Account, Account_RequestChangeMajor_DTO>();
                //request change major for student
                config.CreateMap<RequestChangeMajor_Student_DTO, Request>();
                config.CreateMap<Request, RequestChangeMajor_Student_DTO>();
                //request withdrawal
                config.CreateMap<RequestWithDrawalDTO, Request>();
                config.CreateMap<Request, RequestWithDrawalDTO>();

                config.CreateMap<RequestWithDrawal_Student_DTO, Request>();
                config.CreateMap<Request, RequestWithDrawal_Student_DTO>();
            });

            return mapperConfig.CreateMapper();
        }
    }
    public static class EnumExtensions
    {
        public static string GetDescription(this Enum value)
        {
            var field = value.GetType().GetField(value.ToString());
            var attribute = field.GetCustomAttribute<DescriptionAttribute>();

            return attribute != null ? attribute.Description : value.ToString();
        }
        public static List<string> SplitSubjects(string subjects)
        {
            return subjects.Split(new[] { '–' }, StringSplitOptions.RemoveEmptyEntries)
                           .Select(s => s.Trim())
                           .ToList();
        }
        public static string GetEnumDescription(Enum value)
        {
            var fieldInfo = value.GetType().GetField(value.ToString());

            var attributes = fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];

            return attributes != null && attributes.Length > 0 ? attributes[0].Description : value.ToString();
        }
    }
}
