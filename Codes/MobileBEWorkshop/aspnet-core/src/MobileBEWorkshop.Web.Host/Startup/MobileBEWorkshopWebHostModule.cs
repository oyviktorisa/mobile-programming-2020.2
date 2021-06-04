using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MobileBEWorkshop.Configuration;

namespace MobileBEWorkshop.Web.Host.Startup
{
    [DependsOn(
       typeof(MobileBEWorkshopWebCoreModule))]
    public class MobileBEWorkshopWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public MobileBEWorkshopWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MobileBEWorkshopWebHostModule).GetAssembly());
        }
    }
}
