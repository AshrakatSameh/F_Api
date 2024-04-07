using api.Interfaces;
using api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading;
using System;
using Microsoft.AspNetCore.Authorization;
using api.Dtos;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MainLetterController : ControllerBase
    {
        private readonly IMainLetterService _mainLetter;

        public MainLetterController(IMainLetterService mainLetter)
        {
            _mainLetter = mainLetter;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var mainLetts = await _mainLetter.GetAll();
            return Ok(mainLetts);

        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            if (id == null)
            {
                return BadRequest("Not Found");

            }

            var mainLetts = await _mainLetter.GetById(id);
            if (mainLetts == null)
            {
                return BadRequest("Not Found");
            }
            return Ok(mainLetts);
        }

        [HttpPost]
        //[Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create(MainLetterDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var main = await _mainLetter.Add(dto);
                return Ok(main);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");

            }
        }

        [HttpPut]
        //[Authorize(Roles = "Admin")]
        public async Task<IActionResult> Update(int id, MainLetterDto mainLetter)
        {

            if (id != null)
            {
                var updeted = await _mainLetter.Update(id, mainLetter);
                return Ok(updeted);
            }

            return BadRequest();
        }



        [HttpDelete("{id:int}")]
        //[Authorize(Roles = "Admin")]
        public async Task<ActionResult<MainLetter>> Delete(int id)
        {


            try
            {
                var mainlet = await _mainLetter.GetById(id);
                if (mainlet == null)
                {
                    return BadRequest("Not Found");
                }

                return await _mainLetter.Delete(id);

            }

            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                   "Error deleting data");
            }
        }
    }
}
