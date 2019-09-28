using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstApp.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {

        private List<Employee> _employeeList;
        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>() {
                new Employee(){Id=1 , Name = "masum" , Department = "IT"},
                new Employee(){Id=2 , Name = "masum2" , Department = "IT2"},
                new Employee(){Id=3 , Name = "masum3" , Department = "IT3"},
            };
        }

        public Employee AddEmployee(Employee employee)
        {
            Employee emp = new Employee() {
                Id = employee.Id,
                Name = employee.Name,
                Department = employee.Department
            };
            _employeeList.Add(emp);
            return emp;
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == id);
        }
    }
}
