﻿using AutoMapper;
using Data.DTO;

namespace ARMS_API.ValidData
{
    public class ValidStudentConsultation
    {
        private UserInput _userInput;
        public ValidStudentConsultation(UserInput userInput)
        {
            _userInput = userInput;
        }
        public void InputStudentConsultation(StudentConsultationDTO studentConsultationDTO)
        {
            try
            {
                if (studentConsultationDTO == null) throw new Exception("Không nhận được dữ liệu");
                if (string.IsNullOrEmpty(studentConsultationDTO.FullName)) throw new Exception("Không được để trống họ và tên");
                if (string.IsNullOrEmpty(studentConsultationDTO.Email)) throw new Exception("Không được để trống email");
                if (!_userInput.IsValidEmail(studentConsultationDTO.Email)) throw new Exception("Email không hợp lệ!");
                if (string.IsNullOrEmpty(studentConsultationDTO.PhoneNumber)) throw new Exception("Không được để trống số điện thoại");
                if (!_userInput.IsValidPhoneNumber(studentConsultationDTO.PhoneNumber)) throw new Exception("Số điện thoại không hợp lệ!");
                if (studentConsultationDTO.MajorID == null) throw new Exception("Không được để trống ngành học");
                if (string.IsNullOrEmpty(studentConsultationDTO.LinkFB)) throw new Exception("Không được để trống link facebook");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void UpdateStudentConsultation(StudentConsultation_AO_DTO studentConsultationDTO)
        {
            try
            {
                if (studentConsultationDTO == null) throw new Exception("Không nhận được dữ liệu");
                if (string.IsNullOrEmpty(studentConsultationDTO.FullName)) throw new Exception("Không được để trống họ và tên");
                if (string.IsNullOrEmpty(studentConsultationDTO.Email)) throw new Exception("Không được để trống email");
                if (!_userInput.IsValidEmail(studentConsultationDTO.Email)) throw new Exception("Email không hợp lệ!");
                if (string.IsNullOrEmpty(studentConsultationDTO.PhoneNumber)) throw new Exception("Không được để trống số điện thoại");
                if (!_userInput.IsValidPhoneNumber(studentConsultationDTO.PhoneNumber)) throw new Exception("Số điện thoại không hợp lệ!");
                if (studentConsultationDTO.MajorID == null) throw new Exception("Không được để trống ngành học");
                if (string.IsNullOrEmpty(studentConsultationDTO.LinkFB)) throw new Exception("Không được để trống link facebook");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
