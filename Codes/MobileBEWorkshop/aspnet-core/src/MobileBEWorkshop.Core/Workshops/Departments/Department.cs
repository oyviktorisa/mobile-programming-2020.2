using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace MobileBEWorkshop.Workshops.Departments
{
    [Table("Workshop_Departments")]
    public class Department : Entity<Guid>, IAudited
    {
        [Required]
        [MaxLength(50)]
        public string Name {get;set;}
        [Required]
        [MaxLength(5)]
        public string Code {get;set;}
        public string Description {get;set;}
        public bool isDeleted {get;set;}
        public long? CreatorUserId { get; set; }
        public DateTime CreationTime { get; set; }
        public long? LastModifierUserId { get; set; }
        public DateTime? LastModificationTime { get; set; }
    }
}
