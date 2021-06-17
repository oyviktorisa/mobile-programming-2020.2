﻿using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MobileBEWorkshop.Authorization.Roles;
using MobileBEWorkshop.Authorization.Users;
using MobileBEWorkshop.MultiTenancy;
using MobileBEWorkshop.Workshops.Departments;
using MobileBEWorkshop.Workshops.Assignments;

namespace MobileBEWorkshop.EntityFrameworkCore
{
    public class MobileBEWorkshopDbContext : AbpZeroDbContext<Tenant, Role, User, MobileBEWorkshopDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Department> Departments { get; set; }
        public DbSet<Assignment> Assignments { get; set; }
        
        public MobileBEWorkshopDbContext(DbContextOptions<MobileBEWorkshopDbContext> options)
            : base(options)
        {
        }
    }
}
