using EmployeeManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.NewFolder
{
  
    public class HomeController : Controller
    {
        private IEmployeeRepository _employeeRepository;
        // constructor injection
        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public string Index()
        {
           
            return _employeeRepository.GetEmployee(1).Name;
        }
    }
}
