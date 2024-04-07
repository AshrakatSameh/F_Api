using api.IdentityServices;
using api.Interfaces;
using api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.ConstrainedExecution;
using System.Threading;
using System;
using Microsoft.AspNetCore.Authorization;

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


        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            if (id == null)
            {
                return BadRequest("Not Found");

            }

            var subLets = await _subLetterService.GetById(id);
            if (subLets == null)
            {
                return BadRequest("Not Found");
            }
            return Ok(subLets);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create(SubLetter subletter)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var subLett = new SubLetter()
            {
                Ser = subletter.Ser,
                Nletter = subletter.Nletter,
                Noout1 = subletter.Noout1,
                Datecome = subletter.Datecome,
                Sidecome = subletter.Sidecome,
                Dateletter = subletter.Dateletter,
                Description = subletter.Description,
                Respons = subletter.Respons,
                Noprevletter = subletter.Noprevletter,
                Dateprevletter = subletter.Dateprevletter,
                Noout = subletter.Noout,
                Dateout = subletter.Dateout,
                Sideout = subletter.Sideout,
                Recevied = subletter.Recevied,
                Notes = subletter.Notes,
                Useradd = subletter.Useradd,
                Dateadd = subletter.Dateadd,
                Usermod = subletter.Usermod,
                Datemod = subletter.Datemod,
                DateMode = subletter.DateMode,

        };
            await _subLetterService.Post(subLett);

            return Ok(subLett);
        }


        [HttpPut("{id:int}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Update(int id, SubLetter subletter)
        {
            var existingSubLetter = await _subLetterService.GetById(id);

            if (existingSubLetter == null)
            {
                return BadRequest("SubLetter not found");
            }

            try
            {
                existingSubLetter.Ser = subletter.Ser;
                existingSubLetter.Nletter = subletter.Nletter;
                existingSubLetter.Noout1 = subletter.Noout1;
                existingSubLetter.Datecome = subletter.Datecome;
                existingSubLetter.Sidecome = subletter.Sidecome;
                existingSubLetter.Dateletter = subletter.Dateletter;
                existingSubLetter.Description = subletter.Description;
                existingSubLetter.Respons = subletter.Respons;
                existingSubLetter.Noprevletter = subletter.Noprevletter;
                existingSubLetter.Dateprevletter = subletter.Dateprevletter;
                existingSubLetter.Noout = subletter.Noout;
                existingSubLetter.Dateout = subletter.Dateout;
                existingSubLetter.Sideout = subletter.Sideout;
                existingSubLetter.Recevied = subletter.Recevied;
                existingSubLetter.Notes = subletter.Notes;
                existingSubLetter.Useradd = subletter.Useradd;
                existingSubLetter.Dateadd = subletter.Dateadd;
                existingSubLetter.Usermod = subletter.Usermod;
                existingSubLetter.Datemod = subletter.Datemod;
                existingSubLetter.DateMode = subletter.DateMode;

                var updatedSubLetter = await _subLetterService.Put(existingSubLetter);

                if (updatedSubLetter == null)
                {
                    return BadRequest("Failed to update SubLetter");
                }

                return Ok(updatedSubLetter);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while updating SubLetter");
            }
        }


        [HttpDelete("{id:int}")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<SubLetter>> Delete(int id)
        {


            try
            {
                var subLett = await _subLetterService.GetById(id);
                if (subLett == null)
                {
                    return BadRequest("Not Found");
                }

                return await _subLetterService.Delete(id);

            }

            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                   "Error deleting data");
            }
        }
    }
}
