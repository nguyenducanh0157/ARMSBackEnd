﻿using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO
{
    public class RegisterAdmissionProfileDTO
    {
        public string Fullname { get; set; }
        public DateTime? Dob { get; set; }
        public bool? Gender { get; set; }
        public string? Nation { get; set; } // dân tộc
        public string? CitizenIentificationNumber { get; set; } // căn cước công dân
        public DateTime? CIDate { get; set; } // ngày cấp
        public string? CIAddress { get; set; } // nơi cấp
        public string? Province { get; set; } // tỉnh
        public string? District { get; set; } // huyện
        public string? Ward { get; set; } // xã 
        public string? SpecificAddress { get; set; } // địa chỉ nhà
        public string EmailStudent { get; set; } // duy nhất
        public string PhoneStudent { get; set; } // duy nhất
        public string? FullnameParents { get; set; }
        public string? PhoneParents { get; set; }
        public string CampusId { get; set; }
        public string? Major1 { get; set; }
        public string? Major2 { get; set; }
        public int? YearOfGraduation { get; set; }
        public string? SchoolName { get; set; }
        public bool? RecipientResults { get; set; } // true học sinh nhận kết quả
        public bool? PermanentAddress { get; set; } // true - địa chỉ thường trú
        public string? AddressRecipientResults { get; set; } // lưu địa chỉ nhận khác
        public string? ImgCitizenIdentification1 { get; set; }
        public string? ImgCitizenIdentification2 { get; set; }
        public string? ImgDiplomaMajor1 { get; set; } // ảnh bằng ngành 1
        public string? ImgDiplomaMajor2 { get; set; } // ảnh bằng ngành 2
        public string? Imgpriority { get; set; } // ảnh bằng chứng xác nhận ưu tiên
        public string? ImgAcademicTranscript1 { get; set; }//kỳ 1 - lớp 10
        public string? ImgAcademicTranscript2 { get; set; }//kỳ 2 - lớp 10
        public string? ImgAcademicTranscript3 { get; set; }//cuối năm - lớp 10
        public string? ImgAcademicTranscript4 { get; set; }//kỳ 1 - lớp 11
        public string? ImgAcademicTranscript5 { get; set; }//kỳ 2 - lớp 11
        public string? ImgAcademicTranscript6 { get; set; }//Cuối năm - lớp 11
        public string? ImgAcademicTranscript7 { get; set; }//kỳ 1 - lớp 12
        public string? ImgAcademicTranscript8 { get; set; }//kỳ 2 - lớp 12
        public string? ImgAcademicTranscript9 { get; set; }//cuối năm - lớp 12
        public virtual TypeOfDiploma? TypeOfDiplomaMajor1 { get; set; }// loại bằng ngành 1
        public virtual TypeOfTranscript? TypeOfTranscriptMajor1 { get; set; }// loại học bạ ngành 1
        public virtual TypeOfDiploma? TypeOfDiplomaMajor2 { get; set; }// loại bằng ngành 2
        public virtual TypeOfTranscript? TypeOfTranscriptMajor2 { get; set; }// loại học bạ ngành 2
        public int? PriorityDetailPriorityID { get; set; }
        public virtual TypeofStatusForMajor? TypeofStatusMajor1 { get; set; } // trạng thái xét tuyển ngành 1
        public virtual TypeofStatusForMajor? TypeofStatusMajor2 { get; set; } // trạng thái xét tuyển ngành 2
        public virtual TypeofStatus? TypeofStatusProfile { get; set; } // trạng thái hồ sơ
        public virtual ICollection<AcademicTranscript_View_DTO>? AcademicTranscriptsMajor1 { get; set; }
        public virtual ICollection<AcademicTranscript_View_DTO>? AcademicTranscriptsMajor2 { get; set; }

        // view
        public string? CampusName { get; set; }
        public virtual PriorityDetailDTO? PriorityDetail { get; set; }// loại điểm ưu tiên
        public virtual PayFeeAdmissionDTO? PayFeeAdmission { get; set; }

    }
    public class AcademicTranscript_View_DTO
    {
        public string SubjectName { get; set; }
        public decimal SubjectPoint { get; set; }
        public TypeOfAcademicTranscript TypeOfAcademicTranscript { get; set; }
    }
    public class AcademicTranscriptDTO
    {
        public string SubjectName { get; set; }
        public decimal SubjectPoint { get; set; }
        public bool isMajor1 { get; set; }
        public TypeOfAcademicTranscript TypeOfAcademicTranscript { get; set; }
    }
    public class RequestSearchRegisterAdmissionProfileDTO
    {
        public string? CitizenIentificationNumber { get; set; }
    }
    public class PriorityDetailDTO
    {
        public int PriorityID { get; set; }
        public string PriorityName { get; set; }
        public string PriorityDescription { get; set; }
        public TypeOfPriority TypeOfPriority { get; set; }
    }
    public class PayFeeAdmissionDTO
    {
        public string TxnRef { get; set; }
        public decimal Amount { get; set; }
        public string BankCode { get; set; }
        public string BankTranNo { get; set; }
        public string CardType { get; set; }
        public string OrderInfo { get; set; }
        public DateTime PayDate { get; set; }
        public string ResponseCode { get; set; }
        public string TmnCode { get; set; }
        public string TransactionNo { get; set; }
        public string TransactionStatus { get; set; }
        public string SecureHash { get; set; }
        public bool isFeeRegister { get; set; }
    }
    public class AdmissionProfile_AO_DTO
    {
        public Guid SpId { get; set; }
        public string? StudentCode { get; set; }
        public string Fullname { get; set; }
        public DateTime? Dob { get; set; }
        public bool? Gender { get; set; }
        public string? Nation { get; set; } // dân tộc
        public string? CitizenIentificationNumber { get; set; } // căn cước công dân
        public DateTime? CIDate { get; set; } // ngày cấp
        public string? CIAddress { get; set; } // nơi cấp
        public string? Province { get; set; } // tỉnh
        public string? District { get; set; } // huyện
        public string? Ward { get; set; } // xã 
        public string? SpecificAddress { get; set; } // địa chỉ nhà
        public string EmailStudent { get; set; } // duy nhất
        public string PhoneStudent { get; set; } // duy nhất
        public string? FullnameParents { get; set; }
        public string? PhoneParents { get; set; }
        public string CampusId { get; set; }
        public string? Major1 { get; set; }
        public string? Major2 { get; set; }
        public int? YearOfGraduation { get; set; }
        public string? SchoolName { get; set; }
        public bool? RecipientResults { get; set; } // true học sinh nhận kết quả
        public bool? PermanentAddress { get; set; } // true - địa chỉ thường trú
        public string? AddressRecipientResults { get; set; } // lưu địa chỉ nhận khác
        public string? ImgCitizenIdentification1 { get; set; }
        public string? ImgCitizenIdentification2 { get; set; }
        public string? ImgDiploma { get; set; } // ảnh bằng
        public string? Imgpriority { get; set; } // ảnh bằng chứng xác nhận ưu tiên
        public string? ImgAcademicTranscript1 { get; set; } // kỳ 1_10 | lop10  | lop12 | Kỳ 1_11 | Lop10  |
        public string? ImgAcademicTranscript2 { get; set; } // kỳ 2_10 | lop11  |       | Kỳ 2_11 | Lop11  |
        public string? ImgAcademicTranscript3 { get; set; } // kỳ 1_11 | lop12  |       | Kỳ 1_12 | HK1 12 |
        public string? ImgAcademicTranscript4 { get; set; } // kỳ 2_11 |        |       |         |        |
        public string? ImgAcademicTranscript5 { get; set; } // kỳ 1_12 |        |       |         |        |
        public bool? PayFee { get; set; } // trạng thái thanh toán
        public virtual TypeOfDiploma TypeOfDiploma { get; set; }// loại bằng
        public virtual TypeOfTranscript? TypeOfTranscript { get; set; }// loại học bạ
        public virtual TypeofStatus? TypeofStatus { get; set; }
        public int PriorityDetailPriorityID { get; set; }
        public virtual ICollection<AcademicTranscriptDTO>? AcademicTranscripts { get; set; }

        // view
        public string? CampusName { get; set; }
        public virtual PriorityDetailDTO? PriorityDetail { get; set; }// loại điểm ưu tiên
    }
}
