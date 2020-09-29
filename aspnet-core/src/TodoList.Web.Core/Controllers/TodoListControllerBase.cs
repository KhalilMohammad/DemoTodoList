using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace TodoList.Controllers
{
    public abstract class TodoListControllerBase: AbpController
    {
        protected TodoListControllerBase()
        {
            LocalizationSourceName = TodoListConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
