namespace EmployeeManagement.Models;
public class MockEmployeeRepository : IEmployeeRepository
{
    private List<Employee> _employeeList;

    public MockEmployeeRepository()
    {
        _employeeList= new List<Employee>();// initial cap. can be declared
        {
            new Employee() { Id = 1, Name = "Suyog", Department = "HR", Email = "a@gmail.com" };
            new Employee() { Id = 2, Name = "suy", Department="IT", Email = "b@gamil.com" };
            new Employee() { Id = 3, Name = "su", Department = "IT", Email = "c@gmail.com" };
        };
    }
    public Employee GetEmployee(int id) => _employeeList.FirstOrDefault(e => e.Id == id);
}

