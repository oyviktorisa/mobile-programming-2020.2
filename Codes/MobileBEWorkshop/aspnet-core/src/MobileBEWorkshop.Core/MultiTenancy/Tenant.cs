using Abp.MultiTenancy;
using MobileBEWorkshop.Authorization.Users;

namespace MobileBEWorkshop.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
