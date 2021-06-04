using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Services;

namespace MobileBEWorkshop.Workshops.Departments
{
    public interface IDepartmentManager : IDomainService
    {
        Task CreateDepartmentAsync(Department broadcast);
        Task UpdateDepartmentAsync(Department broadcast);
        Task<Department> GetDepartmentAsync(Guid id);
        Task<List<Department>> GetAllDepartmentsAsync();
    }
}