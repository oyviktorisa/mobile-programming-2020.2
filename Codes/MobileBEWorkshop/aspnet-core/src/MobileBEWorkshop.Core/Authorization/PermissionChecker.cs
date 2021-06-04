using Abp.Authorization;
using MobileBEWorkshop.Authorization.Roles;
using MobileBEWorkshop.Authorization.Users;

namespace MobileBEWorkshop.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
