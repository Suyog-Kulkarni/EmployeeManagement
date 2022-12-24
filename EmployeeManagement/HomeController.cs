using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Hello from home";
        }
    }
}
