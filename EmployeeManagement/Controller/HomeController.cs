using EmployeeManagement.Models;
using EmployeeManagement.ViewModel;
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
        public ViewResult Index()
        {
            IEnumerable<Employee> employees = _employeeRepository.GetAllEmployee();
           return  View(employees);
        }
        public ViewResult Details(int id)
        {
            HomeDetailsViewModel viewModel = new() // we cretae a "View Model" when model object does not contain all the data a view needs
            {
                Employee = _employeeRepository.GetEmployee(id),
                PageTitle = "Employee Details"
            };
            
            return View(viewModel);// have four overloaded versions
        }
    }

}
