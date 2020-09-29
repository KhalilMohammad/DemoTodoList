using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TodoList.Authorization;

namespace TodoList
{
    [DependsOn(
        typeof(TodoListCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class TodoListApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<TodoListAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(TodoListApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
