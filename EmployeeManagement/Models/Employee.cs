using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Models;
public class Employee : Controller
{


    public int Id { get; set; }
    public string? Name { get; set; } 
    public string? Email { get; set; } 
    public string? Department { get; set; } 

}

