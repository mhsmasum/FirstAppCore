using FirstApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstApp.DAL
{
    public class EmployeeDal
    {

        public List<Employee> GetAllEmployee()
        {
            List<Employee> _employeeList = new List<Employee>() {
                new Employee(){Id=1 , Name = "masum" , Department = "IT"},
                new Employee(){Id=1 , Name = "masum2" , Department = "IT2"},
                new Employee(){Id=1 , Name = "masum3" , Department = "IT3"},
            };
            return _employeeList;
        }
        
        
    }
}
