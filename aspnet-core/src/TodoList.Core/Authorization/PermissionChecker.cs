using Abp.Authorization;
using TodoList.Authorization.Roles;
using TodoList.Authorization.Users;

namespace TodoList.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
