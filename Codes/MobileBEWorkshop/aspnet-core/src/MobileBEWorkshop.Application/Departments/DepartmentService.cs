using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.UI;
using MobileBEWorkshop.Departments.DTO;
using MobileBEWorkshop.Workshops.Departments;
using Nito.AsyncEx;

namespace MobileBEWorkshop.Departments
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentManager departmentManager;

        public DepartmentService(IDepartmentManager departmentManager)
        {
            this.departmentManager = departmentManager;
        }

        public async Task<DepartmentDTO> CreateDepartment(DepartmentDTO dto)
        {
            dto.Id = Guid.NewGuid();
            await departmentManager.CreateDepartmentAsync(new Department
            {
                Id = dto.Id,
                Name = dto.Name,
                Code = dto.Code,
            });

            return dto;
        }

        public async Task<List<DepartmentDTO>> GetAll()
        {
            var result = await departmentManager.GetAllDepartmentsAsync(); 

            return result.Select(x => new DepartmentDTO
            {
                Id = x.Id,
                Name = x.Name,
                Code = x.Code
            }).ToList();
        }

        public async Task<DepartmentDTO> GetById(Guid id)
        {
            var result = await departmentManager.GetDepartmentAsync(id);

            if(result==null)
                throw new UserFriendlyException("Not found");
            
            return new DepartmentDTO
            {
                Id = result.Id,
                Name = result.Name,
                Code = result.Code
            };
        }
    }
}