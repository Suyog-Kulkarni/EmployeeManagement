using EmployeeManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.NewFolder
{
  
    public class HomeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;
        // constructor injection
        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public string? Index()
        {
            return "suuuiiii";
        }
        public IActionResult Details()
        {
            Employee model = _employeeRepository.GetEmployee(1);
            return View(model);// have four overloaded versions
        }
    }

}
