using api.Dtos;
using api.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpController : ControllerBase
    {
        private readonly IEmpService _service;

        public EmpController(IEmpService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var emp = await _service.GetAll();
            return Ok(emp);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(int ser)
        {
            var emp = await _service.GetById(ser);
            return Ok(emp);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(int ser)
        {
            var emp = _service.Delete(ser);
            return Ok(emp);
        }

        [HttpPost]
        public async Task<IActionResult> AddEmployee(EmpDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var emp = await _service.Add(dto);
                return Ok(emp);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");

            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateEmployee(int ser, EmpDto dto)
        {
            if (ser != null)
            {
                var updeted = await _service.Update(ser, dto);
                return Ok(updeted);
            }

            return BadRequest();
        }
    }
}
 