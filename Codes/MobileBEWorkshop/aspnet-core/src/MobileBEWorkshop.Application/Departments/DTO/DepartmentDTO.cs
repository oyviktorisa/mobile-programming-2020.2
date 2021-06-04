using System;
using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using MobileBEWorkshop.Workshops.Departments;

namespace MobileBEWorkshop.Departments.DTO
{
    public class DepartmentDTO : EntityDto<Guid>
    {
        [Required]
        [StringLength(50)]
        public string Name {get;set;}
        [Required]
        [StringLength(5)]
        public string Code {get;set;}
        public string Description {get;set;}
        public bool isDeleted {get;set;}
        public long? CreatorUserId { get; set; }
        public DateTime CreationTime { get; set; }
        public long? LastModifierUserId { get; set; }
        public DateTime? LastModificationTime { get; set; }
    }
}