﻿using ARMS_API.ValidData;
using AutoMapper;
using Data.DTO;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.AdmissionInformationSer;
using Service.AdmissionTimeSer;
using Service.CampusSer;
using System.Collections.Generic;

namespace ARMS_API.Controllers.AdmissionCouncil
{
    [Route("api/admission-council/[controller]")]
    [ApiController]
    //[Authorize(Roles = "AdmissionCouncil")]
    public class AdmissionInformationController : ControllerBase
    {
        private IAdmissionInformationService _admissionInformationService;
        private ICampusService _campusService;
        private readonly IMapper _mapper;
        private ValidAdmissionInformation _validAdmissionInformation;
        public AdmissionInformationController(IAdmissionInformationService admissionInformationService, IMapper mapper, ICampusService campusService, ValidAdmissionInformation validAdmissionInformation)
        {
            _admissionInformationService = admissionInformationService;
            _mapper = mapper;
            _campusService = campusService;
            _validAdmissionInformation = validAdmissionInformation;
        }
        [HttpGet("get-admission-information")]
        public async Task<IActionResult> GetAdmissionInformation(string CampusId)
        {
            try
            {
                List <AdmissionInformation> response = await _admissionInformationService.GetAdmissionInformation(CampusId);
                List<AdmissionInformation_AC_DTO> responeResult = _mapper.Map<List<AdmissionInformation_AC_DTO>>(response);
                return Ok(responeResult);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpGet("get-admission-information-by-id")]
        public async Task<IActionResult> GetAdmissionInformationById(int AdmissionInformationID)
        {
            try
            {
                AdmissionInformation response = await _admissionInformationService.GetAdmissionInformationById(AdmissionInformationID);
                AdmissionInformation_AC_DTO responeResult = _mapper.Map<AdmissionInformation_AC_DTO>(response);
                return Ok(responeResult);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPost("add-admission-time")]
        public async Task<IActionResult> AddAdmissionTime([FromBody] AdmissionInformation_Update_DTO AdmissionInformationDTO)
        {
            try
            {
                //check data
                _validAdmissionInformation.ValidDataAdmissionInfor(AdmissionInformationDTO);
                //mapper
                AdmissionInformation AdmissionInformation = _mapper.Map<AdmissionInformation>(AdmissionInformationDTO);
                //add new
                await _admissionInformationService.Add(AdmissionInformation);
                return Ok(new ResponseViewModel()
                {
                    Status = true,
                    Message = "Tạo mới mới thành công!"
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseViewModel()
                {
                    Status = false,
                    Message = ex.Message
                });
            }
        }
        [HttpPut("update-admission-information")]
        public async Task<IActionResult> UpdateAdmissionInformation(AdmissionInformation_Update_DTO AdmissionInformationDTO)
        {
            try
            {
                var checkdata = await _admissionInformationService.GetAdmissionInformationById(AdmissionInformationDTO.AdmissionInformationID);
                if (checkdata == null) return NotFound();
                //check data
                _validAdmissionInformation.ValidDataAdmissionInfor(AdmissionInformationDTO);
                //mapper
                AdmissionInformation admissionInformation = _mapper.Map<AdmissionInformation>(AdmissionInformationDTO);
                await _admissionInformationService.UpdateAdmissionInformation(admissionInformation);
                return Ok(new ResponseViewModel()
                {
                    Status = true,
                    Message = "Cập nhật thành công!"
                });

            }
            catch (Exception)
            {

                return BadRequest();
            }
        }
    }
}
