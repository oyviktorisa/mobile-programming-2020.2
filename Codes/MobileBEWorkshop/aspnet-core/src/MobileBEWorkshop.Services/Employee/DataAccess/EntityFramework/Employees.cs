using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Employee.DataAccess.EntityFramework
{
    public partial class Employees
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string EmployeeNumber { get; set; }
        public DateTime? HireDate { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModified { get; set; }
        public string LastModifiedBy { get; set; }
    }
}
