namespace Manager
{
    using Model;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Manager Interface 
    /// </summary>
    public interface IManager
    {
        /// <summary>
        /// Get Single Employee's Data
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Employee data</returns>
        EmployeeModel GetEmployee(int id);

        /// <summary>
        /// Get all Employee's Data
        /// </summary>
        /// <returns>Employee data</returns>
        IEnumerable<EmployeeModel> GetAllEmployees();

        /// <summary>
        /// Add Employee's data
        /// </summary>
        /// <param name="employee"></param>
        /// <returns>new data</returns>
        Task<int> AddEmployee(EmployeeModel employee);

        /// <summary>
        /// Update Existing Employee's Data
        /// </summary>
        /// <param name="employeeChanges"></param>
        /// <returns>Employee data</returns>
        Task<int> UpdateEmployee(EmployeeModel employeeChanges);

        /// <summary>
        /// Delete EMployee's data
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Employeee Data</returns>
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
