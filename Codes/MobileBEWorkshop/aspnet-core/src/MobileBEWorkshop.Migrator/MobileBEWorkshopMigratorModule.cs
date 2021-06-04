using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MobileBEWorkshop.Configuration;
using MobileBEWorkshop.EntityFrameworkCore;
using MobileBEWorkshop.Migrator.DependencyInjection;

namespace MobileBEWorkshop.Migrator
{
    [DependsOn(typeof(MobileBEWorkshopEntityFrameworkModule))]
    public class MobileBEWorkshopMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public MobileBEWorkshopMigratorModule(MobileBEWorkshopEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(MobileBEWorkshopMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                MobileBEWorkshopConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MobileBEWorkshopMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
