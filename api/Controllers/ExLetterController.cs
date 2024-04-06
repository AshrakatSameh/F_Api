using api.IdentityServices;
using api.Interfaces;
using api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
        public async Task<IActionResult> Create(Exletter exLetter)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var Exlet = new Exletter()
            {
                Ser = exLetter.Ser,
                Noout2 = exLetter.Noout2,
                Noletter = exLetter.Noletter,
                Datecome = exLetter.Datecome,
                Sidecome = exLetter.Sidecome,
                Dateletter = exLetter.Dateletter,
                Description = exLetter.Description,
                Respons = exLetter.Respons,
                Noprevletter = exLetter.Noprevletter,
                Dateprevletter = exLetter.Dateprevletter,
                Noout = exLetter.Noout,
                Dateout = exLetter.Dateout,
                Sideout = exLetter.Sideout,
                Recevied = exLetter.Recevied,
                Notes = exLetter.Notes,
                Useradd = exLetter.Useradd,
                Dateadd = exLetter.Dateadd,
                Usermod = exLetter.Usermod,
                Datemod = exLetter.Datemod,
                DateMode = exLetter.DateMode
            

            };
            await _exLetter.Post(Exlet);

            return Ok(Exlet);
        }




        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(int id, Exletter exLetter)
        {
            var existingexLetter = await _exLetter.GetById(id);

            if (existingexLetter == null)
            {
                return BadRequest("exLetter not found");
            }

            try
            {
               existingexLetter.Ser = exLetter.Ser;
               existingexLetter.Noout2 = exLetter.Noout2;
               existingexLetter.Noletter = exLetter.Noletter;
               existingexLetter.Datecome = exLetter.Datecome;
               existingexLetter.Sidecome = exLetter.Sidecome;
               existingexLetter.Dateletter = exLetter.Dateletter;
               existingexLetter.Description = exLetter.Description;
               existingexLetter.Respons = exLetter.Respons;
               existingexLetter.Noprevletter = exLetter.Noprevletter;
               existingexLetter.Dateprevletter = exLetter.Dateprevletter;
               existingexLetter.Noout = exLetter.Noout;
               existingexLetter.Dateout = exLetter.Dateout;
               existingexLetter.Sideout = exLetter.Sideout;
               existingexLetter.Recevied = exLetter.Recevied;
               existingexLetter.Notes = exLetter.Notes;
               existingexLetter.Useradd = exLetter.Useradd;
               existingexLetter.Dateadd = exLetter.Dateadd;
               existingexLetter.Usermod = exLetter.Usermod;
               existingexLetter.Datemod = exLetter.Datemod;
                existingexLetter.DateMode = exLetter.DateMode;

                var updatedexLetter = await _exLetter.Put(existingexLetter);

                if (updatedexLetter == null)
                {
                    return BadRequest("Failed to update exLetter");
                }

                return Ok(updatedexLetter);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while updating exLetter");
            }
        }


        [HttpDelete("{id:int}")]
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
