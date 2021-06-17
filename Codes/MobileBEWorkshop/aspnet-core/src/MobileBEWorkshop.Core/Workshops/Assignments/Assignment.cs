using System;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace MobileBEWorkshop.Workshops.Assignments
{
    [Table("Workshop_Assignments")]
    public class Assignment : Entity<Guid>, IAudited
    {
        public string Name{get;set;}
        public bool IsDeleted{get;set;}
        public long? CreatorUserId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime CreationTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public long? LastModifierUserId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime? LastModificationTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}