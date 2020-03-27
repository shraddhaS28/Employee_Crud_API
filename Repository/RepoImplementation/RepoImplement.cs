using Model;
using Repository.IRepository;
using Repository.UserContext;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.RepoImplementation
{
    public class RepoImplement : IRepo
    {
        private readonly UserDbContext userDBContext;

        public RepoImplement(UserDbContext userDBContext)
        {
            this.userDBContext = userDBContext;
        }
        public EmployeeModel AddEmployee(EmployeeModel employee)
        {
            userDBContext.Employees.Add(employee);
            userDBContext.SaveChanges();
            return employee;
        }

        public EmployeeModel DeleteEmployee(int id)
        {
            EmployeeModel employee = userDBContext.Employees.Find(id);
            if (employee != null)
            {
                userDBContext.Employees.Remove(employee);
                userDBContext.SaveChanges();
            }
            return employee;

        }

        public IEnumerable<EmployeeModel> GetAllEmployees()
        {
            return userDBContext.Employees;
        }

        public EmployeeModel GetEmployee(int id)
        {
            return userDBContext.Employees.Find(id);
        }

        public EmployeeModel UpdateEmployee(EmployeeModel employeeChanges)
        {
            var employee = userDBContext.Employees.Attach(employeeChanges);
            employee.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            userDBContext.SaveChanges();
            return employeeChanges;
        }
    }
}
