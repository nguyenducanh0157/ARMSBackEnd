using ARMS_API.ValidData;
using AutoMapper;
using Data.DTO;
using Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository.MajorRepo;
using Service.StudentConsultationSer;

namespace ARMS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentConsultationController : ControllerBase
    {
        private IStudentConsultationService _studentConsultationService;
        private readonly IMapper _mapper;
        private ValidStudentConsultation _validInput;
        public StudentConsultationController(IStudentConsultationService studentConsultationService, IMapper mapper, ValidStudentConsultation validInput)
        {
            _studentConsultationService = studentConsultationService;
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
                studentConsultation.StudentConsultationId = Guid.NewGuid();
                studentConsultation.Status = StatusConsultation.Reception;
                studentConsultation.DateReceive = DateTime.Now;
                //add new
                await _studentConsultationService.AddNewStudentConsultation(studentConsultation);
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
        [HttpGet("download-template")]
        public IActionResult DownloadTemplate()
        {
            try
            {
                // Tính đường dẫn từ thư mục gốc của ứng dụng
                var rootPath = Directory.GetCurrentDirectory(); // Gốc của dự án
                var filePath = Path.Combine(rootPath, "File", "Đăng ký tư vấn.xlsx");

                if (!System.IO.File.Exists(filePath))
                {
                    return NotFound(new { message = "Không tìm thấy file." });
                }

                var fileBytes = System.IO.File.ReadAllBytes(filePath);
                return File(fileBytes, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Đăng ký tư vấn.xlsx");
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Đã xảy ra lỗi khi tải file.", details = ex.Message });
            }
        }


    }
}
