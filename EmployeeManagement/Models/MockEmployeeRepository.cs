namespace EmployeeManagement.Models;
public class MockEmployeeRepository : IEmployeeRepository
{
    private readonly List<Employee> _employeeList;

    public MockEmployeeRepository()
    {
        _employeeList= new List<Employee>();// initial cap. can be declared
        {
            _ = new Employee() { Id = 1, Name = "Suyog", Email = "a@gmail.com", Department = "IT" };

            _ = new Employee() { Id = 2, Name = "Suyo", Email = "b@gmail.com", Department = "IT" };

            _ = new Employee() { Id = 3, Name = "Suy", Email = "c@gmail.com", Department = "IT" };

            _  =  new Employee() { Id = 4, Name = "Suy", Email = "d@gmail.com", Department = "IT" };
        }
    }
    public Employee GetEmployee(int Id)
    {
        return _employeeList.SingleOrDefault(e => e.Id == Id);

    }
    public IEnumerable<Employee> GetAllEmployee() => _employeeList;
}

