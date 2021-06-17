using System.Globalization;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Abp.Runtime.Session;

namespace MobileBEWorkshop.Workshops.Departments
{
    public class DepartmentManager : IDepartmentManager
    {
        private IRepository<Department, Guid> departmentRepository;
        public IAbpSession session;

        public DepartmentManager(IRepository<Department, Guid> departmentRepository, IAbpSession session)
        {
            this.departmentRepository = departmentRepository;
            this.session = session;
        }

        public async Task CreateDepartmentAsync(Department broadcast)
        {
            await departmentRepository.InsertAsync(new Department 
            {
                Id = broadcast.Id,
                Name = broadcast.Name,
                Code = broadcast.Code,
                Description = broadcast.Description,
                isDeleted = false,
                CreationTime = DateTime.UtcNow,
                CreatorUserId = session.UserId
            });
        }

        public async Task<List<Department>> GetAllDepartmentsAsync()
        {
            return await departmentRepository.GetAllListAsync(x => !x.isDeleted);
        }

        public async Task<Department> GetDepartmentAsync(Guid id)
        {
            return await departmentRepository.GetAsync(id);
        }

        public Task UpdateDepartmentAsync(Department broadcast)
        {
            throw new NotImplementedException();
        }
    }
}