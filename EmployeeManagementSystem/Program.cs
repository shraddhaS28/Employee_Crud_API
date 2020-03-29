namespace EmployeeManagementSystem
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;
    using EmployeeManagementSystem.Controllers;
    using Microsoft.AspNetCore;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.Logging;
    using Serilog;

    /// <summary>
    /// Program file of EmployeeManagement System.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// main method of the class.
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
            Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .WriteTo.Console()
            .WriteTo.File(@"C:\Users\bittu\source\repos\Employee_Crud_API\EmployeeManagementSystem\Controllers\LogFile.txt", rollingInterval: RollingInterval.Day)
            .CreateLogger();
        }

        /// <summary>
        /// method to call startup class.
        /// </summary>
        /// <param name="args"></param>
        /// <returns> Employeee data</returns>
        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
