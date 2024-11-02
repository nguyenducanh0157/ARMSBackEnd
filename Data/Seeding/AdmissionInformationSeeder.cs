﻿using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Seeding
{
    public class AdmissionInformationSeeder
    {
        private readonly ModelBuilder modelBuilder;

        public AdmissionInformationSeeder(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }
        public void Seed()
        {
            // seed AdmissionInformation
            modelBuilder.Entity<AdmissionInformation>().HasData(
               new AdmissionInformation()
               {
                   AdmissionInformationID = 1,
                   FeeRegister = 100000m,
                   FeeAdmission = 4600000m,
                   CampusId ="Hanoi",
                   Year = 2024,
                   Status = true,
                   StartAdmission = new DateTime(2023, 8, 01, 00, 00, 0),
                   EndAdmission = new DateTime(2024, 8, 30, 23, 59, 59),
                   AdmissionProfileDescription = "01 Phiếu đăng ký học theo mẫu quy định của trường. Phiếu đăng ký học thí sinh có thể điền trực tiếp, hoặc tải về tự in tại đây, hoặc đến nhận tại văn phòng tuyển sinh trên toàn quốc.\r\n01 Bản sao công chứng Căn cước công dân hoặc Chứng minh nhân dân.\r\n01 Bản sao công chứng Bằng tốt nghiệp hoặc Giấy chứng nhận tốt nghiệp tạm thời.\r\n01 Bản sao công chứng bảng điểm(nếu xét học bạ).\r\n2 ảnh 3x4\r\n"
               },
                new AdmissionInformation()
                {
                    AdmissionInformationID = 2,
                    FeeRegister = 100000m,
                    FeeAdmission = 4600000m,
                    CampusId = "Danang",
                    Year = 2024,
                    Status = true,
                    StartAdmission = new DateTime(2023, 8, 01, 00, 00, 0),
                    EndAdmission = new DateTime(2024, 8, 30, 23, 59, 59),
                    AdmissionProfileDescription = "01 Phiếu đăng ký học theo mẫu quy định của trường. Phiếu đăng ký học thí sinh có thể điền trực tiếp, hoặc tải về tự in tại đây, hoặc đến nhận tại văn phòng tuyển sinh trên toàn quốc.\r\n01 Bản sao công chứng Căn cước công dân hoặc Chứng minh nhân dân.\r\n01 Bản sao công chứng Bằng tốt nghiệp hoặc Giấy chứng nhận tốt nghiệp tạm thời.\r\n01 Bản sao công chứng bảng điểm(nếu xét học bạ).\r\n2 ảnh 3x4\r\n"
                },
                new AdmissionInformation()
                {
                    AdmissionInformationID = 3,
                    FeeRegister = 100000m,
                    FeeAdmission = 4600000m,
                    CampusId = "Cantho",
                    Year = 2024,
                    Status = true,
                    StartAdmission = new DateTime(2023, 8, 01, 00, 00, 0),
                    EndAdmission = new DateTime(2024, 8, 30, 23, 59, 59),
                    AdmissionProfileDescription = "01 Phiếu đăng ký học theo mẫu quy định của trường. Phiếu đăng ký học thí sinh có thể điền trực tiếp, hoặc tải về tự in tại đây, hoặc đến nhận tại văn phòng tuyển sinh trên toàn quốc.\r\n01 Bản sao công chứng Căn cước công dân hoặc Chứng minh nhân dân.\r\n01 Bản sao công chứng Bằng tốt nghiệp hoặc Giấy chứng nhận tốt nghiệp tạm thời.\r\n01 Bản sao công chứng bảng điểm(nếu xét học bạ).\r\n2 ảnh 3x4\r\n"
                },
                new AdmissionInformation()
                {
                    AdmissionInformationID = 4,
                    FeeRegister = 100000m,
                    FeeAdmission = 4600000m,
                    CampusId = "HCM",
                    Year = 2024,
                    Status = true,
                    StartAdmission = new DateTime(2023, 8, 01, 00, 00, 0),
                    EndAdmission = new DateTime(2024, 8, 30, 23, 59, 59),
                    AdmissionProfileDescription = "01 Phiếu đăng ký học theo mẫu quy định của trường. Phiếu đăng ký học thí sinh có thể điền trực tiếp, hoặc tải về tự in tại đây, hoặc đến nhận tại văn phòng tuyển sinh trên toàn quốc.\r\n01 Bản sao công chứng Căn cước công dân hoặc Chứng minh nhân dân.\r\n01 Bản sao công chứng Bằng tốt nghiệp hoặc Giấy chứng nhận tốt nghiệp tạm thời.\r\n01 Bản sao công chứng bảng điểm(nếu xét học bạ).\r\n2 ảnh 3x4\r\n"
                },
                new AdmissionInformation()
                {
                    AdmissionInformationID = 5,
                    FeeRegister = 100000m,
                    FeeAdmission = 4600000m,
                    CampusId = "Thanhhoa",
                    Year = 2024,
                    Status = true,
                    StartAdmission = new DateTime(2023, 8, 01, 00, 00, 0),
                    EndAdmission = new DateTime(2024, 8, 30, 23, 59, 59),
                    AdmissionProfileDescription = "01 Phiếu đăng ký học theo mẫu quy định của trường. Phiếu đăng ký học thí sinh có thể điền trực tiếp, hoặc tải về tự in tại đây, hoặc đến nhận tại văn phòng tuyển sinh trên toàn quốc.\r\n01 Bản sao công chứng Căn cước công dân hoặc Chứng minh nhân dân.\r\n01 Bản sao công chứng Bằng tốt nghiệp hoặc Giấy chứng nhận tốt nghiệp tạm thời.\r\n01 Bản sao công chứng bảng điểm(nếu xét học bạ).\r\n2 ảnh 3x4\r\n"
                }
                );

        }
    }
}