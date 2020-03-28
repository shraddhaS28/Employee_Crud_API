namespace Manager
{
    using Model;
    using Repository.IRepository;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Manager Implementation class
    /// </summary>
    public class ManagerImplementation : IManager
    {
        private readonly IRepo repo;

        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="repo"></param>
        public ManagerImplementation(IRepo repo)
        {
            this.repo = repo;
        }

        /// <summary>
        /// method to add new employee data
        /// </summary>
        /// <param name="employee"></param>
        /// <returns> Updated Employee Data </returns>
        public Task<int> AddEmployee(EmployeeModel employee)
        {
            return this.repo.AddEmployee(employee);
        }

        /// <summary>
        ///  method to delete from employee data
        /// </summary>
        /// <param name="id"></param>
        /// <returns> Updated Employee Data </returns>
        public EmployeeModel DeleteEmployee(int id)
        {
            return this.repo.DeleteEmployee(id);
        }

        /// <summary>
        /// method to get all employee's data
        /// </summary>
        /// <returns> Updated Employee Data </returns>
        public IEnumerable<EmployeeModel> GetAllEmployees()
        {
            return this.repo.GetAllEmployees();
        }

        /// <summary>
        /// method to get single employee's data.
        /// </summary>
        /// <param name="id"></param>
        /// <returns> Updated Employee Data </returns>
        public EmployeeModel GetEmployee(int id)
        {
            return this.repo.GetEmployee(id);
        }

        /// <summary>
        /// method to update existed employee data.
        /// </summary>
        /// <param name="employeeChanges"></param>
        /// <returns> Updated Employee Data </returns>
        public Task<int> UpdateEmployee(EmployeeModel employeeChanges)
        {
            return this.repo.UpdateEmployee(employeeChanges);
        }
    }
}
