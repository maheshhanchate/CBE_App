using System.Threading.Tasks;
using Abp.Application.Services;
using CBEApp.Configuration.Dto;

namespace CBEApp.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}