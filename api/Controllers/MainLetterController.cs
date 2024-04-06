using api.Interfaces;
using api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading;
using System;

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
        public async Task<IActionResult> Create(MainLetter mainLetter)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var Mainlet = new MainLetter()
            {
                Id = mainLetter.Id,
                Noletter = mainLetter.Noletter,
                Datecome = mainLetter.Datecome,
                Code = mainLetter.Code,
                Sidecome = mainLetter.Sidecome,
                Dateletter = mainLetter.Dateletter,
                Description = mainLetter.Description,
                Respons = mainLetter.Respons,
                Dept = mainLetter.Dept,
                Datefolow = mainLetter.Datefolow,
                Noout = mainLetter.Noout,
                Dateout = mainLetter.Dateout,
                Sideout = mainLetter.Sideout,
                Recevied = mainLetter.Recevied,
                Notes = mainLetter.Notes,
                Noout1 = mainLetter.Noout1,
                Dateprevletter = mainLetter.Dateprevletter,
                Useradd = mainLetter.Useradd,
                Dateadd = mainLetter.Dateadd,
                Usermod = mainLetter.Usermod,
                Datemod = mainLetter.Datemod,
                DateMode = mainLetter.DateMode,



        };
            await _mainLetter.Post(Mainlet);

            return Ok(Mainlet);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(int id, MainLetter mainLetter)
        {
            var existingMainLetter = await _mainLetter.GetById(id);

            if (existingMainLetter == null)
            {
                return BadRequest("MainLetter not found");
            }

            try
            {
                existingMainLetter.Id = mainLetter.Id;
                existingMainLetter.Noletter = mainLetter.Noletter;
                existingMainLetter.Datecome = mainLetter.Datecome;
                existingMainLetter.Code = mainLetter.Code;
                existingMainLetter.Sidecome = mainLetter.Sidecome;
                existingMainLetter.Dateletter = mainLetter.Dateletter;
                existingMainLetter.Description = mainLetter.Description;
                existingMainLetter.Respons = mainLetter.Respons;
                existingMainLetter.Dept = mainLetter.Dept;
                existingMainLetter.Datefolow = mainLetter.Datefolow;
                existingMainLetter.Noout = mainLetter.Noout;
                existingMainLetter.Dateout = mainLetter.Dateout;
                existingMainLetter.Sideout = mainLetter.Sideout;
                existingMainLetter.Recevied = mainLetter.Recevied;
                existingMainLetter.Notes = mainLetter.Notes;
                existingMainLetter.Noout1 = mainLetter.Noout1;
                existingMainLetter.Dateprevletter = mainLetter.Dateprevletter;
                existingMainLetter.Useradd = mainLetter.Useradd;
                existingMainLetter.Dateadd = mainLetter.Dateadd;
                existingMainLetter.Usermod = mainLetter.Usermod;
                existingMainLetter.Datemod = mainLetter.Datemod;
                existingMainLetter.DateMode = mainLetter.DateMode;

                var updatedMainLetter = await _mainLetter.Put(existingMainLetter);

                if (updatedMainLetter == null)
                {
                    return BadRequest("Failed to update updatedMainLetter");
                }

                return Ok(updatedMainLetter);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while updating updatedMainLetter");
            }
        }



        [HttpDelete("{id:int}")]
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
