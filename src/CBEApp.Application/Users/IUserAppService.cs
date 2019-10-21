using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using CBEApp.Roles.Dto;
using CBEApp.Users.Dto;

namespace CBEApp.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}