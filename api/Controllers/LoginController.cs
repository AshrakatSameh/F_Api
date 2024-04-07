using api.Dtos;
using api.IdentityServices;
using api.Interfaces;
using api.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService _loginService;

        public LoginController(ILoginService loginService)
        {
            _loginService = loginService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var logs = await _loginService.GetAll();
            return Ok(logs);

        }


        [HttpGet("{id:int}")]

        public async Task<IActionResult> GetByIdAsync(int id)
        {
            if (id == null)
            {
                return BadRequest("Not Found");

            }

            var logs = await _loginService.GetById(id);
            if (logs == null)
            {
                return BadRequest("Not Found");
            }
            return Ok(logs);
        }

        [HttpPost]
        public async Task<IActionResult> AddLogin(LoginDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var sub = await _loginService.Add(dto);
                return Ok(sub);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");

            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateLogin(int id, LoginDto dto)
        {
            if (id != null)
            {
                var updeted = await _loginService.Update(id, dto);
                return Ok(updeted);
            }

            return BadRequest();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Login>> Delete(int id)
        {


            try
            {
                var Dep = await _loginService.GetById(id);
                if (Dep == null)
                {
                    return BadRequest("Not Found");
                }

                return await _loginService.Delete(id);

            }

            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                   "Error deleting data");
            }
        }
    }
}
