using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.IRepository
{
    public interface IRepo
    {
        EmployeeModel GetEmployee(int id);
        IEnumerable<EmployeeModel> GetAllEmployees();
        EmployeeModel AddEmployee(EmployeeModel employee);
        EmployeeModel UpdateEmployee(EmployeeModel employeeChanges);
        EmployeeModel DeleteEmployee(int id);
    }
}
