using api.Dtos;
using api.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubExController : ControllerBase
    {
        private readonly ISubExService _service;

        public SubExController(ISubExService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var sub = await _service.GetAll();
            return Ok(sub); 
        }

        [HttpGet("{ser}")]
        public async Task<IActionResult> GetByIdAsync(int ser)
        {
            var sub = await _service.GetById(ser);
            return Ok(sub);
        }

        [HttpDelete]
        //[Authorize(Roles = "Admin")]
        public async Task <IActionResult> DeleteAllAsync(int ser)
        {
            var sub = await _service.Delete(ser);
            return Ok(sub);
        }

        [HttpPost]
        //[Authorize(Roles = "Admin")]
        public async Task<IActionResult> AddSubEx(SubExDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var sub = await _service.AddAsync(dto);
                return Ok(sub);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");

            }
        }

        [HttpPut]
        //[Authorize(Roles = "Admin")]
        public async Task<IActionResult> UpdateSubEx(int ser, SubExDto dto)
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
