using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace MobileBEWorkshop.EntityFrameworkCore
{
    public static class MobileBEWorkshopDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<MobileBEWorkshopDbContext> builder, string connectionString)
        {
            builder.UseMySql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<MobileBEWorkshopDbContext> builder, DbConnection connection)
        {
            builder.UseMySql(connection);
        }
    }
}
