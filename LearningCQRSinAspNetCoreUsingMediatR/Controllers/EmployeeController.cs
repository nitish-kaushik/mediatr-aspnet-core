using LearningCQRSinAspNetCoreUsingMediatR.Data;
using LearningCQRSinAspNetCoreUsingMediatR.Models;
using Microsoft.AspNetCore.Mvc;

namespace LearningCQRSinAspNetCoreUsingMediatR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController(IEmployeeService employeeService) : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(employeeService.GetEmployees());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var employee = employeeService.GetEmployee(id);
            if (employee == null)
            {
                return NotFound();
            }
            return Ok(employee);
        }

        [HttpPost("")]
        public IActionResult Post([FromBody]EmployeeDto employee)
        {
            employeeService.AddEmployee(employee);
            return CreatedAtAction(nameof(GetById), new { id = employee.Id }, employee);
        }
    }
}
