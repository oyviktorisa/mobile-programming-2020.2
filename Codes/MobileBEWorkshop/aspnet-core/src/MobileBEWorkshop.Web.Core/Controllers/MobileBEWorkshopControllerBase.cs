using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace MobileBEWorkshop.Controllers
{
    public abstract class MobileBEWorkshopControllerBase: AbpController
    {
        protected MobileBEWorkshopControllerBase()
        {
            LocalizationSourceName = MobileBEWorkshopConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
