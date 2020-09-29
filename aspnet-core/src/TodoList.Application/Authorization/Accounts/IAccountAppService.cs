using System.Threading.Tasks;
using Abp.Application.Services;
using TodoList.Authorization.Accounts.Dto;

namespace TodoList.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
