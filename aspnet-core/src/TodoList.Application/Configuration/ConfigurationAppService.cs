using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using TodoList.Configuration.Dto;

namespace TodoList.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : TodoListAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
