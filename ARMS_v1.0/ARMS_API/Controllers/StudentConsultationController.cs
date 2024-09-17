using ARMS_API.Models;
using ARMS_API.ValidData;
using AutoMapper;
using Data.DTO;
using Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository.MajorRepo;
using Repository.StudentConsultationRepo;

namespace ARMS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentConsultationController : ControllerBase
    {
        private IStudentConsultationRepository _studentConsultationRepository;
        private readonly IMapper _mapper;
        private ValidStudentConsultation _validInput;
        public StudentConsultationController(IStudentConsultationRepository studentConsultationRepository, IMapper mapper, ValidStudentConsultation validInput)
        {
            _studentConsultationRepository = studentConsultationRepository;
            _mapper = mapper;
            _validInput = validInput;
        }
        [HttpPost]
        public async Task<IActionResult> AddStudentConsultation([FromBody] StudentConsultationDTO studentConsultationDTO)
        {
            try
            {
                // check data
                _validInput.InputStudentConsultation(studentConsultationDTO);
                //mapper
                StudentConsultation studentConsultation = _mapper.Map<StudentConsultation>(studentConsultationDTO);
                studentConsultation.Status = false;
                studentConsultation.DateReceive = DateTime.Now;
                //add new
                await _studentConsultationRepository.AddNewStudentConsultation(studentConsultation);
                return Ok(new ResponseViewModel()
                {
                    Status = true,
                    Message = "Đăng ký thành công!"
                });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseViewModel()
                {
                    Status = false,
                    Message = ex.Message
                });
            }
        }
    }
}
