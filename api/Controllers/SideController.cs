using api.Dtos;
using api.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SideController : ControllerBase
    {
        private readonly ISideService _service;

        public SideController(ISideService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var side = await _service.GetAll();
            return Ok(side);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(int ser)
        {
            var side = await _service.GetById(ser);
            return Ok(side);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(int ser)
        {
            var side = _service.Delete(ser);
            return Ok(side);
        }

        [HttpPost]
        public async Task<IActionResult> AddEmployee(SideDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var side = await _service.Add(dto);
                return Ok(side);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");

            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateSide(int ser, SideDto dto)
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
