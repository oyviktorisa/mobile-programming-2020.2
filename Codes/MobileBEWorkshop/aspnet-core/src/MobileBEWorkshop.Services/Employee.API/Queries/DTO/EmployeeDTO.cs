using System;

namespace Employee.API.Queries.EmployeeDraftDTO
{
    public class EmployeeDTO
    {
        public Guid Id {get;set;}
        public string Name {get;set;}
        public string EmpNumber {get;set;}
        public DateTime HireDate {get;set;}
    }
}