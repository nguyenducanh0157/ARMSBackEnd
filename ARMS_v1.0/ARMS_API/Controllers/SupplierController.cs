using AutoMapper;
using Data.DTO;
using Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository.MajorRepo;
using Repository.SupplierRepo;

namespace ARMS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        private ISupplierRepository _supplierRepository;
        private readonly IMapper _mapper;
        public SupplierController(ISupplierRepository supplierRepository, IMapper mapper)
        {
            _supplierRepository = supplierRepository;
            _mapper = mapper;
        }
        [HttpGet("get-suplliers")]
        public async Task<IActionResult> GetSuppliers()
        {
            try
            {
                List<Supplier> response = await _supplierRepository.GetSuppliers();
                return Ok(response);

            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpGet("count-supllier")]
        public async Task<IActionResult> CountSupllier()
        {
            try
            {
                int response = await _supplierRepository.CountSupplier();
                return Ok(response);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
