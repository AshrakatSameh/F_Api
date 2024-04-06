using api.Interfaces;
using api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeptController : ControllerBase
    {
        private readonly IDeptService _deptService;

        public DeptController(IDeptService deptService)
        {
            _deptService = deptService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var depts = await _deptService.GetAll();
            return Ok(depts);

        }

        [HttpGet("{id:int}")]
       
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            if (id == null)
            {
                return BadRequest("Not Found");

            }

            var depts = await _deptService.GetById(id);
            if(depts == null)
            {
                return BadRequest("Not Found");
            }
            return Ok(depts);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Dept dept)
        {
            if (!ModelState.IsValid)
            {
                 return BadRequest(ModelState);
            }

            var Dept = new Dept()
            {
                Id = dept.Id,
                DeptName = dept.DeptName

            };
            await _deptService.Post(Dept);

            return Ok(Dept);
        }



        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(int id, Dept dept)
        {
            var existingDept = await _deptService.GetById(id);

            if (existingDept == null)
            {
                return BadRequest("Department not found");
            }

            try
            {
                existingDept.DeptName = dept.DeptName;

                var updatedDept = await _deptService.Put(existingDept);

                if (updatedDept == null)
                {
                    return BadRequest("Failed to update department");
                }

                return Ok(updatedDept);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while updating department");
            }
        }


        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Dept>> Delete(int id)
        {
           

            try
            {
                var Dep = await _deptService.GetById(id);
                if (Dep == null)
                {
                    return BadRequest("Not Found");
                }

                return await _deptService.Delete(id);

            }

            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                   "Error deleting data");
            }
        }

    }
}
