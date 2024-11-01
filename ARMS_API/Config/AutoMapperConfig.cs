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
                config.CreateMap<RequestChangeMajor, RequestChangeMajorDTO>()
                .ForMember(dest => dest.MajorName, opt => opt.MapFrom(src => src.Major.MajorName))
                .ForMember(dest => dest.MajorID, opt => opt.MapFrom(src => src.Major.MajorID));
                // Priority
                config.CreateMap<PriorityDetail, PriorityDTO>()
                     .ForMember(dest => dest.TypeOfPriority, opt => opt.MapFrom(src =>
                        src.TypeOfPriority == TypeOfPriority.UT1 ? "Ưu tiên 1" :
                        src.TypeOfPriority == TypeOfPriority.UT2 ? "Ưu tiên 2" : "Không xác định"))
                     .ForMember(dest => dest.BonusPoint, opt => opt.MapFrom(src =>
                        src.TypeOfPriority == TypeOfPriority.UT1 ? 2 :
                        src.TypeOfPriority == TypeOfPriority.UT2 ? 1 : 0));
                // AdmissionGroup
                //config.CreateMap<AdmissionGroup, AdmissionGroupDTO>()
                //            .ForMember(dest => dest.SubjectGroupName, opt => opt.MapFrom(src => src.SubjectGroup.GetDescription())) 
                //            .ForMember(dest => dest.SubjectGroup, opt => opt.MapFrom(src => src.SubjectGroup.ToString()))
                //            .ForMember(dest => dest.Subject1, opt => opt.MapFrom(src => EnumExtensions.SplitSubjects(src.SubjectGroup.GetDescription()).ElementAtOrDefault(0))) // Get the first subject
                //            .ForMember(dest => dest.Subject2, opt => opt.MapFrom(src => EnumExtensions.SplitSubjects(src.SubjectGroup.GetDescription()).ElementAtOrDefault(1))) // Get the second subject
                //            .ForMember(dest => dest.Subject3, opt => opt.MapFrom(src => EnumExtensions.SplitSubjects(src.SubjectGroup.GetDescription()).ElementAtOrDefault(2))); // Get the third subject

                //config.CreateMap<AdmissionGroup, AdmissionGroup_AC_DTO>()
                //.ForMember(dest => dest.SubjectGroupName, opt => opt.MapFrom(src => src.SubjectGroup.GetDescription()));
                //config.CreateMap<AdmissionGroup_AC_DTO, AdmissionGroup>();
                //register admission
                config.CreateMap<AcademicTranscript, AcademicTranscriptDTO>();
                config.CreateMap<AcademicTranscriptDTO, AcademicTranscript>();

                config.CreateMap<RegisterAdmissionProfileDTO, StudentProfile>();
                config.CreateMap<StudentProfile, RegisterAdmissionProfileDTO>();

                config.CreateMap<AdmissionProfile_AO_DTO, StudentProfile>();
                config.CreateMap<StudentProfile, AdmissionProfile_AO_DTO>()

               .ForMember(dest => dest.CampusName, opt => opt.MapFrom(src => src.Campus.CampusName));
                config.CreateMap<PriorityDetail, PriorityDetailDTO>();
                config.CreateMap<PriorityDetailDTO, PriorityDetail>();

                config.CreateMap<PayFeeAdmission, PayFeeAdmissionDTO>();
                config.CreateMap<PayFeeAdmissionDTO, PayFeeAdmission>();
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

                // Mapping from AdmissionDetailForMajorDto to AdmissionDetailForMajor
                //config.CreateMap<AdmissionDetailForMajorDto, AdmissionDetailForMajor>()
                //    .ForMember(dest => dest.SubjectGroupsJson,
                //               opt => opt.MapFrom(src =>
                //                   JsonSerializer.Serialize(src.subjectGroupDTOs)));

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
        //public static string ConvertIntToSubjectGroupName(int value)
        //{
        //    if (Enum.IsDefined(typeof(SubjectGroup), value))
        //    {
        //        var subjectGroup = (SubjectGroup)value;
        //        return subjectGroup.ToString(); // Or use .GetDescription() if you prefer the description
        //    }
        //    return null; // or return a default string if needed
        //}
        //public static string ConvertIntToSubjectGroupDescription(int value)
        //{
        //    if (Enum.IsDefined(typeof(SubjectGroup), value))
        //    {
        //        var subjectGroup = (SubjectGroup)value;
        //        return GetEnumDescription(subjectGroup); // Call a method to get the description
        //    }
        //    return null; // Or return a default string if needed
        //}
        //public static string GetEnumDescription(SubjectGroup subjectGroup)
        //{
        //    var fieldInfo = subjectGroup.GetType().GetField(subjectGroup.ToString());
        //    var attributes = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);
        //    return attributes.Length > 0 ? attributes[0].Description : subjectGroup.ToString();
        //}
        public static string GetEnumDescription(Enum value)
        {
            var fieldInfo = value.GetType().GetField(value.ToString());

            var attributes = fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];

            return attributes != null && attributes.Length > 0 ? attributes[0].Description : value.ToString();
        }
    }
}
