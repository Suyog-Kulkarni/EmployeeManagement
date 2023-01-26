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
            return View(_employeeRepository.GetAllEmployee());
        }
        public ViewResult Details()
        {
            HomeDetailsViewModel viewModel = new() // we cretae a "View Model" when model object does not contain all the data a view needs
            {
                Employee = _employeeRepository.GetEmployee(1),
                PageTitle = "Employee Details"
            };
            
            return View(viewModel);// have four overloaded versions
        }
    }

}
