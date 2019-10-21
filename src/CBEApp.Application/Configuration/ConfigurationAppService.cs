using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using CBEApp.Configuration.Dto;

namespace CBEApp.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : CBEAppAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
