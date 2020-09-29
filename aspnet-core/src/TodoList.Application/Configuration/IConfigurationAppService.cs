using System.Threading.Tasks;
using TodoList.Configuration.Dto;

namespace TodoList.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
