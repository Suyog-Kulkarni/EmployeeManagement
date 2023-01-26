namespace EmployeeManagement.Models;
public class MockEmployeeRepository : IEmployeeRepository
{
    private readonly List<Employee> _employeeList;

    public MockEmployeeRepository()
    {
        _employeeList = new List<Employee>(4);// initial cap. can be declared
        {
            _ = new Employee() { Id = 1, Name = "Suyog", Email = "a@gmail.com", Department = "IT" };

            _ = new Employee() { Id = 2, Name = "Suyo", Email = "b@gmail.com", Department = "IT" };

            _ = new Employee() { Id = 3, Name = "Suy", Email = "c@gmail.com", Department = "IT" };

            _ = new Employee() { Id = 4, Name = "Suy", Email = "d@gmail.com", Department = "IT" };
        }
        
    }

  
    public Employee GetEmployee(int id)
    {
        return _employeeList.FirstOrDefault(predicate: e => e.Id == id);

    }
    public IEnumerable<Employee> GetAllEmployee() => _employeeList;
}

