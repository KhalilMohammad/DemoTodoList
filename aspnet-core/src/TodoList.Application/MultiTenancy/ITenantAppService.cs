using Abp.Application.Services;
using TodoList.MultiTenancy.Dto;

namespace TodoList.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

