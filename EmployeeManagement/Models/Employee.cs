using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Models;
public class Employee : Controller
{
    public Employee(int id, string? name, string? email, string? department)
    {
        Id = id;
        Name = name;
        Email = email;
        Department = department;
    }

    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Email { get; set; }
    public string? Department { get; set; }

}

