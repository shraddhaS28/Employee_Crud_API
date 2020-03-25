namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Text;

    /// <summary>
    /// model class to get employee data
    /// </summary>
    public class EmployeeModel
    {
        /// <summary>
        /// Employee's Email
        /// </summary>
        private string email;

        /// <summary>
        /// Employee's Password
        /// </summary>
        private string password;

        /// <summary>
        /// Employee's Id
        /// </summary>
        private int empId;

        /// <summary>
        /// Employee's Mobile
        /// </summary>
        private string mobile;

        /// <summary>
        /// Employee's Address
        /// </summary>
        private string address;

        /// <summary>
        /// Specifies how database generates values for a property
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int EmpId
        {
            get
            {
                return this.empId;
            }
            set
            {
                this.empId = value;
            }
        }
        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                this.email = value;
            }
        }
        public string Password
        {
            get
            {
                return this.password;
            }
            set
            {
                this.password = value;
            }
        }
        public string Mobile
        {
            get
            {
                return this.mobile;
            }
            set
            {
                this.mobile = value;
            }
        }
        public string Address
        {
            get
            {
                return this.address;
            }
            set
            {
                this.address = value;
            }
        }
    }
}
