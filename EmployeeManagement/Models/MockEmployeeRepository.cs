namespace EmployeeManagement.Models;
public class MockEmployeeRepository : IEmployeeRepository
{
    private List<Employee> _employeeList;

    public MockEmployeeRepository()
    {
        _employeeList = new();// initial cap. can be declared
        {
            _ = new Employee() { Id = 1, Name = "Suyog", Email = "a@gmail.com", Department = "IT" };

            _ = new Employee() { Id = 2, Name = "Suyo", Email = "b@gmail.com", Department = "IT" };

            _ = new Employee() { Id = 3, Name = "Suy", Email = "c@gmail.com", Department = "IT" };

            _ = new Employee() { Id = 4, Name = "Suy", Email = "d@gmail.com", Department = "IT" };
        }

    }

  
    public Employee GetEmployee(int id)
    {
        if (_employeeList.FirstOrDefault(predicate: e => e.Id == id) is not null)
        {  

            _employeeList.Add(new Employee { });

            _employeeList.Add(new Employee { Id = 1, Name = "Suyog", Email = "a@gmail.com", Department = "IT" });

            _employeeList.Add(new Employee { Id = 2, Name = "Suyo", Email = "b@gmail.com", Department = "IT" });

            _employeeList.Add(new Employee { Id = 3, Name = "Suy", Email = "c@gmail.com", Department = "IT" });

            _employeeList.Add(new Employee { Id = 4, Name = "Suy", Email = "d@gmail.com", Department = "IT" });

            return _employeeList[id];
        }
        return _employeeList[id];
    }
    public IEnumerable<Employee> GetAllEmployee() {

    
/*
        for(int i =1;i<=_employeeList.Count;i++)
        {
            GetEmployee(i);
        }
        */
        return _employeeList;
     }

   
}

