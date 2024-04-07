using api.IdentityServices;
using api.Interfaces;
using api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.ConstrainedExecution;
using System.Threading;
using System;
using Microsoft.AspNetCore.Authorization;
using api.Dtos;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubLetterController : ControllerBase
    {
        private readonly ISubLetterService _subLetterService;

        public SubLetterController(ISubLetterService subLetterService)
        {
            _subLetterService = subLetterService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var subLet = await _subLetterService.GetAll();
            return Ok(subLet);

        }


        [HttpGet("{ser}")]
        public async Task<IActionResult> GetByIdAsync(int ser)
        {
            if (ser == null)
            {
                return BadRequest("Not Found");

            }

            var subLets = await _subLetterService.GetById(ser);
            if (subLets == null)
            {
                return BadRequest("Not Found");
            }
            return Ok(subLets);
        }

        [HttpPost]
        //[Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create(SubLetterDto dto)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var sub = await _subLetterService.AddAsync(dto);
                return Ok(sub);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");

            }
        }


        [HttpPut]
        public async Task<IActionResult> Update(int ser, SubLetterDto subletter)
        {
            if ( ser != null)
            {
                var updeted = await _subLetterService.Update(ser, subletter);
                return Ok(updeted);
            }

            return BadRequest();
        }


        [HttpDelete]
        //[Authorize(Roles = "Admin")]
        public async Task<ActionResult<SubLetter>> Delete(int id)
        {

            var sub = await _subLetterService.Delete(id);
            return Ok(sub);
        }
    }
}
