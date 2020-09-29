using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TodoList.EntityFrameworkCore;
using TodoList.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace TodoList.Web.Tests
{
    [DependsOn(
        typeof(TodoListWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class TodoListWebTestModule : AbpModule
    {
        public TodoListWebTestModule(TodoListEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TodoListWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(TodoListWebMvcModule).Assembly);
        }
    }
}