using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MobileBEWorkshop.Authorization;

namespace MobileBEWorkshop
{
    [DependsOn(
        typeof(MobileBEWorkshopCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class MobileBEWorkshopApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<MobileBEWorkshopAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(MobileBEWorkshopApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
