namespace Repository.RepoImplementation
{
    using Model;
    using Repository.IRepository;
    using Repository.UserContext;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Repository Implementation class
    /// </summary>
    public class RepoImplement : IRepo
    {
        private readonly UserDbContext userDBContext;

        public RepoImplement(UserDbContext userDBContext)
        {
            this.userDBContext = userDBContext;
        }

        /// <summary>
        /// method to add new employee data
        /// </summary>
        /// <param name="employee"></param>
        /// <returns> Updated Employee Data </returns>
        public Task<int> AddEmployee(EmployeeModel employee)
        {
            userDBContext.Employees.Add(employee);
            var result = userDBContext.SaveChangesAsync();
            return result;
        }

        /// <summary>
        /// method to delete from employee data
        /// </summary>
        /// <param name="id"></param>
        /// <returns> Updated Employee Data </returns>
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

        /// <summary>
        /// method to get all employee's data
        /// </summary>
        /// <returns> Updated Employee Data </returns>
        public IEnumerable<EmployeeModel> GetAllEmployees()
        {
            return userDBContext.Employees;
        }

        /// <summary>
        /// method to get single employee's data
        /// </summary>
        /// <param name="id"></param>
        /// <returns> Updated Employee Data </returns>
        public EmployeeModel GetEmployee(int id)
        {
            return userDBContext.Employees.Find(id);
        }

        /// <summary>
        /// method to update existed employee data
        /// </summary>
        /// <param name="employeeChanges"></param>
        /// <returns> Updated Employee Data </returns>
        public Task<int> UpdateEmployee(EmployeeModel employeeChanges)
        {
            var employee = userDBContext.Employees.Attach(employeeChanges);
            employee.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            var result = userDBContext.SaveChangesAsync();
            return result;
        }
    }
}
