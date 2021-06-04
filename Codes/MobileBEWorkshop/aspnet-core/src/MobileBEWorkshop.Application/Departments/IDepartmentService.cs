using System;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Dependency;
using MobileBEWorkshop.Departments.DTO;

namespace MobileBEWorkshop.Departments
{
    public interface IDepartmentService : IApplicationService, ITransientDependency
    {
        public Task<DepartmentDTO> CreateDepartment(DepartmentDTO dto);

        public Task<DepartmentDTO> GetById(Guid id);
    }
}