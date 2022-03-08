using Microsoft.AspNetCore.Mvc;
using StreamsTalk.Application.Interfaces;
using StreamsTalk.Application.ViewModels;
using System;
using System.Threading.Tasks;

namespace StreamsTalk.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeService;
        public EmployeeController(IEmployeeService employeService)
        {
            _employeService = employeService;
        }

        //GET: api/Employee
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var data = await _employeService.GetAll();
            return Ok(data);
        }


        // GET: api/Employee/asdfghjkkl
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(string id)
        {
            try
            {
                if (!await _employeService.EmployeeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    var data = await _employeService.Get(id);
                    return Ok(data);
                }
            }
            catch (Exception)
            {
                throw;
            }

        }

        // PUT: api/Employee/asdfghjkkl
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(string id, EmployeeVm entity)
        {
            if (id != entity.Id)
            {
                return BadRequest();
            }

            try
            {
                if (!await _employeService.EmployeeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    await _employeService.Update(id, entity);
                }
            }
            catch (Exception)
            {
                throw;
            }

            return NoContent();
        }

        // POST: api/Employee
        [HttpPost]
        public async Task<ActionResult> Post(EmployeeVm entity)
        {
            try
            {
                await _employeService.Insert(entity);
                return Ok("successfully created a new Employee!");
            }
            catch (Exception)
            {
                return Ok("Employee creation become unsuccessfull!");
            }
        }

        // DELETE: api/Employee/asdfghjkkl
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(string id)
        {
            try
            {
                if (!await _employeService.EmployeeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    await _employeService.Delete(id);
                }
            }
            catch (Exception)
            {
                throw;
            }

            return NoContent();
        }
    }
}
