namespace EmployeeManagementSystem.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Manager;
    using Microsoft.AspNetCore.Mvc;
    using Model;

    /// <summary>
    /// Controller class.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        /// <summary>
        /// variable of imanager interface type.
        /// </summary>
        public readonly IManager Manager;

        /// <summary>
        /// Initializes a new instance of the <see cref="ValuesController"/> class.
        /// Parameerized Constructor.
        /// </summary>
        /// <param name="manager"></param>
        public ValuesController(IManager manager)
        {
            this.Manager = manager;
        }

        /// <summary>
        /// method to add employee data.
        /// </summary>
        /// <param name="employee"></param>
        /// <returns>  Updated Employee Data </returns>
        [Route("AddEmployee")]
        [HttpPost]
        public async Task<IActionResult> AddEmployee(Model.EmployeeModel employee)
        {
            var result = await this.Manager.AddEmployee(employee);
            if (result == 1)
            {
                return this.Ok(employee);
            }
            else
            {
                return this.BadRequest();
            }
        }

        /// <summary>
        /// method to get all employees data.
        /// </summary>
        /// <returns> Updated Employee Data </returns>
        [Route("GetAllEmployee")]
        [HttpGet]
        public IEnumerable<EmployeeModel> GetAllEmployees()
        {
            return this.Manager.GetAllEmployees();
        }

        /// <summary>
        /// method to update employee data.
        /// </summary>
        /// <param name="employeeChanges"></param>
        /// <returns> Updated Employee Data </returns>
        [Route("UpdateEmployee")]
        [HttpPut]
        public async Task<IActionResult> UpdateEmployee(EmployeeModel employeeChanges)
        {
            var result = await this.Manager.UpdateEmployee(employeeChanges);
            if (result == 1)
            {
                return this.Ok(employeeChanges);
            }
            else
            {
                return this.BadRequest();
            }
        }

        /// <summary>
        /// method to delete from employee data.
        /// </summary>
        /// <param name="id"></param>
        /// <returns> Updated Employee Data </returns>
        [HttpDelete]
        [Route("DeleteEmployee")]
        public EmployeeModel DeleteEmployee(int id)
        {
            return this.Manager.DeleteEmployee(id);
        }

        /// <summary>
        /// method to get employee data.
        /// </summary>
        /// <param name="id"></param>
        /// <returns> Updated Employee Data </returns>
        [Route("GetEmployee")]
        [HttpGet]
        public EmployeeModel GetEmployee(int id)
        {
            return this.Manager.GetEmployee(id);
        }
    }
}
