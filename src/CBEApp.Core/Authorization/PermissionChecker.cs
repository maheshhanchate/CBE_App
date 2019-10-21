using Abp.Authorization;
using CBEApp.Authorization.Roles;
using CBEApp.Authorization.Users;

namespace CBEApp.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
