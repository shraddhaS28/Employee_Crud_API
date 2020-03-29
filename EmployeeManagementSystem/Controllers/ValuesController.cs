namespace EmployeeManagementSystem.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Manager;
    using Microsoft.AspNetCore.Mvc;
    using Model;
    using Serilog;

    /// <summary>
    /// Controlleer class route the project to access database.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        /// <summary>
        /// variable of imanager interface type.
        /// </summary>
        private readonly IManager manager;

        /// <summary>
        /// Initializes a new instance of the <see cref="ValuesController"/> class.
        /// Parameerized Constructor.
        /// </summary>
        /// <param name="manager"></param>
        public ValuesController(IManager manager)
        {
            this.manager = manager;
        }

        /// <summary>
        /// Method to add employee data.
        /// </summary>
        /// <param name="employee"></param>
        /// <returns>  Updated Employee Data. </returns>
        [Route("AddEmployee")]
        [HttpPost]
        public async Task<IActionResult> AddEmployee(Model.EmployeeModel employee)
        {
            var result = await this.manager.AddEmployee(employee);
            if (result == 1)
            {
                return this.Ok(employee);
            }
            else
            {
                return this.BadRequest();
                Log.Error("BadRequest, Provide Correct Infomation of Employee");
            }
        }

        /// <summary>
        /// Method to get all employees data.
        /// </summary>
        /// <returns> Updated Employee Data </returns>
        [Route("GetAllEmployee")]
        [HttpGet]
        public IEnumerable<EmployeeModel> GetAllEmployees()
        {
            return this.manager.GetAllEmployees();
            Log.Information("Method will show all the employee data saved in the DataBase");
        }

        /// <summary>
        /// Method to update employee data.
        /// </summary>
        /// <param name="employeeChanges"></param>
        /// <returns> Updated Employee Data </returns>
        [Route("UpdateEmployee")]
        [HttpPut]
        public async Task<IActionResult> UpdateEmployee(EmployeeModel employeeChanges)
        {
            var result = await this.manager.UpdateEmployee(employeeChanges);
            if (result == 1)
            {
                return this.Ok(employeeChanges);
            }
            else
            {
                return this.BadRequest();
                Log.Error("Bad Request, Provide Correct employee Data to be updated");
            }
        }

        /// <summary>
        /// Method to delete from employee data.
        /// </summary>
        /// <param name="id"></param>
        /// <returns> Updated Employee Data </returns>
        [HttpDelete]
        [Route("DeleteEmployee")]
        public EmployeeModel DeleteEmployee(int id)
        {
            return this.manager.DeleteEmployee(id);
            Log.Information("Method will Delete data of one employee using employee id");
        }

        /// <summary>
        /// Method to get employee data.
        /// </summary>
        /// <param name="id"></param>
        /// <returns> Updated Employee Data </returns>
        [Route("GetEmployee")]
        [HttpGet]
        public EmployeeModel GetEmployee(int id)
        {
            return this.manager.GetEmployee(id);
            Log.Information("Method will show data of one employee using employee id");
        }
    }
}
