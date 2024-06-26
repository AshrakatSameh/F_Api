﻿using api.Dtos;
using api.IdentityServices;
using api.Interfaces;
using api.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.ConstrainedExecution;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExLetterController : ControllerBase
    {
        private readonly IExLetterService _exLetter;

        public ExLetterController(IExLetterService exLetter)
        {
            _exLetter = exLetter;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var exLetts = await _exLetter.GetAll();
            return Ok(exLetts);

        }

        [HttpGet("{id:int}")]

        public async Task<IActionResult> GetByIdAsync(int id)
        {
            if (id == null)
            {
                return BadRequest("Not Found");

            }

            var exLetts = await _exLetter.GetById(id);
            if (exLetts == null)
            {
                return BadRequest("Not Found");
            }
            return Ok(exLetts);
        }



        [HttpPost]
        //[Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create(ExLetterDto exLetter)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var newExLetter = await _exLetter.Add(exLetter);
            return Ok(newExLetter);

        }




        [HttpPut]
        //[Authorize(Roles = "Admin")]
        public async Task<IActionResult> Update(int id, ExLetterDto exLetter)
        {
            if (id != null)
            {
                var updeted = await _exLetter.Update(id, exLetter);
                return Ok(updeted);
            }

            return BadRequest();
        }


        [HttpDelete("{id:int}")]
        //[Authorize(Roles = "Admin")]
        public async Task<ActionResult<Exletter>> Delete(int id)
        {


            try
            {
                var exlet = await _exLetter.GetById(id);
                if (exlet == null)
                {
                    return BadRequest("Not Found");
                }

                return await _exLetter.Delete(id);

            }

            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                   "Error deleting data");
            }
        }

    }
}
