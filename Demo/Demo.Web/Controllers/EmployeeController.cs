using Demo.Web.Service;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Web.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(
           IEmployeeService employeeService)
          : base()
        {
            _employeeService = employeeService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> List()
        {
            var data = await _employeeService.GetAll();
            return PartialView(data);
        }
    }
}
