using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using MobileBEWorkshop.Configuration;
using MobileBEWorkshop.Web;

namespace MobileBEWorkshop.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class MobileBEWorkshopDbContextFactory : IDesignTimeDbContextFactory<MobileBEWorkshopDbContext>
    {
        public MobileBEWorkshopDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<MobileBEWorkshopDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            MobileBEWorkshopDbContextConfigurer.Configure(builder, configuration.GetConnectionString(MobileBEWorkshopConsts.ConnectionStringName));

            return new MobileBEWorkshopDbContext(builder.Options);
        }
    }
}
