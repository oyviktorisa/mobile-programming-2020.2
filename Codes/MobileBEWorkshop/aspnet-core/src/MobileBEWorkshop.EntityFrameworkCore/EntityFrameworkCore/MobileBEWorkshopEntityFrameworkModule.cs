using Abp.EntityFrameworkCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Zero.EntityFrameworkCore;
using MobileBEWorkshop.EntityFrameworkCore.Seed;

namespace MobileBEWorkshop.EntityFrameworkCore
{
    [DependsOn(
        typeof(MobileBEWorkshopCoreModule), 
        typeof(AbpZeroCoreEntityFrameworkCoreModule))]
    public class MobileBEWorkshopEntityFrameworkModule : AbpModule
    {
        /* Used it tests to skip dbcontext registration, in order to use in-memory database of EF Core */
        public bool SkipDbContextRegistration { get; set; }

        public bool SkipDbSeed { get; set; }

        public override void PreInitialize()
        {
            if (!SkipDbContextRegistration)
            {
                Configuration.Modules.AbpEfCore().AddDbContext<MobileBEWorkshopDbContext>(options =>
                {
                    if (options.ExistingConnection != null)
                    {
                        MobileBEWorkshopDbContextConfigurer.Configure(options.DbContextOptions, options.ExistingConnection);
                    }
                    else
                    {
                        MobileBEWorkshopDbContextConfigurer.Configure(options.DbContextOptions, options.ConnectionString);
                    }
                });
            }
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MobileBEWorkshopEntityFrameworkModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            if (!SkipDbSeed)
            {
                SeedHelper.SeedHostDb(IocManager);
            }
        }
    }
}
