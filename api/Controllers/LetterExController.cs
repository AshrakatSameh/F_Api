using api.Dtos;
using api.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LetterExController : ControllerBase
    {
        private readonly ILetterExService _service;

        public LetterExController(ILetterExService service)
        {
            _service = service;
        }

        [HttpGet("GetAllLetterEx")]
        public async Task<IActionResult> GetAllAsync()
        {
            var letterEx = await _service.GetAll();
            return Ok(letterEx);
        }

        [HttpGet("{ser}")]
        public async Task<IActionResult> GetById(int ser)
        {
            var letterEx = await _service.GetById(ser);
            return Ok(letterEx);
        }

        [HttpPost]

        public async Task<IActionResult> AddLetterEx(LettterexDto dto)
        {
           
       
            var newLetterEx = await _service.Add(dto);
            return Ok(newLetterEx);
          
            
          
        }

        [HttpPut]
        public async Task<IActionResult> UpdateLetterEx(int ser , LettterexDto dto)
        {
            if (ser != null)
            {
                var updeted= await _service.Update(ser, dto);
                return Ok(updeted);
            }

            return BadRequest();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteLetterEx(int ser)
        {
            if(ser != null)
            {
                return Ok(await _service.Delete(ser));
            }
            return BadRequest();
        }
    }
}
