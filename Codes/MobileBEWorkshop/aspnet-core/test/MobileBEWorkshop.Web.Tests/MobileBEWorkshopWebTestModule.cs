using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MobileBEWorkshop.EntityFrameworkCore;
using MobileBEWorkshop.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace MobileBEWorkshop.Web.Tests
{
    [DependsOn(
        typeof(MobileBEWorkshopWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class MobileBEWorkshopWebTestModule : AbpModule
    {
        public MobileBEWorkshopWebTestModule(MobileBEWorkshopEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MobileBEWorkshopWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(MobileBEWorkshopWebMvcModule).Assembly);
        }
    }
}