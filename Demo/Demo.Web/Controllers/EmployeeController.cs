using Demo.Web.Service;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(
           IEmployeeService employeeService)
          : base()
        {
            _employeeService = employeeService;
        }
        [HttpGet]
        [Route("GetEmployee")]
        public async Task<IActionResult> GetEmployee()
        {
            return Ok(await _employeeService.GetAll());
        }

    }
}
