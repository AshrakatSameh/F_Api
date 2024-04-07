using api.Dtos;
using api.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MainExController : ControllerBase
    {
        private readonly IMainEx _service;

        public MainExController(IMainEx service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> AddMainEx(MainExDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var main = await _service.Add(dto);
                return Ok(main);
            }catch(Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");

            }
        }

        [HttpGet("All")]
        public async Task<IActionResult> GetAllAsync()
        {
            var main = await _service.GetAll();
            return Ok(main);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var main = await _service.GetById(id);
            return Ok(main);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var main = _service.Delete(id);
            return Ok(main);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateMainEx(int id, MainExDto dto)
        {
            if (id != null)
            {
                var updeted = await _service.Update(id, dto);
                return Ok(updeted);
            }

            return BadRequest();
        }
    }
}
