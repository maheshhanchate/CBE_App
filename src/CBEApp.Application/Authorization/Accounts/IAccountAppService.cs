using System.Threading.Tasks;
using Abp.Application.Services;
using CBEApp.Authorization.Accounts.Dto;

namespace CBEApp.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
