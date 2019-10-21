using Abp.Application.Services;
using Abp.Application.Services.Dto;
using CBEApp.MultiTenancy.Dto;

namespace CBEApp.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
