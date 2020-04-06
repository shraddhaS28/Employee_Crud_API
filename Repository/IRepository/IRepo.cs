using Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.IRepository
{
    public interface IRepo
    {
        /// <summary>
        /// Get Employee's data
        /// </summary>
        /// <param name="id"></param>
        /// <returns> Employee Data</returns>
        EmployeeModel GetEmployee(int id);

        /// <summary>
        /// Get All Employee's data
        /// </summary>
        /// <returns>Employee Data</returns>
        IEnumerable<EmployeeModel> GetAllEmployees();

        /// <summary>
        /// Add Employee's data
        /// </summary>
        /// <param name="employee"></param>
        /// <returns>Employee Data</returns>
        Task<int> AddEmployee(EmployeeModel employee);

        /// <summary>
        /// Update Existing Employee's data
        /// </summary>
        /// <param name="employeeChanges"></param>
        /// <returns>Employee Data</returns>
        Task<int> UpdateEmployee(EmployeeModel employeeChanges);

        /// <summary>
        /// Delete Employee's data
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Employee Data</returns>
        EmployeeModel DeleteEmployee(int id);

        /// <summary>
        /// Employee Login
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        bool LoginEmployee(string email, string password);
    }
}
