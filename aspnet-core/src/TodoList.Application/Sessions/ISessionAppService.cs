using System.Threading.Tasks;
using Abp.Application.Services;
using TodoList.Sessions.Dto;

namespace TodoList.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
